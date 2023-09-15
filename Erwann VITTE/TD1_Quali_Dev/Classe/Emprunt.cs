using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_Quali_Dev.Classe
{
    internal class Emprunt
    {
        public Media MediaEmprunte { get; set; }
        public DateTime DateEmprunt { get; set; }
        public DateTime DateRetour { get; set; }


        public void EmprunterMedia(Media media)
        {
            if (media.nbExemplaire > 0)
            {
                media.nbExemplaire--;
                Console.WriteLine($"Emprunt de '{media.titre}' effectué.");
            }
            else
            {
                Console.WriteLine($"Désolé, '{media.titre}' n'est pas disponible pour l'emprunt.");
            }
        }

        public void RetournerMedia(Media media)
        {
            media.nbExemplaire++;
            Console.WriteLine($"Retour de '{media.titre}' effectué.");
        }


    }

}
