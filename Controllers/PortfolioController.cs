using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class PortfolioController : Controller
    { 
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
           
            return View("Index");
            //Both of these returns will render the same view (You only need one!)
        }
    }
}