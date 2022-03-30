using System;
using System.Collections.Generic;
var numsList = new List<int> { 11,22,33,44,55,66,77,88,99};
foreach (var salmon in numsList)
{
    Console.Write(salmon + " " );

}
Console.WriteLine(" - Элементы коллекции");


foreach (var salmon in numsList)
{
	
	for (int i = 0; i < 9; i++)
    {
		int sum = 0;
        
        sum += (int)(numsList[i] / 10);
        sum += numsList[i] % 10;
        int res = sum;
Console.WriteLine(res);
    }
        Console.ReadLine();
    
    

}
   



