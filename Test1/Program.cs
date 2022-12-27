using Calculation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Test1.Class;

namespace Test1
{
    class Program
    {
        class Details
        {
            public string Name { get; set; }
            public string age { get; set; }
        }
        static void Main(string[] args)
        {
            Test1
                Test 2
                12345
            #region MongoDBDemo
            //MongoDBService2.Create();
            //MongoDBService2.Update();
            MongoDBService2.Delete();
            #endregion

            #region AdvanceConcepts
            //AdvanceConcepts.DemoGenerics();
            //AdvanceConcepts.DemoDelegate();
            #endregion

            #region PolyMorphism
            //Vehicle car = new Car();
            //Vehicle bus = new Bus();
            //Flight flight = new Flight();

            //car.Run();
            //bus.Run();
            //flight.Run();
            #endregion

            #region MoveFiles
            //SampleMethods.MoveFiles();

            //SampleMethods.FileOperations();
            //var res = SampleMethods.AddTwoValue<string>("5", "6");
            //Console.WriteLine(res);
            //IDMA.GetDirecWithSubDirec();
            #endregion

            #region MongoDB
            //MongoDbService.MongoServices();
            #endregion

            #region Lambda
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<Details> obj = new List<Details>() { 
            //new Details{Name = "Karthi", age ="18"},
            //new Details{Name = "Dinesh",age="22"},
            //new Details{Name = "Bala",age="21"},
            //new Details{Name = "Manoj",age="23"}
            //};

            //List<int> evenNum = numbers.FindAll(x => (x % 2) == 0); //Lambda expression

            //var names = obj.Select(x => (x.Name + " => " + x.age));
            ////names.Sort();
            //var sortNames = obj.OrderByDescending(x => x.Name);

            //Console.WriteLine("Names with age :");
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Test_Reference_DLL
            //Calculate cal = new Calculate();

            //int a = 35, b = 20;

            //int addition = cal.Add(a, b);
            //int subraction = cal.Sub(a, b);
            //int multiplication = cal.Mul(a, b);
            //float division = cal.Div(a, b);

            //Console.WriteLine(addition + "\n" + subraction + "\n" + multiplication + "\n" + division);
            #endregion

            #region StrBuilder
            //SampleMethods.stringConcat();
            //SampleMethods.stringBuild();
            #endregion

            #region Excep
            //try
            //{
            //    SampleMethods.SampleException();
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            #endregion

            #region Tuples
            //var student = SampleMethods.GetStudentDetails();
            //Console.WriteLine(student.Item1 + " " + student.Item2 + " " + student.Item3 + " " + student.Item4);
            #endregion

            #region Yield
            //Console.WriteLine("---- Normal List ----- ");
            //var num = SampleMethods.GetNumGreatenthan_10();
            //foreach (var item in num)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---- Yield ----- ");
            //var number = SampleMethods.GetNumMorethan_10();
            //foreach (var item in number)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region LINQ to List
            //SampleMethods.linqQuery();
            //SampleMethods.LinqToList();
            #endregion

            #region Flags
            //SampleMethods.FlagsExample();
            #endregion

            Console.ReadLine();
        }
    }
}
