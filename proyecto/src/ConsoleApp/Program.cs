double @base = 5;
double altura = 10;
double alturaPrisma = 15;

double perimetro = Application.Rectangulo.Perimetro(@base, altura);
double area = Application.Rectangulo.Area(@base, altura);
double volumen = Application.PrismaRectangular.Volumen(@base, altura, alturaPrisma);

Console.WriteLine($"El perímetro de la base de un Prisma Rectangular de {@base}cm de base y {altura}cm de altura es {perimetro}cm");
Console.WriteLine($"El área de la base de un Prisma Rectangular de {@base}cm por {altura}cm es {area}cm2");
Console.WriteLine($"El volumen de un Prisma Rectangular con un área de la base de {area}cm2 y {alturaPrisma}cm de altura es {volumen}cm3");
