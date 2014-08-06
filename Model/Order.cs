/**  版本信息模板在安装目录下，可自行修改。
* Order.cs
*
* 功 能： N/A
* 类 名： Order
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/8/6 16:54:44   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace CMS.Model
{
	/// <summary>
	/// Order:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Order
	{
		public Order()
		{}
		#region Model
		private int _id;
		private string _orderid;
		private DateTime _addtime;
		private int _userid;
		private int _isdel;
		private int _wuliuid;
		private int _payid;
		private int _ispay;
		private int _addressid;
		private int? _couponid;
		private string _memo;
		private string _trackingnumber;
		private int? _state;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orderId
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime addTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int userId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 订单是否被删除
		/// </summary>
		public int isDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		/// <summary>
		/// 配送方式 如韵达 申通
		/// </summary>
		public int wuliuId
		{
			set{ _wuliuid=value;}
			get{return _wuliuid;}
		}
		/// <summary>
		/// 付款方式 如 淘宝、网银
		/// </summary>
		public int payId
		{
			set{ _payid=value;}
			get{return _payid;}
		}
		/// <summary>
		/// 是否已经付款
		/// </summary>
		public int isPay
		{
			set{ _ispay=value;}
			get{return _ispay;}
		}
		/// <summary>
		/// 收货地址
		/// </summary>
		public int addressId
		{
			set{ _addressid=value;}
			get{return _addressid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? couponId
		{
			set{ _couponid=value;}
			get{return _couponid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trackingNumber
		{
			set{ _trackingnumber=value;}
			get{return _trackingnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? state
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

