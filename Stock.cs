using System;
namespace onlineBagShopping
{
    public class Stock
    {
        public static List<string> shopKeeperNameList=new List<string>();
		public static List<string> productIdList=new List<string>();
		public static List<string> productNameList=new List<string>();
		public static List<string> productModelList=new List<string>();
		public static List<string> productPriceList=new List<string>();
		public static List<string> productQuantityList=new List<string>();
		public static List<DateTime> productAddedOnList=new List<DateTime>();
		public static string? productId=null;
		public static string? productName = null;
		public static string? productModel = null;
		public static string? productQuantity = null;
	    public static string? productPrice = null;
		public static void addStock(string userName)
		{
			
			Console.WriteLine("welcome mr."+userName);
            Productsvalidation.productIdValidation(userName,productId,productName, productModel, productQuantity, productPrice);
			Boolean flag=false;
			for(int index=0;index<Stock.productIdList.Count();index++)
			{
				if(Stock.productIdList[index].Equals(productId)&&Stock.shopKeeperNameList[index].Equals(userName))
				{
					Console.WriteLine("product already exist!!");
					flag=true;
					break;
				}
			}
			if(flag==false)
			{
				    
					if(userName!=null && productId!=null && productName!=null && productModel!=null && productPrice!=null && productQuantity!=null)
					{
						Stock.shopKeeperNameList.Add(userName);
				        Stock.productIdList.Add(productId);
					    Stock.productNameList.Add(productName);
					    Stock.productModelList.Add(productModel);
					    Stock.productPriceList.Add(productPrice);
					    Stock.productQuantityList.Add(productQuantity);
					}
					Stock.productAddedOnList.Add(Date());
				    Console.WriteLine("Productsvalidation added successfully!!");
			}
			else
			{
				Stock.updateStock(userName);
			}
			
		}
		
		private static DateTime Date() 
		{
            DateTime dateTime=new DateTime();
			return dateTime;
		}
		public static void updateStock(string userName)
		{
			Console.WriteLine("welcome mr."+userName);
			if(Productsvalidation.updateValidation(productId))
			{
				if(Productsvalidation.productDetailsValidation(productName, productModel, productQuantity, productPrice))
				{
					for(int index=0;index<Stock.productIdList.Count();index++)
					{
						if(Stock.productIdList[index].Equals(productId)&&Stock.shopKeeperNameList[index].Equals(userName))
						{
							if(userName!=null && productId!=null && productName!=null && productModel!=null && productPrice!=null && productQuantity!=null)
							{
								Stock.productNameList[index]=productName;
							    Stock.productModelList[index]=productModel;
							    Stock.productQuantityList[index]=productQuantity;
							    Stock.productPriceList[index]=productPrice;
							}
							Console.WriteLine("successfully updated!!");
							break;
						}
					}
				}
			}
			else
			{
				Console.WriteLine("updation failed");
			}
			
		}
	    public static Boolean displayStock(string username)
	    {
		    if(productNameList.Count()==0)
		    {
			    Console.WriteLine("***************************************************");
 			    Console.WriteLine("There is no products entered: please enter products");
			    Console.WriteLine("***************************************************");
			    return false;
		    }
		    else
	 	    {
			    Console.WriteLine("*************************************************************STOCK DETAILS****************************************************************");
			    for(int index=0;index<productNameList.Count();index++)
		 	    { 
				    if(shopKeeperNameList[index].Equals(username))
			 	    { 
					    Console.WriteLine("Shopkeeper Name:"+shopKeeperNameList[index]+" | "+"Product Id: "+productIdList[index]+" | "+"Product Name: "+productNameList[index]+" | "+" product Model: "+productModelList[index]+" | "+" product Quantity: "+productQuantityList[index]+" | "+" product Price: "+productPriceList[index]+" | "+"product Addedon: "+productAddedOnList[index]);
				    }
			    }
			    Console.WriteLine("*****************************************************************************************************************************************");
		    }
		    return true;
 	    }   
    }
}