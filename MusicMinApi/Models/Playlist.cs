using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApi.Models
{
 public class Playlist
 {
  public Playlist() { }

  [Key]
  public int Id { get; set; }
  [Required]
  public string? Name { get; set; }
  [Required]
  [ForeignKey("User")]
  public int User_Id { get; set; }
  [Required]
  [ForeignKey("Song")]
  public virtual ICollection<Song>? Songs { get; set; }
  [Required]
  [ForeignKey("Album")]
  public virtual ICollection<Album>? Albums { get; set; }
 }
}