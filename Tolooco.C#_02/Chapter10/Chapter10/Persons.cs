using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Chapter10
{
    /// <summary>
    /// کلاس افراد که سرالایزیبل است
    /// این کلاس از اینترفیس آی لیست جنریک پرسون اینهریت شده است
    /// </summary>
	[Serializable]
	//[XmlRoot("Persons")]
	 public class Persons :IList<Person>
	{
        /// <summary>
        /// سازنده پیش فرض که در   شی  ایجاد شده از ایکس ام ال سرالایز
        /// با نام دلخواه نیو و مقدار دهی میشود
        /// </summary>
		public Persons()
		{
			xmlSer = new XmlSerializer(typeof(Persons),new XmlRootAttribute(this.GetType().Name));
		}

        /// <summary>
        /// تعریف یک شی از کلاس ایکس ام ال سرالایزر
        /// </summary>
		XmlSerializer xmlSer;

        /// <summary>
        /// ایجاد یک شی از لیست جنریک از پرسون 
        /// </summary>
		List<Person> InnerList = new List<Person>();

		#region IList
		public int IndexOf(Person item)
		{
			throw new NotImplementedException();
		}

		public void Insert(int index, Person item)
		{
			throw new NotImplementedException();
		}

		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		public Person this[int index]
		{
			get
			{
				return InnerList[index];
			}
			set
			{
				InnerList[index] = value;
			}
		}

		public void Add(Person item)
		{
			InnerList.Add(item);
		}

		public void AddPerson(Person item)
		{
			Load("C:\\PersonsList.xml");
			InnerList.Add(item);
			Save(@"C:\PersonsList.xml");
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(Person item)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(Person[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		public int Count
		{
			get { return InnerList.Count; }
		}

		public bool IsReadOnly
		{
			get { throw new NotImplementedException(); }
		}

		public bool Remove(Person item)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<Person> GetEnumerator()
		{
			return InnerList.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return InnerList.GetEnumerator();
		}
		#endregion

        /// <summary>
        /// متد ذخیره  افراد در فایل ایکس ام ال
        /// </summary>
        /// <param name="SPath"></param>
		public void Save(string SPath)
		{
			using (StreamWriter SWriter_2 = new StreamWriter(SPath))
			{
				xmlSer.Serialize(SWriter_2, this);
			}
		}

        /// <summary>
        /// متد فراخوانی افراد از فایل ایکس ام ال
        /// </summary>
        /// <param name="SPath"></param>
		public void Load(string SPath)
		{
 			using (StreamReader SReader_2= new StreamReader (SPath))
			{
			Persons Temp=(Persons)	xmlSer.Deserialize(SReader_2);
			this.InnerList = Temp.InnerList;
			}
		}

        /// <summary>
        /// متد اورراید تو استرینگ
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{
			string Temp = string.Empty;

			foreach (Person  P in this)
			{
				Temp += string.Format("{0}\r\n",P);
			}
			return Temp;
		}
	}
}
