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


namespace Framework.PageObjects
{
    public class SignUpObjects
    {
        IWebDriver _driver;

        public string strPageName = "SignUp";

        /// <summary>
        /// Blank field validations on SignUp
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public IWebDriver SignUp_Verification_WithBlankDetails(IWebDriver driver)
        {


            _driver = driver;

            SignUp_Verification_WithBlankDetails();

            return _driver;
        }

        public void SignUp_Verification_WithBlankDetails()
        {

            SignupElementsVerification();

            Report.AddToHtmlReport("STEP 3: Click on 'Sign Up' button without entering any details on PHPTravels SignUp page.", false, true);
            
            _driver.FindElement(By.XPath(ElementLocators.SignUp_btn_SignUp)).Click();
            new Common(_driver).pause(2000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_msg_EmailRequired), "'The Email field is required' message text verification on PHPTravels SignUp page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_msg_FirstnameRequired), "'The First name field is required' message text verification on PHPTravels SignUp page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_msg_LastnameRequired), "'The Last Name field is required' message text verification on PHPTravels SignUp page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_msg_PasswordRequired), "'The Password field is required' message text verification on PHPTravels SignUp page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_msg_CPasswordRequired), "'The Password field is required' message text verification on PHPTravels SignUp page.");
            
        }

        /// <summary>
        /// SignUp with valid data
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public IWebDriver SignUp_Verification_WithValidData(IWebDriver driver)
        {


            _driver = driver;

            SignUp_Verification_WithValidData();

            return _driver;
        }

        public void SignUp_Verification_WithValidData()
        {

            SignupElementsVerification();

            Report.AddToHtmlReport("STEP 4: Enter valid details and then click on 'Sign Up' button on PHPTravels SignUp page.", false, true);
            
            string strFirstName = "Jayesh";
            string strLastName = "Shah";
            string strAccName = strFirstName + " " + strLastName;
            string strPhone = "8989898989";
            string strEmail = "jayesh@gmail.com";
            string strPassword = "baps@200";

            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_FirstName)).SendKeys(strFirstName);
            new Common(_driver).pause(2000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_LastName)).SendKeys(strLastName);
            new Common(_driver).pause(2000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_Phone)).SendKeys(strPhone);
            new Common(_driver).pause(2000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_Email)).SendKeys(strEmail);
            new Common(_driver).pause(2000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_Password)).SendKeys(strPassword);
            new Common(_driver).pause(2000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_CPassword)).SendKeys(strPassword);
            new Common(_driver).pause(2000);

            Report.AddToHtmlReport("Data Entered is : ");
            Report.AddToHtmlReport("First Name : " + strFirstName);
            Report.AddToHtmlReport("Last Name : " + strLastName);
            Report.AddToHtmlReport("Phone : " + strPhone);
            Report.AddToHtmlReport("Email : " + strEmail);
            Report.AddToHtmlReport("Password : " + strPassword);
            Report.AddToHtmlReport("Confirm Password : " + strPassword);

            _driver.FindElement(By.XPath(ElementLocators.SignUp_btn_SignUp)).Click();
            new Common(_driver).pause(2000);

            new Common(_driver).FindElement(By.XPath("//h3[text()='Hi, " + strAccName + "']"), "Hi, '" + strAccName + "' text verification on PHPTravels Home page.",true,2000);

            new Common(_driver).FindElement(By.XPath("//a[@class='dropdown-toggle'][contains(text(),'" + strFirstName + "')]"), "'" + strFirstName + "' account name verification on PHPTravels Home page.",true,2000);
            

        }

        
        public void SignupElementsVerification()
        {
            HomeObjects objHome = new HomeObjects();
            objHome.HomePage_Elements_Verification(_driver);

            Report.AddToHtmlReport("STEP 2: Click on 'My Account' link on PHPTravels Home page.", false, true);

            new Common(_driver).FindElement(By.XPath(ElementLocators.Header_ddl_MyAccount)).Click();
            new Common(_driver).pause(2000);


            new Common(_driver).FindElement(By.XPath(ElementLocators.MyAccount_lnk_SignUp), "'SignUp' link under My Account Dropdown on PHPTravels Home page.").Click();
            Report.AddToHtmlReport("STEP 3: Click on 'SignUp' link on PHPTravels Home page.", false, true);
            new Common(_driver).pause(3000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_Header_SignUp), "'SignUp' header text verification on PHPTravels SignUp page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_FirstName), "'First Name' textbox on PHPTravels SignUp page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_LastName), "'Last Name' textbox on PHPTravels SignUp page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_Phone), "'Phone' textbox on PHPTravels SignUp page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_Email), "'Email' textbox on PHPTravels SignUp page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_Password), "'Password' textbox on PHPTravels SignUp page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_txt_CPassword), "'Confirm Password' textbox on PHPTravels SignUp page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.SignUp_btn_SignUp), "'SignUp' button on PHPTravels SignUp page.");

        }

        internal IWebDriver Options_CancelOnInsert(IWebDriver driver)
        {
            throw new NotImplementedException();
        }


    }
}
