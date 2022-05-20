using System;
namespace onlineBagShopping
{
    public class ShopKeeper
    {
        private static List<string> shopNameList=new List<string>(); //This array list contains the shopkeepers shop name
	    private static List<string> shopKeepersNameList= new List<string>();//This array list contains the shopkeeper's user name
	    private static List<string> shopKeepersPasswordList=new List<string>();//This array list contains the shopkeeper's password
	    private static List<string> shopKeepersMailList=new List<string>();//This array list contains the shopkeeper's mail id
	    private static List<string> shopKeepersMobileNumberList=new  List<string>();
        public  static List<string> getShopNameList
	    {
            get
            {
                return shopNameList;
            }
   	    }
	    public static void setShopNameList(string shopName) 
	    {
           shopNameList.Add(shopName);
 	    }
        public  static List<string> getShopkeepersNameList
	    {
            get
            {
                return shopKeepersNameList;
            }   
   	    }
	    public static void setShopkeepersNameList(string shopKeeperName) 
	    {
		   shopKeepersNameList.Add(shopKeeperName);
 	    }
        public static  List<string> getShopkeepersPasswordList
	    {
            get
            {
                return shopKeepersPasswordList;
            }
		    
   	    }
	    public static void setShopkeepersPasswordList(string password) 
	    {
		   shopKeepersPasswordList.Add(password);
 	    }
	    public static List<string> getShopkeepersMailList
	    {
            get
            {
                return shopKeepersMailList;
            }
   	    }
	    public static void setShopkeepersMailList(string MailId) 
	    {
		   shopKeepersPasswordList.Add(MailId);
 	    }     
        public static List<string> getShopkeepersMobileNumberList
	    {
            get
            {
                return shopKeepersMobileNumberList;
            }
   	    }
	    public static void setShopkeepersMobileNumberList(string mobileNumber) 
	    {
		   shopKeepersMobileNumberList.Add(mobileNumber);
 	    }  
	    public ShopKeeper()
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
				    shopKeepersLogin();
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
	    public static void shopKeepersLogin()
	    {
		    List<string> passwordList=new List<string>();
		    string? userName=null,shopName=null;
		    Console.WriteLine("*************************");
            int index=0;
            Boolean flag=true;
            while(flag)
            {
        	    Console.WriteLine("enter the shop name:");
                shopName=Console.ReadLine();
        	    for(index=0;index<shopNameList.Count();index++)
                {
            	    if(shopNameList[index].Equals(shopName))
            	    {
            		    flag=false;
            		    Boolean flag1=true;
            		    while(flag1)
            		    {
            			    Console.WriteLine("enter the user name:");
            			    userName=Console.ReadLine();
            			    if(userName!=null && userName.Equals(shopKeepersNameList[index]))
            			    {
            				    flag1=false;
            			    }
            			    else
            			    {
            				    Console.WriteLine("user name does not exist!!");
            				    flag1=true;
            			    }
            		    }
            		    break;
            	    }
                }
                if(flag==true)
                {
            	    Console.WriteLine("shop name does not exist!!");
                }
            }
            flag=true;
            passwordList=shopKeepersPasswordList;
            int count=3;
            while(flag==true&& count!=0)
            {
        	    Console.WriteLine("enter the password:");
			    string? password=Console.ReadLine();
			    if(passwordList[index].Equals(password))
			    {
				    Console.WriteLine("LOGIN SUCCESSFUL!!");
  				    if(Home.choice==2 && userName!=null  && shopName!=null)
  				    {
  					    showShopkeepersMenu(userName,shopName);
  				    }
				    flag=false;
		    	}
			    else
			    {
				    Console.WriteLine("password incorrect!!");
				    count--;
				    if(count!=0)
				    {
				       Console.WriteLine("still you have "+count+" attempt to enter password!!");
				    }
			        if(count==0)
				    {
					    Console.WriteLine("Your account was locked!!");
					    flag=false;
					    break;
				    }
				    flag=true;
			    }
            }    
	    }
	    public static int choice;
	    public static void showShopkeepersMenu(String userName,String shopName)
	    {
		    Boolean flag=true;
		    for(int index=0;index<shopNameList.Count();index++)
		    {
			    if(shopKeepersNameList[index].Equals(userName))
			    {
				    Console.WriteLine("****************welcome to "+shopNameList[index]+"****************");
				    break;
			    }
		    }
		    Console.WriteLine("welcome mr."+userName);
		    do
	    	{	
		        Console.WriteLine("****************************************************************************************************************************");
			    Console.WriteLine("press 1 for add stock, 2 for update stock, 3 for display stock, 4 for display sales details, 5 for logout ");
			    choice=Convert.ToInt32(Console.ReadLine());
		        switch(choice)
		 	    {
			    case 1:
				    Stock.addStock(userName);
					break;
				case 2:
					Stock.updateStock(userName);
					break;
				case 3:
					Stock.displayStock(userName);
					break;
				case 4:
//					Sales.displaySales(userName);
					break;
				case 5:
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