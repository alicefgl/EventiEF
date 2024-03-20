using FogliettaA_5I_EventiEF.Data;
using Microsoft.EntityFrameworkCore;

public class dbContext  :DbContext
{
    public dbContext(DbContextOptions<dbContext> options)
        :base(options)
        {

        }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
     => options.UseSqlite(@"Data Source=Data/DbContext.db");

    public DbSet<Membro> Membri { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Evento> Events { get; set; }
    public DbSet<TerritorioP> TerritoriP { get; set; }
    public DbSet<Categoria> Categorie { get; set; }
    public DbSet<Appartenente> Appertenenti { get; set; }
}