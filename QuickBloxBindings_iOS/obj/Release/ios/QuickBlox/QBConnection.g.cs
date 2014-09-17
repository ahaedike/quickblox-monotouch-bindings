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
	[Register("QBConnection", true)]
	public unsafe partial class QBConnection : NSObject {
		[CompilerGenerated]
		const string selRegisterServiceKey_ = "registerServiceKey:";
		static readonly IntPtr selRegisterServiceKey_Handle = Selector.GetHandle ("registerServiceKey:");
		[CompilerGenerated]
		const string selRegisterServiceSecret_ = "registerServiceSecret:";
		static readonly IntPtr selRegisterServiceSecret_Handle = Selector.GetHandle ("registerServiceSecret:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBConnection");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBConnection () : base (NSObjectFlag.Empty)
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
		public QBConnection (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBConnection (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBConnection (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("registerServiceKey:")]
		[CompilerGenerated]
		public static void RegisterServiceKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selRegisterServiceKey_Handle, nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("registerServiceSecret:")]
		[CompilerGenerated]
		public static void RegisterServiceSecret (string secret)
		{
			if (secret == null)
				throw new ArgumentNullException ("secret");
			var nssecret = NSString.CreateNative (secret);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selRegisterServiceSecret_Handle, nssecret);
			NSString.ReleaseNative (nssecret);
			
		}
		
	} /* class QBConnection */
}
