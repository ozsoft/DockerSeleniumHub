using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System.Web;
using System;
using System.Threading;

namespace DockerSeleniumHub
{
    [Parallelizable(ParallelScope.All)]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChromeDockerSelenium()
        {

            var chromeOptions = new ChromeOptions();

            var driver = new RemoteWebDriver(new Uri("http://localhost:4545/wd/hub"), chromeOptions);
            driver.Navigate().GoToUrl("http://www.google.com");

            driver.FindElement(By.Name("q")).SendKeys("ozgur");


            Thread.Sleep(5000);
            driver.Quit();

        }

        [Test]
        public void FirefoxDockerSelenium()
        {

            var firefox = new FirefoxOptions();

            var driver = new RemoteWebDriver(new Uri("http://localhost:4545/wd/hub"), firefox);
            driver.Navigate().GoToUrl("http://www.google.com");

            driver.FindElement(By.Name("q")).SendKeys("ozgur");


            Thread.Sleep(5000);
            driver.Quit();

        }
    }
}