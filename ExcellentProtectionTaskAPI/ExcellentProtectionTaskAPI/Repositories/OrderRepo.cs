using ExcellentProtectionTaskAPI.Data;
using ExcellentProtectionTaskAPI.Models;

namespace ExcellentProtectionTaskAPI.Repositories
{
    public class OrderRepo : IRepository<Order>
    {
        private readonly Entites _db;
        public OrderRepo(Entites db)
        {
            _db = db;
        }
        public int Create(Order order)
        {
            _db.Add(order);
            try
            {
                int rows = _db.SaveChanges();
                return rows;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.InnerException.ToString());
            }



        }

        public ICollection<Order> GetAll()
        {
            return _db.Orders.ToList();
        }
    }
}
