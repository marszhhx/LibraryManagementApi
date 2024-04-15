using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementApi.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<LibraryBranch> LibraryBranches { get; set; } = default!;

    public DbSet<Customer> Customers { get; set; } = default!;

    public DbSet<Author> Authors { get; set; } = default!;

    public DbSet<Book> Books { get; set; } = default!;
}

