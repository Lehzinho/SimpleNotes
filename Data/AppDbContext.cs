using Microsoft.EntityFrameworkCore;
using SimpleNotes.Models;

namespace SimpleNotes.Data;

public class AppDbContext : DbContext
{
    public DbSet<NotesModel> Notes { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost,1433;Database=SimpleNotes;User ID=sa;Password=1q2w3e4r@#$");
}