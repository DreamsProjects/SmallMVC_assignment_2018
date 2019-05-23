using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Register
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName{ get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Losenord { get; set; }
        [Required]
        public string ConfirmLosenord { get; set; }

        public int Country { get; set; }
        public int UserType { get; set; }

        public bool Want { get; set; }

    }
}
