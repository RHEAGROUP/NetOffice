//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void FormOld_LoadEventHandler();
	public delegate void FormOld_CurrentEventHandler();
	public delegate void FormOld_BeforeInsertEventHandler(ref Int16 Cancel);
	public delegate void FormOld_AfterInsertEventHandler();
	public delegate void FormOld_BeforeUpdateEventHandler(ref Int16 Cancel);
	public delegate void FormOld_AfterUpdateEventHandler();
	public delegate void FormOld_DeleteEventHandler(ref Int16 Cancel);
	public delegate void FormOld_BeforeDelConfirmEventHandler(ref Int16 Cancel, ref Int16 Response);
	public delegate void FormOld_AfterDelConfirmEventHandler(ref Int16 Status);
	public delegate void FormOld_OpenEventHandler(ref Int16 Cancel);
	public delegate void FormOld_ResizeEventHandler();
	public delegate void FormOld_UnloadEventHandler(ref Int16 Cancel);
	public delegate void FormOld_CloseEventHandler();
	public delegate void FormOld_ActivateEventHandler();
	public delegate void FormOld_DeactivateEventHandler();
	public delegate void FormOld_GotFocusEventHandler();
	public delegate void FormOld_LostFocusEventHandler();
	public delegate void FormOld_ClickEventHandler();
	public delegate void FormOld_DblClickEventHandler(ref Int16 Cancel);
	public delegate void FormOld_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void FormOld_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void FormOld_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void FormOld_KeyDownEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void FormOld_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void FormOld_KeyUpEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void FormOld_ErrorEventHandler(ref Int16 DataErr, ref Int16 Response);
	public delegate void FormOld_TimerEventHandler();
	public delegate void FormOld_FilterEventHandler(ref Int16 Cancel, ref Int16 FilterType);
	public delegate void FormOld_ApplyFilterEventHandler(ref Int16 Cancel, ref Int16 ApplyType);
	public delegate void FormOld_DirtyEventHandler(ref Int16 Cancel);
	public delegate void FormOld_UndoEventHandler(ref Int16 Cancel);
	public delegate void FormOld_RecordExitEventHandler(ref Int16 Cancel);
	public delegate void FormOld_BeginBatchEditEventHandler(ref Int16 Cancel);
	public delegate void FormOld_UndoBatchEditEventHandler(ref Int16 Cancel);
	public delegate void FormOld_BeforeBeginTransactionEventHandler(ref Int16 Cancel, ref NetOffice.ADODBApi.Connection Connection);
	public delegate void FormOld_AfterBeginTransactionEventHandler(ref NetOffice.ADODBApi.Connection Connection);
	public delegate void FormOld_BeforeCommitTransactionEventHandler(ref Int16 Cancel, ref NetOffice.ADODBApi.Connection Connection);
	public delegate void FormOld_AfterCommitTransactionEventHandler(ref NetOffice.ADODBApi.Connection Connection);
	public delegate void FormOld_RollbackTransactionEventHandler(ref NetOffice.ADODBApi.Connection Connection);
	public delegate void FormOld_OnConnectEventHandler();
	public delegate void FormOld_OnDisconnectEventHandler();
	public delegate void FormOld_PivotTableChangeEventHandler(Int32 Reason);
	public delegate void FormOld_QueryEventHandler();
	public delegate void FormOld_BeforeQueryEventHandler();
	public delegate void FormOld_SelectionChangeEventHandler();
	public delegate void FormOld_CommandBeforeExecuteEventHandler(COMObject Command, COMObject Cancel);
	public delegate void FormOld_CommandCheckedEventHandler(COMObject Command, COMObject Checked);
	public delegate void FormOld_CommandEnabledEventHandler(COMObject Command, COMObject Enabled);
	public delegate void FormOld_CommandExecuteEventHandler(COMObject Command);
	public delegate void FormOld_DataSetChangeEventHandler();
	public delegate void FormOld_BeforeScreenTipEventHandler(COMObject ScreenTipText, COMObject SourceObject);
	public delegate void FormOld_BeforeRenderEventHandler(COMObject drawObject, COMObject chartObject, COMObject Cancel);
	public delegate void FormOld_AfterRenderEventHandler(COMObject drawObject, COMObject chartObject);
	public delegate void FormOld_AfterFinalRenderEventHandler(COMObject drawObject);
	public delegate void FormOld_AfterLayoutEventHandler(COMObject drawObject);
	public delegate void FormOld_MouseWheelEventHandler(bool Page, Int32 Count);
	public delegate void FormOld_ViewChangeEventHandler(Int32 Reason);
	public delegate void FormOld_DataChangeEventHandler(Int32 Reason);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass FormOld SupportByLibrary Access, 10,11,12,14
	///</summary>
	[SupportByLibrary("Access", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class FormOld : _Form, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_FormEvents_SinkHelper __FormEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(FormOld);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public FormOld(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormOld(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FormOld(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of FormOld 
        /// </summary>		
		public FormOld():base("Access.FormOld")
		{
		}
		
		/// <summary>
        /// creates a new instance of FormOld
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public FormOld(string progId):base(progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _FormEvents_SinkHelper.Id);


			if(_FormEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__FormEvents_SinkHelper = new _FormEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_LoadEventHandler _LoadEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_LoadEventHandler LoadEvent
		{
			add
			{
				CreateEventBridge();
				_LoadEvent += value;
			}
			remove
			{
				_LoadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_CurrentEventHandler _CurrentEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_CurrentEventHandler CurrentEvent
		{
			add
			{
				CreateEventBridge();
				_CurrentEvent += value;
			}
			remove
			{
				_CurrentEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_BeforeInsertEventHandler _BeforeInsertEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_BeforeInsertEventHandler BeforeInsertEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeInsertEvent += value;
			}
			remove
			{
				_BeforeInsertEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_AfterInsertEventHandler _AfterInsertEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_AfterInsertEventHandler AfterInsertEvent
		{
			add
			{
				CreateEventBridge();
				_AfterInsertEvent += value;
			}
			remove
			{
				_AfterInsertEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_BeforeUpdateEventHandler _BeforeUpdateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_BeforeUpdateEventHandler BeforeUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeUpdateEvent += value;
			}
			remove
			{
				_BeforeUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_AfterUpdateEventHandler _AfterUpdateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_AfterUpdateEventHandler AfterUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_AfterUpdateEvent += value;
			}
			remove
			{
				_AfterUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_DeleteEventHandler _DeleteEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_DeleteEventHandler DeleteEvent
		{
			add
			{
				CreateEventBridge();
				_DeleteEvent += value;
			}
			remove
			{
				_DeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_BeforeDelConfirmEventHandler _BeforeDelConfirmEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_BeforeDelConfirmEventHandler BeforeDelConfirmEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDelConfirmEvent += value;
			}
			remove
			{
				_BeforeDelConfirmEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_AfterDelConfirmEventHandler _AfterDelConfirmEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_AfterDelConfirmEventHandler AfterDelConfirmEvent
		{
			add
			{
				CreateEventBridge();
				_AfterDelConfirmEvent += value;
			}
			remove
			{
				_AfterDelConfirmEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_OpenEventHandler _OpenEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_OpenEventHandler OpenEvent
		{
			add
			{
				CreateEventBridge();
				_OpenEvent += value;
			}
			remove
			{
				_OpenEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_ResizeEventHandler _ResizeEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_ResizeEventHandler ResizeEvent
		{
			add
			{
				CreateEventBridge();
				_ResizeEvent += value;
			}
			remove
			{
				_ResizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_UnloadEventHandler _UnloadEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_UnloadEventHandler UnloadEvent
		{
			add
			{
				CreateEventBridge();
				_UnloadEvent += value;
			}
			remove
			{
				_UnloadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_CloseEventHandler _CloseEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_CloseEventHandler CloseEvent
		{
			add
			{
				CreateEventBridge();
				_CloseEvent += value;
			}
			remove
			{
				_CloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_ActivateEventHandler _ActivateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_ActivateEventHandler ActivateEvent
		{
			add
			{
				CreateEventBridge();
				_ActivateEvent += value;
			}
			remove
			{
				_ActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_DeactivateEventHandler _DeactivateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_DeactivateEventHandler DeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_DeactivateEvent += value;
			}
			remove
			{
				_DeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_GotFocusEventHandler _GotFocusEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_GotFocusEventHandler GotFocusEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_LostFocusEventHandler _LostFocusEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_LostFocusEventHandler LostFocusEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_ClickEventHandler ClickEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_DblClickEventHandler DblClickEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_MouseDownEventHandler MouseDownEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_MouseMoveEventHandler MouseMoveEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_MouseUpEventHandler MouseUpEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_KeyDownEventHandler KeyDownEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_KeyPressEventHandler KeyPressEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_KeyUpEventHandler KeyUpEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_ErrorEventHandler _ErrorEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_ErrorEventHandler ErrorEvent
		{
			add
			{
				CreateEventBridge();
				_ErrorEvent += value;
			}
			remove
			{
				_ErrorEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_TimerEventHandler _TimerEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_TimerEventHandler TimerEvent
		{
			add
			{
				CreateEventBridge();
				_TimerEvent += value;
			}
			remove
			{
				_TimerEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_FilterEventHandler _FilterEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_FilterEventHandler FilterEvent
		{
			add
			{
				CreateEventBridge();
				_FilterEvent += value;
			}
			remove
			{
				_FilterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_ApplyFilterEventHandler _ApplyFilterEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_ApplyFilterEventHandler ApplyFilterEvent
		{
			add
			{
				CreateEventBridge();
				_ApplyFilterEvent += value;
			}
			remove
			{
				_ApplyFilterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event FormOld_DirtyEventHandler _DirtyEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event FormOld_DirtyEventHandler DirtyEvent
		{
			add
			{
				CreateEventBridge();
				_DirtyEvent += value;
			}
			remove
			{
				_DirtyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_UndoEventHandler _UndoEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_UndoEventHandler UndoEvent
		{
			add
			{
				CreateEventBridge();
				_UndoEvent += value;
			}
			remove
			{
				_UndoEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_RecordExitEventHandler _RecordExitEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_RecordExitEventHandler RecordExitEvent
		{
			add
			{
				CreateEventBridge();
				_RecordExitEvent += value;
			}
			remove
			{
				_RecordExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_BeginBatchEditEventHandler _BeginBatchEditEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_BeginBatchEditEventHandler BeginBatchEditEvent
		{
			add
			{
				CreateEventBridge();
				_BeginBatchEditEvent += value;
			}
			remove
			{
				_BeginBatchEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_UndoBatchEditEventHandler _UndoBatchEditEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_UndoBatchEditEventHandler UndoBatchEditEvent
		{
			add
			{
				CreateEventBridge();
				_UndoBatchEditEvent += value;
			}
			remove
			{
				_UndoBatchEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_BeforeBeginTransactionEventHandler _BeforeBeginTransactionEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_BeforeBeginTransactionEventHandler BeforeBeginTransactionEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeBeginTransactionEvent += value;
			}
			remove
			{
				_BeforeBeginTransactionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_AfterBeginTransactionEventHandler _AfterBeginTransactionEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_AfterBeginTransactionEventHandler AfterBeginTransactionEvent
		{
			add
			{
				CreateEventBridge();
				_AfterBeginTransactionEvent += value;
			}
			remove
			{
				_AfterBeginTransactionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_BeforeCommitTransactionEventHandler _BeforeCommitTransactionEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_BeforeCommitTransactionEventHandler BeforeCommitTransactionEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeCommitTransactionEvent += value;
			}
			remove
			{
				_BeforeCommitTransactionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_AfterCommitTransactionEventHandler _AfterCommitTransactionEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_AfterCommitTransactionEventHandler AfterCommitTransactionEvent
		{
			add
			{
				CreateEventBridge();
				_AfterCommitTransactionEvent += value;
			}
			remove
			{
				_AfterCommitTransactionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_RollbackTransactionEventHandler _RollbackTransactionEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_RollbackTransactionEventHandler RollbackTransactionEvent
		{
			add
			{
				CreateEventBridge();
				_RollbackTransactionEvent += value;
			}
			remove
			{
				_RollbackTransactionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_OnConnectEventHandler _OnConnectEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_OnConnectEventHandler OnConnectEvent
		{
			add
			{
				CreateEventBridge();
				_OnConnectEvent += value;
			}
			remove
			{
				_OnConnectEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_OnDisconnectEventHandler _OnDisconnectEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_OnDisconnectEventHandler OnDisconnectEvent
		{
			add
			{
				CreateEventBridge();
				_OnDisconnectEvent += value;
			}
			remove
			{
				_OnDisconnectEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_PivotTableChangeEventHandler _PivotTableChangeEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_PivotTableChangeEventHandler PivotTableChangeEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableChangeEvent += value;
			}
			remove
			{
				_PivotTableChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_QueryEventHandler _QueryEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_QueryEventHandler QueryEvent
		{
			add
			{
				CreateEventBridge();
				_QueryEvent += value;
			}
			remove
			{
				_QueryEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_BeforeQueryEventHandler _BeforeQueryEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_BeforeQueryEventHandler BeforeQueryEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeQueryEvent += value;
			}
			remove
			{
				_BeforeQueryEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_SelectionChangeEventHandler _SelectionChangeEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_SelectionChangeEventHandler SelectionChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SelectionChangeEvent += value;
			}
			remove
			{
				_SelectionChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_CommandBeforeExecuteEventHandler _CommandBeforeExecuteEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_CommandBeforeExecuteEventHandler CommandBeforeExecuteEvent
		{
			add
			{
				CreateEventBridge();
				_CommandBeforeExecuteEvent += value;
			}
			remove
			{
				_CommandBeforeExecuteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_CommandCheckedEventHandler _CommandCheckedEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_CommandCheckedEventHandler CommandCheckedEvent
		{
			add
			{
				CreateEventBridge();
				_CommandCheckedEvent += value;
			}
			remove
			{
				_CommandCheckedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_CommandEnabledEventHandler _CommandEnabledEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_CommandEnabledEventHandler CommandEnabledEvent
		{
			add
			{
				CreateEventBridge();
				_CommandEnabledEvent += value;
			}
			remove
			{
				_CommandEnabledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_CommandExecuteEventHandler _CommandExecuteEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_CommandExecuteEventHandler CommandExecuteEvent
		{
			add
			{
				CreateEventBridge();
				_CommandExecuteEvent += value;
			}
			remove
			{
				_CommandExecuteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_DataSetChangeEventHandler _DataSetChangeEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_DataSetChangeEventHandler DataSetChangeEvent
		{
			add
			{
				CreateEventBridge();
				_DataSetChangeEvent += value;
			}
			remove
			{
				_DataSetChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_BeforeScreenTipEventHandler _BeforeScreenTipEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_BeforeScreenTipEventHandler BeforeScreenTipEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeScreenTipEvent += value;
			}
			remove
			{
				_BeforeScreenTipEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_BeforeRenderEventHandler _BeforeRenderEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_BeforeRenderEventHandler BeforeRenderEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeRenderEvent += value;
			}
			remove
			{
				_BeforeRenderEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_AfterRenderEventHandler _AfterRenderEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_AfterRenderEventHandler AfterRenderEvent
		{
			add
			{
				CreateEventBridge();
				_AfterRenderEvent += value;
			}
			remove
			{
				_AfterRenderEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_AfterFinalRenderEventHandler _AfterFinalRenderEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_AfterFinalRenderEventHandler AfterFinalRenderEvent
		{
			add
			{
				CreateEventBridge();
				_AfterFinalRenderEvent += value;
			}
			remove
			{
				_AfterFinalRenderEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_AfterLayoutEventHandler _AfterLayoutEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_AfterLayoutEventHandler AfterLayoutEvent
		{
			add
			{
				CreateEventBridge();
				_AfterLayoutEvent += value;
			}
			remove
			{
				_AfterLayoutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_MouseWheelEventHandler _MouseWheelEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_MouseWheelEventHandler MouseWheelEvent
		{
			add
			{
				CreateEventBridge();
				_MouseWheelEvent += value;
			}
			remove
			{
				_MouseWheelEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_ViewChangeEventHandler _ViewChangeEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_ViewChangeEventHandler ViewChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ViewChangeEvent += value;
			}
			remove
			{
				_ViewChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 10,11,12,14
		/// </summary>
		private event FormOld_DataChangeEventHandler _DataChangeEvent;

		/// <summary>
		/// SupportByLibrary Access 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public event FormOld_DataChangeEventHandler DataChangeEvent
		{
			add
			{
				CreateEventBridge();
				_DataChangeEvent += value;
			}
			remove
			{
				_DataChangeEvent -= value;
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
			if( null != __FormEvents_SinkHelper)
			{
				__FormEvents_SinkHelper.Dispose();
				__FormEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}