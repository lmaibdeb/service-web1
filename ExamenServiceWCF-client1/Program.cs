using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenServiceWCF_client1.GestionProjetReference;

namespace ExamenServiceWCF_client1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionServiceClient client
                = new GestionServiceClient("BasicHttpBinding_IGestionService");

            //Saisir les information du projet
            Console.WriteLine("Saisir le code du projet:");
            string code = Console.ReadLine();
            Console.WriteLine("Saisir la description du projet:");
            string description = Console.ReadLine();

            //Créer le projet - insérer dans la bd
            client.GererProjet(code, description);

            Console.WriteLine("Le projet a été créé");
            Console.ReadKey();
        }
    }
}
