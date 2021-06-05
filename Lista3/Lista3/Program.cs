﻿using System;
using System.Collections.Generic;

namespace Lista3
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "...Uma atividade livre, conscientemente tomada como “não - séria” e exterior à vida habitual, mas ao mesmo tempo capaz de absorver " +
                "o jogador de maneira intensa e total. É uma atividade desligada de todo e qualquer interesse material, com a qual não se pode obter qualquer lucro, " +
                "praticada dentro de limites espaciais e temporais próprios, segundo uma certa ordem e certas regras. Promove a formação de grupos sociais com tendência " +
                "a rodearem-se de segredo e a sublinharem sua diferença em relação ao resto do mundo por meio de disfarces ou outros meios semelhantes.";



            Console.WriteLine("Palavras no texto: " + VerificarQuantidadePalavras(texto));
            Console.WriteLine("Palavras diferentes no texto: " + VerificarQuantidadePalavrasDiferentes(texto));
            VerificarPalavrasRepetidas(texto);
        }

        static int VerificarQuantidadePalavras(string texto)
        {
            List<string> palavrasColetadas = new List<string>();
            string[] palavras = texto.Split(' ', ',', '.', '-', '“', '”', '"');

            foreach (var item in palavras)
            {
                if (item.Length != 0)
                {
                        palavrasColetadas.Add(item.ToLower());

                }
            }

            return palavrasColetadas.Count;
        }
        static int VerificarQuantidadePalavrasDiferentes(string texto)
        {
            List<string> palavrasColetadas = new List<string>();
            string[] palavras = texto.Split(' ', ',', '.', '-', '“', '”', '"');

            foreach (var item in palavras)
            {
                if (item.Length != 0)
                {
                    if (!palavrasColetadas.Contains(item))
                        palavrasColetadas.Add(item.ToLower());

                }
            }

            return palavrasColetadas.Count;
        }
        static void VerificarPalavrasRepetidas(string texto)
        {
            Console.WriteLine();
            Console.WriteLine("Quantas vezes cada palavra foi repetida:");
            Console.WriteLine("------------------------------------------");

            List<string> palavrasColetadas = new List<string>();
            List<string> palavrasJaContadas = new List<string>();
            string[] palavras = texto.Split(' ', ',', '.', '-', '“', '”', '"');

            foreach (var item in palavras)
            {
                if (item.Length != 0)
                {
                        palavrasColetadas.Add(item.ToLower());
                }
            }

            foreach (var item in palavrasColetadas)
            {
                int VezesRepetida = 0;
                if (!palavrasJaContadas.Contains(item))
                {
                    foreach (var itemAnalise in palavrasColetadas)
                    {
                        palavrasJaContadas.Add(item.ToLower());
                        if (item == itemAnalise)
                        {
                            VezesRepetida++;
                        }
                    }

                    Console.WriteLine($"{item}: {VezesRepetida}");
                }
            }


        }
    }
}
