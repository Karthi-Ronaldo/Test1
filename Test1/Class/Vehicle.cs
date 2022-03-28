using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Class
{
    public interface Machines 
    {
        void Run();
    }
    public interface Vehicle : Machines
    {
        void Run();
    }

    public class Car : Vehicle
    {
        private int speed = 200, peopleCount = 4;
        public virtual void Run()
        {
            Console.WriteLine($"Top speed : {speed}, People capacity: {peopleCount}");
        }
}

    public class Bus : Car
    {
        private int speed = 140, peopleCount = 70;
        public new void Run()
        {
            Console.WriteLine($"Top speed : {speed}, People capacity: {peopleCount}");
        }
    }

    public class Flight : Bus
    {
        private int speed = 1500, peopleCount = 400;
        public new void Run()
        {
            Console.WriteLine($"Top speed : {speed}, People capacity: {peopleCount}");
        }
    }
}
