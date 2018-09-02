FIXME:breakpoint



--------------------

/*
 * Created by SharpDevelop.
 * User: 
 * Date: 2018/8/30
 * Time: 10:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

//https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/yield
//https://blog.csdn.net/beihuanlihe130/article/details/76098844
namespace testyield
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
	        // Display powers of 2 up to the exponent of 8:
	        System.Collections.Generic.IEnumerable<int> k = Power(2, 8);
	        IEnumerator<int> enumerator = k.GetEnumerator();
	        while (enumerator.MoveNext())
	        {
	        	int i = enumerator.Current;
	        	Console.Write("{0} ", i);
	        }
//	        foreach (int i in k)
//	        {
//	            Console.Write("{0} ", i);
//	        }		
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
	    {
	        int result = 1;
	
	        for (int i = 0; i < exponent; i++)
	        {
	        	Console.WriteLine("===================");
	            result = result * number;
	            yield return result;
	        }
	    }

	}
}

---------------------------------

