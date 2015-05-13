
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;
using HealthCloud.DBModel;//Please add references
namespace HealthCloud.DBDAL
{
	/// <summary>
	/// 数据访问类:VER_HIS
	/// </summary>
	public partial class VerHisDAL
	{
		public VerHisDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(HealthCloud.DBModel.VER_HIS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NT_VER_HIS(");
			strSql.Append("F_GID,F_Type,F_VER_NO,F_VER_CONTENT,F_href,F_OPERID,F_UploadTime,F_IsForce,F_INDATE,F_REDATE,F_STATUS,F_OS_VER)");
			strSql.Append(" values (");
			strSql.Append("@F_GID,@F_Type,@F_VER_NO,@F_VER_CONTENT,@F_href,@F_OPERID,@F_UploadTime,@F_IsForce,@F_INDATE,@F_REDATE,@F_STATUS,@F_OS_VER)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_Type", SqlDbType.VarChar,20),
					new SqlParameter("@F_VER_NO", SqlDbType.VarChar,50),
					new SqlParameter("@F_VER_CONTENT", SqlDbType.VarChar,4000),
					new SqlParameter("@F_href", SqlDbType.VarChar,1000),
					new SqlParameter("@F_OPERID", SqlDbType.VarChar,40),
					new SqlParameter("@F_UploadTime", SqlDbType.DateTime),
					new SqlParameter("@F_IsForce", SqlDbType.Char,1),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_OS_VER", SqlDbType.VarChar,200)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_Type;
			parameters[2].Value = model.F_VER_NO;
			parameters[3].Value = model.F_VER_CONTENT;
			parameters[4].Value = model.F_href;
			parameters[5].Value = model.F_OPERID;
			parameters[6].Value = model.F_UploadTime;
			parameters[7].Value = model.F_IsForce;
			parameters[8].Value = model.F_INDATE;
			parameters[9].Value = model.F_REDATE;
			parameters[10].Value = model.F_STATUS;
			parameters[11].Value = model.F_OS_VER;

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
		public bool Update(HealthCloud.DBModel.VER_HIS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NT_VER_HIS set ");
			strSql.Append("F_GID=@F_GID,");
			strSql.Append("F_Type=@F_Type,");
			strSql.Append("F_VER_NO=@F_VER_NO,");
			strSql.Append("F_VER_CONTENT=@F_VER_CONTENT,");
			strSql.Append("F_href=@F_href,");
			strSql.Append("F_OPERID=@F_OPERID,");
			strSql.Append("F_UploadTime=@F_UploadTime,");
			strSql.Append("F_IsForce=@F_IsForce,");
			strSql.Append("F_INDATE=@F_INDATE,");
			strSql.Append("F_REDATE=@F_REDATE,");
			strSql.Append("F_STATUS=@F_STATUS,");
			strSql.Append("F_OS_VER=@F_OS_VER");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_Type", SqlDbType.VarChar,20),
					new SqlParameter("@F_VER_NO", SqlDbType.VarChar,50),
					new SqlParameter("@F_VER_CONTENT", SqlDbType.VarChar,4000),
					new SqlParameter("@F_href", SqlDbType.VarChar,1000),
					new SqlParameter("@F_OPERID", SqlDbType.VarChar,40),
					new SqlParameter("@F_UploadTime", SqlDbType.DateTime),
					new SqlParameter("@F_IsForce", SqlDbType.Char,1),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_OS_VER", SqlDbType.VarChar,200),
					new SqlParameter("@F_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_Type;
			parameters[2].Value = model.F_VER_NO;
			parameters[3].Value = model.F_VER_CONTENT;
			parameters[4].Value = model.F_href;
			parameters[5].Value = model.F_OPERID;
			parameters[6].Value = model.F_UploadTime;
			parameters[7].Value = model.F_IsForce;
			parameters[8].Value = model.F_INDATE;
			parameters[9].Value = model.F_REDATE;
			parameters[10].Value = model.F_STATUS;
			parameters[11].Value = model.F_OS_VER;
			parameters[12].Value = model.F_ID;

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
			strSql.Append("delete from NT_VER_HIS ");
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
			strSql.Append("delete from NT_VER_HIS ");
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
		public HealthCloud.DBModel.VER_HIS GetModel(int F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_ID,F_GID,F_Type,F_VER_NO,F_VER_CONTENT,F_href,F_OPERID,F_UploadTime,F_IsForce,F_INDATE,F_REDATE,F_STATUS,F_OS_VER from NT_VER_HIS ");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = F_ID;

			HealthCloud.DBModel.VER_HIS model=new HealthCloud.DBModel.VER_HIS();
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
		public HealthCloud.DBModel.VER_HIS DataRowToModel(DataRow row)
		{
			HealthCloud.DBModel.VER_HIS model=new HealthCloud.DBModel.VER_HIS();
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
				if(row["F_Type"]!=null)
				{
					model.F_Type=row["F_Type"].ToString();
				}
				if(row["F_VER_NO"]!=null)
				{
					model.F_VER_NO=row["F_VER_NO"].ToString();
				}
				if(row["F_VER_CONTENT"]!=null)
				{
					model.F_VER_CONTENT=row["F_VER_CONTENT"].ToString();
				}
				if(row["F_href"]!=null)
				{
					model.F_href=row["F_href"].ToString();
				}
				if(row["F_OPERID"]!=null)
				{
					model.F_OPERID=row["F_OPERID"].ToString();
				}
				if(row["F_UploadTime"]!=null && row["F_UploadTime"].ToString()!="")
				{
					model.F_UploadTime=DateTime.Parse(row["F_UploadTime"].ToString());
				}
				if(row["F_IsForce"]!=null)
				{
					model.F_IsForce=row["F_IsForce"].ToString();
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
				if(row["F_OS_VER"]!=null)
				{
					model.F_OS_VER=row["F_OS_VER"].ToString();
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
			strSql.Append("select F_ID,F_GID,F_Type,F_VER_NO,F_VER_CONTENT,F_href,F_OPERID,F_UploadTime,F_IsForce,F_INDATE,F_REDATE,F_STATUS,F_OS_VER ");
			strSql.Append(" FROM NT_VER_HIS ");
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
			strSql.Append(" F_ID,F_GID,F_Type,F_VER_NO,F_VER_CONTENT,F_href,F_OPERID,F_UploadTime,F_IsForce,F_INDATE,F_REDATE,F_STATUS,F_OS_VER ");
			strSql.Append(" FROM NT_VER_HIS ");
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
			strSql.Append("select count(1) FROM NT_VER_HIS ");
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
			strSql.Append(")AS Row, T.*  from NT_VER_HIS T ");
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
			parameters[0].Value = "NT_VER_HIS";
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
      
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HealthCloud.DBModel.VER_HIS GetModel(String osType,String osVersion,String appVersion)
        {
            
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 F_ID,F_GID,F_Type,F_VER_NO,F_VER_CONTENT,F_href,F_OPERID,F_UploadTime,F_IsForce,F_INDATE,F_REDATE,F_STATUS,F_OS_VER from NT_VER_HIS ");
            strSql.Append(" where (F_Type=@F_Type) and (F_OS_VER like @F_OS_VER)  and (F_VER_NO>@F_VER_NO)");
            SqlParameter[] parameters = {
					new SqlParameter("@F_Type", SqlDbType.NVarChar),
                    new SqlParameter("@F_OS_VER", SqlDbType.NVarChar),
                     new SqlParameter("@F_VER_NO", SqlDbType.NVarChar)
			};
            parameters[0].Value = osType;
            parameters[1].Value =String.Format("%{0}%",osVersion);
            parameters[2].Value =String.Format("{0}%", appVersion);
            HealthCloud.DBModel.VER_HIS model = new HealthCloud.DBModel.VER_HIS();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
		#endregion  ExtensionMethod
	}
}

