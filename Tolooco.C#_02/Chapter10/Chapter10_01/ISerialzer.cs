using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Chapter10_01
{
	[Serializable]
	 public class ISerialzer <T> :IList<T>
	{
		string SPath_3 = string.Empty;

		public ISerialzer()
		{
			xmlSer = new XmlSerializer(this.GetType(), new XmlRootAttribute(string.Format("{0}s", typeof(T).Name)));
			SPath_3=string.Format("{0}{1}.xml",Environment.CurrentDirectory,typeof(T).Name);
		}

		public ISerialzer(string spath)
		{
			xmlSer = new XmlSerializer(this.GetType(), new XmlRootAttribute(string.Format("{0}s", typeof(T).Name)));
			SPath_3 = spath;
		}

		public void Save()
		{
			using (StreamWriter SWriter_3 = new StreamWriter(SPath_3)) { xmlSer.Serialize(SWriter_3, this); }
		}

		public void Load()
		{
 			using (StreamReader SReader_3 = new StreamReader (SPath_3))
			{
				this.InnerList = ((ISerialzer<T>)xmlSer.Deserialize(SReader_3)).InnerList;
			}
		}

		XmlSerializer xmlSer;

		List<T> InnerList = new List<T>();

		public int IndexOf(T item)
		{
			throw new NotImplementedException();
		}

		public void Insert(int index, T item)
		{
			throw new NotImplementedException();
		}

		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		public T this[int index]
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

		public void Add(T item)
		{
			InnerList.Add(item);
		}

		public void AddItem(T item)
		{
			if (File.Exists(SPath_3))
			{
				this.Load();
				this.Add(item);
				this.Save();
			}
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(T item)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(T[] array, int arrayIndex)
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

		public bool Remove(T item)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<T> GetEnumerator()
		{
			return InnerList.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return InnerList.GetEnumerator();
		}
	}
}
