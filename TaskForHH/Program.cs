using LibForTask;
try
{
    Console.WriteLine("Введите 3 стороны треугольника");
    double side1 = Convert.ToDouble(Console.ReadLine());
    double side2 = Convert.ToDouble(Console.ReadLine());
    double side3 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Введите радиус круга");
    double radius = Convert.ToDouble(Console.ReadLine());

    double result = 0;
    double result1 = 0;

    bool checker = Triangle.CheckerForTriangle(side1, side2, side3);

    if (checker == true)
    {
        result = Triangle.CheckerFor90(side1, side2, side3);
        Console.WriteLine($"Площадь треугольника: {result}");
    }
    else Console.WriteLine("Введены неверные стороны треугольника");
    result1 = Circle.Square(radius);

    Console.WriteLine($"Площадь круга {result1}");
}
catch(SystemException ex)
{
    Console.WriteLine(ex);
}



