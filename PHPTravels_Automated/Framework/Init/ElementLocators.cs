using System;

namespace Framework.Init
{
    public static class ElementLocators
    {

        #region //########### HomePage Header Elements ###########//

        public static String Header_logo_PHPTravels = "//img[@class='logo' and @alt='PHPTRAVELS']";
        public static String HeaderMenu_lnk_Flights = "//ul[contains(@class,'navbar-left')]/li[starts-with(@class,'go-right')]/a[contains(.,'Flights')]";
        public static String HeaderMenu_lnk_Tours ="//ul[contains(@class,'navbar-left')]/li[starts-with(@class,'go-right')]/a[contains(.,'Tours')]";
        public static String HeaderMenu_lnk_Cars = "//ul[contains(@class,'navbar-left')]/li[starts-with(@class,'go-right')]/a[contains(.,'Cars')]";
        public static String HeaderMenu_lnk_Offers = "//ul[contains(@class,'navbar-left')]/li[starts-with(@class,'go-right')]/a[contains(.,'Offers')]";
        public static String HeaderMenu_lnk_Blog = "//ul[contains(@class,'navbar-left')]/li[starts-with(@class,'go-right')]/a[contains(.,'Blog')]";
        public static String HeaderMenu_lnk_Hotels = "//ul[contains(@class,'navbar-left')]/li[starts-with(@class,'go-right')]/a[contains(.,'Hotels')]";

        public static String Header_ddl_Currency = "//select[@id='currency']";
        public static String Header_ddl_Language = "//ul[contains(@class,'navbar-right')]/li/a[contains(.,'English')]";
        public static String Header_ddl_MyAccount = "//ul[contains(@class,'navbar-right')]/li/a[contains(.,'My Account')]";

        public static String Home_txt_SearchHotel="//input[@id='citiesInput'][@name='city']";
        public static String Home_btn_Search ="//div[@id='EXPEDIA']//button[@type='submit'][text()='Search']";

        #endregion

        #region //########### Login Elements ###########//


        public static String MyAccount_lnk_Login = "//a[contains(text(),'Login')]";
        public static String Login_txt_Email = "//input[@type='email']";
        public static String Login_txt_Password ="//input[@type='password']";
        public static String Login_btn_Login ="//button[@type='submit'][contains(@class,'loginbtn')]";
        public static String Login_msg_EmailPwdRequired = "//div[@class='resultlogin']/div[@class='alert alert-danger'][contains(.,'Invalid Email or Password')]";

        #endregion
        
        
        #region //########### Sign UP Elements ###########//

        public static String MyAccount_lnk_SignUp = "//a[contains(text(),'Sign Up')]";
        public static String SignUp_Header_SignUp = "//div[@class='panel-heading'][contains(text(),'Sign Up')]";
        public static String SignUp_txt_FirstName = "//input[@name='firstname']";
        public static String SignUp_txt_LastName = "//input[@name='lastname']";
        public static String SignUp_txt_Phone = "//input[@name='phone']";
        public static String SignUp_txt_Email = "//input[@name='email']";
        public static String SignUp_txt_Password = "//input[@name='password']";
        public static String SignUp_txt_CPassword = "//input[@name='confirmpassword']";
        public static String SignUp_btn_SignUp = "//button[@type='submit'][contains(text(),'Sign Up')]";

        public static String SignUp_msg_EmailRequired ="//div[@class='alert alert-danger']/p[contains(.,'The Email field is required.')]";
        public static String SignUp_msg_FirstnameRequired = "//div[@class='alert alert-danger']/p[contains(.,'The First name field is required.')]";
        public static String SignUp_msg_LastnameRequired = "//div[@class='alert alert-danger']/p[contains(.,'The Last Name field is required.')]";
        public static String SignUp_msg_PasswordRequired = "//div[@class='alert alert-danger']/p[contains(.,'The Password field is required.')][1]";
        public static String SignUp_msg_CPasswordRequired = "//div[@class='alert alert-danger']/p[contains(.,'The Password field is required.')][2]";



        #endregion


    }
}
