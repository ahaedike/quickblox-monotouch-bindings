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
	[Register("QBResponse", true)]
	public unsafe partial class QBResponse : NSObject {
		[CompilerGenerated]
		const string selData = "data";
		static readonly IntPtr selDataHandle = Selector.GetHandle ("data");
		[CompilerGenerated]
		const string selError = "error";
		static readonly IntPtr selErrorHandle = Selector.GetHandle ("error");
		[CompilerGenerated]
		const string selHeaders = "headers";
		static readonly IntPtr selHeadersHandle = Selector.GetHandle ("headers");
		[CompilerGenerated]
		const string selIsSuccess = "isSuccess";
		static readonly IntPtr selIsSuccessHandle = Selector.GetHandle ("isSuccess");
		[CompilerGenerated]
		const string selRequestUrl = "requestUrl";
		static readonly IntPtr selRequestUrlHandle = Selector.GetHandle ("requestUrl");
		[CompilerGenerated]
		const string selStatus = "status";
		static readonly IntPtr selStatusHandle = Selector.GetHandle ("status");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBResponse");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBResponse () : base (NSObjectFlag.Empty)
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
		public QBResponse (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBResponse (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBResponse (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_Data_var;
		[CompilerGenerated]
		public virtual NSData Data {
			[Export ("data")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataHandle));
				} else {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Data_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Error_var;
		[CompilerGenerated]
		public virtual QBError Error {
			[Export ("error")]
			get {
				QBError ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBError> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selErrorHandle));
				} else {
					ret =  Runtime.GetNSObject<QBError> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selErrorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Error_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Headers_var;
		[CompilerGenerated]
		public virtual NSDictionary Headers {
			[Export ("headers")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHeadersHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHeadersHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Headers_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RequestUrl_var;
		[CompilerGenerated]
		public virtual NSUrl RequestUrl {
			[Export ("requestUrl")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRequestUrlHandle));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRequestUrlHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RequestUrl_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual QBResponseStatusCode Status {
			[Export ("status")]
			get {
				if (IsDirectBinding) {
					return (QBResponseStatusCode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStatusHandle);
				} else {
					return (QBResponseStatusCode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selStatusHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Success {
			[Export ("isSuccess")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSuccessHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsSuccessHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Data_var = null;
				__mt_Error_var = null;
				__mt_Headers_var = null;
				__mt_RequestUrl_var = null;
			}
		}
	} /* class QBResponse */
}
