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
	[Register("SignHelper", true)]
	public unsafe partial class SignHelper : NSObject {
		[CompilerGenerated]
		const string selSignClearTextWithSecret_ = "signClearText:withSecret:";
		static readonly IntPtr selSignClearTextWithSecret_Handle = Selector.GetHandle ("signClearText:withSecret:");
		[CompilerGenerated]
		const string selSignDataWithSecret_ = "signData:withSecret:";
		static readonly IntPtr selSignDataWithSecret_Handle = Selector.GetHandle ("signData:withSecret:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SignHelper");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SignHelper () : base (NSObjectFlag.Empty)
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
		public SignHelper (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SignHelper (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SignHelper (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("signClearText:withSecret:")]
		[CompilerGenerated]
		public static string SignClearText (string text, string secret)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			if (secret == null)
				throw new ArgumentNullException ("secret");
			var nstext = NSString.CreateNative (text);
			var nssecret = NSString.CreateNative (secret);
			
			string ret;
			ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selSignClearTextWithSecret_Handle, nstext, nssecret));
			NSString.ReleaseNative (nstext);
			NSString.ReleaseNative (nssecret);
			
			return ret;
		}
		
		[Export ("signData:withSecret:")]
		[CompilerGenerated]
		public static string SignData (NSData data, string secret)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (secret == null)
				throw new ArgumentNullException ("secret");
			var nssecret = NSString.CreateNative (secret);
			
			string ret;
			ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selSignDataWithSecret_Handle, data.Handle, nssecret));
			NSString.ReleaseNative (nssecret);
			
			return ret;
		}
		
	} /* class SignHelper */
}
