using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    /// <summary>
    /// 21 March 2014
    /// Version 1.1.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    /// <summary>
    /// کلاس افراد که آرایه ای از پرسون است
    /// </summary>
    public class Persons
    {
        /// <summary>
        ///سازنده پیش فرض کلاس 
        /// </summary>
        public Persons()
        {

        }

        /// <summary>
        /// سازنده با ورودی یک پرسون
        /// </summary>
        /// <param name="person"></param>
        public Persons(Person person)
        {
            //متد اد که یک پرسون میگیرد 
            this.Add(person);
        }

        /// <summary>
        /// سازنده با ورودی آرایه ای از پرسون
        /// </summary>
        /// <param name="persons"></param>
        public Persons(params Person[] persons)
        {
            foreach (Person p in persons)
            {
                //متد اد که یک پرسون میگیرد 
                this.Add(p);
            }
        }

        /// <summary>
        /// فیلد پرایویت که یک آرایه داخلی از پرسون است
        /// </summary>
        private Person[] InnerList = new Person[0];

        /// <summary>
        /// متد اد که یک پرسون میگیرد و به آرایه داخلی اد میکند
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Add(Person value)
        {
            try
            {
                //ایجاد یک آرایه متناظر با آرایه داخلی با یک حانه بیشتر
                Person[] Temp = new Person[InnerList.Length + 1];

                //ایجاد یک کانتر داخلی
                int Count = 0;

                //حلقه  فورایچ که در آن به ترتیب خانه های آرایه داخلی به آرایه متناظر  منتقل میشود
                foreach (Person p in InnerList)
                {
                    Temp[Count] = p;
                    Count++;
                }
                //پرسون ورودی در آخرین خانه آرایه متناظر قرار میگیرد
                Temp[InnerList.Length] = value;
                //آرایه داخلی با آرایه متناظر تعویض میگردد
                InnerList = Temp;
                return true;

            }
            //درصورت بروز خطا
            catch
            {

                return false;
            }
        }

        /// <summary>
        /// متد یافتن پرسون که یک پرسون دریافت میکند
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Find(Person value)
        {
            //تعریف یک متغیر بول و مقدار دهی فالس
            bool Temp = false;

            //حلقه فورایچ که پراپرتی های پرسون را در حلقه بررسی میکند
            foreach (Person p in InnerList)
            {
                //اگر پرسون پیدا شود مقدار تمپ تورو میشود
                if (p.Name == value.Name && p.Family == value.Family && p.ID == value.ID)
                {
                    Temp = true;
                    break;
                }
            }
            //در نهایت مقدار تمپ برمیگردد
            return Temp;
        }

        /// <summary>
        /// متد حذف یک پرسون از جنس بولین
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Remove(Person value)
        {
            //سعی میشود
            try
            {
                //اگر متد یافتن پرسون صحیح باشد
                if (Find(value))
                {
                    //ایجاد یک آرایه متناظر با یک خانه کمتر از آرایه داخلی
                    Person[] Temp = new Person[InnerList.Length - 1];
                    //ایجاد یک شمارنده
                    int Count = 0;

                    //حلقه فورایچ که بررسی میکند اگر پرسون ها با مقدار ولیو تفاوت داشت در آرایه متناظر بنشیند
                    foreach (Person p in InnerList)
                    {
                        if (p.Name != value.Name && p.Family != value.Family && p.ID != value.ID)
                        {
                            Temp[Count] = p;
                            Count++;
                        }
                    }

                    //اینر لیست را با تمپ که ولیو پرسون از آن حذف شده است جایگزین میکنیم
                    InnerList = Temp;
                    //به برنامه مقدار صحیح را ارسال میکنیم
                    return true;
                }
                //در غیر اینصورت مقدار فالس را ارسال میکنیم
                return false;
            }
            //درصورت بروز خطا
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// پراپرتی نمایش پرسون های موجود در آرایه
        /// </summary>
        /// <returns></returns>
        public string DisplayList()
        {
            string Temp = string.Empty;

            foreach (Person p in InnerList)
            {
                Temp += string.Format("{0}", p);
            }
            return Temp;
        }
    }
}
