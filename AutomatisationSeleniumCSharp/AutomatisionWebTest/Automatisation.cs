////////////////////////////////////////////////////////////
/// Propriétaire du programme : CodeRedempteur          ///
/// Youtube : https://www.youtube.com/@CodeRedempteur   ///
///////////////////////////////////////////////////////////
using Keys = OpenQA.Selenium.Keys;
using System.Diagnostics;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
namespace AutomatisionWebTest
{
    namespace AutomatisionWebTest
    {
        // Déclaration de l'espace de noms, qui regroupe les classes liées à l'automatisation de tests web.
        internal class Automatisation
        {
            // Constructeur par défaut de la classe Automatisation, ne fait rien de particulier ici.
            public Automatisation(){}
            // Méthode qui lance le navigateur Chrome et effectue des actions sur YouTube.
            public void LauchChrome()
            {
                // Instanciation du driver Chrome, ce qui ouvre une nouvelle fenêtre de Chrome.
                var driver = new ChromeDriver();
                try
                {
                    // Définit l'URL à laquelle le navigateur doit se rendre (une chaîne YouTube).
                    driver.Url = "https://www.youtube.com/channel/UC4w6n_v3M9KP4-A_JdHjeqQ";

                    // Attend 3 secondes pour s'assurer que la page est bien chargée.
                    Thread.Sleep(3000);

                    // Recherche un bouton "Tout refuser" en utilisant le sélecteur CSS basé sur l'attribut 'aria-label'.
                    var button = driver.FindElement(By.CssSelector("[aria-label='Tout refuser']"));

                    // Attend 2 secondes avant d'interagir avec le bouton pour éviter les problèmes de synchronisation.
                    Thread.Sleep(2000);

                    // Simule un clic sur le bouton "Tout refuser" pour refuser les cookies.
                    button.Click();

                    // Attend 2 secondes après le clic pour s'assurer que l'interaction est bien terminée.
                    Thread.Sleep(2000);

                    // Recherche la barre de recherche de YouTube en utilisant son 'aria-label'.
                    var inputSearchYtb = driver.FindElement(By.CssSelector("[aria-label='Rechercher']"));

                    // Attend encore 2 secondes pour laisser la page se stabiliser après l'apparition de la barre de recherche.
                    Thread.Sleep(2000);

                    // Saisit "Code Redempteur" dans la barre de recherche.
                    inputSearchYtb.SendKeys("Code Redempteur");

                    // Attend encore 2 secondes pour voir l'entrée dans le champ de recherche.
                    Thread.Sleep(2000);

                    // Envoie la touche 'Enter' pour lancer la recherche.
                    inputSearchYtb.SendKeys(Keys.Enter);

                    // Attend encore 2 secondes pour que les résultats de recherche apparaissent.
                    Thread.Sleep(2000);

                    // Le driver est volontairement laissé ouvert ici. Pour fermer l'application, utilisez 'driver.Close()'.
                    // driver.Close(); // Sert à fermer l'application (ferme la fenêtre du navigateur).
                }
                catch
                {
                    // En cas d'erreur, cela affiche "error" dans la sortie de débogage.
                    Debug.Print("error");
                }
            }
        }
    }

}
