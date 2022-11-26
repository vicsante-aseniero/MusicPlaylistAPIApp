using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApi.Models
{
 public class User
 {
  public User() { }

  [Key]
  [ForeignKey("Parent")]
  public int Id { get; set; }
  [Required]
  public string? FirstName { get; set; }
  [Required]
  public string? LastName { get; set; }
  [Required]
  public string? Email { get; set; }
 }
}