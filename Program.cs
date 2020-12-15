using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;


namespace SeleniumTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            // driver.Navigate().GoToUrl("http:www.google.com");
            driver.Navigate().GoToUrl("https://dotnetfiddle.net/");

            //Maximize the window
            driver.Manage().Window.Maximize();

            try
            {
                IWebElement first_name = driver.FindElement(By.CssSelector("#CodeForm > div.main.docked > div.status-line > div.name-container > input[type=text]"));
                first_name.SendKeys("OGirija");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            //Find the Search text box using xpath
            // IWebElement element = driver.FindElement(By.XPath("//*[@title='Search']"));
            Console.WriteLine("Clicking on Run");
            try
            {
                driver.FindElement(By.Id("run-button")).Click();
                //get the value from output pane
                IWebElement output_pane = driver.FindElement(By.Id("output"));
                string output_val = output_pane.Text;
                Console.WriteLine(output_val);
                if (output_val == "Hello World")
                {
                    Console.WriteLine("After clicking on Run Program is displaying Hello World");
                }
                else
                {
                    Console.WriteLine("After clicking on Run Program is not displaying Hello World");
                }
            }
            catch(NoSuchElementException e) {
                Console.WriteLine(e.Message);
            }

            // Check for the installation
            try
            {

                //IWebElement package_name = driver.FindElement(By.XPath("//*[@id='CodeForm']/div[2]/div[2]/div[5]/div/div/input"));
                // package_name.SendKeys("")
                IWebElement first_name = driver.FindElement(By.Id("fiddle-name"));
     
                string f_name = first_name.GetAttribute("value");
                Regex ex = new Regex("^(A|B|C|D|E)");
                if (ex.IsMatch(f_name))
                {
                    Console.WriteLine("Start with A,B,C,D,E");

                    // start getting value for package
                    IWebElement p_name = driver.FindElement(By.XPath("//*[@id='CodeForm']/div[2]/div[2]/div[5]/div/div/input"));
                    p_name.SendKeys("NUnit");
                    var now = DateTime.Now;
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                    wait.PollingInterval = TimeSpan.FromSeconds(1);
                    wait.Until(wd => (DateTime.Now - now) - TimeSpan.FromSeconds(5) > TimeSpan.Zero);
                    IWebElement package_name = driver.FindElement(By.ClassName("ui-icon-carat-1-e"));
                    package_name.Click();

                    now = DateTime.Now;
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(7));
                    wait.PollingInterval = TimeSpan.FromSeconds(2);
                    wait.Until(wd => (DateTime.Now - now) - TimeSpan.FromSeconds(7) > TimeSpan.Zero);
                    driver.FindElement(By.PartialLinkText("3.12.0")).Click();

                    now = DateTime.Now;
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                    wait.PollingInterval = TimeSpan.FromSeconds(1);
                    wait.Until(wd => (DateTime.Now - now) - TimeSpan.FromSeconds(3) > TimeSpan.Zero);

                    // check option is selected
                    IWebElement temp = driver.FindElement(By.XPath("//*[@id='CodeForm']/div[2]/div[2]/div[5]/div/div/ul/li/div/div"));
                    string selected_package = temp.Text;
                    if (selected_package == "NUnit")
                    {
                        Console.WriteLine("NUnit (3.12.0) selected");
                    }
                    else
                    {
                        Console.WriteLine("NUnit (3.12.0) not selected");
                    }
                }
                else
                {
                    Console.WriteLine("Does Not Start with A,B,C,D,E");
                }

            }
            catch(NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }

            //check the link
            // Check for the installation
            try
            {

                //IWebElement package_name = driver.FindElement(By.XPath("//*[@id='CodeForm']/div[2]/div[2]/div[5]/div/div/input"));
                // package_name.SendKeys("")
                IWebElement first_name = driver.FindElement(By.Id("fiddle-name"));

                string f_name = first_name.GetAttribute("value");
                Regex ex = new Regex("^(F|G|H|I|J|K)");
                if (ex.IsMatch(f_name))
                {
                    Console.WriteLine("Start with F,G,H,I,J,K");

                    var now = DateTime.Now;
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(7));
                    wait.PollingInterval = TimeSpan.FromSeconds(2);
                    wait.Until(wd => (DateTime.Now - now) - TimeSpan.FromSeconds(7) > TimeSpan.Zero);

                    // find share button and click
                    IWebElement share_button = driver.FindElement(By.Id("Share"));
                    share_button.Click();

                    IWebElement share_link = driver.FindElement(By.Id("ShareLink"));
                    string share_text = share_link.Text;
                    share_text = share_link.GetAttribute("value");

                    ex = new Regex("^(https://dotnetfiddle.net/)");
                    if (ex.IsMatch(share_text))
                    {
                        Console.WriteLine("https://dotnetfiddle.net/20Nigb");
                    }
                    else
                    {
                        Console.WriteLine("NOT : https://dotnetfiddle.net/20Nigb");
                    }

                }
                else
                {
                    Console.WriteLine("Does Not Start with A,B,C,D,E");
                }

            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }


            // Back button
            try
            {

                //IWebElement package_name = driver.FindElement(By.XPath("//*[@id='CodeForm']/div[2]/div[2]/div[5]/div/div/input"));
                // package_name.SendKeys("")
                IWebElement first_name = driver.FindElement(By.Id("fiddle-name"));

                string f_name = first_name.GetAttribute("value");
                Regex ex = new Regex("^(L|M|N|O|P)");
                if (ex.IsMatch(f_name))
                {
                    Console.WriteLine("Start with L, M, N, O, P");

                    var now = DateTime.Now;
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(7));
                    wait.PollingInterval = TimeSpan.FromSeconds(2);
                    wait.Until(wd => (DateTime.Now - now) - TimeSpan.FromSeconds(7) > TimeSpan.Zero);

                    // find share button and click
                    IWebElement back_button = driver.FindElement(By.ClassName("btn-sidebar-toggle"));
                    back_button.Click();

                    IWebElement back_link = driver.FindElement(By.XPath("//*[@id='CodeForm']/div[2]/div[2]/div[2]/span/strong/label"));
                    string back_text = back_link.Text;      
                    if (back_text == "")
                    {
                        Console.WriteLine("Option Panel is hidden");
                    }
                    else
                    {
                        Console.WriteLine("Option Panel is not hidden");
                    }
                }
                else
                {
                    Console.WriteLine("Does Not Start with A,B,C,D,E");
                }

            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);
            //Close the browse
            driver.Close();
        }
    }
}
