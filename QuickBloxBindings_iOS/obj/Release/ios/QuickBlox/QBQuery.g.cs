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
	[Register("QBQuery", true)]
	public unsafe partial class QBQuery : NSObject, IQBActionStatusDelegate {
		[CompilerGenerated]
		const string selAllocAnswer = "allocAnswer";
		static readonly IntPtr selAllocAnswerHandle = Selector.GetHandle ("allocAnswer");
		[CompilerGenerated]
		const string selCancel = "cancel";
		static readonly IntPtr selCancelHandle = Selector.GetHandle ("cancel");
		[CompilerGenerated]
		const string selCanceler = "canceler";
		static readonly IntPtr selCancelerHandle = Selector.GetHandle ("canceler");
		[CompilerGenerated]
		const string selCompletedWithResponse_ = "completedWithResponse:";
		static readonly IntPtr selCompletedWithResponse_Handle = Selector.GetHandle ("completedWithResponse:");
		[CompilerGenerated]
		const string selCompletedWithResult_ = "completedWithResult:";
		static readonly IntPtr selCompletedWithResult_Handle = Selector.GetHandle ("completedWithResult:");
		[CompilerGenerated]
		const string selCompletedWithResultContext_ = "completedWithResult:context:";
		static readonly IntPtr selCompletedWithResultContext_Handle = Selector.GetHandle ("completedWithResult:context:");
		[CompilerGenerated]
		const string selContext = "context";
		static readonly IntPtr selContextHandle = Selector.GetHandle ("context");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selFinishedSuccess = "finishedSuccess";
		static readonly IntPtr selFinishedSuccessHandle = Selector.GetHandle ("finishedSuccess");
		[CompilerGenerated]
		const string selRequestBuildStyle = "requestBuildStyle";
		static readonly IntPtr selRequestBuildStyleHandle = Selector.GetHandle ("requestBuildStyle");
		[CompilerGenerated]
		const string selSetBody_ = "setBody:";
		static readonly IntPtr selSetBody_Handle = Selector.GetHandle ("setBody:");
		[CompilerGenerated]
		const string selSetCanceler_ = "setCanceler:";
		static readonly IntPtr selSetCanceler_Handle = Selector.GetHandle ("setCanceler:");
		[CompilerGenerated]
		const string selSetContext_ = "setContext:";
		static readonly IntPtr selSetContext_Handle = Selector.GetHandle ("setContext:");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selSetFiles_ = "setFiles:";
		static readonly IntPtr selSetFiles_Handle = Selector.GetHandle ("setFiles:");
		[CompilerGenerated]
		const string selSetHeaders_ = "setHeaders:";
		static readonly IntPtr selSetHeaders_Handle = Selector.GetHandle ("setHeaders:");
		[CompilerGenerated]
		const string selSetMethod_ = "setMethod:";
		static readonly IntPtr selSetMethod_Handle = Selector.GetHandle ("setMethod:");
		[CompilerGenerated]
		const string selSetParams_ = "setParams:";
		static readonly IntPtr selSetParams_Handle = Selector.GetHandle ("setParams:");
		[CompilerGenerated]
		const string selSetProgress_ = "setProgress:";
		static readonly IntPtr selSetProgress_Handle = Selector.GetHandle ("setProgress:");
		[CompilerGenerated]
		const string selSetRequestBuildStyle_ = "setRequestBuildStyle:";
		static readonly IntPtr selSetRequestBuildStyle_Handle = Selector.GetHandle ("setRequestBuildStyle:");
		[CompilerGenerated]
		const string selSetUploadProgress_ = "setUploadProgress:";
		static readonly IntPtr selSetUploadProgress_Handle = Selector.GetHandle ("setUploadProgress:");
		[CompilerGenerated]
		const string selSetUpRequest_ = "setUpRequest:";
		static readonly IntPtr selSetUpRequest_Handle = Selector.GetHandle ("setUpRequest:");
		[CompilerGenerated]
		const string selSetUrl_ = "setUrl:";
		static readonly IntPtr selSetUrl_Handle = Selector.GetHandle ("setUrl:");
		[CompilerGenerated]
		const string selUrl = "url";
		static readonly IntPtr selUrlHandle = Selector.GetHandle ("url");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBQuery () : base (NSObjectFlag.Empty)
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
		public QBQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cancel")]
		[CompilerGenerated]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCancelHandle);
			}
		}
		
		[Export ("completedWithResponse:")]
		[CompilerGenerated]
		public virtual void CompletedWithResponse (QBRestResponse response)
		{
			if (response == null)
				throw new ArgumentNullException ("response");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCompletedWithResponse_Handle, response.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selCompletedWithResponse_Handle, response.Handle);
			}
		}
		
		[Export ("completedWithResult:")]
		[CompilerGenerated]
		public virtual void CompletedWithResult (Result result)
		{
			if (result == null)
				throw new ArgumentNullException ("result");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCompletedWithResult_Handle, result.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selCompletedWithResult_Handle, result.Handle);
			}
		}
		
		[Export ("completedWithResult:context:")]
		[CompilerGenerated]
		public virtual void CompletedWithResultInContext (Result result, NSObject contextInfo)
		{
			if (result == null)
				throw new ArgumentNullException ("result");
			if (contextInfo == null)
				throw new ArgumentNullException ("contextInfo");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selCompletedWithResultContext_Handle, result.Handle, contextInfo.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selCompletedWithResultContext_Handle, result.Handle, contextInfo.Handle);
			}
		}
		
		[Export ("finishedSuccess")]
		[CompilerGenerated]
		public virtual void FinishedSuccess ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFinishedSuccessHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFinishedSuccessHandle);
			}
		}
		
		[CompilerGenerated]
		object __mt_AllocAnswer_var;
		[CompilerGenerated]
		public virtual RestAnswer AllocAnswer {
			[Export ("allocAnswer")]
			get {
				RestAnswer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<RestAnswer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAllocAnswerHandle));
				} else {
					ret =  Runtime.GetNSObject<RestAnswer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAllocAnswerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AllocAnswer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Body_var;
		[CompilerGenerated]
		public virtual QBRestRequest Body {
			[Export ("setBody:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBody_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBody_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Body_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Canceler_var;
		[CompilerGenerated]
		public virtual NSObject Canceler {
			[Export ("canceler", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCancelerHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCancelerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Canceler_var = ret;
				return ret;
			}
			
			[Export ("setCanceler:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCanceler_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCanceler_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Canceler_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Context_var;
		[CompilerGenerated]
		public virtual NSObject Context {
			[Export ("context", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContextHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContextHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Context_var = ret;
				return ret;
			}
			
			[Export ("setContext:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetContext_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetContext_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Context_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual NSObject Delegate {
			[Export ("delegate", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Files_var;
		[CompilerGenerated]
		public virtual QBRestRequest Files {
			[Export ("setFiles:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFiles_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFiles_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Files_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Headers_var;
		[CompilerGenerated]
		public virtual QBRestRequest Headers {
			[Export ("setHeaders:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetHeaders_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetHeaders_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Headers_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Method_var;
		[CompilerGenerated]
		public virtual QBRestRequest Method {
			[Export ("setMethod:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMethod_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMethod_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Method_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Params_var;
		[CompilerGenerated]
		public virtual QBRestRequest Params {
			[Export ("setParams:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParams_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParams_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Params_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float Progress {
			[Export ("setProgress:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetProgress_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetProgress_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual RestRequestBuildStyle RequestBuildStyle {
			[Export ("requestBuildStyle")]
			get {
				if (IsDirectBinding) {
					return (RestRequestBuildStyle) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selRequestBuildStyleHandle);
				} else {
					return (RestRequestBuildStyle) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selRequestBuildStyleHandle);
				}
			}
			
			[Export ("setRequestBuildStyle:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetRequestBuildStyle_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetRequestBuildStyle_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float UploadActionProgress {
			[Export ("setUploadProgress:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetUploadProgress_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetUploadProgress_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_upRequest_var;
		[CompilerGenerated]
		public virtual QBRestRequest upRequest {
			[Export ("setUpRequest:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUpRequest_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUpRequest_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_upRequest_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Url {
			[Export ("url")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUrlHandle));
				}
			}
			
			[Export ("setUrl:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AllocAnswer_var = null;
				__mt_Body_var = null;
				__mt_Canceler_var = null;
				__mt_Context_var = null;
				__mt_Delegate_var = null;
				__mt_Files_var = null;
				__mt_Headers_var = null;
				__mt_Method_var = null;
				__mt_Params_var = null;
				__mt_upRequest_var = null;
			}
		}
	} /* class QBQuery */
}
