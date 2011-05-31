//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface FieldListHierarchy SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class FieldListHierarchy : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FieldListHierarchy(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FieldListHierarchy(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FieldListHierarchy(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FieldListHierarchy()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.FieldListNode Root
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Root", paramsArray);
				NetOffice.OWC10Api.FieldListNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.FieldListNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public bool Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.FieldListNode Selection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Selection", paramsArray);
				NetOffice.OWC10Api.FieldListNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.FieldListNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public bool ConcatenateData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConcatenateData", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ConcatenateData", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public string DataSeparator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataSeparator", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataSeparator", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pflhs">NetOffice.OWC10Api.FieldListHierarchySite pflhs</param>
		[SupportByLibrary("OWC10", 1)]
		public void SetHierarchySite(NetOffice.OWC10Api.FieldListHierarchySite pflhs)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pflhs);
			Invoker.Method(this, "SetHierarchySite", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pflnParent">NetOffice.OWC10Api.FieldListNode pflnParent</param>
		/// <param name="fInsertFirst">bool fInsertFirst</param>
		/// <param name="nID">Int32 nID</param>
		/// <param name="bstrName">string bstrName</param>
		/// <param name="bstrData">string bstrData</param>
		/// <param name="nType">Int32 nType</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.FieldListNode AddNode(NetOffice.OWC10Api.FieldListNode pflnParent, bool fInsertFirst, Int32 nID, string bstrName, string bstrData, Int32 nType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pflnParent, fInsertFirst, nID, bstrName, bstrData, nType);
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.OWC10Api.FieldListNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api.FieldListNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="nID">Int32 nID</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.FieldListNode GetNode(Int32 nID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(nID);
			object returnItem = Invoker.MethodReturn(this, "GetNode", paramsArray);
			NetOffice.OWC10Api.FieldListNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api.FieldListNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pfln">NetOffice.OWC10Api.FieldListNode pfln</param>
		[SupportByLibrary("OWC10", 1)]
		public void RemoveNode(NetOffice.OWC10Api.FieldListNode pfln)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pfln);
			Invoker.Method(this, "RemoveNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="nType">Int32 nType</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.FieldListType AddType(Int32 nType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(nType);
			object returnItem = Invoker.MethodReturn(this, "AddType", paramsArray);
			NetOffice.OWC10Api.FieldListType newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api.FieldListType;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="nTypeId">Int32 nTypeId</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.FieldListType GetType(Int32 nTypeId)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(nTypeId);
			object returnItem = Invoker.MethodReturn(this, "GetType", paramsArray);
			NetOffice.OWC10Api.FieldListType newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api.FieldListType;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pfln">NetOffice.OWC10Api.FieldListNode pfln</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.FieldListNode GetNextSelected(NetOffice.OWC10Api.FieldListNode pfln)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pfln);
			object returnItem = Invoker.MethodReturn(this, "GetNextSelected", paramsArray);
			NetOffice.OWC10Api.FieldListNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api.FieldListNode;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}