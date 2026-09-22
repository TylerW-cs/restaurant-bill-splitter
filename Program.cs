// Asks the user what the total bill amount is. The user inputs the amount and it gets converted to a decimal data type so it can be used in calculations.
Console.WriteLine("What is the total bill amount?");
decimal billAmount = decimal.Parse(Console.ReadLine());

// Asks the user what the tip percentage is. The user inputs the amount and it gets converted to a decimal data type so it can be used in calculations.
Console.WriteLine("What is the tip percentage you would like to give?");
decimal tipPercentage = decimal.Parse(Console.ReadLine());

// Asks the user how many people to split the bill with. The user inputs the amount and it gets converted to an integer data type so it can be used in calculations.
Console.WriteLine("What is the number of people to split the bill?");
int numberOfPeople = int.Parse(Console.ReadLine());

// Calculations for the Tip Amount, Total for the Bill and also the Total per customer.
decimal tipAmount = (billAmount * tipPercentage) / 100;
decimal totalBill = billAmount + tipAmount;
decimal totalPerCustomer = totalBill / numberOfPeople;

// If statement that prints messages depending on the tip percentage the customer inputs.
if (tipPercentage > 20)
{
    Console.WriteLine("Very generous tip!");
}
else if (tipPercentage >= 10 && tipPercentage <= 20)
{
    Console.WriteLine("Thank you for your standard tip!");
}
else

// Prints the total tip amount, total bill including tip and how much each person pays, all in £ and to 2 decimal places.
Console.WriteLine($"The total tip amount is: £{tipAmount:F2}");
Console.WriteLine($"The total bill including tip is: £{totalBill:F2}");
Console.WriteLine($"Each person pays: £{totalPerCustomer:F2}");
