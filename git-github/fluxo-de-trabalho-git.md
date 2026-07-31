# Guia Prático: Fluxo de Trabalho e Boas Práticas em Git & GitHub
Documentação técnica do fluxo de trabalho padrão para versionamento de projetos, desenvolvida durante as atividades práticas do curso **Dev Back-end .NET (C#) WoMakersCode**.

## Fluxo de Execução
[1. Preparação Local] ➔ [2. Registro Local] ➔ [3. Envio para Nuvem] ➔ [4. Verificação] ➔ [5. Validação/Clone]

## Detalhamento das Etapas

Fase 1: Preparação e Edição Local
    •	Objetivo: Criar, organizar ou editar os arquivos do projeto na máquina local.
    •	Ação Exemplo: Inclusão de pastas de projeto e edição do arquivo README.md para incluir a licença (ex.: Licença MIT).

Fase 2: Registro no Git Local (Staging e Commit)
    •	Objetivo: Salvar um ponto de checagem (snapshot) do trabalho no histórico local.
    •	Comandos:
Bash

# Prepara todas as alterações para o registro
    git add .

# Salva a versão no histórico com mensagem descritiva
    git commit -m "Adiciona documentação inicial e licença MIT"

Fase 3: Sincronização com o Repositório Remoto (Push)
    •	Objetivo: Enviar os commits registrados localmente para o GitHub.
    •	Comando:
                Bash
                git push


Fase 4: Verificação de Integridade e Histórico
    •	Objetivo: Validar se o repositório local está sincronizado com a nuvem e revisar o histórico.
    •	Comandos:
                Bash

# Verifica o status da área de trabalho (deve indicar: 'working tree clean')
                git status

# Exibe o histórico resumido de commits
                git log --oneline

Fase 5: Validação Externa (Clone de Teste)
    •	Objetivo: Simular o download do projeto por terceiros (avaliadores) para garantir a integridade do repositório.
    •	Comando:
                Bash
                git clone [https://github.com/ROSANARRL/WoMakersCode.git](https://github.com/ROSANARRL/WoMakersCode.git)

Comandos Úteis de Navegação no Terminal
    •	Navegar para a pasta do projeto:
                Bash
cd WoMakersCode
    •	Subir um nível de pasta (Sair do diretório atual):
                Bash
                cd ..


## Executando a tarefa

1ª FASE – Criar a Issue (Mapear a tarefa)
1.	Ir ao repositório do grupo no GitHub.
2.	Clicar na aba Issues -> New Issue.
3.	Preencher o Título e a Descrição:
    a.	Título: Criar código de conduta da comunidade (código-de-conduta.md)
    b.	Descrição (Description):

‘Contexto: O repositório precisa apresentar o código de conduta e as regras de convivência da comunidade.

Escopo: Criar e preencher o arquivo codigo-de-conduta.md.

Critérios de aceite:
- [ ] Criar o arquivo codigo-de-conduta.md
- [ ] Adicionar um título principal
- [ ] Listar as regras de respeito, inclusão e convivência da comunidade
- [ ] Utilizar uma linguagem clara e inclusiva
- [ ] Conferir se o Markdown está aparecendo corretamente
- [ ] Não alterar outros arquivos’

4. Em Assigness (coluna direita), clicar em Assign Yourself para atribuir a tarefa a você. (Opcional)
5. Finalizar esta etapa: clicar no botão “Create”.

2ª FASE – Desenvolvimento Local (VS Code)
Passo 1: Clonar o repositório
1.	Clicar na Aba Code no GitHub.
2.	Clicar no <>Code e copiar link HTTPS do repositório.
3.	Abrir o VS Code no meu computador e abrir novo Terminal.
4.	Conferir se estou na pasta correta para entrar: cd <nome da pasta>
5.	Dentro da pasta correta, no Terminal clonar o projeto: git clone <colar link HTTPS>
6.	No menu do VS Code, ir em File > Open Folder e abra a pasta baixada (manual-comunidade-squad).

Passo 2: Entrar na pasta e criar a branch
1.	No Terminal do VS Code, garantir que estou na pasta do projeto.
2.	Criar e alterar para a minha branch de trabalho:
    o	Correção: Evitar acentos e caracteres específicos no nome da branch.
    o	Comando correto: git checkout -b feature/codigo-de-conduta

Passo 3: Criar o arquivo 
1.	No painel do VS Code, certifique-se de que está na pasta correta e clique novo arquivo (New File).
2.	Digite o nome exato com a extensão (sem acento e com .md no final): codigo-de-conduta.md

Passo 4: Escrever o conteúdo e salvar
# Código de Conduta da Comunidade

## 1. Nosso Compromisso
Nos dedicamos a proporcionar uma experiência livre de assédio, discriminação e intimidação para todas as pessoas participantes, independentemente de gênero, orientação sexual, deficiência, aparência física, raça ou religião.

## 2. Nossos Padrões
Exemplos de comportamentos que contribuem para criar um ambiente positivo:
* Usar linguagem empática, acolhedora e inclusiva.
* Respeitar pontos de vista e experiências diferentes.
* Aceitar críticas construtivas graciosamente.
* Focar no que é melhor para a comunidade.

Exemplos de comportamentos inaceitáveis:
* Uso de linguagem ou imagens de caráter sexual não solicitadas.
* Comentários pejorativos, intimidação ou ataques pessoais/políticos.
* Assédio público ou privado.
* Publicação de informações privadas de terceiros sem permissão.

## 3. Responsabilidades
A liderança e os organizadores do projeto são responsáveis por esclarecer os padrões de comportamento e tomar as medidas corretivas adequadas em resposta a qualquer comportamento inaceitável. 


Passo 5: Enviar as alterações para o GitHub
No terminal do VS Code, rode os 3 comandos abaixo em sequência:
1.	Preparar os arquivos: git add .
2.	Gravar as alterações localmente:
    o	Comando: git commit -m "docs: adiciona codigo de conduta da comunidade"
3.	Enviar para o servidor: git push origin feature/codigo-de-conduta.


3ª FASE  - Finalização e Integração (GitHub)

Passo 6: Abrir o Pull Request (PR)
1.	Voltar à página do repositório no navegador.
2.	Clicar no botão Compare & pull request na faixa amarela.


Passo 7: Preencher e Criar o Pull Request (Opção Rascunho / Draft)
1.	Título: docs: adiciona codigo-de-conduta.md
2.	Descrição: Escrever Closes #2 (para vincular à Issue).
Automação do GitHub:

    •	Quando você escreve Closes #2 (ou Fixes #2), o GitHub entende que aquele Pull Request entrega exatamente o que a Issue #2 estava pedindo.

Fechamento automático:

    •	Assim que a líder ou a squad clicar em Merge pull request para aprovar o seu código, o próprio GitHub vai fechar a Issue #2 automaticamente.

Organização do Projeto:

    •	Economiza tempo, pois você não precisa ir manualmente na aba Issues depois para fechar a tarefa, evitando que o painel do grupo fique com pendências desatualizadas.

3. Forma de envio:

    a. Para enviar direto para revisão: Clicar em "Create pull request".

    b. Para enviar como rascunho (trabalho em andamento): Clicar na seta ao lado do botão verde -> Selecionar "Create draft pull request" -> Clicar em "Draft pull request".

Passo 7.1: Mudar de Draft para Pronto para Revisão (quando concluir o trabalho)
1. Abrir a página do PR no GitHub.
2. Na caixa inferior do PR, clicar no botão "Ready for review".
3. O status mudará de cinza (Draft) para verde (Open), avisando a equipe que já pode revisar.


Passo 8: Aprovação e União do Código (Merge)
1.	Aguardar a revisão do Squad/Líder.
2.	Após a revisão, a responsável clica no botão Merge pull request e depois em Confirm merge.
3.	(Opcional) Clicar em Delete branch no GitHub para manter o repositório limpo.

Passo 9: Sair da página com segurança
1.	Clicar no nome do repositório (manual-comunidade-squad) no topo da página para retornar à página principal.
2.	(Opcional) Se desejar atualizar seu VS Code com a versão final do grupo, rode no terminal local:
    o	git checkout main
    o	git pull origin main

Após trabalhar no branch (feature/codigo-de-conduta)

Passo 1: Voltar para a branch principal (main)
Digite e aperte Enter: git checkout main

Passo 2: Atualizar seu projeto local
Para puxar tudo o que a equipe já aprovou e unificou no repositório remoto, digite e aperte Enter:
git pull origin main

    I.	cd .. (Mudar de pasta): Serve para navegar pelas pastas do seu computador (como subir do nível manual-comunidade-squad para a pasta pai WoMakersCode).

    II.	git checkout main (Mudar de branch no Git): Serve para alternar o "modo de trabalho" do código (sair da sua versão de testes feature/codigo-de-conduta e voltar para a versão principal do projeto main).

## Alterando arquivo na pasta do GitHub na máquina via VS Code e subindo para o GitHub web.

Passo 0: Limpar a tela (Opcional)
            Clear

Passo 1: Verificar a área de trabalho
Confeccione o status para garantir que o Git está enxergando a sua alteração no arquivo correto: git status


Passo 2: Sincronizar com o repositório remoto
Como você está na branch main, baixe qualquer alteração pendente apontando para a branch, não para o arquivo: git pull origin main

Passo 3: Adicionar o arquivo alterado à área de preparação (Staging)
Adicione o arquivo específico alterado: git add git-github/fluxo-de-trabalho-git.md

Passo 4: Gravar a alteração no histórico local (Commit)
Crie um ponto de salvamento com uma mensagem descritiva: git commit -m "docs: atualiza fluxo de trabalho no git"

Passo 5: Enviar para o GitHub (Push)
Suba a alteração salva para a sua branch principal na nuvem: git push origin main

## Resumo da rotina mental para fixar:

	git status → O que mudou?
	git pull → Atualizar o local.
	git add → Selecionar o arquivo.
	git commit → Salvar o pacote localmente.
	git push → Enviar para a nuvem.

