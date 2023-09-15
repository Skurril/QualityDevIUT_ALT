using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1_Quali_Dev.Classe
{
    internal class Library
    {

        private List<Media> medias = new List<Media>();

        public Media this[int numeroReference]
        {
            get
            {
                return medias.Find(media => media.numRef == numeroReference);
            }
        }

        public void AjouterMedia(Media media)
        {
            medias.Add(media);
        }

        public void RetirerMedia(Media media)
        {
            medias.Remove(media);
        }

       
        public List<Media> RechercherMedia(string termeRecherche)
        {
            return medias.FindAll(media => media.titre.Contains(termeRecherche));
        }

    }
}
