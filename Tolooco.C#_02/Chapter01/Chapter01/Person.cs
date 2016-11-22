using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{//بدنه کلاس پرسون
	class Person
	{
		
		/// <summary>
		/// تعریف سازنده پیش فرض کلاس پرسون
		/// </summary>
		public Person()
		{
			
		}
		/// <summary>
		/// تعریف سازنده با دو ورودی نام و فامیل 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="family"></param>
		public Person(string name,string family)
		{
			this.Name = name;
			this.Family = family;
		}
		/// <summary>
		/// تعریف سازنده با چهار ورودی نام و فامیل و کلاس آدرس و کلاس تلفن
		/// </summary>
		/// <param name="name"></param>
		/// <param name="family"></param>
		/// <param name="personaddress"></param>
		/// <param name="personphone"></param>
		public Person(string name,string family,Address_Person personaddress,Phone_Person personphone):this(name,family)
		{
			this.PersonAddress = personaddress;
			this.PersonPhone = personphone;
		}
	
		/// <summary>
		/// تعریف فیلد های پرایویت کلاس پرسون
		/// </summary>
	  private string _name;
	  private string _family;
	  private Address_Person _personaddress;
	  private  Phone_Person _personphone;
	
	/// <summary>
	/// تعریف پراپرتی های پابلیک کلاس پرسون
	/// </summary>
	  public string Name { get { return _name; } set { _name = value; } }
	  public string Family { get { return _family; } set { _family = value; } }
	  public Address_Person PersonAddress { get { return _personaddress; } set { _personaddress = value; } }
	  public Phone_Person PersonPhone { get { return _personphone; } set { _personphone = value; } }

	 /// <summary>
	 /// تعریف پراپرتی نمایش مشخصات شخص
	 /// </summary>
	  public string ShowInfo { get { return string.Format("Name:{0}Family:{1}",this.Name,this.Family); } }
	}
}
