# CatShop - Loja de Itens para Gatos 🐱

Este é um projeto feito em .NET para gerenciar uma loja de itens para gatos. Ele serve como um exemplo de aplicação web utilizando ASP.NET Core.

## 🚀 Tecnologias

* **.NET 8** 
* **ASP.NET Core MVC**
* **Entity Framework Core** 
* **Razor Pages**

## 📂 Estrutura de Diretórios

* `Areas/` - Áreas da aplicação
* `Data/` - Configuração e acesso ao banco de dados
* `Models/` - Modelos de dados
* `Pages/` - Páginas Razor
* `Services/` - Serviços da aplicação
* `wwwroot/` - Arquivos estáticos (CSS, JS, imagens)
* `appsettings.json` - Arquivo de configuração
* `Program.cs` - Ponto de entrada da aplicação

## 💻 Como Executar Localmente

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/seu-usuario/catshop-dotnet.git
   cd catshop-dotnet
   ```

2. **Restaure os pacotes:**

   ```bash
   dotnet restore
   ```

3. **Atualize o banco de dados (se aplicável):**

   ```bash
   dotnet ef database update
   ```

4. **Execute o projeto:**

   ```bash
   dotnet run
   ```

5. Abra o navegador em `https://localhost:5001` ou `http://localhost:5000`.


