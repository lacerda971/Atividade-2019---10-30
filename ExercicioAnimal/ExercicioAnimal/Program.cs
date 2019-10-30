using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            Console.WriteLine("O animal e mamifero?");
            resposta = Console.ReadLine();


            if (resposta == "sim")

            {
                Console.WriteLine("o animal e um quadrupede?");
                resposta = Console.ReadLine();
                if (resposta == "sim")
                {
                    Console.WriteLine("o animal e um carnivoro?");
                    resposta = Console.ReadLine();
                    if (resposta == "sim")
                    {
                        Console.WriteLine("o animal é o leão!");

                    }
                    else
                    {
                        Console.WriteLine("o animal e um herbivoro?");
                        resposta = Console.ReadLine();
                        if (resposta == "sim")
                        {
                            Console.WriteLine("o animal é o cavalo!");

                        }
                        else
                        {
                            Console.WriteLine("Animal inesistente!");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("o animal e um bipede?");
                    resposta = Console.ReadLine();
                    if ( resposta == "sim")
                    {
                        Console.WriteLine("o animal e um onivoro?");
                        resposta = Console.ReadLine();
                        if ( resposta == "sim")
                        {
                            Console.WriteLine("o animal é o homem!");
                        }
                        else
                        {
                            Console.WriteLine("o animal e um frutivoro?");
                            resposta = Console.ReadLine();
                            if ( resposta == "sim")
                            {
                                Console.WriteLine("o animal é o macaco!");
                            }
                            else
                            {
                                Console.WriteLine("Animal inesistente!");
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("o animal e um voador?");
                        resposta = Console.ReadLine();
                        if (resposta == "sim")
                        {
                            Console.WriteLine("o animal é o morcego !");
                        }
                        else
                        {
                            Console.WriteLine("o animal e aquatico?");
                            resposta = Console.ReadLine();
                            if (resposta == "sim")
                            {
                                Console.WriteLine("o animal é o baleia!");
                            }
                            else
                            {
                                Console.WriteLine("Animal inesistente!");
                            }
                        }
                    }
                    
                }


            }
            else
            {
                Console.WriteLine("O animal é uma ave?");
                resposta = Console.ReadLine();
                if ( resposta == "sim")
                {
                    Console.WriteLine("O animal é não-voador ?");
                    resposta = Console.ReadLine();
                    if (resposta == "sim")
                    {
                        Console.WriteLine("O animal é tropical?");
                        resposta = Console.ReadLine();
                        if (resposta == "sim")
                        {
                            Console.WriteLine("o animal é um avestruz!");
                        }
                        else
                        {
                            Console.WriteLine("O animal é polar?");
                            resposta = Console.ReadLine();
                            if (resposta == "sim")
                            {
                                Console.WriteLine("o animal é um pinguim!");
                            }
                            else
                            {
                                Console.WriteLine("Animal inesistente!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("O animal é nadador?");
                        resposta = Console.ReadLine();
                        if (resposta == "sim")
                        {
                            Console.WriteLine("o animal é um pato!");
                        }
                        else
                        {
                            Console.WriteLine("O animal é de rapina?");
                            resposta = Console.ReadLine();
                            if ( resposta == "sim")
                            {
                                Console.WriteLine("o animal é um águia!");
                            }
                            else
                            {
                                Console.WriteLine("Animal inesistente!");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("O animal é um réptil?");
                    resposta = Console.ReadLine();
                    if (resposta == "sim")
                    {
                        Console.WriteLine("Ele tem casco?");
                        resposta = Console.ReadLine();
                        if (resposta == "sim")
                        {
                            Console.WriteLine("O animal é uma tartaruga!");
                        }
                        else
                        {
                            Console.WriteLine("O animal é um carnivoro?");
                            resposta = Console.ReadLine();
                            if (resposta == "sim")
                            {
                                Console.WriteLine("O animal é uma crocodilo!");
                            }
                            else
                            {
                                Console.WriteLine("O animal é sem patas?");
                                resposta = Console.ReadLine();
                                if (resposta == "sim")
                                {
                                    Console.WriteLine("O animal é uma cobra!");
                                }
                                else
                                {
                                    Console.WriteLine("Animal inesistente!");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Animal inesistente");
                    }
                }
            }
            //( resp.ToUpper () =="S" )
            Console.ReadKey();
        }
    }
}