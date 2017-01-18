using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace housesexample
{
    class Program
    {
        static void Main(string[] args)
        {

            House house1 = new House("Green", 4, 1000, 3);
            House house2 = new House("Blue", 700);
            House house3 = new House();

            //house1.Paint("Green");
            //house1.NumberofRooms(4);
            //house1.SetSize(1000);
            //house1.NUmberofDoors(3);
            house2.Paint("Yellow");


            // House house3 = new House("Pink", 7, 7000, 7);
            house1.DisplayHouseInfo();
           // house2.DisplayHouseInfo();
            house3.DisplayHouseInfo();
            house2.Name = "The blue house";
            Console.WriteLine(house2.Name);


            


           
            
        }
    }
}
