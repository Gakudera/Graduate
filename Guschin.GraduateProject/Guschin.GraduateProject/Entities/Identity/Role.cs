using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guschin.GraduateProject.Entities.Identity
{
    public class Role
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
