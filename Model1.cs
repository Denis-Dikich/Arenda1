using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Arenda1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public object Users { get; internal set; }

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
