namespace Eterna.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public Category Category { get; set; } = null!;
        public int CategoryId { get; set; }
        public List<PortfolioImg> PortfolioImgs { get; set; } = new List<PortfolioImg>();
    }
}

