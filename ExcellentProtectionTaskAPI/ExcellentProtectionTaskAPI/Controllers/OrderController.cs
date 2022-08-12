using ExcellentProtectionTaskAPI.Models;
using ExcellentProtectionTaskAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExcellentProtectionTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IRepository<Order> orderRepo;
        public OrderController(IRepository<Order> _orderRepo)
        {
            orderRepo = _orderRepo;
        }
        [HttpPost]
        public ActionResult Add(Order order)
        {
            orderRepo.Create(order);
            return Created("uri", order);
        }
        [HttpGet]
        public ActionResult getAll()
        {
            if (orderRepo.GetAll().Count > 0)
                return Ok(orderRepo.GetAll());
            else
                return NotFound();
        }
    }
}
