 static void Main(string[] args)
 {
     
     Console.Write("Enter the number of items in the array: ");
     int array_size = int.Parse(Console.ReadLine());
     int[] array = new int[array_size];
     int mx = int.MinValue,mn=int.MaxValue,sum =0;
     for(int i=0;i<array_size;i++)
     {
       
         Console.Write($"Enter element number {i + 1}: ");
         array[i] = int.Parse(Console.ReadLine());
         Console.WriteLine(" ");
         if (mx < array[i])
             mx = array[i];
         if (mn > array[i])
             mn = array[i];
         sum += array[i];
     }
     Console.WriteLine($"The minimum number = {mn}");
     Console.WriteLine($"The maximum number = {mx}");
     double average = sum / array_size;
     Console.WriteLine($"Average = {average}");
 }