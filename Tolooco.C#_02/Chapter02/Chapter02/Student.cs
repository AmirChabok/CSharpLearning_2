using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    /// <summary>
    /// کلاس دانشجو اینهریت شده از کلاس پرسون
    /// </summary>
	class Student : Person
	{
        /// <summary>
        /// سازنده پیش فرض کلاس 
        /// </summary>
		public Student()
		{

		}

        /// <summary>
        /// سازنده با دو ورودی
        /// </summary>
        /// <param name="name"></param>
        /// <param name="family"></param>
        /// <param name="id"></param>
		public Student(string name,string family,int id):base(name,family)
		{
			this.ID = id;
		}

        /// <summary>
        /// پراپرتی آی دی
        /// </summary>
		public int ID { get; set; }

        /// <summary>
        /// متد اورراید نمایش مشخصات
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{
			return string.Format("Name:{0}\r\n Family:{1}\r\n ID:{2}\r\n", this.Name, this.Family,this.ID); 
		}

        //پراپرتی اورراید شده دسپلی
		//public override string Display { get { return string.Format("Name:{0}\r\n Family:{1}\r\n ID:{2}\r\n"
		//	,base.Name,base.Family,this.ID); } }
	}
}
