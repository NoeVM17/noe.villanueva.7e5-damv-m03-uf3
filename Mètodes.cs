using System;
using System.IO;

namespace MastermindV3
{
    /// <summary>
    /// Classe Mètodes on tindrem tots els mètodes que necessitarem per controlar les combinacions, comprovar-les i anar donant la informació sobre els acerts i errors. També tindrem el mètode per crear el document amb el ranking dels jugadors.
    /// </summary>
    public class Mètodes
    {
        /// <summary>
        /// Mètode on es crea la combinació del Mastermind de manera aleatòria.
        /// </summary>
        /// <returns></returns>
        public static string Combinacio()
        {
            string comb = "";
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                char repetida = Convert.ToChar(rnd.Next(65, 71));

                if (comb.Contains(repetida))
                    i--;
                else
                {
                    comb += repetida;
                }
            }

            return comb;
        }
        /// <summary>
        /// Mètode on es comprova la combinació del jugador i es miren els acerts i errors que té.
        /// </summary>
        /// <param name="intent">Combinació provada pel jugador.</param>
        /// <param name="comb">Combinació del Mastermind per acertar.</param>
        /// <param name="intents">Intents restants per acertar la combinació.</param>
        /// <param name="final">Paràmetre per saber que s'ha acabat la partida.</param>
        /// <param name="intentsjugador">Intents que porta el jugador intentant-ho.</param>
        public static void ComprovarComb(string intent, string comb, ref int intents, ref bool final,
            ref int intentsjugador)
        {
            int rightposition = 0;
            int wrongposition = 0;
            
            for (int j = 0; j < 4; j++)
            {
                if (intent.Contains(comb[j]))
                {
                    if (intent[j] == comb[j])
                    {
                        rightposition = rightposition + 1;
                    }
                    else
                    {
                        wrongposition = wrongposition + 1;
                    }
                }
            }

            if (rightposition != 4 && intents != 0)
            {
                intents--;
                intentsjugador++;
                OutData.IntentsRestants(rightposition,wrongposition,intents);
            }
            
            if (rightposition == 4)
            {
                intentsjugador++;
                final = !final;
                OutData.Victoria();
                OutData.SortirPrograma(comb);
            }

            if (intents == 0 && rightposition != 4)
            {
                intentsjugador = 12;
                final = !final;
                OutData.Derrota();
                OutData.SortirPrograma(comb);
            }
        }
        /// <summary>
        /// Mètode per crear el ranking del Mastermind.
        /// </summary>
        /// <param name="path">Ruta de la carpeta per crear el document.</param>
        /// <param name="nom">Nom del jugador que està jugant.</param>
        /// <param name="intentsjugador">Intents que ha necessitat el jugador per acertar la combinació.</param>
        public static void NomRanking(string path, string nom, int intentsjugador)
        {
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
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(nom + " - " + intentsjugador + " intents");
                }
            }
        }
    }
}