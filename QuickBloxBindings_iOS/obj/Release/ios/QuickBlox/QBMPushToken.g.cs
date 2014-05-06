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
	[Register("QBMPushToken", true)]
	public unsafe partial class QBMPushToken : Entity {
		[CompilerGenerated]
		const string selClientIdentificationSequence = "clientIdentificationSequence";
		static readonly IntPtr selClientIdentificationSequenceHandle = Selector.GetHandle ("clientIdentificationSequence");
		[CompilerGenerated]
		const string selIsEnvironmentDevelopment = "isEnvironmentDevelopment";
		static readonly IntPtr selIsEnvironmentDevelopmentHandle = Selector.GetHandle ("isEnvironmentDevelopment");
		[CompilerGenerated]
		const string selPushToken = "pushToken";
		static readonly IntPtr selPushTokenHandle = Selector.GetHandle ("pushToken");
		[CompilerGenerated]
		const string selSetClientIdentificationSequence_ = "setClientIdentificationSequence:";
		static readonly IntPtr selSetClientIdentificationSequence_Handle = Selector.GetHandle ("setClientIdentificationSequence:");
		[CompilerGenerated]
		const string selSetIsEnvironmentDevelopment_ = "setIsEnvironmentDevelopment:";
		static readonly IntPtr selSetIsEnvironmentDevelopment_Handle = Selector.GetHandle ("setIsEnvironmentDevelopment:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMPushToken");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMPushToken () : base (NSObjectFlag.Empty)
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
		public QBMPushToken (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMPushToken (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMPushToken (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string ClientIdentificationSequence {
			[Export ("clientIdentificationSequence", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selClientIdentificationSequenceHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selClientIdentificationSequenceHandle));
				}
			}
			
			[Export ("setClientIdentificationSequence:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetClientIdentificationSequence_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetClientIdentificationSequence_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsEnvironmentDevelopment {
			[Export ("isEnvironmentDevelopment")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEnvironmentDevelopmentHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsEnvironmentDevelopmentHandle);
				}
			}
			
			[Export ("setIsEnvironmentDevelopment:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsEnvironmentDevelopment_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsEnvironmentDevelopment_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		static object __mt_PushToken_var_static;
		[CompilerGenerated]
		public static QBMPushToken PushToken {
			[Export ("pushToken")]
			get {
				QBMPushToken ret;
				ret =  Runtime.GetNSObject<QBMPushToken> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selPushTokenHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_PushToken_var_static = ret;
				return ret;
			}
			
		}
		
	} /* class QBMPushToken */
}
