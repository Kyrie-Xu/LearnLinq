using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linq.Model;
using System.Linq.Expressions;

namespace Linq.DAL
{
	public class BusiUnitDao
	{
		PetrolStationAssistEntities dbContext = new PetrolStationAssistEntities();

		#region 根据id获取单位实体 + public BusiUnit GetBusiUnitById(int id)
		/// <summary>
		/// 根据id获取单位实体
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public void  LinqTest()
		{
			
		} 
		#endregion

		#region 添加单位实体 + public int Add(BusiUnit entity)
		/// <summary>
		/// 添加单位实体
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public int Add(BusiUnit entity)
		{
			try
			{
				dbContext.BusiUnit.Add(entity);
				return dbContext.SaveChanges();
			}
			catch
			{
				throw new Exception();
			}
		} 
		#endregion

		#region 根据id删除实体 + public int DeleteBusiUnitById(int id)
		/// <summary>
		/// 根据id删除实体
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public int DeleteBusiUnitById(int id)
		{
			try
			{
				BusiUnit unit = new BusiUnit()
					{
						BusiUnitId = id
					};

				BusiUnit entity = dbContext.BusiUnit.Attach(unit);
				dbContext.BusiUnit.Remove(entity);
				return dbContext.SaveChanges();
			}
			catch (Exception e)
			{
				
				throw e;
			}
		} 
		#endregion

		#region 根据条件查询实体列表 + public List<BusiUnit> GetBusiUnitListByCondition(Expression<Func<BusiUnit, bool>> where)
		/// <summary>
		/// 根据条件查询实体列表
		/// </summary>
		/// <param name="where"></param>
		/// <returns></returns>
		public List<BusiUnit> GetBusiUnitListByCondition(Expression<Func<BusiUnit, bool>> where)
		{
			try
			{
				return dbContext.BusiUnit.Where(where).ToList();
			}
			catch (Exception e)
			{

				throw e;
			}
		} 
		#endregion


			
	}
}
