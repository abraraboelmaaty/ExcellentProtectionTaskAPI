using ExcellentProtectionTaskAPI.Data;
using ExcellentProtectionTaskAPI.Models;

namespace ExcellentProtectionTaskAPI.Repositories
{
    public class PaymentRepo : IRepository<Payment>
    {
        private readonly Entites _db;
        public PaymentRepo(Entites db)
        {
            _db = db;
        }
        public int Create(Payment payment)
        {
            try
            {
                List<Order>? orders = _db.Orders.Where(o => o.status == "partialPaid" || o.status == "NotPaid").ToList();
                int orderCount = orders.Count;
                if (orders.Count == 0)
                {
                    string message = "There is No Orders to paid for";
                    throw new InvalidOperationException(message);
                }
                else
                {
                    int rows = 0;
                    _db.Add(payment);
                    rows = _db.SaveChanges();
                    double? newAmmount = 0;
                    double? paidAmmount = 0;
                    for (int i = 0; i < orderCount; i++)
                    {

                        if (payment.Ammount <= orders[i].TotalPrice)
                        {
                            OrderPayment orderPayment = new OrderPayment() { OrderId = orders[i].Id, PaymentId = payment.Id };
                            _db.Add(orderPayment);
                            rows = _db.SaveChanges();
                           
                        

                            return rows;
                        }
                      
                        else
                        {
                            break;
                        }
                    }
                    return rows;

                }

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.InnerException.ToString());

            }


        }
      

        public ICollection<Payment> GetAll()
        {
            return _db.Payments.ToList();
        }
    }
}
