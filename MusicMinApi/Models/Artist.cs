using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApi.Models
{
 public class Artist
 {
  public Artist() { }

  [Key]
  [ForeignKey("Parent")]
  public int Id { get; set; }
  [Required]
  public string? Name { get; set; }
  [Required]
  public int? Artist_ID_iTunes { get; set; } // From iTunes Search
 }
}