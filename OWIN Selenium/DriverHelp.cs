using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace OWIN_Selenium;

public class DriverHelp {
    public IWebDriver WebDriver;

    public DriverHelp() {
        var dm = new DriverManager();
        dm.SetUpDriver(new EdgeConfig());
        WebDriver = new EdgeDriver();
    }

    public void navigate(string url) {
        WebDriver.Navigate().GoToUrl(url);
    }

    public IWebElement findElement(string method, string locator) {
        IWebElement output;
        try {
            switch (method) {
                case "xpath":
                    output = WebDriver.FindElement(By.XPath(locator));
                    break;
                case "css":
                    output = WebDriver.FindElement(By.CssSelector(locator));
                    break;
                case "tag":
                    output = WebDriver.FindElement(By.TagName(locator));
                    break;
                default:
                    output = null;
                    break;
            }
        }
        catch (NotFoundException ex) {
            Console.WriteLine(ex.Message);
            output = null;
        }

        return output;
    }

    public string getValue(IWebElement element) {
        var JE = (IJavaScriptExecutor) WebDriver;
        return JE.ExecuteScript("arguments[0].value", element).ToString();
    }
}