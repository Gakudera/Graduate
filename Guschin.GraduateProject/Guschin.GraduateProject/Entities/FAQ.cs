using Guschin.GraduateProject.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guschin.GraduateProject.Entities
{
    public class FAQ
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
