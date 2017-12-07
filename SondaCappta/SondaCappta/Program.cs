using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaCappta
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a posição inicial da Sonda(int int string(N,S,E,W))");
                string posicaoInicial = Console.ReadLine();
                Console.WriteLine("Digite a série de instruções(string(L,R,M))");
                string serieInstrucoes = Console.ReadLine();

                //0 0 e
                //m

                string[] posicao = posicaoInicial.ToLower().Split(' ');

                if (!String.IsNullOrEmpty(serieInstrucoes) && posicao.Length == 3)
                {
                    foreach (char item in serieInstrucoes.ToLower())
                    {
                        if (item.Equals('m'))
                        {
                            if (posicao[2].Equals("n"))
                            {
                                posicao[0] = (Convert.ToInt32(posicao[0]) - 1).ToString();
                            }
                            else if (posicao[2].Equals("s"))
                            {
                                posicao[0] = (Convert.ToInt32(posicao[0]) + 1).ToString();
                            }
                            else if (posicao[2].Equals("e"))
                            {
                                posicao[1] = (Convert.ToInt32(posicao[1]) + 1).ToString();
                            }
                            else
                            {
                                posicao[1] = (Convert.ToInt32(posicao[1]) - 1).ToString();
                            }
                        }
                        else if (item.Equals('r'))
                        {
                            if (posicao[2].Equals("n"))
                            {
                                posicao[2] = "e";
                            }
                            else if (posicao[2].Equals("s"))
                            {
                                posicao[2] = "w";
                            }
                            else if (posicao[2].Equals("e"))
                            {
                                posicao[2] = "s";
                            }
                            else
                            {
                                posicao[2] = "n";
                            }
                        }
                        else
                        {
                            if (posicao[2].Equals("n"))
                            {
                                posicao[2] = "w";
                            }
                            else if (posicao[2].Equals("s"))
                            {
                                posicao[2] = "e";
                            }
                            else if (posicao[2].Equals("e"))
                            {
                                posicao[2] = "n";
                            }
                            else
                            {
                                posicao[2] = "s";
                            }
                        }
                    }
                    posicaoInicial = posicao[0] + " " + posicao[1] + " " + posicao[2].ToUpper();
                }


                Console.WriteLine("Posição atual da Sonda");
                Console.WriteLine(posicaoInicial);

                Console.WriteLine("Deseja continuar? (S/N)");
                
            } while (Console.ReadLine().ToLower().Equals("s") ? true : false);
        }
    }
}
