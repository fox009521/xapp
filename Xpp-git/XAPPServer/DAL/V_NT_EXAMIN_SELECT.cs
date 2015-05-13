
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HealthCloud.DBDAL
{
	/// <summary>
	/// 数据访问类:V_NT_EXAMIN_SELECT
	/// </summary>
	public partial class V_NT_EXAMIN_SELECT
	{
		public V_NT_EXAMIN_SELECT()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HealthCloud.DBModel.V_NT_EXAMIN_SELECT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into V_NT_EXAMIN_SELECT(");
			strSql.Append("F_ID,F_GID,F_PTNO,F_DEVICE_NO,F_DEVICE_TIME,F_USERNUM,F_RFID,F_SBP,F_DBP,F_HR,F_BODY_TEMP,F_GLUCOSE,F_WEIGHT,F_CHOL,F_UA,F_ROOM_TEMP,F_INDATE,F_REDATE,F_STATUS,F_ERROR,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_XUEYA,F_USERNAME,F_NAME)");
			strSql.Append(" values (");
			strSql.Append("@F_ID,@F_GID,@F_PTNO,@F_DEVICE_NO,@F_DEVICE_TIME,@F_USERNUM,@F_RFID,@F_SBP,@F_DBP,@F_HR,@F_BODY_TEMP,@F_GLUCOSE,@F_WEIGHT,@F_CHOL,@F_UA,@F_ROOM_TEMP,@F_INDATE,@F_REDATE,@F_STATUS,@F_ERROR,@F_MEMO,@F_BAK1,@F_BAK2,@F_BAK3,@F_BAK4,@F_XUEYA,@F_USERNAME,@F_NAME)");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.BigInt,8),
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_PTNO", SqlDbType.Char,10),
					new SqlParameter("@F_DEVICE_NO", SqlDbType.Char,18),
					new SqlParameter("@F_DEVICE_TIME", SqlDbType.DateTime),
					new SqlParameter("@F_USERNUM", SqlDbType.VarChar,40),
					new SqlParameter("@F_RFID", SqlDbType.Char,20),
					new SqlParameter("@F_SBP", SqlDbType.Decimal,5),
					new SqlParameter("@F_DBP", SqlDbType.Decimal,5),
					new SqlParameter("@F_HR", SqlDbType.Decimal,5),
					new SqlParameter("@F_BODY_TEMP", SqlDbType.Decimal,5),
					new SqlParameter("@F_GLUCOSE", SqlDbType.Decimal,5),
					new SqlParameter("@F_WEIGHT", SqlDbType.Decimal,5),
					new SqlParameter("@F_CHOL", SqlDbType.Decimal,5),
					new SqlParameter("@F_UA", SqlDbType.Decimal,5),
					new SqlParameter("@F_ROOM_TEMP", SqlDbType.Decimal,5),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_ERROR", SqlDbType.VarChar,100),
					new SqlParameter("@F_MEMO", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK1", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK2", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK3", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK4", SqlDbType.VarChar,100),
					new SqlParameter("@F_XUEYA", SqlDbType.VarChar,61),
					new SqlParameter("@F_USERNAME", SqlDbType.Char,10),
					new SqlParameter("@F_NAME", SqlDbType.VarChar,100)};
			parameters[0].Value = model.F_ID;
			parameters[1].Value = model.F_GID;
			parameters[2].Value = model.F_PTNO;
			parameters[3].Value = model.F_DEVICE_NO;
			parameters[4].Value = model.F_DEVICE_TIME;
			parameters[5].Value = model.F_USERNUM;
			parameters[6].Value = model.F_RFID;
			parameters[7].Value = model.F_SBP;
			parameters[8].Value = model.F_DBP;
			parameters[9].Value = model.F_HR;
			parameters[10].Value = model.F_BODY_TEMP;
			parameters[11].Value = model.F_GLUCOSE;
			parameters[12].Value = model.F_WEIGHT;
			parameters[13].Value = model.F_CHOL;
			parameters[14].Value = model.F_UA;
			parameters[15].Value = model.F_ROOM_TEMP;
			parameters[16].Value = model.F_INDATE;
			parameters[17].Value = model.F_REDATE;
			parameters[18].Value = model.F_STATUS;
			parameters[19].Value = model.F_ERROR;
			parameters[20].Value = model.F_MEMO;
			parameters[21].Value = model.F_BAK1;
			parameters[22].Value = model.F_BAK2;
			parameters[23].Value = model.F_BAK3;
			parameters[24].Value = model.F_BAK4;
			parameters[25].Value = model.F_XUEYA;
			parameters[26].Value = model.F_USERNAME;
			parameters[27].Value = model.F_NAME;

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
		public bool Update(HealthCloud.DBModel.V_NT_EXAMIN_SELECT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update V_NT_EXAMIN_SELECT set ");
			strSql.Append("F_ID=@F_ID,");
			strSql.Append("F_GID=@F_GID,");
			strSql.Append("F_PTNO=@F_PTNO,");
			strSql.Append("F_DEVICE_NO=@F_DEVICE_NO,");
			strSql.Append("F_DEVICE_TIME=@F_DEVICE_TIME,");
			strSql.Append("F_USERNUM=@F_USERNUM,");
			strSql.Append("F_RFID=@F_RFID,");
			strSql.Append("F_SBP=@F_SBP,");
			strSql.Append("F_DBP=@F_DBP,");
			strSql.Append("F_HR=@F_HR,");
			strSql.Append("F_BODY_TEMP=@F_BODY_TEMP,");
			strSql.Append("F_GLUCOSE=@F_GLUCOSE,");
			strSql.Append("F_WEIGHT=@F_WEIGHT,");
			strSql.Append("F_CHOL=@F_CHOL,");
			strSql.Append("F_UA=@F_UA,");
			strSql.Append("F_ROOM_TEMP=@F_ROOM_TEMP,");
			strSql.Append("F_INDATE=@F_INDATE,");
			strSql.Append("F_REDATE=@F_REDATE,");
			strSql.Append("F_STATUS=@F_STATUS,");
			strSql.Append("F_ERROR=@F_ERROR,");
			strSql.Append("F_MEMO=@F_MEMO,");
			strSql.Append("F_BAK1=@F_BAK1,");
			strSql.Append("F_BAK2=@F_BAK2,");
			strSql.Append("F_BAK3=@F_BAK3,");
			strSql.Append("F_BAK4=@F_BAK4,");
			strSql.Append("F_XUEYA=@F_XUEYA,");
			strSql.Append("F_USERNAME=@F_USERNAME,");
			strSql.Append("F_NAME=@F_NAME");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.BigInt,8),
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_PTNO", SqlDbType.Char,10),
					new SqlParameter("@F_DEVICE_NO", SqlDbType.Char,18),
					new SqlParameter("@F_DEVICE_TIME", SqlDbType.DateTime),
					new SqlParameter("@F_USERNUM", SqlDbType.VarChar,40),
					new SqlParameter("@F_RFID", SqlDbType.Char,20),
					new SqlParameter("@F_SBP", SqlDbType.Decimal,5),
					new SqlParameter("@F_DBP", SqlDbType.Decimal,5),
					new SqlParameter("@F_HR", SqlDbType.Decimal,5),
					new SqlParameter("@F_BODY_TEMP", SqlDbType.Decimal,5),
					new SqlParameter("@F_GLUCOSE", SqlDbType.Decimal,5),
					new SqlParameter("@F_WEIGHT", SqlDbType.Decimal,5),
					new SqlParameter("@F_CHOL", SqlDbType.Decimal,5),
					new SqlParameter("@F_UA", SqlDbType.Decimal,5),
					new SqlParameter("@F_ROOM_TEMP", SqlDbType.Decimal,5),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_ERROR", SqlDbType.VarChar,100),
					new SqlParameter("@F_MEMO", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK1", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK2", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK3", SqlDbType.VarChar,100),
					new SqlParameter("@F_BAK4", SqlDbType.VarChar,100),
					new SqlParameter("@F_XUEYA", SqlDbType.VarChar,61),
					new SqlParameter("@F_USERNAME", SqlDbType.Char,10),
					new SqlParameter("@F_NAME", SqlDbType.VarChar,100)};
			parameters[0].Value = model.F_ID;
			parameters[1].Value = model.F_GID;
			parameters[2].Value = model.F_PTNO;
			parameters[3].Value = model.F_DEVICE_NO;
			parameters[4].Value = model.F_DEVICE_TIME;
			parameters[5].Value = model.F_USERNUM;
			parameters[6].Value = model.F_RFID;
			parameters[7].Value = model.F_SBP;
			parameters[8].Value = model.F_DBP;
			parameters[9].Value = model.F_HR;
			parameters[10].Value = model.F_BODY_TEMP;
			parameters[11].Value = model.F_GLUCOSE;
			parameters[12].Value = model.F_WEIGHT;
			parameters[13].Value = model.F_CHOL;
			parameters[14].Value = model.F_UA;
			parameters[15].Value = model.F_ROOM_TEMP;
			parameters[16].Value = model.F_INDATE;
			parameters[17].Value = model.F_REDATE;
			parameters[18].Value = model.F_STATUS;
			parameters[19].Value = model.F_ERROR;
			parameters[20].Value = model.F_MEMO;
			parameters[21].Value = model.F_BAK1;
			parameters[22].Value = model.F_BAK2;
			parameters[23].Value = model.F_BAK3;
			parameters[24].Value = model.F_BAK4;
			parameters[25].Value = model.F_XUEYA;
			parameters[26].Value = model.F_USERNAME;
			parameters[27].Value = model.F_NAME;

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
			strSql.Append("delete from V_NT_EXAMIN_SELECT ");
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
		public HealthCloud.DBModel.V_NT_EXAMIN_SELECT GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_ID,F_GID,F_PTNO,F_DEVICE_NO,F_DEVICE_TIME,F_USERNUM,F_RFID,F_SBP,F_DBP,F_HR,F_BODY_TEMP,F_GLUCOSE,F_WEIGHT,F_CHOL,F_UA,F_ROOM_TEMP,F_INDATE,F_REDATE,F_STATUS,F_ERROR,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_XUEYA,F_USERNAME,F_NAME from V_NT_EXAMIN_SELECT ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			HealthCloud.DBModel.V_NT_EXAMIN_SELECT model=new HealthCloud.DBModel.V_NT_EXAMIN_SELECT();
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
		public HealthCloud.DBModel.V_NT_EXAMIN_SELECT DataRowToModel(DataRow row)
		{
			HealthCloud.DBModel.V_NT_EXAMIN_SELECT model=new HealthCloud.DBModel.V_NT_EXAMIN_SELECT();
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
				if(row["F_PTNO"]!=null)
				{
					model.F_PTNO=row["F_PTNO"].ToString();
				}
				if(row["F_DEVICE_NO"]!=null)
				{
					model.F_DEVICE_NO=row["F_DEVICE_NO"].ToString();
				}
				if(row["F_DEVICE_TIME"]!=null && row["F_DEVICE_TIME"].ToString()!="")
				{
					model.F_DEVICE_TIME=DateTime.Parse(row["F_DEVICE_TIME"].ToString());
				}
				if(row["F_USERNUM"]!=null)
				{
					model.F_USERNUM=row["F_USERNUM"].ToString();
				}
				if(row["F_RFID"]!=null)
				{
					model.F_RFID=row["F_RFID"].ToString();
				}
				if(row["F_SBP"]!=null && row["F_SBP"].ToString()!="")
				{
					model.F_SBP=decimal.Parse(row["F_SBP"].ToString());
				}
				if(row["F_DBP"]!=null && row["F_DBP"].ToString()!="")
				{
					model.F_DBP=decimal.Parse(row["F_DBP"].ToString());
				}
				if(row["F_HR"]!=null && row["F_HR"].ToString()!="")
				{
					model.F_HR=decimal.Parse(row["F_HR"].ToString());
				}
				if(row["F_BODY_TEMP"]!=null && row["F_BODY_TEMP"].ToString()!="")
				{
					model.F_BODY_TEMP=decimal.Parse(row["F_BODY_TEMP"].ToString());
				}
				if(row["F_GLUCOSE"]!=null && row["F_GLUCOSE"].ToString()!="")
				{
					model.F_GLUCOSE=decimal.Parse(row["F_GLUCOSE"].ToString());
				}
				if(row["F_WEIGHT"]!=null && row["F_WEIGHT"].ToString()!="")
				{
					model.F_WEIGHT=decimal.Parse(row["F_WEIGHT"].ToString());
				}
				if(row["F_CHOL"]!=null && row["F_CHOL"].ToString()!="")
				{
					model.F_CHOL=decimal.Parse(row["F_CHOL"].ToString());
				}
				if(row["F_UA"]!=null && row["F_UA"].ToString()!="")
				{
					model.F_UA=decimal.Parse(row["F_UA"].ToString());
				}
				if(row["F_ROOM_TEMP"]!=null && row["F_ROOM_TEMP"].ToString()!="")
				{
					model.F_ROOM_TEMP=decimal.Parse(row["F_ROOM_TEMP"].ToString());
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
				if(row["F_ERROR"]!=null)
				{
					model.F_ERROR=row["F_ERROR"].ToString();
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
				if(row["F_XUEYA"]!=null)
				{
					model.F_XUEYA=row["F_XUEYA"].ToString();
				}
				if(row["F_USERNAME"]!=null)
				{
					model.F_USERNAME=row["F_USERNAME"].ToString();
				}
				if(row["F_NAME"]!=null)
				{
					model.F_NAME=row["F_NAME"].ToString();
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
			strSql.Append("select F_ID,F_GID,F_PTNO,F_DEVICE_NO,F_DEVICE_TIME,F_USERNUM,F_RFID,F_SBP,F_DBP,F_HR,F_BODY_TEMP,F_GLUCOSE,F_WEIGHT,F_CHOL,F_UA,F_ROOM_TEMP,F_INDATE,F_REDATE,F_STATUS,F_ERROR,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_XUEYA,F_USERNAME,F_NAME ");
			strSql.Append(" FROM V_NT_EXAMIN_SELECT ");
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
			strSql.Append(" F_ID,F_GID,F_PTNO,F_DEVICE_NO,F_DEVICE_TIME,F_USERNUM,F_RFID,F_SBP,F_DBP,F_HR,F_BODY_TEMP,F_GLUCOSE,F_WEIGHT,F_CHOL,F_UA,F_ROOM_TEMP,F_INDATE,F_REDATE,F_STATUS,F_ERROR,F_MEMO,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_XUEYA,F_USERNAME,F_NAME ");
			strSql.Append(" FROM V_NT_EXAMIN_SELECT ");
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
			strSql.Append("select count(1) FROM V_NT_EXAMIN_SELECT ");
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
			strSql.Append(")AS Row, T.*  from V_NT_EXAMIN_SELECT T ");
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
			parameters[0].Value = "V_NT_EXAMIN_SELECT";
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

