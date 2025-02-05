
public class estruturaRepeticao
{


    public static void Main(string[] args)
    {

        Console.WriteLine("Qual exercício deseja ver?");
        for (int i = 0; i <= 13; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("0 - todos");

            }
            else
            {
                Console.WriteLine($"{i} - exercício {i}");
            }
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
        }
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
            default:
                Console.WriteLine("Valor inválido");
                break;

        }
    }
    private static void exercicio1()
    {

        Console.WriteLine("\nImprimir números de 1 a 10: Escreva um programa em C# que utilize um loop for para imprimir os números de 1 a 10;\n\n\n");
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(i);
        }
    }

    private static void exercicio2()
    {

        Console.WriteLine("\nCalcular a soma dos primeiros 100 números inteiros: Desenvolva um programa em C# que calcule e exiba a soma dos primeiros 100 números inteiros usando um loop for.");
        int sum = 0;
        for (int i = 0; i < 101; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);
    }


    private static void exercicio3()
    {

        Console.WriteLine("\nimprimir os números pares de 1 a 20: Crie um programa em C# que utilize um loop for para imprimir os números pares no intervalo de 1 a 20.");

        for (int i = 0; i < 21; i += 2)
        {
            Console.WriteLine(i);
        }

    }

    private static void exercicio4()
    {
        Console.WriteLine("\nCalcular o fatorial de um número dado: Elabore um programa em C# que calcule e apresente o fatorial de um número inteiro fornecido pelo usuário usando um loop for.");
        Console.WriteLine("Insira o numero que você deseja a fatorial");
        int num = int.Parse(Console.ReadLine());
        int fatorial = 1;
        for(int i = num; i >1; i--)
        {
            fatorial *=i;
        }
        Console.WriteLine($"A fatorial do valor é de {fatorial}");
    }

    private static void exercicio5()
    {
        Console.WriteLine("\nImprimir a tabuada de multiplicação de um número dado: Descreva um programa em C# que exiba a tabuada de multiplicação de um número inteiro fornecido pelo usuário, usando um loop for para calcular os resultados.");
        Console.WriteLine("Insira o numero no qual deseja saber a tabuada");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }

    }

    private static void exercicio6()
    {
        Console.WriteLine("\nContar a quantidade de números pares e ímpares em um intervalo:\r\nCrie um programa em C# que conte e mostre a quantidade de números pares e ímpares no intervalo de 1 a 100, usando um loop for.");
        int par = 0;
        int impar = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
        }
        Console.WriteLine($"a quantidade de numeros pares e impar entre 1 e 100 é de: \n impar: {impar} \n par: {par}");
    }

    private static void exercicio7()
    {
        Console.WriteLine("\nCalcular a média de um conjunto de notas:\r\nDesenvolva um programa em C# que calcule a média de um conjunto de notas e exiba o resultado.");
        Console.WriteLine("quantas notas você deseja calcular a média? ");
        int qntNotas = int.Parse(Console.ReadLine());
        double somaNotas = 0;

        for (int i = 1; i <= qntNotas; i++)
        {
            Console.WriteLine($"Insira a nota {i}");
            somaNotas += double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"A soma das médias é de {somaNotas / qntNotas}");

    }
    private static void exercicio8()
    {
        Console.WriteLine("\nImprimir os primeiros 20 termos da sequência de Fibonacci:Escreva um programa em C# que utilize um loop for para calcular e imprimir os primeiros 20 termos da sequência de Fibonacci.");

        int termoAntecessor = 0;
        int termoAtual = 1;
        int fibonacci;
        for (int i = 3; i <= 20; i ++ )
        {
            fibonacci = termoAtual+ termoAntecessor;
            Console.WriteLine($"Sequencia \n {fibonacci}");
            termoAntecessor = termoAtual;
            termoAtual = fibonacci;
        }

    }
    private static void exercicio9()
    {
        Console.WriteLine("\nVerificar se um número é primo:Crie um programa em C# que verifique se um número inteiro fornecido pelo usuário é primo ou não, utilizando um loop for para realizar a verificação.");
        Console.WriteLine($"Insira o numero que deseja saber se é primo");
        int verifPrimo = int.Parse(Console.ReadLine());
        int primo = 0;


        for (int i = 1; i <= verifPrimo; i++)
        {
            if (verifPrimo % i == 0)
            {
                primo++;
            }

        }

        if (primo > 2)
        {
            Console.WriteLine("O numero não é primo");
        }
        else
        {
            Console.WriteLine("O numero é primo");
        }

    }
    private static void exercicio10()
    {
        Console.WriteLine("\nCriar um padrão de triângulo utilizando asteriscos: Elabore um programa em C# que utilize loops for aninhados para criar e exibir um padrão de triângulo formado por asteriscos.");
        Console.WriteLine("Insira o tamanho das vertices");
        int vertice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= vertice; i++) 
        {
            for (int j = 1; j <= i; j++)  
            {
                Console.Write("*");
            }
            Console.WriteLine();  
        }

    }
    private static void exercicio11()
    {
        Console.WriteLine("\nSoma de Números Pares Escreva um programa que calcule e exiba a soma dos números pares de 1 a 100 utilizando um loop for.");
        int sumPar = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                sumPar += i;
            }
        }
        Console.WriteLine(sumPar);
    }
    private static void exercicio12()
    {
        Console.WriteLine("\nSequência de Potências Crie um programa que peça ao usuário para inserir um número inteiro e, em seguida, exiba a sequência de potências de 2 até a potência correspondente ao número inserido.");
        Console.WriteLine("Insira um numero inteiro");
        double nPotencia = double.Parse(Console.ReadLine());
        double potencia = 0;
        for (int i = 1; i <= nPotencia; i++)
        {
            Console.WriteLine($"{nPotencia}^{i} = {Math.Pow(nPotencia, i)}");
        }

    }
    private static void exercicio13()
    {
        Console.WriteLine("\nContagem Regressiva Peça ao usuário para inserir um número inteiro positivo e utilize um loop for para fazer uma contagem regressiva a partir desse número até 1, exibindo cada valor.");

        Console.WriteLine("Insira um inteiro positivo");
        int nPositivo = int.Parse(Console.ReadLine());

        for (int i = nPositivo; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}

