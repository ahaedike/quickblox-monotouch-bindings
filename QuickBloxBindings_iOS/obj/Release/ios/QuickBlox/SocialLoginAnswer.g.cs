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
	[Register("SocialLoginAnswer", true)]
	public unsafe partial class SocialLoginAnswer : RestAnswer {
		[CompilerGenerated]
		const string selPopulateAnswerHeaders_ = "populateAnswer:headers:";
		static readonly IntPtr selPopulateAnswerHeaders_Handle = Selector.GetHandle ("populateAnswer:headers:");
		[CompilerGenerated]
		const string selReturnResult = "returnResult";
		static readonly IntPtr selReturnResultHandle = Selector.GetHandle ("returnResult");
		[CompilerGenerated]
		const string selSession = "session";
		static readonly IntPtr selSessionHandle = Selector.GetHandle ("session");
		[CompilerGenerated]
		const string selSetSession_ = "setSession:";
		static readonly IntPtr selSetSession_Handle = Selector.GetHandle ("setSession:");
		[CompilerGenerated]
		const string selSetSocialProviderToken_ = "setSocialProviderToken:";
		static readonly IntPtr selSetSocialProviderToken_Handle = Selector.GetHandle ("setSocialProviderToken:");
		[CompilerGenerated]
		const string selSetSocialProviderTokenExpiresAt_ = "setSocialProviderTokenExpiresAt:";
		static readonly IntPtr selSetSocialProviderTokenExpiresAt_Handle = Selector.GetHandle ("setSocialProviderTokenExpiresAt:");
		[CompilerGenerated]
		const string selSetUser_ = "setUser:";
		static readonly IntPtr selSetUser_Handle = Selector.GetHandle ("setUser:");
		[CompilerGenerated]
		const string selSocialProviderToken = "socialProviderToken";
		static readonly IntPtr selSocialProviderTokenHandle = Selector.GetHandle ("socialProviderToken");
		[CompilerGenerated]
		const string selSocialProviderTokenExpiresAt = "socialProviderTokenExpiresAt";
		static readonly IntPtr selSocialProviderTokenExpiresAtHandle = Selector.GetHandle ("socialProviderTokenExpiresAt");
		[CompilerGenerated]
		const string selUser = "user";
		static readonly IntPtr selUserHandle = Selector.GetHandle ("user");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SocialLoginAnswer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SocialLoginAnswer () : base (NSObjectFlag.Empty)
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
		public SocialLoginAnswer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SocialLoginAnswer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SocialLoginAnswer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("populateAnswer:headers:")]
		[CompilerGenerated]
		public virtual void PopulateAnswer (string responce, NSDictionary headers)
		{
			if (responce == null)
				throw new ArgumentNullException ("responce");
			if (headers == null)
				throw new ArgumentNullException ("headers");
			var nsresponce = NSString.CreateNative (responce);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selPopulateAnswerHeaders_Handle, nsresponce, headers.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPopulateAnswerHeaders_Handle, nsresponce, headers.Handle);
			}
			NSString.ReleaseNative (nsresponce);
			
		}
		
		[Export ("returnResult")]
		[CompilerGenerated]
		public virtual void ReturnResult ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReturnResultHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selReturnResultHandle);
			}
		}
		
		[CompilerGenerated]
		object __mt_Session_var;
		[CompilerGenerated]
		public virtual NSObject Session {
			[Export ("session", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSessionHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSessionHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Session_var = ret;
				return ret;
			}
			
			[Export ("setSession:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSession_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSession_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Session_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string SocialProviderToken {
			[Export ("socialProviderToken", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSocialProviderTokenHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSocialProviderTokenHandle));
				}
			}
			
			[Export ("setSocialProviderToken:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSocialProviderToken_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSocialProviderToken_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_SocialProviderTokenExpiresAt_var;
		[CompilerGenerated]
		public virtual NSDate SocialProviderTokenExpiresAt {
			[Export ("socialProviderTokenExpiresAt", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSocialProviderTokenExpiresAtHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSocialProviderTokenExpiresAtHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SocialProviderTokenExpiresAt_var = ret;
				return ret;
			}
			
			[Export ("setSocialProviderTokenExpiresAt:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSocialProviderTokenExpiresAt_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSocialProviderTokenExpiresAt_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SocialProviderTokenExpiresAt_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_User_var;
		[CompilerGenerated]
		public virtual NSObject User {
			[Export ("user", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_User_var = ret;
				return ret;
			}
			
			[Export ("setUser:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUser_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUser_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_User_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Session_var = null;
				__mt_SocialProviderTokenExpiresAt_var = null;
				__mt_User_var = null;
			}
		}
	} /* class SocialLoginAnswer */
}
