using ChavezITELEC1C.Models;
using Microsoft.AspNetCore.Mvc;
namespace ChavezITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1 , FirstName = "Gabriel", LastName = "Montano", isTenured = true, Rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-08-26")
                },
                new Instructor()
                {
                    Id= 4 ,FirstName = "Aira", LastName = "Chavez", isTenured = true, Rank = Rank.Professor, HiringDate = DateTime.Parse("2022-1-25")
                },
                new Instructor()
                {
                    Id= 2 ,FirstName = "Melissa", LastName = "Chavez", isTenured = true , Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-07")
                },
                new Instructor()
                {
                    Id= 3 ,FirstName = "John", LastName = "Chavez", isTenured = false , Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2020-01-25")
                }
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {

            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {

            return View();
        }
        }
       

}