public class MonedaDeCambioDbContext : DbContext
{
    public DbSet<MonedaDeCambio> MonedasDeCambio { get; set; }
    public DbSet<Fee> Fees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MonedaDeCambio>()
            .HasData(
            new MonedaDeCambio()
            {
                IdCambio = 1,
                Monto = 1,
                TipoDeCambio = "DolarPeso",
                MontoResultante = 105.9
            },
             new MonedaDeCambio()
             {
                 IdCambio = 1,
                 Monto = 1,
                 TipoDeCambio = "PesoDolar",
                 MontoResultante = 0.0095
             });

        modelBuilder.Entity<Fee>()
            .HasData(
            new Fee()
            {
                IdCambio = 1,
                TipoDeCambio = "DolarPeso",
                Fee = 105.9
            },
              new Address()
              {
                  IdCambio = 2,
                  TipoDeCambio = "PesoDolar",
                  Fee = 0.0095
              });

        base.OnModelCreating(modelBuilder);
    }

    public MonedaDeCambioDbContext(DbContextOptions<MonedaDeCambioDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    