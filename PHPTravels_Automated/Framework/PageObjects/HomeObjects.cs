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
    public class HomeObjects
    {
        IWebDriver _driver;

        public string strPageName = "Home";
                
        /// <summary>
        /// Home page Elements verification
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public IWebDriver HomePage_Elements_Verification(IWebDriver driver)
        {


            _driver = driver;

            HomePage_Elements_Verification();

            return _driver;
        }

        public void HomePage_Elements_Verification()
        {

            new Common(_driver).FindElement(By.XPath(ElementLocators.Header_logo_PHPTravels), "'PHPTravels' logo on PHPTravels Home page.",true,5000);
            new Common(_driver).FindElement(By.XPath(ElementLocators.HeaderMenu_lnk_Flights), "'Flights' menu on PHPTravels Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.HeaderMenu_lnk_Tours), "'Tours' menu on PHPTravels Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.HeaderMenu_lnk_Cars), "'Cars' menu on PHPTravels Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.HeaderMenu_lnk_Offers), "'Offers' menu on PHPTravels Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.HeaderMenu_lnk_Blog), "'Blog' menu on PHPTravels Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.HeaderMenu_lnk_Hotels), "'Hotels' menu on PHPTravels Home page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Header_ddl_Currency), "'Currency' dropdown on PHPTravels Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Header_ddl_Language), "'Language' dropdown on PHPTravels Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Header_ddl_MyAccount), "'My Account' dropdown on PHPTravels Home page.");
        
        }

        /// <summary>
        /// Ccy list options verification
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public IWebDriver HomePage_CcyList_Verification(IWebDriver driver)
        {


            _driver = driver;

            HomePage_CcyList_Verification();

            return _driver;
        }

        public void HomePage_CcyList_Verification()
        {

            HomePage_Elements_Verification();

            Report.AddToHtmlReport("STEP 2: Click on 'Currency' dropdown on PHPTravels Home page.", false, true);

            new Common(_driver).FindElement(By.XPath(ElementLocators.Header_ddl_Currency)).Click();
            new Common(_driver).pause(2000);

            IList<IWebElement> Currency_DDL_options = _driver.FindElements(By.XPath("//select[@id='currency']/option"));
            string strCcyOption = "";
            Report.AddToHtmlReport("Available Currency Options are: ");

            for (int i = 1; i <= Currency_DDL_options.Count; i++)
            {
                strCcyOption = _driver.FindElement(By.XPath("//select[@id='currency']/option[" + i + "]")).Text;
                new Common(_driver).pause(2000);
                Report.AddToHtmlReport("'"+ strCcyOption +"'");
            }
            

        }

        /// <summary>
        /// Search Hotels Functionality verification
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public IWebDriver HomePage_HotelSearch_Verification(IWebDriver driver)
        {


            _driver = driver;

            HomePage_HotelSearch_Verification();

            return _driver;
        }

        public void HomePage_HotelSearch_Verification()
        {

            HomePage_Elements_Verification();

            string strCityName = "Delhi City, India";

            IWebElement Home_txt_SearchHotel =  new Common(_driver).FindElement(By.XPath(ElementLocators.Home_txt_SearchHotel), "'Search by City and Hotel' textbox on PHPTravels Home page.");
            
            IWebElement Home_btn_Search=  new Common(_driver).FindElement(By.XPath(ElementLocators.Home_btn_Search), "'Search' button on PHPTravels Home page");
            
            Report.AddToHtmlReport("STEP 2: Enter any City name and click on 'Search' button on PHPTravels Home page.", false, true);

            Home_txt_SearchHotel.SendKeys(strCityName);
            new Common(_driver).pause(2000);

            Home_btn_Search.Click();
            new Common(_driver).pause(2000);
            
            Report.AddToHtmlReport("Data Entered is : " + strCityName);

            new Common(_driver).FindElement(By.XPath("//div[@class='row listing-search']/div[contains(@class,'localarea')]/span[text()='" + strCityName + "']"),"'"+ strCityName +"' search summary label text verification on Search Summary page.");
            
            IList<IWebElement> Search_HotelsList = _driver.FindElements(By.XPath("//table//tr//div[contains(@class,'rtl_title_home')]/h4/a/b"));
            int nHotelsCount = Search_HotelsList.Count;

            Report.AddToHtmlReport("Total found Hotels for searched city are : " + nHotelsCount);
            Report.AddToHtmlReport("Name of the Hotels are : ");
            string strHotelName;

            for (int i = 1; i <= nHotelsCount; i++)
            {
                if (i > 3 | i > 7)
                {
                    IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
                    js.ExecuteScript("window.scrollBy(0,700);");
                    new Common(_driver).pause(2000);
                }                
                strHotelName = new Common(_driver).FindElement(By.XPath("//table//tr[" + i + "]//div[contains(@class,'rtl_title_home')]/h4/a/b")).Text;
                Report.AddToHtmlReport(strHotelName);

            }


        }


        /// <summary>
        /// Cheap Hotel Rental verification
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public IWebDriver HomePage_CheapHotelRental_Verification(IWebDriver driver)
        {


            _driver = driver;

            HomePage_CheapHotelRental_Verification();

            return _driver;
        }

        public void HomePage_CheapHotelRental_Verification()
        {

            HomePage_HotelSearch_Verification();

            Report.AddToHtmlReport("STEP 3: Search for cheap hotel rental on Search Summary page.", false, true);

            IList<IWebElement> Search_HotelRentals = _driver.FindElements(By.XPath("//table//tr//div[contains(@class,'text-success')]/b"));
            int nRentalcount = Search_HotelRentals.Count;
            
            string strHotelRent;
            string[] strRentalArr = new string[nRentalcount];
            Report.AddToHtmlReport("Rentals of searched hotels are : ");
            for (int i = 1; i <= nRentalcount; i++)
            {
                if (i > 3 | i > 7)
                {
                    IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
                    js.ExecuteScript("window.scrollBy(0,700);");
                    new Common(_driver).pause(2000);
                }
                strHotelRent = new Common(_driver).FindElement(By.XPath("//table//tr[" + i + "]//div[contains(@class,'text-success')]/b")).Text;
                strRentalArr[i - 1] = strHotelRent.Remove(0, 4);
                Report.AddToHtmlReport(strRentalArr[i - 1]);
            }

            double[] DoubleRentalArr = new double[nRentalcount];
            DoubleRentalArr = Array.ConvertAll(strRentalArr, p => Convert.ToDouble(p));

            Array.Sort(DoubleRentalArr);
            Report.AddToHtmlReport("The most cheap hotel rental is : " + DoubleRentalArr[0]);


        }


        internal IWebDriver Options_CancelOnInsert(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }
}
