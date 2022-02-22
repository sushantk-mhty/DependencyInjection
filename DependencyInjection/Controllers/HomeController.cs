using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        ITransientService _transientService1;
        ITransientService _transientService2;

        IScopedService _scopedService1;
        IScopedService _scopedService2;

        ISingletonService _singletonService1;
        ISingletonService _singletonService2;
        public HomeController(ITransientService transientService1,
                           ITransientService transientService2,
                           IScopedService scopedService1,
                          IScopedService scopedService2,
                           ISingletonService singletonService1,
                      ISingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {

            ViewBag.transient1 = "First Instance " + _transientService1.GetID().ToString();
            ViewBag.transient2 = "Second Instance " + _transientService2.GetID().ToString();


            ViewBag.scoped1 = "First Instance " + _scopedService1.GetID().ToString();
            ViewBag.scoped2 = "Second Instance " + _scopedService2.GetID().ToString();

            ViewBag.singleton1 = "First Instance " + _singletonService1.GetID().ToString();
            ViewBag.singleton2 = "Second Instance " + _singletonService2.GetID().ToString();

            ViewBag.transient1 =  _transientService1.GetID().ToString();
            ViewBag.transient2 =  _transientService2.GetID().ToString();


            ViewBag.scoped1 =  _scopedService1.GetID().ToString();
            ViewBag.scoped2 = _scopedService2.GetID().ToString();

            ViewBag.singleton1 =  _singletonService1.GetID().ToString();
            ViewBag.singleton2 =  _singletonService2.GetID().ToString();
            return View();
        }

    }
}