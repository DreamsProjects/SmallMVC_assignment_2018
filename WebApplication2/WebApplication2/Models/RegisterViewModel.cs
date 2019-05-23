using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
            Country = new List<SelectListItem>();
            UserType = new List<SelectListItem>();
        }

        public Register Register { get; set; }
        public List<SelectListItem> Country { get; set; }
        public List<SelectListItem> UserType { get; set; }
    }
}
