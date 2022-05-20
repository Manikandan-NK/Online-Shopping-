using System;
namespace onlineBagShopping
{
    public class Customer
    {
        private  static List<string> customerNameList=new List<string>();
        private  static List<string> customerPasswordList=new List<string>();
        private  static List<string> customerMobileNumberList=new List<string>();
        private static List<string> customerMailList=new List<string>();
        public static List<string> getCustomerNameList
        {
          get
          {
            return customerNameList;
          }
        }
        public static List<string> getCustomerPasswordList
        {
          get
          {
            return customerPasswordList;
          }
        }
        public static List<string> getCustomerMobileNumberList
        {
          get
          {
            return customerMobileNumberList;
          }
        }
        public static List<string> getCustomerMailList
        {
            get
            {
                return customerMailList;
            }
        }
        public static void setCustomerName(string userName)
        {
          customerNameList.Add(userName);
        }
        public static void setCustomerPassword(string password)
        {
          customerPasswordList.Add(password);
        }
        public static void setCustomerMobileNumber(string mobileNumber)
        {
          customerMobileNumberList.Add(mobileNumber);
        }
        public static void setCustomerMailId(string MailId)
        {
            customerMailList.Add(MailId);
        }
      
        public  Customer()
	    {
            
		    Boolean flag=true;
		    do
		    {
			   Console.WriteLine("*************************************************************");
			   Console.WriteLine("press 1 for signup, 2 for login, 3 for exit:");
			   int choice=Convert.ToInt32(Console.ReadLine());
			   switch(choice)
		       {
			    case 1:
				    Registration.validation();
				    break;
			    case 2:
				    Login.login();
			        break;
			    case 3:
				    flag=false;
				    break;
			    default:
				    Console.WriteLine("wrong choice!!");
			    	break;
			   } 
		   }
		   while(flag);
	    }
    }
}