using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DateTime01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Demo01();
			Console.WriteLine();
			Demo02();
			Console.WriteLine();
			Demo03();
			Console.WriteLine();
			Demo04();
			Console.WriteLine();
			Demo05();

			Console.Read();
		}
		private static void Demo01()
		{
			//EXEC - 1
			DateTime thedate = DateTime.Today;
			Console.Write("請輸入幾天後還書：");
			string dday = Console.ReadLine();
			int ddd = Convert.ToInt32(dday);
			DateTime newdate = thedate.AddDays(ddd);

			Console.WriteLine($"還書日期是{newdate:yyyy-MM-dd}");

			//throw new NotImplementedException();
		}
		private static void Demo02()
		{
			//EXEC-2
			DateTime thedate = DateTime.Today;
			DateTime newday2 = thedate.AddMonths(1);
			Console.WriteLine($"下個月還書日期為{newday2:yyyy-MM-dd}");
		}
		private static void Demo03()
		{
			//EXEC3
			DateTime Bang = DateTime.Today;
			DateTime settime1 = new DateTime(Bang.Year, Bang.Month, 1);
			Console.WriteLine($"本月第一天為{settime1:yyyy-MM-dd}");
		}
		private static void Demo04()
		{
			//EXEC4
			DateTime Bang = DateTime.Today;
			DateTime settime2 = new DateTime(Bang.Year, Bang.AddMonths(1).Month, 1);
			settime2 = settime2.AddDays(-1);
			Console.WriteLine($"本月最後一天為{settime2:yyyy-MM-dd}");
		}
		private static void Demo05()
		{
			//EXEC5
			Console.Write("請輸入一個年份：");
			string input = Console.ReadLine();
			DateTime tttt = new DateTime(int.Parse(input), 01, 01);

			if (tttt.DayOfWeek == DayOfWeek.Monday)
				tttt = tttt.AddDays(6);
			else if (tttt.DayOfWeek == DayOfWeek.Tuesday)
				tttt = tttt.AddDays(5);
			else if (tttt.DayOfWeek == DayOfWeek.Wednesday)
				tttt = tttt.AddDays(4);
			else if (tttt.DayOfWeek == DayOfWeek.Thursday)
				tttt = tttt.AddDays(3);
			else if (tttt.DayOfWeek == DayOfWeek.Friday)
				tttt = tttt.AddDays(2);
			else if (tttt.DayOfWeek == DayOfWeek.Saturday)
				tttt = tttt.AddDays(1);

			Console.WriteLine("所有週日的日期");
			Console.WriteLine(tttt.ToString("yyyy-MM-dd"));

			int i = 7;
			while (true)
			{
				if (tttt.Year == int.Parse(input))
				{
					Console.WriteLine(tttt.ToString("yyyy-MM-dd"));
					tttt = tttt.AddDays(i);
				}
				else
					break;
			}
		}
	}
}
