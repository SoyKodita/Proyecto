namespace Application;

public class Rectangulo
{
    public static double Perimetro(double @base, double altura)
    {
        double perimetro = 2 * (@base + altura);
        return perimetro;
    }
    public static double Area(double @base, double altura)
    {
        double area = @base * altura;
        return area;
    }
}