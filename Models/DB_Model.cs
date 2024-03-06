using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SoundLocator_WebApi.Models
{
    public partial class DB_Model : DbContext
    {
        public DB_Model()
            : base("name=DB_Model")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Sound> Sounds { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasOptional(e => e.Sound)
                .WithRequired(e => e.Category);
        }
    }
}
