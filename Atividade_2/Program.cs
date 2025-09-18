using System;

public class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Digite uma frase: ");
        string primeiraFrase = Console.ReadLine();

        string fraseInvertida = InverterPalavrasDaFrase(primeiraFrase);

        Console.WriteLine("\nResultado com as palavras invertidas:");
        Console.WriteLine(fraseInvertida);
    }

    public static string InverterPalavrasDaFrase(string frase)
    {
        string resultado = "";
        string palavra = "";

        foreach (char letra in frase)
        {
            if (letra == ' ')
            {
                resultado += Inverter(palavra);
                resultado += " ";
                palavra = "";
            }
            else
            {
                palavra += letra;
            }
        }
        
        resultado += Inverter(palavra);

        return resultado;
    }

    public static string Inverter(string texto)
    {
        string Invertida = "";
        
        for (int i = texto.Length - 1; i >= 0; i--)
        {
            Invertida += texto[i];
        }
        
        return Invertida;
    }
}
