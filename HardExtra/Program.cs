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

void FillArray(int[] col)
{
    int len = col.Length;
    for (int i = 0; i<len; i++)
    {
        col[i] = new Random().Next(1, 100);
    }
}

//Задача1
// int[] point1 = CreatePoint(); 
// int[] point2 = CreatePoint(); 
// int[] point3 = CreatePoint();

// PrintArray(point1); PrintArray(point2); PrintArray(point3);

// double dist1 = Math.Sqrt(Math.Pow(point1[0], 2) + Math.Pow(point1[1], 2));
// double dist2 = Math.Sqrt(Math.Pow(point2[0], 2) + Math.Pow(point2[1], 2));
// double dist3 = Math.Sqrt(Math.Pow(point3[0], 2) + Math.Pow(point3[1], 2));
    
// Console.WriteLine($"Dist1:{dist1} Dist2:{dist2} Dist3:{dist3}");

// int[] firstPoint = point1;
// int[] secondPoint = point2;
// int[] thirdPoint = point3;


// if (dist2 < dist1 && dist2 < dist3) firstPoint = point2;
// else if (dist3 < dist2) firstPoint = point3;


// if (firstPoint == point1)
// {
//     double aa = Math.Sqrt(Math.Pow(point2[0] - point1[0], 2) 
//     + Math.Pow(point2[1] - point1[1], 2));
//     double bb = Math.Sqrt(Math.Pow(point3[0] - point1[0], 2) 
//     + Math.Pow(point3[1] - point1[1], 2));
//     if (aa < bb) secondPoint = point2;
//     else secondPoint = point3;
// }
// else if (firstPoint == point2)
// {
//     double aa = Math.Sqrt(Math.Pow(point1[0] - point2[0], 2) 
//     + Math.Pow(point1[1] - point2[1], 2));
//     double bb = Math.Sqrt(Math.Pow(point3[0] - point2[0], 2) 
//     + Math.Pow(point3[1] - point2[1], 2));
//     if (aa < bb) secondPoint = point1;
//     else secondPoint = point3;
// }
// else if (firstPoint == point3)
// {
//     double aa = Math.Sqrt(Math.Pow(point2[0] - point3[0], 2) 
//     + Math.Pow(point2[1] - point3[1], 2));
//     double bb = Math.Sqrt(Math.Pow(point1[0] - point3[0], 2) 
//     + Math.Pow(point1[1] - point3[1], 2));
//     if (aa < bb) secondPoint = point2;
//     else secondPoint = point1;
// }
 
// if (point1 != firstPoint && point1 != secondPoint) thirdPoint = point1;
// else if (point2 != firstPoint && point2 != secondPoint) thirdPoint = point2;
// else if (point3 != firstPoint && point3 != secondPoint) thirdPoint = point3;

// PrintArray(firstPoint); PrintArray(secondPoint); PrintArray(thirdPoint); 


//Задача 2 + 3
// int[] a = {7,3};   //CreatePoint();
// int[] b = {4,-3};   //CreatePoint();
// int[] c = {7,-3};   //CreatePoint();
// int[] d = {3,4};   //CreatePoint();

// PrintArray(a); PrintArray(b); PrintArray(c); PrintArray(d);

// double v1 = (c[0] - d[0]) * (c[1] - a[1]) - (c[0] - a[0]) * (c[1] - d[1]);
// double v2 = (c[0] - d[0]) * (c[1] - b[1]) - (c[0] - b[0]) * (c[1] - d[1]);
// double v3 = (b[0] - a[0]) * (b[1] - d[1]) - (b[0] - d[0]) * (b[1] - a[1]);
// double v4 = (b[0] - a[0]) * (b[1] - c[1]) - (b[0] - c[0]) * (b[1] - a[1]);
// Console.WriteLine($"v1:{v1} v2:{v2} v3:{v3} v4:{v4}");

// double x = 0;
// double y = 0;
// if (v1 * v2 < 0 && v3 * v4 < 0) 
// {
//     Console.WriteLine("Отрезки пересекаются");
//     x = d[0] + (c[0] - d[0]) * Math.Abs(v3)/ Math.Abs(v4 - v3);
//     y = d[1] + (c[1] - d[1]) * Math.Abs(v3)/ Math.Abs(v4 - v3);
//     Console.WriteLine($"x = {x} y = {y}");
// }
// else Console.WriteLine("Отрезки не пересекаются");

// if (x>0 && y>0) Console.WriteLine("First quater");
// else if (x<0 && y>0) Console.WriteLine("Second quater");
// else if (x>0 && y<0) Console.WriteLine("Fours quater");
// else if (x<0 && y<0) Console.WriteLine("Third quater");
// else Console.WriteLine("No intersection");


