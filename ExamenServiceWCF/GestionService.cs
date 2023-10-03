using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ExamenServiceWCF
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class GestionService : IGestionService
    {
        #region IConversionService Membres
        public void GererProjet(string code, string description)
        {
            DAO.insertProjet(code, description);
        }

        public string RecupererProjet(string code)
        {
            string resultat = DAO.selectProjet(code);
            return resultat;
        }
        #endregion
    }
}
