using ExcellentProtectionTaskAPI.Models;
using ExcellentProtectionTaskAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExcellentProtectionTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        IRepository<Payment> paymentRepo;
        public PaymentController(IRepository<Payment> _paymentRepo)
        {
            paymentRepo = _paymentRepo;
        }
        [HttpPost]
        public ActionResult Add(Payment payment)
        {
            paymentRepo.Create(payment);
            return Created("uri", payment);
        }
        [HttpGet]
        public ActionResult getAll()
        {
            if (paymentRepo.GetAll().Count > 0)
                return Ok(paymentRepo.GetAll());
            else
                return NotFound();
        }
    }
}
