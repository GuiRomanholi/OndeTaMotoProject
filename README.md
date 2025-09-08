# OndeTaMoto API — CP4
API para gestão de locações de motos. 

---

## Descrição do Domínio
Este projeto é uma **API** para a gestão completa de um sistema de locação de motocicletas.  
Ela permite:  
- Cadastro de clientes e motos.  
- Criação de novas locações com controle de período e status.  
- Consulta e gerenciamento de todos os dados do negócio.  

---

## Como Rodar 

1. Git clone https://github.com/GuiRomanholi/OndeTaMotoProject.git
2. Selecione a pasta OndeTaMoto e selecione OndeTaMoto.sln para compilar o projeto completo
3. Ao rodar o Crud, rode com HTTPS 
4. Ao rodar o Crud com Swagger, rode com esse link http://localhost:5294/swagger/index.html 

---
##  Arquitetura (Clean Architecture)

O projeto segue uma arquitetura em camadas para garantir **baixo acoplamento** e **separação de responsabilidades**:

- **OndeTaMotoApi**: Camada de apresentação e entrada (Controllers, DI).  
- **OndeTaMotoBusiness**: Camada de aplicação e lógica de negócio (Casos de uso, DTOs).  
- **OndeTaMotoModel**: Camada de domínio (Entidades, Value Objects, Interfaces de Repositório).  
- **OndeTaMotoData**: Camada de infraestrutura (EF Core, Repositórios, Migrations).  

---

## DDD

A modelagem do sistema é guiada pelos princípios de **Domain-Driven Design (DDD)**.
  
- **Value Objects**: `Email`.  

**Invariantes de Domínio:**  
- `MotoId` deve ser maior que 0.   
- `UsuarioId` deve ser maior que 0.  

---

### 1) Configurar a Connection String
Edite o arquivo `appsettings.json` na raiz do projeto **OndeTaMotoApi** e adicione sua string de conexão:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=oracle.fiap.com.br:1521/orcl; User Id=FIAP_ORACLE_USER; Password=FIAP_ORACLE_PASS;"
  }
}

```
---

## Tecnologias Utilizadas

- [.NET 8](https://dotnet.microsoft.com/en-us/)
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger (Swashbuckle)
- Visual Studio 2022+
- REST Client (ou Postman)

---

  ## Integrantes
- Guilherme Romanholi Santos — RM: **557462** 

