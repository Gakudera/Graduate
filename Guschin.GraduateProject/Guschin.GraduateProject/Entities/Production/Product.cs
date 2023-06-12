using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guschin.GraduateProject.Entities.Production
{
    public class Product
    {
       
       

        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string? Logo { get; set; }



        public Guid ProductTypeId { get; set; }

        public ProductType ProductType { get; set; }

        public string CorrectLogoPath
        {
            get => (Logo == null | Logo == string.Empty) ? @"\Resources\picture.png" : $@"\Resources{Logo}";
        }



    }
}
