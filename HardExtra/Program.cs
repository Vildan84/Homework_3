int GetNumber()
{
    Console.WriteLine("Enter from 1 to 4: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreatePoint()
{   
    int number = GetNumber();
    Random rand = new Random();
    int[] point = new int[2];
           
    if (number == 1)
    {
        point[0] = rand.Next(1,10);
        point[1] = rand.Next(1,10);
    }
    else if (number == 2)
    {
        point[0] = rand.Next(-10,-1);
        point[1] = rand.Next(1,10);
    }
    else if (number == 3)
    {
        point[0] = rand.Next(-10,-1);
        point[1] = rand.Next(-10,-1);

    }
    else
    {
        point[0] = rand.Next(1,10);
        point[1] = rand.Next(-10,-1);
    }
    return point;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]}/");
        position++;
    }
    Console.WriteLine();
}

int[] point1 = CreatePoint(); 
int[] point2 = CreatePoint(); 
int[] point3 = CreatePoint();

PrintArray(point1); PrintArray(point2); PrintArray(point3);

double dist1 = Math.Sqrt(Math.Pow(point1[0], 2) + Math.Pow(point1[1], 2));
double dist2 = Math.Sqrt(Math.Pow(point2[0], 2) + Math.Pow(point2[1], 2));
double dist3 = Math.Sqrt(Math.Pow(point3[0], 2) + Math.Pow(point3[1], 2));
    
Console.WriteLine($"Dist1:{dist1} Dist2:{dist2} Dist3:{dist3}");

int[] firstPoint = point1;
int[] secondPoint = point2;
int[] thirdPoint = point3;


if (dist2 < dist1 && dist2 < dist3) firstPoint = point2;
else if (dist3 < dist2) firstPoint = point3;


if (firstPoint == point1)
{
    double aa = Math.Sqrt(Math.Pow(point2[0] - point1[0], 2) 
    + Math.Pow(point2[1] - point1[1], 2));
    double bb = Math.Sqrt(Math.Pow(point3[0] - point1[0], 2) 
    + Math.Pow(point3[1] - point1[1], 2));
    if (aa < bb) secondPoint = point2;
    else secondPoint = point3;
}
else if (firstPoint == point2)
{
    double aa = Math.Sqrt(Math.Pow(point1[0] - point2[0], 2) 
    + Math.Pow(point1[1] - point2[1], 2));
    double bb = Math.Sqrt(Math.Pow(point3[0] - point2[0], 2) 
    + Math.Pow(point3[1] - point2[1], 2));
    if (aa < bb) secondPoint = point1;
    else secondPoint = point3;
}
else if (firstPoint == point3)
{
    double aa = Math.Sqrt(Math.Pow(point2[0] - point3[0], 2) 
    + Math.Pow(point2[1] - point3[1], 2));
    double bb = Math.Sqrt(Math.Pow(point1[0] - point3[0], 2) 
    + Math.Pow(point1[1] - point3[1], 2));
    if (aa < bb) secondPoint = point2;
    else secondPoint = point1;
}
 
if (point1 != firstPoint && point1 != secondPoint) thirdPoint = point1;
else if (point2 != firstPoint && point2 != secondPoint) thirdPoint = point2;
else if (point3 != firstPoint && point3 != secondPoint) thirdPoint = point3;

PrintArray(firstPoint); PrintArray(secondPoint); PrintArray(thirdPoint); 



