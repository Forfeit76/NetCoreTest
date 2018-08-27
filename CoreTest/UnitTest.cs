using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using System.IO;
using System.Reflection;
using System.Threading;

namespace CoreTest
{
    public class UnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void OpenWebDriver()
        {
            
        }
        
        [Test]
        public void TestMethodChrome()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Url = "https://ya.ru/";
            var search = driver.FindElement(By.Id("text"));
            search.Click();
            search.SendKeys("Gomel");
            search = driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]/td/form/div[2]/button"));
            search.Click();
            Thread.Sleep(2000);
            Assert.That(driver.Title.ToString(), Does.Contain("Gomel"), "Title not contain Gomel");
        }

        [Test]
        public void TestMethodFierfox()
        {
            driver = new FirefoxDriver();
            driver.Url = "https://ya.ru/";
            var search = driver.FindElement(By.Id("text"));
            search.Click();
            search.SendKeys("Gomel");
            search = driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]/td/form/div[2]/button"));
            search.Click();
            Thread.Sleep(2000);
            Assert.That(driver.Title.ToString(), Does.Contain("Gomel"), "Title not contain Gomel");
        }

        [Test]
        public void TestMethodEdge()
        {
            driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Url = "https://ya.ru/";
            var search = driver.FindElement(By.Id("text"));
            search.Click();
            search.SendKeys("Gomel");
            search = driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]/td/form/div[2]/button"));
            search.Click();
            Thread.Sleep(2000);
            Assert.That(driver.Title.ToString(), Does.Contain("Gomel"), "Title not contain Gomel");
        }

        [Test]
        public void TestMethodInternetExplorer()
        {
            driver = new InternetExplorerDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Url = "https://ya.ru/";
            var search = driver.FindElement(By.Id("text"));
            search.Click();
            search.SendKeys("Gomel");
            search = driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]/td/form/div[2]/button"));
            search.Click();
            Thread.Sleep(2000);
            Assert.That(driver.Title.ToString(), Does.Contain("Gomel"), "Title not contain Gomel");
        }

        [TearDown]
        public void CloseWebDriver()
        {
            driver.Quit();
        }
    }
}
