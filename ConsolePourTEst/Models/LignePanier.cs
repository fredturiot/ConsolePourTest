namespace ConsolePourTEst.Models
{
    class LignePanier
    {
        //public static int ID { get; set; }   
        //pas d'id car pas d'enregistrement en base
        public Produit Produit { get; set; }
        public int Quantity { get; set; }
    }
}
