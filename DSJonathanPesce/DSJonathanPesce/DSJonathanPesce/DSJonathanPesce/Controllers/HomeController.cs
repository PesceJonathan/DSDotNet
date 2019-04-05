using DSJonathanPesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSJonathanPesce.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int displayAction = 0, int typeDeProduit = 0, String nomDeProduit = "")
        {
            List<Produit> produits = generateProducts();
            if (displayAction == 1)
            {
                return View("ListElements", produits.OrderBy(x => x.LeNom));
            } else if (displayAction == 2)
            {
                return View("ListElements", produits.Where(x=> x.LeType == typeDeProduit));
            } else if (displayAction == 3) {
                return View("ListElements", produits.OrderBy(x => x.LePrix));
            } else if (displayAction == 4)
            {
                Produit produit = produits.FirstOrDefault(x => x.LeNom.Equals(nomDeProduit));
                if (produit != null)
                    return View("View", produit);

                ViewBag.errorMessage = "Ce produit n'existe pas";
                return View();
            }

            return View();
        }

        private List<Produit> generateProducts()
        {
            List<Produit> produits = new List<Produit>();
            produits.Add(new Produit("Monopoly", 1, 20.12));
            produits.Add(new Produit("Risk", 1, 32.24));
            produits.Add(new Produit("Sorry", 1, 9.99));
            produits.Add(new Produit("Barbie", 2, 16.00));
            produits.Add(new Produit("GIJOE", 2, 17.45));
            produits.Add(new Produit("Avengers", 3, 4.99));
            produits.Add(new Produit("Avengers Age Of Ultron", 3, 5.99));
            produits.Add(new Produit("Avengers Infinity War", 3, 6.99));
            produits.Add(new Produit("Avengers End Game", 3, 9.97));

            return produits;
        }
    }
}