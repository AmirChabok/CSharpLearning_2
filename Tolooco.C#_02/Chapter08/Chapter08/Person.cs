using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
{
    /// <summary>
    /// کلاس پرسون که اینترفیس آی ایکواتیبل اینهریت شده است
    /// </summary>
	public class Person :IEquatable<Person>
	{
        /// <summary>
        ///سازنده پیش فرض کلاس
        /// </summary>
		public Person()
		{

		}

        /// <summary>
        /// سازنده با دو ورودی
        /// </summary>
        /// <param name="name"></param>
        /// <param name="family"></param>
		public Person(string name,string family)
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

        /// <summary>
        /// متد ایکوال از جنس بولین که از اینترفیس آی ایکوالتیبل پیاده سازی شده است
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
		public bool Equals(Person other)
		{
			if (this.Name==other.Name&&this.Family==other.Family)
			{
				return true;
				
			}
			else
				return false;
		}

        /// <summary>
        /// تعریف یک متد استاتیک برای معیار برابری
        /// </summary>
        /// <param name="pr_1"></param>
        /// <param name="pr_2"></param>
        /// <returns></returns>
		public static bool operator ==(Person pr_1, Person pr_2)
		{
			return pr_1.Equals(pr_2);
		}

        /// <summary>
        /// تعریف یک متد استاتیک برای معیار نابرابری
        /// </summary>
        /// <param name="pr_1"></param>
        /// <param name="pr_2"></param>
        /// <returns></returns>
		public static bool operator !=(Person pr_1, Person pr_2)
		{
			return pr_1.Equals(pr_2);
		}
	}
}
