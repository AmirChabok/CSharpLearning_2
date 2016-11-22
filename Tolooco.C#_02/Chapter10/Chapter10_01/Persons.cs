using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_01
{
    /// <summary>
    /// کلاس افراد که اینترفیس جنریک آی سرالایزر پرسون را میپذیرد
    /// </summary>
	public class Persons :ISerialzer<Person>
	{
        /// <summary>
        /// متد اورراید تو استرینگ
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{

			string Temp = string.Empty;

			foreach (Person  P in this)
			{
				Temp += string.Format("{0}\r\n", P);
			}
			return Temp;
		}
	}
}
