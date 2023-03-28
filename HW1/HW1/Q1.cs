using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            string name = "exchange", customer = "";
            const double rate = 3.42, commission = 0.015;
            uint amount = 0;
            double convertedAmount = 0, fee = 0, totalPrice = 0;
            Console.WriteLine($"Welcome to {name}'s Store.\n");
            Console.Write("Please enter your name: ");
            customer = Console.ReadLine();
            Console.Write("Please enter the amount of $USD you wish to receive: ");
            amount = uint.Parse(Console.ReadLine());
            convertedAmount = amount * rate;
            fee = convertedAmount * commission;
            totalPrice = convertedAmount + fee;
            Console.WriteLine($"\t#Price of USD: {amount}");
            Console.WriteLine($"\t#Price in Shekels: {convertedAmount}");
            Console.WriteLine($"\t#The fee in one payment: {fee:F2}");
            Console.WriteLine($"\t#The fee in three payment: {fee/3:F2}");
            Console.WriteLine($"\t#Total price to pay: {totalPrice:F2}");
        }
    }
}