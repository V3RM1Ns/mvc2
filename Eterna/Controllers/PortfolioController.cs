using Eterna.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    }
}
