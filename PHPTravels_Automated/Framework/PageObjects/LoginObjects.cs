using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Init;
using OpenQA.Selenium;
using System.Configuration;
using NUnit.Framework;
using System.Collections;
using OpenQA.Selenium.Interactions;
using Framework.PageObjects;


namespace Framework.PageObjects
{
    public class LoginObjects
    {
        IWebDriver _driver;

        public string strPageName = "Login";

        /// <summary>
        /// Blank field validations on Login
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public IWebDriver Login_Verification_WithBlankDetails(IWebDriver driver)
        {


            _driver = driver;

            Login_Verification_WithBlankDetails();

            return _driver;
        }

        public void Login_Verification_WithBlankDetails()
        {
            LoginElementsVerification();

            Report.AddToHtmlReport("STEP 4: Click on 'Login' button without entering any details on PHPTravels Login page.", false, true);

            new Common(_driver).FindElement(By.XPath(ElementLocators.Login_btn_Login)).Click();
            new Common(_driver).pause(2000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.Login_msg_EmailPwdRequired), "'Invalid Email or Password' message text verification on PHPTravels Login page."); 
                     

        }


        /// <summary>
        /// Login with valid data
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public IWebDriver Login_Verification_WithValidData(IWebDriver driver)
        {


            _driver = driver;

            Login_Verification_WithValidData();

            return _driver;
        }

        public void Login_Verification_WithValidData()
        {
            LoginElementsVerification();
            string strEmail = "user@phptravels.com";
            string strPassword = "demouser";

            new Common(_driver).FindElement(By.XPath(ElementLocators.Login_txt_Email)).SendKeys(strEmail);
            new Common(_driver).pause(2000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.Login_txt_Password)).SendKeys(strPassword);
            new Common(_driver).pause(2000);

            Report.AddToHtmlReport("Data Entered is: ");
            Report.AddToHtmlReport("Email : " + strEmail);
            Report.AddToHtmlReport("Password : " + strPassword);

            Report.AddToHtmlReport("STEP 4: Click on 'Login' button after entering valid details on PHPTravels Login page.", false, true);

            new Common(_driver).FindElement(By.XPath(ElementLocators.Login_btn_Login)).Click();
            new Common(_driver).pause(3000);

            new Common(_driver).FindElement(By.XPath("//h3[text()='Hi, John Smith']"),"'Hi, John Smith' welcome text verification on PHPTravels Home page.");

            new Common(_driver).FindElement(By.XPath("//a[@class='dropdown-toggle'][contains(text(),'John')]"), "'John' account name text verification on PHPTravels Home page.",true,2000);


        }

        public void LoginElementsVerification()
        {
            HomeObjects objHome = new HomeObjects();
            objHome.HomePage_Elements_Verification(_driver);
            
            Report.AddToHtmlReport("STEP 2: Click on 'My Account' link on PHPTravels Home page.", false, true);

            new Common(_driver).FindElement(By.XPath(ElementLocators.Header_ddl_MyAccount)).Click();
            new Common(_driver).pause(2000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.MyAccount_lnk_Login), "'Login' link in My Account Dropdown on PHPTravels Home page.").Click();
            
            Report.AddToHtmlReport("STEP 3: Click on 'Login' link in My Account Dropdown on PHPTravels Home page.", false, true);

            new Common(_driver).pause(3000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.Login_txt_Email), "'Email' textbox on PHPTravels Login page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Login_txt_Password), "'Password' textbox on PHPTravels Login page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Login_btn_Login), "'Login' button on PHPTravels Login page.");

        }

        internal IWebDriver Options_CancelOnInsert(IWebDriver driver)
        {
            throw new NotImplementedException();
        }


    }
}
