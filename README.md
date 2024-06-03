# Sobre o projeto
Esta **API**, desenvolvida utilizando **.NET 8**, adota os princípios do **Domain-Driven Design (DDD)** para oferecer uma solução estruturada e eficaz no gerenciamento de despesas pessoais. O principal objetivo é permitir que os usuários registrem suas despesas, detalhando informações como título, data e hora, descrição, valor e tipo de pagamento, com os dados sendo armazenados de forma segura em um banco de dados **MySQL**.

A arquitetura da **API** baseia-se em **REST,** utilizando métodos **HTTP** padrões para uma comunicação eficiente e simplificada. Além disso, é complementada por uma documentação **Swagger**, que proporciona uma interface gráfica interativa para que os desenvolvedores possam explorar e testar os endpoints de maneira fácil.

Dentre os pacotes NuGet utilizados, o **AutoMapper** é o responsável pelo mapeamento entre objetos de domínio e requisição/resposta, reduzindo a necessidade de código repetitivo e manual. O **FluentAssertions** é utilizado nos testes de unidade para tornar as verificações mais legíveis, ajudando a escrever testes claros e compreensíveis. Para as validações, o **FluentValidation** é usado para implementar regras de validação de forma simples e intuitiva nas classes de requisições, mantendo o código limpo e fácil de manter. Por fim, o **EntityFramework** atua como um ORM (Object-Relational Mapper) que simplifica as interações com o banco de dados, permitindo o uso de objetos .NET para manipular dados diretamente, sem a necessidade de lidar com consultar SQL.

![hero-image]

### Resumo

- API PROJECT: Recebeu uma requisição e retorna uma resposta, somente isso
- APPLICATION PROJECT: Biblioteca de classes, que tem uma função específica. Ela que vai conter as regras de negócio (validações).
- EXCEPTION PROJECT: Contém as minhas próprias exceptions.
- COMMUNICATION PROJECT: Classes de Request e Response. Quando vamos cadastrar um usuário, este usuário(a) precisa passar informações como Nome, Email, Senha e nós passamos essas informações no Body da Requisição, então, nesse projeto criamos a classe RequestRegisterUser, por exemplo, que vai conter Nome, Email e Senha. Quando a Requisição chegar e, caso o Body contenha esses valores internamente, o Dotnet os colocará nas propriedades corretas da classe. Também contém as classes de Respostas, que contém partes essenciais de uma Entidade (User, por exemplo).
- DOMAIN PROJECT: Coisas comuns a todos no projeto. Não colocamos em Domain implementações específicas. Utilizamos esse projeto para colocar classes mais abstratas. Colocamos nele um contrato, uma interface.
- INFRAESTRUCTURE PROJECT: Aqui ficam as implementações. Tudo que a API precisa comunicar que está externo à ela, como upload de foto, enviar email, salvar no banco de dados, tudo isso está externo. O código que põe a mão na massa pra implementar isso ficará nesse projeto.
- As setas indicam os acessos permitidos a cada um dos projetos.
- Na prática, devido à Injeção de Dependência, o projeto de API irá conhecer o projeto de Infraestrutura.

### Features

- **Domain-Driven Design (DDD):** Estrutura modular que facilita o entendimento e a manutenção do domínio da aplicação.
- **Testes de Unidade:** Testes com FluentAssertions para garantir a funcionalidade e a qualidade.
- **Geração de Relatórios:** Capacidade de exportar relatórios detalhados para **PDF e Excel**, oferecendo uma análise visual e eficaz das despesas.
- **RESTful API com Documentação Swagger**: Interface documentada que facilita a integração e o teste por parte dos desenvolvedores.

### Construído com

![badge-dot-net]
![badge-rider]
![badge-mysql]
![badge-windows]
![badge-swagger]

### Getting Started

Para testar localmente, siga esses passos:

### Requisitos

- IDE (Visual Studio 2022+, VSCode, Rider)
- Windows 10+ ou LInux/MacOS com [.NET SDK][dot-net-sdk] instalado
- MySQL Server

### Instalação

1. Clone o repositório:
  ```sh
  git clone https://github.com/IgorCastilhos/FinanceApp.git
  ```
2. Preencha as informações no arquivo `appsettings.Development.json`.
3. Execute a API.

<!-- Links -->
[dot-net-sdk]: https://dotnet.microsoft.com/en-us/download/dotnet/8.0

<!-- Images -->
[hero-image]: images/financeApp.png
<!-- Badges -->
[badge-dot-net]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge
[badge-windows]: https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=fff&style=for-the-badge
[badge-rider]: https://img.shields.io/badge/Rider-000?logo=rider&logoColor=fff&style=for-the-badge
[badge-mysql]: https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=fff&style=for-the-badge
[badge-swagger]: https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge
