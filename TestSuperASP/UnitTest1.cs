//using OpenQA.Selenium;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Support.UI;

//namespace TestSuperASP
//{
//    public class Tests
//    {
//        //[SetUp]
//        //public void Setup()
//        //{
//        //}

//        //[Test]
//        //public void Test1()
//        //{
//        //    Assert.Pass();
//        //}
//        [Test]
//        public void SecondSeleniumTest()
//        {
//            var chromeOptions = new EdgeOptions();
//            IWebDriver driver = new EdgeDriver(@"C:\chromedriver\msedgedriver.exe", chromeOptions);
//            try
//            {
//                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
//                driver.Navigate().GoToUrl("https://localhost:7208/");
//                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

//                //�������� �� ������ ������
//                IWebElement searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/div[1]/form[1]/button[1]")));
//                searchBox.SendKeys(Keys.Enter);

//                //������� �� ��������� ������ � ����
//                searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
//                searchBox.SendKeys("������ ������");
//                searchBox.SendKeys(Keys.Enter);
//                //�������� �� ������ �����
//                searchBox = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'�����')]")));
//                searchBox.Click();
//                //��������� ���� �� �����
//                searchBox = wait.Until(d => d.FindElement(By.XPath("//span[contains(text(),'������ ������ - ����� ��������� (2012)')]")));
//                bool a = searchBox.Text == "������ ������ - ����� ��������� (2012)";
//                Assert.IsTrue(searchBox.Text == "������ ������ - ����� ��������� (2012)");

//                //searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
//                //searchBox.SendKeys("���� �������");
//                //searchBox.SendKeys(Keys.Enter);
//                ////�������� �� ������ �����
//                //searchBox = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'�����')]")));
//                //searchBox.Click();
//                ////��������� ���� �� �����
//                //searchBox = wait.Until(d => d.FindElement(By.XPath("//span[contains(text(),'��������� ��� - ���� ������� (2005)')]")));
//                //a = searchBox.Text == "��������� ��� - ���� ������� (2005)";
//                //Assert.IsTrue(searchBox.Text == "��������� ��� - ���� ������� (2005)");

//                //searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
//                //searchBox.SendKeys("2003");
//                //searchBox.SendKeys(Keys.Enter);
//                ////�������� �� ������ �����
//                //searchBox = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'�����')]")));
//                //searchBox.Click();
//                ////��������� ���� �� �����
//                //searchBox = wait.Until(d => d.FindElement(By.XPath("//span[contains(text(),'������� �������� - ������� ��������� (2003)')]")));
//                //a = searchBox.Text == "������� �������� - ������� ��������� (2003)";
//                //Assert.IsTrue(searchBox.Text == "������� �������� - ������� ��������� (2003)");

//                //searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
//                //searchBox.SendKeys("����������� �� ���� ��������� - ������ �������� (2019)");
//                //searchBox.SendKeys(Keys.Enter);
//                ////�������� �� ������ �����
//                //searchBox = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'�����')]")));
//                //searchBox.Click();
//                ////��������� ���� �� �����
//                //searchBox = wait.Until(d => d.FindElement(By.XPath("//span[contains(text(),'����������� �� ���� ��������� - ������ �������� (2')]")));
//                //a = searchBox.Text == "����������� �� ���� ��������� - ������ �������� (2019)";
//                //Assert.IsTrue(searchBox.Text == "����������� �� ���� ��������� - ������ �������� (2019)");

//            }
//            catch (WebDriverTimeoutException)
//            {
//            }
//            finally
//            {
//                // �������� �����������

//                driver.Quit();
//            }
//        }
//    }
//}

//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Support.UI;
//using Allure.Commons;
//using Allure.Net.Commons;
//using NUnit.Allure.Attributes;

//namespace TestSuperASP
//{
//    public class Tests
//    {
//        [Test]
//        [AllureTest("Second Selenium Test")] // ��������� ��������� Allure ��� ����� �����
//        [AllureSeverity(Allure.Commons.SeverityLevel.Critical)] // ������� ����������� �����
//        [AllureFeature("Search Functionality")] // ����������������, ������� �����������
//        public void SecondSeleniumTest()
//        {
//            var chromeOptions = new EdgeOptions();
//            IWebDriver driver = new EdgeDriver(@"C:\chromedriver\msedgedriver.exe", chromeOptions);
//            try
//            {
//                AllureLifecycle.Instance.WrapInStep(() =>
//                {
//                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
//                    driver.Navigate().GoToUrl("https://localhost:7208/");
//                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

//                    //�������� �� ������ ������
//                    IWebElement searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/div[1]/form[1]/button[1]")));
//                    searchBox.SendKeys(Keys.Enter);

//                    //������� �� ��������� ������ � ����
//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
//                    searchBox.SendKeys("������ ������");
//                    searchBox.SendKeys(Keys.Enter);
//                    //�������� �� ������ �����
//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'�����')]")));
//                    searchBox.Click();
//                    //��������� ���� �� �����
//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//span[contains(text(),'������ ������ - ����� ��������� (2012)')]")));
//                    bool a = searchBox.Text == "������ ������ - ����� ��������� (2012)";
//                    Assert.IsTrue(searchBox.Text == "������ ������ - ����� ��������� (2012)");

