using Eterna.Models;

namespace Eterna.ViewModels;

public class PortfolioVm
{
    public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    public List<Category> Categories { get; set; } = new List<Category>();
    
}
