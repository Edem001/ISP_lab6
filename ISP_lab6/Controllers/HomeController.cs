using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB_lab4;
using ISP_lab6.Models;

namespace ISP_lab6.Controllers
{
    public class HomeController : Controller
    {
        mContext db = new mContext();
        public ActionResult Index()
        {
            IEnumerable<Institutes> institutes = db.Institute;
            ViewBag.Institutes = institutes;

            IEnumerable<Departments> departments = db.Department;
            ViewBag.Departments = departments;

            IEnumerable<Groups> groups = db.Group;
            ViewBag.Groups = groups;

            IEnumerable<Lecturers> lecturers = db.Lecturer;
            ViewBag.Lecturers = lecturers;

            IEnumerable<Students> students = db.Student;
            ViewBag.Students = students;

            IEnumerable<Subjects> subjects = db.Subject;
            ViewBag.Subjects = subjects;

            IEnumerable<Union> union = db.mUnion;
            ViewBag.Union = union;

            return View();
        }

        [HttpGet]
        public ActionResult Enroll(int id)
        {
            ViewBag.GroupID = id;
            return View();
        }
        [HttpPost]
        public string Enroll(Student_extended student_e)
        {
            Students student = new Students
            {
                Name = student_e.Name,
                Surname = student_e.Surname,
                Age = student_e.Age,
                Group = db.Group.Find(student_e.GroupID)
            };
            
            db.Student.Add(student);
            db.SaveChanges();

            return student.Name + ", Вас зараховано";
        }
    }
}