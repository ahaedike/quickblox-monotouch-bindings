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
	[Register("QBLGeoData", true)]
	public unsafe partial class QBLGeoData : Entity {
		[CompilerGenerated]
		const string selLatitude = "latitude";
		static readonly IntPtr selLatitudeHandle = Selector.GetHandle ("latitude");
		[CompilerGenerated]
		const string selSetLatitude_ = "setLatitude:";
		static readonly IntPtr selSetLatitude_Handle = Selector.GetHandle ("setLatitude:");
		[CompilerGenerated]
		const string selLongitude = "longitude";
		static readonly IntPtr selLongitudeHandle = Selector.GetHandle ("longitude");
		[CompilerGenerated]
		const string selSetLongitude_ = "setLongitude:";
		static readonly IntPtr selSetLongitude_Handle = Selector.GetHandle ("setLongitude:");
		[CompilerGenerated]
		const string selStatus = "status";
		static readonly IntPtr selStatusHandle = Selector.GetHandle ("status");
		[CompilerGenerated]
		const string selSetStatus_ = "setStatus:";
		static readonly IntPtr selSetStatus_Handle = Selector.GetHandle ("setStatus:");
		[CompilerGenerated]
		const string selUserID = "userID";
		static readonly IntPtr selUserIDHandle = Selector.GetHandle ("userID");
		[CompilerGenerated]
		const string selSetUserID_ = "setUserID:";
		static readonly IntPtr selSetUserID_Handle = Selector.GetHandle ("setUserID:");
		[CompilerGenerated]
		const string selUser = "user";
		static readonly IntPtr selUserHandle = Selector.GetHandle ("user");
		[CompilerGenerated]
		const string selSetUser_ = "setUser:";
		static readonly IntPtr selSetUser_Handle = Selector.GetHandle ("setUser:");
		[CompilerGenerated]
		const string selApplicationID = "applicationID";
		static readonly IntPtr selApplicationIDHandle = Selector.GetHandle ("applicationID");
		[CompilerGenerated]
		const string selSetApplicationID_ = "setApplicationID:";
		static readonly IntPtr selSetApplicationID_Handle = Selector.GetHandle ("setApplicationID:");
		[CompilerGenerated]
		const string selCreatedAtTimestamp = "createdAtTimestamp";
		static readonly IntPtr selCreatedAtTimestampHandle = Selector.GetHandle ("createdAtTimestamp");
		[CompilerGenerated]
		const string selSetCreatedAtTimestamp_ = "setCreatedAtTimestamp:";
		static readonly IntPtr selSetCreatedAtTimestamp_Handle = Selector.GetHandle ("setCreatedAtTimestamp:");
		[CompilerGenerated]
		const string selGeoData = "geoData";
		static readonly IntPtr selGeoDataHandle = Selector.GetHandle ("geoData");
		[CompilerGenerated]
		const string selCurrentGeoData = "currentGeoData";
		static readonly IntPtr selCurrentGeoDataHandle = Selector.GetHandle ("currentGeoData");
		[CompilerGenerated]
		const string selLocation = "location";
		static readonly IntPtr selLocationHandle = Selector.GetHandle ("location");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBLGeoData");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBLGeoData () : base (NSObjectFlag.Empty)
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
		public QBLGeoData (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGeoData (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGeoData (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
		public virtual string Status {
			[Export ("status", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStatusHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStatusHandle));
				}
			}
			
			[Export ("setStatus:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetStatus_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetStatus_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 UserID {
			[Export ("userID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selUserIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selUserIDHandle);
				}
			}
			
			[Export ("setUserID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetUserID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetUserID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_User_var;
		[CompilerGenerated]
		public virtual QBUUser User {
			[Export ("user", ArgumentSemantic.Retain)]
			get {
				QBUUser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBUUser> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserHandle));
				} else {
					ret =  Runtime.GetNSObject<QBUUser> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_User_var = ret;
				return ret;
			}
			
			[Export ("setUser:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUser_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUser_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_User_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 ApplicationID {
			[Export ("applicationID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selApplicationIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selApplicationIDHandle);
				}
			}
			
			[Export ("setApplicationID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetApplicationID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetApplicationID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 CreatedAtTimestamp {
			[Export ("createdAtTimestamp")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selCreatedAtTimestampHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selCreatedAtTimestampHandle);
				}
			}
			
			[Export ("setCreatedAtTimestamp:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetCreatedAtTimestamp_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetCreatedAtTimestamp_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		static object __mt_GeoData_var_static;
		[CompilerGenerated]
		public static QBLGeoData GeoData {
			[Export ("geoData")]
			get {
				QBLGeoData ret;
				ret =  Runtime.GetNSObject<QBLGeoData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selGeoDataHandle));
				__mt_GeoData_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static object __mt_CurrentGeoData_var_static;
		[CompilerGenerated]
		public static QBLGeoData CurrentGeoData {
			[Export ("currentGeoData")]
			get {
				QBLGeoData ret;
				ret =  Runtime.GetNSObject<QBLGeoData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selCurrentGeoDataHandle));
				__mt_CurrentGeoData_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Location_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreLocation.CLLocation Location {
			[Export ("location")]
			get {
				global::MonoTouch.CoreLocation.CLLocation ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.CoreLocation.CLLocation> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocationHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.CoreLocation.CLLocation> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLocationHandle));
				}
				MarkDirty ();
				__mt_Location_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_User_var = null;
				__mt_Location_var = null;
			}
		}
	} /* class QBLGeoData */
}
