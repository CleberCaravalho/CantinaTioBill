# Desafio - Cantina do Tio Bill
Esta aplicação foi desenvolvida como um desafio proposto pela equipe de desenvolvimento do Grupo São Domingos.
Em Resumo, temos que a Cantina do Tio Bill está em busca de automatizar o processo de vendas de suas quentinhas. 
No caso, Ela gostaria de um sistema para gerenciar os seus clientes e as vendas

## Requisitos
Os requisitos necessarios para os teste da aplicação são:
 - .NET Core
 - Entity Framework
 - Visual Studio 2019
 - SQL Server
 
 ## Instalação
 Para rodar a aplicação, verifque se a maquina possui SQL Server ou similar instalado. As seguintes dependencias são necessarias no projeto.
 Instale as dependencias via Visual Studio pelos comandos
  - SQL Server provider: `Install-Package Microsoft.EntityFrameworkCore.SqlServer`
  
  ## Configuração
  A aplicação usa o Entity Framework como ORM, então, ao realizar os teste altere a `connection string` no arquivo `ApplicationDBContext.cs` na pasta `Models`.
  Para a devida configuração, verifique o caminho disponibilizado pelo DB instalado na sua maquina:
  
  ```
  public class ApplicationDbContext : DbContext
    {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
      }
    }
  ```
  
## Links
  - SQL Server: [https://www.microsoft.com/pt-br/sql-server/sql-server-downloads](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
  - Visual Studio Community 2019: [https://visualstudio.microsoft.com/pt-br/vs/community/](https://visualstudio.microsoft.com/pt-br/vs/community/)
  
