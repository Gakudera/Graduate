using System;

namespace Guschin.GraduateProject.Entities.Identity
{
    public class Person
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }

        public Guid? UserId { get; set; }

        public User User { get; set; }
    }
}
