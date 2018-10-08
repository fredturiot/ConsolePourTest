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
                    Prix = 90m
                },
                Quantity=1
            });
            Assert.AreEqual(100, panier.GetTotal());
        }
        [TestMethod]
        public void CalculFraisPortOffertsSiSupperieur100()
        {
            var panier = new Panier();
            panier.Lignes.Add(new LignePanier
            {
                Produit = new Produit()
                {
                    Name = "chainsow",
                    Prix = 90m
                },
                Quantity = 2
            });
            Assert.AreEqual(180, panier.GetTotal());
        }


    }
}

