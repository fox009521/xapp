
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HealthCloud.DBDAL
{
	/// <summary>
	/// 数据访问类:USERS_Token
	/// </summary>
	public partial class UserTokenDAL
	{
		public UserTokenDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long F_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NT_USERS_Token");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = F_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(HealthCloud.DBModel.USERS_Token model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NT_USERS_Token(");
			strSql.Append("F_GID,F_USERID,F_Token,F_StartTime,F_EndTime,F_InDate,F_ReDate,F_Status,F_Memo,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_VER_OS,F_VER_SOFT,F_IP,F_HARDINFO,F_HARDSN)");
			strSql.Append(" values (");
			strSql.Append("@F_GID,@F_USERID,@F_Token,@F_StartTime,@F_EndTime,@F_InDate,@F_ReDate,@F_Status,@F_Memo,@F_BAK1,@F_BAK2,@F_BAK3,@F_BAK4,@F_VER_OS,@F_VER_SOFT,@F_IP,@F_HARDINFO,@F_HARDSN)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_USERID", SqlDbType.VarChar,40),
					new SqlParameter("@F_Token", SqlDbType.VarChar,100),
					new SqlParameter("@F_StartTime", SqlDbType.DateTime),
					new SqlParameter("@F_EndTime", SqlDbType.DateTime),
					new SqlParameter("@F_InDate", SqlDbType.DateTime),
					new SqlParameter("@F_ReDate", SqlDbType.DateTime),
					new SqlParameter("@F_Status", SqlDbType.Char,1),
					new SqlParameter("@F_Memo", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK1", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK2", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK3", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK4", SqlDbType.VarChar,100),
					new SqlParameter("@F_VER_OS", SqlDbType.VarChar,20),
					new SqlParameter("@F_VER_SOFT", SqlDbType.VarChar,20),
					new SqlParameter("@F_IP", SqlDbType.VarChar,20),
					new SqlParameter("@F_HARDINFO", SqlDbType.VarChar,100),
					new SqlParameter("@F_HARDSN", SqlDbType.VarChar,100)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_USERID;
			parameters[2].Value = model.F_Token;
			parameters[3].Value = model.F_StartTime;
			parameters[4].Value = model.F_EndTime;
			parameters[5].Value = model.F_InDate;
			parameters[6].Value = model.F_ReDate;
			parameters[7].Value = model.F_Status;
			parameters[8].Value = model.F_Memo;
			parameters[9].Value = model.F_BAK1;
			parameters[10].Value = model.F_BAK2;
			parameters[11].Value = model.F_BAK3;
			parameters[12].Value = model.F_BAK4;
			parameters[13].Value = model.F_VER_OS;
			parameters[14].Value = model.F_VER_SOFT;
			parameters[15].Value = model.F_IP;
			parameters[16].Value = model.F_HARDINFO;
			parameters[17].Value = model.F_HARDSN;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt64(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HealthCloud.DBModel.USERS_Token model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NT_USERS_Token set ");
			strSql.Append("F_GID=@F_GID,");
			strSql.Append("F_USERID=@F_USERID,");
			strSql.Append("F_Token=@F_Token,");
			strSql.Append("F_StartTime=@F_StartTime,");
			strSql.Append("F_EndTime=@F_EndTime,");
			strSql.Append("F_InDate=@F_InDate,");
			strSql.Append("F_ReDate=@F_ReDate,");
			strSql.Append("F_Status=@F_Status,");
			strSql.Append("F_Memo=@F_Memo,");
			strSql.Append("F_BAK1=@F_BAK1,");
			strSql.Append("F_BAK2=@F_BAK2,");
			strSql.Append("F_BAK3=@F_BAK3,");
			strSql.Append("F_BAK4=@F_BAK4,");
			strSql.Append("F_VER_OS=@F_VER_OS,");
			strSql.Append("F_VER_SOFT=@F_VER_SOFT,");
			strSql.Append("F_IP=@F_IP,");
			strSql.Append("F_HARDINFO=@F_HARDINFO,");
			strSql.Append("F_HARDSN=@F_HARDSN");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_USERID", SqlDbType.VarChar,40),
					new SqlParameter("@F_Token", SqlDbType.VarChar,100),
					new SqlParameter("@F_StartTime", SqlDbType.DateTime),
					new SqlParameter("@F_EndTime", SqlDbType.DateTime),
					new SqlParameter("@F_InDate", SqlDbType.DateTime),
					new SqlParameter("@F_ReDate", SqlDbType.DateTime),
					new SqlParameter("@F_Status", SqlDbType.Char,1),
					new SqlParameter("@F_Memo", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK1", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK2", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK3", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK4", SqlDbType.VarChar,100),
					new SqlParameter("@F_VER_OS", SqlDbType.VarChar,20),
					new SqlParameter("@F_VER_SOFT", SqlDbType.VarChar,20),
					new SqlParameter("@F_IP", SqlDbType.VarChar,20),
					new SqlParameter("@F_HARDINFO", SqlDbType.VarChar,100),
					new SqlParameter("@F_HARDSN", SqlDbType.VarChar,100),
					new SqlParameter("@F_ID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_USERID;
			parameters[2].Value = model.F_Token;
			parameters[3].Value = model.F_StartTime;
			parameters[4].Value = model.F_EndTime;
			parameters[5].Value = model.F_InDate;
			parameters[6].Value = model.F_ReDate;
			parameters[7].Value = model.F_Status;
			parameters[8].Value = model.F_Memo;
			parameters[9].Value = model.F_BAK1;
			parameters[10].Value = model.F_BAK2;
			parameters[11].Value = model.F_BAK3;
			parameters[12].Value = model.F_BAK4;
			parameters[13].Value = model.F_VER_OS;
			parameters[14].Value = model.F_VER_SOFT;
			parameters[15].Value = model.F_IP;
			parameters[16].Value = model.F_HARDINFO;
			parameters[17].Value = model.F_HARDSN;
			parameters[18].Value = model.F_ID;

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
		public bool Delete(long F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NT_USERS_Token ");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.BigInt)
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
			strSql.Append("delete from NT_USERS_Token ");
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
		public HealthCloud.DBModel.USERS_Token GetModel(long F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_ID,F_GID,F_USERID,F_Token,F_StartTime,F_EndTime,F_InDate,F_ReDate,F_Status,F_Memo,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_VER_OS,F_VER_SOFT,F_IP,F_HARDINFO,F_HARDSN from NT_USERS_Token ");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = F_ID;

			HealthCloud.DBModel.USERS_Token model=new HealthCloud.DBModel.USERS_Token();
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
		public HealthCloud.DBModel.USERS_Token DataRowToModel(DataRow row)
		{
			HealthCloud.DBModel.USERS_Token model=new HealthCloud.DBModel.USERS_Token();
			if (row != null)
			{
				if(row["F_ID"]!=null && row["F_ID"].ToString()!="")
				{
					model.F_ID=long.Parse(row["F_ID"].ToString());
				}
				if(row["F_GID"]!=null)
				{
					model.F_GID=row["F_GID"].ToString();
				}
				if(row["F_USERID"]!=null)
				{
					model.F_USERID=row["F_USERID"].ToString();
				}
				if(row["F_Token"]!=null)
				{
					model.F_Token=row["F_Token"].ToString();
				}
				if(row["F_StartTime"]!=null && row["F_StartTime"].ToString()!="")
				{
					model.F_StartTime=DateTime.Parse(row["F_StartTime"].ToString());
				}
				if(row["F_EndTime"]!=null && row["F_EndTime"].ToString()!="")
				{
					model.F_EndTime=DateTime.Parse(row["F_EndTime"].ToString());
				}
				if(row["F_InDate"]!=null && row["F_InDate"].ToString()!="")
				{
					model.F_InDate=DateTime.Parse(row["F_InDate"].ToString());
				}
				if(row["F_ReDate"]!=null && row["F_ReDate"].ToString()!="")
				{
					model.F_ReDate=DateTime.Parse(row["F_ReDate"].ToString());
				}
				if(row["F_Status"]!=null)
				{
					model.F_Status=row["F_Status"].ToString();
				}
				if(row["F_Memo"]!=null)
				{
					model.F_Memo=row["F_Memo"].ToString();
				}
				if(row["F_BAK1"]!=null)
				{
					model.F_BAK1=row["F_BAK1"].ToString();
				}
				if(row["F_BAK2"]!=null)
				{
					model.F_BAK2=row["F_BAK2"].ToString();
				}
				if(row["F_BAK3"]!=null)
				{
					model.F_BAK3=row["F_BAK3"].ToString();
				}
				if(row["F_BAK4"]!=null)
				{
					model.F_BAK4=row["F_BAK4"].ToString();
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
				if(row["F_HARDSN"]!=null)
				{
					model.F_HARDSN=row["F_HARDSN"].ToString();
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
			strSql.Append("select F_ID,F_GID,F_USERID,F_Token,F_StartTime,F_EndTime,F_InDate,F_ReDate,F_Status,F_Memo,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_VER_OS,F_VER_SOFT,F_IP,F_HARDINFO,F_HARDSN ");
			strSql.Append(" FROM NT_USERS_Token ");
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
			strSql.Append(" F_ID,F_GID,F_USERID,F_Token,F_StartTime,F_EndTime,F_InDate,F_ReDate,F_Status,F_Memo,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_VER_OS,F_VER_SOFT,F_IP,F_HARDINFO,F_HARDSN ");
			strSql.Append(" FROM NT_USERS_Token ");
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
			strSql.Append("select count(1) FROM NT_USERS_Token ");
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
			strSql.Append(")AS Row, T.*  from NT_USERS_Token T ");
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
			parameters[0].Value = "NT_USERS_Token";
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
        /// 更新一条数据
        /// </summary>
        public bool Update(String UserID,String Token,DateTime EndDate)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update NT_USERS_Token set ");
            strSql.Append("F_Token=@F_Token,");
            strSql.Append("F_StartTime=getDate(),");
            strSql.Append("F_EndTime=@F_EndTime,");
            strSql.Append("F_InDate=getDate(),");
            strSql.Append("F_ReDate=getDate()");
            strSql.Append(" where F_USERID=@F_USERID");
            SqlParameter[] parameters = {
					new SqlParameter("@F_Token", SqlDbType.VarChar,100),
					new SqlParameter("@F_EndTime", SqlDbType.DateTime),
					new SqlParameter("@F_USERID", SqlDbType.VarChar,40)
                                        };
            parameters[0].Value = Token;
            parameters[1].Value = EndDate;
            parameters[2].Value = UserID;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 是否存在该记录
        /// </summary>
        public bool ExistsByUserID(String UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from NT_USERS_Token");
            strSql.Append(" where F_USERID=@F_USERID");
            SqlParameter[] parameters = {
					new SqlParameter("@F_USERID", SqlDbType.VarChar)
			};
            parameters[0].Value = UserID;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool IsTokenOutDate(String userID,String token)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select F_Token from NT_USERS_Token");
            strSql.Append(" where F_USERID=@F_USERID AND F_StartTime <= GETDATE() AND F_EndTime >= getdate() ");
            SqlParameter[] parameters = {
					new SqlParameter("@F_USERID", SqlDbType.NVarChar)
			};
            parameters[0].Value = userID;
            Object tokenData = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (tokenData!=null&&token.Equals(tokenData.ToString()))
            {
                return false;
            }
            return true;
        }

		#endregion  ExtensionMethod
	}
}

