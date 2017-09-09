using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Init;
using NUnit.Framework;
using TestCases;




namespace TestCases
{
    [TestFixture]
    //Test Line to see Diff in Git
    public class TestSuites
    {

        static bool IsTestFinished;
        static Int32 intLoginPassCnt = 0;
        static Int32 intLoginFailCnt = 0;
        static Int32 intLoginWarningCnt = 0;

        public TestSuites()
        {
            Report.sbHtml = null;
            Report.sbSummaryHtml = null;
            IsTestFinished = true;
            intLoginPassCnt = 0;
            intLoginFailCnt = 0;

            Report.TCcnt = 1;
            Report.IsPassed = 0;


            Home.IsTcAdded = false;
            Report.IsHeaderUpdated = false;
            Report.sbTcHtml = null;
            Report.sbFeatureHtml = null;

        }

        #region "PHPTravels- Home Page"

        [Test]
        public void HomePage_Elements_Verification()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;
                Home objHome = new Home();
                objHome.HomePage_Elements_Verification();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Home.IsTcAdded = true;

            }

        }

        [Test]
        public void HomePage_CcyList_Verification()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;
                Home objHome = new Home();
                objHome.HomePage_CcyList_Verification();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Home.IsTcAdded = true;

            }

        }

        [Test]
        public void HomePage_HotelSearch_Verification()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;
                Home objHome = new Home();
                objHome.HomePage_HotelSearch_Verification();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Home.IsTcAdded = true;

            }

        }

        [Test]
        public void HomePage_CheapHotelRental_Verification()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;
                Home objHome = new Home();
                objHome.HomePage_CheapHotelRental_Verification();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Home.IsTcAdded = true;

            }

        }
        
       #endregion

        #region "PHPTravels- Login Page"

        [Test]
        public void Login_Verification_WithBlankDetails()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;
                Login objLogin = new Login();
                objLogin.Login_Verification_WithBlankDetails();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Home.IsTcAdded = true;

            }

        }

        [Test]
        public void Login_Verification_WithValidData()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;
                Login objLogin = new Login();
                objLogin.Login_Verification_WithValidData();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Home.IsTcAdded = true;

            }

        }
                
        #endregion

        #region "PHPTravels- Sign Up Page"

        [Test]
        public void SignUp_Verification_WithBlankDetails()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;
                SignUp objSignUp = new SignUp();
                objSignUp.SignUp_Verification_WithBlankDetails();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Home.IsTcAdded = true;

            }

        }

        [Test]
        public void SignUp_Verification_WithValidData()
        {
            try
            {
                waitForPrevTestToFinish();
                IsTestFinished = false;
                SignUp objSignUp = new SignUp();
                objSignUp.SignUp_Verification_WithValidData();
            }
            finally
            {
                Report.AddToHtmlReportFeatureFinish();
                Report.GenerateHtmlReport();
                IsTestFinished = true;
                if (Report.IsFtrPassed == 1) intLoginPassCnt++;
                else if (Report.IsFtrPassed == 2) intLoginFailCnt++;
                else if (Report.IsFtrPassed == 3) intLoginWarningCnt++;
                Home.IsTcAdded = true;

            }

        }


        #endregion

        
         [TestFixtureTearDown]
        public void zzzGenerateSummaryReport()
        {
            try
            {
                Report.AddToHtmlSummaryReport("TFC Test Cases", intLoginPassCnt, intLoginFailCnt, intLoginWarningCnt);
                Report.AddToHtmlSummaryReportTotal();
                Report.GenerateHtmlSummaryReport();
            }
            finally
            {
                Report._intPassedCnt = 0;
                Report._intFailedCnt = 0;
                Report._inTotalCnt = 0;
            }
        }

        private void waitForPrevTestToFinish()
        {
            while (true)
            {
                if (!IsTestFinished) Common.pauseStatic(2000);
                else break;
            }
        }
    }




}
