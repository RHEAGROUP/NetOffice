//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface Research SupportByLibrary Excel, 12,14
	///</summary>
	[SupportByLibrary("Excel", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Research : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Research);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="ServiceID">string ServiceID</param>
		/// <param name="QueryString">optional object QueryString</param>
		/// <param name="QueryLanguage">optional object QueryLanguage</param>
		/// <param name="UseSelection">optional object UseSelection</param>
		/// <param name="LaunchQuery">optional object LaunchQuery</param>
		[SupportByLibrary("Excel", 12,14)]
		public object Query(string serviceID, object queryString, object queryLanguage, object useSelection, object launchQuery)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(serviceID, queryString, queryLanguage, useSelection, launchQuery);
			object returnItem = Invoker.MethodReturn(this, "Query", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="ServiceID">string ServiceID</param>
		[SupportByLibrary("Excel", 12,14)]
		public object Query(string serviceID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(serviceID);
			object returnItem = Invoker.MethodReturn(this, "Query", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="ServiceID">string ServiceID</param>
		[SupportByLibrary("Excel", 12,14)]
		public bool IsResearchService(string serviceID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(serviceID);
			object returnItem = Invoker.MethodReturn(this, "IsResearchService", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="LanguageFrom">Int32 LanguageFrom</param>
		/// <param name="LanguageTo">Int32 LanguageTo</param>
		[SupportByLibrary("Excel", 12,14)]
		public object SetLanguagePair(Int32 languageFrom, Int32 languageTo)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(languageFrom, languageTo);
			object returnItem = Invoker.MethodReturn(this, "SetLanguagePair", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		#endregion
		#pragma warning restore
	}
}