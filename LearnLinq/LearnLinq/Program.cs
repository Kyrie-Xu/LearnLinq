using Linq.BLL;
using Linq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace LearnLinq
{
	class Program
	{
		static void Main(string[] args)
		{
			BusiUnitBll bll = new BusiUnitBll();
			bll.LinqTest();

		
			Console.WriteLine("单位name是：" );
			Console.ReadKey();
			
		}
	}
}
