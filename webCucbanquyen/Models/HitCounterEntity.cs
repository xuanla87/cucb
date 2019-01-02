namespace webCucbanquyen.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HitCounterEntity : DbContext
    {
        public HitCounterEntity()
            : base("name=HitCounterEntity")
        {
        }

        public virtual DbSet<Visiter> Visiters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
