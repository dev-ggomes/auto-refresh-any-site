<!-- |||||||||||||||||||| EN - PT |||||||||||||||||||| -->
<p align='center'>
  <a href="https://github.com/dev-ggomes/auto-refresh-any-site/blob/main/README.md">🇺🇸 English</a> | 
  <a href="https://github.com/dev-ggomes/auto-refresh-any-site/blob/main/README-pt-pt.md">ᴘᴛ Português</a> | 
  <a href="https://github.com/dev-ggomes/auto-refresh-any-site/blob/main/README-pt-br.md">🇧🇷 Português</a>
</p>

<h1 align="center">
  🚀 Auto refresh any site
</h1>

<p align='center'>
  :octocat: Follow the step by step guide to run this code the proper way.
</p>

<p align="center">
  ⭐ If you liked this project, please give it a star
</p>

<!-- |||||||||||||||||||| SPONSORS & STARS |||||||||||||||||||| -->
<p align='center'>
  <a href="https://github.com/sponsors/dev-ggomes"><img alt="Sponsor" src="https://img.shields.io/badge/sponsor-30363D?style=for-the-badge&logo=GitHub-Sponsors&logoColor=#white" /></a>
  &nbsp;
  <a href="#"><img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/dev-ggomes/auto-refresh-any-site?style=for-the-badge" /></a>
</p>

<br>

## ✔️ Requirements 

<p>
  Make sure you have the following required things: <br>

  1. `.NET SDK` You can download it [here](https://dotnet.microsoft.com/download)
  2. Google Chrome (to run the program)
  3. Operating System: `Windows`, `Linux` or `macOS`
  4. Internet connection

> [!NOTE]
> Typically the recommended SDK version is `.NET 7` or `.NET 8`

<br>

</p>

## ⚙️ Setup and Run

  :rocket: **1. Clone this repository** <br>
  ```bash
    git clone https://github.com/dev-ggomes/auto-refresh-any-site.git
    cd auto-refresh-any-site
  ```

  <br>

  :rocket: **2. Create and configure the console project (if not already created)**
  ```bash
    dotnet new console -n GitHubProfileRefresh
    cd GitHubProfileRefresh
  ```

  <br>

  :rocket: **3. Add Selenium dependencies**
  ```bash
    dotnet add package Selenium.WebDriver
    dotnet add package Selenium.WebDriver.ChromeDriver
  ```

  <br>

  :rocket: **4. Replace the content of `Program.cs` with the one in this repository and make the changes mentioned on the 5<sup>th</sup> step**

  <br>

  :rocket: **5. Things you may wanna change**

  <p align="left">
    
   - If you actually wanna see the browser window refreshing, remove this line: `options.AddArgument("--headless");` <br>
  
   - If you want to auto refresh a site, find this line: `driver.Navigate().GoToUrl("https://site.com");` and change the link to the site you want to auto refresh <br>
  
   - This script were made to auto refresh any site every `5 seconds`. If you want to change this period of time between refreshes, change the value of this line: `Thread.Sleep(5000);` to every value you think is the better for you. <br>
  > [!WARNING]
> Too short periods of time between refreshes may cause a crash in your browser.

</p>

<br>

  :rocket: **6. Run the project**
  ```bash
    dotnet run
  ```

## ❌ How to stop it
Press `Ctrl` + `C` in the terminal to stop the script.

<br>

## 🎯 What the script does

 1. Automatically launches `Google Chrome` in headless (invisible) mode.
 2. Visits the url that is saved in the variable `driver.Navigate().GoToUrl("https://site.com")`.
 3. Refreshes the page every 5 seconds, simulating real user behavior (cookies, JavaScript, etc.).

---

> [!WARNING]
> This project is for educational purposes only. Artifically inflating view counters may violate the terms os service of certain platforms. Use responsibly.
