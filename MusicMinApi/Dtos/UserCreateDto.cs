using System.ComponentModel.DataAnnotations;

namespace MusicApi.Dtos
{
 public class UserCreateDto
 {
  [Required]
  public string? FirstName { get; set; }
  [Required]
  public string? LastName { get; set; }
  [Required]
  public string? Email { get; set; }
 }
}