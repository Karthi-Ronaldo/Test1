using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    static class IDMA
    {
        public static void GetDirecWithSubDirec()
        {
            var list = Directory.GetDirectories("D:\\TestCMD", "*.*",SearchOption.AllDirectories);
            var fileList = Directory.GetFiles("D:\\TestCMD", "*.*", SearchOption.AllDirectories);
            //foreach (var item in list)
            //{
            //    //File.Move(f.FullName, f.FullName.Replace("abc_", ""));
            //    //Directory.
            //    //var temp = item.Replace("TestCMD", "TestCMDIn");
            //    //File.Move(item, temp.ToUpper());
            //    var dest = item.Replace("TestCMD", "TestCMDConvert");
            //    Directory.CreateDirectory(dest.ToUpper());
            //}

            foreach (var item in fileList)
            {
                //var dest = item.Replace("TestCMD", "TestCMDConvert");
                //File.Copy(item, dest.ToUpper());
                FindLowerCase(item);
            }
        }

        public static void FindLowerCase(string path)
        {
            TextWriter wrt = new StreamWriter(@"D:\Learnings\Lower.csv");
            string fileName = Path.GetFileName(path);
            if (fileName.Any(char.IsLower))
            {
                wrt.WriteLine(path);
            }
            wrt.Close();
        }

        public static void DiffPath()
        {
            string[] Foo_New = { "one", "two", "three" }, Foo_Old = { "one", "three", "four" }; 
            var diff = Foo_New.Except(Foo_Old);
        }
    }
}
