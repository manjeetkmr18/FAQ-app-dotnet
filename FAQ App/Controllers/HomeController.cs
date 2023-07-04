using FAQ_App.Models;
using FAQ_App.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FAQ_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly FAQContext _context;

        public HomeController(FAQContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var faqs = _context.FAQs.Include(f => f.Category).Include(f => f.Topic).ToList();
            return View(faqs);
        }

        public IActionResult FilterByCategory(int categoryId)
        {
            var faqs = _context.FAQs.Where(f => f.CategoryId == categoryId).Include(f => f.Category).Include(f => f.Topic).ToList();
            return View("Index", faqs);
        }

        public IActionResult FilterByTopic(int topicId)
        {
            var faqs = _context.FAQs.Where(f => f.TopicId == topicId).Include(f => f.Category).Include(f => f.Topic).ToList();
            return View("Index", faqs);
        }

    }
}
