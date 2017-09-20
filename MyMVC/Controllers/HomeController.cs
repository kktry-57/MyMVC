using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVC.Models;
using MyMVC.Services;

namespace MyMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Member()
        {
            var members = MemberSvc.GetMembers();
            return View(members);
        }

        [HttpGet]
        public ActionResult Create()
        {
            MemberViewModel obj = new MemberViewModel();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Create(MemberViewModel obj)
        {
            //if (obj.ID == null)
            //{
            //    obj = new MemberViewModel();
            //    return View(obj);
            //}
            //else
            {
                MemberSvc.Add(obj);
                return RedirectToAction("Member");
            }
        }
    }
}