using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bitcoin.com.au.Controllers
{
    public class NavController : Controller
    {
        //
        // GET: /Nav/

        public ActionResult Menu()
        {
            return View();
        }

    }
}
