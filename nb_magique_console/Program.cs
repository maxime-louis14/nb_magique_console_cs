using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nb_magique_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreMagique = 5;
            
            while (true)
            {

                Console.WriteLine("devinez le nombre magique: ");
                String reultat = Console.ReadLine();

                int nombreUtilisateur = 0;
                if (int.TryParse(reultat, out nombreUtilisateur)) {
                    //La convertion s'est bien passée;

                    if (nombreUtilisateur < nombreMagique) {
                        Console.WriteLine("Le nombre magique est plus grand ");
                    }
                    else if(nombreUtilisateur > nombreMagique) {
                        Console.WriteLine("Le nombre magique est plus petit. ");
                    }
                    else {
                        //Egalité
                        Console.WriteLine("BRAVO: Vous avez trouvé le nombre magique");
                    }

                } else {
                    //Erreur de la conversion
                    Console.WriteLine("ERREUR: vous devez rentre un nombre.");
                  }

           }
        }
    }
}
