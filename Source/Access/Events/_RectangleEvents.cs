﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;
using NetOffice.Attributes;

namespace NetOffice.AccessApi.EventContracts
{
    /// <summary>
    /// _RectangleEvents
    /// </summary>
	[SupportByVersion("Access", 9,10,11,12,14,15,16)]
    [InternalEntity(InternalEntityKind.ComEventInterface)]
    [ComImport, Guid("BC9E4342-F037-11CD-8701-00AA003F0F07"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface _RectangleEvents
	{
        /// <summary>
        /// Click
        /// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-600)]
		void Click();

        /// <summary>
        /// DblClick
        /// </summary>
        /// <param name="cancel"></param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
        [SinkArgument("cancel", SinkArgumentType.Int16)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-601)]
		void DblClick([In] [Out] ref object cancel);

        /// <summary>
        /// MouseDown
        /// </summary>
        /// <param name="button"></param>
        /// <param name="shift"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
        [SinkArgument("button", SinkArgumentType.Int16)]
        [SinkArgument("shift", SinkArgumentType.Int16)]
        [SinkArgument("x", SinkArgumentType.Single)]
        [SinkArgument("y", SinkArgumentType.Single)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-605)]
		void MouseDown([In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y);

        /// <summary>
        /// MouseMove
        /// </summary>
        /// <param name="button"></param>
        /// <param name="shift"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
        [SinkArgument("button", SinkArgumentType.Int16)]
        [SinkArgument("shift", SinkArgumentType.Int16)]
        [SinkArgument("x", SinkArgumentType.Single)]
        [SinkArgument("y", SinkArgumentType.Single)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-606)]
		void MouseMove([In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y);

        /// <summary>
        /// MouseUp
        /// </summary>
        /// <param name="button"></param>
        /// <param name="shift"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
        [SinkArgument("button", SinkArgumentType.Int16)]
        [SinkArgument("shift", SinkArgumentType.Int16)]
        [SinkArgument("x", SinkArgumentType.Single)]
        [SinkArgument("y", SinkArgumentType.Single)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(-607)]
		void MouseUp([In] [Out] ref object button, [In] [Out] ref object shift, [In] [Out] ref object x, [In] [Out] ref object y);
	}
}
