//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Table SupportByLibrary PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Table : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Table);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Table(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Table(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Table(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Table() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Table(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
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

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Columns Columns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Columns", paramsArray);
				NetOffice.PowerPointApi.Columns newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Columns.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Columns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Rows Rows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Rows", paramsArray);
				NetOffice.PowerPointApi.Rows newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Rows.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Rows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Enums.PpDirection TableDirection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TableDirection", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpDirection)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TableDirection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public bool FirstRow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstRow", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FirstRow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public bool LastRow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastRow", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LastRow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public bool FirstCol
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstCol", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FirstCol", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public bool LastCol
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastCol", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LastCol", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public bool HorizBanding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HorizBanding", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HorizBanding", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public bool VertBanding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VertBanding", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "VertBanding", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.TableStyle Style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Style", paramsArray);
				NetOffice.PowerPointApi.TableStyle newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.TableStyle.LateBindingApiWrapperType) as NetOffice.PowerPointApi.TableStyle;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.TableBackground Background
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Background", paramsArray);
				NetOffice.PowerPointApi.TableBackground newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.TableBackground.LateBindingApiWrapperType) as NetOffice.PowerPointApi.TableBackground;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public string AlternativeText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlternativeText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlternativeText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public string Title
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Title", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Title", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Row">Int32 Row</param>
		/// <param name="Column">Int32 Column</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Cell Cell(Int32 row, Int32 column)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(row, column);
			object returnItem = Invoker.MethodReturn(this, "Cell", paramsArray);
			NetOffice.PowerPointApi.Cell newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Cell.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Cell;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void MergeBorders()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MergeBorders", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="scale">Single scale</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public void ScaleProportionally(Single scale)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(scale);
			Invoker.Method(this, "ScaleProportionally", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="StyleID">string StyleID</param>
		/// <param name="SaveFormatting">bool SaveFormatting</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public void ApplyStyle(string styleID, bool saveFormatting)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(styleID, saveFormatting);
			Invoker.Method(this, "ApplyStyle", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}