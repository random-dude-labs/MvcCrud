using MvcCrud.Models;
using MvcCrud.Services;
using Microsoft.AspNetCore.Mvc;

namespace MvcCrud.Controllers
{
    public class SchoolController : Controller
    {

        private ISchoolService _schoolService;
        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        public IActionResult All()
        {
            return View(_schoolService.GetAllSchools());
        }
        public IActionResult CreateSchool() => View();
        public IActionResult SchoolCreated(School school)
        {

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Something went wrong!");
                return View("CreateSchool");
            }
            _schoolService.AddSchool(school);
            return View();
        }


        public IActionResult EditSchool(int id) => View(_schoolService.GetSingleSchoolById(id));


        public IActionResult SchoolEdited(School newSchool)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Something went wrong!");
                return View("EditSchool", newSchool);
            }
            _schoolService.UpdateSchool(newSchool);

            return View();

        }

        public IActionResult DeleteSchool(int id) => View(_schoolService.SchoolDeletionConfirmation(id));


        public IActionResult SchoolDeleted(int id)
        {
            _schoolService.DeleteSchool(id);
            return View();
        }

        public IActionResult SchoolDetails(int id)
        {

            return View(_schoolService.SchoolDetails(id));
        }

        [Route("/search/{name}")]
        public IActionResult Search(string name)
        {
            string searchName = name;
            return View();
        }
    }
}
