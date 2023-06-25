// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] arrayX = new int[2];
int[] arrayY = new int[2];
int[] arrayZ = new int[2];

Console.WriteLine("Введите координату X первой точки.");
arrayX[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки.");
arrayY[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z первой точки.");
arrayZ[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки.");
arrayX[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки.");
arrayY[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z второй точки.");
arrayZ[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow((arrayX[1] - arrayX[0]), 2) + Math.Pow((arrayY[1] - arrayY[0]), 2) + Math.Pow((arrayZ[1] - arrayZ[0]), 2)));