
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HealthCloud.DBDAL
{
	/// <summary>
	/// 数据访问类:Service_Log
	/// </summary>
	public partial class Service_Log
	{
		public Service_Log()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(HealthCloud.DBModel.Service_Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Service_Log(");
			strSql.Append("f_gid,F_USERID,F_USERNAME,F_TOKEN,F_VER_OS,F_VER_SOFT,F_IP,F_HARDINFO,F_OPERTIME,F_OPERCONTENT,F_HARD_SN)");
			strSql.Append(" values (");
			strSql.Append("@f_gid,@F_USERID,@F_USERNAME,@F_TOKEN,@F_VER_OS,@F_VER_SOFT,@F_IP,@F_HARDINFO,@F_OPERTIME,@F_OPERCONTENT,@F_HARD_SN)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@f_gid", SqlDbType.VarChar,40),
					new SqlParameter("@F_USERID", SqlDbType.VarChar,40),
					new SqlParameter("@F_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("@F_TOKEN", SqlDbType.VarChar,40),
					new SqlParameter("@F_VER_OS", SqlDbType.VarChar,20),
					new SqlParameter("@F_VER_SOFT", SqlDbType.VarChar,20),
					new SqlParameter("@F_IP", SqlDbType.VarChar,20),
					new SqlParameter("@F_HARDINFO", SqlDbType.VarChar,100),
					new SqlParameter("@F_OPERTIME", SqlDbType.DateTime),
					new SqlParameter("@F_OPERCONTENT", SqlDbType.VarChar,200),
					new SqlParameter("@F_HARD_SN", SqlDbType.VarChar,100)};
			parameters[0].Value = model.f_gid;
			parameters[1].Value = model.F_USERID;
			parameters[2].Value = model.F_USERNAME;
			parameters[3].Value = model.F_TOKEN;
			parameters[4].Value = model.F_VER_OS;
			parameters[5].Value = model.F_VER_SOFT;
			parameters[6].Value = model.F_IP;
			parameters[7].Value = model.F_HARDINFO;
			parameters[8].Value = model.F_OPERTIME;
			parameters[9].Value = model.F_OPERCONTENT;
			parameters[10].Value = model.F_HARD_SN;

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
		public bool Update(HealthCloud.DBModel.Service_Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Service_Log set ");
			strSql.Append("f_gid=@f_gid,");
			strSql.Append("F_USERID=@F_USERID,");
			strSql.Append("F_USERNAME=@F_USERNAME,");
			strSql.Append("F_TOKEN=@F_TOKEN,");
			strSql.Append("F_VER_OS=@F_VER_OS,");
			strSql.Append("F_VER_SOFT=@F_VER_SOFT,");
			strSql.Append("F_IP=@F_IP,");
			strSql.Append("F_HARDINFO=@F_HARDINFO,");
			strSql.Append("F_OPERTIME=@F_OPERTIME,");
			strSql.Append("F_OPERCONTENT=@F_OPERCONTENT,");
			strSql.Append("F_HARD_SN=@F_HARD_SN");
			strSql.Append(" where f_id=@f_id");
			SqlParameter[] parameters = {
					new SqlParameter("@f_gid", SqlDbType.VarChar,40),
					new SqlParameter("@F_USERID", SqlDbType.VarChar,40),
					new SqlParameter("@F_USERNAME", SqlDbType.VarChar,50),
					new SqlParameter("@F_TOKEN", SqlDbType.VarChar,40),
					new SqlParameter("@F_VER_OS", SqlDbType.VarChar,20),
					new SqlParameter("@F_VER_SOFT", SqlDbType.VarChar,20),
					new SqlParameter("@F_IP", SqlDbType.VarChar,20),
					new SqlParameter("@F_HARDINFO", SqlDbType.VarChar,100),
					new SqlParameter("@F_OPERTIME", SqlDbType.DateTime),
					new SqlParameter("@F_OPERCONTENT", SqlDbType.VarChar,200),
					new SqlParameter("@F_HARD_SN", SqlDbType.VarChar,100),
					new SqlParameter("@f_id", SqlDbType.Int,4)};
			parameters[0].Value = model.f_gid;
			parameters[1].Value = model.F_USERID;
			parameters[2].Value = model.F_USERNAME;
			parameters[3].Value = model.F_TOKEN;
			parameters[4].Value = model.F_VER_OS;
			parameters[5].Value = model.F_VER_SOFT;
			parameters[6].Value = model.F_IP;
			parameters[7].Value = model.F_HARDINFO;
			parameters[8].Value = model.F_OPERTIME;
			parameters[9].Value = model.F_OPERCONTENT;
			parameters[10].Value = model.F_HARD_SN;
			parameters[11].Value = model.f_id;

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
		public bool Delete(int f_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Service_Log ");
			strSql.Append(" where f_id=@f_id");
			SqlParameter[] parameters = {
					new SqlParameter("@f_id", SqlDbType.Int,4)
			};
			parameters[0].Value = f_id;

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
		public bool DeleteList(string f_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Service_Log ");
			strSql.Append(" where f_id in ("+f_idlist + ")  ");
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
		public HealthCloud.DBModel.Service_Log GetModel(int f_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 f_id,f_gid,F_USERID,F_USERNAME,F_TOKEN,F_VER_OS,F_VER_SOFT,F_IP,F_HARDINFO,F_OPERTIME,F_OPERCONTENT,F_HARD_SN from Service_Log ");
			strSql.Append(" where f_id=@f_id");
			SqlParameter[] parameters = {
					new SqlParameter("@f_id", SqlDbType.Int,4)
			};
			parameters[0].Value = f_id;

			HealthCloud.DBModel.Service_Log model=new HealthCloud.DBModel.Service_Log();
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
		public HealthCloud.DBModel.Service_Log DataRowToModel(DataRow row)
		{
			HealthCloud.DBModel.Service_Log model=new HealthCloud.DBModel.Service_Log();
			if (row != null)
			{
				if(row["f_id"]!=null && row["f_id"].ToString()!="")
				{
					model.f_id=int.Parse(row["f_id"].ToString());
				}
				if(row["f_gid"]!=null)
				{
					model.f_gid=row["f_gid"].ToString();
				}
				if(row["F_USERID"]!=null)
				{
					model.F_USERID=row["F_USERID"].ToString();
				}
				if(row["F_USERNAME"]!=null)
				{
					model.F_USERNAME=row["F_USERNAME"].ToString();
				}
				if(row["F_TOKEN"]!=null)
				{
					model.F_TOKEN=row["F_TOKEN"].ToString();
				}
				if(row["F_VER_OS"]!=null)
				{
					model.F_VER_OS=row["F_VER_OS"].ToString();
				}
				if(row["F_VER_SOFT"]!=null)
				{
					model.F_VER_SOFT=row["F_VER_SOFT"].ToString();
				}
				if(row["F_IP"]!=null)
				{
					model.F_IP=row["F_IP"].ToString();
				}
				if(row["F_HARDINFO"]!=null)
				{
					model.F_HARDINFO=row["F_HARDINFO"].ToString();
				}
				if(row["F_OPERTIME"]!=null && row["F_OPERTIME"].ToString()!="")
				{
					model.F_OPERTIME=DateTime.Parse(row["F_OPERTIME"].ToString());
				}
				if(row["F_OPERCONTENT"]!=null)
				{
					model.F_OPERCONTENT=row["F_OPERCONTENT"].ToString();
				}
				if(row["F_HARD_SN"]!=null)
				{
					model.F_HARD_SN=row["F_HARD_SN"].ToString();
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
			strSql.Append("select f_id,f_gid,F_USERID,F_USERNAME,F_TOKEN,F_VER_OS,F_VER_SOFT,F_IP,F_HARDINFO,F_OPERTIME,F_OPERCONTENT,F_HARD_SN ");
			strSql.Append(" FROM Service_Log ");
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
			strSql.Append(" f_id,f_gid,F_USERID,F_USERNAME,F_TOKEN,F_VER_OS,F_VER_SOFT,F_IP,F_HARDINFO,F_OPERTIME,F_OPERCONTENT,F_HARD_SN ");
			strSql.Append(" FROM Service_Log ");
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
			strSql.Append("select count(1) FROM Service_Log ");
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
				strSql.Append("order by T.f_id desc");
			}
			strSql.Append(")AS Row, T.*  from Service_Log T ");
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
			parameters[0].Value = "Service_Log";
			parameters[1].Value = "f_id";
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

