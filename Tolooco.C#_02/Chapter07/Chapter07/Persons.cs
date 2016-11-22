using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Chapter07
{
    /// <summary>
    /// کلاس افراد که دو قوانین اینترفیس آی آینام ریبل و آی اینام ریتور را میپذیرد
    /// </summary>
	class Persons :IEnumerable,IEnumerator
	{
        /// <summary>
        /// ایجاد یک آرایه داخلی از پرسون
        /// </summary>
		private Person[] InnerList;

		#region Ctor

        /// <summary>
        /// سازنده پیش فرض کلاس
        /// </summary>
		public Persons()
		{
            //در این سازنده یک آرایه از پرسون در نظر گرفته میشود
			InnerList = new Person[0];
		}

        /// <summary>
        /// سازنده دوم با ورودی تعداد پرسون ها
        /// </summary>
        /// <param name="PersonCount"></param>
		public Persons(int PersonCount)
		{
            
			InnerList = new Person[PersonCount];
		}

		#endregion

        /// <summary>
        /// متد افزودن پرسون
        /// </summary>
        /// <param name="value"></param>
		public void Add(Person value)
		{
			Person[] Temp = new Person[InnerList.Length + 1];

			InnerList.CopyTo(Temp, 0);

			Temp[InnerList.Length] = value;

			InnerList = Temp;
		}

        /// <summary>
        /// پیاده سازی متد گت اینامریتور
        /// </summary>
        /// <returns></returns>
		public IEnumerator GetEnumerator()
		{
			return this;
		}


		#region Ienumerator

        /// <summary>
        /// فیلد اینت ایندکس
        /// </summary>
		int Index = -1;

        /// <summary>
        /// پیاده سازی متد کارنت
        /// </summary>
		public object Current
		{
			get { return InnerList[Index]; }
		}

        /// <summary>
        /// پیاده سازی متد مو نکست
        /// </summary>
        /// <returns></returns>
		public bool MoveNext()
		{
			if (Index<InnerList.Length-1)
			{
				Index++;
				return true;
			}
			return false;
		}

        /// <summary>
        /// پیاده سازی متد ریست
        /// </summary>
		public void Reset()
		{
			Index =- 1;
		}
		#endregion
	}
}
