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
	/// DispatchInterface PublishObject SupportByLibrary PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PublishObject : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(PublishObject);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PublishObject(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PublishObject(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PublishObject(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PublishObject() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PublishObject(string progId) : base(progId)
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
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Enums.PpHTMLVersion HTMLVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HTMLVersion", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpHTMLVersion)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HTMLVersion", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Enums.PpPublishSourceType SourceType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceType", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpPublishSourceType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SourceType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 RangeStart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RangeStart", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RangeStart", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 RangeEnd
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RangeEnd", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RangeEnd", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string SlideShowName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SlideShowName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SlideShowName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState SpeakerNotes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SpeakerNotes", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SpeakerNotes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string FileName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FileName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FileName", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Publish()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Publish", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}