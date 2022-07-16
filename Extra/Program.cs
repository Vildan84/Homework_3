void Task01()
{
    double x = 5;
    double b = (x * Math.PI) / 180;
        
    if (x > 0)
    {
        double y = Math.Pow(Math.Sin(b), 2);
        Console.WriteLine(Math.Round(y, 2));
    }
    else
    {
        double c = (Math.Pow(x, 2) * Math.PI) / 180;
        double y = 1 - 2 * (Math.Sin(c));
        
        Console.WriteLine(Math.Round(y, 2));
    } 
}
//Task01();

void Task02()
{
    Console.WriteLine("Please enter number");
    int number = Convert.ToInt32(Console.ReadLine());

    int ones = number / 100;
    int doubles = (number / 10) % 10;
    int hund = number % 10;
    int res = ones + doubles + hund;

    if (res % 3 == 0) Console.WriteLine($"Yes {res}/3 without reserve");
    else Console.WriteLine("No");
}
//Task02();

void Task03()
{
    Console.WriteLine("Please enter number");
    int number = Convert.ToInt32(Console.ReadLine());

    int ones = number / 100;
    int doubles = (number / 10) % 10;
    int hund = number % 10;

    if (ones == 4 || doubles == 4 || hund == 4)
    {
        Console.WriteLine("Number contain 4 or 7");  
    }

    else if (ones == 7 || doubles == 7 || hund == 7)
    {
        Console.WriteLine("Number contain 4 or 7");
    }
    
    else Console.WriteLine("Number NOT contain 4 or 7");
     
}
//Task03();

void Task04()
{
    int[] array = new int[10];
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = index + 1;
        Console.Write(array[index]);
        index++;
    }
    Console.WriteLine();
}
//Task04();

