# Gerenciador de Tarefas - Back-End

API REST desenvolvida com **ASP.NET Core 8**, responsável por gerenciar tarefas e autenticação de usuários via **JWT**.

---

## 🚀 Tecnologias Utilizadas

- .NET 8 (ASP.NET Core Web API)
- Entity Framework Core (banco em memória)
- AutoMapper
- FluentValidation
- JWT (autenticação via token)
- Swagger
- xUnit (testes unitários)

---

## ⚙️ Como Executar

1. Clone o repositório:

bash
git clone https://github.com/RibeiroVinicius/Gerenciador-TarefasBack
cd Gerenciador-TarefasBack

2. Restaure as dependências:
dotnet restore

3. Inicie a aplicação:
dotnet run

4. Acesse o Swagger em:
https://localhost:5001/swagger

---

## 🔐 Login de Teste

Usuário: administrador

Senha: mv

Após o login, o token JWT será retornado e deverá ser usado nas requisições protegidas.

---

## 📁 Estrutura do Projeto
Controllers/ – Controladores da API (Login, Tarefas)

DTOs/ – Objetos de transferência de dados

Models/ – Entidades principais

Services/ – Regras de negócio

Repositories/ – Acesso aos dados (fake DB)

Validators/ – Validações com FluentValidation

Tests/ – Testes unitários com xUnit

---

## ✅ Funcionalidades Implementadas
Autenticação com JWT

CRUD de tarefas (criar, listar, editar, excluir)

Filtros por status e data (lado do front)

Validações com FluentValidation

Testes unitários no serviço de tarefas

Integração com Swagger para documentação dos endpoints
