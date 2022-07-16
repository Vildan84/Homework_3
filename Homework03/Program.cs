void Task01()
{
    Console.Write("Enter number (5 digit):");
    int number = Convert.ToInt32(Console.ReadLine());
    int num1 = number / 10000;
    int num2 = number / 1000 % 10;
    int num4 = number % 100 / 10;
    int num5 = number % 10;
    
    if ( num1 == num5 && num2 == num4) 
    {
        Console.WriteLine($"Number: {number} is Palindrom");
    }
    else Console.WriteLine($"Number: {number} is NOT Palindrom");
}
//Task01();

void Task02()
{
    Console.WriteLine("Ввдедите координаты первой точки");
    double x1 = Convert.ToInt32(Console.ReadLine());
    double y1 = Convert.ToInt32(Console.ReadLine());
    double z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ввдедите координаты второй точки");
    double x2 = Convert.ToInt32(Console.ReadLine());
    double y2 = Convert.ToInt32(Console.ReadLine());
    double z2 = Convert.ToInt32(Console.ReadLine());

    double xx = x2 - x1;
    double yy = y2 - y1;
    double zz = z2 - z1;


    double result = Math.Sqrt(xx*xx + yy*yy + zz*zz);
    Console.WriteLine("Расстояние:" + Math.Round(result, 2));
}
//Task02();

void Task03()
{

    Console.Write("Please enter number:");
    int number = Convert.ToInt32(Console.ReadLine());
    int counter = 0;
    
     while (counter <= number)
     {
        double result = Math.Pow(counter, 3);
        Console.WriteLine($"{counter} x {counter} x {counter} = {result}");
        counter++;
     }
}
Task03();




