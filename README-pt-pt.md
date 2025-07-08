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
  :octocat: Segue o passo a passo para usares este código da maneira certa.
</p>

<p align="center">
  ⭐ Se gostares deste repositório, considera contribuir com uma estrela
</p>

<!-- |||||||||||||||||||| SPONSORS & STARS |||||||||||||||||||| -->
<p align='center'>
  <a href="https://github.com/sponsors/dev-ggomes"><img alt="Sponsor" src="https://img.shields.io/badge/sponsor-30363D?style=social&logo=GitHub-Sponsors&logoColor=#white" /></a>
  &nbsp;
  <a href="#"><img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/dev-ggomes/auto-refresh-any-site?style=social" /></a>
</p>

<br>

## ✔️ Requisitos 

<p>
  Certifica-te que tens estes requisitos: <br>

  1. `.NET SDK` Podes fazer o download [aqui](https://dotnet.microsoft.com/download)
  2. Google Chrome (para correr o programa)
  3. Sistema Operativo: `Windows`, `Linux` ou `macOS`
  4. Conexão à internet

> [!NOTE]
> Normalmente a versão do SDK recomendada é `.NET 7` ou `.NET 8`

<br>

</p>

## ⚙️ Preparar e usar

  :rocket: **1. Clonar o repositório** <br>
  ```bash
    git clone https://github.com/dev-ggomes/auto-refresh-any-site.git
    cd auto-refresh-any-site
  ```

  <br>

  :rocket: **2. Criar e configurar o projeto na linha de comandos (se ainda não criaste)**
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

  :rocket: **5. Coisas que podes querer mudar**

  <p align="left">
    
   - O script está desenvolvido para correr de maneira invisível, se quiseres ver a página a recarregar tira esta linha do código: `options.AddArgument("--headless");` <br>
  
   - Para conseguires fazer com que este script funcione, encontra esta linha: `driver.Navigate().GoToUrl("https://site.com");` e muda o link para o site que queres recarregar automaticamente <br>
  
   - Este script foi feito para recarregar um site a cada `5 segundos`. Se quiseres alterar o intervalo de tempo entre refreshes, muda o valor desta linha: `Thread.Sleep(5000);` para qualquer valor que achares melhor para ti. <br>
  > [!WARNING]
> Períodos de tempo muito curtos entre recarregamentos podem causar um problema no teu browser.

</p>

<br>

  :rocket: **6. Como usar o script**
  ```bash
    dotnet run
  ```

## ❌ Como parar o script
Pressiona `Ctrl` + `C` no terminal e o script vai parar automaticamente.

<br>

## 🎯 O que o script faz?

 1. Abre automaticamente o `Google Chrome` em modo invisível (headless).
 2. Vai ao URL que colocaste nesta linha: `driver.Navigate().GoToUrl("https://site.com")`.
 3. Recarrega o site a cada 5 segundos, simulando um comportamento de um utilizador real (cookies, JavaScript, etc.).

---

> [!WARNING]
> Este projeto é **APENAS** para fins educacionais. Aumentar artificialmente contadores de visualizações pode violar os termos de serviço de certas plataformas. Usa com **RESPONSABILIDADE**.
