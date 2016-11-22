using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Chapter10
{
    /// <summary>
    /// 21 March 2014
    /// Version 1.1.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    /// <summary>
    /// کلاس پروگرام
    /// </summary>
	class Program
	{
        /// <summary>
        /// متد استاتیک مین
        /// </summary>
        /// <param name="args"></param>
		static void Main(string[] args)
		{
            
			//Person Person_1 = new Person("Sara", "Mohamadi");

			//XmlSerializer xmlSer = new XmlSerializer(typeof(Person));

			//StreamWriter SWriter_1 = new StreamWriter("C:\\MyXmlFile.xml");

			//xmlSer.Serialize(SWriter_1, Person_1);
			//////////////////////////////////////////////////////

            //ایجاد یک آرایه از افراد
			Persons List = new Persons();
            //مقدار دهی خانه های آرایه
			//List.Add(new Person("Amir", "Chabok"));
			//List.Add(new Person("Hosein", "Sadeghi"));
            //افزودن پرسون به آرایه
			List.Add(new Person("Ali", "Jahanshiri"));
			List.Add(new Person("Reza", "Sadeghi"));
			List.Add(new Person("Mohamad", "Alavi"));
			//List.Add(new Person("Pedram", "Mohammadi"));

			List.Add(new Person ("Maryam","Mortazavi"));
			List.Add(new Person("Maryam", "Mortazavi"));

            //ذخیره در فایل ایکس ام ال
			List.Save(@"C:\PersonsList.xml");

            //فراخوانی از فایل ایکس ام ال
			List.Load("C:\\PersonsList.xml");


            //نمایش آرایه
			Console.WriteLine(List);

            //منتظر کلیدی از صفحه کلید
			Console.ReadKey();



		



			

		}
	}
}
