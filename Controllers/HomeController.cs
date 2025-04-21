using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Threading.Tasks;
using LoginAPI.Models;
using LoginAPI.Services;
using Newtonsoft.Json;

namespace LoginAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
             return View();
        }

        //public async Task<ActionResult> UserAuthentication(LoginModel lmodel)
        //{
            
        //    return View();
        //}

        public async Task<JsonResult> UserRegistration(RegistrationModel rmodel)
        {
            var result = new JsonResult();
            var apicontroller = new AuthController();
            try
            {
                rmodel.Qflag = "R";
                rmodel.lastPassword = rmodel.password;
                var response = await apicontroller.apiPostResponse("Account/UserRegistration", rmodel);
                if (response != null && response.IsSuccessStatusCode) {
                    result=this.Json(JsonConvert.DeserializeObject<JsonResult>(response.Content.ReadAsStringAsync().Result),JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            return result;
            
        }
    }
}