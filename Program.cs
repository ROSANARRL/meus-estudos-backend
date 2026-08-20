using System;
using System.Globalization;
using System.Threading;

namespace MeusEstudosBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            bool executar = true;

            while (executar)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("     CADERNO DE EXERCÍCIOS C# - BACKEND          ");
                Console.WriteLine("==================================================");
                Console.WriteLine(" 1 - Soma de dois números");
                Console.WriteLine(" 2 - Antecessor e sucessor");
                Console.WriteLine(" 3 - Área e perímetro de um retângulo");
                Console.WriteLine(" 4 - Conversor de moedas");
                Console.WriteLine(" 5 - Calculadora simples");
                Console.WriteLine(" 6 - Contagem crescente");
                Console.WriteLine(" 7 - Contagem regressiva");
                Console.WriteLine(" 8 - Tabuada");
                Console.WriteLine(" 9 - Soma dos números pares (1 a 100)");
                Console.WriteLine("10 - Login com limite de tentativas");
                Console.WriteLine("11 - Soma até digitar zero");
                Console.WriteLine("12 - Contador de caracteres");
                Console.WriteLine("13 - Verificador de tamanho de senha");
                Console.WriteLine("14 - Maior elemento e posição em array");
                Console.WriteLine("15 - Média de notas (Vetor)");
                Console.WriteLine("16 - Contagem de pares em um vetor");
                Console.WriteLine("17 - Ordem inversa em vetor");
                Console.WriteLine("18 - Jogo da Senha (Adivinhação)");
                Console.WriteLine("19 - Caixa Eletrônico (Contagem de cédulas)");
                Console.WriteLine("20 - Desafio Squad: Menu do Sistema de Alunos");
                Console.WriteLine(" 0 - Sair");
                Console.WriteLine("==================================================");
                Console.Write("Escolha o número do exercício para executar: ");

                if (int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.Clear();
                    switch (opcao)
                    {
                        case 1: ExecutarSomaDoisNumeros(); break;
                        case 2: ExecutarAntecessorSucessor(); break;
                        case 3: ExecutarAreaRetangulo(); break;
                        case 4: ExecutarConversorMoedas(); break;
                        case 5: ExecutarCalculadoraSimples(); break;
                        case 6: ExecutarContagemCrescente(); break;
                        case 7: ExecutarContagemRegressiva(); break;
                        case 8: ExecutarTabuada(); break;
                        case 9: ExecutarSomaPares(); break;
                        case 10: ExecutarLoginTresTentativas(); break;
                        case 11: ExecutarSomaAteZero(); break;
                        case 12: ExecutarContadorCaracteres(); break;
                        case 13: ExecutarVerificadorSenha(); break;
                        case 14: ExecutarMaiorElemento(); break;
                        case 15: ExecutarMediaVetor(); break;
                        case 16: ExecutarContagemParesVetor(); break;
                        case 17: ExecutarOrdemInversa(); break;
                        case 18: ExecutarJogoDaSenha(); break;
                        case 19: ExecutarCaixaEletronico(); break;
                        case 20: ExecutarDesafioSquadMenu(); break;
                        case 0:
                            executar = false;
                            Console.WriteLine("Encerrando o programa...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número do menu.");
                }

                if (executar)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            }
        }

        #region Módulos dos Exercícios

        static void ExecutarSomaDoisNumeros()
        {
            Console.WriteLine("--- 1. SOMA DE DOIS NÚMEROS ---");
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine()!);
            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"A soma é: {numero1 + numero2}");
        }

        static void ExecutarAntecessorSucessor()
        {
            Console.WriteLine("--- 2. ANTE CESSOR E SUCESSOR ---");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Antecessor: {numero - 1} | Atual: {numero} | Sucessor: {numero + 1}");
        }

        static void ExecutarAreaRetangulo()
        {
            Console.WriteLine("--- 3. ÁREA E PERÍMETRO DE UM RETÂNGULO ---");
            Console.Write("Digite a base: ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("Digite a altura: ");
            double h = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"Área: {b * h} | Perímetro: {2 * (b + h)}");
        }

        static void ExecutarConversorMoedas()
        {
            Console.WriteLine("--- 4. CONVERSOR DE MOEDAS ---");
            Console.Write("Digite o valor em Reais R$: ");
            decimal reais = decimal.Parse(Console.ReadLine()!);
            Console.Write("Digite a cotação do dólar: ");
            decimal cotacao = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine($"R$ {reais:C2} = US$ {reais / cotacao:C2}");
        }

        static void ExecutarCalculadoraSimples()
        {
            Console.WriteLine("--- 5. CALCULADORA SIMPLES ---");
            Console.Write("Informe o primeiro número: ");
            int v1 = int.Parse(Console.ReadLine()!);
            Console.Write("Informe o segundo número: ");
            int v2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Soma: {v1 + v2}");
            Console.WriteLine($"Subtração: {v1 - v2}");
            Console.WriteLine($"Multiplicação: {v1 * v2}");
            if (v2 != 0) Console.WriteLine($"Divisão: {(double)v1 / v2:F2}");
            else Console.WriteLine("Divisão por zero não permitida.");
        }

        static void ExecutarContagemCrescente()
        {
            Console.WriteLine("--- 6. CONTAGEM CRESCENTE ---");
            for (int i = 1; i <= 100; i++) Console.WriteLine(i);
        }

        static void ExecutarContagemRegressiva()
        {
            Console.WriteLine("--- 7. CONTAGEM REGRESSIVA ---");
            for (int i = 50; i >= 1; i--) Console.WriteLine(i);
        }

        static void ExecutarTabuada()
        {
            Console.WriteLine("--- 8. TABUADA ---");
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine()!);
            for (int i = 1; i <= 10; i++) Console.WriteLine($"{num} x {i} = {num * i}");
        }

        static void ExecutarSomaPares()
        {
            Console.WriteLine("--- 9. SOMA DOS NÚMEROS PARES (1 A 100) ---");
            int soma = 0;
            for (int i = 1; i <= 100; i++) if (i % 2 == 0) soma += i;
            Console.WriteLine($"Soma dos pares: {soma}");
        }

        static void ExecutarLoginTresTentativas()
        {
            Console.WriteLine("--- 10. LOGIN COM TENTATIVAS ---");
            int erros = 0;
            while (erros < 3)
            {
                Console.Write("Usuário: ");
                string u = Console.ReadLine()!;
                Console.Write("Senha: ");
                string s = Console.ReadLine()!;

                if (u == "admin" && s == "1234") { Console.WriteLine("Login OK!"); break; }
                erros++;
                Console.WriteLine($"Incorreto. Tentativa {erros} de 3.");
            }
        }

        static void ExecutarSomaAteZero()
        {
            Console.WriteLine("--- 11. SOMA ATÉ DIGITAR ZERO ---");
            int soma = 0, n;
            do
            {
                Console.Write("Digite um número (0 para sair): ");
                n = int.Parse(Console.ReadLine()!);
                soma += n;
            } while (n != 0);
            Console.WriteLine($"Soma total: {soma}");
        }

        static void ExecutarContadorCaracteres()
        {
            Console.WriteLine("--- 12. CONTADOR DE CARACTERES ---");
            Console.Write("Digite um nome: ");
            string txt = Console.ReadLine()!;
            Console.WriteLine($"Total de caracteres: {txt.Length}");
        }

        static void ExecutarVerificadorSenha()
        {
            Console.WriteLine("--- 13. VERIFICADOR DE SENHA ---");
            Console.Write("Digite uma senha: ");
            string pwd = Console.ReadLine()!;
            if (pwd.Length >= 8) Console.WriteLine("Senha válida.");
            else Console.WriteLine("A senha deve ter no mínimo 8 caracteres.");
        }

        static void ExecutarMaiorElemento()
        {
            Console.WriteLine("--- 14. MAIOR ELEMENTO E POSIÇÃO ---");
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }
            int maior = arr[0], pos = 0;
            for (int i = 1; i < 10; i++)
            {
                if (arr[i] > maior) { maior = arr[i]; pos = i; }
            }
            Console.WriteLine($"Maior: {maior} na posição {pos + 1}");
        }

        static void ExecutarMediaVetor()
        {
            Console.WriteLine("--- 15. MÉDIA DE UM VETOR ---");
            double soma = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Nota {i + 1}: ");
                soma += double.Parse(Console.ReadLine()!);
            }
            Console.WriteLine($"Média: {soma / 8:F2}");
        }

        static void ExecutarContagemParesVetor()
        {
            Console.WriteLine("--- 16. CONTAGEM DE PARES EM VETOR ---");
            int pares = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Número {i + 1}: ");
                if (int.Parse(Console.ReadLine()!) % 2 == 0) pares++;
            }
            Console.WriteLine($"Total de pares: {pares}");
        }

        static void ExecutarOrdemInversa()
        {
            Console.WriteLine("--- 17. ORDEM INVERSA ---");
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("Inverso:");
            for (int i = 9; i >= 0; i--) Console.WriteLine(arr[i]);
        }

        static void ExecutarJogoDaSenha()
        {
            Console.WriteLine("--- 18. JOGO DA SENHA ---");
            int segredo = 88, chute = 0;
            while (chute != segredo)
            {
                Console.Write("Palpite: ");
                chute = int.Parse(Console.ReadLine()!);
                if (chute > segredo) Console.WriteLine("Menor!");
                else if (chute < segredo) Console.WriteLine("Maior!");
                else Console.WriteLine("Acertou!");
            }
        }

        static void ExecutarCaixaEletronico()
        {
            Console.WriteLine("--- 19. CAIXA ELETRÔNICO ---");
            Console.Write("Saque R$: ");
            int valor = int.Parse(Console.ReadLine()!);
            int[] notas = { 100, 50, 20, 10, 5, 2 };
            foreach (int n in notas)
            {
                int q = valor / n;
                if (q > 0) { Console.WriteLine($"{q} nota(s) de R$ {n}"); valor %= n; }
            }
        }

        static void ExecutarDesafioSquadMenu()
        {
            Console.WriteLine("--- 20. DESAFIO SQUAD: MENU DE ALUNOS ---");
            string[] nomes = new string[10];
            double[] notas1 = new double[10];
            double[] notas2 = new double[10];
            int quantidadeAlunos = 0, tentativasErro = 0, opcao = -1;

            while (opcao != 0 && tentativasErro < 3)
            {
                Console.WriteLine("\n1 - Lista de alunos | 2 - Buscar aluno | 3 - Exibir aprovados | 4 - Média da turma | 0 - Sair");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine()!);

                if (opcao == 1 || opcao == 2) tentativasErro = 0;
                else if (opcao == 3)
                {
                    tentativasErro = 0;
                    for (int i = 0; i < quantidadeAlunos; i++)
                    {
                        double media = (notas1[i] + notas2[i]) / 2;
                        if (media >= 7.0) Console.WriteLine($"{nomes[i]} - Média: {media}");
                    }
                }
                else if (opcao == 4)
                {
                    tentativasErro = 0;
                    if (quantidadeAlunos > 0)
                    {
                        double soma = 0;
                        for (int i = 0; i < quantidadeAlunos; i++) soma += (notas1[i] + notas2[i]) / 2;
                        Console.WriteLine($"Média geral: {soma / quantidadeAlunos}");
                    }
                }
                else if (opcao != 0)
                {
                    tentativasErro++;
                    Console.WriteLine($"Opção inválida! Tentativa {tentativasErro} de 3.");
                }
            }
        }

        #endregion
    }
}