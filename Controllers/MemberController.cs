using Fitness.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fitness.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                // Save the form data to the database or perform other actions as needed

                // Redirect to a success page or display a success message
                return RedirectToAction("Dashboard");
            }
            else
            {
                // If the model state is not valid, return the view with the same model to display validation errors
                return View("Register", model);
            }
        }
        public IActionResult Feedback()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                // Process feedback submission, e.g., save to database, send email, etc.
                // ...

                return RedirectToAction("Success");
            }
            else
            {
                return View("Feedback", feedback);
            }
        }

        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Memebership()
        {
            return View();
        }
    }
}
