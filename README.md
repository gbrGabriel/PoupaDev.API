# PoupaDev - Jornada .NET Direto ao Ponto

Foi desenvolvida uma API REST completa de gerenciamento de objetivos financeiros.

## Tecnologias e práticas utilizadas
- ASP.NET Core com .NET 6
- Entity Framework Core
- SQL Server
- Swagger
- Injeção de Dependência
- Programação Orientada a Objetos
- Hosted Services

## Funcionalidades
- Cadastro, Listagem, Detalhes de Objetivo Financeiro
- Saque e Depósito de Objetivo Financeiro
- Rendimento Automático

## Passo a passo para rodar o Projeto (Visual Studio Code)
- dotnet tool install --global dotnet-ef
- dotnet user-secrets init
- dotnet user-secrets set "ConnectionStrings:PoupaDevCs" "Server=IpDoSeuSqlServer;Database=PoupaDevDb;User ID=sa;Password=SenhaDoSeuDb")
- dotnet ef migrations add initialMigrations -o Persistence/Migrations
- dotnet ef database update

