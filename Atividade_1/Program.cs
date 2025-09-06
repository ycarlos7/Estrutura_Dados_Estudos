using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("1 - Potência (x^y)");
            Console.WriteLine("2 - Cubos dos Inteiros");
            Console.WriteLine("3 - MDC (Algoritmo de Euclides)");
            Console.WriteLine("4 - Série de Fibonacci");
            Console.WriteLine("5 - Converter para Binário");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("--------------------------------------");
            Console.Write("Digite a opção desejada: ");

            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine(); 

            
            switch (opcao)
            {
                
                case 0:
                    Console.WriteLine("Encerrando...");
                    sair = true; 
                    break; 

                
                case 1:
                    Console.Write("Base (x): ");
                    int x = int.Parse(Console.ReadLine());

                    Console.Write("Expoente não-negativo (y): ");
                    int y = int.Parse(Console.ReadLine());
                    if (y < 0) y = -y;

                    long resultadoPotencia = Potencia(x, y);
                    Console.WriteLine($"{x}^{y} = {resultadoPotencia}");
                    break; 

                
                case 2:
                    Console.Write("Informe n (>= 1): ");
                    int nCubos = int.Parse(Console.ReadLine());
                    if (nCubos < 1) nCubos = 1;

                    Console.WriteLine($"Cubos de 1 até {nCubos}:");
                    Cubos(1, nCubos);
                    break;

                
                case 3:
                    Console.Write("Primeiro número: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Segundo número: ");
                    int b = int.Parse(Console.ReadLine());

                    if (a < 0) a = -a;
                    if (b < 0) b = -b;

                    int resultadoMdc = Mdc(a, b);
                    Console.WriteLine($"MDC({a}, {b}) = {resultadoMdc}");
                    break;

               
                case 4:
                    Console.Write("Informe n (posição de Fibonacci, n >= 0): ");
                    int fib = int.Parse(Console.ReadLine());
                    if (fib < 0) fib = 0;

                    long rec = FibonacciRecursivo(fib);
                    long it = FibonacciIterativo(fib);
                    Console.WriteLine($"Fibonacci recursivo({fib}) = {rec}");
                    Console.WriteLine($"Fibonacci iterativo({fib}) = {it}");
                    break;

                
                case 5:
                    Console.Write("Informe um número inteiro (pode ser negativo): ");
                    int bin = int.Parse(Console.ReadLine());

                    if (bin < 0)
                    {
                        string binario = ConverterParaBinario(-bin);
                        Console.WriteLine($"{bin} em binário = -{binario}");
                    }
                    else
                    {
                        string binario = ConverterParaBinario(bin);
                        Console.WriteLine($"{bin} em binário = {binario}");
                    }
                    break;

                
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            
            if (!sair)
            {
                Console.WriteLine();
                Console.Write("Pressione Enter para voltar ao menu...");
                Console.ReadLine();
                Console.Clear(); 
            }
        }

        static long Potencia(int x, int y)
        {
            if (y == 0) return 1;
            return x * Potencia(x, y - 1);
        }

        static void Cubos(int i, int n)
        {
            if (i > n) return;
            Console.WriteLine(i * i * i);
            Cubos(i + 1, n);
        }

        static int Mdc(int x, int y)
        {
            if (y == 0) return x;
            return Mdc(y, x % y);
        }

        static long FibonacciRecursivo(int n)
        {
            if (n == 0 || n == 1) return n;
            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }

        static long FibonacciIterativo(int n)
        {
            if (n == 0) return 0;
            long anterior = 0, atual = 1;
            for (int i = 2; i <= n; i++)
            {
                long proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            return atual;
        }

        static string ConverterParaBinario(int n)
        {
            if (n == 0) return "0";
            if (n == 1) return "1";
            return ConverterParaBinario(n / 2) + (n % 2).ToString();
        }
    }
}