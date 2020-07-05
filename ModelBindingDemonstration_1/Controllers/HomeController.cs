using ModelBindingDemonstration_1.Models;
using ModelBindingDemonstration_1.UtilityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBindingDemonstration_1.Controllers
{
    public class HomeController : Controller
    {
        List<Employee> empList = new List<Employee>
        {
            new Employee {Id=101,Name="Abhinav",Location="Bangalore",Salary=12345 },
            new Employee {Id=102,Name="Abhishek",Location="Chennai",Salary=23456 },
            new Employee {Id=103,Name="Ajay",Location="Bangalore",Salary=34567 },
            new Employee {Id=104,Name="Anil",Location="Chennai",Salary=45678 },
            new Employee {Id=105,Name="Anirudh",Location="Bangalore",Salary=56789 }
        };

        public ActionResult BookAppointment()
        {
            return View();
        }

        [HttpPost]
        public string BookAppointment(UserAppointment appointment)
        {
            //To Create New Appointment in your System
            return "For " + appointment.Name + " with Email ID : " + appointment.EmailId + 
                " and Contact No : " + appointment.ContactNo +
                ", appointment is Booked on : " + appointment.AppointmentDate;
        }
        public ActionResult UpdateEmployees()
        {
            return View(empList);
        }

        [HttpPost]
        public ActionResult UpdateEmployees(List<Employee> employees)
        {
            return View("NewView", employees);
        }
        public ActionResult DisplayNames(List<string> Names)
        {
            Names = Names ?? new List<string>();

            return View(Names);
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string EditEmployee(int Id)
        {
            return "Edit Employee is Called with ID : " + Id;
        }

        public ActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public string CreateEmployee([Bind(Exclude ="Id")] Employee emp)
        {
            
            StreamWriter sw = new StreamWriter(@"D:\JuneMvcBatch_2019\TestFile.txt", true);

            sw.WriteLine(emp.ToString());

            sw.Close();

            return "Data is Logged into the File";
        }
    }
}