public class estruturaRepeticaoWhileDoWhile {

    public static void Main(String[] args)
    {
        Console.WriteLine("**************************");
        Console.WriteLine("**** Exercicios While ****");
        Console.WriteLine("**************************");

        exercicio01();
        exercicio02();
        exercicio03();
        exercicio04();
        exercicio05();

        Console.WriteLine("*****************************");
        Console.WriteLine("**** Exercicios Do While ****");
        Console.WriteLine("*****************************");

        exercicio06();
        exercicio07();
        exercicio08();
        exercicio09();
        exercicio10();
    }

    private static void exercicio01()
    {
        Console.WriteLine("\n1) Escreva um programa que utilize um loop while para exibir os números de 1 a 10 em ordem crescente.\n");
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
    private static void exercicio02()
    { 
        Console.WriteLine("\n2)Crie um jogo em que o computador gera um número aleatório entre 1 e 100, e o jogador deve adivinhar qual é esse número. Use um loop while para permitir que o jogador faça múltiplas tentativas até acertar. Caso ele digite zero o jogo deve se encerrar.\n");
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int r = 1;
        while (true)
        {
            Console.WriteLine("Insira um numero inteiro (0 para sair do game) ");
            r = int.Parse(Console.ReadLine());

            if (r == 0)
            {
                Console.WriteLine($"jogo encerrado, a resposta era {numeroAleatorio}");
                break;
            }
            else if (r == numeroAleatorio)
            {
                Console.WriteLine("Parabens! você acertou o numero secreto!!");
                break;
            }
            else
            {
                Console.WriteLine("Resposta errada, tente novamente.");
            }
        }

    }
    private static void exercicio03() {
        Console.WriteLine("\n 3)Implemente uma calculadora simples que pede ao usuário para inserir dois números e uma operação (+, -, *, /). Use um loop while para permitir que o usuário realize cálculos repetidamente até optar por sair digitando q na operação desejada.");

        while (true)
        {
            Console.WriteLine("Qual Operação Matemática deseja Realizar (q para sair)?\n 1) +\n 2) -\n 3) *\n 4) /");
            string r = Console.ReadLine();
            if (r == "q")
            {
                break;
            } else if (r != "*" && r!="+"&&r!="/" && r!="-"){
                Console.WriteLine("Entrada incorreta é permitido: \n+\n-\n*\n/");
            }
            else
            {
                Console.WriteLine("Insira o numero a");
                double a = double.Parse(Console.ReadLine());                
                Console.WriteLine("Insira o numero b");
                double b = double.Parse(Console.ReadLine());
                switch (r)
                {
                    case "+":
                        Console.WriteLine($"{a} + {b} = {a+b}");
                        break;
                    case "-":
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;                    
                    case "*":
                        Console.WriteLine($"{a} * {b} = {a*b}");
                        break;                    
                    case "/":
                        Console.WriteLine($"{a} / {b} = {a/b}");
                        break;
                    default:
                        Console.WriteLine("Entrada incorreta.");
                        break;

                }
            }
        }


    }
    private static void exercicio04()
    {
        Console.WriteLine("\n4) Peça ao usuário para inserir uma série de números positivos. Use um loop while para continuar lendo números até que o usuário insira um número negativo. Em seguida, exiba a soma dos números positivos inseridos.\n");
        double i = 0;
        double sum = 0;
        while (i >= 0)
        {
            sum += i;
            Console.WriteLine("Insira um numero positivo");
            i = double.Parse(Console.ReadLine());

        }
        Console.WriteLine($"A soma dos numeros positivos informados é de {sum}");
    }    
    private static void exercicio05()
    {
        Console.WriteLine("\n 5) Solicite um número inteiro positivo do usuário e calcule o fatorial desse número usando um loop while. Exiba o resultado no final.\r\n\n");
        int fatorial = 1;
        Console.WriteLine("Insira um numero inteiro para calcular a fatorial");
        int i = int.Parse(Console.ReadLine());
        while (i > 1)
        {
            fatorial *= i;
            i--;
        }
        Console.WriteLine($"Resultado da fatorial: {fatorial}");
    }

    private static void exercicio06()
    {
        Console.WriteLine("\n 1) Escreva um programa que solicite ao usuário um número inteiro. O programa deve então imprimir a tabela de multiplicação desse número, exibindo os produtos do número pelo contador de 1 a 10.");
        Console.WriteLine("\nInsira um numero inteiro para exebir a tabuada");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int i = 1;
        do
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
            i++;
        }
        while (i <= 10);
    }       
    private static void exercicio07()
    {
        Console.WriteLine("Desenvolva um programa que permita ao usuário inserir uma série de notas. O programa deve calcular e exibir a média das notas inseridas, desconsiderando notas negativas. A entrada de notas deve continuar até que o usuário insira o valor -1, indicando o final da entrada.");
        

        int qtdNotas = 0;
        double sumNotas = 0;
        double nota = 0;


        do
        {
            Console.WriteLine("Insira a nota (-1 para sair):");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 0)
            {
                sumNotas += nota;  
                qtdNotas++;        

            }
        }
        while (nota != -1);
        Console.WriteLine($"A média das notas é de {sumNotas/qtdNotas}");
    }    
    private static void exercicio08()
    {
        Console.WriteLine("\n 3) Escreva um programa que solicite ao usuário um número inteiro positivo e, em seguida, realize uma contagem regressiva a partir desse número até zero.");
        Console.WriteLine("\nInsira um numero inteiro.");
        int i = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine(i);
            i--;
        }
        while (i >= 0);
    }    
    private static void exercicio09()
    {
        Console.WriteLine("\n 4) Escreva um programa que solicite ao usuário um número inteiro e calcule a soma de seus dígitos. Por exemplo, se o usuário inserir 123, o programa deve calcular e exibir 1 + 2 + 3 = 6.");
        Console.WriteLine("Insira um numero inteiro");
        string n = Console.ReadLine();
        int qtdCaracter = n.Length - 1;
        int sum = 0;
        do
        {
            sum += n[qtdCaracter] - '0';
            Console.WriteLine();
            qtdCaracter--;
        }
        while (qtdCaracter >= 0) ;
        Console.WriteLine($"A soma dos digitos de {n} é igual a {sum}");
    }    
    private static void exercicio10()
    {
        Console.WriteLine("\n 5) Crie um programa que gere um número aleatório entre 1 e 100. O programa deve pedir ao usuário para adivinhar o número gerado. O usuário deve inserir sua suposição, e o programa deve informar se o palpite está muito alto, muito baixo ou correto. O programa deve continuar solicitando palpites até que o usuário adivinhe o número correto.");
        
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        Console.WriteLine("Insira um numero inteiro (0 para sair do game) ");
        int r = int.Parse(Console.ReadLine());
        do { 
        
            if (r > numeroAleatorio)
            {
                Console.WriteLine("Numero muito alto, o numero que você esta buscando é menor\n");
            }
            else if (r < numeroAleatorio)
            {
                Console.WriteLine("Numero muito baixo, o numero que você esta buscando é maior\n");
            }
            else if (r == numeroAleatorio)
            {
                Console.WriteLine("Parabéns!! Você adivinhou o numero!!!");
                break;
            }
            Console.WriteLine("\nInsira um numero inteiro (0 para sair do game) ");
            r = int.Parse(Console.ReadLine());
        }
        while (r != 0);
    }

}

