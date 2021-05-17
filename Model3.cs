using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Arenda1
{
    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<Сотрудники> Сотрудники { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Сотрудники>()
                .Property(e => e.ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Сотрудники>()
                .Property(e => e.Пароль)
                .IsFixedLength();
        }
    }
}
