# GerenciadorTarefas

Projeto desenvolvido durante as aulas do curso técnico em Informática para Internet do [SENAI-MG](https://www.fiemg.com.br/senai/), com o objetivo de criar um gerenciador de tarefas no C#.

## Ferramentas utilizadas

-  **Framework:** .NET
-  **IDE**: Visual Studio Code
-  **Versionamento:** GIT
-  **Gestão de repositórios:** GitHub

## Funcionalidades

- **Adicionar Tarefa**: Permite ao usuário inserir a descrição de uma nova tarefa.
- **Listar Tarefas**: Exibe todas as tarefas registradas, com seu ID, descrição e status (concluída ou pendente).
- **Concluir Tarefa**: Marca uma tarefa como concluída, baseado no ID informado pelo usuário.
- **Remover Tarefa**: Remove uma tarefa da lista, com base no ID informado.

## Estrutura

O código está organizado em quatro arquivos principais, que são responsáveis por diferentes partes do sistema:

- **Layout.cs**: Contém a classe `Formatacao` com métodos para formatar a saída no console, como mudar a cor do texto e imprimir o cabeçalho.

- **Tarefas.cs**: Contém a classe `Tarefa` que representa uma tarefa com ID, descrição e status de conclusão.

- **GerenciarTarefa.cs**: Contém a classe `GerenciadorTarefas` que gerencia a lista de tarefas e fornece métodos para adicionar, listar, concluir e remover tarefas.

- **Program.cs**: Contém o código principal que implementa a interface do usuário e interage com o `GerenciadorTarefas`.

## Exemplo de uso

![Exemplo de uso do gerenciador de tarefas.](/img/Exemplo.gif)

## Como executar

**1. Pré-requisitos:** 
- [.NET SDK](https://dotnet.microsoft.com/download) 9.0 ou superior instalado na máquina.

**2. Clone este repositório:**
```
git clone https://github.com/croldrte/GerenciadorTarefas.git
```

**3. Acesse a pasta do projeto:**
```
cd GerenciadorTarefas
```

**4. Compile e execute o programa:**
```
dotnet run
```