using System;
namespace Collections
{
    class Program
    {


        static void Main(string[] args)
        {
            //creating Collections and Array
            var dogs = new List<string>();
            dogs.Add("Bulldog");
            dogs.Add("Collie");
            dogs.Add("German Shepherd");
            dogs.Add("Chiuaua");
            dogs.Add("Greyhound");
            dogs.Add("Pit bull");

            dogs.Remove("Collie");
            dogs.Add("German Shepherd");

            //foreach to move throughout the list of dogs
            foreach (var dog in dogs)
                Console.WriteLine(dog+ "");
            Console.ReadLine();

            dogs.Remove("Collie");
           










        }



    }



}
