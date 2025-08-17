using Eterna.Models;

namespace Eterna.ViewModels
{
    public class HomeVm
    {
        public List<Slider> Sliders { get; set; } = new List<Slider>();
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    }
}
