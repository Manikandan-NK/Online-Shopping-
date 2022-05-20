using System;
using System.Text.RegularExpressions;
namespace onlineBagShopping
{
    public class Productsvalidation
    {
		
        public static Boolean productIdValidation(string? userName,string? productId,string? productName, string? productModel, string? productQuantity, string? productPrice) 
	    {
		    Boolean flag=true, flag1=false;
            string productIdPattern="^[0-9]$";
            Regex productIdRegex= new Regex(productIdPattern);
		    while(flag)
		    {
			    Console.WriteLine("enter the product id:");
			    productId=Console.ReadLine();
			    if(productId!=null && !productIdRegex.IsMatch(productId))
			    {
				    Console.WriteLine("enter only numbers in product id:");
				    flag=true;
			    }
			    else
			    {
				    for(int index=0;index<Stock.productIdList.Count();index++)
				    {
					    if(Stock.productIdList[index].Equals(productId)&&Stock.shopKeeperNameList[index].Equals(userName))
					    {
						   flag1=true;
						   Console.WriteLine("product id already exist:");
						   Console.WriteLine("Try another!!");
						   break;
					    }
				    }
				    if(flag1==true)
				    {
					    flag=true;
					    flag1=false;
				    }
				    else
				    {
					    flag=false;
				    }
			    }
		    }
		    if(flag==false)
		    {
			    if(ShopKeeper.choice==1)
			    {
				   Stock.productId=productId;
			    }
		        productDetailsValidation(productName, productModel, productQuantity, productPrice);
		}
        return false;
	}
	public static Boolean productDetailsValidation(string? productName, string? productModel, string? productQuantity, string? productPrice)
	{
		Boolean flag=true;
        string productNamePattern="^[a-z' 'A-Z]$";
        Regex productNameRegex=new Regex(productNamePattern);
		while(flag)
		{
			Console.WriteLine("enter the product name:");
			productName=Console.ReadLine();
			if(productName!=null && !(productNameRegex.IsMatch(productName)))
			{
				Console.WriteLine("enter only characters in product name!!");
				flag=true;
			}
			else
			{
				flag=false;
			}
		}
		flag=true;
        string productModelPattern="^[a-z' '0-9]$";
        Regex productModelRegex=new Regex(productModelPattern);
		while(flag)
		{
			Console.WriteLine("enter the product model:");
			if(productModel!=null && !(productModelRegex.IsMatch(productModel)))
			{
				Console.WriteLine("enter valid product model!!");
				flag=true;
			}
			else
			{
				flag=false;
			}
		}
		flag=true;
        string productQuantityPattern="^[0-9]$";
        Regex productQuantityRegex=new Regex(productQuantityPattern);
		while(flag)
		{
			Console.WriteLine("enter the product quantity:");
            if(productQuantity!=null)
            {
                if(!productQuantityRegex.IsMatch(productQuantity) || productQuantity[0]=='0')
			    {
				    Console.WriteLine("enter product quantity only in numbers and not starts in 0");
				    flag=true;
			    }
            }
			else
			{
				flag=false;
			}
		}
		flag=true;
        string productPricePattern="^[0-9]$";
        Regex productPriceRegex=new Regex(productPricePattern);
		while(flag)
		{
				Console.WriteLine("enter the product Price:");
                if(productPrice!=null)
                {
                    if(!productPriceRegex.IsMatch(productPrice)|| productPrice[0]=='0')
				    {
					    Console.WriteLine("enter only numbers and not starts with 0 in price!!");
					    flag=true;
			   	    }
                }
				else
				{
					flag=false;
				}
		}
		if(flag==false)
		{
			if(ShopKeeper.choice==1)
			{	
				Stock.productModel=productModel;
				Stock.productName=productName;
				Stock.productQuantity=productQuantity;
				Stock.productPrice=productPrice;
			}
			else if(ShopKeeper.choice==3)
			{
				Stock.productModel=productModel;
				Stock.productName=productName;
				Stock.productPrice=productPrice;
				Stock.productQuantity=productQuantity;
			}
		}
		return true;
	}
	public static Boolean updateValidation(string? productId)
	{
		Boolean flag=true, flag1=false;
        string productIdPattern="^[0-9]$";
        Regex productIdRegex= new Regex(productIdPattern);
		while(flag)
		{
		    Console.WriteLine("enter the product id:");
			productId=Console.ReadLine();
			if(productId!=null && !productIdRegex.IsMatch(productId))
			{
				Console.WriteLine("enter only numbers in product id:");
				flag=true;
			}
			else
			{
				for(int index=0;index<Stock.productIdList.Count();index++)
				{
					if((Stock.productIdList[index].Equals(productId)))
					{
						flag1=true;
						break;
					}
				}
				if(flag1==true)
				{
					flag=false;
					flag1=false;
				}
				else
				{
					Console.WriteLine("product id does not exist!!");
			        Console.WriteLine("If you want to continue updation press 1 otherwise any key");
					char choice=Console.ReadLine()[0];
					if(choice=='1')
					{
						flag=true;
					}
					else
					{
						break;
					}
					
				}
			}
		}
		if(flag==false)
		{
			Stock.productId=productId;
			return true;
		}
		return false;
	}


    }
}