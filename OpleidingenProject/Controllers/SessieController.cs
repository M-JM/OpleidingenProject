using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpleidingenProject.Models;
using OpleidingenProject.Services;
using OpleidingenProject.ViewModels.SessieViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Controllers
{
    public class SessieController : Controller
    {
        private readonly IOpleidingService _opleidingService;
        private readonly ISessieService _sessieService;

        public SessieController(IOpleidingService opleidingService, ISessieService sessieService)
        {
            _opleidingService = opleidingService;
            _sessieService = sessieService;
        }

        [Authorize(Policy = "IsAdmin,IsUser")]
        public IActionResult Index()
        {
            return View(_sessieService.AlleSessies());
        }

        [Authorize(Policy = "IsAdmin")]
        public IActionResult Create()
        {
            CreateSessieCommand cmd = new CreateSessieCommand();
            PopulateViewModel(cmd);

            return View(cmd);
        }

        [Authorize(Policy = "IsAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateSessieCommand cmd)
        {
            if (ModelState.IsValid)
            {
                int id = _sessieService.CreateSessie(cmd);
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
                return NotFound();
            }

            var updateCommand = _sessieService.GetSessieForUpdate(id.Value);

            if (updateCommand == null)
            {
                return NotFound();
            }

            PopulateViewModel(updateCommand);

            return View(updateCommand);
        }

        [Authorize(Policy = "IsAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, UpdateSessieCommand cmd)
        {
            if (id != cmd.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _sessieService.UpdateSessie(cmd);

                return RedirectToAction("Details", new { id = id });
            }

            PopulateViewModel(cmd);

            return View(cmd);
        }



        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sessie sessie = _sessieService.SessieById(id.Value);

            if (sessie == null)
            {
                return NotFound();
            }

            return View(sessie);
        }

        [Authorize(Policy = "IsAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _sessieService.DeleteSessie(id.Value);

            return RedirectToAction("Index");
        }




        private void PopulateViewModel(EditSessieBase editSessie)
        {
            editSessie.Opleidingen = _opleidingService.AllOpleidingen();
        }


    }
}
