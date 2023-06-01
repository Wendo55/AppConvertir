using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppConvertir
{
    [DataContract]
    internal class DataSerie
    {
        [DataMember(Name = "fecha")]
        public string Date { get; set; }

        [DataMember(Name = "dato")]
        public string Data { get; set; }
    }
}
