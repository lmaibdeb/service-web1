using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenServiceWCF_client2.GestionProjetReference;

namespace ExamenServiceWCF_client2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionServiceClient client
                = new GestionServiceClient("BasicHttpBinding_IGestionService");

            //Saisir le code du projet à récupérer
            Console.WriteLine("Saisir le code du projet:");
            string code = Console.ReadLine();

            //Récupérer les infos du projet
            string info = client.RecupererProjet(code);

            Console.WriteLine("Information du projet " +code +": " + info);
            Console.ReadKey();
        }
    }
}
