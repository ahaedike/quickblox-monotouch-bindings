//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace QuickBlox {
	[Register("QBMPushTokenCreateQuery", true)]
	public unsafe partial class QBMPushTokenCreateQuery : NSObject {
		[CompilerGenerated]
		const string selPushToken = "pushToken";
		static readonly IntPtr selPushTokenHandle = Selector.GetHandle ("pushToken");
		[CompilerGenerated]
		const string selSetPushToken_ = "setPushToken:";
		static readonly IntPtr selSetPushToken_Handle = Selector.GetHandle ("setPushToken:");
		[CompilerGenerated]
		const string selInitWithPushToken_ = "initWithPushToken:";
		static readonly IntPtr selInitWithPushToken_Handle = Selector.GetHandle ("initWithPushToken:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMPushTokenCreateQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMPushTokenCreateQuery () : base (NSObjectFlag.Empty)
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
		public QBMPushTokenCreateQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMPushTokenCreateQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMPushTokenCreateQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPushToken:")]
		[CompilerGenerated]
		public QBMPushTokenCreateQuery (QBMPushToken token)
			: base (NSObjectFlag.Empty)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPushToken_Handle, token.Handle), "initWithPushToken:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPushToken_Handle, token.Handle), "initWithPushToken:");
			}
		}
		
		[CompilerGenerated]
		object __mt_PushToken_var;
		[CompilerGenerated]
		public virtual QBMPushToken PushToken {
			[Export ("pushToken", ArgumentSemantic.Retain)]
			get {
				QBMPushToken ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBMPushToken> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPushTokenHandle));
				} else {
					ret =  Runtime.GetNSObject<QBMPushToken> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPushTokenHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PushToken_var = ret;
				return ret;
			}
			
			[Export ("setPushToken:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPushToken_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPushToken_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PushToken_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PushToken_var = null;
			}
		}
	} /* class QBMPushTokenCreateQuery */
}
