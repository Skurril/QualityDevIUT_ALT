using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_Quali_Dev.Classe
{
    internal class CD : Media
    {
        public string Artiste { get; set; }

        public int Duree { get; set; }

        public CD(string Titre, int numeroReference, int nombreExemplaires, string artiste)
       : base(Titre, numeroReference, nombreExemplaires)
        {
            Artiste = artiste;
        }
        public override void AfficherInfos()
        {
            base.AfficherInfos();

            Console.Out.WriteLine("Artiste: " + Artiste + "Durée: " + Duree);
        }
    }
}
