using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using BusinessPortal.Models;

namespace BusinessPortal.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            //list all in side of the index
            var db = new MySqlConnection("server=127.0.0.1;database=business;Uid=root;pwd=abc123;");
            IEnumerable<Department> depts = db.GetAll<Department>();
            return View(depts);
        }

        //(R)View a single department and it's details
        public IActionResult Detail(string id)
        {
            //return Content(id);
            // started with content for testing
            var db = new MySqlConnection("server=127.0.0.1;database=business;Uid=root;pwd=abc123;");
            Department dep = db.Get<Department>(id);

            List<Employee> emps = db.Query<Employee>($"select * from employee where department = '{id}'").ToList();

            ViewData["employees"] = emps;

            return View(dep);

        }
        // view that presents a FORM for adding a new department 
        public IActionResult AddForm()
        {
            return View();
        }
        // (C)An action that responds to the form for adding a new department 

        // (D)Delete a department 
        public IActionResult Delete(string id)
        {
            var db = new MySqlConnection("server=127.0.0.1;database=business;Uid=root;pwd=abc123;");
            Department dep = new Department() { id = id};
            db.Delete(dep);
            return Redirect("/department");
        }
        //(U)Edit a department 
    }
}
