using Guschin.GraduateProject.Entities.Identity;
using Guschin.GraduateProject.Entities.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guschin.GraduateProject.Entities.Messaging
{
    public class Chat
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }
        /// <summary>
        /// True - открыт, false - закрыт
        /// </summary>
        public bool Status { get; set; }
                
        public Guid ProductId { get; set; }
                
        public Product Product { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<ChatUser> ChatUsers { get; set; }
    }
}
