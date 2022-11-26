using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApi.Models
{
 public class Album
 {
  public Album() { }

  [Key]
  [ForeignKey("Parent")]
  public int Id { get; set; }
  [Required]
  public string? Name { get; set; }
  [Required]
  public int? Artist_Id { get; set; }
  [Required]
  [ForeignKey("Song")]
  public virtual ICollection<Song>? Songs { get; set; }
 }
}