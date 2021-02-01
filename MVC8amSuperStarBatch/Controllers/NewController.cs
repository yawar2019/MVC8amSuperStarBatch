using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC8amSuperStarBatch.Models;

namespace MVC8amSuperStarBatch.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public string Index()
        {
            return "hello";
        }

        public int Index1()
        {
            return 2;
        }

        public string Index2(int? id)
        {
            return "hello my Id is "+id;
        }

        public ActionResult GetView(int? empId)
        {
            int? a = empId; 
            return View();
        }
        public ActionResult GetView1()
        {
            return View("About");
        }

        public ActionResult GetView2()
        {
            return View("~/Views/Default/index.cshtml");
        }

        public string DisplayValue(int? empId,string EmpName,string Designation)
        {
           return "My EmpId is "+empId+ "and My EmpName is "+EmpName+"My Designation is "+Designation;
             
        }
        public string DisplayValue2(int? empId)
        {
            return "My EmpId is " + empId + "and My EmpName is " + Request.QueryString["EmpName"] + "My Designation is " + Request.QueryString["Designation"];

        }

        //How to Pass Values from Controller to View Pages

        public ActionResult SendDataToView() {
            string Name = "Vinod";
            ViewBag.Info = Name;
            return View();
        }

        //Passing Multiple Information

        public ActionResult SendMultipleDataToView()
        {

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 245670;

            ViewBag.Info = emp;
            
            return View();
        }

        //Passing Multiple objects Information

        public ActionResult SendMultipleEmployeeToView()
        {
            List<EmployeeModel> listemp = new List<EmployeeModel>();
          

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 245670;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Rahim";
            emp1.EmpSalary = 348474;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpSalary = 737332;
            emp2.EmpId = 3;
            emp2.EmpName = "Vinod";

            EmployeeModel emp3 = new EmployeeModel();
            emp3.EmpId = 3;
            emp3.EmpName = "Raveeja";
            emp3.EmpSalary = 837332;

            listemp.Add(emp);
            listemp.Add(emp1); 
            listemp.Add(emp2);
            listemp.Add(emp3);


            ViewBag.Info = listemp;

            return View();
        }

        //sending Data to View Page through ViewModel
        
        public ActionResult getEmployeeByModel()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 245670;

            return View(emp);
        }
        public ActionResult getMultipleEmployeeByModel()
        {
            List<EmployeeModel> listemp = new List<EmployeeModel>();


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 245670;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Rahim";
            emp1.EmpSalary = 348474;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpSalary = 737332;
            emp2.EmpId = 3;
            emp2.EmpName = "Vinod";

            EmployeeModel emp3 = new EmployeeModel();
            emp3.EmpId = 3;
            emp3.EmpName = "Raveeja";
            emp3.EmpSalary = 837332;

            listemp.Add(emp);
            listemp.Add(emp1);
            listemp.Add(emp2);
            listemp.Add(emp3);


            

            return View(listemp);
        }

        public ActionResult getMultipleModels()
        {
            List<EmployeeModel> listemp = new List<EmployeeModel>();


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ritu";
            emp.EmpSalary = 245670;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Rahim";
            emp1.EmpSalary = 348474;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpSalary = 737332;
            emp2.EmpId = 3;
            emp2.EmpName = "Vinod";

            EmployeeModel emp3 = new EmployeeModel();
            emp3.EmpId = 3;
            emp3.EmpName = "Raveeja";
            emp3.EmpSalary = 837332;

            listemp.Add(emp);
            listemp.Add(emp1);
            listemp.Add(emp2);
            listemp.Add(emp3);

            DepartmentModel dept = new DepartmentModel();
            dept.DeptId = 1211;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 1212;
            dept1.DeptName = "Network";


            List<DepartmentModel> listdept = new List<Models.DepartmentModel>();
            listdept.Add(dept);
            listdept.Add(dept1);

            EmployeeDeptModel empdeptModel = new Models.EmployeeDeptModel();


            empdeptModel.Emp = listemp;
            empdeptModel.Dept = listdept;


            return View(empdeptModel);
        }
    }
}