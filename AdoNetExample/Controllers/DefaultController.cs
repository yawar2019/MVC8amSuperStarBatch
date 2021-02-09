using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoNetExample.Models;
namespace AdoNetExample.Controllers
{
    public class DefaultController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        // GET: Default
        public ActionResult Index()
        {

            return View(db.GetEmployee());
        }

        [HttpGet]
        public ActionResult Create() {

            return View();
        }

        [HttpPost]
        public ActionResult Create(string EmpName,int EmpSalary)
        {
            int i = db.SaveEmployee(EmpName, EmpSalary);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}