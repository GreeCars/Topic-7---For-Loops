// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type a message, and I'll display it five times.");
Console.WriteLine("Message: ");
String message = Console.ReadLine();
for (int i = 2; i <= 10; i = i + 2)
{
    Console.WriteLine(i + ". " + message);
}
Console.WriteLine();
// Task 1
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i + ". " + "Pizza is delicious!");
}
Console.WriteLine();
// Task 2
int number;
Console.Write("What do you want me to count to? ");
number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= number; i += 1)
{
    Console.Write(i + " ");
}
Console.WriteLine();
// Task 3
int start, end, step;
Console.Write("Count from: ");
start = Convert.ToInt32(Console.ReadLine());

Console.Write("Count to: ");
end = Convert.ToInt32(Console.ReadLine());

Console.Write("Count by: ");
step = Convert.ToInt32(Console.ReadLine());

if (step > 0) // Step must be 1 or greater in order to reach the end
{
    for (int i = start; i <= end; i += step)
    {
        Console.Write(i + " ");
    }
}
else
{
    Console.WriteLine("Infinite Loop Error");
}