using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;
using HealthCloud.DBModel;
using System.Collections.Generic;//Please add references
namespace HealthCloud.DBDAL
{
	/// <summary>
	/// 数据访问类:BBS
	/// </summary>
	public partial class BBSDAL
	{
		public BBSDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(HealthCloud.DBModel.BBS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NT_BBS(");
			strSql.Append("F_GID,F_OperID,F_Content,F_OperTime,F_INDATE,F_REDATE,F_STATUS,F_BAK1,F_BAK2,F_BAK3,F_BAK4)");
			strSql.Append(" values (");
			strSql.Append("@F_GID,@F_OperID,@F_Content,@F_OperTime,@F_INDATE,@F_REDATE,@F_STATUS,@F_BAK1,@F_BAK2,@F_BAK3,@F_BAK4)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_OperID", SqlDbType.VarChar,40),
					new SqlParameter("@F_Content", SqlDbType.VarChar,2000),
					new SqlParameter("@F_OperTime", SqlDbType.DateTime),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_BAK1", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK2", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK3", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK4", SqlDbType.VarChar,200)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_OperID;
			parameters[2].Value = model.F_Content;
			parameters[3].Value = model.F_OperTime;
			parameters[4].Value = model.F_INDATE;
			parameters[5].Value = model.F_REDATE;
			parameters[6].Value = model.F_STATUS;
			parameters[7].Value = model.F_BAK1;
			parameters[8].Value = model.F_BAK2;
			parameters[9].Value = model.F_BAK3;
			parameters[10].Value = model.F_BAK4;

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
		public bool Update(HealthCloud.DBModel.BBS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NT_BBS set ");
			strSql.Append("F_GID=@F_GID,");
			strSql.Append("F_OperID=@F_OperID,");
			strSql.Append("F_Content=@F_Content,");
			strSql.Append("F_OperTime=@F_OperTime,");
			strSql.Append("F_INDATE=@F_INDATE,");
			strSql.Append("F_REDATE=@F_REDATE,");
			strSql.Append("F_STATUS=@F_STATUS,");
			strSql.Append("F_BAK1=@F_BAK1,");
			strSql.Append("F_BAK2=@F_BAK2,");
			strSql.Append("F_BAK3=@F_BAK3,");
			strSql.Append("F_BAK4=@F_BAK4");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.VarChar,40),
					new SqlParameter("@F_OperID", SqlDbType.VarChar,40),
					new SqlParameter("@F_Content", SqlDbType.VarChar,2000),
					new SqlParameter("@F_OperTime", SqlDbType.DateTime),
					new SqlParameter("@F_INDATE", SqlDbType.DateTime),
					new SqlParameter("@F_REDATE", SqlDbType.DateTime),
					new SqlParameter("@F_STATUS", SqlDbType.Char,1),
					new SqlParameter("@F_BAK1", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK2", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK3", SqlDbType.VarChar,200),
					new SqlParameter("@F_BAK4", SqlDbType.VarChar,200),
					new SqlParameter("@F_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.F_GID;
			parameters[1].Value = model.F_OperID;
			parameters[2].Value = model.F_Content;
			parameters[3].Value = model.F_OperTime;
			parameters[4].Value = model.F_INDATE;
			parameters[5].Value = model.F_REDATE;
			parameters[6].Value = model.F_STATUS;
			parameters[7].Value = model.F_BAK1;
			parameters[8].Value = model.F_BAK2;
			parameters[9].Value = model.F_BAK3;
			parameters[10].Value = model.F_BAK4;
			parameters[11].Value = model.F_ID;

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
			strSql.Append("delete from NT_BBS ");
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
        /// 删除留言
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="gid"></param>
        /// <returns></returns>
        public Boolean Delete(String userID, String gid)
        {
       
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from NT_BBS ");
            strSql.Append(" where F_GID=@F_GID and F_OperID=@F_OperID");
            SqlParameter[] parameters = {
					new SqlParameter("@F_GID", SqlDbType.NVarChar),
                    new SqlParameter("@F_OperID", SqlDbType.NVarChar)
			};
            parameters[0].Value = gid;
            parameters[1].Value = userID;
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string F_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NT_BBS ");
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
		public HealthCloud.DBModel.BBS GetModel(int F_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_ID,F_GID,F_OperID,F_Content,F_OperTime,F_INDATE,F_REDATE,F_STATUS,F_BAK1,F_BAK2,F_BAK3,F_BAK4 from NT_BBS ");
			strSql.Append(" where F_ID=@F_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = F_ID;

			HealthCloud.DBModel.BBS model=new HealthCloud.DBModel.BBS();
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
		public HealthCloud.DBModel.BBS DataRowToModel(DataRow row)
		{
			HealthCloud.DBModel.BBS model=new HealthCloud.DBModel.BBS();
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
				if(row["F_OperID"]!=null)
				{
					model.F_OperID=row["F_OperID"].ToString();
				}
				if(row["F_Content"]!=null)
				{
					model.F_Content=row["F_Content"].ToString();
				}
				if(row["F_OperTime"]!=null && row["F_OperTime"].ToString()!="")
				{
					model.F_OperTime=DateTime.Parse(row["F_OperTime"].ToString());
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select F_ID,F_GID,F_OperID,F_Content,F_OperTime,F_INDATE,F_REDATE,F_STATUS,F_BAK1,F_BAK2,F_BAK3,F_BAK4 ");
			strSql.Append(" FROM NT_BBS ");
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
			strSql.Append(" F_ID,F_GID,F_OperID,F_Content,F_OperTime,F_INDATE,F_REDATE,F_STATUS,F_BAK1,F_BAK2,F_BAK3,F_BAK4 ");
			strSql.Append(" FROM NT_BBS ");
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
			strSql.Append("select count(1) FROM NT_BBS ");
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
			strSql.Append(")AS Row, T.*  from NT_BBS T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="orderby"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public List<BBS> GetList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            List<BBS> result = new List<BBS>();
            DataSet dataSet = GetListByPage(strWhere, orderby, startIndex, endIndex);
            if (dataSet != null)
            {
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    BBS bbs=DataRowToModel(dataRow);
                    result.Add(bbs);
                }
            }
            return result;

        }

        //public List<BBS> GetList(String strWhere, int count, int page)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    BBS bbs;

        //    int endIndex = count * page;

        //    strSql.Append("SELECT * FROM NT_BBS t1,");
        //    strSql.Append(" SELECT TOP @ F_ID from {");
        //    strSql.Append("{ } t2");
        //    strSql.Append(" where t1.F_ID=t2.F_ID order by F_OperTime desc,t1.F_ID DESC ");
        //         strSql.Append("");
        //    return null;
        //}
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
			parameters[0].Value = "NT_BBS";
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

