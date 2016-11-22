using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    /// <summary>
    /// کلاس پرسون با اتربیوت سرالایزبیل بمنظور کار با ایکس ام ال
    /// </summary>
	[Serializable]
	public class Person 
	{
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
		public Person()
		{

		}

        /// <summary>
        /// سازنده با دوورودی
        /// </summary>
        /// <param name="name"></param>
        /// <param name="family"></param>
		public Person(string name,string family)
		{
			this.Name = name;
			this.Family = family;

		}

        /// <summary>
        /// پراپرتی نام
        /// </summary>
		public string  Name { get; set; }

        /// <summary>
        /// پراپرتی فامیلی
        /// </summary>
		public string  Family { get; set; }

        /// <summary>
        /// متد اورراید تو استرینگ
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0}{1}",this.Name,this.Family);
		}

		
	}
}
