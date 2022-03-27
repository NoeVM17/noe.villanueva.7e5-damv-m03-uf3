using System;
using System.IO;
namespace MastermindV3
{
    /// <summary>
    /// Classe OutData on tindrem mètodes només per mostrar resultats a l'usuari.
    /// </summary>
    public class OutData
    {
        /// <summary>
        /// Mètode on es mostra la combinació correcta i es surt del programa.
        /// </summary>
        /// <param name="comb"></param>
        public static void SortirPrograma(string comb)
        {
            Console.WriteLine("La combinació era: " + comb);
            Console.WriteLine("");
            Console.WriteLine("Prem una tecla per sortir!");
            Console.ReadKey();
        }
        /// <summary>
        /// Mètode de informació sobre els intents restants que li queden al jugador.
        /// </summary>
        /// <param name="rightposition">Lletres en posició correcta.</param>
        /// <param name="wrongposition">Lletres en posició incorrecta.</param>
        /// <param name="intents">Intents restants.</param>
        public static void IntentsRestants(int rightposition,int wrongposition, int intents)
        {
            Console.WriteLine("");
            Console.WriteLine("Right position = " + rightposition + ", Wrong position = " + wrongposition);
            Console.WriteLine("Et queden " + intents + " intents.");
            Console.WriteLine("");
        }
        /// <summary>
        /// Writelines en el cas de victoria.
        /// </summary>
        public static void Victoria()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ENHORABONA! Has guanyat!!"); 
            Console.ResetColor();
            Console.WriteLine("");
        }
        /// <summary>
        /// Writelines en el cas de derrota.
        /// </summary>
        public static void Derrota()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Has perdut!! T'has quedat sense intents :( ");
            Console.ResetColor();
            Console.WriteLine("");
        }
        /// <summary>
        /// Mètode de creació del document del ranking o actualització del document.
        /// </summary>
        public static void Ranking()
        {
            var path = @"../../../../RankingPosicions";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("---RANKING DE POSICIONS---");
                    sw.WriteLine("");
                }
            }
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while (((s = sr.ReadLine()) != null))
                    {
                        Console.WriteLine(s);
                    }
                    Console.ReadKey();
                }
            }
        }
        public static void ReglesJoc()
        {
            var path = @"../../../../ReglesDeJoc";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("---REGLES DEL JOC---");
                    sw.WriteLine("");
                    sw.WriteLine("• Combinació aleatòria de 4 lletres, entre A, B, C, D, E i F.");
                    sw.WriteLine("");
                    sw.WriteLine("• Combinació sense repetició de lletres. ");
                    sw.WriteLine("");
                    sw.WriteLine("• 12 intents. ");
                    sw.WriteLine("");
                    sw.WriteLine("• Informació orientativa després de cada intent sobre la combinació: ");
                    sw.WriteLine("  • Posicions correctes / posicions incorrectes.");
                }
            }
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while (((s = sr.ReadLine()) != null))
                    {
                        Console.WriteLine(s);
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}