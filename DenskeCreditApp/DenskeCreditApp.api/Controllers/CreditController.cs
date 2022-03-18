using DenskeCreditApp.api.Services;
using DenskeCreditApp.api.Services.ResponceModel;
using Microsoft.AspNetCore.Mvc;

namespace DenskeCreditApp.api.Controllers
{
    public class CreditController : Controller
    {
        private readonly IServices _services;
        public CreditController(IServices services)
        {
            _services = services;
        }
        [HttpGet]
        public IActionResult CreditReport(double applliedAmount)
        {
            CreditResponceModel result = _services.GetCreditDetails(applliedAmount);
            return Ok(result);
        }
    }
}
