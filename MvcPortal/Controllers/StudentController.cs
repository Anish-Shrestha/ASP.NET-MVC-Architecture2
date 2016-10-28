using System;
using System.Linq;
using System.Web.Mvc;
using CodeFirstEntities;
using CodeFirstServices.Interfaces;

namespace CodeFirstPortal.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            var studentDetails = _studentService.GetStudentById((int) id);
            if (studentDetails == null) throw new ArgumentNullException("Not Found");
            return View(studentDetails);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var studentDetails = _studentService.GetStudentById((int) id);
            if (studentDetails == null) throw new ArgumentNullException("Not Found");
            return View(studentDetails);
        }

        [HttpPost]
        public ActionResult Delete(Student student)
        {
            _studentService.DeleteStudent(student.StudentId);
            return RedirectToAction("List", "Student");
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var studentDetails = _studentService.GetStudentById((int) id);
            if (studentDetails == null) throw new ArgumentNullException("Not Found");
            return View(studentDetails);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            _studentService.UpdateStudent(student);
            return RedirectToAction("List", "Student");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            var studentModel = new Student()
                                   {
                                       Address = student.Address,
                                       Country = student.Country,
                                       Name = student.Name,
                                       Age = student.Age,
                                       Email = student.Email
                                   };
            _studentService.CreateStudent(studentModel);
            return RedirectToAction("List", "Student");
        }

        [HttpGet]
        public ActionResult List()
        {
            var students = _studentService.GetStudents();
            if (students.Any())
            {
                return View("List", students);
            }

            return View("List");
        }
    }
}
