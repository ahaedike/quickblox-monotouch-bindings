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
	[Register("QBRestRequest", true)]
	public unsafe partial class QBRestRequest : NSObject {
		[CompilerGenerated]
		const string selAsyncRequestWithdelegate_ = "asyncRequestWithdelegate:";
		static readonly IntPtr selAsyncRequestWithdelegate_Handle = Selector.GetHandle ("asyncRequestWithdelegate:");
		[CompilerGenerated]
		const string selBuildStyle = "buildStyle";
		static readonly IntPtr selBuildStyleHandle = Selector.GetHandle ("buildStyle");
		[CompilerGenerated]
		const string selCancel = "cancel";
		static readonly IntPtr selCancelHandle = Selector.GetHandle ("cancel");
		[CompilerGenerated]
		const string selCanceler = "canceler";
		static readonly IntPtr selCancelerHandle = Selector.GetHandle ("canceler");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selFiles = "files";
		static readonly IntPtr selFilesHandle = Selector.GetHandle ("files");
		[CompilerGenerated]
		const string selFinalURL = "finalURL";
		static readonly IntPtr selFinalURLHandle = Selector.GetHandle ("finalURL");
		[CompilerGenerated]
		const string selHeaders = "headers";
		static readonly IntPtr selHeadersHandle = Selector.GetHandle ("headers");
		[CompilerGenerated]
		const string selHttpMethod = "httpMethod";
		static readonly IntPtr selHttpMethodHandle = Selector.GetHandle ("httpMethod");
		[CompilerGenerated]
		const string selMethod = "method";
		static readonly IntPtr selMethodHandle = Selector.GetHandle ("method");
		[CompilerGenerated]
		const string selParameters = "parameters";
		static readonly IntPtr selParametersHandle = Selector.GetHandle ("parameters");
		[CompilerGenerated]
		const string selRawBodyWithoutEncode = "rawBodyWithoutEncode";
		static readonly IntPtr selRawBodyWithoutEncodeHandle = Selector.GetHandle ("rawBodyWithoutEncode");
		[CompilerGenerated]
		const string selSetBuildStyle_ = "setBuildStyle:";
		static readonly IntPtr selSetBuildStyle_Handle = Selector.GetHandle ("setBuildStyle:");
		[CompilerGenerated]
		const string selSetCanceler_ = "setCanceler:";
		static readonly IntPtr selSetCanceler_Handle = Selector.GetHandle ("setCanceler:");
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
		const string selSetParameters_ = "setParameters:";
		static readonly IntPtr selSetParameters_Handle = Selector.GetHandle ("setParameters:");
		[CompilerGenerated]
		const string selSetURL_ = "setURL:";
		static readonly IntPtr selSetURL_Handle = Selector.GetHandle ("setURL:");
		[CompilerGenerated]
		const string selURL = "URL";
		static readonly IntPtr selURLHandle = Selector.GetHandle ("URL");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBRestRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBRestRequest () : base (NSObjectFlag.Empty)
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
		public QBRestRequest (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRestRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRestRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("asyncRequestWithdelegate:")]
		[CompilerGenerated]
		public virtual void AsyncRequestWithdelegate (NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAsyncRequestWithdelegate_Handle, _delegate.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAsyncRequestWithdelegate_Handle, _delegate.Handle);
			}
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
		
		[CompilerGenerated]
		public virtual RestRequestBuildStyle BuildStyle {
			[Export ("buildStyle")]
			get {
				if (IsDirectBinding) {
					return (RestRequestBuildStyle) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selBuildStyleHandle);
				} else {
					return (RestRequestBuildStyle) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selBuildStyleHandle);
				}
			}
			
			[Export ("setBuildStyle:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetBuildStyle_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetBuildStyle_Handle, (UInt32)value);
				}
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
		public virtual NSObject[] Files {
			[Export ("files", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFilesHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFilesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Files_var = ret;
				return ret;
			}
			
			[Export ("setFiles:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFiles_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFiles_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Files_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string FinalURL {
			[Export ("finalURL")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFinalURLHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFinalURLHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Headers_var;
		[CompilerGenerated]
		public virtual NSDictionary Headers {
			[Export ("headers", ArgumentSemantic.Retain)]
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
			
			[Export ("setHeaders:", ArgumentSemantic.Retain)]
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
		public virtual string HttpMethod {
			[Export ("httpMethod")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHttpMethodHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHttpMethodHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual RestMethodKind Method {
			[Export ("method")]
			get {
				if (IsDirectBinding) {
					return (RestMethodKind) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selMethodHandle);
				} else {
					return (RestMethodKind) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selMethodHandle);
				}
			}
			
			[Export ("setMethod:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetMethod_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetMethod_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Parameters_var;
		[CompilerGenerated]
		public virtual NSDictionary Parameters {
			[Export ("parameters", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParametersHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParametersHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Parameters_var = ret;
				return ret;
			}
			
			[Export ("setParameters:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParameters_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParameters_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Parameters_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_RawBodyWithoutEncode_var;
		[CompilerGenerated]
		public virtual NSData RawBodyWithoutEncode {
			[Export ("rawBodyWithoutEncode")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRawBodyWithoutEncodeHandle));
				} else {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRawBodyWithoutEncodeHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RawBodyWithoutEncode_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_URL_var;
		[CompilerGenerated]
		public virtual NSUrl URL {
			[Export ("URL", ArgumentSemantic.Retain)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selURLHandle));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selURLHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_URL_var = ret;
				return ret;
			}
			
			[Export ("setURL:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetURL_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetURL_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_URL_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Canceler_var = null;
				__mt_Delegate_var = null;
				__mt_Files_var = null;
				__mt_Headers_var = null;
				__mt_Parameters_var = null;
				__mt_RawBodyWithoutEncode_var = null;
				__mt_URL_var = null;
			}
		}
	} /* class QBRestRequest */
}
