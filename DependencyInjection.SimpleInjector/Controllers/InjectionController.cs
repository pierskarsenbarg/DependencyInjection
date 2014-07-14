using System.Web.Mvc;
using DependencyInjection.Common.Interfaces;

namespace DependencyInjection.SimpleInjector.Controllers
{
    public class InjectionController : Controller
    {
        private readonly IOutput _output;

        public InjectionController(IOutput output)
        {
            _output = output;
        }
        // GET: Injection
        public ActionResult Index()
        {
            ViewBag.Object = _output.TextToWrite();
            return View();
        }
    }
}