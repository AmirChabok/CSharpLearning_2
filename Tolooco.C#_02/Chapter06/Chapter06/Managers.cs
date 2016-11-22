using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Chapter06
{
    /// <summary>
    /// 21 March 2014
    /// Version 1.1.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    /// <summary>
    /// کلاس مدیران
    /// اینترفیس آی اینام ریبل را میپذیرد و شمارشی است
    /// </summary>
    public class Managers : IEnumerable
    {
        /// <summary>
        /// سازنده پیش فرض کلاس
        /// </summary>
        public Managers()
        {
            //مقدار دهی به اندیس های آرایه
            ManagerList[0] = new Manager("Dariush", "Tasdighi");
            ManagerList[1] = new Manager("Soroush", "Sarabi");
            ManagerList[2] = new Manager("Ali", "Pishkari");

        }
        /// <summary>
        /// آرایه از جنس کلاس مدیر که سه مقدار میگیرد
        /// </summary>
        Manager[] ManagerList = new Manager[2];

        /// <summary>
        /// پیاده سازی متد گت انامریتور
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            //با استفاده از یلد سه خاصیت - کارنت - موو نکست و ریست را شبیه سازی میکنیم
            //این سه خاصیت باعث شمارشی شدن اجزا میشوند.
            yield return ManagerList[0];
            yield return ManagerList[1];
            yield return ManagerList[2];

        }

        /// <summary>
        /// متد لیست
        /// </summary>
        /// <returns></returns>
        public string List()
        {
            string Temp = string.Empty;

            foreach (Manager man in this)
            {
                Temp += string.Format("{0}\r\n", man);
            }
            return Temp;
        }

    }
}
