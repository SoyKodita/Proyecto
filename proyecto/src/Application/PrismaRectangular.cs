namespace Application;

public class PrismaRectangular
{
    
    public static double Volumen(double @base, double altura, double alturaPrisma)
    {
        double areaBase = @base * altura;
        double volumen = @base * altura * alturaPrisma;
        return volumen;
    }
}