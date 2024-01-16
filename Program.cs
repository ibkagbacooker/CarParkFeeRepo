// See https://aka.ms/new-console-template for more information

using System;

namespace TicketSystem

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is your car model?:"); 

string carModel = Console.ReadLine();

Console.WriteLine("what is your plate number?:"); 

string plateNumber = Console.ReadLine();

int intHours;

while(true)

{
    Console.WriteLine("How many hours have you been parked:");
    
    string hours = Console.ReadLine();

if (int.TryParse(hours, out intHours) && intHours > 0)
{
    break;
}
else
{
    
     Console.WriteLine("Invalid input. I need a valid positive number");
}


}

Console.WriteLine("Car model: "+ carModel+ "plate number: "+ plateNumber + "no of hours: " + Convert.ToString(intHours));



Console.WriteLine("you drive a "+ carModel +", your plate number is "+ plateNumber +", and you have spent " + Convert.ToString(intHours) + " hours here.");

double TotalParkingFee = 500.00D;
if(intHours == 1){
    
    Console.WriteLine($"Your parking ticket is {TotalParkingFee} naira");
}
else
{
    double TotalParkingFee2 = TotalParkingFee + (100 * (intHours - 1));
    Console.WriteLine($"Your parking ticket is {TotalParkingFee2} naira");

}

        }
    }
}
