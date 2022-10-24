Console.WriteLine("Введите x1:");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y1:");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите x2:");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y2:");
double y2 = double.Parse(Console.ReadLine()!);

double[] interpoint = Findintersection(x1, y1, x2, y2);
Console.WriteLine($"{interpoint[0]} {interpoint[1]}");

double[] Findintersection(double x1, double y1, double x2, double y2)
{
    double [] intersection = new double[2];
    intersection [0] = (x2-x1)/(y1-y2);
    intersection [1] = y1*intersection[0]+x1;
    return intersection;
}