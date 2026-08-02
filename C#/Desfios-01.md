## Desafios-01

# Desafio 1: Calculadora de idade
O usuário informa o ano em que nasceu e o sistema retorna quantos anos ele tem (considerando o ano atual).
Fórmula: idade = anoAtual - anoNascimento
Exemplo de entrada e saída:
Digite o ano atual: 2026
Digite o ano em que você nasceu: 1995
Você tem 31 anos.
💡 Dica: peça o ano atual ao usuário (mais simples) ou coloque um valor fixo no código.
Conceitos avaliados: Variáveis, int, operação matemática (módulos 2, 3).


using System

// Perguntar o nome do usuário
Console.Write("What is your name? ");
string name = Console.ReadLine();

// Cumprimentar o usuário
Console.WriteLine($"Hello, {name}! Nice to meet you.");

// Perguntar o ano de nascimento
Console.Write("What year were you born? ");

// Capturar o ano digitado como texto (string)
string yearInput = Console.ReadLine();

// Converter o texto digitado em um número inteiro (int)
int yearBorn = int.Parse(yearInput);

// Definir o ano atual como um valor fixo número (int)
int currentYear = 2026;

// Faz a operação matemática de subtração
int age = currentYear - yearBorn;


// Exibe o resultado final na tela juntando o texto com o valor da variável age
Console.WriteLine($"You are {age} years old.");



		EXPLICAÇÃO
Como o C# não permite fazer operações matemáticas diretamente com textos, eu precisei criar uma estratégia em duas etapas:

Primeiro, usei uma variável do tipo string chamada yearInput para receber o teclado.
Depois, usei o método int.Parse() para converter esse texto no número inteiro yearBorn.
Com os dados convertidos para int, consegui subtrair de forma segura (currentYear - yearBorn) e exibir o resultado final na tela.

LINK
https://dotnetfiddle.net/8eQ217


# Desafio 2: Receita de torta de tomate
O usuário informa quantas porções de torta de tomate deseja fazer. A receita original rende 4 porções. A aplicação deve mostrar a quantidade ajustada de cada ingrediente.
Fórmula: novaQuantidade = quantidadeOriginal * (porcoes / 4.0)

Regras:
Receita original (4 porções): Farinha 2 xícaras, Tomate picado 1 xícara, Leite 200 ml, Ovos 2 unidades, Sal 1 colher.
Atenção ao tipo: use double e divida por 4.0 (não 4) para manter casas decimais.

Exemplo de entrada e saída:
Quantas porções deseja fazer? 8
Ingredientes para 8 porções:
Farinha: 4 xícaras
Tomate picado: 2 xícaras
Leite: 400 ml
Ovos: 4 unidades
Sal: 2 colheres
Conceitos avaliados: Variáveis, double, operações matemáticas (módulos 2, 3).


using System;

// Perguntar o nome do usuário.
Console.Write("What is your name? ");
string name = Console.ReadLine();

// Cumprimentar o usuário e perguntar a quantidade de porções.
Console.WriteLine($"Hello, {name}! Nice to meet you.");
Console.Write("How many servings of tomato pie would you like to make? ");

string numberInput = Console.ReadLine();

// Usar o double.TryParse porque o usuário pode querer fazer meia receita, como por exemplo 2,5 porções.
if (double.TryParse(numberInput, out double servings))
{
    // A receita original rende 4 porções.
    // Calculamos o fator multiplicador dividindo as porções desejadas por 4.0.
    double factor = servings / 4.0;

    // Ingredientes da receita original (valores base)
    double baseFlour = 2.0;    // Farinha (xícaras)
    double baseTomato = 1.0;   // Tomate picado (xícara)
    double baseMilk = 200.0;   // Leite (ml)
    double baseEggs = 2.0;     // Ovos (unidades)
    double baseSalt = 1.0;     // Sal (colher)

    // Calculando as novas quantidades multiplicando pelo fator calculado.
    double newFlour = baseFlour * factor;
    double newTomato = baseTomato * factor;
    double newMilk = baseMilk * factor;
    double newEggs = baseEggs * factor;
    double newSalt = baseSalt * factor;

    // Exibindo os resultados na tela exatamente como o exemplo pediu.
    Console.WriteLine($"\nIngredients for {servings} servings:");
    Console.WriteLine($"Flour: {newFlour} cups");
    Console.WriteLine($"Chopped tomato: {newTomato} cups");
    Console.WriteLine($"Milk: {newMilk} ml");
    Console.WriteLine($"Eggs: {newEggs} units");
    Console.WriteLine($"Salt: {newSalt} spoons");
}
else
{
    // Mensagem de erro caso o usuário digite letras em vez de números
    Console.WriteLine("That wasn't a valid number of servings!");
}


		EXPLICAÇÃO

