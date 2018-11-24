//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Movies.Data
//{
//    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
//    {
//        public ApplicationDbContext CreateDbContext(string[] args)
//        {
//            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
//            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-IP1HFBL;Initial Catalog=Movies;Integrated Security=True");

//            return new ApplicationDbContext(optionsBuilder.Options);
//        }
//    }
//}
