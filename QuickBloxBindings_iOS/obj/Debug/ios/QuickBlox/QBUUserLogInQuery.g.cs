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
	[Register("QBUUserLogInQuery", true)]
	public unsafe partial class QBUUserLogInQuery : NSObject {
		[CompilerGenerated]
		const string selUser = "user";
		static readonly IntPtr selUserHandle = Selector.GetHandle ("user");
		[CompilerGenerated]
		const string selSetUser_ = "setUser:";
		static readonly IntPtr selSetUser_Handle = Selector.GetHandle ("setUser:");
		[CompilerGenerated]
		const string selSocialProvider = "socialProvider";
		static readonly IntPtr selSocialProviderHandle = Selector.GetHandle ("socialProvider");
		[CompilerGenerated]
		const string selSetSocialProvider_ = "setSocialProvider:";
		static readonly IntPtr selSetSocialProvider_Handle = Selector.GetHandle ("setSocialProvider:");
		[CompilerGenerated]
		const string selSocialProviderScope = "socialProviderScope";
		static readonly IntPtr selSocialProviderScopeHandle = Selector.GetHandle ("socialProviderScope");
		[CompilerGenerated]
		const string selSetSocialProviderScope_ = "setSocialProviderScope:";
		static readonly IntPtr selSetSocialProviderScope_Handle = Selector.GetHandle ("setSocialProviderScope:");
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
		const string selInitWithQBUUser_ = "initWithQBUUser:";
		static readonly IntPtr selInitWithQBUUser_Handle = Selector.GetHandle ("initWithQBUUser:");
		[CompilerGenerated]
		const string selInitWithSocialProviderAndScope_ = "initWithSocialProvider:andScope:";
		static readonly IntPtr selInitWithSocialProviderAndScope_Handle = Selector.GetHandle ("initWithSocialProvider:andScope:");
		[CompilerGenerated]
		const string selInitWithSocialProviderAccessTokenAccessTokenSecret_ = "initWithSocialProvider:accessToken:accessTokenSecret:";
		static readonly IntPtr selInitWithSocialProviderAccessTokenAccessTokenSecret_Handle = Selector.GetHandle ("initWithSocialProvider:accessToken:accessTokenSecret:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBUUserLogInQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBUUserLogInQuery () : base (NSObjectFlag.Empty)
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
		public QBUUserLogInQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUserLogInQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUserLogInQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithQBUUser:")]
		[CompilerGenerated]
		public QBUUserLogInQuery (QBUUser user)
			: base (NSObjectFlag.Empty)
		{
			if (user == null)
				throw new ArgumentNullException ("user");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithQBUUser_Handle, user.Handle), "initWithQBUUser:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithQBUUser_Handle, user.Handle), "initWithQBUUser:");
			}
		}
		
		[Export ("initWithSocialProvider:andScope:")]
		[CompilerGenerated]
		public QBUUserLogInQuery (string socialProvider, NSObject[] scope)
			: base (NSObjectFlag.Empty)
		{
			if (socialProvider == null)
				throw new ArgumentNullException ("socialProvider");
			if (scope == null)
				throw new ArgumentNullException ("scope");
			var nssocialProvider = NSString.CreateNative (socialProvider);
			var nsa_scope = NSArray.FromNSObjects (scope);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithSocialProviderAndScope_Handle, nssocialProvider, nsa_scope.Handle), "initWithSocialProvider:andScope:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithSocialProviderAndScope_Handle, nssocialProvider, nsa_scope.Handle), "initWithSocialProvider:andScope:");
			}
			NSString.ReleaseNative (nssocialProvider);
			nsa_scope.Dispose ();
			
		}
		
		[Export ("initWithSocialProvider:accessToken:accessTokenSecret:")]
		[CompilerGenerated]
		public QBUUserLogInQuery (string socialProvider, string accessToken, string accessTokenSecret)
			: base (NSObjectFlag.Empty)
		{
			if (socialProvider == null)
				throw new ArgumentNullException ("socialProvider");
			if (accessToken == null)
				throw new ArgumentNullException ("accessToken");
			if (accessTokenSecret == null)
				throw new ArgumentNullException ("accessTokenSecret");
			var nssocialProvider = NSString.CreateNative (socialProvider);
			var nsaccessToken = NSString.CreateNative (accessToken);
			var nsaccessTokenSecret = NSString.CreateNative (accessTokenSecret);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithSocialProviderAccessTokenAccessTokenSecret_Handle, nssocialProvider, nsaccessToken, nsaccessTokenSecret), "initWithSocialProvider:accessToken:accessTokenSecret:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithSocialProviderAccessTokenAccessTokenSecret_Handle, nssocialProvider, nsaccessToken, nsaccessTokenSecret), "initWithSocialProvider:accessToken:accessTokenSecret:");
			}
			NSString.ReleaseNative (nssocialProvider);
			NSString.ReleaseNative (nsaccessToken);
			NSString.ReleaseNative (nsaccessTokenSecret);
			
		}
		
		[CompilerGenerated]
		object __mt_User_var;
		[CompilerGenerated]
		public virtual QBUUser User {
			[Export ("user", ArgumentSemantic.Retain)]
			get {
				QBUUser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBUUser> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserHandle));
				} else {
					ret =  Runtime.GetNSObject<QBUUser> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserHandle));
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
		object __mt_SocialProviderScope_var;
		[CompilerGenerated]
		public virtual NSObject[] SocialProviderScope {
			[Export ("socialProviderScope", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSocialProviderScopeHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSocialProviderScopeHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SocialProviderScope_var = ret;
				return ret;
			}
			
			[Export ("setSocialProviderScope:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSocialProviderScope_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSocialProviderScope_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_SocialProviderScope_var = value;
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_User_var = null;
				__mt_SocialProviderScope_var = null;
			}
		}
	} /* class QBUUserLogInQuery */
}
