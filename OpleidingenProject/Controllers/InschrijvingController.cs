using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OpleidingenProject.Data;
using OpleidingenProject.Models;
using OpleidingenProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Controllers
{
    public class InschrijvingController : Controller
    {
        private readonly UserManager<CustomUser> _userManager;
        private readonly IInschrijvingService _inschrijvingService;
        public InschrijvingController(UserManager<CustomUser> userManager, IInschrijvingService inschrijvingService)
        {
            _userManager = userManager;
            _inschrijvingService = inschrijvingService;
        }

        [Authorize(Policy = "IsAdmin,IsUser")]
        public IActionResult Index()
        {
            string userId = _userManager.GetUserId(HttpContext.User);
            return View(_inschrijvingService.InschrijvingByUserId(userId));
        }



        [Authorize(Policy = "IsUser")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Inschrijving(int sessieId)
        {
            string userId = _userManager.GetUserId(HttpContext.User);
            Inschrijving inschrijving = new Inschrijving()
            {
                CustomUserId = userId,
                SessieId = sessieId
            };
            _inschrijvingService.CreateInschrijving(inschrijving);

            return View("Index");
        }



    }
}
