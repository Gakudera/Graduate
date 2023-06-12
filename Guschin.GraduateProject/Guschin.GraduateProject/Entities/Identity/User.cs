using Guschin.GraduateProject.Entities.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guschin.GraduateProject.Entities.Identity
{
    public class User
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public bool PhoneNumberConfirmed { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public Person Person { get; set; }

        public ICollection<Message> Messages { get; set; }
        public ICollection<ChatUser> ChatUsers { get; set; }
    }
}
