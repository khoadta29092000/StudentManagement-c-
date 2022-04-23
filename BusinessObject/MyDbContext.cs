using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategoryLibrary
{
    public class MyDbContext:DbContext 
    {
        public MyDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Using IConfiguration to get information from json file.
            optionsBuilder.UseSqlServer("Server=desktop-5fopul4.\\SQLEXPRESS;Database=MyStore;Uid=sa;Pwd=1;");
        }
        

        
    }
}
