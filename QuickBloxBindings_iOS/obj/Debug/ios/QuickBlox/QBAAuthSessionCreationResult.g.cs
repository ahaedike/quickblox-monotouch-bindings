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
	[Register("QBAAuthSessionCreationResult", true)]
	public unsafe partial class QBAAuthSessionCreationResult : NSObject {
		[CompilerGenerated]
		const string selSession = "session";
		static readonly IntPtr selSessionHandle = Selector.GetHandle ("session");
		[CompilerGenerated]
		const string selToken = "token";
		static readonly IntPtr selTokenHandle = Selector.GetHandle ("token");
		[CompilerGenerated]
		const string selSocialProviderToken = "socialProviderToken";
		static readonly IntPtr selSocialProviderTokenHandle = Selector.GetHandle ("socialProviderToken");
		[CompilerGenerated]
		const string selSocialProviderTokenExpiresAt = "socialProviderTokenExpiresAt";
		static readonly IntPtr selSocialProviderTokenExpiresAtHandle = Selector.GetHandle ("socialProviderTokenExpiresAt");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBAAuthSessionCreationResult");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBAAuthSessionCreationResult () : base (NSObjectFlag.Empty)
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
		public QBAAuthSessionCreationResult (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBAAuthSessionCreationResult (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBAAuthSessionCreationResult (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_Session_var;
		[CompilerGenerated]
		public virtual QBASession Session {
			[Export ("session")]
			get {
				QBASession ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBASession> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSessionHandle));
				} else {
					ret =  Runtime.GetNSObject<QBASession> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSessionHandle));
				}
				MarkDirty ();
				__mt_Session_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Token {
			[Export ("token")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTokenHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTokenHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SocialProviderToken {
			[Export ("socialProviderToken")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSocialProviderTokenHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSocialProviderTokenHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SocialProviderTokenExpiresAt_var;
		[CompilerGenerated]
		public virtual NSDate SocialProviderTokenExpiresAt {
			[Export ("socialProviderTokenExpiresAt")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSocialProviderTokenExpiresAtHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSocialProviderTokenExpiresAtHandle));
				}
				MarkDirty ();
				__mt_SocialProviderTokenExpiresAt_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Session_var = null;
				__mt_SocialProviderTokenExpiresAt_var = null;
			}
		}
	} /* class QBAAuthSessionCreationResult */
}
