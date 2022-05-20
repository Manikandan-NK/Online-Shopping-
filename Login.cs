using System;
namespace onlineBagShopping
{
    public class Login
    {
        public static void login()
        {
            string? userName=null,password=null;
            Boolean flag=true;
            int index=0;
            while(flag)
            {
                Boolean flag1=false;
                Console.Write("enter user Name:\n");
                userName=Console.ReadLine();
                for(index=0;index<Customer.getCustomerNameList.Count;index++)
                {
                   if(userName!=null && userName.Equals(Customer.getCustomerNameList[index]))
                   {
                       flag1=true;
                       break;
                   }
                }
                if(flag1==false)
                {
                    Console.WriteLine("user name does not exist!!");
                    flag=true;
                }
                else
                {
                    while(flag)
                    {
                        Console.Write("enter password:\n");
                        password=Console.ReadLine();
                        if(password!=null && password.Equals(Customer.getCustomerPasswordList[index]))
                        {
                           Console.WriteLine("Login successful!!!");
                           flag=false;
                        } 
                        else
                        {
                          flag=true;
                          Console.WriteLine("incorrect password!!");
                        }
                    }
                }
            }
            
        } 
    }
}