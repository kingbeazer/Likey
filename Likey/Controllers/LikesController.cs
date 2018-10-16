using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Likey.Controllers
{
    public class LikesController : Controller
    {
        // GET: Likes
        public ActionResult Index()
        {
            return View();
        }
    }
}