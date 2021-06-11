using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OpleidingenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCode(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            var ErrorMessages = new ErrorMessage();
            switch (statusCode)
            {
                case 404:
                    ErrorMessages.TheErrorMessage = "sorry deze pagina bestaat niet";
                    ErrorMessages.Path = statusCodeResult.OriginalPath;
                    ErrorMessages.Qs = statusCodeResult.OriginalQueryString;

                 
                    break;
            }
            return View("NotFound", ErrorMessages);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            var exceptiondetailsModel = new ExceptionDetail();
            var exceptiondetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();


            exceptiondetailsModel.ExceptionPath = exceptiondetails.Path;
            exceptiondetailsModel.ExceptionMessage = exceptiondetails.Error.Message;
            exceptiondetailsModel.Stacktrace = exceptiondetails.Error.StackTrace;

         
            return View(exceptiondetailsModel);

        }
    }
}
