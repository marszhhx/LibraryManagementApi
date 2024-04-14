using System.ComponentModel.DataAnnotations;
namespace LibraryManagementApi.Models;

public class LibraryBranch
{
    [Key]
    public int LibraryBranchId { get; set; }
    public string BranchName { get; set; }
}
