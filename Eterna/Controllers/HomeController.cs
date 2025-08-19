using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Eterna.Data;
using Eterna.ViewModels;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeVm
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Portfolios = await _context.Portfolios
                    .Include(p => p.Category)
                    .Include(p => p.PortfolioImgs)
                    .ToListAsync()
            };

            return View(viewModel);
        }
    }
}
