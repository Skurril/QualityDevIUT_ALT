using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_Quali_Dev.Classe
{
    internal class DVD : Media
    {
        public string Realisateur { get; set; }

        public int Duree { get; set; }

        public DVD(string Titre, int numeroReference, int nombreExemplaires, string Duree)
       : base(Titre, numeroReference, nombreExemplaires)
        {
            Duree = Duree;
        }

        public override void AfficherInfos()
        {
            base.AfficherInfos();

            Console.Out.WriteLine("Réalisateur: " + Realisateur + "Durée: " + Duree);
        }
    }
}
