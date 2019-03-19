using Detur.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detur.Cms.Entities.Concrete
{
   public class Product:IEntity
    {
        //if a class implement IEntity then that class is a entity(table)
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
