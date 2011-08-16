//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Slider_ClickEventHandler();
	public delegate void Slider_KeyDownEventHandler(ref Int16 KeyCode, Int16 Shift);
	public delegate void Slider_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void Slider_KeyUpEventHandler(ref Int16 KeyCode, Int16 Shift);
	public delegate void Slider_MouseDownEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void Slider_MouseMoveEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void Slider_MouseUpEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void Slider_ScrollEventHandler();
	public delegate void Slider_ChangeEventHandler();
	public delegate void Slider_OLEStartDragEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 AllowedEffects);
	public delegate void Slider_OLEGiveFeedbackEventHandler(ref Int32 Effect, ref bool DefaultCursors);
	public delegate void Slider_OLESetDataEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int16 DataFormat);
	public delegate void Slider_OLECompleteDragEventHandler(ref Int32 Effect);
	public delegate void Slider_OLEDragOverEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y, ref Int16 State);
	public delegate void Slider_OLEDragDropEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Slider SupportByLibrary MSComctlLib, 6
	///</summary>
	[SupportByLibrary("MSComctlLib", 6)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Slider : ISlider, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ISliderEvents_SinkHelper _iSliderEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Slider);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Slider(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Slider(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Slider(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of Slider 
        /// </summary>		
		public Slider():base("MSComctlLib.Slider")
		{
		}
		
		/// <summary>
        /// creates a new instance of Slider
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Slider(string progId):base(progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ISliderEvents_SinkHelper.Id);


			if(ISliderEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_iSliderEvents_SinkHelper = new ISliderEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event Slider_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_ClickEventHandler ClickEvent
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
		private event Slider_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_KeyDownEventHandler KeyDownEvent
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
		private event Slider_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_KeyPressEventHandler KeyPressEvent
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
		private event Slider_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_KeyUpEventHandler KeyUpEvent
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
		private event Slider_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_MouseDownEventHandler MouseDownEvent
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
		private event Slider_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_MouseMoveEventHandler MouseMoveEvent
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
		private event Slider_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_MouseUpEventHandler MouseUpEvent
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
		private event Slider_ScrollEventHandler _ScrollEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_ScrollEventHandler ScrollEvent
		{
			add
			{
				CreateEventBridge();
				_ScrollEvent += value;
			}
			remove
			{
				_ScrollEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event Slider_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_ChangeEventHandler ChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ChangeEvent += value;
			}
			remove
			{
				_ChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 6
		/// </summary>
		private event Slider_OLEStartDragEventHandler _OLEStartDragEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_OLEStartDragEventHandler OLEStartDragEvent
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
		private event Slider_OLEGiveFeedbackEventHandler _OLEGiveFeedbackEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_OLEGiveFeedbackEventHandler OLEGiveFeedbackEvent
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
		private event Slider_OLESetDataEventHandler _OLESetDataEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_OLESetDataEventHandler OLESetDataEvent
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
		private event Slider_OLECompleteDragEventHandler _OLECompleteDragEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_OLECompleteDragEventHandler OLECompleteDragEvent
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
		private event Slider_OLEDragOverEventHandler _OLEDragOverEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_OLEDragOverEventHandler OLEDragOverEvent
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
		private event Slider_OLEDragDropEventHandler _OLEDragDropEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public event Slider_OLEDragDropEventHandler OLEDragDropEvent
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
			if( null != _iSliderEvents_SinkHelper)
			{
				_iSliderEvents_SinkHelper.Dispose();
				_iSliderEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}