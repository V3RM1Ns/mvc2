using Eterna.Data;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new BlogVm()
            { 
                Blogs = await _context.Blogs.ToListAsync(),
                Categories = await _context.Categories.ToListAsync(),
                RecentBlogs = await _context.Blogs
                   .Take(3)
                   .ToListAsync()
            };
            return View(viewModel);
        }
    }
}
