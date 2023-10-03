using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ExamenServiceWCF
{
    [ServiceContract]
    internal interface IGestionService
    {
        [OperationContract]
        void GererProjet(string code, string description);

        [OperationContract]
        string RecupererProjet(string code);
    }
}
