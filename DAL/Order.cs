/**  版本信息模板在安装目录下，可自行修改。
* Order.cs
*
* 功 能： N/A
* 类 名： Order
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/8/6 16:54:45   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace CMS.DAL
{
	/// <summary>
	/// 数据访问类:Order
	/// </summary>
	public partial class Order
	{
		public Order()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CMS.Model.Order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Order(");
			strSql.Append("id,orderId,addTime,userId,isDel,wuliuId,payId,isPay,addressId,couponId,memo,trackingNumber,state)");
			strSql.Append(" values (");
			strSql.Append("@id,@orderId,@addTime,@userId,@isDel,@wuliuId,@payId,@isPay,@addressId,@couponId,@memo,@trackingNumber,@state)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@orderId", SqlDbType.NVarChar,50),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@isDel", SqlDbType.TinyInt,1),
					new SqlParameter("@wuliuId", SqlDbType.Int,4),
					new SqlParameter("@payId", SqlDbType.Int,4),
					new SqlParameter("@isPay", SqlDbType.TinyInt,1),
					new SqlParameter("@addressId", SqlDbType.Int,4),
					new SqlParameter("@couponId", SqlDbType.Int,4),
					new SqlParameter("@memo", SqlDbType.NVarChar,300),
					new SqlParameter("@trackingNumber", SqlDbType.NVarChar,30),
					new SqlParameter("@state", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.orderId;
			parameters[2].Value = model.addTime;
			parameters[3].Value = model.userId;
			parameters[4].Value = model.isDel;
			parameters[5].Value = model.wuliuId;
			parameters[6].Value = model.payId;
			parameters[7].Value = model.isPay;
			parameters[8].Value = model.addressId;
			parameters[9].Value = model.couponId;
			parameters[10].Value = model.memo;
			parameters[11].Value = model.trackingNumber;
			parameters[12].Value = model.state;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CMS.Model.Order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Order set ");
			strSql.Append("id=@id,");
			strSql.Append("orderId=@orderId,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("userId=@userId,");
			strSql.Append("isDel=@isDel,");
			strSql.Append("wuliuId=@wuliuId,");
			strSql.Append("payId=@payId,");
			strSql.Append("isPay=@isPay,");
			strSql.Append("addressId=@addressId,");
			strSql.Append("couponId=@couponId,");
			strSql.Append("memo=@memo,");
			strSql.Append("trackingNumber=@trackingNumber,");
			strSql.Append("state=@state");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@orderId", SqlDbType.NVarChar,50),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@isDel", SqlDbType.TinyInt,1),
					new SqlParameter("@wuliuId", SqlDbType.Int,4),
					new SqlParameter("@payId", SqlDbType.Int,4),
					new SqlParameter("@isPay", SqlDbType.TinyInt,1),
					new SqlParameter("@addressId", SqlDbType.Int,4),
					new SqlParameter("@couponId", SqlDbType.Int,4),
					new SqlParameter("@memo", SqlDbType.NVarChar,300),
					new SqlParameter("@trackingNumber", SqlDbType.NVarChar,30),
					new SqlParameter("@state", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.orderId;
			parameters[2].Value = model.addTime;
			parameters[3].Value = model.userId;
			parameters[4].Value = model.isDel;
			parameters[5].Value = model.wuliuId;
			parameters[6].Value = model.payId;
			parameters[7].Value = model.isPay;
			parameters[8].Value = model.addressId;
			parameters[9].Value = model.couponId;
			parameters[10].Value = model.memo;
			parameters[11].Value = model.trackingNumber;
			parameters[12].Value = model.state;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Order ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CMS.Model.Order GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,orderId,addTime,userId,isDel,wuliuId,payId,isPay,addressId,couponId,memo,trackingNumber,state from Order ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			CMS.Model.Order model=new CMS.Model.Order();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CMS.Model.Order DataRowToModel(DataRow row)
		{
			CMS.Model.Order model=new CMS.Model.Order();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["orderId"]!=null)
				{
					model.orderId=row["orderId"].ToString();
				}
				if(row["addTime"]!=null && row["addTime"].ToString()!="")
				{
					model.addTime=DateTime.Parse(row["addTime"].ToString());
				}
				if(row["userId"]!=null && row["userId"].ToString()!="")
				{
					model.userId=int.Parse(row["userId"].ToString());
				}
				if(row["isDel"]!=null && row["isDel"].ToString()!="")
				{
					model.isDel=int.Parse(row["isDel"].ToString());
				}
				if(row["wuliuId"]!=null && row["wuliuId"].ToString()!="")
				{
					model.wuliuId=int.Parse(row["wuliuId"].ToString());
				}
				if(row["payId"]!=null && row["payId"].ToString()!="")
				{
					model.payId=int.Parse(row["payId"].ToString());
				}
				if(row["isPay"]!=null && row["isPay"].ToString()!="")
				{
					model.isPay=int.Parse(row["isPay"].ToString());
				}
				if(row["addressId"]!=null && row["addressId"].ToString()!="")
				{
					model.addressId=int.Parse(row["addressId"].ToString());
				}
				if(row["couponId"]!=null && row["couponId"].ToString()!="")
				{
					model.couponId=int.Parse(row["couponId"].ToString());
				}
				if(row["memo"]!=null)
				{
					model.memo=row["memo"].ToString();
				}
				if(row["trackingNumber"]!=null)
				{
					model.trackingNumber=row["trackingNumber"].ToString();
				}
				if(row["state"]!=null && row["state"].ToString()!="")
				{
					model.state=int.Parse(row["state"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,orderId,addTime,userId,isDel,wuliuId,payId,isPay,addressId,couponId,memo,trackingNumber,state ");
			strSql.Append(" FROM Order ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,orderId,addTime,userId,isDel,wuliuId,payId,isPay,addressId,couponId,memo,trackingNumber,state ");
			strSql.Append(" FROM Order ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Order ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from Order T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Order";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

