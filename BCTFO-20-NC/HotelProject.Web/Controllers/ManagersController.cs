using HotelProject.Models;
using HotelProject.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

///TODO : 1.მენეჯერის დამატება შემეძლოს მხოლოდ იმ სასტუმროებზე რომელსაც ამ მომენტში მენეჯერი არ ჰყავს.
///TODO : 2.სასტუმროს არჩევა არ უნდა ხდებოდეს ID - ის მიხედვით. უნდა ვირჩევდე IEnumerable<SelectListItem> - კოლექციის გამოყენებით

namespace HotelProject.Web.Controllers
{
    public class ManagersController : Controller
    {
        private readonly ManagerRepository _managerRepository;
        public ManagersController(ManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _managerRepository.GetManagers();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Manager model)
        {
            await _managerRepository.AddManager(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _managerRepository.GetSingleManager(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePOST(int id)
        {
            await _managerRepository.DeleteManager(id);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Update(int id)
        {
            var result = await _managerRepository.GetSingleManager(id);
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePOST(Manager model)
        {
            await _managerRepository.UpdateManager(model);
            return RedirectToAction("Index");
        }

    }
}
