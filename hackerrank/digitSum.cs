using System;
					
public class Program
{
	public static void Main()
	{
		int number = 8569;
		var result = findDigitSum(number);
		Console.WriteLine(result);
		
	}
	
	public static int findDigitSum(int t)
	{
		int sum = 0;
		while(t > 0){	
			
			int m = t % 10;
			sum = sum + m;
			t = t / 10;
		}
		return sum;
	}
}
