using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA_Slim
{
    public class BotSlim
    {
        IWebDriver driver;



        public BotSlim()
        {
            driver = new ChromeDriver();
        }


        public void Bot()
        {
            driver.Navigate().GoToUrl("https://slim-tech.netlify.app/");

            driver.FindElement(By.XPath("//*[@id=\"contato\"]/div[1]/form/div/div[1]/input[1]")).SendKeys("oi");
            driver.FindElement(By.XPath("//*[@id=\"contato\"]/div[1]/form/div/div[1]/input[2]")).SendKeys("oi");
            driver.FindElement(By.XPath("//*[@id=\"contato\"]/div[1]/form/div/div[2]/input[1]")).SendKeys("oi");
            driver.FindElement(By.XPath("//*[@id=\"contato\"]/div[1]/form/div/div[2]/input[2]")).SendKeys("oi");
            driver.FindElement(By.XPath("//*[@id=\"contato\"]/div[1]/form/div/textarea")).SendKeys("oi");

        }

        
    }
}
