using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        var options = new ChromeOptions();
        options.AddArgument("--headless"); // Executa o Chrome em modo invisível
        options.AddArgument("--disable-gpu");
        options.AddArgument("--window-size=1920,1080");

        using (IWebDriver driver = new ChromeDriver(options))
        {
            while (true)
            {
                driver.Navigate().GoToUrl("https://site.com");
                Console.WriteLine($"Página carregada às {DateTime.Now}");

                Thread.Sleep(5000); // Espera 5 segundos antes de recarregar
            }
        }
    }
}