using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linq.Model;
using Linq.DAL;

namespace Linq.BLL
{
	public class BusiUnitBll
	{
		BusiUnitDao dao = new BusiUnitDao();

		public void LinqTest()
		{
			dao.LinqTest();
		}
	}
}
