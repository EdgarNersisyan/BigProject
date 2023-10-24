using System;
using System.Collections.Generic;
using System.Text;

namespace BigProject.DAL.Models
{
    class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public Qualifications Qualifications { get; set; }
        public Responsibilities Responsibilities { get; set; }
        public Position Position { get; set; }
    }
}
