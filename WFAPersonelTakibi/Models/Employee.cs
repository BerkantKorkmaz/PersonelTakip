using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPersonelTakibi.Models
{
    public class Employee
    {
        public Employee()
        {
            this.ID = new Guid();
        }

        public Guid ID { get; set; }
        [
            Required,
            MaxLength(50)
        ]
        public string FirstName { get; set; }
        [
            Required,
            MaxLength(50)
        ]
        public string LastName { get; set; }
        [
            Required
        ]
        public DateTime BirthDate { get; set; }
        public string EMail { get; set; }
        [
            Required
        ]
        public Gender Gender { get; set; }
        [
            Required,
           
        ]
        public Department Department { get; set; }
        [
            Required,
            MaxLength(24)
        ]
        public string Phone { get; set; }
        [
            Required,
            MaxLength(300)
        ]
        public string Address { get; set; }
        [
            MaxLength(150)
        ]
        public string ImageUrl { get; set; }


    }

}
