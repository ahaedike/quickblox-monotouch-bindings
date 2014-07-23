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
	[Register("QBSocialLoginDialog", true)]
	public unsafe partial class QBSocialLoginDialog : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selAnswer = "answer";
		static readonly IntPtr selAnswerHandle = Selector.GetHandle ("answer");
		[CompilerGenerated]
		const string selHide = "hide";
		static readonly IntPtr selHideHandle = Selector.GetHandle ("hide");
		[CompilerGenerated]
		const string selOperation = "operation";
		static readonly IntPtr selOperationHandle = Selector.GetHandle ("operation");
		[CompilerGenerated]
		const string selRequest = "request";
		static readonly IntPtr selRequestHandle = Selector.GetHandle ("request");
		[CompilerGenerated]
		const string selSetAnswer_ = "setAnswer:";
		static readonly IntPtr selSetAnswer_Handle = Selector.GetHandle ("setAnswer:");
		[CompilerGenerated]
		const string selShowWithHTMLAndBaseURL_ = "showWithHTML:andBaseURL:";
		static readonly IntPtr selShowWithHTMLAndBaseURL_Handle = Selector.GetHandle ("showWithHTML:andBaseURL:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBSocialLoginDialog");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBSocialLoginDialog () : base (NSObjectFlag.Empty)
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
		public QBSocialLoginDialog (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBSocialLoginDialog (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBSocialLoginDialog (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hide")]
		[CompilerGenerated]
		public virtual void Hide ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selHideHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selHideHandle);
			}
		}
		
		[Export ("showWithHTML:andBaseURL:")]
		[CompilerGenerated]
		public virtual void ShowWithHTML (string html, NSUrl baseURL)
		{
			if (html == null)
				throw new ArgumentNullException ("html");
			if (baseURL == null)
				throw new ArgumentNullException ("baseURL");
			var nshtml = NSString.CreateNative (html);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selShowWithHTMLAndBaseURL_Handle, nshtml, baseURL.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selShowWithHTMLAndBaseURL_Handle, nshtml, baseURL.Handle);
			}
			NSString.ReleaseNative (nshtml);
			
		}
		
		[CompilerGenerated]
		object __mt_Answer_var;
		[CompilerGenerated]
		public virtual SocialLoginAnswer Answer {
			[Export ("answer", ArgumentSemantic.Retain)]
			get {
				SocialLoginAnswer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SocialLoginAnswer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnswerHandle));
				} else {
					ret =  Runtime.GetNSObject<SocialLoginAnswer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnswerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Answer_var = ret;
				return ret;
			}
			
			[Export ("setAnswer:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnswer_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnswer_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Answer_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Operation_var;
		[CompilerGenerated]
		public virtual NSObject Operation {
			[Export ("operation")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOperationHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOperationHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Operation_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Request_var;
		[CompilerGenerated]
		public virtual Request Request {
			[Export ("request")]
			get {
				Request ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<Request> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<Request> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRequestHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Request_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Answer_var = null;
				__mt_Operation_var = null;
				__mt_Request_var = null;
			}
		}
	} /* class QBSocialLoginDialog */
}
