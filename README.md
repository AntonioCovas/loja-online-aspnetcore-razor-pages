# 🛒 Quitanda Online

Aplicação web simples de e-commerce desenvolvida com ASP.NET Core e Razor Pages.

## 🚀 Tecnologias

* .NET 10
* C#
* Razor Pages
* Entity Framework Core
* SQLite

## 📌 Sobre o projeto

Este projeto simula uma quitanda online, permitindo o gerenciamento básico de produtos e clientes através de operações CRUD.

O objetivo principal é praticar:

* Renderização no lado do servidor (SSR)
* Estruturação de aplicações com Razor Pages
* Integração com banco de dados utilizando Entity Framework Core
* Boas práticas de desenvolvimento backend

## ⚙️ Como executar o projeto

1. Clone o repositório:

```bash
git clone https://github.com/AntonioCovas/loja-online-aspnetcore-razor-pages.git
```

2. Acesse a pasta do projeto:

```bash
cd diretorio-app
```

3. Restaure as dependências:

```bash
dotnet restore
```

4. Execute as migrations para criar o banco:

```bash
dotnet ef database update
```

5. Execute a aplicação:

```bash
dotnet run
```

6. Acesse no navegador:

```
https://localhost:5001
```

## ⚠️ Observações

* O banco de dados SQLite não é versionado no repositório
* O banco é criado automaticamente via migrations

## 📚 Status

🚧 Projeto em desenvolvimento para fins de estudo