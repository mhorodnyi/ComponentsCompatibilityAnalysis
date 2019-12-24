namespace ComputerComponents.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ComputerComponentsEntities : DbContext
    {
        public ComputerComponentsEntities()
            : base("name=ComputerComponentsEntities")
        {
        }

        public virtual DbSet<Fan> Fans { get; set; }
        public virtual DbSet<GraphicalCard> GraphicalCards { get; set; }
        public virtual DbSet<HDD> HDDs { get; set; }
        public virtual DbSet<Memory> Memories { get; set; }
        public virtual DbSet<PowerSupply> PowerSupplies { get; set; }
        public virtual DbSet<Processor> Processors { get; set; }
        public virtual DbSet<SSD> SSDs { get; set; }
        public virtual DbSet<Motherboard> Motherboards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fan>()
                .Property(e => e.Vendor)
                .IsFixedLength();

            modelBuilder.Entity<Fan>()
                .Property(e => e.Sockets)
                .IsUnicode(false);

            modelBuilder.Entity<Fan>()
                .Property(e => e.Coast)
                .HasPrecision(10, 4);

            modelBuilder.Entity<GraphicalCard>()
                .Property(e => e.Vendor)
                .IsFixedLength();

            modelBuilder.Entity<GraphicalCard>()
                .Property(e => e.Chipset)
                .IsFixedLength();

            modelBuilder.Entity<GraphicalCard>()
                .Property(e => e.Coast)
                .HasPrecision(10, 4);

            modelBuilder.Entity<HDD>()
                .Property(e => e.Vendor)
                .IsFixedLength();

            modelBuilder.Entity<HDD>()
                .Property(e => e.Coast)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Memory>()
                .Property(e => e.Vendor)
                .IsFixedLength();

            modelBuilder.Entity<Memory>()
                .Property(e => e.Generation)
                .IsFixedLength();

            modelBuilder.Entity<Memory>()
                .Property(e => e.Coast)
                .HasPrecision(10, 4);

            modelBuilder.Entity<PowerSupply>()
                .Property(e => e.Vendor)
                .IsFixedLength();

            modelBuilder.Entity<PowerSupply>()
                .Property(e => e.Coast)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Processor>()
                .Property(e => e.Vendor)
                .IsFixedLength();

            modelBuilder.Entity<Processor>()
                .Property(e => e.GraphicalCore)
                .IsFixedLength();

            modelBuilder.Entity<Processor>()
                .Property(e => e.Socket)
                .IsFixedLength();

            modelBuilder.Entity<Processor>()
                .Property(e => e.Coast)
                .HasPrecision(10, 4);

            modelBuilder.Entity<SSD>()
                .Property(e => e.Vendor)
                .IsFixedLength();

            modelBuilder.Entity<SSD>()
                .Property(e => e.Interface)
                .IsFixedLength();

            modelBuilder.Entity<SSD>()
                .Property(e => e.Coast)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Vendor)
                .IsFixedLength();

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Socket)
                .IsFixedLength();

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Chipset)
                .IsFixedLength();

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Coast)
                .HasPrecision(10, 4);
        }
    }
}
