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
	[Register("QBLGeoDataGetQuery", true)]
	public unsafe partial class QBLGeoDataGetQuery : QBLGeoDataQuery {
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
		const string selSearchRequest = "searchRequest";
		static readonly IntPtr selSearchRequestHandle = Selector.GetHandle ("searchRequest");
		[CompilerGenerated]
		const string selSetGeodataID_ = "setGeodataID:";
		static readonly IntPtr selSetGeodataID_Handle = Selector.GetHandle ("setGeodataID:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBLGeoDataGetQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBLGeoDataGetQuery () : base (NSObjectFlag.Empty)
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
		public QBLGeoDataGetQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGeoDataGetQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGeoDataGetQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRequest:")]
		[CompilerGenerated]
		public QBLGeoDataGetQuery (QBLGeoDataGetRequest _searchrequest)
			: base (NSObjectFlag.Empty)
		{
			if (_searchrequest == null)
				throw new ArgumentNullException ("_searchrequest");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithRequest_Handle, _searchrequest.Handle), "initWithRequest:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithRequest_Handle, _searchrequest.Handle), "initWithRequest:");
			}
		}
		
		[Export ("initWithGeoDataID:")]
		[CompilerGenerated]
		public QBLGeoDataGetQuery (global::System.UInt32 geodataID)
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
		object __mt_SearchRequest_var;
		[CompilerGenerated]
		public virtual QBLGeoDataGetRequest SearchRequest {
			[Export ("searchRequest")]
			get {
				QBLGeoDataGetRequest ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBLGeoDataGetRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSearchRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<QBLGeoDataGetRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSearchRequestHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SearchRequest_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SearchRequest_var = null;
			}
		}
	} /* class QBLGeoDataGetQuery */
}
