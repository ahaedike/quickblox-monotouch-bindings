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
	[Register("QBAuth", true)]
	public unsafe partial class QBAuth : NSObject {
		[CompilerGenerated]
		const string selCreateSessionWithDelegate_ = "createSessionWithDelegate:";
		static readonly IntPtr selCreateSessionWithDelegate_Handle = Selector.GetHandle ("createSessionWithDelegate:");
		[CompilerGenerated]
		const string selCreateSessionWithDelegateContext_ = "createSessionWithDelegate:context:";
		static readonly IntPtr selCreateSessionWithDelegateContext_Handle = Selector.GetHandle ("createSessionWithDelegate:context:");
		[CompilerGenerated]
		const string selCreateSessionWithExtendedRequestDelegate_ = "createSessionWithExtendedRequest:delegate:";
		static readonly IntPtr selCreateSessionWithExtendedRequestDelegate_Handle = Selector.GetHandle ("createSessionWithExtendedRequest:delegate:");
		[CompilerGenerated]
		const string selCreateSessionWithExtendedRequestDelegateContext_ = "createSessionWithExtendedRequest:delegate:context:";
		static readonly IntPtr selCreateSessionWithExtendedRequestDelegateContext_Handle = Selector.GetHandle ("createSessionWithExtendedRequest:delegate:context:");
		[CompilerGenerated]
		const string selDestroySessionWithDelegate_ = "destroySessionWithDelegate:";
		static readonly IntPtr selDestroySessionWithDelegate_Handle = Selector.GetHandle ("destroySessionWithDelegate:");
		[CompilerGenerated]
		const string selDestroySessionWithDelegateContext_ = "destroySessionWithDelegate:context:";
		static readonly IntPtr selDestroySessionWithDelegateContext_Handle = Selector.GetHandle ("destroySessionWithDelegate:context:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBAuth");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBAuth () : base (NSObjectFlag.Empty)
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
		public QBAuth (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBAuth (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBAuth (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("createSessionWithDelegate:")]
		[CompilerGenerated]
		public static Cancelable CreateSessionWithDelegate (QBActionStatusDelegate del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<Cancelable> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selCreateSessionWithDelegate_Handle, del.Handle));
		}
		
		[Export ("createSessionWithDelegate:context:")]
		[CompilerGenerated]
		public static Cancelable CreateSessionWithDelegate (QBActionStatusDelegate del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<Cancelable> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateSessionWithDelegateContext_Handle, del.Handle, context.Handle));
		}
		
		[Export ("createSessionWithExtendedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateSessionWithExtendedRequest (QBASessionCreationRequest extendedRequest, NSObject del)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateSessionWithExtendedRequestDelegate_Handle, extendedRequest.Handle, del.Handle));
		}
		
		[Export ("createSessionWithExtendedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateSessionWithExtendedRequest (QBASessionCreationRequest extendedRequest, NSObject del, NSObject context)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateSessionWithExtendedRequestDelegateContext_Handle, extendedRequest.Handle, del.Handle, context.Handle));
		}
		
		[Export ("destroySessionWithDelegate:")]
		[CompilerGenerated]
		public static NSObject DestroySessionWithDelegate (QBActionStatusDelegate del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selDestroySessionWithDelegate_Handle, del.Handle));
		}
		
		[Export ("destroySessionWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject DestroySessionWithDelegate (QBActionStatusDelegate del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selDestroySessionWithDelegateContext_Handle, del.Handle, context.Handle));
		}
		
	} /* class QBAuth */
}
