using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class WebApiDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer("Server=DESKTOP-LIMLNDB;Database=HospitalAPI;Trusted_connection=true;");

        //public WebApiDbContext(DbContextOptions<WebApiDbContext> options) : base(options) { }
        //push hatası deneme


        public DbSet<Doctor> Doctors { get; set; }


    }
}
