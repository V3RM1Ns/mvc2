using Eterna.Migrations;
using Eterna.Models;

namespace Eterna.ViewModels
{
    public class BlogVm
    {
        public List<Blog> Blogs { get; set; } = new List<Blog>();
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Blog> RecentBlogs { get; set; } = new List<Blog>();
    }
}
