# GerenciadorTarefas

Projeto desenvolvido durante as aulas do curso técnico em Informática para Internet do [SENAI-MG](https://www.fiemg.com.br/senai/), com o objetivo de criar um gerenciador de tarefas no C#.

## Ferramentas utilizadas

-  **Framework:** .NET
-  **IDE**: Visual Studio Code
-  **Versionamento:** GIT
-  **Gestão de repositórios:** GitHub

## Funcionalidades

- **Adicionar Tarefa**
- **Listar Tarefas**
- **Concluir Tarefa**
- **Remover Tarefa**

## Estrutura

O código está organizado em quatro arquivos principais, que são responsáveis por diferentes partes do sistema:

- **Layout.cs**
Contém a classe `Formatacao`, que é responsável por exibir mensagens no console com cores e formato especial.  A classe oferece dois métodos principais: `Cor`, que exibe a mensagem passada com a cor especificada; e `ImprimirCabecalho`, que exibe um cabeçalho formatado no console com o nome do sistema.

- **Tarefas.cs**
Define a classe `Tarefa`, que representa uma tarefa no sistema. Cada tarefa tem as seguintes propriedades: `Concluida`, um valor booleano que indica se a tarefa foi concluída ou não; `Id`, que armazena o identificador único da tarefa; e `Descricao`, que contém a descrição da tarefa. Além disso, a classe possui o método `ExibirTarefa`, que exibe a tarefa no console, mostrando seu ID, descrição e se foi concluída.

- **GerenciarTarefa.cs**
Contém a classe `GerenciadorTarefas`, responsável pelo gerenciamento das tarefas. Ela possui os métodos principais do programa, usados para adicionar, listar, concluir e remover tarefas da lista de tarefas: `AdicionarTarefa` cria uma nova tarefa e a adiciona à lista; `ListarTarefas` exibe todas as tarefas presentes na lista; `ConcluirTarefa` marca uma tarefa como concluída com base no seu ID; e `RemoverTarefa` permite remover uma tarefa da lista também com base no seu ID.

- **Program.cs**
Contém o loop principal que exibe o menu de opções para o usuário e interage com o sistema de gerenciamento de tarefas.

## Como executar

**Pré-requisito:** 
- Ter o .NET SDK 9.0.2 ou superior instalado na máquina.

**1. Clone este repositório:**
```
git clone https://github.com/croldrte/GerenciadorTarefas.git
```

**2. Acesse a pasta do projeto:**
```
cd GerenciadorTarefas
```

**3. Compile e execute o programa:**
```
dotnet run
```