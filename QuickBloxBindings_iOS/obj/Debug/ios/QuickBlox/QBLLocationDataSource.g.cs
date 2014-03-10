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
	[Register("QBLLocationDataSource", true)]
	public unsafe partial class QBLLocationDataSource : NSObject {
		[CompilerGenerated]
		const string selCurrentLocation = "currentLocation";
		static readonly IntPtr selCurrentLocationHandle = Selector.GetHandle ("currentLocation");
		[CompilerGenerated]
		const string selLocationManager = "locationManager";
		static readonly IntPtr selLocationManagerHandle = Selector.GetHandle ("locationManager");
		[CompilerGenerated]
		const string selLocationAvailable = "locationAvailable";
		static readonly IntPtr selLocationAvailableHandle = Selector.GetHandle ("locationAvailable");
		[CompilerGenerated]
		const string selInstance = "instance";
		static readonly IntPtr selInstanceHandle = Selector.GetHandle ("instance");
		[CompilerGenerated]
		const string selSetDistanceFilter_ = "setDistanceFilter:";
		static readonly IntPtr selSetDistanceFilter_Handle = Selector.GetHandle ("setDistanceFilter:");
		[CompilerGenerated]
		const string selSetDesiredAccuracy_ = "setDesiredAccuracy:";
		static readonly IntPtr selSetDesiredAccuracy_Handle = Selector.GetHandle ("setDesiredAccuracy:");
		[CompilerGenerated]
		const string selSetActionForLocationUpdateTarget_ = "setActionForLocationUpdate:target:";
		static readonly IntPtr selSetActionForLocationUpdateTarget_Handle = Selector.GetHandle ("setActionForLocationUpdate:target:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBLLocationDataSource");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBLLocationDataSource () : base (NSObjectFlag.Empty)
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
		public QBLLocationDataSource (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLLocationDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLLocationDataSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setActionForLocationUpdate:target:")]
		[CompilerGenerated]
		public virtual void SetActionForLocationUpdate (Selector action, NSObject target)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			if (target == null)
				throw new ArgumentNullException ("target");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetActionForLocationUpdateTarget_Handle, action.Handle, target.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetActionForLocationUpdateTarget_Handle, action.Handle, target.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_CurrentLocation_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreLocation.CLLocation CurrentLocation {
			[Export ("currentLocation")]
			get {
				global::MonoTouch.CoreLocation.CLLocation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.CoreLocation.CLLocation> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCurrentLocationHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.CoreLocation.CLLocation> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCurrentLocationHandle));
				}
				MarkDirty ();
				__mt_CurrentLocation_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LocationManager_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreLocation.CLLocationManager LocationManager {
			[Export ("locationManager")]
			get {
				global::MonoTouch.CoreLocation.CLLocationManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.CoreLocation.CLLocationManager> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocationManagerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.CoreLocation.CLLocationManager> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLocationManagerHandle));
				}
				MarkDirty ();
				__mt_LocationManager_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool LocationAvailable {
			[Export ("locationAvailable")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selLocationAvailableHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selLocationAvailableHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		static object __mt_Instance_var_static;
		[CompilerGenerated]
		public static QBLLocationDataSource Instance {
			[Export ("instance")]
			get {
				QBLLocationDataSource ret;
				ret =  Runtime.GetNSObject<QBLLocationDataSource> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selInstanceHandle));
				__mt_Instance_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.Double DistanceFilter {
			[Export ("setDistanceFilter:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDistanceFilter_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetDistanceFilter_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double DesiredAccuracy {
			[Export ("setDesiredAccuracy:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDesiredAccuracy_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetDesiredAccuracy_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CurrentLocation_var = null;
				__mt_LocationManager_var = null;
			}
		}
	} /* class QBLLocationDataSource */
}
