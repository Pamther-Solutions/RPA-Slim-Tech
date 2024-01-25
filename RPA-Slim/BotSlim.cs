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

 
        public void FindElement(string element, string events)
        {
            driver.FindElement(By.XPath(element)).SendKeys(events);
        }
        

        public BotSlim()
        {
            driver = new ChromeDriver();
        }


        public void Bot()
        {
            driver.Navigate().GoToUrl("https://slim-tech.netlify.app/");

            FindElement("//*[@id=\"contato\"]/div[1]/form/div/div[1]/input[1]", "user");
            FindElement("//*[@id=\"contato\"]/div[1]/form/div/div[1]/input[2]", "exemple@gmail.com");   
            FindElement("//*[@id=\"contato\"]/div[1]/form/div/div[2]/input[1]","11 99999-9999");
            FindElement("//*[@id=\"contato\"]/div[1]/form/div/div[2]/input[2]", "example subject");
            FindElement("//*[@id=\"contato\"]/div[1]/form/div/textarea", "example message");

        }

        
    }
}
