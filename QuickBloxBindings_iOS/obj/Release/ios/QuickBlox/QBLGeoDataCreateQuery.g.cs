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
	[Register("QBLGeoDataCreateQuery", true)]
	public unsafe partial class QBLGeoDataCreateQuery : QBLGeoDataQuery {
		[CompilerGenerated]
		const string selGeodata = "geodata";
		static readonly IntPtr selGeodataHandle = Selector.GetHandle ("geodata");
		[CompilerGenerated]
		const string selInitWithGeoData_ = "initWithGeoData:";
		static readonly IntPtr selInitWithGeoData_Handle = Selector.GetHandle ("initWithGeoData:");
		[CompilerGenerated]
		const string selPushText = "pushText";
		static readonly IntPtr selPushTextHandle = Selector.GetHandle ("pushText");
		[CompilerGenerated]
		const string selRadius = "radius";
		static readonly IntPtr selRadiusHandle = Selector.GetHandle ("radius");
		[CompilerGenerated]
		const string selSetPushText_ = "setPushText:";
		static readonly IntPtr selSetPushText_Handle = Selector.GetHandle ("setPushText:");
		[CompilerGenerated]
		const string selSetRadius_ = "setRadius:";
		static readonly IntPtr selSetRadius_Handle = Selector.GetHandle ("setRadius:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBLGeoDataCreateQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBLGeoDataCreateQuery () : base (NSObjectFlag.Empty)
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
		public QBLGeoDataCreateQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGeoDataCreateQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGeoDataCreateQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithGeoData:")]
		[CompilerGenerated]
		public QBLGeoDataCreateQuery (QBLGeoData _geodata)
			: base (NSObjectFlag.Empty)
		{
			if (_geodata == null)
				throw new ArgumentNullException ("_geodata");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithGeoData_Handle, _geodata.Handle), "initWithGeoData:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithGeoData_Handle, _geodata.Handle), "initWithGeoData:");
			}
		}
		
		[CompilerGenerated]
		object __mt_Geodata_var;
		[CompilerGenerated]
		public virtual QBLGeoData Geodata {
			[Export ("geodata")]
			get {
				QBLGeoData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBLGeoData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGeodataHandle));
				} else {
					ret =  Runtime.GetNSObject<QBLGeoData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGeodataHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Geodata_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PushText {
			[Export ("pushText", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPushTextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPushTextHandle));
				}
			}
			
			[Export ("setPushText:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPushText_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPushText_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float Radius {
			[Export ("radius")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRadiusHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRadiusHandle);
				}
			}
			
			[Export ("setRadius:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRadius_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRadius_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Geodata_var = null;
			}
		}
	} /* class QBLGeoDataCreateQuery */
}
