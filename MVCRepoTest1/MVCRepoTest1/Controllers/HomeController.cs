using MVCRepoTest1.BusinessLayer.Interface;
using MVCRepoTest1.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRepoTest1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            IEmployeeBusiness empData = new EmployeeBusiness();
            ViewBag.EmpName = empData.GetEmployeeName("189080");
            return View();
        }

    }
}
