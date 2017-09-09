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
    public class SignUp
    {
        public static bool IsTcAdded = false;

        IWebDriver driver;

        string ProjectUrl = Convert.ToString(ConfigurationSettings.AppSettings.Get("ProjectUrl"));


        public void SignUp_Verification_WithBlankDetails()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("SignUp Page Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TC_SU_001: To verify blank field validation message on PHPTravels SignUp page.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            SignUpObjects objSignUp = new SignUpObjects();

            driver = objSignUp.SignUp_Verification_WithBlankDetails(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }


        }

        public void SignUp_Verification_WithValidData()
        {

            if (!IsTcAdded)
            {
                Report.AddToHtmlReportTCHeader("SignUp Page Test Cases");
                IsTcAdded = true;
            }

            Report.AddToHtmlReport("TC_SU_002: To verify SignUp functionality with valid details.", true, false, true);

            Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

            driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

            SignUpObjects objSignUp = new SignUpObjects();

            driver = objSignUp.SignUp_Verification_WithValidData(driver);

            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
            {
                Browser.CloseBrowser(driver);
            }


        }
        
    }
}
