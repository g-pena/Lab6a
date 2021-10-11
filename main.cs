using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
  
//for 7 days
//get input in celsius
//store in array called celsius
//convert to fahrenheit
//store in another array called fahrenheit
//store farenheit array in descending order
//use foreach loop display farenheit array values
//calculate sum of fahrenheit array
//use sum to calculate the average temp in fahrenheit

double[] fahrenheit = new double [7];
double[] celsius = new double [7];
double sum=0;

for (int pos=0; pos < 7; pos++)
{
  Console.WriteLine("Enter the temperature in Celsius:");
  celsius[pos]=Convert.ToDouble(Console.ReadLine());

  fahrenheit[pos]=(celsius[pos] * 9/5) +32;
}
Array.Sort(fahrenheit);
Array.Reverse(fahrenheit);
 Console.WriteLine("Temperature in Fahrenheit is:");
foreach (double temp in fahrenheit)
{

  Console.WriteLine(temp);
}
foreach (double item in fahrenheit)
{
  sum += item;
}
double average=sum/7;
Console.WriteLine("Average weekly temperature is "+average+" degrees fahrenheit.");

  }
}