using Detur.Cms.DataAccess.Concrete.EntityFramework.Mappings;
using Detur.Cms.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detur.Cms.DataAccess.Concrete.EntityFramework.Contexts
{
   public class CmsContext:DbContext
    {
        public CmsContext()
        {
            Database.SetInitializer<CmsContext>(null);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
         }
    }
}
