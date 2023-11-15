Console.WriteLine("Enter first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int second = Convert.ToInt32(Console.ReadLine());
int sumofpaired = 0;
int sumofunpaired = 0;
int sumofmultiples = 0;
//double arifmeticalMeanPaired = 0;
//double arifmeticalMeanUnPaired = 0;
//double arifmeticalMeanMultiples = 0;
int counter = 0;
int counterMultiples = 0;
for (int i = first; i <= second; i++)
{
    
    if (i % 2 == 0)
    {
        counter++;
        sumofpaired += i;
        
    }
    
}
Console.WriteLine($"Sum of paired number in range = {sumofpaired}");
Console.WriteLine($"Arifmetical mean of paired number = {sumofpaired / counter}");
for (int i = first; i <= second; ++i)
{
    if (i % 2 == 1)
    {
        counter++;
        sumofunpaired += i;
        
    }
}
Console.WriteLine($"Sum of paired number in range = {sumofunpaired}");
Console.WriteLine($"Arifmetical mean of unpaired number = {sumofunpaired / counter}");
for (int i = first; i <= second; ++i)
{
    if(i % 9 == 0)
    {
        counterMultiples++;
        sumofmultiples += i;
        
    }
}
Console.WriteLine($"Sum number in the range multiples = {sumofmultiples}");
Console.WriteLine($"Arifmetical mean of range multiples number = {sumofmultiples / counterMultiples}");