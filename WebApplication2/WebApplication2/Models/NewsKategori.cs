using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class NewsKategori
    {
        [Key]
        public int Id { get; set; }
        public string Namn { get; set; }

    }
}
