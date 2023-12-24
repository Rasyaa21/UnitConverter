using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class UnitConverter
{
    static void Main(string[] args)
    {
        int input = 0;
        double value = 0, convert = 0;
        
        while (true)
        {
            Option.Start(out input);
            
            if (input == 1)
            {
                Convert.MilesToKm(out value, out convert);
                continue;
            }
            else if (input == 2)
            {
                Convert.FarenheitToCelcius(out value, out convert); 
                continue;
            }
            else if (input == 3)
            {
                Convert.PoundsToKg(out value, out convert);
                continue;
            }
            else
            {
                Console.WriteLine("invalid input try again");
                continue;
            }
        }
    }
}
public class Option()
{
    public static void Start(out int input)
    {
        Console.WriteLine("-----UNIT CONVERTER-----");
        Console.WriteLine();
        Console.WriteLine("1. Miles To Km");
        Console.WriteLine("2. Farenheit To Celcius");
        Console.WriteLine("3. Pounds To Kg");
        Console.WriteLine();
        Console.Write("enter the input : ");
        input = int.Parse(Console.ReadLine());  
    }
}
public class Convert
{
    public static void MilesToKm(out double value, out double convert)
    {
        Console.Write("enter the number of miles : ");
        value = int.Parse(Console.ReadLine());
        convert = value * 1.609344;
        Console.WriteLine($"convert from Miles {value} To Km {convert}");

    }    
    public static void FarenheitToCelcius(out double value, out double convert)
    {
        Console.Write("enter the number of Farenheit : ");
        value = int.Parse(Console.ReadLine());
        convert = (value - 32) * 5 / 9;
        Console.WriteLine($"convert from Farenheit {value} To Celcius {convert}");
    }
    public static void PoundsToKg(out double value, out double convert)
    {
        Console.Write("enter the number of Pounds : ");
        value = int.Parse(Console.ReadLine());
        convert = value * 0.45359237;
        Console.WriteLine($"convert from Pounds {value} To Kg {convert}");
    }
}
