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
	[Register("QBCS3Answer", true)]
	public unsafe partial class QBCS3Answer : XmlAnswer {
		[CompilerGenerated]
		const string selCode = "code";
		static readonly IntPtr selCodeHandle = Selector.GetHandle ("code");
		[CompilerGenerated]
		const string selSetCode_ = "setCode:";
		static readonly IntPtr selSetCode_Handle = Selector.GetHandle ("setCode:");
		[CompilerGenerated]
		const string selMessage = "message";
		static readonly IntPtr selMessageHandle = Selector.GetHandle ("message");
		[CompilerGenerated]
		const string selSetMessage_ = "setMessage:";
		static readonly IntPtr selSetMessage_Handle = Selector.GetHandle ("setMessage:");
		[CompilerGenerated]
		const string selRequestId = "requestId";
		static readonly IntPtr selRequestIdHandle = Selector.GetHandle ("requestId");
		[CompilerGenerated]
		const string selSetRequestId_ = "setRequestId:";
		static readonly IntPtr selSetRequestId_Handle = Selector.GetHandle ("setRequestId:");
		[CompilerGenerated]
		const string selHostId = "hostId";
		static readonly IntPtr selHostIdHandle = Selector.GetHandle ("hostId");
		[CompilerGenerated]
		const string selSetHostId_ = "setHostId:";
		static readonly IntPtr selSetHostId_Handle = Selector.GetHandle ("setHostId:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCS3Answer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCS3Answer () : base (NSObjectFlag.Empty)
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
		public QBCS3Answer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCS3Answer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCS3Answer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_Code_var;
		[CompilerGenerated]
		public virtual NSMutableString Code {
			[Export ("code", ArgumentSemantic.Retain)]
			get {
				NSMutableString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCodeHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCodeHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Code_var = ret;
				return ret;
			}
			
			[Export ("setCode:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCode_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCode_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Code_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Message_var;
		[CompilerGenerated]
		public virtual NSMutableString Message {
			[Export ("message", ArgumentSemantic.Retain)]
			get {
				NSMutableString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMessageHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMessageHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Message_var = ret;
				return ret;
			}
			
			[Export ("setMessage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMessage_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMessage_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Message_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_RequestId_var;
		[CompilerGenerated]
		public virtual NSMutableString RequestId {
			[Export ("requestId", ArgumentSemantic.Retain)]
			get {
				NSMutableString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRequestIdHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRequestIdHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RequestId_var = ret;
				return ret;
			}
			
			[Export ("setRequestId:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRequestId_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRequestId_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RequestId_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_HostId_var;
		[CompilerGenerated]
		public virtual NSMutableString HostId {
			[Export ("hostId", ArgumentSemantic.Retain)]
			get {
				NSMutableString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHostIdHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHostIdHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_HostId_var = ret;
				return ret;
			}
			
			[Export ("setHostId:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetHostId_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetHostId_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_HostId_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Code_var = null;
				__mt_Message_var = null;
				__mt_RequestId_var = null;
				__mt_HostId_var = null;
			}
		}
	} /* class QBCS3Answer */
}
