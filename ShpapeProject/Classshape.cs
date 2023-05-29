namespace shapeProject
{
    public class Shape
    {
        int baseTriangular = 0;
        int NumberSquare = 0;
        int daimondBase = 0;
        //constractor
        public Shape()
        {
            baseTriangular = 0;//base of triangle 
            daimondBase = 0;
            NumberSquare = 0;// the length of the square
        }



        public void Print_Triangular()
        {
            Console.WriteLine("enter the base of shape you want");
            int baseTriangular = int.Parse(Console.ReadLine());
            string LatterTriangular = "*";
            if (baseTriangular > 3 && baseTriangular < 10)
            {
                for (int i = 0; i < baseTriangular; i++)
                {
                    for (int j = baseTriangular - i; j >= 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(LatterTriangular);
                    LatterTriangular += "**";

                }
            }
            else
            {
                Console.WriteLine("low or high number ");

            }
        }

        //print square
        public void print_Square()
        {
            Console.WriteLine("enter the base of shape you want");
            int NumberSquare = int.Parse(Console.ReadLine());
            if (NumberSquare > 3 && NumberSquare < 10)
            {
                for (int k = 0; k < NumberSquare; k++)
                {
                    for (int s = 0; s < NumberSquare; s++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("low or high number ");

            }

        }
        //print dimond 
        public void print_dimond()
        {
            Console.WriteLine("enter the base of shape you want");
            int diamondBase = int.Parse(Console.ReadLine());
            string diamondLine = "*";
            if (diamondBase > 3 && diamondBase < 10)
            {
                for (int i = 0; i < diamondBase; i++)
                {
                    for (int j = diamondBase - i; j >= 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(diamondLine);
                    diamondLine += "**";
                }

                for (int i = diamondBase - 1; i >= 0; i--)
                {
                    for (int j = diamondBase - i; j >= 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(diamondLine.Substring(0, diamondLine.Length - 2));
                    diamondLine = diamondLine.Substring(0, diamondLine.Length - 2);

                }
            }
            else
            {
                Console.WriteLine("low or high number ");

            }

        }
    }

}