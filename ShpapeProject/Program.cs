using shapeProject;


class shapes
{
    static void Main(string[] args)
    {

        Shape shape = new Shape();

        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine(" 1. print a trinagle");
            Console.WriteLine(" 2. print a square");
            Console.WriteLine(" 3. print dimond");
            Console.WriteLine(" 4. exit menu");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    shape.Print_Triangular();

                    break;
                case 2:
                    shape.print_Square();
                    break;
                case 3:
                    shape.print_dimond();

                    break;
                case 4:
                    Console.WriteLine("you done");
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }

        }
    }

}

