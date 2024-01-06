 using Microsoft.EntityFrameworkCore;
using NguyenHongQuan489.Models;
namespace NguyenHongQuan489.Data
{
    public class ApplicationDbcontext : DbContext
    {
    public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
    {}
    public DbSet<Person> Person { get; set; }

    }
} 