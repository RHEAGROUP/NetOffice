//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface ITreeView SupportByLibrary MSComctlLib, 6
	///</summary>
	[SupportByLibrary("MSComctlLib", 6)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ITreeView : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ITreeView);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ITreeView(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ITreeView(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ITreeView(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ITreeView() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ITreeView(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.INode DropHighlight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DropHighlight", paramsArray);
				NetOffice.MSComctlLibApi.INode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSComctlLibApi.INode.LateBindingApiWrapperType) as NetOffice.MSComctlLibApi.INode;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DropHighlight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public bool HideSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HideSelection", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HideSelection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public COMObject ImageList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ImageList", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ImageList", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public Single Indentation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Indentation", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Indentation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.Enums.LabelEditConstants LabelEdit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LabelEdit", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.LabelEditConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LabelEdit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.Enums.TreeLineStyleConstants LineStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LineStyle", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.TreeLineStyleConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LineStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.Enums.MousePointerConstants MousePointer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MousePointer", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.MousePointerConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MousePointer", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public stdole.Picture MouseIcon
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MouseIcon", paramsArray);
				stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Picture;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MouseIcon", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.INodes Nodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Nodes", paramsArray);
				NetOffice.MSComctlLibApi.INodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSComctlLibApi.INodes.LateBindingApiWrapperType) as NetOffice.MSComctlLibApi.INodes;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Nodes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public string PathSeparator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PathSeparator", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PathSeparator", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.INode SelectedItem
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelectedItem", paramsArray);
				NetOffice.MSComctlLibApi.INode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.MSComctlLibApi.INode.LateBindingApiWrapperType) as NetOffice.MSComctlLibApi.INode;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelectedItem", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public bool Sorted
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sorted", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Sorted", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.Enums.TreeStyleConstants Style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Style", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.TreeStyleConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Style", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.Enums.OLEDragConstants OLEDragMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OLEDragMode", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.OLEDragConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OLEDragMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.Enums.OLEDropConstants OLEDropMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OLEDropMode", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.OLEDropConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OLEDropMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.Enums.AppearanceConstants Appearance
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Appearance", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.AppearanceConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Appearance", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.Enums.BorderStyleConstants BorderStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BorderStyle", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.BorderStyleConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BorderStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public bool Enabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enabled", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Enabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public stdole.Font Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				stdole.Font newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Font;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Font", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public Int32 hWnd
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "hWnd", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "hWnd", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public bool Checkboxes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Checkboxes", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Checkboxes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public bool FullRowSelect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FullRowSelect", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FullRowSelect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public bool HotTracking
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HotTracking", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HotTracking", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public bool Scroll
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Scroll", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Scroll", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public bool SingleSel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SingleSel", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SingleSel", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.INode HitTest(Single x, Single y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			object returnItem = Invoker.MethodReturn(this, "HitTest", paramsArray);
			NetOffice.MSComctlLibApi.INode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSComctlLibApi.INode.LateBindingApiWrapperType) as NetOffice.MSComctlLibApi.INode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public Int32 GetVisibleCount()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetVisibleCount", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public void StartLabelEdit()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "StartLabelEdit", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public void AboutBox()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AboutBox", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public void OLEDrag()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "OLEDrag", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}