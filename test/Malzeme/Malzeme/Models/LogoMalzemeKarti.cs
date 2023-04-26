using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malzeme.Models
{
    public class LogoMalzemeKarti
    {
        public int CARD_TYPE { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }

        public string GUID { get; set; }
        public int LOGOREF { get; set; }
    }
}
