using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    /// <summary>
    /// کلاس مدیر
    /// </summary>
	class Manager
	{
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
		public Manager()
		{

		}

        /// <summary>
        /// سازنده با دو ورودی
        /// </summary>
        /// <param name="name"></param>
        /// <param name="family"></param>
		public Manager(string name,string family)
		{
			this.Name = name;
			this.Family = family;
		}

        /// <summary>
        /// پراپرتی های کلاس
        /// </summary>
		public string  Name { get; set; }
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
