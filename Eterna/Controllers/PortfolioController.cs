using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Eterna.Data;
using Eterna.ViewModels;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var portfolios = await _context.Portfolios
                .Include(p => p.Category)
                .Include(p => p.PortfolioImgs)
                .ToListAsync();
            
            return View(portfolios);
        }

        public async Task<IActionResult> Details(int id)
        {
            var portfolio = await _context.Portfolios
                .Include(p => p.Category)
                .Include(p => p.PortfolioImgs)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (portfolio == null)
            {
                return NotFound();
            }

            var viewModel = new PortfolioVm
            {
                Portfolio = portfolio
            };

            return View(viewModel);
        }
    }
}
