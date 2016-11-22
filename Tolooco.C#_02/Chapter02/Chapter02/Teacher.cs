using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    /// <summary>
    /// کلاس استاد که از پرسون اینهریت شده است
    /// </summary>
	class Teacher :Person
	{
        /// <summary>
        /// سازنده پیش فرض کلاس
        /// </summary>
		public Teacher()
		{

		}

        /// <summary>
        /// سازنده با  سه ورودی که نام و فامیل را از سازنده دوم پدر میگیرد
        /// </summary>
        /// <param name="name"></param>
        /// <param name="family"></param>
        /// <param name="tid"></param>
		public Teacher(string name,string family,int tid):base(name,family)
		{
			this.TID = tid;
		}

        /// <summary>
        /// پراپرتی آی دی
        /// </summary>
		public int TID { get; set; }


        /// <summary>
        /// متد اورراید تو استرینگ برای نمایش مشخصات اجزای کلاس
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{
			return string.Format("Name:{0}\r\n Family:{1}\r\n TID:{2}\r\n", this.Name, this.Family, this.TID); 
		}

        //پراپرتی اورراید استرینگ دیسپلی
		//public override string Display { get { return string.Format("Name:{0}\r\n{1}Family:\r\n TID:{2}\r\n",
		//	base.Name,base.Family,this.TID); } }

	}
}
