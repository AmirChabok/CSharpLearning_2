using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter09
{
    /// <summary>
    /// 21 March 2014
    /// Version 1.1.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			#region FileInfo
            //حلقه فور ایچ و دریافت خصوصیات فایل های موجود در درایو دی
            //foreach (string FileName in Directory.GetFiles(@"D:\"))
            //{
            //    FileInfo FileInfo_1 = new FileInfo(FileName);
            //    Console.WriteLine(FileInfo_1.Extension);
            //}

            //حلقه فور ایچ و کار با دایرکتوریها
            //foreach (string Directory_1 in Directory.GetDirectories(@"E:\"))
            //{
            //    DirectoryInfo DirectoryInfo_1 = new DirectoryInfo(Directory_1);

            //    Console.WriteLine(DirectoryInfo_1.GetDirectories());
            //}
			#endregion

            // ایجاد یک شی از استریم رایتر و نوشتن در فایل
            StreamWriter SWriter_1 = new StreamWriter(@"D:\Test.txt");
            SWriter_1.WriteLine("Hello World !");
            SWriter_1.WriteLine("Salam . . . !");

            SWriter_1.Close();
            SWriter_1.Dispose();

            //ایجاد یک شی از استریم ریدر و خواندن از فایل
            StreamReader SReader_1 = new StreamReader(@"D:\Test.txt");
            while (!SReader_1.EndOfStream)
            {
                Console.WriteLine(SReader_1.ReadToEnd());
            }

			Console.ReadKey();
		}
	}
}
