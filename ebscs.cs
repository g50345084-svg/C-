//electricty bill and service charge systemwith class named Customer 
using System;
class Customer
{
    string name;
    int units;

    // Constructor to initialize values
    public Customer(string n, int u)
    {
        name = n;
        units = u;
    }

    public void GetData()
    {
        Console.WriteLine("Enter customer name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter units consumed:");
        units = Convert.ToInt32(Console.ReadLine());

    }
    public static void Main()
    {
        Customer customer = new Customer("", 0);
        customer.GetData();
        double electricityBill = BillCalculator.CalculateBill(customer.units);
        double serviceCharge = BillCalculator.CalculateServiceCharge();
        double totalAmount = electricityBill + serviceCharge;
        Console.WriteLine("\n==================Electricity Bill Details:=====================");
        Console.WriteLine("Customer Name:" + customer.name);
        Console.WriteLine("Units Consumed: " + customer.units);
        Console.WriteLine("Electricity Bill: " + electricityBill + "rs");
        Console.WriteLine("Service Charge: " + serviceCharge + "rs");
        Console.WriteLine("Total Amount: " + totalAmount + "rs");
    }

}

static class BillCalculator
{
    public static double CalculateBill(int units)
    {
        return units * 12.0; // Electricity rate: 12rs per unit
    }

    public static double CalculateServiceCharge()
    {
        return 50.0; // Service charge: 50rs
    }
}