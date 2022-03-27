using System;
namespace MastermindV3
{ 
    public class Menu
    {
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
            //string [,] jugadors = InData.RankNameInts();
            //string[] nomsRanking = InData.RankName();
            //int[] intentsRanking = InData.RankInts();
            //Mètodes.ActMatriu(ref nomsRanking, ref intentsRanking, nom, intentsjugador);
            Mètodes.NomRanking(path, nom, intentsjugador);
        }
        public static void Exercici2()
        {
            OutData.Ranking();
        }
        public static void Exercici3()
        {
            OutData.ReglesJoc();
        }
    }
}