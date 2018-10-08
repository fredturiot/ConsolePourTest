using System;

namespace ConsolePourTEst.Models
{
    public class LignePanier
    {
        //public static int ID { get; set; }   
        //pas d'id car pas d'enregistrement en base
        public Produit Produit { get; set; }
        public int Quantity { get; set; }
        public void Valider()
        {
            if (Quantity < 0)
                throw new Exception("Quantite doit etre positive");
            if (Produit == null)
                throw new Exception("Produit est requis");
        }

    }
}
