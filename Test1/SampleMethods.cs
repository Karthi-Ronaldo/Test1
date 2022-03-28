using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class SampleMethods
    {
        public static void MoveFiles()
        {
            Directory.Delete(@"D:\TestCMD\Out\Output");
            Directory.Move(@"D:\TestCMD\Fol2", @"D:\TestCMD\Out\Output");
        }

        public static void FileOperations()
        {
            string file = @"C:\Test\Dir2\Dir3\Test.docx";
            string dir = Path.GetDirectoryName(file);
            Console.WriteLine(dir);
        }
        #region Generic
        //public static bool AddTwoValue<T>(T val1,T val2)
        //{
        //    if (char.IsNumber((val1))
        //    {
        //        return true;
        //    }
            
        //}
        #endregion
        #region StringBuilder
        public static void stringConcat()
        {
            string[] str = { "one ", "two ", "three ", "four " };
            string strCollec = string.Empty;
            foreach (var item in str)
            {
                strCollec += item;
            }
            Console.WriteLine(strCollec);
        }

        public static void stringBuild()
        {
            string[] str = { "one ", "two ", "three ", "four " };
            string strCollec = string.Empty;
            StringBuilder bld = new StringBuilder();
            foreach (var item in str)
            {
                bld.Append(item);
            }
            strCollec = bld.ToString();
            Console.WriteLine(strCollec);
        }
        #endregion

        #region MyRegion
        public static void SampleException()
        {
            try
            {
                int x = 0;
                var num = (10 / x);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Tuples
        public static Tuple<int, string, string, string> GetStudentDetails()
        {
            int rollNo = 7;
            string name = "Tom";
            string email = "tom007@gmail.com";
            string city = "Erode";

            return Tuple.Create(rollNo, name, email, city);
        }
        #endregion

        #region Yield
        public static List<int> GetNumGreatenthan_10()
        {
            List<int> numbers = new List<int>() { 1, 2, 30, 40, 50, 5, 6, 7 };
            List<int> temp = new List<int>();
            foreach (var item in numbers)
            {
                if (item > 10)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }
        public static IEnumerable<int> GetNumMorethan_10()
        {
            List<int> numbers = new List<int>() { 1, 2, 30, 40, 50, 5, 6, 7 };
            foreach (var item in numbers)
            {
                if (item > 10)
                {
                    yield return item;
                }
            }
        }
        #endregion

        #region LINQ to List
        public static void linqQuery()
        {
            List<int> numbers = new List<int>() { 1, 2, 30, 40, 50, 5, 6, 7 };
            var result = numbers.Where(i => i > 10);

            long startLinq = Stopwatch.GetTimestamp();
            Console.WriteLine(result.Count());
            Console.WriteLine(result.Average());
            long endLinq = Stopwatch.GetTimestamp();
            Console.WriteLine("LINQ Time consuming : {0} Ticks" , (endLinq - startLinq));
        }
        public static void LinqToList()
        {
            List<int> numbers = new List<int>() { 1, 2, 30, 40, 50, 5, 6, 7 };
            var result = numbers.Where(i => i > 10).ToList();

            long startLinq = Stopwatch.GetTimestamp();
            Console.WriteLine(result.Count());
            Console.WriteLine(result.Average());
            long endLinq = Stopwatch.GetTimestamp();
            Console.WriteLine("LinqToList Time consuming : {0} Ticks" , (endLinq - startLinq));
        }
        #endregion

        #region Flags
        //public static void FlagsExample()
        //{
        //    int animals = 17;
        //    Console.WriteLine(((Lives)animals).ToString());
        //}
        //[Flags]
        //public enum Lives { Dog = 4, Cat = 6, Cow = 7, Peacock = 15, Dove = 20 };
        #endregion
    }
}
