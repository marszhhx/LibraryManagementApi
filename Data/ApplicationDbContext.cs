using LibraryManagementApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Author> Authors { get; set; }
    public DbSet<LibraryBranch> LibraryBranches { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Book> Books { get; set; }

}

