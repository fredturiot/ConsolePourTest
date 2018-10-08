using System;
using ConsolePourTEst.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePour_TestTests
{
    [TestClass]
    public class PanierTests
    {
        [TestMethod]
        public void CalculPrixTotalQuandVide()
        {
            var panier = new Panier();
            Assert.AreEqual(0, panier.GetTotal());
        }

        [TestMethod]
        public void CalculPrixTotal()
        {
            var panier = new Panier();
            panier.Lignes.Add(new LignePanier
            {
                Produit = new Produit()
                {
                    Name = "chainsow",
                    Price = 100m

                },
                Quantity=1
            });
            Assert.AreEqual(100, panier.GetTotal());
        }


    }
}

