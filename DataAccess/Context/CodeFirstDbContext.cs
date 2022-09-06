using DataAccess.Mapping;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class CodeFirstDbContext : DbContext
    {
        public CodeFirstDbContext() : base("Server=LAPTOP-RONOC5PG\\FURKANAYDIN;Database=KD12CodeFirtsAppTekrarDB;Uid=sa;Pwd=7356;")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CodeFirstDbContext>());
            //Eğer senin database'in veri tabanında bulunmuyorsa gidip onu yaratacak
        }

        public DbSet<Teacher> Teachers { get; set; } //Database'de tablo oluşması için
        public DbSet<School> Schools { get; set; } //Database'de tablo oluşması için

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Birazdan yapacağım database düzenleme işlemlerini buraya ekleyeceğim.

            modelBuilder.Configurations.Add(new TeacherMapping());
            modelBuilder.Configurations.Add(new SchoolMapping());

            //Az önce ayarlamış olduğum düzenlemerli veritabanına yansıtılacağını söyledim.
        }
    }
}
