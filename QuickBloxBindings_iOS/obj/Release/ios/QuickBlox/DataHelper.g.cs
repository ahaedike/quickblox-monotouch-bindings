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
	[Register("DataHelper", true)]
	public unsafe partial class DataHelper : NSObject {
		[CompilerGenerated]
		const string selDataFromHexString_ = "dataFromHexString:";
		static readonly IntPtr selDataFromHexString_Handle = Selector.GetHandle ("dataFromHexString:");
		[CompilerGenerated]
		const string selDataFromString_ = "dataFromString:";
		static readonly IntPtr selDataFromString_Handle = Selector.GetHandle ("dataFromString:");
		[CompilerGenerated]
		const string selDataFromStringEncoding_ = "dataFromString:encoding:";
		static readonly IntPtr selDataFromStringEncoding_Handle = Selector.GetHandle ("dataFromString:encoding:");
		[CompilerGenerated]
		const string selGzipDeflate_ = "gzipDeflate:";
		static readonly IntPtr selGzipDeflate_Handle = Selector.GetHandle ("gzipDeflate:");
		[CompilerGenerated]
		const string selGzipInflate_ = "gzipInflate:";
		static readonly IntPtr selGzipInflate_Handle = Selector.GetHandle ("gzipInflate:");
		[CompilerGenerated]
		const string selIsJPEGValid_ = "isJPEGValid:";
		static readonly IntPtr selIsJPEGValid_Handle = Selector.GetHandle ("isJPEGValid:");
		[CompilerGenerated]
		const string selParseIntFromData_ = "parseIntFromData:";
		static readonly IntPtr selParseIntFromData_Handle = Selector.GetHandle ("parseIntFromData:");
		[CompilerGenerated]
		const string selStringFromData_ = "stringFromData:";
		static readonly IntPtr selStringFromData_Handle = Selector.GetHandle ("stringFromData:");
		[CompilerGenerated]
		const string selStringFromDataEncoding_ = "stringFromData:encoding:";
		static readonly IntPtr selStringFromDataEncoding_Handle = Selector.GetHandle ("stringFromData:encoding:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("DataHelper");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public DataHelper () : base (NSObjectFlag.Empty)
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
		public DataHelper (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public DataHelper (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public DataHelper (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("dataFromHexString:")]
		[CompilerGenerated]
		public static NSData DataFromHexString (string hexString)
		{
			if (hexString == null)
				throw new ArgumentNullException ("hexString");
			var nshexString = NSString.CreateNative (hexString);
			
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selDataFromHexString_Handle, nshexString));
			NSString.ReleaseNative (nshexString);
			
			return ret;
		}
		
		[Export ("dataFromString:encoding:")]
		[CompilerGenerated]
		public static NSData DataFromString (string _string, NSStringEncoding encoding)
		{
			if (_string == null)
				throw new ArgumentNullException ("_string");
			var ns_string = NSString.CreateNative (_string);
			
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32 (class_ptr, selDataFromStringEncoding_Handle, ns_string, (UInt32)encoding));
			NSString.ReleaseNative (ns_string);
			
			return ret;
		}
		
		[Export ("dataFromString:")]
		[CompilerGenerated]
		public static NSData DataFromString (string _string)
		{
			if (_string == null)
				throw new ArgumentNullException ("_string");
			var ns_string = NSString.CreateNative (_string);
			
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selDataFromString_Handle, ns_string));
			NSString.ReleaseNative (ns_string);
			
			return ret;
		}
		
		[Export ("gzipDeflate:")]
		[CompilerGenerated]
		public static NSData GzipDeflate (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selGzipDeflate_Handle, data.Handle));
		}
		
		[Export ("gzipInflate:")]
		[CompilerGenerated]
		public static NSData GzipInflate (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selGzipInflate_Handle, data.Handle));
		}
		
		[Export ("isJPEGValid:")]
		[CompilerGenerated]
		public static bool IsJPEGValid (NSData jpeg)
		{
			if (jpeg == null)
				throw new ArgumentNullException ("jpeg");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selIsJPEGValid_Handle, jpeg.Handle);
		}
		
		[Export ("parseIntFromData:")]
		[CompilerGenerated]
		public static global::System.UInt32 ParseIntFromData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (class_ptr, selParseIntFromData_Handle, data.Handle);
		}
		
		[Export ("stringFromData:encoding:")]
		[CompilerGenerated]
		public static string StringFromData (NSData data, NSStringEncoding encoding)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32 (class_ptr, selStringFromDataEncoding_Handle, data.Handle, (UInt32)encoding));
		}
		
		[Export ("stringFromData:")]
		[CompilerGenerated]
		public static string StringFromData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selStringFromData_Handle, data.Handle));
		}
		
	} /* class DataHelper */
}
