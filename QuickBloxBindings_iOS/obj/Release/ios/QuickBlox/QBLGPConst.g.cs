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
	[Register("QBLGPConst", true)]
	public unsafe partial class QBLGPConst : NSObject {
		[CompilerGenerated]
		const string selCoordinateIsEqualTo_ = "coordinate:isEqualTo:";
		static readonly IntPtr selCoordinateIsEqualTo_Handle = Selector.GetHandle ("coordinate:isEqualTo:");
		[CompilerGenerated]
		const string selCoordinateWithLatitudeLongitude_ = "coordinateWithLatitude:longitude:";
		static readonly IntPtr selCoordinateWithLatitudeLongitude_Handle = Selector.GetHandle ("coordinateWithLatitude:longitude:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBLGPConst");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBLGPConst () : base (NSObjectFlag.Empty)
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
		public QBLGPConst (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGPConst (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGPConst (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("coordinate:isEqualTo:")]
		[CompilerGenerated]
		public static bool Coordinate (global::MonoTouch.CoreLocation.CLLocationCoordinate2D coordinate1, global::MonoTouch.CoreLocation.CLLocationCoordinate2D coRestRequestBuildStyleordinate2)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend_CLLocationCoordinate2D_CLLocationCoordinate2D (class_ptr, selCoordinateIsEqualTo_Handle, coordinate1, coRestRequestBuildStyleordinate2);
		}
		
		[Export ("coordinateWithLatitude:longitude:")]
		[CompilerGenerated]
		public static global::MonoTouch.CoreLocation.CLLocationCoordinate2D CoordinateWithLatitude (float latitude, float longitude)
		{
			global::MonoTouch.CoreLocation.CLLocationCoordinate2D ret;
			ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret_float_float (out ret, class_ptr, selCoordinateWithLatitudeLongitude_Handle, latitude, longitude);
			return ret;
		}
		
	} /* class QBLGPConst */
}
