using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// NewsCategory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NewsCategory
	{
		public NewsCategory()
		{}
		#region Model
		private int _id;
		private string _categoryname;
		private string _status;
		private string _remark;
		/// <summary>
		/// 新闻类别编号
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 新闻名称
		/// </summary>
		public string Categoryname
		{
			set{ _categoryname=value;}
			get{return _categoryname;}
		}
		/// <summary>
		/// 状态（显示，不显示）
		/// </summary>
		public string Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 详细说明
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

