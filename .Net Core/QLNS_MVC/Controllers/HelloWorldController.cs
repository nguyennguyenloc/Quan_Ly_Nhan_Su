using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QLNS_MVC.Models;
namespace QLNS_MVC.Controllers {
    public class HelloWorldController : Controller {
        //
        //Get: /HelloWorld/
        public IActionResult Index () {
            return View ();
        }

        //
        //Get: /HelloWorld/Welcome
        public string Welcome () {
            return "This is the Welcome....";
        }
    }
}