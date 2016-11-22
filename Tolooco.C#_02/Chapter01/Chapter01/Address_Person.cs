using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    /// <summary>
    /// Class Address
    /// </summary>
	public class Address_Person
	{
        /// <summary>
        /// Default Constracture
        /// </summary>
		public Address_Person()
		{

		}

        /// <summary>
        /// سازنده با دو ورودی
        /// </summary>
        /// <param name="address"></param>
        /// <param name="id"></param>
		public Address_Person(string address,int id)
		{
			this.Address = address;
			this.ID = id;
		}

        /// <summary>
        /// فیلد های پرایویت
        /// </summary>
		private string _address;
		private int _id;

        /// <summary>
        /// پراپرتی های پابلیک
        /// </summary>
		public string Address { get { return _address; } set { _address = value; } }
		public int ID { get { return _id; } set { _id = value; } }


        /// <summary>
        /// پراپرتی نمایش آدرس
        /// </summary>
		public string ShowAddress { get { return string.Format("Address:{0}/ID:{1}",this.Address,this.ID); } }
	}
}
