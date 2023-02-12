using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop_Mvp.Services.Contracts;
using OnlineShop_Mvp.Services.Dtos.PersonDtos;

namespace OnlineShop.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public IActionResult Index()
        {
            return View(_personService.FillGrid());
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person_Save_Dto person)
        {
            if (ModelState.IsValid)
            {
                _personService.Save(person);
                RedirectToAction("Index");
            }
            return View(person);
        }

        public IActionResult Edit(Guid id)
        {
            var person = _personService.FindEdit(id);
            return View(person);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Person_Edit_Dto person)
        {
            if (ModelState.IsValid)
            {
                _personService.Edit(person);
                RedirectToAction("index");
            }
            return View(person);
        }
        public IActionResult Delete(Guid id)
        {
            _personService.Delete(id);
            return RedirectToAction("index");
        }
        public IActionResult Details(Guid id)
        {
            var person = _personService.Find(id);
            return View(person);
        }
    }
}
