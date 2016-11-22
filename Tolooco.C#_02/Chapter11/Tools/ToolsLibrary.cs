using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    /// <summary>
    /// 21 March 2014
    /// Version 1.1.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    /// <summary>
    /// کلاس کتابخانه ابزار
    /// </summary>
	public class ToolsLibrary
	{
        /// <summary>
        /// دلیگیت وید با ورودی فایل استریم
        /// </summary>
        /// <param name="Source"></param>
		public delegate void CreateBackup(FileStream Source);

        /// <summary>
        /// متد استاتیک کپی با دو ورودی استرینگ
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="Destination"></param>
		public static void Copy(string Source, string Destination)
		{
			File.Copy(Source, Destination);
		}

        /// <summary>
        /// متد استاتیک کپی با دوورودی استرینگ و یک ورودی دلیگیت
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="Destination"></param>
        /// <param name="CB"></param>
		public static void Copy(string Source, string Destination,CreateBackup CB)
		{
			File.Copy(Source, Destination);
			CB(new FileStream (Destination,FileMode.Create));
		}


	}
}
