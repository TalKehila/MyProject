

using Project_number_4;

class program
{
    static void Main()
    {
        string type = " ";
       Vehicle[] myvehicles= new Vehicle[4];
 
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("wihch of vehicle you want for  car press 1 , for boat 2 , for truck 3 ");
            int choiceCarorBoat = int.Parse(Console.ReadLine());
            if (choiceCarorBoat == 1)
            {
                type= " car";
                myvehicles[i] = new car(type);
            }
            else if (choiceCarorBoat == 2)
            {
                type = "boat";
                myvehicles[i] = new boat(type);
            }
            else if (choiceCarorBoat == 3)
            {
                type = "truck";
                myvehicles[i] = new Truck(type);
            }
           
            else if (choiceCarorBoat != 1 || choiceCarorBoat != 2 || choiceCarorBoat != 3)
            {
                Console.WriteLine("worng choice next time press 1 for car and 2 for boat ");
            }  
            

        }
        for (int i = 0; i < myvehicles.Length; i++)
        {
            
            Console.WriteLine( $"your vehivle  is {type} : " + myvehicles[i]);
        }
    }

}


