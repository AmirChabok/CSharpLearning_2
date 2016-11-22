using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    /// <summary>
    /// کلاس تلفن
    /// </summary>
	public class Phone_Person
	{
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
		public Phone_Person()
		{

		}

        /// <summary>
        /// سازند ه با دو ورودی
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="home"></param>
		public Phone_Person(string mobile,string home)
		{
			this.Mobile = mobile;
			this.Home = home;
		}

        /// <summary>
        /// فیلدهای پرایویت
        /// </summary>
		private string _mobile;
		private string _home;

        /// <summary>
        /// پراپرتی هیا پابلیک
        /// </summary>
		public string Mobile { get { return _mobile; } set { _mobile = value; } }
		public string Home { get { return _home; } set { _home = value; } }

        /// <summary>
        /// پراپرتی نمایش تلفن
        /// </summary>
		public string ShowPhone { get { return string.Format("Mpbile:{0}/Home:{1}", this.Mobile, this.Home); } }
	}
}
