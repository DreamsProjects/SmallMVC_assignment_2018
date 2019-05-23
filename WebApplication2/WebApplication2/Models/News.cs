using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class News
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Headline { get; set; }
        [Required]
        public string NewsText { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public List<News> List = new List<News>();

        public NewsKategori Kategori { get; set; }

        public News(int id, string titel, string text)
        {
            ID = id;
            Headline = titel;
            NewsText = text;
        }

        public News()
        {

        }

    }
}
