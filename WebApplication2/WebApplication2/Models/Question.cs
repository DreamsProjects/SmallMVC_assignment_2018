using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Email { get; set; }
        public string QuestionText { get; set; }

        //public List<SelectListItem> Country {get;set;}
        //public List<SelectListItem> UserType { get; set; }


        public Question(string mail, string text)
        {
            Email = mail;
            QuestionText = text;
        }

        public Question()
        {

        }
    }
}
