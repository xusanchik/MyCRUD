using Microsoft.EntityFrameworkCore;
using MyCRUD.Models.cs;

namespace MyCRUD.Data;
public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> users { get; set; }
    public DbSet<Product> Products { get; set; }


}
