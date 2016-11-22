using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
{
    /// <summary>
    /// کلاس دیتا با تایپ حرف آ
    /// </summary>
    /// <typeparam name="A"></typeparam>
	public class Data<A>
	{
        /// <summary>
        /// تعریف یک پراپرتی از جنس آ
        /// </summary>
		public A Prop_1 { get; set; }

        /// <summary>
        /// تعریف یک متد که ورودی از جنس آ دارد
        /// </summary>
        /// <param name="a"></param>
		public void Method_1(A a)
		{
			int i = 0;
		}

        /// <summary>
        /// تعریف یک متد که ورودی آز جنس آ دارد و آ برمیگرداند
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
		public A Method_2(A a)
		{
			return a;
		}
	}
}
