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
	[Register("QBUUser", true)]
	public unsafe partial class QBUUser : Entity {
		[CompilerGenerated]
		const string selBlobID = "blobID";
		static readonly IntPtr selBlobIDHandle = Selector.GetHandle ("blobID");
		[CompilerGenerated]
		const string selEmail = "email";
		static readonly IntPtr selEmailHandle = Selector.GetHandle ("email");
		[CompilerGenerated]
		const string selExternalUserID = "externalUserID";
		static readonly IntPtr selExternalUserIDHandle = Selector.GetHandle ("externalUserID");
		[CompilerGenerated]
		const string selFacebookID = "facebookID";
		static readonly IntPtr selFacebookIDHandle = Selector.GetHandle ("facebookID");
		[CompilerGenerated]
		const string selFullName = "fullName";
		static readonly IntPtr selFullNameHandle = Selector.GetHandle ("fullName");
		[CompilerGenerated]
		const string selLastRequestAt = "lastRequestAt";
		static readonly IntPtr selLastRequestAtHandle = Selector.GetHandle ("lastRequestAt");
		[CompilerGenerated]
		const string selLogin = "login";
		static readonly IntPtr selLoginHandle = Selector.GetHandle ("login");
		[CompilerGenerated]
		const string selOldPassword = "oldPassword";
		static readonly IntPtr selOldPasswordHandle = Selector.GetHandle ("oldPassword");
		[CompilerGenerated]
		const string selPassword = "password";
		static readonly IntPtr selPasswordHandle = Selector.GetHandle ("password");
		[CompilerGenerated]
		const string selPhone = "phone";
		static readonly IntPtr selPhoneHandle = Selector.GetHandle ("phone");
		[CompilerGenerated]
		const string selSetBlobID_ = "setBlobID:";
		static readonly IntPtr selSetBlobID_Handle = Selector.GetHandle ("setBlobID:");
		[CompilerGenerated]
		const string selSetEmail_ = "setEmail:";
		static readonly IntPtr selSetEmail_Handle = Selector.GetHandle ("setEmail:");
		[CompilerGenerated]
		const string selSetExternalUserID_ = "setExternalUserID:";
		static readonly IntPtr selSetExternalUserID_Handle = Selector.GetHandle ("setExternalUserID:");
		[CompilerGenerated]
		const string selSetFacebookID_ = "setFacebookID:";
		static readonly IntPtr selSetFacebookID_Handle = Selector.GetHandle ("setFacebookID:");
		[CompilerGenerated]
		const string selSetFullName_ = "setFullName:";
		static readonly IntPtr selSetFullName_Handle = Selector.GetHandle ("setFullName:");
		[CompilerGenerated]
		const string selSetLastRequestAt_ = "setLastRequestAt:";
		static readonly IntPtr selSetLastRequestAt_Handle = Selector.GetHandle ("setLastRequestAt:");
		[CompilerGenerated]
		const string selSetLogin_ = "setLogin:";
		static readonly IntPtr selSetLogin_Handle = Selector.GetHandle ("setLogin:");
		[CompilerGenerated]
		const string selSetOldPassword_ = "setOldPassword:";
		static readonly IntPtr selSetOldPassword_Handle = Selector.GetHandle ("setOldPassword:");
		[CompilerGenerated]
		const string selSetPassword_ = "setPassword:";
		static readonly IntPtr selSetPassword_Handle = Selector.GetHandle ("setPassword:");
		[CompilerGenerated]
		const string selSetPhone_ = "setPhone:";
		static readonly IntPtr selSetPhone_Handle = Selector.GetHandle ("setPhone:");
		[CompilerGenerated]
		const string selSetTags_ = "setTags:";
		static readonly IntPtr selSetTags_Handle = Selector.GetHandle ("setTags:");
		[CompilerGenerated]
		const string selSetTwitterID_ = "setTwitterID:";
		static readonly IntPtr selSetTwitterID_Handle = Selector.GetHandle ("setTwitterID:");
		[CompilerGenerated]
		const string selSetWebsite_ = "setWebsite:";
		static readonly IntPtr selSetWebsite_Handle = Selector.GetHandle ("setWebsite:");
		[CompilerGenerated]
		const string selTags = "tags";
		static readonly IntPtr selTagsHandle = Selector.GetHandle ("tags");
		[CompilerGenerated]
		const string selTwitterID = "twitterID";
		static readonly IntPtr selTwitterIDHandle = Selector.GetHandle ("twitterID");
		[CompilerGenerated]
		const string selUser = "user";
		static readonly IntPtr selUserHandle = Selector.GetHandle ("user");
		[CompilerGenerated]
		const string selWebsite = "website";
		static readonly IntPtr selWebsiteHandle = Selector.GetHandle ("website");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBUUser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBUUser () : base (NSObjectFlag.Empty)
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
		public QBUUser (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("user")]
		[CompilerGenerated]
		public static QBUUser User ()
		{
			return  Runtime.GetNSObject<QBUUser> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selUserHandle));
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
		public virtual string Email {
			[Export ("email", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEmailHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEmailHandle));
				}
			}
			
			[Export ("setEmail:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetEmail_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetEmail_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 ExternalUserID {
			[Export ("externalUserID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selExternalUserIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selExternalUserIDHandle);
				}
			}
			
			[Export ("setExternalUserID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetExternalUserID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetExternalUserID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string FacebookID {
			[Export ("facebookID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFacebookIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFacebookIDHandle));
				}
			}
			
			[Export ("setFacebookID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFacebookID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFacebookID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string FullName {
			[Export ("fullName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFullNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFullNameHandle));
				}
			}
			
			[Export ("setFullName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFullName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFullName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_LastRequestAt_var;
		[CompilerGenerated]
		public virtual NSDate LastRequestAt {
			[Export ("lastRequestAt", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLastRequestAtHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLastRequestAtHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LastRequestAt_var = ret;
				return ret;
			}
			
			[Export ("setLastRequestAt:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLastRequestAt_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLastRequestAt_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LastRequestAt_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Login {
			[Export ("login", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLoginHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLoginHandle));
				}
			}
			
			[Export ("setLogin:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLogin_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLogin_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string OldPassword {
			[Export ("oldPassword", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOldPasswordHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOldPasswordHandle));
				}
			}
			
			[Export ("setOldPassword:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOldPassword_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOldPassword_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Password {
			[Export ("password", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPasswordHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPasswordHandle));
				}
			}
			
			[Export ("setPassword:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPassword_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPassword_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Phone {
			[Export ("phone", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPhoneHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPhoneHandle));
				}
			}
			
			[Export ("setPhone:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPhone_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPhone_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Tags_var;
		[CompilerGenerated]
		public virtual NSMutableArray Tags {
			[Export ("tags", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTagsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTagsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Tags_var = ret;
				return ret;
			}
			
			[Export ("setTags:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTags_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTags_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Tags_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string TwitterID {
			[Export ("twitterID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTwitterIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTwitterIDHandle));
				}
			}
			
			[Export ("setTwitterID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTwitterID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTwitterID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Website {
			[Export ("website", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWebsiteHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWebsiteHandle));
				}
			}
			
			[Export ("setWebsite:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetWebsite_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetWebsite_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_LastRequestAt_var = null;
				__mt_Tags_var = null;
			}
		}
	} /* class QBUUser */
}
