var sortedList = new List<int>();
int number;

while (sortedList.Count < 5)
{
    System.Console.Write("Enter a unique number:");
    number = Convert.ToInt32(Console.ReadLine());
    if (sortedList.Contains(number))
    {
        Console.WriteLine("Number is already in the list");
    }
    else
    {
        sortedList.Add(number);
        Console.WriteLine("Number added to the list");
    }
}

sortedList.Sort();
Console.Write("Sorted list: ");
Console.WriteLine(string.Join(", ", sortedList));
 