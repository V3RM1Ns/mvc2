namespace Eterna.Models
{
    public class PortfolioImg
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; } = null!;
    }
}

