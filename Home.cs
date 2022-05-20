using System;
namespace onlineBagShopping
{
    public class Home
    {
        public static int choice=0;
        public static void Menus()
        {
	        Boolean flag=true;
	        do
            {
		        Console.WriteLine("**************************************************************");
		        Console.WriteLine("WELCOME TO ONLINE BAG SHOPPING!!");
		        Console.WriteLine("**************************************************************");
                Console.WriteLine("press 1 admin, 2 for shop keeper, 3 for customer, 4 for exit:");
                choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                case 1:
        	        new Admin();
                    break;
                case 2:
                    new ShopKeeper();
                    break;
                case 3:
        	        new Customer();
                    break;
                case 4:
        	        flag=false;
        	        Console.WriteLine("***************WELCOME AGAIN!!*************");
        	        break;
                default:
           	        Console.WriteLine("wrong choice: ");
           	        break;
                }  
            }
            while(flag);
        }
    }
}
