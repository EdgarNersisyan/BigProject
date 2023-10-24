using System;
using System.Collections.Generic;
using System.Text;

namespace BigProject.DAL.Models
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime DateModified { get; set; }
    }
}
