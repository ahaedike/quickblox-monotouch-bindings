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
	[Register("DateTimeHelper", true)]
	public unsafe partial class DateTimeHelper : NSObject {
		[CompilerGenerated]
		const string selDateFromISO8601_ = "dateFromISO8601:";
		static readonly IntPtr selDateFromISO8601_Handle = Selector.GetHandle ("dateFromISO8601:");
		[CompilerGenerated]
		const string selDateFromQBTokenHeader_ = "dateFromQBTokenHeader:";
		static readonly IntPtr selDateFromQBTokenHeader_Handle = Selector.GetHandle ("dateFromQBTokenHeader:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("DateTimeHelper");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public DateTimeHelper () : base (NSObjectFlag.Empty)
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
		public DateTimeHelper (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public DateTimeHelper (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public DateTimeHelper (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("dateFromISO8601:")]
		[CompilerGenerated]
		public static NSDate DateFromISO8601 (string str)
		{
			if (str == null)
				throw new ArgumentNullException ("str");
			var nsstr = NSString.CreateNative (str);
			
			NSDate ret;
			ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selDateFromISO8601_Handle, nsstr));
			NSString.ReleaseNative (nsstr);
			
			return ret;
		}
		
		[Export ("dateFromQBTokenHeader:")]
		[CompilerGenerated]
		public static NSDate DateFromQBTokenHeader (string str)
		{
			if (str == null)
				throw new ArgumentNullException ("str");
			var nsstr = NSString.CreateNative (str);
			
			NSDate ret;
			ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selDateFromQBTokenHeader_Handle, nsstr));
			NSString.ReleaseNative (nsstr);
			
			return ret;
		}
		
	} /* class DateTimeHelper */
}
