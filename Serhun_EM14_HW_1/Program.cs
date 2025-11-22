using System;
using System.Security.AccessControl;

namespace Serhun_EM14_HW_1
{
    internal class Program
    {
        static void printError(string message)
        {
            throw new Exception(message);
        }
        static void printResult(double firstNum, string opr, double secondNum, double result)
        {
            Console.WriteLine("Result: " + firstNum + " " + opr + " " + secondNum + " = " + result);
        }
        static void printResult(double firstNum, string opr, double result)
        {
            Console.WriteLine("Result: " + opr + result);
        }
        static double readDouble(string message) {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }
        static void Main()
        {
            //Task 1
            try
            {
                double firstNum, secondNum = 0;
                int operation;
                string[] opr = { "+", "-", "*", "/", "√", "^" };
                firstNum = readDouble("Enter number:");
                operation = Convert.ToInt32(readDouble("Enter operation(\n1 - \"+\"\n2 - \"-\"\n3 - \"*\"\n4 - \"/\"\n5 - \"√\"\n6 - \"^\")\n"));
                if (operation < 1 ||  operation > 7)
                    printError("Error! unknown operation number");
                if (operation != 5)
                {
                    if (operation != 6)
                        {
                            secondNum = readDouble("Enter second number: ");
                            if (operation == 4 && secondNum == 0)
                                printError("Error! cannot divide by zero");
                        }
                    else{
                        secondNum = readDouble("Enter degree: ");
                        if (secondNum < 0) {
                            printError("Error! Degree cannot be negative");
                        }
                    }
                }
                else
                {
                    if (firstNum < 0)
                        printError("Error! The number under the root cannot be negative");
                }
                operation -= 1;
                    switch (operation)
                    {
                        case 0:
                            {
                                printResult(firstNum, opr[operation], secondNum, firstNum + secondNum);
                                break;
                            }
                        case 1:
                            {
                                printResult(firstNum, opr[operation], secondNum, firstNum - secondNum);
                                break;
                            }
                        case 2:
                            {
                                printResult(firstNum, opr[operation], secondNum, firstNum * secondNum);
                                break;
                            }
                        case 3:
                            {
                                printResult(firstNum, opr[operation], secondNum, firstNum / secondNum);
                                break;
                            }
                        case 4:
                            {
                                printResult(firstNum, opr[operation], Math.Sqrt(firstNum));
                                break;
                            }
                        default:
                            {
                                printResult(firstNum, opr[operation], secondNum, Math.Pow(firstNum, secondNum));
                                break;
                            }
                    }
            }
            catch (Exception ex) {
                printError(ex.Message);                
            }
            //Task 2
            /*
            try
            {
                double km, minutes, kmRate = 10, minutesRate = 2, fare;
                km = readDouble("Enter the travel distance(kilometers): ");
                if (km < 0)
                    printError("Error! The value cannot be negative");
                minutes = readDouble("Enter downtime minutes: ");
                if (minutes < 0)
                    printError("Error! The value cannot be negative");
                fare = km * kmRate + minutes * minutesRate;
                if (fare <= 50)
                    Console.WriteLine("Travel cost: 50 UAH");
                else
                    Console.WriteLine("Travel cost: " + fare + " UAH");
            }
            catch (Exception ex) { printError(ex.Message); }
            */
            //Task 3
            /*
            try
            {
                double kWh, tariff = 0;
                kWh = readDouble("Enter the number of kilowatt-hours consumed (kWh): ");
                if (kWh < 0)
                    printError("Error! The value cannot be negative");
                if (kWh > 0)
                {
                    if (kWh > 100)
                    {
                        if (kWh > 600)
                        {
                            tariff = 1.92;
                        }
                        else
                            tariff = 1.68;
                    }
                    else
                        tariff = 1.44;
                }
                Console.WriteLine("Total cost of electricity: " +(kWh*tariff));
            }
            catch (Exception ex) { printError(ex.Message); }
            */
        }
    }
}
