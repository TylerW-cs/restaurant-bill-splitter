Console.WriteLine("What is the total bill amount?");
decimal billAmount = decimal.Parse(Console.ReadLine());

Console.WriteLine("What is the tip percentage you would like to give?");
decimal tipPercentage = decimal.Parse(Console.ReadLine());

Console.WriteLine("What is the number of people to split the bill?");
int numberOfPeople = int.Parse(Console.ReadLine());

decimal tipAmount = (billAmount * tipPercentage) / 100;
decimal totalBill = billAmount + tipAmount;
decimal totalPerCustomer = totalBill / numberOfPeople;

if (tipPercentage > 20)
{
    Console.WriteLine("Very generous tip!");
}
else if (tipPercentage >= 10 && tipPercentage <= 20)
{
    Console.WriteLine("Thank you for your standard tip!");
}
else if (tipPercentage < 10)
{
    Console.WriteLine("That is a low tip!");
}

Console.WriteLine($"The total tip amount is: £{tipAmount:F2}");
Console.WriteLine($"The total bill including tip is: £{totalBill:F2}");
Console.WriteLine($"Each person pays: £{totalPerCustomer:F2}");

