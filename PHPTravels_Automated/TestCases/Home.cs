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
   public class Home
   {
       public static bool IsTcAdded = false;

       IWebDriver driver;

       string ProjectUrl = Convert.ToString(ConfigurationSettings.AppSettings.Get("ProjectUrl"));

       
       public void HomePage_Elements_Verification()
       {

           if (!IsTcAdded)
           {
               Report.AddToHtmlReportTCHeader("Home Page Test Cases");
               IsTcAdded = true;
           }

           Report.AddToHtmlReport("TC_HP_001: To verify page elements visible on PHPTravels Home page.", true, false, true);

           Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);
           
           driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);
           
           HomeObjects objHome = new HomeObjects();

           driver = objHome.HomePage_Elements_Verification(driver);

           if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
           {
               Browser.CloseBrowser(driver);
           }

           
       }

       public void HomePage_CcyList_Verification()
       {

           if (!IsTcAdded)
           {
               Report.AddToHtmlReportTCHeader("Home Page Test Cases");
               IsTcAdded = true;
           }

           Report.AddToHtmlReport("TC_HP_002: To verify list of Currency options available on PHPTravels Home page.", true, false, true);

           Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

           driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

           HomeObjects objHome = new HomeObjects();

           driver = objHome.HomePage_CcyList_Verification(driver);

           if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
           {
               Browser.CloseBrowser(driver);
           }


       }

       public void HomePage_HotelSearch_Verification()
       {

           if (!IsTcAdded)
           {
               Report.AddToHtmlReportTCHeader("Home Page Test Cases");
               IsTcAdded = true;
           }

           Report.AddToHtmlReport("TC_HP_003: To verify Search Hotels functionality on PHPTravels Home page.", true, false, true);

           Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

           driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

           HomeObjects objHome = new HomeObjects();

           driver = objHome.HomePage_HotelSearch_Verification(driver);

           if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
           {
               Browser.CloseBrowser(driver);
           }


       }

       public void HomePage_CheapHotelRental_Verification()
       {

           if (!IsTcAdded)
           {
               Report.AddToHtmlReportTCHeader("Home Page Test Cases");
               IsTcAdded = true;
           }

           Report.AddToHtmlReport("TC_HP_004: To verify cheap rental among searched hotels.", true, false, true);

           Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

           driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

           HomeObjects objHome = new HomeObjects();

           driver = objHome.HomePage_CheapHotelRental_Verification(driver);

           if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
           {
               Browser.CloseBrowser(driver);
           }


       }
       }
   }