LINK
https://dotnetfiddle.net/dvcyor

# Desafio 3: Ímpares de 200 a 0
Crie um programa que conte de 200 até 0 (decrescente) e mostre apenas os números ímpares.
Exemplo de entrada e saída:
199 197 195 193 ... 3 1
Conceitos avaliados: Laço for decrescente + operador % (módulos 3 e 7).

using System;

// Indica o início do programa
Console.WriteLine("Printing odd numbers from 200 down to 0:");

// O laço começa em 200, roda enquanto o contador for maior ou igual a 0, e diminui 1 a cada volta (i--)
for (int counter = 200; counter >= 0; counter--)
{
    // O operador % pega o resto da divisão do número atual por 2.
    // Se o resto for IGUAL a 1, significa que o número atual é ÍMPAR.
    if (counter % 2 == 1)
    {
        // Mostra o número ímpar na tela separado por um espaço, conforme o exemplo do exercício
        Console.Write($"{counter} ");
    }
}

// Quebra a linha no final para o console ficar organizado
Console.WriteLine();

Entendendo o Operador % (Resto da Divisão)

O operador % não faz uma divisão normal. Ele devolve o resto que sobra de uma divisão inteira.

Se você dividir 4 por 2, o resultado é 2 e sobra 0 (4 é par).
Se você dividir 5 por 2, o resultado é 2 e sobra 1 (5 é ímpar).

💡 A regra de ouro: Qualquer número inteiro que, ao ser dividido por 2, deixar o resto igual a 1 é, obrigatoriamente, um número ímpar.

No C#, escrevemos essa pergunta assim: if (i % 2 != 0) ou if (i % 2 == 1).

			EXPLICAÇÃO

No Desafio 3, eu criei um laço for decrescente. Ele começa no número 200 e vai diminuindo de um em um enquanto o contador for maior ou igual a zero.

A cada volta do laço, o programa faz uma checagem usando o operador de módulo, que é o símbolo de porcentagem. Ele pega o resto da divisão do número atual por 2. 
Se esse resto for igual a 1, o sistema entende que o número é ímpar e o exibe na tela.

# Desafio 4: Sistema de desconto na compra

O usuário informa o valor total da compra. O sistema aplica um desconto conforme as faixas abaixo e mostra o valor final.
Regras:
valor < 100 → sem desconto
valor >= 100 e < 500 → 5% de desconto
valor >= 500 → 10% de desconto
Exemplo de entrada e saída:
Valor da compra: R$ 250
Desconto aplicado: 5%
Valor a pagar: R$ 237,50
Conceitos avaliados: Variáveis, double, if/else if/else (módulos 2, 3, 4).


using System;

// 1. Entrada de dados e cumprimento ao usuário.
Console.Write("What is your name? ");
string name = Console.ReadLine();

Console.WriteLine($"Hello, {name}! Nice to meet you.");

// 2. Solicitar o valor total da compra.
Console.Write("Total amount: R$ ");
string inputAmount = Console.ReadLine();

