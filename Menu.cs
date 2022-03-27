using System;
namespace MastermindV3
{ 
    /// <summary>
    /// Classe Menu on tenim el Menu per controlar les instruccions i els mètodes de cada exercici.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Mètode Inici on controlarem l'inici del programa i quan s'acabara l'execució.
        /// </summary>
        public void Inici()
        {
            bool fi;
            do
            {
                Console.Clear();
                MostrarMenu();
                fi = TractarOpcio();
            } while (!fi);
        }
        /// <summary>
        /// Writelines amb els missatges sobre les instruccions del menu.
        /// </summary>
        public static void MostrarMenu()
        {
            Console.WriteLine("\nMASTERMIND V3");
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.WriteLine("[1] Començar a jugar.");
            Console.WriteLine("[2] Veure el ranking.");
            Console.WriteLine("[3] Regles del joc.");
            Console.WriteLine("[4] Finalitzar execució.");
            Console.WriteLine("Opció:");
        }
        /// <summary>
        /// Mètode on controlem les instruccions i el final de l'execució.
        /// </summary>
        /// <returns>Retorna un booleà per indicar que es vol acabar l'execució.</returns>
        private bool TractarOpcio()
        {
            var finalitzacio = false;
            var opcio = Console.ReadLine();

            switch (opcio)
            {
                case "1":
                    Console.Clear();
                    Exercici1();
                    break;
                case "2":
                    Console.Clear();
                    Exercici2();
                    break;
                case "3":
                    Console.Clear();
                    Exercici3();
                    break;
                case "4":
                    finalitzacio = true;
                    break;
                default:
                    Console.WriteLine("Opció incorrecta!");
                    break;
            }
            return finalitzacio;
        }
        /// <summary>
        /// Mètode del primer exercici on accedim a altres cs per fer altres mètodes necessaris per executar el primer exercici.
        /// </summary>
        public static void Exercici1()
        {
            InData.IniciJoc();
            string nom = InData.Nom();
            Console.Clear();
            string comb = Mètodes.Combinacio();
            InData.JocInici();
            int intents = InData.Intents();
            int intentsjugador = InData.IntentsJugador();
            bool final = false;
            do
            {
                string intent = InData.CombInicial();
                Mètodes.ComprovarComb(intent,comb,ref intents,ref final, ref intentsjugador);
            } while (!final);
            var path = @"../../../../RankingPosicions";
            Mètodes.NomRanking(path, nom, intentsjugador);
        }
        /// <summary>
        /// Mètode del segon exercici on accedim a altres cs, en aquest cas per mostrar el ranking de jugadors.
        /// </summary>
        public static void Exercici2()
        {
            OutData.Ranking();
        }
        /// <summary>
        ///  Mètode del tercer exercici on accedim a altres cs, en aquest cas per mostrar les regles del Mastermind.
        /// </summary>
        public static void Exercici3()
        {
            OutData.ReglesJoc();
        }
    }
}