using Microsoft.AspNetCore.Mvc;
using ChavezITELEC1C.Models;


namespace ChavezITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "John",LastName = "Chavez",  Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "johnchristopher.chavez.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id= 2,FirstName = "Aira",LastName = "Chavez",  Course = Course.BSCS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "airaclarisse.chavez.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id= 3,FirstName = "Melissa",LastName = "Chavez", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "melissagrace.chavez.cics@ust.edu.ph"
                }
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }
    }
}