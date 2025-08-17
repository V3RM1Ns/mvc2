using System.Diagnostics;
using Eterna.Data;
using Microsoft.AspNetCore.Mvc;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var homeVm = new HomeVm
        {
            Sliders = await _context.Sliders.ToListAsync()
        };
        return View(homeVm);
    }
}