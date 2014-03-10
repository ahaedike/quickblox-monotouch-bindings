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
	[Register("QBLGPConst", true)]
	public unsafe partial class QBLGPConst : NSObject {
		[CompilerGenerated]
		const string selCoordinateWithLatitudeLongitude_ = "coordinateWithLatitude:longitude:";
		static readonly IntPtr selCoordinateWithLatitudeLongitude_Handle = Selector.GetHandle ("coordinateWithLatitude:longitude:");
		[CompilerGenerated]
		const string selGeodataRectWithNWSE_ = "geodataRectWithNW:SE:";
		static readonly IntPtr selGeodataRectWithNWSE_Handle = Selector.GetHandle ("geodataRectWithNW:SE:");
		[CompilerGenerated]
		const string selCoordinateIsEqualTo_ = "coordinate:isEqualTo:";
		static readonly IntPtr selCoordinateIsEqualTo_Handle = Selector.GetHandle ("coordinate:isEqualTo:");
		[CompilerGenerated]
		const string selGeodataRectIsEqualTo_ = "geodataRect:isEqualTo:";
		static readonly IntPtr selGeodataRectIsEqualTo_Handle = Selector.GetHandle ("geodataRect:isEqualTo:");
		
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

		[Export ("coordinateWithLatitude:longitude:")]
		[CompilerGenerated]
		public static global::MonoTouch.CoreLocation.CLLocationCoordinate2D CoordinateWithLatitude (global::System.Double latitude, global::System.Double longitude)
		{
			global::MonoTouch.CoreLocation.CLLocationCoordinate2D ret;
			ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret_Double_Double (out ret, class_ptr, selCoordinateWithLatitudeLongitude_Handle, latitude, longitude);
			return ret;
		}
		
		[Export ("geodataRectWithNW:SE:")]
		[CompilerGenerated]
		public static NSObject GeodataRectWithNW (global::MonoTouch.CoreLocation.CLLocationCoordinate2D NWpoint, global::MonoTouch.CoreLocation.CLLocationCoordinate2D SEpoint)
		{
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_CLLocationCoordinate2D (class_ptr, selGeodataRectWithNWSE_Handle, NWpoint, SEpoint));
		}
		
		[Export ("coordinate:isEqualTo:")]
		[CompilerGenerated]
		public static bool Coordinate (global::MonoTouch.CoreLocation.CLLocationCoordinate2D coordinate1, global::MonoTouch.CoreLocation.CLLocationCoordinate2D coordinate2)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend_CLLocationCoordinate2D_CLLocationCoordinate2D (class_ptr, selCoordinateIsEqualTo_Handle, coordinate1, coordinate2);
		}
		
		[Export ("geodataRect:isEqualTo:")]
		[CompilerGenerated]
		public static bool GeodataRect (NSObject rect1, NSObject rect2)
		{
			if (rect1 == null)
				throw new ArgumentNullException ("rect1");
			if (rect2 == null)
				throw new ArgumentNullException ("rect2");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (class_ptr, selGeodataRectIsEqualTo_Handle, rect1.Handle, rect2.Handle);
		}
		
	} /* class QBLGPConst */
}
