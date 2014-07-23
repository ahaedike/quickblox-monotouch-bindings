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
	[Register("QBRestResponse", true)]
	public unsafe partial class QBRestResponse : NSObject {
		[CompilerGenerated]
		const string selAFHTTPRequestOperation = "AFHTTPRequestOperation";
		static readonly IntPtr selAFHTTPRequestOperationHandle = Selector.GetHandle ("AFHTTPRequestOperation");
		[CompilerGenerated]
		const string selContentType = "contentType";
		static readonly IntPtr selContentTypeHandle = Selector.GetHandle ("contentType");
		[CompilerGenerated]
		const string selEncoding = "encoding";
		static readonly IntPtr selEncodingHandle = Selector.GetHandle ("encoding");
		[CompilerGenerated]
		const string selError = "error";
		static readonly IntPtr selErrorHandle = Selector.GetHandle ("error");
		[CompilerGenerated]
		const string selHeaders = "headers";
		static readonly IntPtr selHeadersHandle = Selector.GetHandle ("headers");
		[CompilerGenerated]
		const string selInitWithResponseObjectAFHTTPRequestOperationError_ = "initWithResponseObject:AFHTTPRequestOperation:error:";
		static readonly IntPtr selInitWithResponseObjectAFHTTPRequestOperationError_Handle = Selector.GetHandle ("initWithResponseObject:AFHTTPRequestOperation:error:");
		[CompilerGenerated]
		const string selResponseObject = "responseObject";
		static readonly IntPtr selResponseObjectHandle = Selector.GetHandle ("responseObject");
		[CompilerGenerated]
		const string selResponseObjectAsString = "responseObjectAsString";
		static readonly IntPtr selResponseObjectAsStringHandle = Selector.GetHandle ("responseObjectAsString");
		[CompilerGenerated]
		const string selResponseType = "responseType";
		static readonly IntPtr selResponseTypeHandle = Selector.GetHandle ("responseType");
		[CompilerGenerated]
		const string selStatus = "status";
		static readonly IntPtr selStatusHandle = Selector.GetHandle ("status");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBRestResponse");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBRestResponse () : base (NSObjectFlag.Empty)
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
		public QBRestResponse (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRestResponse (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRestResponse (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithResponseObject:AFHTTPRequestOperation:error:")]
		[CompilerGenerated]
		public QBRestResponse (NSObject responseObject, QBAFHTTPRequestOperation AFHTTPRequestOperation, NSError error)
			: base (NSObjectFlag.Empty)
		{
			if (responseObject == null)
				throw new ArgumentNullException ("responseObject");
			if (AFHTTPRequestOperation == null)
				throw new ArgumentNullException ("AFHTTPRequestOperation");
			if (error == null)
				throw new ArgumentNullException ("error");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithResponseObjectAFHTTPRequestOperationError_Handle, responseObject.Handle, AFHTTPRequestOperation.Handle, error.Handle), "initWithResponseObject:AFHTTPRequestOperation:error:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithResponseObjectAFHTTPRequestOperationError_Handle, responseObject.Handle, AFHTTPRequestOperation.Handle, error.Handle), "initWithResponseObject:AFHTTPRequestOperation:error:");
			}
		}
		
		[CompilerGenerated]
		object __mt_AFHTTPRequestOperation_var;
		[CompilerGenerated]
		public virtual NSObject AFHTTPRequestOperation {
			[Export ("AFHTTPRequestOperation")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAFHTTPRequestOperationHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAFHTTPRequestOperationHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AFHTTPRequestOperation_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ContentType {
			[Export ("contentType")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentTypeHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContentTypeHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSStringEncoding Encoding {
			[Export ("encoding")]
			get {
				if (IsDirectBinding) {
					return (NSStringEncoding) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selEncodingHandle);
				} else {
					return (NSStringEncoding) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selEncodingHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Error_var;
		[CompilerGenerated]
		public virtual NSError Error {
			[Export ("error")]
			get {
				NSError ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selErrorHandle));
				} else {
					ret =  Runtime.GetNSObject<NSError> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selErrorHandle));
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
		object __mt_ResponseObject_var;
		[CompilerGenerated]
		public virtual NSObject ResponseObject {
			[Export ("responseObject")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selResponseObjectHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selResponseObjectHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ResponseObject_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ResponseObjectAsString {
			[Export ("responseObjectAsString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selResponseObjectAsStringHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selResponseObjectAsStringHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual RestResponseType ResponseType {
			[Export ("responseType")]
			get {
				if (IsDirectBinding) {
					return (RestResponseType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selResponseTypeHandle);
				} else {
					return (RestResponseType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selResponseTypeHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Status {
			[Export ("status")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selStatusHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selStatusHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AFHTTPRequestOperation_var = null;
				__mt_Error_var = null;
				__mt_Headers_var = null;
				__mt_ResponseObject_var = null;
			}
		}
	} /* class QBRestResponse */
}
