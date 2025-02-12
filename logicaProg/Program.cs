using System;
using System.Runtime.Intrinsics.X86;

class Funcoes
{
    public static void Main(String[] args)
    {

        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 01 *");
        Console.WriteLine("\t\t****************\n");
        //1. Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.
        double a = AskNumberDouble("Digite um número");        
        double b = AskNumberDouble("Digite um número");
        Console.WriteLine($"A soma dos numeros {a} e {b} é equivalente a {soma(a,b)}");

        Console.WriteLine("\n\t\t****************");
        Console.WriteLine("\t\t* Exercício 02 *");
        Console.WriteLine("\t\t****************\n");
        //2. Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.
        int n = AskNumberInt("Digite um número");
        Console.WriteLine($"A fatorial do número {n} é {Fatorial(n)}");
        //3. Desenvolva uma função que verifique se um número é primo ou não.
        n = AskNumberInt("Digite um número");

        if (EhPrimo(n))
        {
            Console.WriteLine($"O número {n} é primo");
        }
        else
        {
            Console.WriteLine($"O número {n} não é primo");
        }
        //4. Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.
       
        List<int> numeros = new List<int>();
        n = AskNumberInt("Insira um número (-1 para sair)");
        while (n != -1) { 
            numeros.Add(n);
            n = AskNumberInt("Insira um número (-1 para sair)");
        }
        Console.WriteLine($"O maior número inserido é {numeros.Max()}");

        //5. Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).
        string str = Ask("Digite uma palavra: ");
        Console.WriteLine($"A palavra {str} ao contrário é {InverterString(str)}");
        //6. Escreva uma função que calcule a média de uma lista de números reais.

        List<int> notas = new List<int>();
        n = AskNumberInt("Insira um número (-1 para sair)");
        while (n != -1)
        {
            notas.Add(n);
            n = AskNumberInt("Insira um número (-1 para sair)");
        }
        Console.WriteLine($"A média das notas inserídas é {Media(notas)}");
        //7.Desenvolva uma função que verifique se uma string é um palíndromo(ela lê o mesmo de trás para frente) ou não.
         str = Ask("Digite uma palavra: ");

        if (str == InverterString(str))
        {
            Console.WriteLine($"A palavra {str} é um palíndromo");
        }
        else
        {
            Console.WriteLine($"A palavra {str} não é um palíndromo");
        }
        //8.Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.
        double grausC = AskNumberDouble("Insira o grau celsius para converter: ");
        Console.WriteLine($"{grausC}°C é {CtoFahrenheit(grausC)}° fahrenheit");
        //9. Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.

        /*
        
        10. Escreva uma função que calcule o máximo divisor comum (MDC) entre dois números inteiros.
        11. Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.
        12. Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.
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

    static double soma(double x, double y)
    {
        return x + y;
    }
    static double AskNumberDouble (string pergunta)
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
        for(int i = x; i > 1; i--)
        {
            fat *= i;
        }
        return fat;
    }
    static Boolean EhPrimo(int n)
    {
        int verificaPrimo = 0;
        for(int i = 1;i <= n; i++)
        {
            if(n%i == 0)
            {
                verificaPrimo++;
            }
        }
        if(verificaPrimo > 2)
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
    static string InverterString (string str)
    {
        int qtdCaracter = str.Length - 1;
        string strNew = "";

        for( int i = qtdCaracter; i >= 0; i--)
        {
            strNew += str[i];
        }
        return strNew;
    }
    static double Media(List<int> lista)
    {
        double sum = 0;
        for( int i = 0; i >= lista.Count; i++)
        {
            sum+= lista[i];
        }

        return sum/lista.Count;
    }
    static double CtoFahrenheit(double grausC)
    {
        return grausC * 1.8 + 32;
    }
}