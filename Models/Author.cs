using System.ComponentModel.DataAnnotations;
namespace LibraryManagementApi.Models;

public class Author
{
    [Key]
    public int AuthorId { get; set; }
    public string Name { get; set; }
}

 