//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
//                    searchBox.SendKeys("���� �������");
//                    searchBox.SendKeys(Keys.Enter);
//                    //�������� �� ������ �����
//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'�����')]")));
//                    searchBox.Click();
//                    //��������� ���� �� �����
//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//span[contains(text(),'��������� ��� - ���� ������� (2005)')]")));
//                    a = searchBox.Text == "��������� ��� - ���� ������� (2005)";
//                    Assert.IsTrue(searchBox.Text == "��������� ��� - ���� ������� (2005)");

//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
//                    searchBox.SendKeys("2003");
//                    searchBox.SendKeys(Keys.Enter);
//                    //�������� �� ������ �����
//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'�����')]")));
//                    searchBox.Click();
//                    //��������� ���� �� �����
//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//span[contains(text(),'������� �������� - ������� ��������� (2003)')]")));
//                    a = searchBox.Text == "������� �������� - ������� ��������� (2003)";
//                    Assert.IsTrue(searchBox.Text == "������� �������� - ������� ��������� (2003)");

//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
//                    searchBox.SendKeys("����������� �� ���� ��������� - ������ �������� (2019)");
//                    searchBox.SendKeys(Keys.Enter);
//                    //�������� �� ������ �����
//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'�����')]")));
//                    searchBox.Click();
//                    //��������� ���� �� �����
//                    searchBox = wait.Until(d => d.FindElement(By.XPath("//span[contains(text(),'����������� �� ���� ��������� - ������ �������� (2')]")));
//                    a = searchBox.Text == "����������� �� ���� ��������� - ������ �������� (2019)";
//                    Assert.IsTrue(searchBox.Text == "����������� �� ���� ��������� - ������ �������� (2019)");
//                }, "Performing search and validation steps"); // ��� Allure

//            }
//            catch (WebDriverTimeoutException)
//            {
//            }
//            finally
//            {
//                driver.Quit();
//            }
//        }
//    }
//}


//using OpenQA.Selenium;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Support.UI;

//namespace TestSuperASP
//{
//    public class Tests
//    {
//        [Test]
//        public void SecondSeleniumTest()
//        {
//            var chromeOptions = new EdgeOptions();
//            IWebDriver driver = new EdgeDriver(@"C:\chromedriver\msedgedriver.exe", chromeOptions);
//            try
//            {
//                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
//                driver.Navigate().GoToUrl("https://localhost:7208/");
//                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

//                //�������� �� ������ ������
//                IWebElement searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/div[1]/form[1]/button[1]")));
//                searchBox.SendKeys(Keys.Enter);

//                //������� �� ��������� ������ � ����
//                searchBox = wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
//                searchBox.SendKeys("������ ������");
//                searchBox.SendKeys(Keys.Enter);
//                //�������� �� ������ �����
//                searchBox = wait.Until(d => d.FindElement(By.XPath("//button[contains(text(),'�����')]")));
//                searchBox.Click();
//                //��������� ���� �� �����
//                searchBox = wait.Until(d => d.FindElement(By.XPath("//span[contains(text(),'������ ������ - ����� ��������� (2012)')]")));
//                bool a = searchBox.Text == "������ ������ - ����� ��������� (2012)";
//                Assert.IsTrue(searchBox.Text == "������ ������ - ����� ��������� (2012)"); 

//            }
//            catch (WebDriverTimeoutException)
//            {
//            }
//            finally
//            {
//                // �������� �����������
//                driver.Quit();
//            }
//        }
//    }
//}

using Allure.Net.Commons;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestSuperASP
{
    public class SearchPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public SearchPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        [AllureStep("Go to page: {0}")]
        public void GoToPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        [AllureStep("Click the Buy button")]
        public void ClickBuyButton()
        {
            IWebElement buyButton = _wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/div[1]/form[1]/button[1]")));
            buyButton.SendKeys(Keys.Enter);
        }

        [AllureStep("Search for: {0}")]
        public void Search(string searchText)
        {
            IWebElement searchBox = _wait.Until(d => d.FindElement(By.XPath("//body/div[1]/main[1]/form[1]/input[1]")));
            searchBox.SendKeys(searchText);
            searchBox.SendKeys(Keys.Enter);
        }

        [AllureStep("Verify search result: {0}")]
        public bool IsSearchResultDisplayed(string expectedResult)
        {
            IWebElement searchResult = _wait.Until(d => d.FindElement(By.XPath($"//span[contains(text(), '{expectedResult}')]")));
            return searchResult.Text == expectedResult;
        }
    }

    public class Tests
    {
        [Test]
        [AllureSuite("Search Tests")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Your Name")]
        [AllureTms("Verify Search Functionality")]
        public void SecondSeleniumTest()
        {
            var chromeOptions = new EdgeOptions();
            IWebDriver driver = new EdgeDriver(@"C:\chromedriver\msedgedriver.exe");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            SearchPage searchPage = new SearchPage(driver);
            searchPage.GoToPage("https://localhost:7208/");
            searchPage.ClickBuyButton();
            searchPage.Search("2001");

            Assert.IsTrue(searchPage.IsSearchResultDisplayed("��� - ���� (2001)"));

            driver.Quit();
        }
    }
}
