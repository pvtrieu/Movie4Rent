namespace Movie4Rent.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BaseModel : DbContext
    {
        public BaseModel()
            : base("name=BaseModel")
        {
        }

        public virtual DbSet<Exporting> Exportings { get; set; }
        public virtual DbSet<ExportingDetail> ExportingDetails { get; set; }
        public virtual DbSet<Importing> Importings { get; set; }
        public virtual DbSet<ImportingDetail> ImportingDetails { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(e => e.ExportingDetails)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.ImportingDetails)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);
        }
    }
}
