using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInjection.Common.Classes;
using DependencyInjection.Common.Interfaces;

namespace DependencyInjection.Basic.Controllers
{
    public class InjectionController : Controller
    {
        private IOutput _output;

        public InjectionController(IOutput output)
        {
            _output = output;
        }

        public InjectionController() : this(new Class2())
        {
        }

        // GET: Injection
        public ActionResult Index()
        {
            ViewBag.Object = _output.TextToWrite();
            return View();
        }
    }
}