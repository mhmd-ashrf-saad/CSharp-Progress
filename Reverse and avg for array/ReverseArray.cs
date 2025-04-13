Console.Write("Enter number of items: ");
int size=int.Parse(Console.ReadLine()); // size of array
int[] numbers = new int[size+1]; // initialize array
for(int i=1;i<=size;i++)// fill the array
{
    Console.WriteLine($"Enter element number {i}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

// original array
Console.WriteLine("The array you entered:");
for (int i = 1; i <= size; i++)
{
    Console.WriteLine(numbers[i]);
}

//reversed array
Console.WriteLine("\nThe Reversed Array:");
for(int i=size;i>=1;i--)
{
    Console.WriteLine(numbers[i]);
}

// calculate average =  sum / size
float sum = 0;
foreach(int num in numbers)
{
    sum += num;
}
Console.WriteLine($"\nAverage = {sum / size}") ;