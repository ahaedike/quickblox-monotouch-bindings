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
	[Register("QBMApplePushEvent", true)]
	public unsafe partial class QBMApplePushEvent : QBMEvent {
		[CompilerGenerated]
		const string selPushEvent = "pushEvent";
		static readonly IntPtr selPushEventHandle = Selector.GetHandle ("pushEvent");
		[CompilerGenerated]
		const string selPushMessage = "pushMessage";
		static readonly IntPtr selPushMessageHandle = Selector.GetHandle ("pushMessage");
		[CompilerGenerated]
		const string selSetPushMessage_ = "setPushMessage:";
		static readonly IntPtr selSetPushMessage_Handle = Selector.GetHandle ("setPushMessage:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMApplePushEvent");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMApplePushEvent () : base (NSObjectFlag.Empty)
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
		public QBMApplePushEvent (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMApplePushEvent (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMApplePushEvent (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		static object __mt_PushEvent_var_static;
		[CompilerGenerated]
		public static QBMApplePushEvent PushEvent {
			[Export ("pushEvent")]
			get {
				QBMApplePushEvent ret;
				ret =  Runtime.GetNSObject<QBMApplePushEvent> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selPushEventHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_PushEvent_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PushMessage_var;
		[CompilerGenerated]
		public virtual QBMPushMessage PushMessage {
			[Export ("pushMessage", ArgumentSemantic.Retain)]
			get {
				QBMPushMessage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBMPushMessage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPushMessageHandle));
				} else {
					ret =  Runtime.GetNSObject<QBMPushMessage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPushMessageHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PushMessage_var = ret;
				return ret;
			}
			
			[Export ("setPushMessage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPushMessage_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPushMessage_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PushMessage_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PushMessage_var = null;
			}
		}
	} /* class QBMApplePushEvent */
}
