////////////////////////////////////////////////////////////
/// Propriétaire du programme : CodeRedempteur          ///
/// Youtube : https://www.youtube.com/@CodeRedempteur   ///
///////////////////////////////////////////////////////////
using AutomatisionWebTest.AutomatisionWebTest;
namespace AutomatisionWebTest
{
    internal class Program
    {
        /// <summary>
        /// Entrée du programme
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Instentition de la classe Automatisation
            Automatisation auto = new Automatisation();
            //Appel de la methode LauchChrome
            auto.LauchChrome();
        }
    }
}
