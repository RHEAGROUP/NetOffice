﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.AccessApi.Behind
{
	/// <summary>
	/// CoClass Class
	/// SupportByVersion Access, 9,10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("Access", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsCoClass)]
    [ComEventContract(typeof(NetOffice.AccessApi.EventContracts._DummyEvents))]
    public class Class : _Dummy, NetOffice.AccessApi.Class
    {
		#pragma warning disable

		#region Fields

		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
        private static Type _type;
        private NetOffice.AccessApi.Behind.EventContracts._DummyEvents_SinkHelper __DummyEvents_SinkHelper;
    
		#endregion

		#region Type Information

        /// <summary>
        /// Instance Type
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Class);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
        /// Stub Ctor, not intended to use
        /// </summary>
		public Class() : base()
		{

		}

		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14,15,16
		/// </summary>
		private event Class_InitializeEventHandler _InitializeEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14 15,16
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual event Class_InitializeEventHandler InitializeEvent
		{
			add
			{
				CreateEventBridge();
				_InitializeEvent += value;
			}
			remove
			{
				_InitializeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 9,10,11,12,14,15,16
		/// </summary>
		private event Class_TerminateEventHandler _TerminateEvent;

		/// <summary>
		/// SupportByVersion Access 9 10 11 12 14 15,16
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual event Class_TerminateEventHandler TerminateEvent
		{
			add
			{
				CreateEventBridge();
				_TerminateEvent += value;
			}
			remove
			{
				_TerminateEvent -= value;
			}
		}

		#endregion

	    #region IEventBinding

		/// <summary>
        /// Creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual void CreateEventBridge()
        {
			if(false == Factory.Settings.EnableEvents)
				return;

			if (null != _connectPoint)
				return;

            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, NetOffice.AccessApi.Behind.EventContracts._DummyEvents_SinkHelper.Id);


			if(NetOffice.AccessApi.Behind.EventContracts._DummyEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__DummyEvents_SinkHelper = new NetOffice.AccessApi.Behind.EventContracts._DummyEvents_SinkHelper(this, _connectPoint);
				return;
			}
        }

        /// <summary>
        /// The instance use currently an event listener
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool EventBridgeInitialized
        {
            get
            {
                return (null != _connectPoint);
            }
        }

        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <returns>true if one or more event is active, otherwise false</returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool HasEventRecipients()
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType);
        }

        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <param name="eventName">name of the event</param>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool HasEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Target methods from its actual event recipients
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual Delegate[] GetEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Returns the current count of event recipients
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual int GetCountOfEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetCountOfEventRecipients(this, LateBindingApiWrapperType, eventName);
         }

        /// <summary>
        /// Raise an instance event
        /// </summary>
        /// <param name="eventName">name of the event without 'Event' at the end</param>
        /// <param name="paramsArray">custom arguments for the event</param>
        /// <returns>count of called event recipients</returns>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
            return NetOffice.Events.CoClassEventReflector.RaiseCustomEvent(this, LateBindingApiWrapperType, eventName, ref paramsArray);
		}

        /// <summary>
        /// Stop listening events for the instance
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual void DisposeEventBridge()
        {
			if( null != __DummyEvents_SinkHelper)
			{
				__DummyEvents_SinkHelper.Dispose();
				__DummyEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}

        #endregion

		#pragma warning restore
	}
}
