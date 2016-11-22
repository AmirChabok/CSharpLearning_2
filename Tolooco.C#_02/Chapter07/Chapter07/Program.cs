using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
	class Program
	{
		static void Main(string[] args)
		{
            //ایجاد یک شی از افراد
			Persons List = new Persons();

            //افزودن افراد
			List.Add(new Person("Hosein", "Sadeghi"));
			List.Add(new Person("Ali", "Jahanshir"));
			List.Add(new Person("Amir", "Chabok"));

			//foreach (Person P in List)
			//{
			//	Console.WriteLine(P);
			//}

            //نمایش افراد
			Console.WriteLine(Tools.Generator(List));

			Console.ReadKey();
		}
	}
}
