using System;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Funcoes
{
    public static void Main(System.String[] args)
    {
        /*exercicio01();
        exercicio02();
        exercicio03();
        exercicio04();
        exercicio05();
        exercicio06();
        exercicio07();
        exercicio08();*/
        exercicio09();
        //exercicio10(); //nfalta fazer
        exercicio11(); //não esta funcionando

        /*
        13. Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.
        14. Escreva uma função que calcule o valor da série de Fibonacci para um dado número de termos.
        15. Desenvolva uma função que determine se um número é positivo, negativo ou zero.
        16: Calculadora Simples - Crie uma função chamada Calculadora que recebe dois números e um operador (+, -, *, /) como parâmetros e retorna o resultado da operação.
        17: Verificação de Número Primo - Escreva uma função chamada Primo que recebe um número inteiro como parâmetro e retorna true se o número for primo e false caso contrário.
        18: Sequência de Fibonacci - Implemente uma função chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna uma lista contendo os primeiros n números da sequência de Fibonacci.
        19: Contagem de Dígitos - Crie uma função chamada ContarDigitos que recebe um número inteiro como parâmetro e retorna o número de dígitos no número.
        20: Média de Números - Desenvolva uma função chamada CalcularMedia que recebe 3 números e retorna a média dos itens.
        */
    }
    static void exercicio01()
    {
        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 01 *");
        Console.WriteLine("\t\t****************\n");

        //1. Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.
        double a = AskNumberDouble("Digite um número");
        double b = AskNumberDouble("Digite um número");
        Console.WriteLine($"A soma dos numeros {a} e {b} é equivalente a {soma(a, b)}");

    }
    static void exercicio02()
    {
        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 02 *");
        Console.WriteLine("\t\t****************\n");
        //2. Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.
        int n = AskNumberInt("Digite um número");
        Console.WriteLine($"A fatorial do número {n} é {Fatorial(n)}");
    }
    static void exercicio03()
    {
        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 03 *");
        Console.WriteLine("\t\t****************\n");
        //3. Desenvolva uma função que verifique se um número é primo ou não.
        int n = AskNumberInt("Digite um número");

        if (EhPrimo(n))
        {
            Console.WriteLine($"O número {n} é primo");
        }
        else
        {
            Console.WriteLine($"O número {n} não é primo");
        }
    }
    static void exercicio04()
    {
        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 04 *");
        Console.WriteLine("\t\t****************\n");
        //4. Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.

        List<int> numeros = new List<int>();
        int n = AskNumberInt("Insira um número (-1 para sair)");
        while (n != -1)
        {
            numeros.Add(n);
            n = AskNumberInt("Insira um número (-1 para sair)");
        }
        Console.WriteLine($"O maior número inserido é {numeros.Max()}");
    }
    static void exercicio05()
    {
        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 05 *");
        Console.WriteLine("\t\t****************\n");
        //5. Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).
        string str = Ask("Digite uma palavra: ");
        Console.WriteLine($"A palavra {str} ao contrário é {InverterString(str)}");
    }
    static void exercicio06()
    {
        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 06 *");
        Console.WriteLine("\t\t****************\n");

        //6. Escreva uma função que calcule a média de uma lista de números reais.

        List<int> notas = new List<int>();
        int n = AskNumberInt("Insira um número (-1 para sair)");
        while (n != -1)
        {
            notas.Add(n);
            n = AskNumberInt("Insira um número (-1 para sair)");
        }
        Console.WriteLine($"A média das notas inserídas é {Media(notas)}");
    }
    static void exercicio07()
    {
        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 07 *");
        Console.WriteLine("\t\t****************\n");
        //7.Desenvolva uma função que verifique se uma string é um palíndromo(ela lê o mesmo de trás para frente) ou não.
        string str = Ask("Digite uma palavra: ");

        if (str.ToUpper() == InverterString(str).ToUpper())
        {
            Console.WriteLine($"A palavra {str} é um palíndromo");
        }
        else
        {
            Console.WriteLine($"A palavra {str} não é um palíndromo");
        }
    }
    static void exercicio08()
    {
        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 08 *");
        Console.WriteLine("\t\t****************\n");
        //8.Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.
        double grausC = AskNumberDouble("Insira o grau celsius para converter: ");
        Console.WriteLine($"{grausC}°C é {CtoFahrenheit(grausC)}° fahrenheit");
    }
    static void exercicio09()
    {
        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 09 *");
        Console.WriteLine("\t\t****************\n");

        //9. Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.
        string[] palavras = ["ana", "julia", "estudando", "csharp"];

        for (int i = 0; i <palavras.Length; i++)
        {
            if (ContaCarac(palavras[i]) >= 5)
            {
                Console.WriteLine($"A palavra {palavras[i]} possui {ContaCarac(palavras[i])} caracteres.");
            }

        }
    }
    static void exercicio10()
    {
        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 10 *");
        Console.WriteLine("\t\t****************\n");

        //10.Escreva uma função que calcule o máximo divisor comum(MDC) entre dois números inteiros.
        int a = AskNumberInt("Insira um número inteiro");
        int b = AskNumberInt("Insira um número inteiro");

    }
    static void exercicio11()
    {
        //11.Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.
        List<int> numeros = new List<int>();
        int n = AskNumberInt("Insira um número (-1 para sair)");
        while (n != -1)
        {
            numeros.Add(n);
            n = AskNumberInt("Insira um número (-1 para sair)");
        }

        Console.WriteLine($"Somente os numeros {EhPar(numeros)} são pares");
    }
    static void exercicio12()
    {
        //12.Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.

    }

    static double soma(double x, double y)
    {
        return x + y;
    }
    static double AskNumberDouble(string pergunta)
    {
        Console.WriteLine(pergunta);
        return double.Parse(Console.ReadLine());
    }
    static int AskNumberInt(string pergunta)
    {
        Console.WriteLine(pergunta);
        return int.Parse(Console.ReadLine());
    }
    static string Ask(string pergunta)
    {
        Console.WriteLine(pergunta);
        return Console.ReadLine();
    }
    static int Fatorial(int x)
    {
        int fat = 1;
        for (int i = x; i > 1; i--)
        {
            fat *= i;
        }
        return fat;
    }
    static bool EhPrimo(int n)
    {
        int verificaPrimo = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                verificaPrimo++;
            }
        }
        if (verificaPrimo > 2)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    static int MaiorNumero(List<int> lista)
    {
        return lista.Max();
    }
    static string InverterString(string str)
    {
        int qtdCaracter = str.Length - 1;
        string strNew = "";

        for (int i = qtdCaracter; i >= 0; i--)
        {
            strNew += str[i];
        }
        return strNew;
    }
    static double Media(List<int> lista)
    {
        double sum = 0;
        for (int i = 0; i < lista.Count; i++)
        {
            sum += lista[i];
        }

        return sum / lista.Count;
    }
    static double CtoFahrenheit(double grausC)
    {
        return grausC * 1.8 + 32;
    }
    static int ContaCarac(string palavra)
    {
        return palavra.Length;
    }
    static List<int> EhPar(List<int> numeros)
    {
        List<int> pares = new List<int>();

        for (int i = 0; i < numeros.Count(); i++)
        {
            if (numeros[i] % 2 == 0)
            {
                pares.Add(numeros[i]);
            }

        }

        return pares;
    }


}