public class variaveis
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual exercício deseja ver?");
        Console.WriteLine("0 - todos");
        for (int i = 1; i <= 19; i++)
        {
            Console.WriteLine($"{i} - exercício {i}");
        }
        Console.WriteLine("Resposta: ");
        int Resposta = int.Parse(Console.ReadLine());
        if (Resposta == 0)
        {
            exercicio1();
            exercicio2();
            exercicio3();
            exercicio4();
            exercicio5();
            exercicio6();
            exercicio7();
            exercicio8();
            exercicio9();
            exercicio10();
            exercicio11();
            exercicio12();
            exercicio13();
            exercicio14();
            exercicio15();
            exercicio16();
            exercicio17();
            exercicio18();
            exercicio19();
        }
        else
        {
            switch (Resposta)
            {
                case 1:
                    exercicio1();
                    break;
                case 2:
                    exercicio2();
                    break;
                case 3:
                    exercicio3();
                    break;
                case 4:
                    exercicio4();
                    break;
                case 5:
                    exercicio5();
                    break;
                case 6:
                    exercicio6();
                    break;
                case 7:
                    exercicio7();
                    break;
                case 8:
                    exercicio8();
                    break;
                case 9:
                    exercicio9();
                    break;
                case 10:
                    exercicio10();
                    break;
                case 11:
                    exercicio11();
                    break;
                case 12:
                    exercicio12();
                    break;
                case 13:
                    exercicio13();
                    break;
                case 14:
                    exercicio14();
                    break;
                case 15:
                    exercicio15();
                    break;
                case 16:
                    exercicio16();
                    break;
                case 17:
                    exercicio17();
                    break;
                case 18:
                    exercicio18();
                    break;
                case 19:
                    exercicio19();
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }
        }
    }

    private static void exercicio1()
    {
        Console.WriteLine("Declare uma variável do tipo int, atribua um valor e imprima na tela.\n");
        int n = 2;
        Console.WriteLine($"Variavel escolhida: {n}");
    }
    private static void exercicio2()
    {
        Console.WriteLine("Crie uma variável string com o nome do seu curso e exiba a mensagem: “Bem-vindo ao curso [nome]”.\n");
        string nome = "Ana";
        Console.WriteLine($" Bem-vindo ao curso {nome}");
    }
    private static void exercicio3()
    {
        Console.WriteLine("Declare duas variáveis do tipo double, atribua valores e exiba a soma\n");
        double a = 1.895;
        double b = 187.95;
        Console.WriteLine($" A soma de {a} + {b} é igual a {a+b}");
    }
    private static void exercicio4()
    {
        Console.WriteLine("Leia um número inteiro do usuário e exiba o quadrado desse número.\n");
        Console.WriteLine("Insira um numero inteiro");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nO quadrado do numero inserido é {a*a}");
    }
    private static void exercicio5()
    {
        Console.WriteLine("Verifique se um número inteiro lido do teclado é par ou ímpar.\n");
        Console.WriteLine("Insira um numero ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("\nO numero é par");
        }
        else
        {
            Console.WriteLine("\nO numero é impar");
        }
    }
    private static void exercicio6()
    {
        Console.WriteLine("Leia dois números inteiros e exiba o maior deles.\n");
        Console.WriteLine("Insira um numero ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira um numero ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 >num2)
        {
            Console.WriteLine($"\nO numero {num1} é maior que o {num2}");
        }
        else if(num2 >num1)
        {
            Console.WriteLine($"\nO numero {num2} é maior que o {num1}");
        }
        else
        {
            Console.WriteLine("Os dois numeros são iguais.");
        }
    }
    private static void exercicio7()
    {
        Console.WriteLine("Crie uma variável booleana que indica se a soma de dois números é maior que 100.\n");
        Console.WriteLine("Insira um numero ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira um numero ");
        int num2 = int.Parse(Console.ReadLine());
        bool maior100 = (num1 + num2) > 100;
        if(maior100)
        {
            Console.WriteLine($"\nA soma é maior de {num1} e {num2} que 100");
        }
    }
    private static void exercicio8()
    {
        Console.WriteLine("Converta uma variável double para int e exiba o valor antes e depois da conversão.\n");
        double v = 1.89;
        Console.WriteLine($"Valor em double: {v}");
        int vNew = (int)v;
        Console.WriteLine($"Valor em int: {vNew}");
    }
    private static void exercicio9()
    {
        Console.WriteLine("Declare uma variável e calcule a variável ao cubo.\n");
        int a = 3;
        Console.WriteLine($"o cubo de {a} é igual {a*a*a}");
    }
    private static void exercicio10()
    {
        Console.WriteLine("Crie uma expressão que verifica se um número é múltiplo de 5 e de 3 ao mesmo tempo.\n");
        Console.WriteLine("Insira um numero");
        int num = int.Parse(Console.ReadLine());

        bool divisivel = (num % 5 == 0) && (num % 3 == 0);
        if (divisivel)
        {
            Console.WriteLine($"\nO numero {num} é multiplo de 5 e 3");
        }
    }
    private static void exercicio11()
    {
        Console.WriteLine("Leia uma idade e exiba uma mensagem informando se é maior de idade.\n");
        Console.WriteLine("Insira sua idade");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine($"\nVocê é maior de idade");
        }
        else
        {
            Console.WriteLine($"\nVocê é menor de idade");
        }
        
    }
    private static void exercicio12()
    {
        Console.WriteLine("Leia um valor em graus Celsius e converta para Fahrenheit.\n");

        double grausC = double.Parse(Console.ReadLine());

        double fahrenheit = (grausC * 1.8) + 32;
        Console.WriteLine($"\n{grausC}º celsius equivalem a {fahrenheit} graus fahrenheit");


    }
    private static void exercicio13()
    {
        Console.WriteLine("Crie um programa que recebe três números e exibe a média aritmética.\n");

        Console.WriteLine("Insira o primeiro numero");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo numero");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o terceiro numero");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nA média dos três numeros é de {(a+b+c)/3}");

    }
    private static void exercicio14()
    {
        Console.WriteLine("Declare uma variável que representa um salário e calcule um aumento de 10%.\n");
        double salario = 1500;
        Console.WriteLine($"Parabéns! Você recebeu um aumento de 10% seu salário agora é de {salario*1.1}");

    }
    private static void exercicio15()
    {
        Console.WriteLine("Crie uma variável do tipo string e concatene com outra variável para formar uma frase.\n");
        string a = "Bem ";
        string b = "vindo";
        Console.WriteLine(a+b);

    }
    private static void  exercicio16()
    {
        Console.WriteLine("Crie um programa que leia um número decimal e converta para inteiro.\n");
        Console.WriteLine("Insira um numero decimal");
        decimal num = decimal.Parse(Console.ReadLine());
        int num2 = (int)(num);
        Console.WriteLine($"\n O numero decimal {num} convertido para inteiro é {num2}");
    }
    private static void exercicio17()
    {
        Console.WriteLine("Verifique se um número fornecido pelo usuário está entre 1 e 100.\n");
        Console.WriteLine("Insira um numero");
        double num = double.Parse(Console.ReadLine());
        if (num >=1 || num <= 100)
        {
            Console.WriteLine("\nO numero inserido esta entre 1 e 100");
        }
        else
        {
            Console.WriteLine("\nO numero fornecido não esta entre 1 e 100");
        }

    }
    private static void exercicio18()
    {
        Console.WriteLine("Leia um texto e exiba o número de caracteres usando Length.\n");
        Console.WriteLine("Insira um texto");
        string text = Console.ReadLine();
        Console.WriteLine($"O texto possui {text.Length} caracteres");

    }
    private static void exercicio19()
    {
        Console.WriteLine("Receba duas strings e compare se elas são iguais, ignorando maiúsculas e minúsculas.\n");
        Console.WriteLine("Insira uma string");
        string text1 = Console.ReadLine();
        Console.WriteLine("Insira uma string");
        string text2 = Console.ReadLine();
        if(text1.ToUpper() == text2.ToUpper())
        {
            Console.WriteLine("As duas strings são iguais");
        }
        else
        {
            Console.WriteLine("As duas strings são diferentes");
        }

    }
}