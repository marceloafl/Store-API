using Microsoft.EntityFrameworkCore;
using Store.Domain.Models;

namespace Store.Infra.Data.Context;

public partial class StoreDbContext : DbContext
{
    public StoreDbContext()
    {
    }

    public StoreDbContext(DbContextOptions<StoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=NBQFC-8YHVYL3;Initial Catalog=StoreDB;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__Client__E67E1A245CF1215C");

            entity.ToTable("Client");

            entity.Property(e => e.ClientBirth).HasColumnType("date");
            entity.Property(e => e.ClientCity)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClientCountry)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClientCpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ClientCPF");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClientState)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClienteAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity.HasKey(e => e.PurchaseId).HasName("PK__Compras__067DA725CC8E3498");

            entity.ToTable("Purchase");

            entity.Property(e => e.Item)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Client).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Purchase__Client__4E88ABD4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
