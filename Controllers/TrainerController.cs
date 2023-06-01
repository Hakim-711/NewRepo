using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.DependencyResolver;

namespace YourNamespace.Controllers
{
    public class TrainerController : Controller
    {
        // GET: Trainer/RegisterTrainer
        public IActionResult RegisterFormTrainer()
        {
            return View();
        }

        // POST: Trainer/RegisterTrainer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterFormTrainer(RegisterFormTrainer model)
        {
            if (ModelState.IsValid)
            {
                // Save the trainer data to the database or perform other necessary actions

                // Redirect to a confirmation page or another action
                return RedirectToAction("Success", "Trainer");
            }
            return View("RegisterFormTrainer", model);
        }
        [HttpPost]
        public IActionResult Success() {

            return View();
        }

        /*
         * 
         *         [HttpPost]

        public IActionResult Success(RegisterFormTrainer re)
        {
            
            ViewBag.Name=re.Name;
            ViewBag.PhoneNumber=re.PhoneNumber;
            ViewBag.TrainerType = re.TrainerType;
            ViewBag.Experience=re.Experience;

            return View();
        }
        */

    }
}
