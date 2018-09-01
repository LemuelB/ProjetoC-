using System;


namespace Projeto_C
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Questão 01");

                Console.Write("01 , 02, 03, 04, 05, 06, 07, 08, 09, 10");
                Console.Write("\n11 , 12, 13, 14, 15, 16, 17, 18, 19, 20");
                Console.Write("\n21 , 22, 23, 24, 25, 26, 27, 28, 29, 30");
                Console.Write("\n31 , 32, 33, 34, 35, 36, 37, 38, 39, 40");

                Console.ReadKey();
                Console.Clear();
            }

            {
                Console.WriteLine("\nQUESTÃO 2");

                int x;
                x = 2;
                int y;
                y = 3;

                Console.WriteLine("x = " + x);// Exibe o valor de X
                Console.WriteLine("O valor de x + x é " + (x + x)); // Soma X+X
                Console.WriteLine("y = " + y); // Exibe o valor de y
                Console.WriteLine((x + y) + " = " + (y + x));// Soma x+y

                Console.ReadKey();
                Console.Clear();
            }


            {
                Console.WriteLine("\nQUESTÃO 3"); 

                Console.WriteLine("* \n** \n*** \n**** \n*****");
                //Realiza a quebra de linha

                Console.ReadKey();
                Console.Clear();
            }

            {
                Console.WriteLine("\nQUESTÃO 4");
                Console.Write("*"); //Segue em uma linha
                Console.Write("***");//não realizou quebra segue na mesma linha
                Console.WriteLine("*****");//Segue na mesma linha mais realiza a quebra
                Console.Write("****");//Segue em outra linha
                Console.WriteLine("**");//Segue na mesma linha da anterior mais realizou a quebra
                /* o Console.WriteLine dá um "enter" no final do texto, movendo o cursor para a próxima linha, 
               e o Console.Write não faz isso, e deixa o cursor logo após o texto.*/

                Console.ReadKey();
                Console.Clear();    
            }

            {
                Console.WriteLine("\nQUESTÃO 5");

                Console.WriteLine("digite seu nome:");
                var nome = Console.ReadLine();
                Console.WriteLine("\ndigite seu sobrenome:");
                var sobrenome = Console.ReadLine();
                Console.WriteLine("\ndigite sua matricula:");
                var matricula = Console.ReadLine();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\n{nome}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{sobrenome}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" - ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{matricula}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ReadKey();
                Console.Clear();
            }


            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\nQUESTÃO 6"); 

                int valor1, valor2, resultado;
                Console.Write("Informe o 1 numero ->");
                valor1 = int.Parse(Console.ReadLine());
                Console.Write("Informe o 2 numero ->");
                valor2 = int.Parse(Console.ReadLine());

                Console.Write($" soma = ");
                resultado = valor1 + valor2;
                Console.WriteLine(resultado);
                Console.Write($" subtração = ");
                resultado = valor1 - valor2;
                Console.WriteLine(resultado);
                Console.Write($" multiplicação = ");
                resultado = valor1 * valor2;
                Console.WriteLine(resultado);
                Console.Write($" divisão = ");
                resultado = valor1 / valor2;
                Console.WriteLine(resultado);

                Console.ReadKey();
                Console.Clear();
            }

            {
                 Console.WriteLine("\nQuestão 07");

                const double PI = 3.14D;
                double area = 0;
                double raio = 0;
                double diametro = 0;
                double circunferencia = 0;

                Console.Write("Entrada do raio? ");
                raio = double.Parse(Console.ReadLine());

                area = PI * raio * raio;
                diametro = 2 * raio;
                circunferencia = PI * diametro;

                Console.Write("\n\tO diâmetro do circulo: " + diametro);
                Console.Write("\n\tA área do circulo: " + area);
                Console.Write("\n\tA circunferência do circulo: " + circunferencia);

                Console.ReadKey();
                Console.Clear();
            }

            {
                Console.WriteLine("\nQUESTAO 8");
                int a, b;
                Console.Write("primeiro numero (a)= ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("segundo numero (b)= ");
                b = Convert.ToInt32(Console.ReadLine());

                if (a % b == 0)
                {
                    Console.WriteLine("numero a: {0}, e multiplo de numero b: {1}", a, b);
                }
                else
                {
                    Console.WriteLine("numero a: {0}, não e multiplo de numero b: {1}", a, b);
                }
                Console.ReadKey();
                Console.Clear();
            }

            {
                Console.WriteLine("\nQUESTÃO 9 ");

               

                Console.ReadKey();
                Console.Clear();
            }
            
            Console.WriteLine("\nQUESTÃO 10");
            int w, z;
            w = 0 * 0 ;
            z = 0 * 0 * 0;

            Console.WriteLine("\nNúmero \t\t Quadrado \t Cubo");
            Console.WriteLine("\n");

            Console.WriteLine("0000\t\t" + w);
            Console.WriteLine("\t\t\t\t" + z);
            w = 0 * 0;
            z = 0 * 0 * 0;


            w = 1 * 1;
            z = 1 * 1 * 1;
            Console.WriteLine("0001\t\t" + w);
            Console.WriteLine("\t\t\t\t" + z);
            
            w = 2 * 2;
            z = 2 * 2 * 2;
            Console.WriteLine("0002\t\t" + w);
            Console.WriteLine("\t\t\t\t" + z);

            w = 3 * 3;
            z = 3 * 3 * 3;
            Console.WriteLine("0003\t\t" + w);
            Console.WriteLine("\t\t\t\t" + z);

            w = 4 * 4;
            z = 4 * 4 * 4;
            Console.WriteLine("0004\t\t" + w);
            Console.WriteLine("\t\t\t\t" + z);

            w = 5 * 5;
            z = 5 * 5 * 5;
            Console.WriteLine("0005\t\t" + w);
            Console.WriteLine("\t\t\t\t" + z);

            w = 6 * 6;
            z = 6 * 6 * 6;
            Console.WriteLine("0006\t\t" + w);
            Console.WriteLine("\t\t\t\t" + z);

            w = 7 * 7;
            z = 7 * 7 * 7;
            Console.WriteLine("0007\t\t" + w);
            Console.WriteLine("\t\t\t\t" + z);

            w = 8 * 8;
            z = 8 * 8 * 8;
            Console.WriteLine("0008\t\t" + w);
            Console.WriteLine("\t\t\t\t" + z);

            w = 9 * 9;
            z = 9 * 9 * 9;
            Console.WriteLine("0009\t\t" + w);
            Console.WriteLine("\t\t\t\t" + z);

            w = 10 * 10;
            z = 10 * 10 * 10;
            Console.WriteLine("0010\t\t" + w);
            Console.WriteLine("\t\t\t\t" + z);

            Console.ReadKey();
            Console.Clear();

             
            }
        }
    }

        
       
    







