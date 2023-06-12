using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guschin.GraduateProject.Entities.Production
{
    public class ProductType
    {

        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
