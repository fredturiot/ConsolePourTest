using System;
using ConsolePourTEst.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePour_TestTests
{
    [TestClass]
    public class LignePanierTests
    {
        [TestMethod]
        public void ValiderQuantitePositive()
        {
            var lignePanier = new LignePanier
            {

                Produit = new Produit(),
                Quantity = -1

            };

            var exception = Assert.ThrowsException<Exception>(() => lignePanier.Valider());
            Assert.AreEqual("Quantite doit etre positive", exception.Message);
        }
        [TestMethod]
        public void ValiderProduitRenseigne()
        {
            var lignePanier = new LignePanier
            {

                Produit = null,
                Quantity = 1

            };

            var exception = Assert.ThrowsException<Exception>(() => lignePanier.Valider());
            Assert.AreEqual("Produit est requis", exception.Message);
            // les messages d'erreur sont comparés !!!
        }
    }
}
