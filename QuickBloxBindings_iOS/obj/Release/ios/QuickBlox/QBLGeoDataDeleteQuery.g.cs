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
	[Register("QBLGeoDataDeleteQuery", true)]
	public unsafe partial class QBLGeoDataDeleteQuery : QBLGeoDataQuery {
		[CompilerGenerated]
		const string selDeleteRequest = "deleteRequest";
		static readonly IntPtr selDeleteRequestHandle = Selector.GetHandle ("deleteRequest");
		[CompilerGenerated]
		const string selGeodataID = "geodataID";
		static readonly IntPtr selGeodataIDHandle = Selector.GetHandle ("geodataID");
		[CompilerGenerated]
		const string selInitWithGeoDataID_ = "initWithGeoDataID:";
		static readonly IntPtr selInitWithGeoDataID_Handle = Selector.GetHandle ("initWithGeoDataID:");
		[CompilerGenerated]
		const string selInitWithRequest_ = "initWithRequest:";
		static readonly IntPtr selInitWithRequest_Handle = Selector.GetHandle ("initWithRequest:");
		[CompilerGenerated]
		const string selSetGeodataID_ = "setGeodataID:";
		static readonly IntPtr selSetGeodataID_Handle = Selector.GetHandle ("setGeodataID:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBLGeoDataDeleteQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBLGeoDataDeleteQuery () : base (NSObjectFlag.Empty)
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
		public QBLGeoDataDeleteQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGeoDataDeleteQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGeoDataDeleteQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRequest:")]
		[CompilerGenerated]
		public QBLGeoDataDeleteQuery (QBLGeoDataDeleteRequest _deleteRequest)
			: base (NSObjectFlag.Empty)
		{
			if (_deleteRequest == null)
				throw new ArgumentNullException ("_deleteRequest");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithRequest_Handle, _deleteRequest.Handle), "initWithRequest:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithRequest_Handle, _deleteRequest.Handle), "initWithRequest:");
			}
		}
		
		[Export ("initWithGeoDataID:")]
		[CompilerGenerated]
		public QBLGeoDataDeleteQuery (global::System.UInt32 geodataID)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selInitWithGeoDataID_Handle, geodataID), "initWithGeoDataID:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selInitWithGeoDataID_Handle, geodataID), "initWithGeoDataID:");
			}
		}
		
		[CompilerGenerated]
		object __mt_DeleteRequest_var;
		[CompilerGenerated]
		public virtual QBLGeoDataDeleteRequest DeleteRequest {
			[Export ("deleteRequest")]
			get {
				QBLGeoDataDeleteRequest ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBLGeoDataDeleteRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDeleteRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<QBLGeoDataDeleteRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDeleteRequestHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DeleteRequest_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 GeodataID {
			[Export ("geodataID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selGeodataIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selGeodataIDHandle);
				}
			}
			
			[Export ("setGeodataID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetGeodataID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetGeodataID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DeleteRequest_var = null;
			}
		}
	} /* class QBLGeoDataDeleteQuery */
}
