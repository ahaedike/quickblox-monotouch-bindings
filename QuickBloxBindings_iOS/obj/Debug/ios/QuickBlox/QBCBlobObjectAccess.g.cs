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
	[Register("QBCBlobObjectAccess", true)]
	public unsafe partial class QBCBlobObjectAccess : Entity {
		[CompilerGenerated]
		const string selBlobID = "blobID";
		static readonly IntPtr selBlobIDHandle = Selector.GetHandle ("blobID");
		[CompilerGenerated]
		const string selSetBlobID_ = "setBlobID:";
		static readonly IntPtr selSetBlobID_Handle = Selector.GetHandle ("setBlobID:");
		[CompilerGenerated]
		const string selType = "type";
		static readonly IntPtr selTypeHandle = Selector.GetHandle ("type");
		[CompilerGenerated]
		const string selSetType_ = "setType:";
		static readonly IntPtr selSetType_Handle = Selector.GetHandle ("setType:");
		[CompilerGenerated]
		const string selExpires = "expires";
		static readonly IntPtr selExpiresHandle = Selector.GetHandle ("expires");
		[CompilerGenerated]
		const string selSetExpires_ = "setExpires:";
		static readonly IntPtr selSetExpires_Handle = Selector.GetHandle ("setExpires:");
		[CompilerGenerated]
		const string selUrlWithParams = "urlWithParams";
		static readonly IntPtr selUrlWithParamsHandle = Selector.GetHandle ("urlWithParams");
		[CompilerGenerated]
		const string selSetUrlWithParams_ = "setUrlWithParams:";
		static readonly IntPtr selSetUrlWithParams_Handle = Selector.GetHandle ("setUrlWithParams:");
		[CompilerGenerated]
		const string selParams = "params";
		static readonly IntPtr selParamsHandle = Selector.GetHandle ("params");
		[CompilerGenerated]
		const string selSetParams_ = "setParams:";
		static readonly IntPtr selSetParams_Handle = Selector.GetHandle ("setParams:");
		[CompilerGenerated]
		const string selUrl = "url";
		static readonly IntPtr selUrlHandle = Selector.GetHandle ("url");
		[CompilerGenerated]
		const string selSetUrl_ = "setUrl:";
		static readonly IntPtr selSetUrl_Handle = Selector.GetHandle ("setUrl:");
		[CompilerGenerated]
		const string selExpired = "expired";
		static readonly IntPtr selExpiredHandle = Selector.GetHandle ("expired");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCBlobObjectAccess");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCBlobObjectAccess () : base (NSObjectFlag.Empty)
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
		public QBCBlobObjectAccess (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobObjectAccess (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobObjectAccess (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::System.UInt32 BlobID {
			[Export ("blobID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selBlobIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selBlobIDHandle);
				}
			}
			
			[Export ("setBlobID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetBlobID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetBlobID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual QBCBlobObjectAccessType Type {
			[Export ("type")]
			get {
				if (IsDirectBinding) {
					return (QBCBlobObjectAccessType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTypeHandle);
				} else {
					return (QBCBlobObjectAccessType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selTypeHandle);
				}
			}
			
			[Export ("setType:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetType_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetType_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Expires_var;
		[CompilerGenerated]
		public virtual NSDate Expires {
			[Export ("expires", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selExpiresHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selExpiresHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Expires_var = ret;
				return ret;
			}
			
			[Export ("setExpires:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetExpires_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetExpires_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Expires_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string UrlWithParams {
			[Export ("urlWithParams", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUrlWithParamsHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUrlWithParamsHandle));
				}
			}
			
			[Export ("setUrlWithParams:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUrlWithParams_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUrlWithParams_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Params_var;
		[CompilerGenerated]
		public virtual NSDictionary Params {
			[Export ("params", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Params_var = ret;
				return ret;
			}
			
			[Export ("setParams:", ArgumentSemantic.Retain)]
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
		object __mt_Url_var;
		[CompilerGenerated]
		public virtual NSUrl Url {
			[Export ("url", ArgumentSemantic.Retain)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUrlHandle));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUrlHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Url_var = ret;
				return ret;
			}
			
			[Export ("setUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUrl_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUrl_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Url_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Expired {
			[Export ("expired")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selExpiredHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selExpiredHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Expires_var = null;
				__mt_Params_var = null;
				__mt_Url_var = null;
			}
		}
	} /* class QBCBlobObjectAccess */
}
