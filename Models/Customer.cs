using System.ComponentModel.DataAnnotations;
namespace LibraryManagementApi.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    public string Name { get; set; }
}
