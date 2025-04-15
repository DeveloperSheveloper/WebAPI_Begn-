using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Threading.Tasks;
using LoginAPI.Models;

namespace LoginAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
             return View();
        }

        public async Task<ActionResult> UserAuthentication(LoginModel model)
        {
            
            return View();
        }
    }
}