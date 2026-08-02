### 1. Resumo para Estudo e Fixação

* **Visão Geral do Fluxo C# / .NET:**
* **Código-fonte (`.cs`):** Texto em C# escrito pelo desenvolvedor. O computador não o executa diretamente.
* **Compilação (`Roslyn`):** Valida sintaxe, tipos, referências e regras da linguagem. Transforma o código C# em uma linguagem intermediária (`IL` / `CIL`).
* **Código Intermediário (`IL` / `CIL` / `MSIL`):** Formato padrão do .NET que garante compatibilidade entre diferentes sistemas (Windows, Linux, macOS) e arquiteturas (x64, ARM64).
* **.NET Runtime & CLR:** O motor do .NET. O CLR (*Common Language Runtime*) gerencia a execução, memória, exceções e threads.
* **JIT (*Just-In-Time*):** Traduz o código intermediário (`IL`) para código de máquina nativo durante a execução.


* **Estrutura de Arquivos e Pastas:**
* **`.csproj`:** Arquivo XML com as configurações do projeto (versão do .NET, tipo de saída, dependências).
* **Pasta `obj`:** Guarda arquivos intermediários temporários do processo de *build*.
* **Pasta `bin`:** Armazena os arquivos finais gerados (DLL, EXE, configurações de runtime).


* **Modos de Compilação e Publicação:**
* **Debug vs. Release:** *Debug* é voltado ao desenvolvimento (facilita depuração); *Release* é voltado à produção (aplica otimizações de desempenho).
* **Framework-dependent vs. Self-contained:** *Framework-dependent* exige a instalação do .NET no ambiente de destino (gerando arquivos menores); *Self-contained* já empacota o runtime junto à aplicação.


* **Tipos de Erros:**
* **Compilação:** Ocorrem antes da execução (erros de sintaxe, tipos incompatíveis, pontuação).
* **Execução (*Runtime*):** Ocorrem enquanto o programa roda (divisão por zero, conversão inválida de formato).
* **Lógica:** O programa compila e roda sem exceções, mas gera um resultado incorreto por falha na regra implementada (ex.: falta de parênteses no cálculo de uma média).



---

### 2. Gabarito das Perguntas de Revisão (Slide 33)

1. **O que é compilação?**
* É o processo de analisar e transformar o código-fonte C# em um formato intermediário (`IL`/`CIL`), validando regras de sintaxe, tipos e estruturas antes da execução.


2. **Qual a diferença entre *build* e *run*?**
* `dotnet build` apenas compila e valida o projeto, gerando os arquivos de saída sem iniciar o programa.
* `dotnet run` realiza a compilação (quando necessário) e executa o programa.


3. **Para que serve o `.csproj`?**
* Armazena as configurações fundamentais do projeto, como o tipo de aplicação, versão do .NET, opções de compilação e dependências de pacotes.


4. **O que são `bin` e `obj`?**
* **`obj`:** Guarda arquivos temporários e metadados usados durante a compilação.
* **`bin`:** Guarda os binários finais gerados prontos para uso/teste (DLLs, EXEs).


5. **O que é `IL`/`CIL`?**
* *Intermediate Language* (ou *Common Intermediate Language*), a linguagem intermediária e neutra do .NET que permite que o código rode em diferentes plataformas.


6. **Qual o papel do .NET Runtime?**
* É o ambiente de execução responsável por carregar o programa, acionar o JIT, gerenciar memória, controlar threads e tratar exceções por meio do CLR.


7. **O que é JIT?**
* *Just-In-Time Compiler*: o compilador interno do runtime que traduz o código intermediário (`IL`) para código de máquina nativo conforme as partes do sistema são chamadas.


8. **Qual a diferença entre erro de compilação, execução e lógica?**
* **Compilação:** Impede a geração do binário devido a regras da linguagem violadas.
* **Execução:** Quebra a aplicação durante o funcionamento devido a cenários não previstos (ex.: divisão por zero).
* **Lógica:** O código roda perfeitamente, mas entrega o resultado errado devido a uma falha na instrução do desenvolvedor.


9. **Quando usamos `dotnet publish`?**
* Quando a aplicação está pronta para ser distribuída, empacotando os artefatos necessários para o ambiente de produção, servidores ou *containers*.


10. **Qual a diferença entre *Debug* e *Release*?**
* ***Debug*:** Inclui símbolos de depuração e não otimiza o código, facilitando a inspeção linha por linha.
* ***Release*:** Aplica otimizações de desempenho e reduz o tamanho dos arquivos, ideal para a versão final de produção.