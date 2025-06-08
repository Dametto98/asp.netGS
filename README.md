# ExtremeHelp: Resposta Rápida em Eventos Extremos

## 1. Visão Geral do Projeto

O projeto **ExtremeHelp** é uma solução criativa e inovadora proposta como um MVP (Mínimo Produto Viável) de uma plataforma de resposta a desastres. [cite_start]Com o aumento da frequência e intensidade de eventos climáticos extremos [cite: 1][cite_start], a agilidade na comunicação e na coordenação de ajuda tornou-se fundamental.

[cite_start]O objetivo deste projeto é desenvolver um aplicativo móvel que conecte pessoas que necessitam de auxílio com voluntários dispostos a ajudar durante e após a ocorrência de desastres naturais ou situações críticas. [cite_start]Além disso, a plataforma serve como um canal centralizado para alertas preventivos e informações úteis.

## 2. Tecnologias Utilizadas

A solução foi construída utilizando a stack de tecnologias .NET, seguindo as diretrizes e disciplinas do curso.

* **Backend (API):** C# com ASP.NET Core
* **Banco de Dados:** SQL Server com Entity Framework Core
* **Arquitetura:** API RESTful, relacionamento 1:N entre Categorias e Dicas.
* **Documentação da API:** Swagger (OpenAPI)

## 3. Funcionalidades Principais (MVP)

* [cite_start]**Gestão de Alertas:** Permite o cadastro e consulta de alertas importantes sobre eventos críticos.
* [cite_start]**Gestão de Dicas de Preparação:** Permite o cadastro e consulta de dicas de segurança, organizadas por categorias.
* **API Robusta:** Endpoints para criar, ler, atualizar e deletar os principais recursos da aplicação.

## 4. Como Executar o Projeto

Siga os passos abaixo para executar a solução localmente.

### Pré-requisitos
* Visual Studio 2022
* .NET 8 SDK
* SQL Server (a instância `(localdb)\MSSQLLocalDB` que vem com o Visual Studio é suficiente)

### Passos para Instalação
1.  Clone este repositório:
    ```bash
    git clone [URL_DO_SEU_REPOSITORIO]
    ```
2.  Abra o arquivo `ExtremeHelp.sln` com o Visual Studio.
3.  **Configuração do Banco de Dados:**
    * O projeto está configurado para usar a string de conexão diretamente nos arquivos `Program.cs` e `DesignTimeDbContextFactory.cs` para garantir a execução. Não é necessário alterar o `appsettings.json`.
4.  **Aplicar as Migrations:**
    * No menu do Visual Studio, vá em **Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes**.
    * Verifique se o projeto padrão selecionado é o `ExtremeHelp.Api`.
    * Execute o comando para criar o banco de dados e as tabelas:
        ```powershell
        Update-Database
        ```
5.  **Executar a Solução:**
    * Pressione **F5** ou clique no botão de "Iniciar" (com os múltiplos projetos de inicialização `ExtremeHelp.Api` e `ExtremeHelp.WebApp`).

## 5. Como Testar a API

Após a execução, a interface do Swagger será aberta no navegador.

* **URL do Swagger:** `http://localhost:[SUA_PORTA]/swagger`

### Exemplo de Requisição: Criar um Alerta

* **Endpoint:** `POST /api/Alertas`
* **Corpo da Requisição (JSON):**
    ```json
    {
      "titulo": "ALERTA DE TESTE: Risco de Enchente",
      "mensagem": "Nível do rio subindo rapidamente. Evite áreas de risco.",
      "dataPublicacao": "2025-06-08T19:50:00Z"
    }
    ```
* **Resposta Esperada:** Código de status `201 Created`.