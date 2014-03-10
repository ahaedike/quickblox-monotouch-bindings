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
	[Register("QBMPushMessageBase", true)]
	public unsafe partial class QBMPushMessageBase : NSObject {
		[CompilerGenerated]
		const string selPayloadDict = "payloadDict";
		static readonly IntPtr selPayloadDictHandle = Selector.GetHandle ("payloadDict");
		[CompilerGenerated]
		const string selSetPayloadDict_ = "setPayloadDict:";
		static readonly IntPtr selSetPayloadDict_Handle = Selector.GetHandle ("setPayloadDict:");
		[CompilerGenerated]
		const string selJson = "json";
		static readonly IntPtr selJsonHandle = Selector.GetHandle ("json");
		[CompilerGenerated]
		const string selCharsLeft = "charsLeft";
		static readonly IntPtr selCharsLeftHandle = Selector.GetHandle ("charsLeft");
		[CompilerGenerated]
		const string selInitWithPayload_ = "initWithPayload:";
		static readonly IntPtr selInitWithPayload_Handle = Selector.GetHandle ("initWithPayload:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMPushMessageBase");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMPushMessageBase () : base (NSObjectFlag.Empty)
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
		public QBMPushMessageBase (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMPushMessageBase (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMPushMessageBase (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPayload:")]
		[CompilerGenerated]
		public QBMPushMessageBase (NSDictionary payload)
			: base (NSObjectFlag.Empty)
		{
			if (payload == null)
				throw new ArgumentNullException ("payload");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithPayload_Handle, payload.Handle), "initWithPayload:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithPayload_Handle, payload.Handle), "initWithPayload:");
			}
		}
		
		[CompilerGenerated]
		object __mt_PayloadDict_var;
		[CompilerGenerated]
		public virtual NSMutableDictionary PayloadDict {
			[Export ("payloadDict", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPayloadDictHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPayloadDictHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PayloadDict_var = ret;
				return ret;
			}
			
			[Export ("setPayloadDict:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPayloadDict_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPayloadDict_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PayloadDict_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Json {
			[Export ("json")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selJsonHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selJsonHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int CharsLeft {
			[Export ("charsLeft")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selCharsLeftHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selCharsLeftHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PayloadDict_var = null;
			}
		}
	} /* class QBMPushMessageBase */
}
