namespace Eterna.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    }
}