// Usar double.TryParse porque o valor da compra pode ter centavos (casas decimais).
if (double.TryParse(inputAmount, out double totalAmount))
{
    // Criar as variáveis necessárias para o cálculo do desconto.
    int discountPercentage = 0;

    // Regra 1: Compras menores que 100 não ganham desconto (continua 0).
    if (totalAmount < 100)
    {
        discountPercentage = 0;
    }
    // Regra 2: Compras entre 100 (inclusive) e 500 (exclusive) ganham 5%.
    else if (totalAmount >= 100 && totalAmount < 500)
    {
        discountPercentage = 5;
    }
    // Regra 3: Compras a partir de 500 ganham 10%.
    else if (totalAmount >= 500)
    {
        discountPercentage = 10;
    }

    // 3. Cálculos matemáticos finais:
    // Calcular o valor do desconto em dinheiro (Ex.: total * 0.05).
    double discountValue = totalAmount * (discountPercentage / 100.0);
    // Subtrair o desconto do valor total da compra.
    double finalAmount = totalAmount - discountValue;

    // 4. Exibir as saídas, conforme o modelo do exercício.
    Console.WriteLine($"Discount applied: {discountPercentage}%");
    Console.WriteLine($"Amount due: R$ {finalAmount:F2}");
}
else
{
    // Mensagem de segurança caso o usuário digite um valor de texto inválido
    Console.WriteLine("Please, enter a valid numerical value for your purchase.");
}


# Desafio 5: Controle de volume
Crie uma aplicação para controlar o volume de um aparelho de música. O volume começa em 50. Mínimo 0, máximo 100.
Regras:
Menu: 1 - Mostrar volume | 2 - Aumentar | 3 - Diminuir | 4 - Sair
Ao aumentar/diminuir, peça o quanto.
Se a operação fizer o volume sair dos limites (abaixo de 0 ou acima de 100), mostre erro e mantenha o volume atual.
Após cada operação, mostrar o volume atualizado e voltar ao menu.

Exemplo de entrada e saída:
Volume atual: 50
Opção: 2
Aumentar quanto? 30
Volume atual: 80
Opção: 2
Aumentar quanto? 50
Operação inválida! O volume máximo é 100.
Volume atual: 80

Conceitos avaliados: while + switch + if (limites) (módulos 4, 6, 8).

	CÓPIA DO CÓDIGO ENVIADO

using System;


// Definir o volume inicial, conforme a regra do exercício.
int currentVolume = 50;

// Variável de controle do menu. Começa vazia.
string menuOption = "";

// Iniciar o laço de repetição. O menu vai rodar até o usuário digitar "4".
while (menuOption != "4")
{
    // Mostrar sempre o volume atualizado no início de cada ciclo.
    Console.WriteLine($"Volume Atual: {currentVolume}");
    
    // Exibir as instruções do menu na tela
    Console.WriteLine("Menu: 1 - Mostrar Volume | 2 - Aumentar | 3 - Diminuir | 4 - Sair");
    Console.Write("Opção: ");
    menuOption = Console.ReadLine();

    // Avaliar a opção escolhida pelo usuário.
    switch (menuOption)
    {
        case "1":
            // Apenas exibir o volume atualizado na tela.
            break;

        case "2":
            Console.Write("Para qual volume você quer aumentar? ");
            if (int.TryParse(Console.ReadLine(), out int newVolume))
            {
                // Verificar se o novo volume digitado é menor que o atual.
                if (newVolume < currentVolume)
				{
					Console.WriteLine($"Comando inválido! Para diminuir o volume, pressione 3");					
				}
                // Verificar se passou do limite máximo permitido de 100.
                else if (newVolume > 100)
                {
                    Console.WriteLine("Operação inválida! O volume máximo é 100.");
                }
                else
                {
                    // Definir o volume direto para o número digitado.
                    currentVolume = newVolume;
                }
            }
            break;

         case "3":
            Console.Write("Para qual volume você quer reduzir?");
            if (int.TryParse(Console.ReadLine(), out newVolume))
            {
                // Verificar se o novo volume digitado é maior que o atual.
                if (newVolume > currentVolume)
                {
                    Console.WriteLine("Operação inválida! O volume mínimo é 0.");
                }
               //Verificar se ficou abaixo do limite mínimo permitido de 0.
               if (newVolume < 0)
			    {
				   Console.WriteLine("Operação inválida! O volume mínimo é 0.");
			    }
			   else
			    {
				   //Definir o volume direto para o número digitado
				   currentVolume = newVolume;
			    }
			}
			break;

        case "4":
            // Opção de Sair.
            Console.WriteLine("Saindo do controle de volume...");
            break;

        default:            
	   // Mensagem caso o usuário digite algo diferente de 1, 2, 3 ou 4.
            Console.WriteLine("Escolha inválida! Selecione um número entre 1 e 4.");
            break;
    }

    Console.WriteLine();
}

