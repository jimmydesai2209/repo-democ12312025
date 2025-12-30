using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V134.Audits;
using OpenQA.Selenium.Support.UI;

namespace DotNetSelenium
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create instance
            IWebDriver driver = new ChromeDriver();

            // Navigate to website
            driver.Navigate().GoToUrl("https://www.google.com/");

            //Maximumize window
            driver.Manage().Window.Maximize();

            //Find element 
            IWebElement webElement = driver.FindElement(By.Name("q"));

            //Type in Element
            webElement.SendKeys("Selenium");

            //Click on the element
            webElement.SendKeys(Keys.Return);
        }

        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            IWebElement logininstance = driver.FindElement(By.LinkText("Login"));

            logininstance.Click();

            IWebElement adminInstance = driver.FindElement(By.Name("UserName"));

            adminInstance.SendKeys("admin");

            IWebElement passwordInstance = driver.FindElement(By.Name("Password"));

            passwordInstance.SendKeys("password");

            //AccessedThroughPropertyAttribute CSS
            // IWebElement login2Instance = driver.FindElement(By.ClassName("btn"));
            // login2Instance.Click();

            //Access through CSS Selector
            IWebElement login2Instance = driver.FindElement(By.CssSelector(".btn"));
            login2Instance.Click();

            //pending with shortcut writting methods


        }







        [TestMethod]
        public void TestMethod3()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

           // driver.FindElement(By.LinkText("Login")).Click();

            //More simpler way of writting for click operation

            SeleniumCustomeMethodClick.Click(driver, By.LinkText("Login"));




            driver.FindElement(By.Name("UserName")).SendKeys("admin");



            driver.FindElement(By.Name("Password")).SendKeys("password");



            driver.FindElement(By.CssSelector(".btn")).Click();

        }



        [TestMethod]

        //For dropdown menus to be tested out
        public void TestMethod4()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.automationtesting.co.uk/dropdown.html");



            SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("cars")));

            selectElement.SelectByValue("suzuki");

        }

        [TestMethod]

        //For dropdown menus to be tested out with Multiselect option
        public void TestMethod5()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/select-menu");



            SelectElement multiselect = new SelectElement(driver.FindElement(By.Id("cars")));

            multiselect.SelectByValue("volvo");
            multiselect.SelectByValue("saab");
            multiselect.SelectByValue("opel");

            IList<IWebElement> selectedOptions = multiselect.AllSelectedOptions;

            foreach (IWebElement selectedOption in selectedOptions)
            {
                Console.WriteLine(selectedOption.Text);
                Console.WriteLine("Hello Changes been done here to check");
                Console.WriteLine("Hello Changes been done here to check");
                Console.WriteLine("Hello Changes been done here to check");



            }


        }
    }
}
    
