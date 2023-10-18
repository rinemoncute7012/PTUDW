using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace modelfirst.Models
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context1")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<modelfirst.Models.NhanVien> NhanViens { get; set; }

        public System.Data.Entity.DbSet<modelfirst.Models.PhongBan> PhongBans { get; set; }
    }
}
