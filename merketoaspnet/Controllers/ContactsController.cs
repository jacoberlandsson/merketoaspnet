using merketoaspnet.Helpers.Repositories;
using merketoaspnet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace merketoaspnet.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactRepo _contactRepo;

        public ContactsController(ContactRepo contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Index(ContactViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _contactRepo.AddAsync(new Models.Entities.ContactFormEntity
                {
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    Email = viewModel.Email,
                    Message = viewModel.Message
                });

                return RedirectToAction("Index");
            }
            return View(viewModel);
        }


    }
}
