//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace QuickBlox {
	public unsafe static partial class ActionPerform_Performer  {
		[CompilerGenerated]
		const string selActionInBg = "actionInBg";
		static readonly IntPtr selActionInBgHandle = Selector.GetHandle ("actionInBg");
		[CompilerGenerated]
		const string selPerformInBgAsyncWithDelegate_ = "performInBgAsyncWithDelegate:";
		static readonly IntPtr selPerformInBgAsyncWithDelegate_Handle = Selector.GetHandle ("performInBgAsyncWithDelegate:");
		[CompilerGenerated]
		const string selPrepare = "prepare";
		static readonly IntPtr selPrepareHandle = Selector.GetHandle ("prepare");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::QuickBlox.Performer");
		
		[Export ("actionInBg")]
		[CompilerGenerated]
		public static void ActionInBg (this Performer This)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, selActionInBgHandle);
		}
		
		[Export ("performInBgAsyncWithDelegate:")]
		[CompilerGenerated]
		public static void PerformInBgAsyncWithDelegate (this Performer This, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, selPerformInBgAsyncWithDelegate_Handle, _delegate.Handle);
		}
		
		[Export ("prepare")]
		[CompilerGenerated]
		public static void Prepare (this Performer This)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, selPrepareHandle);
		}
		
	} /* class ActionPerform_Performer */
}
