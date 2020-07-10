using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicMenu.Models
{
    public class ApplicationContext :IdentityDbContext<ApplicationUser>
    {
      
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            :base(options)
        {

        }

        public virtual DbSet<MenuMaster> MenuMaster { get; set; }
        public virtual DbSet<TblEmpDetails> TblEmpDetails { get; set; }
        public virtual DbSet<MyTasks> MyTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
