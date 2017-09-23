using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BESHMC_CAMP
    {
        public int COD_CAMP { get; set; }
        public int COD_CLIE { get; set; }
        public string ALF_CAMP { get; set; }
        public DateTime FEC_DESD { get; set; }
        public DateTime FEC_HAST { get; set; }
        public bool IND_CERR { get; set; }
        public string ALF_CLIE { get; set; }
        public string COD_USUA_CREA { get; set; }
        public string COD_USUA_MODI { get; set; }
        public int NUM_ACCI { get; set; }

    }
}
