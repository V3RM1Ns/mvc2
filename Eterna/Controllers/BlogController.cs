using Eterna.Data;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index(AppDbContext context)
        {
            var viewModel = new BlogVm()
            { 
                Blogs = context.Blogs.ToList(),
               Categories = context.Categories.ToList(),
               RecentBlogs = context.Blogs
                   .Take(3)
                    .ToList()
            };
            return View(viewModel);
        }
    }
}
