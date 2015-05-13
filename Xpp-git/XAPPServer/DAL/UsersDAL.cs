
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HealthCloud.DBDAL
{
	/// <summary>
	/// 数据访问类:USERS
	/// </summary>
	public partial class UsersDAL
	{
		public UsersDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long F_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NT_USERS");
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
		public long Add(HealthCloud.DBModel.USERS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NT_USERS(");
			strSql.Append("F_GID,F_USERNAME,F_PWD,F_MOBILE,F_TYPE,F_NAME,F_EMAIL,F_WEIGHT,F_HEIGHT,F_INDATE,F_REDATE,F_STATUS,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_MOBILE2,F_MOBILE3,F_ALTERPWD,F_JOB,F_ADDR)");
			strSql.Append(" values (");
			strSql.Append("@F_GID,@F_USERNAME,@F_PWD,@F_MOBILE,@F_TYPE,@F_NAME,@F_EMAIL,@F_WEIGHT,@F_HEIGHT,@F_INDATE,@F_REDATE,@F_STATUS,@F_MEMO,@F_BAK1,@F_BAK2,@F_BAK3,@F_BAK4,@F_MOBILE2,@F_MOBILE3,@F_ALTERPWD,@F_JOB,@F_ADDR)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_USERNAME", SqlDbType.Char,10),
					new SqlParameter("@F_PWD", SqlDbType.VarChar,50),
					new SqlParameter("@F_MOBILE", SqlDbType.VarChar,20),
					new SqlParameter("@F_TYPE", SqlDbType.VarChar,40),
					new SqlParameter("@F_NAME", SqlDbType.VarChar,100),
					new SqlParameter("@F_EMAIL", SqlDbType.VarChar,100),
					new SqlParameter("@F_WEIGHT", SqlDbType.Decimal,9),
					new SqlParameter("@F_HEIGHT", SqlDbType.Decimal,9),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_MEMO", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK1", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK2", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK3", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK4", SqlDbType.VarChar,100),
					new SqlParameter("@F_MOBILE2", SqlDbType.VarChar,20),
					new SqlParameter("@F_MOBILE3", SqlDbType.VarChar,20),
					new SqlParameter("@F_ALTERPWD", SqlDbType.Char,1),
					new SqlParameter("@F_JOB", SqlDbType.VarChar,100),
					new SqlParameter("@F_ADDR", SqlDbType.VarChar,500)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_USERNAME;
			parameters[2].Value = model.F_PWD;
			parameters[3].Value = model.F_MOBILE;
			parameters[4].Value = model.F_TYPE;
			parameters[5].Value = model.F_NAME;
			parameters[6].Value = model.F_EMAIL;
			parameters[7].Value = model.F_WEIGHT;
			parameters[8].Value = model.F_HEIGHT;
			parameters[9].Value = model.F_INDATE;
			parameters[10].Value = model.F_REDATE;
			parameters[11].Value = model.F_STATUS;
			parameters[12].Value = model.F_MEMO;
			parameters[13].Value = model.F_BAK1;
			parameters[14].Value = model.F_BAK2;
			parameters[15].Value = model.F_BAK3;
			parameters[16].Value = model.F_BAK4;
			parameters[17].Value = model.F_MOBILE2;
			parameters[18].Value = model.F_MOBILE3;
			parameters[19].Value = model.F_ALTERPWD;
			parameters[20].Value = model.F_JOB;
			parameters[21].Value = model.F_ADDR;

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
		public bool Update(HealthCloud.DBModel.USERS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NT_USERS set ");
			strSql.Append("F_GID=@F_GID,");
			strSql.Append("F_USERNAME=@F_USERNAME,");
			strSql.Append("F_PWD=@F_PWD,");
			strSql.Append("F_MOBILE=@F_MOBILE,");
			strSql.Append("F_TYPE=@F_TYPE,");
			strSql.Append("F_NAME=@F_NAME,");
			strSql.Append("F_EMAIL=@F_EMAIL,");
			strSql.Append("F_WEIGHT=@F_WEIGHT,");
			strSql.Append("F_HEIGHT=@F_HEIGHT,");
			strSql.Append("F_INDATE=@F_INDATE,");
			strSql.Append("F_REDATE=@F_REDATE,");
			strSql.Append("F_STATUS=@F_STATUS,");
			strSql.Append("F_MEMO=@F_MEMO,");
			strSql.Append("F_BAK1=@F_BAK1,");
			strSql.Append("F_BAK2=@F_BAK2,");
			strSql.Append("F_BAK3=@F_BAK3,");
			strSql.Append("F_BAK4=@F_BAK4,");
			strSql.Append("F_MOBILE2=@F_MOBILE2,");
			strSql.Append("F_MOBILE3=@F_MOBILE3,");
			strSql.Append("F_ALTERPWD=@F_ALTERPWD,");
			strSql.Append("F_JOB=@F_JOB,");
			strSql.Append("F_ADDR=@F_ADDR");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_USERNAME", SqlDbType.Char,10),
					new SqlParameter("@F_PWD", SqlDbType.VarChar,50),
					new SqlParameter("@F_MOBILE", SqlDbType.VarChar,20),
					new SqlParameter("@F_TYPE", SqlDbType.VarChar,40),
					new SqlParameter("@F_NAME", SqlDbType.VarChar,100),
					new SqlParameter("@F_EMAIL", SqlDbType.VarChar,100),
					new SqlParameter("@F_WEIGHT", SqlDbType.Decimal,9),
					new SqlParameter("@F_HEIGHT", SqlDbType.Decimal,9),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_MEMO", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK1", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK2", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK3", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK4", SqlDbType.VarChar,100),
					new SqlParameter("@F_MOBILE2", SqlDbType.VarChar,20),
					new SqlParameter("@F_MOBILE3", SqlDbType.VarChar,20),
					new SqlParameter("@F_ALTERPWD", SqlDbType.Char,1),
					new SqlParameter("@F_JOB", SqlDbType.VarChar,100),
					new SqlParameter("@F_ADDR", SqlDbType.VarChar,500),
					new SqlParameter("@F_ID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_USERNAME;
			parameters[2].Value = model.F_PWD;
			parameters[3].Value = model.F_MOBILE;
			parameters[4].Value = model.F_TYPE;
			parameters[5].Value = model.F_NAME;
			parameters[6].Value = model.F_EMAIL;
			parameters[7].Value = model.F_WEIGHT;
			parameters[8].Value = model.F_HEIGHT;
			parameters[9].Value = model.F_INDATE;
			parameters[10].Value = model.F_REDATE;
			parameters[11].Value = model.F_STATUS;
			parameters[12].Value = model.F_MEMO;
			parameters[13].Value = model.F_BAK1;
			parameters[14].Value = model.F_BAK2;
			parameters[15].Value = model.F_BAK3;
			parameters[16].Value = model.F_BAK4;
			parameters[17].Value = model.F_MOBILE2;
			parameters[18].Value = model.F_MOBILE3;
			parameters[19].Value = model.F_ALTERPWD;
			parameters[20].Value = model.F_JOB;
			parameters[21].Value = model.F_ADDR;
			parameters[22].Value = model.F_ID;

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
			strSql.Append("delete from NT_USERS ");
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
			strSql.Append("delete from NT_USERS ");
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
		public HealthCloud.DBModel.USERS GetModel(long F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_ID,F_GID,F_USERNAME,F_PWD,F_MOBILE,F_TYPE,F_NAME,F_EMAIL,F_WEIGHT,F_HEIGHT,F_INDATE,F_REDATE,F_STATUS,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_MOBILE2,F_MOBILE3,F_ALTERPWD,F_JOB,F_ADDR from NT_USERS ");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = F_ID;

			HealthCloud.DBModel.USERS model=new HealthCloud.DBModel.USERS();
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
		public HealthCloud.DBModel.USERS DataRowToModel(DataRow row)
		{
			HealthCloud.DBModel.USERS model=new HealthCloud.DBModel.USERS();
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
				if(row["F_USERNAME"]!=null)
				{
					model.F_USERNAME=row["F_USERNAME"].ToString();
				}
				if(row["F_PWD"]!=null)
				{
					model.F_PWD=row["F_PWD"].ToString();
				}
				if(row["F_MOBILE"]!=null)
				{
					model.F_MOBILE=row["F_MOBILE"].ToString();
				}
				if(row["F_TYPE"]!=null)
				{
					model.F_TYPE=row["F_TYPE"].ToString();
				}
				if(row["F_NAME"]!=null)
				{
					model.F_NAME=row["F_NAME"].ToString();
				}
				if(row["F_EMAIL"]!=null)
				{
					model.F_EMAIL=row["F_EMAIL"].ToString();
				}
				if(row["F_WEIGHT"]!=null && row["F_WEIGHT"].ToString()!="")
				{
					model.F_WEIGHT=decimal.Parse(row["F_WEIGHT"].ToString());
				}
				if(row["F_HEIGHT"]!=null && row["F_HEIGHT"].ToString()!="")
				{
					model.F_HEIGHT=decimal.Parse(row["F_HEIGHT"].ToString());
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
				if(row["F_MEMO"]!=null)
				{
					model.F_MEMO=row["F_MEMO"].ToString();
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
				if(row["F_MOBILE2"]!=null)
				{
					model.F_MOBILE2=row["F_MOBILE2"].ToString();
				}
				if(row["F_MOBILE3"]!=null)
				{
					model.F_MOBILE3=row["F_MOBILE3"].ToString();
				}
				if(row["F_ALTERPWD"]!=null)
				{
					model.F_ALTERPWD=row["F_ALTERPWD"].ToString();
				}
				if(row["F_JOB"]!=null)
				{
					model.F_JOB=row["F_JOB"].ToString();
				}
				if(row["F_ADDR"]!=null)
				{
					model.F_ADDR=row["F_ADDR"].ToString();
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
			strSql.Append("select F_ID,F_GID,F_USERNAME,F_PWD,F_MOBILE,F_TYPE,F_NAME,F_EMAIL,F_WEIGHT,F_HEIGHT,F_INDATE,F_REDATE,F_STATUS,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_MOBILE2,F_MOBILE3,F_ALTERPWD,F_JOB,F_ADDR ");
			strSql.Append(" FROM NT_USERS ");
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
			strSql.Append(" F_ID,F_GID,F_USERNAME,F_PWD,F_MOBILE,F_TYPE,F_NAME,F_EMAIL,F_WEIGHT,F_HEIGHT,F_INDATE,F_REDATE,F_STATUS,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_MOBILE2,F_MOBILE3,F_ALTERPWD,F_JOB,F_ADDR ");
			strSql.Append(" FROM NT_USERS ");
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
			strSql.Append("select count(1) FROM NT_USERS ");
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
			strSql.Append(")AS Row, T.*  from NT_USERS T ");
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
			parameters[0].Value = "NT_USERS";
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
        /// 是否存在该记录
        /// </summary>
        public bool ExistsByUser(String  UserName)
        {
            return ExistsByColumn("F_USERNAME", UserName, SqlDbType.NVarChar);
          
        }
        public bool ExistsByMobile(String mobile)
        {
            return ExistsByColumn("F_Mobile", mobile, SqlDbType.NVarChar);
        }
        public Boolean ExistsByEmail(String email)
        {
            return ExistsByColumn("F_EMAIL", email, SqlDbType.NVarChar);
        }

        private Boolean ExistsByColumn(String ColumnName, Object value,SqlDbType type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from NT_USERS");
            strSql.Append(" where " + ColumnName + "=@" + ColumnName);
            SqlParameter[] parameters = {
					new SqlParameter("@"+ColumnName, type)
			};
            parameters[0].Value = value;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获取用户ID
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public long GetUserFID(String userName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select F_ID from NT_USERS");
            strSql.Append(" where F_USERNAME=@F_USERNAME");
            SqlParameter[] parameters = {
					new SqlParameter("@F_USERNAME", SqlDbType.NVarChar)
			};
            parameters[0].Value = userName;
            Object value=DbHelperSQL.GetSingle(strSql.ToString(), parameters)!=null;
            if(value!=null)
            {
                return  (long)value;
            }

            return -1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public HealthCloud.DBModel.USERS GetModel(String userName, String password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 F_ID,F_GID,F_USERNAME,F_PWD,F_MOBILE,F_TYPE,F_NAME,F_EMAIL,F_WEIGHT,F_HEIGHT,F_INDATE,F_REDATE,F_STATUS,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_MOBILE2,F_MOBILE3,F_ALTERPWD,F_JOB,F_ADDR from NT_USERS ");
            strSql.Append(" where F_USERNAME=@F_USERNAME and F_PWD=@F_PWD ");
            SqlParameter[] parameters = {
					new SqlParameter("@F_USERNAME", SqlDbType.NVarChar),
                    new SqlParameter("@F_PWD", SqlDbType.NVarChar)
			};
            parameters[0].Value = userName;
            parameters[1].Value = password;
            HealthCloud.DBModel.USERS model = new HealthCloud.DBModel.USERS();
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
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public HealthCloud.DBModel.USERS GetAcountByUserID(String userID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from NT_USERS ");
            strSql.Append(" where F_GID=@F_GID ");
            SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.NVarChar),
                   
			};
            parameters[0].Value = userID;
            HealthCloud.DBModel.USERS model = new HealthCloud.DBModel.USERS();
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

