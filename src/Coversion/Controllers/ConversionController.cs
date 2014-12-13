using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conversion.Controllers
{
    public class ConversionController : Controller
    {
        public ActionResult UnixTime()
        {
            return View();
        }

        public ActionResult Length()        
        {           
            return View();
        }

        public ActionResult Md5()
        {
            return View();
        }
    }
}
