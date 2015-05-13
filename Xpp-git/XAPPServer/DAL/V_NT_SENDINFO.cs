
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HealthCloud.DBDAL
{
	/// <summary>
	/// 数据访问类:V_NT_SENDINFO
	/// </summary>
	public partial class V_NT_SENDINFO
	{
		public V_NT_SENDINFO()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HealthCloud.DBModel.V_NT_SENDINFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into V_NT_SENDINFO(");
			strSql.Append("F_ID,F_GID,F_SEND_CONTENT,F_SEND_USER,F_SEND_TIME,F_SEND_TYPE,F_INDATE,F_REDATE,F_STATUS,F_TYPENAME,USERNAME)");
			strSql.Append(" values (");
			strSql.Append("@F_ID,@F_GID,@F_SEND_CONTENT,@F_SEND_USER,@F_SEND_TIME,@F_SEND_TYPE,@F_INDATE,@F_REDATE,@F_STATUS,@F_TYPENAME,@USERNAME)");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.Int,4),
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_SEND_CONTENT", SqlDbType.VarChar,4000),
					new SqlParameter("@F_SEND_USER", SqlDbType.VarChar,40),
					new SqlParameter("@F_SEND_TIME", SqlDbType.DateTime),
					new SqlParameter("@F_SEND_TYPE", SqlDbType.VarChar,40),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_TYPENAME", SqlDbType.VarChar,100),
					new SqlParameter("@USERNAME", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_ID;
			parameters[1].Value = model.F_GID;
			parameters[2].Value = model.F_SEND_CONTENT;
			parameters[3].Value = model.F_SEND_USER;
			parameters[4].Value = model.F_SEND_TIME;
			parameters[5].Value = model.F_SEND_TYPE;
			parameters[6].Value = model.F_INDATE;
			parameters[7].Value = model.F_REDATE;
			parameters[8].Value = model.F_STATUS;
			parameters[9].Value = model.F_TYPENAME;
			parameters[10].Value = model.USERNAME;

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
		public bool Update(HealthCloud.DBModel.V_NT_SENDINFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update V_NT_SENDINFO set ");
			strSql.Append("F_ID=@F_ID,");
			strSql.Append("F_GID=@F_GID,");
			strSql.Append("F_SEND_CONTENT=@F_SEND_CONTENT,");
			strSql.Append("F_SEND_USER=@F_SEND_USER,");
			strSql.Append("F_SEND_TIME=@F_SEND_TIME,");
			strSql.Append("F_SEND_TYPE=@F_SEND_TYPE,");
			strSql.Append("F_INDATE=@F_INDATE,");
			strSql.Append("F_REDATE=@F_REDATE,");
			strSql.Append("F_STATUS=@F_STATUS,");
			strSql.Append("F_TYPENAME=@F_TYPENAME,");
			strSql.Append("USERNAME=@USERNAME");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.Int,4),
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_SEND_CONTENT", SqlDbType.VarChar,4000),
					new SqlParameter("@F_SEND_USER", SqlDbType.VarChar,40),
					new SqlParameter("@F_SEND_TIME", SqlDbType.DateTime),
					new SqlParameter("@F_SEND_TYPE", SqlDbType.VarChar,40),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_TYPENAME", SqlDbType.VarChar,100),
					new SqlParameter("@USERNAME", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_ID;
			parameters[1].Value = model.F_GID;
			parameters[2].Value = model.F_SEND_CONTENT;
			parameters[3].Value = model.F_SEND_USER;
			parameters[4].Value = model.F_SEND_TIME;
			parameters[5].Value = model.F_SEND_TYPE;
			parameters[6].Value = model.F_INDATE;
			parameters[7].Value = model.F_REDATE;
			parameters[8].Value = model.F_STATUS;
			parameters[9].Value = model.F_TYPENAME;
			parameters[10].Value = model.USERNAME;

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
			strSql.Append("delete from V_NT_SENDINFO ");
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
		public HealthCloud.DBModel.V_NT_SENDINFO GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_ID,F_GID,F_SEND_CONTENT,F_SEND_USER,F_SEND_TIME,F_SEND_TYPE,F_INDATE,F_REDATE,F_STATUS,F_TYPENAME,USERNAME from V_NT_SENDINFO ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			HealthCloud.DBModel.V_NT_SENDINFO model=new HealthCloud.DBModel.V_NT_SENDINFO();
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
		public HealthCloud.DBModel.V_NT_SENDINFO DataRowToModel(DataRow row)
		{
			HealthCloud.DBModel.V_NT_SENDINFO model=new HealthCloud.DBModel.V_NT_SENDINFO();
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
				if(row["F_SEND_CONTENT"]!=null)
				{
					model.F_SEND_CONTENT=row["F_SEND_CONTENT"].ToString();
				}
				if(row["F_SEND_USER"]!=null)
				{
					model.F_SEND_USER=row["F_SEND_USER"].ToString();
				}
				if(row["F_SEND_TIME"]!=null && row["F_SEND_TIME"].ToString()!="")
				{
					model.F_SEND_TIME=DateTime.Parse(row["F_SEND_TIME"].ToString());
				}
				if(row["F_SEND_TYPE"]!=null)
				{
					model.F_SEND_TYPE=row["F_SEND_TYPE"].ToString();
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
				if(row["F_TYPENAME"]!=null)
				{
					model.F_TYPENAME=row["F_TYPENAME"].ToString();
				}
				if(row["USERNAME"]!=null)
				{
					model.USERNAME=row["USERNAME"].ToString();
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
			strSql.Append("select F_ID,F_GID,F_SEND_CONTENT,F_SEND_USER,F_SEND_TIME,F_SEND_TYPE,F_INDATE,F_REDATE,F_STATUS,F_TYPENAME,USERNAME ");
			strSql.Append(" FROM V_NT_SENDINFO ");
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
			strSql.Append(" F_ID,F_GID,F_SEND_CONTENT,F_SEND_USER,F_SEND_TIME,F_SEND_TYPE,F_INDATE,F_REDATE,F_STATUS,F_TYPENAME,USERNAME ");
			strSql.Append(" FROM V_NT_SENDINFO ");
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
			strSql.Append("select count(1) FROM V_NT_SENDINFO ");
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
			strSql.Append(")AS Row, T.*  from V_NT_SENDINFO T ");
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
			parameters[0].Value = "V_NT_SENDINFO";
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

