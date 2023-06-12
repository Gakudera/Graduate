using Guschin.GraduateProject.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guschin.GraduateProject.Entities.Messaging
{
    public class Message
    {
        public Guid Id { get; set; }

        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }

        public Chat Chat { get; set; }
        public User User { get; set; }
    }
}
