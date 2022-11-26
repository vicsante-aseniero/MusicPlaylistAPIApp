using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApi.Models
{
 public class Song
 {
  public Song() { }

  [Key]
  [ForeignKey("Parent")]
  public int Id { get; set; }
  [Required]
  public string? Name { get; set; }
  [Required]
  [ForeignKey("Artist")]
  public int? Artist_Id { get; set; }
 }
}