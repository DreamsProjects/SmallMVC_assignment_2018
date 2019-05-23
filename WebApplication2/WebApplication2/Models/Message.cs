using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }


        public override string ToString()
        {
            Id++;
            Text = "Nu har sidan laddats om " + Id + " gånger";
            return Text;
        }
    }
}
