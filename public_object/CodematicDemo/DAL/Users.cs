using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Users
	/// </summary>
	public partial class Users
	{
		public Users()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Users"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Users");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Users(");
			strSql.Append("UserLoginID,Password,UserName,UserEmail,UserRegDate,UserType,Remark)");
			strSql.Append(" values (");
			strSql.Append("@UserLoginID,@Password,@UserName,@UserEmail,@UserRegDate,@UserType,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserLoginID", SqlDbType.VarChar,30),
					new SqlParameter("@Password", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.NVarChar,10),
					new SqlParameter("@UserEmail", SqlDbType.VarChar,50),
					new SqlParameter("@UserRegDate", SqlDbType.DateTime),
					new SqlParameter("@UserType", SqlDbType.NVarChar,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.UserLoginID;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.UserEmail;
			parameters[4].Value = model.UserRegDate;
			parameters[5].Value = model.UserType;
			parameters[6].Value = model.Remark;

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
		public bool Update(Maticsoft.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Users set ");
			strSql.Append("UserLoginID=@UserLoginID,");
			strSql.Append("Password=@Password,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("UserEmail=@UserEmail,");
			strSql.Append("UserRegDate=@UserRegDate,");
			strSql.Append("UserType=@UserType,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserLoginID", SqlDbType.VarChar,30),
					new SqlParameter("@Password", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.NVarChar,10),
					new SqlParameter("@UserEmail", SqlDbType.VarChar,50),
					new SqlParameter("@UserRegDate", SqlDbType.DateTime),
					new SqlParameter("@UserType", SqlDbType.NVarChar,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserLoginID;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.UserEmail;
			parameters[4].Value = model.UserRegDate;
			parameters[5].Value = model.UserType;
			parameters[6].Value = model.Remark;
			parameters[7].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Users ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Users ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public Maticsoft.Model.Users GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,UserLoginID,Password,UserName,UserEmail,UserRegDate,UserType,Remark from Users ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.Users model=new Maticsoft.Model.Users();
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
		public Maticsoft.Model.Users DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Users model=new Maticsoft.Model.Users();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["UserLoginID"]!=null)
				{
					model.UserLoginID=row["UserLoginID"].ToString();
				}
				if(row["Password"]!=null)
				{
					model.Password=row["Password"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["UserEmail"]!=null)
				{
					model.UserEmail=row["UserEmail"].ToString();
				}
				if(row["UserRegDate"]!=null && row["UserRegDate"].ToString()!="")
				{
					model.UserRegDate=DateTime.Parse(row["UserRegDate"].ToString());
				}
				if(row["UserType"]!=null)
				{
					model.UserType=row["UserType"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select ID,UserLoginID,Password,UserName,UserEmail,UserRegDate,UserType,Remark ");
			strSql.Append(" FROM Users ");
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
			strSql.Append(" ID,UserLoginID,Password,UserName,UserEmail,UserRegDate,UserType,Remark ");
			strSql.Append(" FROM Users ");
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
			strSql.Append("select count(1) FROM Users ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Users T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}
		//获取用户到是否登录成功
		public DataSet validate(string usernemae,string password)
		{
			StringBuilder strsql = new StringBuilder();
			strsql.Append("select username,password ");
			strsql.Append("FROM newproject.dbo.ceshiuser ");
			strsql.Append("where username=@username and password=@password");
			SqlParameter[] paramters = {
			new SqlParameter("@username",SqlDbType.VarChar,30),
			new SqlParameter("@password",SqlDbType.VarChar,50)

 			};
			paramters[0].Value = usernemae;
			paramters[1].Value = password;
			return DbHelperSQL.Query(strsql.ToString(),paramters);
		}
		public DataSet Administrations(string username,string password)
		{
			StringBuilder strsql = new StringBuilder();
			strsql.Append("select administratorsusername,administratorspassword ");
			strsql.Append("from [newproject].[dbo].[administrators] ");
			strsql.Append("where administratorsusername = @user and administratorspassword = @possword");
			SqlParameter[] paramters = {
				new SqlParameter("@user",SqlDbType.VarChar,30),
				new SqlParameter("@possword",SqlDbType.VarChar,50)
			};
			paramters[0].Value = username;
			paramters[1].Value = password;
			return DbHelperSQL.Query(strsql.ToString(),paramters);
		}
		/// <summary>
		/// 获取新闻的种类
		/// </summary>
		/// <returns></returns>
		public DataSet newstypes()
		{
			StringBuilder strsql = new StringBuilder();
			strsql.Append("select newstype ");
			strsql.Append("from newstype");
			return DbHelperSQL.Query(strsql.ToString());
		}
		/// <summary>
		/// 对新闻的类型进行修改
		/// </summary>
		public void modify(int nam,string type)
        {
			//更改用的sql语句
			string mod = "update dbo.newstype set newstype = '" + type + "' where newstypenumbers = " + nam + "";
			DbHelperSQL.ExecuteSql(mod);
			/*
			StringBuilder strSql = new StringBuilder();
			strSql.Append("update Users set ");
			strSql.Append("UserLoginID=@UserLoginID,");
			strSql.Append("Password=@Password,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("UserEmail=@UserEmail,");
			strSql.Append("UserRegDate=@UserRegDate,");
			strSql.Append("UserType=@UserType,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserLoginID", SqlDbType.VarChar,30),
					new SqlParameter("@Password", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.NVarChar,10),
					new SqlParameter("@UserEmail", SqlDbType.VarChar,50),
					new SqlParameter("@UserRegDate", SqlDbType.DateTime),
					new SqlParameter("@UserType", SqlDbType.NVarChar,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,100),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserLoginID;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.UserEmail;
			parameters[4].Value = model.UserRegDate;
			parameters[5].Value = model.UserType;
			parameters[6].Value = model.Remark;
			parameters[7].Value = model.ID;

			int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}*/
		}
		/// <summary>
		/// 保存用户注册的账号与密码
		/// </summary>
		public void registerload(string username,string password)
		{
			string mod = "insert into  dbo.ceshiuser([username],[password]) values ('" + username + "','" + password + "')";
			DbHelperSQL.ExecuteSql(mod);
		}

		/// <summary>
		/// 提交新闻的方法
		/// </summary>
		/// <param name="newstype"></param>
		/// <param name="newsp"></param>
		/// <param name="title"></param>
		/// <param name="state"></param>
		/// <param name="comment"></param>
		/// <param name="text"></param>
		public void Tnews(int newstype, string newsp, string title, string state, string comment, string text)
		{
			
			string mod = "insert into dbo.Tnews (newstype,newsp,newstitle,newsstate,newscomment,newstext,newstime) values (" + newstype + ",'" + newsp + "','" + title + "','" + state + "','" + comment + "','" + text + "',GETDATE())";
			DbHelperSQL.ExecuteSql(mod); 
		}
		/// <summary>
		/// 获取首页新闻
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public DataSet NewsTnew()
		{
			StringBuilder strsql = new StringBuilder();
			strsql.Append("select [newsid],[newsp],[newstitle] ,[newstime] ");
			strsql.Append("from [newproject].[dbo].[Tnews]");
			return DbHelperSQL.Query(strsql.ToString());
		}
		/// <summary>
		/// 根据id查询新闻
		/// </summary>
		/// <returns></returns>
		public DataSet NewTnew(int id)
		{
			StringBuilder strsql = new StringBuilder();
			strsql.Append("select [newstime],[newsp],[newstitle],[newstext] ");
			strsql.Append("from [newproject].[dbo].[Tnews] ");
			strsql.Append("where newsid = "+ id +"");
			return DbHelperSQL.Query(strsql.ToString());
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
			parameters[0].Value = "Users";
			parameters[1].Value = "ID";
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

