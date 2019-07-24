using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class EmployeeEditViewModel
    {

        [Key]
        public int EmployeeId { get; set; }


        [StringLength(70)]
        public string Address { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [StringLength(40)]
        public string State { get; set; }

        [StringLength(40)]
        public string Country { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [StringLength(24)]
        public string Fax { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        //added the required data annotation due to it being a password
        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Range(2, 6)]
        public int Vacation { get; set; }
    }
}