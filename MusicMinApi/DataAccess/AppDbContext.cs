using Microsoft.EntityFrameworkCore;
using MusicApi.Models;

namespace MusicApi.Data
{
 public class AppDbContext : DbContext
 {
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {

  }

  public DbSet<User>? Users { get; set; }
  public DbSet<Song>? Songs { get; set; }
  public DbSet<Album>? Albums { get; set; }
  public DbSet<Playlist>? Playlists { get; set; }
 }
}