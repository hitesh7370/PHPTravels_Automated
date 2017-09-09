using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using Framework.Init;
using OpenQA.Selenium.Firefox;
using Framework.PageObjects;
using System.Data;


namespace TestCases
{
    public class Login
    {
        public static bool IsTcAdded = false;

        IWebDriver driver;

        string ProjectUrl = Convert.ToString(ConfigurationSettings.AppSettings.Get("ProjectUrl"));


        public void Login_Verification_WithBlankDetails()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("Login Page Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TC_LG_001: To verify blank field validation message on PHPTravels Login page.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            LoginObjects objLogin = new LoginObjects();

            driver = objLogin.Login_Verification_WithBlankDetails(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }


        }

        public void Login_Verification_WithValidData()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("Login Page Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TC_LG_002: To verify Login functionality with valid data.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            LoginObjects objLogin = new LoginObjects();

            driver = objLogin.Login_Verification_WithValidData(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }


        }
        
    }
}
