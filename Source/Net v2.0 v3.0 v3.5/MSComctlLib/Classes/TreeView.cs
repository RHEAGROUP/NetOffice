//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{

	#region Delegates

	#pragma warning disable
	public delegate void TreeView_BeforeLabelEditEventHandler(ref Int16 Cancel);
	public delegate void TreeView_AfterLabelEditEventHandler(ref Int16 Cancel, ref string NewString);
	public delegate void TreeView_CollapseEventHandler(NetOffice.MSComctlLibApi.Node Node);
	public delegate void TreeView_ExpandEventHandler(NetOffice.MSComctlLibApi.Node Node);
	public delegate void TreeView_NodeClickEventHandler(NetOffice.MSComctlLibApi.Node Node);
	public delegate void TreeView_KeyDownEventHandler(ref Int16 KeyCode, Int16 Shift);
	public delegate void TreeView_KeyUpEventHandler(ref Int16 KeyCode, Int16 Shift);
	public delegate void TreeView_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void TreeView_MouseDownEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void TreeView_MouseMoveEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void TreeView_MouseUpEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void TreeView_ClickEventHandler();
	public delegate void TreeView_DblClickEventHandler();
	public delegate void TreeView_NodeCheckEventHandler(NetOffice.MSComctlLibApi.Node Node);
	public delegate void TreeView_OLEStartDragEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 AllowedEffects);
	public delegate void TreeView_OLEGiveFeedbackEventHandler(ref Int32 Effect, ref bool DefaultCursors);
	public delegate void TreeView_OLESetDataEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int16 DataFormat);
	public delegate void TreeView_OLECompleteDragEventHandler(ref Int32 Effect);
	public delegate void TreeView_OLEDragOverEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y, ref Int16 State);
	public delegate void TreeView_OLEDragDropEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass TreeView SupportByLibrary MSComctlLib, 6
	///</summary>
	[SupportByLibrary("MSComctlLib", 6)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class TreeView : ITreeView, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ITreeViewEvents_SinkHelper _iTreeViewEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(TreeView);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public TreeView(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TreeView(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TreeView(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of TreeView 
        /// </summary>		
		public TreeView():base("MSComctlLib.TreeView")
		{
		}
		
		/// <summary>
        /// creates a new instance of TreeView
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public TreeView(string progId):base(progId)
		{
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ITreeViewEvents_SinkHelper.Id);


			if(ITreeViewEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_iTreeViewEvents_SinkHelper = new ITreeViewEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_BeforeLabelEditEventHandler _BeforeLabelEditEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_BeforeLabelEditEventHandler BeforeLabelEditEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeLabelEditEvent += value;
			}
			remove
			{
				_BeforeLabelEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_AfterLabelEditEventHandler _AfterLabelEditEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_AfterLabelEditEventHandler AfterLabelEditEvent
		{
			add
			{
				CreateEventBridge();
				_AfterLabelEditEvent += value;
			}
			remove
			{
				_AfterLabelEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_CollapseEventHandler _CollapseEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_CollapseEventHandler CollapseEvent
		{
			add
			{
				CreateEventBridge();
				_CollapseEvent += value;
			}
			remove
			{
				_CollapseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_ExpandEventHandler _ExpandEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_ExpandEventHandler ExpandEvent
		{
			add
			{
				CreateEventBridge();
				_ExpandEvent += value;
			}
			remove
			{
				_ExpandEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_NodeClickEventHandler _NodeClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_NodeClickEventHandler NodeClickEvent
		{
			add
			{
				CreateEventBridge();
				_NodeClickEvent += value;
			}
			remove
			{
				_NodeClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_NodeCheckEventHandler _NodeCheckEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_NodeCheckEventHandler NodeCheckEvent
		{
			add
			{
				CreateEventBridge();
				_NodeCheckEvent += value;
			}
			remove
			{
				_NodeCheckEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_OLEStartDragEventHandler _OLEStartDragEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_OLEStartDragEventHandler OLEStartDragEvent
		{
			add
			{
				CreateEventBridge();
				_OLEStartDragEvent += value;
			}
			remove
			{
				_OLEStartDragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_OLEGiveFeedbackEventHandler _OLEGiveFeedbackEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_OLEGiveFeedbackEventHandler OLEGiveFeedbackEvent
		{
			add
			{
				CreateEventBridge();
				_OLEGiveFeedbackEvent += value;
			}
			remove
			{
				_OLEGiveFeedbackEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_OLESetDataEventHandler _OLESetDataEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_OLESetDataEventHandler OLESetDataEvent
		{
			add
			{
				CreateEventBridge();
				_OLESetDataEvent += value;
			}
			remove
			{
				_OLESetDataEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_OLECompleteDragEventHandler _OLECompleteDragEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_OLECompleteDragEventHandler OLECompleteDragEvent
		{
			add
			{
				CreateEventBridge();
				_OLECompleteDragEvent += value;
			}
			remove
			{
				_OLECompleteDragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_OLEDragOverEventHandler _OLEDragOverEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_OLEDragOverEventHandler OLEDragOverEvent
		{
			add
			{
				CreateEventBridge();
				_OLEDragOverEvent += value;
			}
			remove
			{
				_OLEDragOverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event TreeView_OLEDragDropEventHandler _OLEDragDropEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event TreeView_OLEDragDropEventHandler OLEDragDropEvent
		{
			add
			{
				CreateEventBridge();
				_OLEDragDropEvent += value;
			}
			remove
			{
				_OLEDragDropEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _iTreeViewEvents_SinkHelper)
			{
				_iTreeViewEvents_SinkHelper.Dispose();
				_iTreeViewEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}