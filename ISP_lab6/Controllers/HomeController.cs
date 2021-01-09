using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB_lab4;

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
    }
}