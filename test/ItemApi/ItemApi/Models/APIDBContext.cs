using Microsoft.EntityFrameworkCore;

namespace ItemApi.Models
{
    public class APIDBContext:DbContext
    {
        public APIDBContext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Item> Items { get; set; }
    }
}
