Console.WriteLine("Enter array length (from 2 to 32)");
int arraySize = int.Parse(Console.ReadLine()!);

if (arraySize < 2) {
    arraySize = 2;
}
else if (arraySize > 32) {
    arraySize = 32;
}

int[] array = new int[arraySize];
Console.Write("Array numbers:");

for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(0, 100);
    Console.Write(" " + array[i].ToString());
}
Console.WriteLine("");

Console.WriteLine("Enter the Number");
int N = int.Parse(Console.ReadLine()!);
string pairs = "";

for (int i = 0; i < array.Length - 1; i++) {
    for (int j = i + 1; j < array.Length; j++) {
    
        if (array[i] + array[j] == N)
        {
            pairs += "(" + array[i].ToString() + ", " + array[j].ToString() + "); ";
          
        }

    }
}

Console.WriteLine(pairs == "" ? "There are no pairs whose sum is equal to " + N.ToString() : "Pairs whose sum is equal to " + N.ToString() + ": " + pairs);