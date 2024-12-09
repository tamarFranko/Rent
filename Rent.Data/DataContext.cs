using Microsoft.EntityFrameworkCore;
using Rent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Turn> Turns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Rent");
        }

        //public DataContext()
        //{
        //    Clinics = new List<Clinic>
        //     {
        //        new Clinic(1, "Office", "Rozovsky 10", 50),
        //        new Clinic( 2,"Home", "Shlomo Hacohen", 30),
        //        new Clinic(3,"Shlomo Hacohen", "Shlomo Hacohen", 30)
        //     };


        //    Tenants = new List<Tenant>
        //     {
        //        new  Tenant("Yakov","Cohen","231315156","0556745532","yc745532@gmail.com"),
        //        new  Tenant("ysrael meir","galin","223122432","0548554534","yg8554534@gmail.com"),
        //        new  Tenant("david","lev","234444156","0556778990","dl6778990@gmail.com")
        //     };


        //    Turns = new List<Turn>
        //    {
        //            new Turn(1,"Rozovsky",new DateTime(),new DateTime(),3,new DateTime(),new DateTime(),"235"),
        //            new Turn(2,"Office",new DateTime(),new DateTime(),2,new DateTime(),new DateTime(),"198"),
        //            new Turn(3,"Shlomo Hacohen",new DateTime(),new DateTime(),5,new DateTime(),new DateTime(),"456")
        //    };

        //}
    }
}
