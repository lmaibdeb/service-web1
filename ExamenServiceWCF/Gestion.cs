using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExamenServiceWCF
{
    [DataContract]
    internal class Gestion
    {
        [DataMember]
        public string codeProjet;
        [DataMember]
        public string description;

    }
}
