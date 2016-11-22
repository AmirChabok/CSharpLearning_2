using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    /// <summary>
    /// کلاس پرسون
    /// </summary>
    public class Person
    {

        /// <summary>
        /// سازنده پیش فرض کلاس
        /// </summary>
        public Person()
        {

        }

        /// <summary>
        /// سازنده با سه ورودی
        /// </summary>
        /// <param name="name"></param>
        /// <param name="family"></param>
        /// <param name="id"></param>
        public Person(string name, string family, int id)
        {
            this.Name = name;
            this.Family = family;
            this.ID = id;
        }

        /// <summary>
        /// تعریف پراپرتی های کلاس
        /// </summary>
        public string Name { get; set; }
        public string Family { get; set; }
        public int ID { get; set; }


        /// <summary>
        /// متد اورراید تو استرینگ برای نمایش مشخصات کلاس
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Name:{0}\r\n Family:{1}\r\n ID:{2}\r\n------------------------------------\r\n",
                this.Name, this.Family, this.ID);
        }
    }
}
