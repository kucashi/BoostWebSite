using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Boosting.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Sent()
        {
            return View();
        }
    }
}