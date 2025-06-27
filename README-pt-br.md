<!-- |||||||||||||||||||| EN - PT |||||||||||||||||||| -->
<p align='center'>
  <a href="https://github.com/dev-ggomes/auto-refresh-any-site/blob/main/README.md">🇺🇸 English</a> | 
  <a href="https://github.com/dev-ggomes/auto-refresh-any-site/blob/main/README-pt-pt.md">ᴘᴛ Português</a> | 
  <a href="https://github.com/dev-ggomes/auto-refresh-any-site/blob/main/README-pt-br.md">🇧🇷 Português</a>
</p>

<h1 align="center">
  🚀 Auto refrescar qualquer site
</h1>

<p align='center'>
  :octocat: Siga o passo a passo para usar este código da forma correta.
</p>

<p align="center">
  ⭐ Se gostar deste repositório, considere contribuir com uma estrela
</p>

<!-- |||||||||||||||||||| SPONSORS & STARS |||||||||||||||||||| -->
<p align='center'>
  <a href="https://github.com/sponsors/dev-ggomes"><img alt="Sponsor" src="https://img.shields.io/badge/sponsor-30363D?style=for-the-badge&logo=GitHub-Sponsors&logoColor=#white" /></a>
  &nbsp;
  <a href="#"><img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/dev-ggomes/auto-refresh-any-site?style=for-the-badge" /></a>
</p>

<br>

## ✔️ Requisitos 

<p>
  Certifique que tem estes requisitos: <br>

  1. `.NET SDK` Pode fazer o download [aqui](https://dotnet.microsoft.com/download)
  2. Google Chrome (para correr o programa)
  3. Sistema Operacional: `Windows`, `Linux` ou `macOS`
  4. Conexão com a internet

> [!NOTE]
> A versão do SDK recomendada é `.NET 7` ou `.NET 8`

<br>

</p>

## ⚙️ Preparar e usar

  :rocket: **1. Clonar o repositório** <br>
  ```bash
    git clone https://github.com/dev-ggomes/auto-refresh-any-site.git
    cd auto-refresh-any-site
  ```

  <br>

  :rocket: **2. Criar e configurar o projeto na linha de comandos (se ainda não criou)**
  ```bash
    dotnet new console -n GitHubProfileRefresh
    cd GitHubProfileRefresh
  ```

  <br>

  :rocket: **3. Adicionar as dependências Selenium**
  ```bash
    dotnet add package Selenium.WebDriver
    dotnet add package Selenium.WebDriver.ChromeDriver
  ```

  <br>

  :rocket: **4. Substituir o conteúdo de `Program.cs` com o deste repositório e fazer as mudanças mencionadas no 5º passo**

  <br>

  :rocket: **5. Coisas que pode querer mudar**

  <p align="left">
    
   - O script está desenvolvido para correr de maneira invisível, se quiser ver a página a recarregar tire esta linha do código: `options.AddArgument("--headless");` <br>
  
   - Para conseguir fazer com que este script funcione, encontre esta linha: `driver.Navigate().GoToUrl("https://site.com");` e mude o link para o site que quer recarregar automaticamente <br>
  
   - Este script foi feito para recarregar um site a cada `5 segundos`. Se quiser alterar o intervalo de tempo entre refreshes, mude o valor desta linha: `Thread.Sleep(5000);` para qualquer valor que achar bom para você. <br>
  > [!WARNING]
> Intervalos de tempo muito curtos entre recarregamentos podem causar um problema no seu navegador.

</p>

<br>

  :rocket: **6. Como usar o script**
  ```bash
    dotnet run
  ```

## ❌ Como parar o script
Pressione `Ctrl` + `C` na linha de comandos e o script vai parar automaticamente.

<br>

## 🎯 O que o script faz?

 1. Abre automaticamente o `Google Chrome` em modo invisível (headless).
 2. Vai ao URL que você colocou nesta linha: `driver.Navigate().GoToUrl("https://site.com")`.
 3. Recarrega o site a cada 5 segundos, simulando um comportamento de um usuário real (cookies, JavaScript, etc.).

---

> [!WARNING]
> Este projeto é **APENAS** para fins educativos. Aumentar artificialmente contadores de visualizações pode violar os termos de serviço de certas plataformas. Use com **RESPONSABILIDADE**.
