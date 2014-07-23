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
	[Protocol (Name = "QBActionStatusDelegate", WrapperType = typeof (QBActionStatusDelegateWrapper))]
	public interface IQBActionStatusDelegate : INativeObject, IDisposable
	{
	}
	
	public static class QBActionStatusDelegate_Extensions {
		[CompilerGenerated]
		public static void CompletedWithResult (this IQBActionStatusDelegate This, Result result)
		{
			if (result == null)
				throw new ArgumentNullException ("result");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("completedWithResult:"), result.Handle);
		}
		
		[CompilerGenerated]
		public static void CompletedWithResultInContext (this IQBActionStatusDelegate This, Result result, NSObject contextInfo)
		{
			if (result == null)
				throw new ArgumentNullException ("result");
			if (contextInfo == null)
				throw new ArgumentNullException ("contextInfo");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("completedWithResult:context:"), result.Handle, contextInfo.Handle);
		}
		
	}
	
	internal sealed class QBActionStatusDelegateWrapper : IQBActionStatusDelegate {
		public IntPtr Handle { get; set; }
		
		public QBActionStatusDelegateWrapper (IntPtr handle)
			: this (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public QBActionStatusDelegateWrapper (IntPtr handle, bool owns)
		{
			Handle = handle;
			if (!owns)
			    global::MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("retain"));
		}
		
		~QBActionStatusDelegateWrapper ()
		{
			Dispose ();
		}
		
		public void Dispose ()
		{
			if (Handle != IntPtr.Zero) {
				global::MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("release"));
				Handle = IntPtr.Zero;
			}
			GC.SuppressFinalize (this);
		}
		
	}
}
namespace QuickBlox {
	[Protocol]
	[Register("QBActionStatusDelegate", true)]
	[Model]
	public unsafe partial class QBActionStatusDelegate : NSObject, IQBActionStatusDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBActionStatusDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init), "init");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public QBActionStatusDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBActionStatusDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBActionStatusDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("completedWithResult:")]
		[CompilerGenerated]
		public virtual void CompletedWithResult (Result result)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("completedWithResult:context:")]
		[CompilerGenerated]
		public virtual void CompletedWithResultInContext (Result result, NSObject contextInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual float Progress {
			[Export ("setProgress:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual float UploadActionProgress {
			[Export ("setUploadProgress:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class QBActionStatusDelegate */
}
