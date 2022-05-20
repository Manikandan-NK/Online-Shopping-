using System;
using System.Text.RegularExpressions;
namespace onlineBagShopping
{
    public class Registration
    {
        private static List<string> userNameList=new List<string>();
        private static List<string> mailList=new List<string>();
        private static List<string> mobileNumberList=new List<string>();
        public static void validation()
        {
            string? userName=null,userPassword=null,userMobileNumber=null,userMailId=null;
            if(Home.choice==2)
            {
                userNameList=ShopKeeper.getShopkeepersNameList;
                mobileNumberList=ShopKeeper.getShopkeepersMobileNumberList;
                mailList=ShopKeeper.getShopkeepersMailList;
                Console.WriteLine("enter shop Name:");
                string? shopName=Console.ReadLine();
                if(shopName!=null)
                {
                    ShopKeeper.setShopNameList(shopName);
                }   
            }
            if(Home.choice==3)
            {
                userNameList=Customer.getCustomerNameList;
                mobileNumberList=Customer.getCustomerMobileNumberList;
                mailList=Customer.getCustomerMailList;   
            }
            Boolean flag=true;
            string userNamePattern ="^[A-Za-z]\\w{5,29}$";
            Regex userNameRegex=new Regex(userNamePattern);
            while(flag)
            {
                Console.Write("enter user name:\n");
                userName=Console.ReadLine();
                if(userName!=null)
                {
                    if(!userNameRegex.IsMatch(userName))
                    {
                     Console.WriteLine("Invalid user name!!");
                     Console.WriteLine("*********************************************************************************");
	   		         Console.WriteLine("A username is considered valid if all the following constraints are satisfied:\r\n"
	   		   		+ "The username consists of 6 to 30 characters inclusive. If the username\r\n"
	   		   		+ "consists of less than 6 or greater than 30 characters, then it is an invalid username.\r\n"
	   		   		+ "The username can only contain alphanumeric characters and underscores (_)."
	   		   		+ " Alphanumeric characters describe the character set consisting of lowercase characters [a – z], uppercase characters [A – Z], and digits [0 – 9].\r\n"
	   		   		+ "The first character of the username must be an alphabetic character, i.e., either lowercase character\r\n"
	   		   		+ "[a – z] or uppercase character [A – Z].");
	   		        Console.WriteLine("*********************************************************************************");
                    flag=true;
                    }
                    else
                    {
                        flag=false;
                        for(int index=0;index<Customer.getCustomerNameList.Count;index++)
                        {
                            if(Customer.getCustomerNameList[index].Equals(userName))
                            {
                                flag=true;
                                Console.WriteLine("userName already exist try another!!");
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Name should not be null!!");
                    flag=true;
                }
            }
            flag=true;
            
            string passwordPattern ="^(?=.*[0-9])"+"(?=.*[a-z])(?=.*[A-Z])"+ "(?=.*[@#!$%^&()+=*])"+ "(?=\\S+$).{8,20}$";
            Regex passwordRegex=new Regex(passwordPattern);
            while(flag)
            {
                Console.Write("enter password:\n");
                userPassword=Console.ReadLine();
                if(userPassword!=null)
                {
                    if(!passwordRegex.IsMatch(userPassword))
                    {
                        Console.WriteLine("Invalid password!!");
                        Console.WriteLine("*********************************************************************************");
    		    	    Console.WriteLine("A password is considered valid if all the following constraints are satisfied:\r\n"
    		    	 		+ "It contains at least 8 characters and at most 20 characters.\r\n"
    		    	 		+ "It contains at least one digit.\r\n"
    		    	 		+ "It contains at least one upper case alphabet.\r\n"
    		    	 		+ "It contains at least one lower case alphabet.\r\n"
    		    	 		+ "It contains at least one special character which includes !@#$%&*()-+=^.\r\n"
    		    	 		+ "It doesn’t contain any white space.");
    		    	    Console.WriteLine("*********************************************************************************");
                        flag=true;
                    }
                    else
                    {
                        Console.WriteLine("Confirm password!!");
    		        	 String? confirmPassword=Console.ReadLine();
    		        	 if(!(userPassword.Equals(confirmPassword)))
    		        	 {
    		        		Console.WriteLine("Password doesn't match try again!!");
    		        		Console.WriteLine("***********************************");
    		        		flag=true;
    		        	 }
    		        	 else
    		        	 {
    		        		flag=false;
    		        	 }
                    }
                }
            }
            flag=true;
            while(flag)
            {
                Console.Write("enter mobile number:\n");
                userMobileNumber=Console.ReadLine();
                if(userMobileNumber==null || userMobileNumber[0]=='0'|| !Regex.Match(userMobileNumber,"^[0-9]").Success || userMobileNumber.Length!=10)
                {
                    Console.WriteLine("Enter valid mobile number!");
                    flag=true;
                }
                else
                {
                    flag=false;
                }
            }
            if(flag==false)
         	{
                String mailIdFormat="^[A-Za-z0-9+_.-]+@(.+)$";
                Regex mailRegex=new Regex(mailIdFormat);
    		    do
    		    {
    			    Console.WriteLine("Enter mailId:");
    		        userMailId=Console.ReadLine();
    	            if(userMailId !=null && !mailRegex.IsMatch(userMailId))
    	            {
    	       	        Console.WriteLine("Invalid mail id!!");
    	       	        Console.WriteLine("*************************************************************");
    	       	        Console.WriteLine("A-Z characters are allowed\r\n"
    	       	 		 + "a-z characters are allowed\r\n"
    	       	 		 + "0-9 numbers are allowed\r\n"
    	       	 		 + "Additionally email can contain dot(.), underscore(_), and dash(-).\r\n"
    	       	 		 + "The remaining characters are not allowed.");
    	       	        Console.WriteLine("*************************************************************");
    	       	        flag =true;
    	            }
    	            else
    	            { 
    	        	   flag=false;
    	            }
    		    }
    		    while(flag);
    	    }
            if(flag==false && userName!=null && userPassword!=null && userMailId!=null && userMobileNumber!=null)
            {
                registration(userName,userPassword,userMailId,userMobileNumber);
            }
        }
        public static void registration(String userName, String userPassword, String userMailId,String userMobilenumber)
	    {
            if(Home.choice==3)
            {
                Customer.setCustomerName(userName);
       	        Customer.setCustomerPassword(userPassword);
                Customer.setCustomerMailId(userMailId);
                Customer.setCustomerMobileNumber(userMobilenumber);
            }
            else if(Home.choice==2)
            {
                ShopKeeper.setShopkeepersNameList(userName);
       	        ShopKeeper.setShopkeepersPasswordList(userPassword);
                ShopKeeper.setShopkeepersMailList(userMailId);
                ShopKeeper.setShopkeepersMobileNumberList(userMobilenumber);
            }
		    Console.WriteLine("Your account was created successfully!!");
            Console.WriteLine("***************************************");
	}
    }
}



