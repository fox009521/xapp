
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;
using System.Collections.Generic;
using HealthCloud.DBModel;//Please add references
namespace HealthCloud.DBDAL
{
	/// <summary>
	/// 数据访问类:HHT_Request
	/// </summary>
	public partial class HHTRequestDAL
	{
		public HHTRequestDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(HealthCloud.DBModel.HHT_Request model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NT_HHT_Request(");
			strSql.Append("F_GID,F_UserID,F_Type,F_ServerTime,F_BeginDate,F_EndDate,F_SN,F_DATA1,F_DATA2,F_INDATE,F_REDATE,F_STATUS,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_Mtp,F_Min)");
			strSql.Append(" values (");
			strSql.Append("@F_GID,@F_UserID,@F_Type,@F_ServerTime,@F_BeginDate,@F_EndDate,@F_SN,@F_DATA1,@F_DATA2,@F_INDATE,@F_REDATE,@F_STATUS,@F_BAK1,@F_BAK2,@F_BAK3,@F_BAK4,@F_Mtp,@F_Min)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_UserID", SqlDbType.VarChar,40),
					new SqlParameter("@F_Type", SqlDbType.VarChar,50),
					new SqlParameter("@F_ServerTime", SqlDbType.VarChar,50),
					new SqlParameter("@F_BeginDate", SqlDbType.DateTime),
					new SqlParameter("@F_EndDate", SqlDbType.DateTime),
					new SqlParameter("@F_SN", SqlDbType.VarChar,50),
					new SqlParameter("@F_DATA1", SqlDbType.Text),
					new SqlParameter("@F_DATA2", SqlDbType.Text),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_BAK1", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK2", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK3", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK4", SqlDbType.VarChar,200),
					new SqlParameter("@F_Mtp", SqlDbType.VarChar,50),
					new SqlParameter("@F_Min", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_UserID;
			parameters[2].Value = model.F_Type;
			parameters[3].Value = model.F_ServerTime;
			parameters[4].Value = model.F_BeginDate;
			parameters[5].Value = model.F_EndDate;
			parameters[6].Value = model.F_SN;
			parameters[7].Value = model.F_DATA1;
			parameters[8].Value = model.F_DATA2;
			parameters[9].Value = model.F_INDATE;
			parameters[10].Value = model.F_REDATE;
			parameters[11].Value = model.F_STATUS;
			parameters[12].Value = model.F_BAK1;
			parameters[13].Value = model.F_BAK2;
			parameters[14].Value = model.F_BAK3;
			parameters[15].Value = model.F_BAK4;
			parameters[16].Value = model.F_Mtp;
			parameters[17].Value = model.F_Min;

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
		public bool Update(HealthCloud.DBModel.HHT_Request model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NT_HHT_Request set ");
			strSql.Append("F_GID=@F_GID,");
			strSql.Append("F_UserID=@F_UserID,");
			strSql.Append("F_Type=@F_Type,");
			strSql.Append("F_ServerTime=@F_ServerTime,");
			strSql.Append("F_BeginDate=@F_BeginDate,");
			strSql.Append("F_EndDate=@F_EndDate,");
			strSql.Append("F_SN=@F_SN,");
			strSql.Append("F_DATA1=@F_DATA1,");
			strSql.Append("F_DATA2=@F_DATA2,");
			strSql.Append("F_INDATE=@F_INDATE,");
			strSql.Append("F_REDATE=@F_REDATE,");
			strSql.Append("F_STATUS=@F_STATUS,");
			strSql.Append("F_BAK1=@F_BAK1,");
			strSql.Append("F_BAK2=@F_BAK2,");
			strSql.Append("F_BAK3=@F_BAK3,");
			strSql.Append("F_BAK4=@F_BAK4,");
			strSql.Append("F_Mtp=@F_Mtp,");
			strSql.Append("F_Min=@F_Min");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_UserID", SqlDbType.VarChar,40),
					new SqlParameter("@F_Type", SqlDbType.VarChar,50),
					new SqlParameter("@F_ServerTime", SqlDbType.VarChar,50),
					new SqlParameter("@F_BeginDate", SqlDbType.DateTime),
					new SqlParameter("@F_EndDate", SqlDbType.DateTime),
					new SqlParameter("@F_SN", SqlDbType.VarChar,50),
					new SqlParameter("@F_DATA1", SqlDbType.Text),
					new SqlParameter("@F_DATA2", SqlDbType.Text),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_BAK1", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK2", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK3", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK4", SqlDbType.VarChar,200),
					new SqlParameter("@F_Mtp", SqlDbType.VarChar,50),
					new SqlParameter("@F_Min", SqlDbType.VarChar,50),
					new SqlParameter("@F_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_UserID;
			parameters[2].Value = model.F_Type;
			parameters[3].Value = model.F_ServerTime;
			parameters[4].Value = model.F_BeginDate;
			parameters[5].Value = model.F_EndDate;
			parameters[6].Value = model.F_SN;
			parameters[7].Value = model.F_DATA1;
			parameters[8].Value = model.F_DATA2;
			parameters[9].Value = model.F_INDATE;
			parameters[10].Value = model.F_REDATE;
			parameters[11].Value = model.F_STATUS;
			parameters[12].Value = model.F_BAK1;
			parameters[13].Value = model.F_BAK2;
			parameters[14].Value = model.F_BAK3;
			parameters[15].Value = model.F_BAK4;
			parameters[16].Value = model.F_Mtp;
			parameters[17].Value = model.F_Min;
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
		public bool Delete(int F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NT_HHT_Request ");
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
			strSql.Append("delete from NT_HHT_Request ");
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
		public HealthCloud.DBModel.HHT_Request GetModel(int F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_ID,F_GID,F_UserID,F_Type,F_ServerTime,F_BeginDate,F_EndDate,F_SN,F_DATA1,F_DATA2,F_INDATE,F_REDATE,F_STATUS,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_Mtp,F_Min from NT_HHT_Request ");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = F_ID;

			HealthCloud.DBModel.HHT_Request model=new HealthCloud.DBModel.HHT_Request();
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
		public HealthCloud.DBModel.HHT_Request DataRowToModel(DataRow row)
		{
			HealthCloud.DBModel.HHT_Request model=new HealthCloud.DBModel.HHT_Request();
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
				if(row["F_UserID"]!=null)
				{
					model.F_UserID=row["F_UserID"].ToString();
				}
				if(row["F_Type"]!=null)
				{
					model.F_Type=row["F_Type"].ToString();
				}
				if(row["F_ServerTime"]!=null)
				{
					model.F_ServerTime=row["F_ServerTime"].ToString();
				}
				if(row["F_BeginDate"]!=null && row["F_BeginDate"].ToString()!="")
				{
					model.F_BeginDate=DateTime.Parse(row["F_BeginDate"].ToString());
				}
				if(row["F_EndDate"]!=null && row["F_EndDate"].ToString()!="")
				{
					model.F_EndDate=DateTime.Parse(row["F_EndDate"].ToString());
				}
				if(row["F_SN"]!=null)
				{
					model.F_SN=row["F_SN"].ToString();
				}
				if(row["F_DATA1"]!=null)
				{
					model.F_DATA1=row["F_DATA1"].ToString();
				}
				if(row["F_DATA2"]!=null)
				{
					model.F_DATA2=row["F_DATA2"].ToString();
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
				if(row["F_Mtp"]!=null)
				{
					model.F_Mtp=row["F_Mtp"].ToString();
				}
				if(row["F_Min"]!=null)
				{
					model.F_Min=row["F_Min"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetDataSet(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select F_ID,F_GID,F_UserID,F_Type,F_ServerTime,F_BeginDate,F_EndDate,F_SN,F_DATA1,F_DATA2,F_INDATE,F_REDATE,F_STATUS,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_Mtp,F_Min ");
			strSql.Append(" FROM NT_HHT_Request ");
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
			strSql.Append(" F_ID,F_GID,F_UserID,F_Type,F_ServerTime,F_BeginDate,F_EndDate,F_SN,F_DATA1,F_DATA2,F_INDATE,F_REDATE,F_STATUS,F_BAK1,F_BAK2,F_BAK3,F_BAK4,F_Mtp,F_Min ");
			strSql.Append(" FROM NT_HHT_Request ");
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
			strSql.Append("select count(1) FROM NT_HHT_Request ");
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
			strSql.Append(")AS Row, T.*  from NT_HHT_Request T ");
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
			parameters[0].Value = "NT_HHT_Request";
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
        public List<HHT_Request> GetList(String strWhere)
        {
            List<HHT_Request> list = new List<HHT_Request>();
            DataSet ds=GetDataSet(strWhere);
            if (ds != null)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    list.Add(DataRowToModel(row));
                }
            }
            return list;

        }
		#endregion  ExtensionMethod
	}
}

