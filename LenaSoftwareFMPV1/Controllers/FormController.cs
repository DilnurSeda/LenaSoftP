using LenaSoftwareFMP.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LenaSoftwareFMPV1.Controllers
{
    public class FormController : Controller
    {
        FormManager formManager = new FormManager();
        // GET: Form
        public ActionResult FormIndex()
        {
            
            if (Session["ActiveUser"] == null)
            {
                return RedirectToAction("LoginIndex", "Login");
            }
            return View();
        }
        
        public ActionResult FormDisplayIndex()
        {
            if (Session["ActiveUser"] == null)
            {
                return RedirectToAction("LoginIndex", "Login");
            }
            return View();
        }
        [HttpPost]
        public ActionResult FormIndex(string name, string description, DateTime? createdAt, int? createdBy)
        {
            createdBy = Convert.ToInt32(Session["UserID"].ToString());
            formManager.FormInsert(name, description, Convert.ToDateTime(DateTime.Now.ToShortDateString()), (int)createdBy);
            return View();
        }
        [HttpPost]
        public ActionResult FormDisplayIndex(int formId)
        {            
            return View();
        }
    }
}