namespace tes2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            Console.WriteLine("Map size");
            int.TryParse(Console.ReadLine(), out int taille);
            Console.WriteLine("Speed");
            int.TryParse(Console.ReadLine(), out int vitesse);
            Console.WriteLine("WASD to move");
            Thread.Sleep(500);
            Console.Clear();
            string[,] tableau2d = new string[taille, taille];
            for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille; j++)
                {
                    tableau2d[i, j] = ".";
                }
                Console.WriteLine();
            }
            tableau2d[0, 0] = "@";
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < taille; i++)
                {
                    for (int j = 0; j < taille; j++)
                    {
                        Console.Write(tableau2d[i, j]);
                    }
                    Console.WriteLine();
                }
                char dir = Console.ReadKey().KeyChar;
                if (dir == 'd' || dir == 'd')
                {
                    tableau2d[y, x] = ".";
                    x = x + vitesse;
                    tableau2d[y, x] = "@";
                }
                else if (dir == 'a')
                {
                    tableau2d[y, x] = ".";
                    x = x - vitesse;
                    tableau2d[y, x] = "@";
                }
                else if (dir == 's')
                {
                    tableau2d[y, x] = ".";
                    y = y + vitesse;
                    tableau2d[y, x] = "@";
                }
                else if (dir == 'w')
                {
                    tableau2d[y, x] = ".";
                    y = y - vitesse;
                    tableau2d[y, x] = "@";
                }
                else if (dir == 'q')
                {
                    tableau2d[y, x] = ".";
                    y = y - vitesse;
                    x = x - vitesse;
                    tableau2d[y, x] = "@";
                }
                else if (dir == 'e')
                {
                    tableau2d[y, x] = ".";
                    y = y - vitesse;
                    x = x + vitesse;
                    tableau2d[y, x] = "@";
                }
                else if (dir == 'z')
                {
                    tableau2d[y, x] = ".";
                    y = y + vitesse;
                    x = x - vitesse;
                    tableau2d[y, x] = "@";
                }
                else if (dir == 'c')
                {
                    tableau2d[y, x] = ".";
                    y = y + vitesse;
                    x = x + vitesse;
                    tableau2d[y, x] = "@";
                }
            }
        }
    }
}
