using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string LASTNAME { get; set; }
        public DateTime BIRTH { get; set; }
        public int TYPE { get; set; } //WHEN IS 0 IT'S AN ADMIN AND 1 IT'S A GENERAL USER
        public string USER { get; set; }
        public string PASSWORD { get; set; }
        public string CAREER { get; set; }
        public string MAIL { get; set; }
        public string PICTURE { get; set; }

    }
}
