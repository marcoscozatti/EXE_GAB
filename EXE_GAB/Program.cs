
//GABI legal
//companheira
using System;
using System.Data;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcao = 0;
        int subopcao = 0;

        while (opcao != 9)
        {
            Console.Clear();
            Console.WriteLine("\nSistema Veiculos");

            Console.WriteLine("1. Veículos");
            Console.WriteLine("2. Marcas");
            Console.WriteLine("3. Modelos");
            Console.WriteLine("9. Sair");
            Console.Write("Digite a opçâo: ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 9)  //VERDADEIRO  1
            {
                Console.WriteLine("Opção inválida, tente novamente.");
              
            }


            //opção 1 do menu
            if (opcao == 1) 
            {
                //Console.Clear();
                //Console.WriteLine("Você digitou número 1");
                //Console.ReadKey();
             //   Console.Clear();

                while (subopcao != 19)
                {
                    Console.WriteLine("\nVeículos");
                    Console.WriteLine("10. Inserir");
                    Console.WriteLine("11. Alterar");
                    Console.WriteLine("12. Excluir");
                    Console.WriteLine("13. Pesquisar");
                    Console.WriteLine("14. Exibir");
                    Console.WriteLine("19. Voltar para menu anterior");
                    Console.Write("Digite a opção: ");

                    subopcao = int.Parse(Console.ReadLine());
                    // Console.Clear();


                    if (subopcao == 10)
                    {
                        Console.Clear();
                        Console.WriteLine("Inserir Veículo");
                        Console.WriteLine("Aqui começa a execução do programa de Inserir");
                    }

                    if (subopcao == 11)
                    {
                        Console.Clear();
                        Console.WriteLine("Alterar Veículo");
                    }

                    if (subopcao == 12)
                    {
                        Console.Clear();
                        Console.WriteLine("Excluir Veículo");
                    }

                    if (subopcao == 13)
                    {
                        Console.Clear();
                        Console.WriteLine("Pesquisar Veículo");
                    }

                    if (subopcao == 14)
                    {
                        Console.Clear();
                        Console.WriteLine("Exibir Veículo");
                    }

                    if (subopcao == 19)
                    {
                        Console.WriteLine("Sair");
                    }

                    //switch (subopcao)
                    //{
                    //    case 10:
                    //        Console.WriteLine("Inserir Veículo");
                    //        break;
                    //    case 11:
                    //        Console.WriteLine("Alterar Veículo");
                    //        break;
                    //    case 12:
                    //        Console.WriteLine("Excluir Veículo");
                    //        break;
                    //    default:
                    //        Console.WriteLine("Número não é 1, 2 ou 3");
                    //        break;
                    //}

                }


            }


            //opção 2 do menu
            if (opcao == 2)
            {
                Console.Clear();
                Console.WriteLine("Marcas");
                Console.ReadKey();  


            }


            //opção 3 do menu
            if (opcao == 3)
            {
                Console.Clear();
                Console.WriteLine("Modelos");
                Console.ReadKey();

            }





        }
    }
}