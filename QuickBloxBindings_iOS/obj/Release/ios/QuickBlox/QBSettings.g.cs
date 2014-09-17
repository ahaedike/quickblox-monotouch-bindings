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
	[Register("QBSettings", true)]
	public unsafe partial class QBSettings : NSObject {
		[CompilerGenerated]
		const string selSetAccountKey_ = "setAccountKey:";
		static readonly IntPtr selSetAccountKey_Handle = Selector.GetHandle ("setAccountKey:");
		[CompilerGenerated]
		const string selUseProductionEnvironmentForPushNotifications_ = "useProductionEnvironmentForPushNotifications:";
		static readonly IntPtr selUseProductionEnvironmentForPushNotifications_Handle = Selector.GetHandle ("useProductionEnvironmentForPushNotifications:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBSettings");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBSettings () : base (NSObjectFlag.Empty)
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
		public QBSettings (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBSettings (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBSettings (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setAccountKey:")]
		[CompilerGenerated]
		public static void SetAccountKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetAccountKey_Handle, nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("useProductionEnvironmentForPushNotifications:")]
		[CompilerGenerated]
		public static void UseProductionEnvironmentForPushNotifications (bool useProductionEnvironment)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selUseProductionEnvironmentForPushNotifications_Handle, useProductionEnvironment);
		}
		
	} /* class QBSettings */
}
