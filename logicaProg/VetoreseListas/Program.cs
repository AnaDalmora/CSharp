

namespace Vetores_Listas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            exercicio01();
            exercicio02();
            exercicio03();
            exercicio04();
            exercicio05();
            exercicio06();
            exercicio07();
            exercicio08();
            exercicio09();
            exercicio10();
            exercicio11();
            exercicio12();
        }

     
        static void exercicio01()
        {
            try
            {
                //1.Soma e Média: Escreva um programa que lê um vetor de 5 números inteiros e calcula a soma e a média dos elementos.
                int[] vetorInteiros = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    int n = assistencia.AskInt("Insira um número inteiro");
                    vetorInteiros[i] = n;
                }
                Console.WriteLine($"A soma dos elementos é de {matematica.soma(vetorInteiros)}.\nA média dos elementos é de: {matematica.Media(vetorInteiros)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Insira um número inteiro.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
        static void exercicio02()
        {
            //2. Maior e Menor Valor: Crie um programa que encontra e exibe o maior e o menor valor em um vetor de números reais.
            try
            {
                double[] numeros = new double[5];
                for (int i = 0; i < 5; i++)
                {
                    double n = assistencia.AskDouble("Insira um número");
                    numeros[i] = n;
                }
                double[] resultados = matematica.MaioreMenor(numeros);
                Console.WriteLine($"O maior número é {resultados[0]}\nO menor número é {resultados[1]}");
            } catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
        static void exercicio03()
        {
            try { 
            //3. Pares e Ímpares: Implemente um programa que divide um vetor de inteiros em dois vetores: um contendo os números pares e outro os números ímpares.
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int n = assistencia.AskInt("Insira um número inteiro");
                numeros[i] = n;
            }
            int[][] resultados = matematica.PrimosandNotPrimos(numeros);
            Console.WriteLine("Os números primos são");
            assistencia.ShareVetorInt(resultados[0]);
            Console.WriteLine("Os números não primos são");
            assistencia.ShareVetorInt(resultados[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
        static void exercicio04()
        {
            try 
            {
                //4. Busca por Valor: Crie uma função que recebe um vetor e um valor para procurar. A função deve retornar verdadeiro se o valor estiver presente no vetor e falso caso contrário.
                double[] numeros = new double[10];
                for (int i = 0; i < 10; i++)
                {
                    double n = assistencia.AskDouble("Insira um número inteiro");
                    numeros[i] = n;
                }
                int num = assistencia.AskInt("Insira um número no qual deseja buscar na lista.");
                if(matematica.BuscaValor(numeros, num))
                {
                    Console.WriteLine($"O número {num} esta na lista");
                }
                else
                {
                    Console.WriteLine($"O número {num} não esta na lista.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}"); 
            }
        }
        static void exercicio05()
        {
            try
            {
                //5. Inversão de Vetor: Escreva um programa que inverte a ordem dos elementos em um vetor (não utilizar função pronta).
                string[] vetor = { "A", "n", "a" };
                Console.Write($"O vetor invertido é {matematica.InverterVetor(vetor)} ");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro inesperado {ex.Message}");
            }
        }
        static void exercicio06()
        {
            //6. Contagem de Elementos: Implemente uma função que conta quantas vezes um determinado valor aparece em um vetor.
            
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int n = assistencia.AskInt("Insira um número inteiro");
                numeros[i] = n;
            }
            int num = assistencia.AskInt("Insira um número no qual deseja saber quantas vezes ele aparece na lista");
            Console.WriteLine($"O numero {num} aparece {matematica.ContagemNumero(numeros, num)} vezes no vetor");
            Console.Write("[");
            foreach(int elementos in numeros)
            {
                Console.Write(elementos + " ");
                
            }
            Console.Write("]");

        }
        static void exercicio07()
        {
            //7.Mescla de Vetores: Desenvolva um programa que recebe dois vetores de inteiros ordenados e cria um terceiro vetor mesclando os elementos dos dois em ordem crescente.
            int[] vetorA = { 4, 5, 6 };
            int[] vetorB = { 1, 2, 3 };

           
            Console.WriteLine("Vetor A");
            assistencia.exibirVetor(vetorA);
            Console.WriteLine("\nVetor B");
            assistencia.exibirVetor(vetorB);
            Console.WriteLine("\nMescla de A + B");
            assistencia.exibirVetor(matematica.MescladeVetores(vetorA, vetorB));

        }
        static void exercicio08()
        {
            try
            {
                //1.Crie uma List de inteiros e adicione os números de 1 a 5.Exiba os números no console.
                List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
                numeros.ForEach(x => Console.Write(x + " "));
            } 
            catch(Exception ex)
            {
                Console.WriteLine($"Erro inesperado {ex.Message}");
                
            }
        }
        static void exercicio09()
        {
            try
            {
                //2. Crie uma List de números inteiros. Solicite ao usuário para digitar 5 números e adicione-os à lista. Em seguida, calcule e exiba a soma de todos os números.
                int n = matematica.Sum(5);
                Console.WriteLine($"A soma dos números inseridos é {n}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro inesperado {ex.Message}");
            }
        }
        static void exercicio10()
        {
            // 3. Crie uma List de inteiros com 6 valores pré-definidos. Percorra a lista e encontre o maior número. Exiba o maior valor no console.
            try
            {
                List<int> numeros = new List<int> {1,2,3,4,5,6};
                Console.WriteLine($"O maior número é {matematica.Maior(numeros)}"); 
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro inesperado {ex.Message}");
            }
        }
        static void exercicio11()
        {
            try
            {
                //4. Crie uma List de strings com nomes de frutas ("banana", "maçã", "uva", "laranja"). Solicite ao usuário uma fruta para remover e remova-a da lista. Exiba a lista atualizada.
                List<string> frutas = new List<string> { "Banana", "Maçã", "Uva", "Laranja" };
                assistencia.ShareList(frutas);
                string frutaRemovida = assistencia.Ask("Qual fruta você deseja remover?");
                List<string> listaNova = matematica.Remover(frutas, frutaRemovida);
                assistencia.ShareList(listaNova);
            }catch(Exception ex)
            {
                Console.WriteLine($"Erro inesperado {ex.Message}");
            }
        }
        static void exercicio12()
        {
            // 5. Crie uma List de números inteiros. Adicione 10 números quaisquer à lista e conte quantos números são maiores que 50. Exiba o resultado.

            Random rnd = new Random();
            List<int> numerosAleatorios = new List<int>();
            for (int i = 0;i< 10; i++)
            {
                numerosAleatorios.Add(rnd.Next(1,100));
            }
            Console.Write("Os numeros são: ");
            assistencia.ShareListInt(numerosAleatorios);
            Console.Write("Os numeros maiores que 50 são: ");
            assistencia.ShareListInt(matematica.numerosMaior50(numerosAleatorios));
        }
        static void exercicio13()
        {
            //6.Crie uma List de nomes("Ana", "Bruno", "Carlos", "Diana", "Eduardo"). Pergunte ao usuário por um nome e informe se ele está presente na lista.
            List<string> nomes = new List<string> {"Ana","Bruno","Carlos","Diana","Eduardo"};
            string nome = assistencia.Ask("Insira o nome no qual deseja ver se esta na lista.");

            if (matematica.NomePresente(nomes, nome))
            {
                Console.WriteLine("Seu nome esta na lista!");
            }
            else
            {
                Console.WriteLine("Seu nome não esta na lista, os nomes presentes são:");
                assistencia.ShareList(nomes);
            }
        }
        static void exercicio14()
        {
            //7. Crie uma List de números inteiros contendo pelo menos 5 elementos. Remova o primeiro e o último elemento da lista e exiba os valores restantes.

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("lista atual");
            assistencia.ShareListInt(numeros);
            numeros.RemoveAt(0);
            numeros.RemoveAt(3);
            Console.WriteLine("Lista com numeros removidos");
            assistencia.ShareListInt(numeros);

        }
    }
}
