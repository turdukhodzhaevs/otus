namespace QuadraticEquation;

public static class QuadraticEquationService
{
    public static double[] Solve(double a, double b, double c)
    {
        if (double.IsNaN(a) || double.IsNaN(b) || double.IsNaN(c))
        {
            throw new ArgumentException("Аргумент не является числом");
        }

        if (double.IsInfinity(a) || double.IsInfinity(b) || double.IsInfinity(c))
        {
            throw new ArgumentException("Аргумент является бесконечностью");
        }

        if (Math.Abs(a) < double.Epsilon)
        {
            throw new ArgumentException("Коэффициент a не может быть равен 0", "a");
        }

        var discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            return Array.Empty<double>(); // корней нет
        }

        if (Math.Abs(discriminant) < double.Epsilon)
        {
            return new[] { -b / (2 * a) }; // один корень
        }

        var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        return new[] { x1, x2 }; // два корня
    }
}