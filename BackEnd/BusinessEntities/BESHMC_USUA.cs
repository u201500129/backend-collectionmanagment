using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BusinessEntities
{
    [DataContract]
    public class BESHMC_USUA
    {
        [DataMember]
        public string COD_USUA { get; set; }
        [DataMember]
        public string ALF_PASS { get; set; }
        [DataMember]
        public string ALF_PASS_REPE { get; set; }
        [DataMember]
        public int COD_AGEN { get; set; }
        [DataMember]
        public int COD_TIPO_USUA { get; set; }
        [DataMember]
        public string ALF_AGEN { get; set; }
        [DataMember]
        public string ALF_DNII { get; set; }
        [DataMember]
        public string ALF_DIRE { get; set; }
        [DataMember]
        public int NUM_TOKE { get; set; }
        [DataMember]
        public bool IND_ACTI { get; set; }
        [DataMember]
        public string COD_USUA_CREA { get; set; }
        [DataMember]
        public string COD_USUA_MODI { get; set; }
        [DataMember]
        public int NUM_ACCI { get; set; }
    }
}
