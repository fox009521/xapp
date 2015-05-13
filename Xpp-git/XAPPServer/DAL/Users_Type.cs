
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HealthCloud.DBDAL
{
	/// <summary>
	/// 数据访问类:Users_Type
	/// </summary>
	public partial class Users_Type
	{
		public Users_Type()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(HealthCloud.DBModel.Users_Type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NT_Users_Type(");
			strSql.Append("F_GID,F_USERID,F_TYPEID,F_INDATE,F_REDATE,F_STATUS)");
			strSql.Append(" values (");
			strSql.Append("@F_GID,@F_USERID,@F_TYPEID,@F_INDATE,@F_REDATE,@F_STATUS)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_USERID", SqlDbType.VarChar,40),
					new SqlParameter("@F_TYPEID", SqlDbType.VarChar,40),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_USERID;
			parameters[2].Value = model.F_TYPEID;
			parameters[3].Value = model.F_INDATE;
			parameters[4].Value = model.F_REDATE;
			parameters[5].Value = model.F_STATUS;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(HealthCloud.DBModel.Users_Type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NT_Users_Type set ");
			strSql.Append("F_GID=@F_GID,");
			strSql.Append("F_USERID=@F_USERID,");
			strSql.Append("F_TYPEID=@F_TYPEID,");
			strSql.Append("F_INDATE=@F_INDATE,");
			strSql.Append("F_REDATE=@F_REDATE,");
			strSql.Append("F_STATUS=@F_STATUS");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_USERID", SqlDbType.VarChar,40),
					new SqlParameter("@F_TYPEID", SqlDbType.VarChar,40),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_USERID;
			parameters[2].Value = model.F_TYPEID;
			parameters[3].Value = model.F_INDATE;
			parameters[4].Value = model.F_REDATE;
			parameters[5].Value = model.F_STATUS;
			parameters[6].Value = model.F_ID;

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
		public bool Delete(int F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NT_Users_Type ");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = F_ID;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string F_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NT_Users_Type ");
			strSql.Append(" where F_ID in ("+F_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public HealthCloud.DBModel.Users_Type GetModel(int F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_ID,F_GID,F_USERID,F_TYPEID,F_INDATE,F_REDATE,F_STATUS from NT_Users_Type ");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = F_ID;

			HealthCloud.DBModel.Users_Type model=new HealthCloud.DBModel.Users_Type();
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
		public HealthCloud.DBModel.Users_Type DataRowToModel(DataRow row)
		{
			HealthCloud.DBModel.Users_Type model=new HealthCloud.DBModel.Users_Type();
			if (row != null)
			{
				if(row["F_ID"]!=null && row["F_ID"].ToString()!="")
				{
					model.F_ID=int.Parse(row["F_ID"].ToString());
				}
				if(row["F_GID"]!=null)
				{
					model.F_GID=row["F_GID"].ToString();
				}
				if(row["F_USERID"]!=null)
				{
					model.F_USERID=row["F_USERID"].ToString();
				}
				if(row["F_TYPEID"]!=null)
				{
					model.F_TYPEID=row["F_TYPEID"].ToString();
				}
				if(row["F_INDATE"]!=null && row["F_INDATE"].ToString()!="")
				{
					model.F_INDATE=DateTime.Parse(row["F_INDATE"].ToString());
				}
				if(row["F_REDATE"]!=null && row["F_REDATE"].ToString()!="")
				{
					model.F_REDATE=DateTime.Parse(row["F_REDATE"].ToString());
				}
				if(row["F_STATUS"]!=null)
				{
					model.F_STATUS=row["F_STATUS"].ToString();
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
			strSql.Append("select F_ID,F_GID,F_USERID,F_TYPEID,F_INDATE,F_REDATE,F_STATUS ");
			strSql.Append(" FROM NT_Users_Type ");
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
			strSql.Append(" F_ID,F_GID,F_USERID,F_TYPEID,F_INDATE,F_REDATE,F_STATUS ");
			strSql.Append(" FROM NT_Users_Type ");
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
			strSql.Append("select count(1) FROM NT_Users_Type ");
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
				strSql.Append("order by T.F_ID desc");
			}
			strSql.Append(")AS Row, T.*  from NT_Users_Type T ");
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
			parameters[0].Value = "NT_Users_Type";
			parameters[1].Value = "F_ID";
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

