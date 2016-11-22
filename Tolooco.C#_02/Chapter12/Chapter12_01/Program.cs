using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter12_01
{
    /// <summary>
    /// 21 March 2014
    /// Version 1.1.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    /// <summary>
    /// کلاس پروگرام
    /// </summary>
	class Program
	{
        /// <summary>
        /// متد استاتیک بدنه
        /// </summary>
        /// <param name="args"></param>
		static void Main(string[] args)
		{
            //ایجاد یک شی از کلاس فایل سیستم واچر
			FileSystemWatcher FSW = new FileSystemWatcher("C:\\");
            //مقدار دهی پراپرتی های شی
			FSW.IncludeSubdirectories = true;
			FSW.EnableRaisingEvents = true;
            //بارگزاری هندلر ایونت ایجاد
			FSW.Created += FSW_Created;
		}

        /// <summary>
        /// هندلر ایونت ایجاد
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		static void FSW_Created(object sender, FileSystemEventArgs e)
		{
			
		}
	}
}
