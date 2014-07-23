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
	[Register("QBLPlace", true)]
	public unsafe partial class QBLPlace : Entity {
		[CompilerGenerated]
		const string selAddress = "address";
		static readonly IntPtr selAddressHandle = Selector.GetHandle ("address");
		[CompilerGenerated]
		const string selGeoDataID = "geoDataID";
		static readonly IntPtr selGeoDataIDHandle = Selector.GetHandle ("geoDataID");
		[CompilerGenerated]
		const string selLatitude = "latitude";
		static readonly IntPtr selLatitudeHandle = Selector.GetHandle ("latitude");
		[CompilerGenerated]
		const string selLongitude = "longitude";
		static readonly IntPtr selLongitudeHandle = Selector.GetHandle ("longitude");
		[CompilerGenerated]
		const string selPhotoID = "photoID";
		static readonly IntPtr selPhotoIDHandle = Selector.GetHandle ("photoID");
		[CompilerGenerated]
		const string selPlace = "place";
		static readonly IntPtr selPlaceHandle = Selector.GetHandle ("place");
		[CompilerGenerated]
		const string selPlaceDescription = "placeDescription";
		static readonly IntPtr selPlaceDescriptionHandle = Selector.GetHandle ("placeDescription");
		[CompilerGenerated]
		const string selSetAddress_ = "setAddress:";
		static readonly IntPtr selSetAddress_Handle = Selector.GetHandle ("setAddress:");
		[CompilerGenerated]
		const string selSetGeoDataID_ = "setGeoDataID:";
		static readonly IntPtr selSetGeoDataID_Handle = Selector.GetHandle ("setGeoDataID:");
		[CompilerGenerated]
		const string selSetLatitude_ = "setLatitude:";
		static readonly IntPtr selSetLatitude_Handle = Selector.GetHandle ("setLatitude:");
		[CompilerGenerated]
		const string selSetLongitude_ = "setLongitude:";
		static readonly IntPtr selSetLongitude_Handle = Selector.GetHandle ("setLongitude:");
		[CompilerGenerated]
		const string selSetPhotoID_ = "setPhotoID:";
		static readonly IntPtr selSetPhotoID_Handle = Selector.GetHandle ("setPhotoID:");
		[CompilerGenerated]
		const string selSetPlaceDescription_ = "setPlaceDescription:";
		static readonly IntPtr selSetPlaceDescription_Handle = Selector.GetHandle ("setPlaceDescription:");
		[CompilerGenerated]
		const string selSetTitle_ = "setTitle:";
		static readonly IntPtr selSetTitle_Handle = Selector.GetHandle ("setTitle:");
		[CompilerGenerated]
		const string selTitle = "title";
		static readonly IntPtr selTitleHandle = Selector.GetHandle ("title");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBLPlace");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBLPlace () : base (NSObjectFlag.Empty)
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
		public QBLPlace (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLPlace (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLPlace (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string Address {
			[Export ("address", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAddressHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAddressHandle));
				}
			}
			
			[Export ("setAddress:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAddress_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAddress_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 GeoDataID {
			[Export ("geoDataID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selGeoDataIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selGeoDataIDHandle);
				}
			}
			
			[Export ("setGeoDataID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetGeoDataID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetGeoDataID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Latitude {
			[Export ("latitude")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selLatitudeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selLatitudeHandle);
				}
			}
			
			[Export ("setLatitude:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetLatitude_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetLatitude_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Longitude {
			[Export ("longitude")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selLongitudeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selLongitudeHandle);
				}
			}
			
			[Export ("setLongitude:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetLongitude_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetLongitude_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 PhotoID {
			[Export ("photoID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPhotoIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPhotoIDHandle);
				}
			}
			
			[Export ("setPhotoID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPhotoID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPhotoID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		static object __mt_Place_var_static;
		[CompilerGenerated]
		public static QBLPlace Place {
			[Export ("place")]
			get {
				QBLPlace ret;
				ret =  Runtime.GetNSObject<QBLPlace> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selPlaceHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Place_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PlaceDescription {
			[Export ("placeDescription", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlaceDescriptionHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPlaceDescriptionHandle));
				}
			}
			
			[Export ("setPlaceDescription:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPlaceDescription_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPlaceDescription_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTitleHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTitleHandle));
				}
			}
			
			[Export ("setTitle:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTitle_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTitle_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class QBLPlace */
}
