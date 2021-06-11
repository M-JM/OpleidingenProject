using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpleidingenProject.Models;
using OpleidingenProject.Services;
using OpleidingenProject.ViewModels.OpleidingViewModel;

namespace OpleidingenProject.Controllers
{
    public class OpleidingController : Controller
    {

        private readonly IOpleidingService _opleidingService;

        public OpleidingController(IOpleidingService opleidingService)
        {
            _opleidingService = opleidingService;
        }


        public IActionResult Index()
        {
            return View(_opleidingService.AllOpleidingen());
        }

        [Authorize(Policy = "IsAdmin")]
        public IActionResult Create()
        {
            CreateOpleidingCommand cmd = new CreateOpleidingCommand();
            PopulateViewModel(cmd);

            return View(cmd);
        }

        [Authorize(Policy = "IsAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateOpleidingCommand cmd)
        {
            if (ModelState.IsValid)
            {
                int id = _opleidingService.CreateOpleiding(cmd);
                return RedirectToAction("Details", new { id = id });
            }

            PopulateViewModel(cmd);
            return View(cmd);
        }


        [Authorize(Policy = "IsAdmin")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("OpleidingNotFound", id);
            }

            var updateCommand = _opleidingService.GetOpleidingForUpdate(id.Value);

            if (updateCommand == null)
            {
                return View("OpleidingNotFound", id);
            }

            PopulateViewModel(updateCommand);

            return View(updateCommand);
        }
        [Authorize(Policy = "IsAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, UpdateOpleidingCommand cmd)
        {
            if (id != cmd.Id)
            {
                return View("OpleidingNotFound", id);
            }

            if (ModelState.IsValid)
            {
                _opleidingService.updateOpleiding(cmd);

                return RedirectToAction("Details", new { id = id });
            }

            PopulateViewModel(cmd);

            return View(cmd);
        }


        [AllowAnonymous]
        public IActionResult Details(int? id)
        {
         
            if (id == null)
            {
                return NotFound();
            }

            Opleiding opleiding = _opleidingService.OpleidingById(id.Value);
            

            if (opleiding == null)
            {
                return View("OpleidingNotFound",id);
            }

            return View(opleiding);
        }

        [Authorize(Policy = "IsAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("OpleidingNotFound", id);
            }

            _opleidingService.DeleteOpleiding(id.Value);

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Search()
        {

            var overViewWithSearchViewModel = new OverviewWithSearchViewmodel()
            {
                Categorieen = _opleidingService.AllCategories(),
                Opleidingen = _opleidingService.AllOpleidingen()
              
            };

            return View(overViewWithSearchViewModel);
        }



        private void PopulateViewModel(EditOpleidingBase editOpleiding)
        {
            editOpleiding.Categorieen = _opleidingService.AllCategories();
        }

       
    }
}
