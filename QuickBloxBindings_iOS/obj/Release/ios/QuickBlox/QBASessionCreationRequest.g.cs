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
	[Register("QBASessionCreationRequest", true)]
	public unsafe partial class QBASessionCreationRequest : Request {
		[CompilerGenerated]
		const string selSocialProvider = "socialProvider";
		static readonly IntPtr selSocialProviderHandle = Selector.GetHandle ("socialProvider");
		[CompilerGenerated]
		const string selSetSocialProvider_ = "setSocialProvider:";
		static readonly IntPtr selSetSocialProvider_Handle = Selector.GetHandle ("setSocialProvider:");
		[CompilerGenerated]
		const string selScope = "scope";
		static readonly IntPtr selScopeHandle = Selector.GetHandle ("scope");
		[CompilerGenerated]
		const string selSetScope_ = "setScope:";
		static readonly IntPtr selSetScope_Handle = Selector.GetHandle ("setScope:");
		[CompilerGenerated]
		const string selSocialProviderAccessToken = "socialProviderAccessToken";
		static readonly IntPtr selSocialProviderAccessTokenHandle = Selector.GetHandle ("socialProviderAccessToken");
		[CompilerGenerated]
		const string selSetSocialProviderAccessToken_ = "setSocialProviderAccessToken:";
		static readonly IntPtr selSetSocialProviderAccessToken_Handle = Selector.GetHandle ("setSocialProviderAccessToken:");
		[CompilerGenerated]
		const string selSocialProviderAccessTokenSecret = "socialProviderAccessTokenSecret";
		static readonly IntPtr selSocialProviderAccessTokenSecretHandle = Selector.GetHandle ("socialProviderAccessTokenSecret");
		[CompilerGenerated]
		const string selSetSocialProviderAccessTokenSecret_ = "setSocialProviderAccessTokenSecret:";
		static readonly IntPtr selSetSocialProviderAccessTokenSecret_Handle = Selector.GetHandle ("setSocialProviderAccessTokenSecret:");
		[CompilerGenerated]
		const string selUserLogin = "userLogin";
		static readonly IntPtr selUserLoginHandle = Selector.GetHandle ("userLogin");
		[CompilerGenerated]
		const string selSetUserLogin_ = "setUserLogin:";
		static readonly IntPtr selSetUserLogin_Handle = Selector.GetHandle ("setUserLogin:");
		[CompilerGenerated]
		const string selUserEmail = "userEmail";
		static readonly IntPtr selUserEmailHandle = Selector.GetHandle ("userEmail");
		[CompilerGenerated]
		const string selSetUserEmail_ = "setUserEmail:";
		static readonly IntPtr selSetUserEmail_Handle = Selector.GetHandle ("setUserEmail:");
		[CompilerGenerated]
		const string selUserPassword = "userPassword";
		static readonly IntPtr selUserPasswordHandle = Selector.GetHandle ("userPassword");
		[CompilerGenerated]
		const string selSetUserPassword_ = "setUserPassword:";
		static readonly IntPtr selSetUserPassword_Handle = Selector.GetHandle ("setUserPassword:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBASessionCreationRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBASessionCreationRequest () : base (NSObjectFlag.Empty)
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
		public QBASessionCreationRequest (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBASessionCreationRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBASessionCreationRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string SocialProvider {
			[Export ("socialProvider", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSocialProviderHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSocialProviderHandle));
				}
			}
			
			[Export ("setSocialProvider:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSocialProvider_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSocialProvider_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Scope_var;
		[CompilerGenerated]
		public virtual NSObject[] Scope {
			[Export ("scope", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selScopeHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selScopeHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Scope_var = ret;
				return ret;
			}
			
			[Export ("setScope:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetScope_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetScope_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Scope_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string SocialProviderAccessToken {
			[Export ("socialProviderAccessToken", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSocialProviderAccessTokenHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSocialProviderAccessTokenHandle));
				}
			}
			
			[Export ("setSocialProviderAccessToken:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSocialProviderAccessToken_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSocialProviderAccessToken_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string SocialProviderAccessTokenSecret {
			[Export ("socialProviderAccessTokenSecret", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSocialProviderAccessTokenSecretHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSocialProviderAccessTokenSecretHandle));
				}
			}
			
			[Export ("setSocialProviderAccessTokenSecret:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSocialProviderAccessTokenSecret_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSocialProviderAccessTokenSecret_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UserLogin {
			[Export ("userLogin", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserLoginHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserLoginHandle));
				}
			}
			
			[Export ("setUserLogin:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserLogin_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserLogin_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UserEmail {
			[Export ("userEmail", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserEmailHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserEmailHandle));
				}
			}
			
			[Export ("setUserEmail:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserEmail_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserEmail_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UserPassword {
			[Export ("userPassword", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserPasswordHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserPasswordHandle));
				}
			}
			
			[Export ("setUserPassword:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserPassword_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserPassword_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Scope_var = null;
			}
		}
	} /* class QBASessionCreationRequest */
}
