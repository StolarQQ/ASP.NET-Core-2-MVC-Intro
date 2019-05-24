using Microsoft.AspNetCore.Mvc;
using PieShop.Models;

namespace PieShop.Controllers
{
    public class FeedbackController : Controller
    {
        public IFeedbackRepository FeedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            FeedbackRepository = feedbackRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                FeedbackRepository.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }

            return View(feedback);

        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}