Console.WriteLine("Pls enter the number to check: ");
var numericValue = Validation();

int[] numbers = new int[12];

for (int i = 0; i < numbers.Length; i++)
{
    int rest = Convert.ToInt32(numericValue % 10);
    numericValue /= 10;
    numbers[i] = rest;
}

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 == 1)
    {
        numbers[i] = numbers[i] * 2;
        if (numbers[i] > 9)
        {
            numbers[i] = numbers[i] - 9;
        }
    }
}


int sum = 0;
foreach (int i in numbers)
{
    sum += i;
}


if (sum % 10 == 0)
{
    Console.WriteLine("The number is valid");
}
else
{
    Console.WriteLine("the number is invalid");
}


static long Validation()
{
    string valueToValidate = Console.ReadLine();
    long numericValue = -1;
    while (!long.TryParse(valueToValidate, out numericValue) || String.IsNullOrEmpty(valueToValidate) || !(valueToValidate.Length == 12))
    {
        Console.WriteLine("wrong format. Try again: ");
        valueToValidate = Console.ReadLine();

    }
    return numericValue;
}