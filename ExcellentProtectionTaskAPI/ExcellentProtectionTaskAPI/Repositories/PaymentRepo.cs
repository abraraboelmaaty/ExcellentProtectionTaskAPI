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
                            //Order? newOrder = _db.Orders.FirstOrDefault(o => o.Id == orders[i].Id);
                            //newOrder.Price = orders[i].Price;
                            //newOrder.Price = orders[i].Price;
                            //newOrder.Price = orders[i].Price;
                            //newOrder.Price = orders[i].Price;
                            //rows = _db.SaveChanges();
                            //_db.Update(orders[i]);
                            //rows = _db.SaveChanges();
                            //    if(i == 0)
                            //        newAmmount += ( payment.Ammount);
                            //    else
                            //        newAmmount += orders[i].Paid;
                            //    paidAmmount = payment.Ammount - newAmmount;
                            //if (paidAmmount <= 0 || payment.Ammount == orders[i].TotalPrice)
                            //    break;
                            //Payment? newPayment = _db.Payments.FirstOrDefault(p=>p.Id == payment.Id);
                            //newPayment.Ammount = payment.Ammount;
                            //newPayment.Date = payment.Date;
                            //rows = _db.SaveChanges();

                            return rows;
                        }
                        //else if (payment.Ammount > orders[0].TotalPrice)
                        //{
                        //    if (i == 0)
                        //        newAmmount += (payment.Ammount);
                        //    else
                        //        newAmmount += orders[i].Paid;
                        //    paidAmmount = payment.Ammount - newAmmount;
                        //}
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
        //public int Create(Payment payment)
        //{
        //    try
        //    {
        //        List<Order>? orders = _db.Orders.Where(o => o.status == "partialPaid" || o.status == "NotPaid").ToList();
        //        int orderCount = orders.Count;
        //        if (orders.Count == 0)
        //        {
        //            string message = "There is No Orders to paid for";
        //            throw new InvalidOperationException(message);
        //        }
        //        else
        //        {
        //            int rows = 0;
        //            _db.Add(payment);
        //            rows = _db.SaveChanges();

        //            double? newAmmount = 0;
        //            double? paidAmmount = 0;
        //            for (int i = 0; i < orderCount; i++)
        //            {

        //                if (payment.Ammount <= orders[i].TotalPrice)
        //                {
        //                    OrderPayment orderPayment = new OrderPayment() { OrderId = orders[i].Id, PaymentId = payment.Id };
        //                    _db.Add(orderPayment);
        //                    rows = _db.SaveChanges();
        //                    payment.Paid = payment.Ammount;
        //                    rows = _db.SaveChanges();
        //                    //Order? newOrder = _db.Orders.FirstOrDefault(o => o.Id == orders[i].Id);
        //                    //newOrder.Price = orders[i].Price;
        //                    //newOrder.Price = orders[i].Price;
        //                    //newOrder.Price = orders[i].Price;
        //                    //newOrder.Price = orders[i].Price;
        //                    //rows = _db.SaveChanges();
        //                    //_db.Update(orders[i]);
        //                    //rows = _db.SaveChanges();
        //                    //    if(i == 0)
        //                    //        newAmmount += ( payment.Ammount);
        //                    //    else
        //                    //        newAmmount += orders[i].Paid;
        //                    //    paidAmmount = payment.Ammount - newAmmount;
        //                    //if (paidAmmount <= 0 || payment.Ammount == orders[i].TotalPrice)
        //                    //    break;
        //                    //Payment? newPayment = _db.Payments.FirstOrDefault(p=>p.Id == payment.Id);
        //                    //newPayment.Ammount = payment.Ammount;
        //                    //newPayment.Date = payment.Date;
        //                    //rows = _db.SaveChanges();

        //                    return rows;
        //                }
        //                else if (payment.Ammount > orders[0].TotalPrice)
        //                {
        //                    OrderPayment orderPayment = new OrderPayment() { OrderId = orders[i].Id, PaymentId = payment.Id };
        //                    _db.Add(orderPayment);
        //                    rows = _db.SaveChanges();
        //                    payment.Paid = payment.Ammount - (payment.Ammount - orders[i].TotalPrice).Value;
        //                    payment.Rest = payment.Ammount - _db.Payments.Where(p => p.Id == payment.Id).Sum(p => p.Paid);
        //                    rows = _db.SaveChanges();
        //                    //if (i == 0)
        //                    //    newAmmount += (payment.Ammount);
        //                    //else
        //                    //    newAmmount += orders[i].Paid;
        //                    //paidAmmount = payment.Ammount - newAmmount;
        //                    if (payment.Rest <= 0)
        //                        break;
        //                }
        //                else
        //                {
        //                    break;
        //                }
        //            }
        //            return rows;

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new InvalidOperationException(ex.InnerException.ToString());

        //    }


        //}

        public ICollection<Payment> GetAll()
        {
            return _db.Payments.ToList();
        }
    }
}
