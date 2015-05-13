
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HealthCloud.DBDAL
{
	/// <summary>
	/// 数据访问类:V_NT_USERS
	/// </summary>
	public partial class V_NT_USERS
	{
		public V_NT_USERS()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HealthCloud.DBModel.V_NT_USERS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into V_NT_USERS(");
			strSql.Append("F_ID,F_GID,F_USERNAME,F_PWD,F_MOBILE,F_TYPE,F_NAME,F_EMAIL,F_WEIGHT,F_HEIGHT,F_INDATE,F_REDATE,F_STATUS,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_MOBILE2,F_MOBILE3,F_ALTERPWD,F_JOB,F_ADDR,SEX,F_TYPENAME,MAXTestTime,NOTTestLength)");
			strSql.Append(" values (");
			strSql.Append("@F_ID,@F_GID,@F_USERNAME,@F_PWD,@F_MOBILE,@F_TYPE,@F_NAME,@F_EMAIL,@F_WEIGHT,@F_HEIGHT,@F_INDATE,@F_REDATE,@F_STATUS,@F_MEMO,@F_BAK1,@F_BAK2,@F_BAK3,@F_BAK4,@F_MOBILE2,@F_MOBILE3,@F_ALTERPWD,@F_JOB,@F_ADDR,@SEX,@F_TYPENAME,@MAXTestTime,@NOTTestLength)");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.BigInt,8),
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
					new SqlParameter("@SEX", SqlDbType.VarChar,2),
					new SqlParameter("@F_TYPENAME", SqlDbType.VarChar,100),
					new SqlParameter("@MAXTestTime", SqlDbType.DateTime),
					new SqlParameter("@NOTTestLength", SqlDbType.Int,4)};
			parameters[0].Value = model.F_ID;
			parameters[1].Value = model.F_GID;
			parameters[2].Value = model.F_USERNAME;
			parameters[3].Value = model.F_PWD;
			parameters[4].Value = model.F_MOBILE;
			parameters[5].Value = model.F_TYPE;
			parameters[6].Value = model.F_NAME;
			parameters[7].Value = model.F_EMAIL;
			parameters[8].Value = model.F_WEIGHT;
			parameters[9].Value = model.F_HEIGHT;
			parameters[10].Value = model.F_INDATE;
			parameters[11].Value = model.F_REDATE;
			parameters[12].Value = model.F_STATUS;
			parameters[13].Value = model.F_MEMO;
			parameters[14].Value = model.F_BAK1;
			parameters[15].Value = model.F_BAK2;
			parameters[16].Value = model.F_BAK3;
			parameters[17].Value = model.F_BAK4;
			parameters[18].Value = model.F_MOBILE2;
			parameters[19].Value = model.F_MOBILE3;
			parameters[20].Value = model.F_ALTERPWD;
			parameters[21].Value = model.F_JOB;
			parameters[22].Value = model.F_ADDR;
			parameters[23].Value = model.SEX;
			parameters[24].Value = model.F_TYPENAME;
			parameters[25].Value = model.MAXTestTime;
			parameters[26].Value = model.NOTTestLength;

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
		public bool Update(HealthCloud.DBModel.V_NT_USERS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update V_NT_USERS set ");
			strSql.Append("F_ID=@F_ID,");
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
			strSql.Append("F_ADDR=@F_ADDR,");
			strSql.Append("SEX=@SEX,");
			strSql.Append("F_TYPENAME=@F_TYPENAME,");
			strSql.Append("MAXTestTime=@MAXTestTime,");
			strSql.Append("NOTTestLength=@NOTTestLength");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.BigInt,8),
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
					new SqlParameter("@SEX", SqlDbType.VarChar,2),
					new SqlParameter("@F_TYPENAME", SqlDbType.VarChar,100),
					new SqlParameter("@MAXTestTime", SqlDbType.DateTime),
					new SqlParameter("@NOTTestLength", SqlDbType.Int,4)};
			parameters[0].Value = model.F_ID;
			parameters[1].Value = model.F_GID;
			parameters[2].Value = model.F_USERNAME;
			parameters[3].Value = model.F_PWD;
			parameters[4].Value = model.F_MOBILE;
			parameters[5].Value = model.F_TYPE;
			parameters[6].Value = model.F_NAME;
			parameters[7].Value = model.F_EMAIL;
			parameters[8].Value = model.F_WEIGHT;
			parameters[9].Value = model.F_HEIGHT;
			parameters[10].Value = model.F_INDATE;
			parameters[11].Value = model.F_REDATE;
			parameters[12].Value = model.F_STATUS;
			parameters[13].Value = model.F_MEMO;
			parameters[14].Value = model.F_BAK1;
			parameters[15].Value = model.F_BAK2;
			parameters[16].Value = model.F_BAK3;
			parameters[17].Value = model.F_BAK4;
			parameters[18].Value = model.F_MOBILE2;
			parameters[19].Value = model.F_MOBILE3;
			parameters[20].Value = model.F_ALTERPWD;
			parameters[21].Value = model.F_JOB;
			parameters[22].Value = model.F_ADDR;
			parameters[23].Value = model.SEX;
			parameters[24].Value = model.F_TYPENAME;
			parameters[25].Value = model.MAXTestTime;
			parameters[26].Value = model.NOTTestLength;

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
			strSql.Append("delete from V_NT_USERS ");
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
		public HealthCloud.DBModel.V_NT_USERS GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_ID,F_GID,F_USERNAME,F_PWD,F_MOBILE,F_TYPE,F_NAME,F_EMAIL,F_WEIGHT,F_HEIGHT,F_INDATE,F_REDATE,F_STATUS,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_MOBILE2,F_MOBILE3,F_ALTERPWD,F_JOB,F_ADDR,SEX,F_TYPENAME,MAXTestTime,NOTTestLength from V_NT_USERS ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			HealthCloud.DBModel.V_NT_USERS model=new HealthCloud.DBModel.V_NT_USERS();
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
		public HealthCloud.DBModel.V_NT_USERS DataRowToModel(DataRow row)
		{
			HealthCloud.DBModel.V_NT_USERS model=new HealthCloud.DBModel.V_NT_USERS();
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
				if(row["SEX"]!=null)
				{
					model.SEX=row["SEX"].ToString();
				}
				if(row["F_TYPENAME"]!=null)
				{
					model.F_TYPENAME=row["F_TYPENAME"].ToString();
				}
				if(row["MAXTestTime"]!=null && row["MAXTestTime"].ToString()!="")
				{
					model.MAXTestTime=DateTime.Parse(row["MAXTestTime"].ToString());
				}
				if(row["NOTTestLength"]!=null && row["NOTTestLength"].ToString()!="")
				{
					model.NOTTestLength=int.Parse(row["NOTTestLength"].ToString());
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
			strSql.Append("select F_ID,F_GID,F_USERNAME,F_PWD,F_MOBILE,F_TYPE,F_NAME,F_EMAIL,F_WEIGHT,F_HEIGHT,F_INDATE,F_REDATE,F_STATUS,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_MOBILE2,F_MOBILE3,F_ALTERPWD,F_JOB,F_ADDR,SEX,F_TYPENAME,MAXTestTime,NOTTestLength ");
			strSql.Append(" FROM V_NT_USERS ");
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
			strSql.Append(" F_ID,F_GID,F_USERNAME,F_PWD,F_MOBILE,F_TYPE,F_NAME,F_EMAIL,F_WEIGHT,F_HEIGHT,F_INDATE,F_REDATE,F_STATUS,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_MOBILE2,F_MOBILE3,F_ALTERPWD,F_JOB,F_ADDR,SEX,F_TYPENAME,MAXTestTime,NOTTestLength ");
			strSql.Append(" FROM V_NT_USERS ");
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
			strSql.Append("select count(1) FROM V_NT_USERS ");
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
			strSql.Append(")AS Row, T.*  from V_NT_USERS T ");
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
			parameters[0].Value = "V_NT_USERS";
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

