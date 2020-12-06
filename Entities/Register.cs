using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Register
    {
        public int ID { get; set; }
        public int ID_USER { get; set; }
        public int ID_BUILDING { get; set; }
        public string ENTRY { get; set; }
        public string EXIT { get; set; }
        public string REASON { get; set; } //THAT MEANS THE VISIT REASON
        public int ID_CLASSROOM { get; set; }


    }
}
