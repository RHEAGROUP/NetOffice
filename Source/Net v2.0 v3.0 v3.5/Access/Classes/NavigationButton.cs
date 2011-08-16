//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void NavigationButton_ClickEventHandler();
	public delegate void NavigationButton_EnterEventHandler();
	public delegate void NavigationButton_ExitEventHandler(ref Int16 Cancel);
	public delegate void NavigationButton_GotFocusEventHandler();
	public delegate void NavigationButton_LostFocusEventHandler();
	public delegate void NavigationButton_DblClickEventHandler(ref Int16 Cancel);
	public delegate void NavigationButton_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void NavigationButton_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void NavigationButton_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void NavigationButton_KeyDownEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void NavigationButton_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void NavigationButton_KeyUpEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass NavigationButton SupportByLibrary Access, 14
	///</summary>
	[SupportByLibrary("Access", 14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class NavigationButton : _NavigationButton, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		DispNavigationButtonEvents_SinkHelper _dispNavigationButtonEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(NavigationButton);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public NavigationButton(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NavigationButton(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NavigationButton(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of NavigationButton 
        /// </summary>		
		public NavigationButton():base("Access.NavigationButton")
		{
		}
		
		/// <summary>
        /// creates a new instance of NavigationButton
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public NavigationButton(string progId):base(progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, DispNavigationButtonEvents_SinkHelper.Id);


			if(DispNavigationButtonEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dispNavigationButtonEvents_SinkHelper = new DispNavigationButtonEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_ClickEventHandler ClickEvent
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
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_EnterEventHandler _EnterEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_EnterEventHandler EnterEvent
		{
			add
			{
				CreateEventBridge();
				_EnterEvent += value;
			}
			remove
			{
				_EnterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_ExitEventHandler _ExitEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_ExitEventHandler ExitEvent
		{
			add
			{
				CreateEventBridge();
				_ExitEvent += value;
			}
			remove
			{
				_ExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_GotFocusEventHandler _GotFocusEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_GotFocusEventHandler GotFocusEvent
		{
			add
			{
				CreateEventBridge();
				_GotFocusEvent += value;
			}
			remove
			{
				_GotFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_LostFocusEventHandler _LostFocusEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_LostFocusEventHandler LostFocusEvent
		{
			add
			{
				CreateEventBridge();
				_LostFocusEvent += value;
			}
			remove
			{
				_LostFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_DblClickEventHandler DblClickEvent
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
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_MouseDownEventHandler MouseDownEvent
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
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_MouseMoveEventHandler MouseMoveEvent
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
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_MouseUpEventHandler MouseUpEvent
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
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_KeyDownEventHandler KeyDownEvent
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
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_KeyPressEventHandler KeyPressEvent
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
		/// SupportByLibrary Access, 14
		/// </summary>
		private event NavigationButton_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public event NavigationButton_KeyUpEventHandler KeyUpEvent
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
			if( null != _dispNavigationButtonEvents_SinkHelper)
			{
				_dispNavigationButtonEvents_SinkHelper.Dispose();
				_dispNavigationButtonEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}