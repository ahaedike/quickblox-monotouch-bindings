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
	[Register("QBMSendPushTask", true)]
	public unsafe partial class QBMSendPushTask : Task {
		[CompilerGenerated]
		const string selUsersIDs = "usersIDs";
		static readonly IntPtr selUsersIDsHandle = Selector.GetHandle ("usersIDs");
		[CompilerGenerated]
		const string selSetUsersIDs_ = "setUsersIDs:";
		static readonly IntPtr selSetUsersIDs_Handle = Selector.GetHandle ("setUsersIDs:");
		[CompilerGenerated]
		const string selUsersTagsAny = "usersTagsAny";
		static readonly IntPtr selUsersTagsAnyHandle = Selector.GetHandle ("usersTagsAny");
		[CompilerGenerated]
		const string selSetUsersTagsAny_ = "setUsersTagsAny:";
		static readonly IntPtr selSetUsersTagsAny_Handle = Selector.GetHandle ("setUsersTagsAny:");
		[CompilerGenerated]
		const string selPushMessage = "pushMessage";
		static readonly IntPtr selPushMessageHandle = Selector.GetHandle ("pushMessage");
		[CompilerGenerated]
		const string selSetPushMessage_ = "setPushMessage:";
		static readonly IntPtr selSetPushMessage_Handle = Selector.GetHandle ("setPushMessage:");
		[CompilerGenerated]
		const string selSimplePushText = "simplePushText";
		static readonly IntPtr selSimplePushTextHandle = Selector.GetHandle ("simplePushText");
		[CompilerGenerated]
		const string selSetSimplePushText_ = "setSimplePushText:";
		static readonly IntPtr selSetSimplePushText_Handle = Selector.GetHandle ("setSimplePushText:");
		[CompilerGenerated]
		const string selIsDevelopmentEnvironment = "isDevelopmentEnvironment";
		static readonly IntPtr selIsDevelopmentEnvironmentHandle = Selector.GetHandle ("isDevelopmentEnvironment");
		[CompilerGenerated]
		const string selSetIsDevelopmentEnvironment_ = "setIsDevelopmentEnvironment:";
		static readonly IntPtr selSetIsDevelopmentEnvironment_Handle = Selector.GetHandle ("setIsDevelopmentEnvironment:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMSendPushTask");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMSendPushTask () : base (NSObjectFlag.Empty)
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
		public QBMSendPushTask (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMSendPushTask (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMSendPushTask (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string UsersIDs {
			[Export ("usersIDs", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersIDsHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersIDsHandle));
				}
			}
			
			[Export ("setUsersIDs:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersIDs_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersIDs_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UsersTagsAny {
			[Export ("usersTagsAny", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersTagsAnyHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersTagsAnyHandle));
				}
			}
			
			[Export ("setUsersTagsAny:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersTagsAny_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersTagsAny_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
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
		public virtual string SimplePushText {
			[Export ("simplePushText", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSimplePushTextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSimplePushTextHandle));
				}
			}
			
			[Export ("setSimplePushText:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSimplePushText_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSimplePushText_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsDevelopmentEnvironment {
			[Export ("isDevelopmentEnvironment")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDevelopmentEnvironmentHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDevelopmentEnvironmentHandle);
				}
			}
			
			[Export ("setIsDevelopmentEnvironment:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsDevelopmentEnvironment_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsDevelopmentEnvironment_Handle, value);
				}
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
	} /* class QBMSendPushTask */
}