//Задача4
void FillTemp(int[] col)
{
    for (int i = 0; i<120;)
    {

        for (int w = 0; w < 3; w++)
        {
            col[i] = new Random().Next(-30, 5);
            i++;
        }
        for (int s = 0; s < 3; s++)
        {
            col[i] = new Random().Next(-5, 15);
            i++;
        }
        for (int u = 0; u < 3; u++)
        {
            col[i] = new Random().Next(15, 35);
            i++;
        }
        for (int a = 0; a < 3; a++)
        {
            col[i] = new Random().Next(5, 20);
            i++;
        }
    }
}
int[] arr = new int[120];
FillTemp(arr);
PrintArray(arr);

Console.WriteLine(arr.Min());
Console.WriteLine(arr.Max());

Console.Write("Please enter start year from 2010 - 2020: ");
int startYear = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter end year from 2010 - 2020: ");
int endYear = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter month: ");
int month = Convert.ToInt32(Console.ReadLine());

int startIndex = startYear % 10 * 12 + month;
int endIndex = startIndex + ((endYear - startYear) * 12);

Console.WriteLine(startIndex);
Console.WriteLine(endIndex);

int[] winter = new int[(endYear - startYear) * 12 / 4];
int[] spring = new int[(endYear - startYear) * 12 / 4];
int[] summer = new int[(endYear - startYear) * 12 / 4];
int[] autumn = new int[(endYear - startYear) * 12 / 4];

int i = startIndex;
int w = 0;
int s = 0;
int u = 0;
int a = 0;

for (i = startIndex; i < endIndex; i++)
{
    int check = i - (i /12) * 12;
   
    if (check == 1 || check == 2 || check == 0) 
    {
        winter[w] = arr[i]; w++;
    }
    else if (check == 3 || check == 4 || check == 5) 
    {
        spring[s] = arr[i]; s++;
    }
    else if (check == 6 || check == 7 || check == 8) 
    {
        summer[u] = arr[i]; u++;
    }
    else
    {
        autumn[a] = arr[i]; a++;
    }
    
}
Console.WriteLine($"Winter temperature Max: {winter.Max()} Min: {winter.Min()}");
Console.WriteLine($"Spring temperature Max: {spring.Max()} Min: {spring.Min()}");
Console.WriteLine($"Summer temperature Max: {summer.Max()} Min: {summer.Min()}");
Console.WriteLine($"Autumn temperature Max: {autumn.Max()} Min: {autumn.Min()}");




//Задача5
// Console.WriteLine("Enter number > 4:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 4) Console.WriteLine("Incorrect number");

// string[] letters = {"a", "b", "c", "d", "e", "f", "g", "h", "j", "k", "l", "m",
// "n", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
// string[] digits = {"2", "3", "4", "5", "6", "7", "8", "9"};
// string[] symbols = {"#", "@", "%", "&"};
// string password = string.Empty;
// Random rand = new Random();

// for (int i = 0; i < number;)
// {
//     password += digits[rand.Next(0, 8)];
//     i ++;
//     if (i == number) break;

//     password += symbols[rand.Next(0, 4)];
//     i ++;
//     if (i == number) break;

//     password += letters[rand.Next(0, 24)];
//     i ++;
//     if (i == number) break;
// }

// Console.WriteLine(password);


 //Задача6

// int[] point = CreatePoint();
// double katetA = point[0];
// double katetB = point[1];
// Console.WriteLine($"katetA = {katetA} katetB = {katetB}");

// double rad = Math.Atan(katetB / katetA);
// double angleB = rad * (180/Math.PI);
// double angleA = 90 - angleB;
// Console.WriteLine($"angleA = {angleA} angleB = {angleB}");


//Задача7
// int[] array = new int[99];
// FillArray(array);
// int count = 0;
// int[] newArray = new int[array.Length];
// int j = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == 3 | array[i]/10 == 3 | array[i]%10 == 3) count++;
//     else 
//     {
//         newArray[j] = array[i]; 
//         j++;
//     }
// }
// Console.WriteLine($"Count: {count}");
// PrintArray(newArray);


//Задача8
// Random rand = new Random();
// int n = rand.Next(2, 20);

// for (int i = 1; i<n; i++)
// {
//     for (int j = 1; j<n; j++) Console.WriteLine($"{i}x{j} = {i*j}");
//     Console.WriteLine();
// }

//Задача9

// for (int result = 1; result < 1000;)
// {
//     Console.WriteLine("First player enter number from 2 to 9:");
//     int number = Convert.ToInt32(Console.ReadLine());
//     result = number * result;

//     if (result > 1000)
//     {
//         Console.WriteLine("First player win!!!"); 
//         break;
//     }

//     Console.WriteLine($"Currently result: {result}");

//     Console.WriteLine("Second player enter number from 2 to 9:");
//     int number2 = Convert.ToInt32(Console.ReadLine());

//     for (int res = result; result < res * number2;)
//     {
//         result = res * number2;
//         if (result > 1000)
//         {
//             Console.WriteLine("Second player win!!!"); 
//             break;
//         }
//         Console.WriteLine($"Currently result: {result}");
//     }
// }
