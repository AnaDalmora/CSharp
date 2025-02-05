
//1. Escreva um programa que verifique se um número é positivo ou negativo e exiba uma mensagem correspondente.
public class estruturaSelecao
{


    public static void Main(string[] args)
    {

        Console.WriteLine("Qual exercício deseja ver?");
        for (int i = 0; i <= 20; i++)
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
            exercicio14();
            exercicio15();
            exercicio16();
            exercicio17();
            exercicio18();
            exercicio19();
            exercicio20();
            exercicio21();
            exercicio22();
            exercicio23();
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
            case 20:
                exercicio20();
                break;
            case 21:
                exercicio21();
                break;
            case 22:
                exercicio22();
                break;
            case 23:
                exercicio23();
                break;

            default:
                Console.WriteLine("Valor inválido");
                break;

        }
    }
    private static void exercicio1() {
        Console.Write("Insira um numero: ");
        double n = double.Parse(Console.ReadLine());
        if (n >= 0)
        {
            Console.WriteLine("O numero inserido é positivo.");
        } else
        {
            Console.WriteLine("O numero é negativo");
        }
    }
    private static void exercicio2() {
        //2. Crie um programa que determine se um usuário é maior de idade (idade igual ou acima de 18 anos) e exiba uma mensagem apropriada.

        Console.WriteLine("Por gentileza, insira sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        if (idade >= 18)
        {
            Console.WriteLine("Usuário é maior de idade");
        }
        else
        {
            Console.WriteLine("O usuário é menor de idade");
        }
    }

    //3. Desenvolva um programa que verifique se um número é par ou ímpar e exiba o resultado.
    private static void exercicio3() {
        Console.WriteLine("Insira um numero inteiro: ");
        int x = int.Parse(Console.ReadLine());
        if (x % 2 == 0)
        {
            Console.WriteLine($"O numero {x} é par");
        }
        else
        {
            Console.WriteLine($"O numero {x} é impar");
        }
    }
    //4. Faça um programa que determine se um aluno passou em um exame, considerando que a nota mínima para aprovação é 60.

    private static void exercicio4() {
        Console.WriteLine("Insira sua nota: ");
        double nota = double.Parse(Console.ReadLine());
        if (nota >= 60)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else
        {
            Console.WriteLine("Aluno reprovado");
        }
    }
    //5.Escreva um programa que verifique se um número digitado pelo usuário é múltiplo de 5.
    private static void exercicio5() {
        Console.WriteLine("Digite um numero inteiro");
        int y = int.Parse(Console.ReadLine());
        if (y % 5 == 0)
        {
            Console.WriteLine("O numero é divisivel por 5.");
        }
        else
        {
            Console.WriteLine("O numero não é divisivel por 5");
        }
    }
    //1. Crie um programa que, dado o peso e a altura de uma pessoa, determine se ela está abaixo do peso, com peso normal, com sobrepeso ou obesa, 
    //de acordo com o índice de massa corporal (IMC).
    private static void exercicio6() {
        Console.WriteLine("Insira seu peso em Kg");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira sua altura em cm");
        int altura = int.Parse(Console.ReadLine());

        double imc = peso / Math.Pow(2, altura / 100);

        if (imc < 18.5)
        {
            Console.WriteLine("Você esta abaixo do peso");
        } else if (imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Seu peso esta normal");
        }
        else
        {
            Console.WriteLine("Você esta com sobrepeso");
        }
    }
    //2.Desenvolva um programa que determine se um ano é bissexto ou não. Um ano é bissexto se for divisível por 4, mas não por 100, a menos que seja divisível por 400.
    private static void exercicio7() {
        Console.WriteLine("Insira um ano");
        int ano = int.Parse(Console.ReadLine());

        bool div4 = ano % 4 == 0;
        bool div100 = ano % 100 == 0;
        bool div400 = ano % 400 == 0;

        if (div4 && (!div100 || div400))
        {
            Console.WriteLine("O ano inserido é bissexto");
        }
        else
        {
            Console.WriteLine("O ano inserido não é bissexto");
        }
    }
    //3.Faça um programa que determine o maior de três números digitados pelo usuário.
    private static void exercicio8() {
        Console.WriteLine("Insira um numero");
        double n1 = double.Parse(Console.ReadLine()); //1
        Console.WriteLine("Insira um numero");
        double n2 = double.Parse(Console.ReadLine()); //2
        Console.WriteLine("Insira um numero");
        double n3 = double.Parse(Console.ReadLine()); //3

        if (n1 > n2 && n1 > n3)
        {
            Console.WriteLine($"O maior numero inserido é o {n1}");
        } else if (n2 > n1 && n2 > n3)
        {
            Console.WriteLine($"O maior numero inserido é o {n2}");
        }
        else
        {
            Console.WriteLine($"O maior numero inserido é o {n3}");
        }
    }
    //4. Escreva um programa que calcule o preço de um produto com desconto de 10% se o valor total da compra for maior ou igual a R$100.
    private static void exercicio9() {
        Console.WriteLine("Insira o valor da sua compra");
        double valor = double.Parse(Console.ReadLine());

        if (valor >= 100)
        {
            valor = valor * 0.9;
        }

        Console.WriteLine($"O valor total da compra é de R$ {valor}");
    }
    /*5.Crie um programa que solicite o nome e a idade de um usuário e, com base na idade,
    apresente mensagens de boas-vindas apropriadas: "Bem-vindo, [Nome]!"
    para idades até 12 anos, "Olá, [Nome]!" para idades entre 13 e 19 anos, e "Olá, Sr./Sra. [Nome]!" para idades acima de 19 anos.*/
    private static void exercicio10() {
        Console.WriteLine("Insira seu nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Insira sua idade");
        int iidade = int.Parse(Console.ReadLine());

        if (iidade <= 12)
        {
            Console.WriteLine($"Bem-vindo, {nome}");
        } else if (iidade <= 13 && iidade >= 19)
        {
            Console.WriteLine($"Olá, {nome}!");
        }
        else
        {
            Console.WriteLine($"Olá, Sr./Sra. {nome}!");
        }
    }


    //1. Crie um programa que verifique se um número digitado pelo usuário é positivo, negativo ou zero. Imprima a mensagem correspondente.

    private static void exercicio11()
    {
        Console.WriteLine("Insira um numero");
        double numero01 = double.Parse(Console.ReadLine());

        if (numero01 < 0)
        {
            Console.WriteLine("Numero negativo");
        }
        else if (numero01 > 0)
        {
            Console.WriteLine("Numero positivo");
        }
        else
        {
            Console.WriteLine("O numero inserido é zero");
        }
    }
    /*2. Desenvolva um programa que pergunte ao usuário se deseja um café. Se o usuário digitar "sim", 
    pergunte se ele quer açúcar. Com base nas respostas, exiba uma mensagem adequada, como "Aqui está o seu café preto." ou "Aqui está o seu café com açúcar."
    */
    private static void exercicio12()
    {
        Console.WriteLine("Você deseja um café?");
        string resposta = Console.ReadLine();
        if (resposta == "sim")
        {
            Console.WriteLine("Você quer açucar no seu café?");
            string resposta02 = Console.ReadLine();
            if (resposta02 == "sim")
            {
                Console.WriteLine("Aqui está o seu café com açucar");
            }
            else
            {
                Console.WriteLine("Aqui está seu café preto");
            }
        }
    }

    //3.Crie um programa que peça ao usuário para digitar três números inteiros. Verifique se pelo menos dois dos números são iguais entre si.
    private static void exercicio13()
    {
        Console.WriteLine("Insira um numero inteiro");
        int num01 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira um numero inteiro");
        int num02 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira um numero inteiro");
        int num03 = int.Parse(Console.ReadLine());

        if (num03 == num01 || num03 == num02 || num02 == num01)
        {
            Console.WriteLine("Pelo menos dois números são iguais");
        }
        else
        {
            Console.WriteLine("Nenhum dos números é igual aos outros.");
        }
    }
    //4. Escreva um programa que simule um caixa eletrônico. Peça ao usuário para digitar o saldo da conta e o valor que deseja sacar.
    //Verifique se há saldo suficiente na conta. Se houver, imprima "Saque autorizado." Se não houver saldo suficiente, imprima "Saldo insuficiente."
    private static void exercicio14()
    {
        double saldo = 1500.06;
        Console.WriteLine("Insira o valor que deseja sacar.");
        double saque = double.Parse(Console.ReadLine());

        if ((saldo - saque) >= 0)
        {
            Console.WriteLine("Saque autorizado");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }
    }
    /*
    5. Crie um programa que simule um sistema de controle de acesso a um edifício.
    Peça ao usuário para digitar sua identificação e a hora de entrada. O acesso é permitido apenas se a identificação for válida (por exemplo, "12345") e 
    se a hora de entrada estiver entre 9h e 18h. Imprima uma mensagem informando se o acesso foi autorizado ou negado.*/
    private static void exercicio15()
    {
        Console.WriteLine("Insira sua identificação");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a hora de entrada (troque o : por ,)");
        double hora = double.Parse(Console.ReadLine());

        if (id > 12 && id < 22 && hora > 9 && hora < 18)
        {
            Console.WriteLine("Acesso liberado");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }
    }

    /*1. Calculadora Simples: Crie uma calculadora simples que solicite ao usuário dois números e um operador (+, -, *, /).
    Use switch case para realizar a operação escolhida e mostrar o resultado.*/
   private static void exercicio16()
    {
        Console.WriteLine("Insira o numero a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o numero b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual operação matemática deseja fazer:\n 1- soma;\n 2- subtração;\n 3-Multiplicação;\n 4-Divisão");
        int resposta = int.Parse(Console.ReadLine());
        switch (resposta)
        {
            case 1:
                Console.WriteLine($"A soma dos dois numeros é de {a + b}");
                break;
            case 2:
                Console.WriteLine($"A subtração dos dois numeros é de {a-b}");
                break;
            case 3:
                Console.WriteLine($"A multiplicação dos dois numeros é de {a*b}");
                break;
            case 4:
                Console.WriteLine($"A divisão dos dois numeros é de {a/b}");
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }
    }


    //Conversão de Unidades: Crie um conversor de unidades que permita ao usuário escolher entre
    //converter uma quantidade em metros para centímetros ou centímetros para metros usando switch case.
    private static void exercicio17()
    {
        Console.WriteLine("Insira uma quantidade a ser convertida");
        double unidade = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite  0 para m - cm, 1 para cm - m");
        int resp = int.Parse(Console.ReadLine());

        switch (resp)
        {
            case 0:
                Console.WriteLine($"{unidade} m é equivalente a {unidade * 100} cm");
                break;
            case 1:
                Console.WriteLine($"{unidade} cm é equivalente a {unidade / 100} m");
                break;
            default:
                Console.WriteLine("Conversão inválida");
                break;

        }
    }
    /*3. Seleção de Língua: Desenvolva um programa multilíngue que solicite ao usuário que escolha um idioma (1 para inglês, 2 para espanhol, 3 para francês) 
    e exiba uma saudação de boas-vindas nesse idioma usando switch case. Se o idioma escolhido não estiver disponível, exiba uma mensagem informando que o idioma é inválido.*/
    private static void exercicio18() {
        Console.WriteLine("1- Inglês \n 2- Espanhol \n 3-Francês");
        int idioma = int.Parse(Console.ReadLine());

        switch (idioma)
        {
            case 1:
                Console.WriteLine("Welcome!");
                break;
            case 2:
                Console.WriteLine("Bienvenido!");
                break;
            case 3:
                Console.WriteLine("Bienvenue!");
                break;
            default:
                Console.WriteLine("Valor inválido");
                break;
        }
    }

    private static void exercicio19() {
        /*4. Conversão de Meses: Desenvolva um conversor de meses que solicite ao usuário um número de 1 a 12, 
        representando um mês do ano. Use switch case para exibir o nome do mês correspondente. Se o número estiver fora do intervalo, mostre uma mensagem de erro.*/

        Console.WriteLine("Digite um numero de 1 a 12");
        int numMes = int.Parse(Console.ReadLine());

        switch (numMes) {

            case 1:
                Console.WriteLine("Janeiro");
                break;
            case 2:
                Console.WriteLine("fevereiro");
                break;
            case 3:
                Console.WriteLine("Março");
                break;
            case 4:
                Console.WriteLine("Abril");
                break;
            case 5:
                Console.WriteLine("Maio");
                break;
            case 6:
                Console.WriteLine("Junho");
                break;
            case 7:
                Console.WriteLine("Julho");
                break;
            case 8:
                Console.WriteLine("Agosto");
                break;
            case 9:
                Console.WriteLine("Setembro");
                break;
            case 10:
                Console.WriteLine("Outubro");
                break;
            case 11:
                Console.WriteLine("Novembro");
                break;
            case 12:
                Console.WriteLine("Dezembro");
                break;
            default:
                Console.WriteLine("Valor inválido");
                break;
        }
    }

    //1. Verificação de Paridade: Escreva uma função chamada VerificarParidade que recebe um número inteiro como argumento e retorna uma string "Par" se o número for par e "Ímpar" se for ímpar.

    static void exercicio20()
    {
        Console.WriteLine("Insira um numero");
        int paridade = int.Parse (Console.ReadLine());
        string verificarParidade = (paridade % 2) == 0 ? "Par" : "Impar";
        Console.WriteLine("O numero é "+verificarParidade);

    }

    /*2. Calculadora de Desconto: Crie uma função chamada CalcularDesconto que recebe o preço de um produto e um booleano indicando se o cliente é um membro VIP. 
    Se o cliente for VIP, o desconto é de 20%; caso contrário, o desconto é de 10%. A função deve retornar o preço com o desconto aplicado.*/

    static void exercicio21()
    {
        Console.WriteLine("Insira o valor da compra");
        int valor = int.Parse(Console.ReadLine());
        bool vip = true;

        Console.WriteLine("O valor a ser pago é de: "+ calcularDesconto(valor, vip));
        static double calcularDesconto(double valor, bool vip)
        {
            if (vip)
            {
                valor = valor * 0.8;
            }
            else
            {
                valor = valor * 0.9;
            }
            return valor;
        }

    }


    /*3. Classificação de Aluno: Crie um programa que solicita ao usuário a nota de um aluno e determine se ele foi aprovado ou reprovado.
    Use o operador ternário para definir a aprovação com base na nota (por exemplo, notas maiores ou iguais a 6 são aprovadas).*/
    static void exercicio22()
    {
        Console.WriteLine("Insira a nota do aluno: ");
        double nota = double.Parse(Console.ReadLine());

        string situacao = (nota >= 6) ? "Aprovado" : "Reprovado";
        Console.WriteLine($"Aluno {situacao}");
    }   



    /*4. Avaliação de Idade: Crie uma função chamada ClassificarIdade que recebe a idade de uma pessoa como argumento e 
    retorna uma string indicando se a pessoa é uma "Criança" (até 12 anos), "Adolescente" (de 13 a 19 anos) ou "Adulto" (20 anos ou mais).*/

    static void exercicio23()
    {
        Console.WriteLine("Qual a sua idade: ");
        int idade = int.Parse(Console.ReadLine());


        Console.WriteLine($"Você é um {classificarIdade(idade)}");
        static string classificarIdade(int idade)
        {
            if (idade <= 12)
            {
                return "Criança";
            }else if(idade >= 13 && idade <= 19)
            {
                return "Adolescente";
            }
            else
            {
                return "Adulto";
            }
        }

    }
}
