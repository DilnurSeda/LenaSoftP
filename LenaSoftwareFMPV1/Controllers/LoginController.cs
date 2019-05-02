using LenaSoftwareFMP.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LenaSoftwareFMPV1.Controllers
{
    public class LoginController : Controller
    {
        LoginManager loginManager = new LoginManager();
        // GET: Login
        public ActionResult LoginIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginIndex(string username, string password)
        {
            var loginGiris = loginManager.Login(username, password);
            if (loginGiris!=null)
            {
                //user id send to createdBY
                Session.Add("UserID",loginGiris.ID);
                Session.Add("ActiveUser",username);
                return RedirectToAction("FormIndex", "Form");
            }
            else
            {
                ViewBag.mesaj = "Kullanıcı Adı veya Şifre Hatalı!";
            }
            return View();
        }
    }
}