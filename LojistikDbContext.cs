using Microsoft.EntityFrameworkCore;

public class LojistikDbContext : DbContext
{
    public DbSet<Kurye> Kuryeler { get; set; }
    public DbSet<Siparis> Siparisler { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=kurye_lojistik.db");
    }
}
