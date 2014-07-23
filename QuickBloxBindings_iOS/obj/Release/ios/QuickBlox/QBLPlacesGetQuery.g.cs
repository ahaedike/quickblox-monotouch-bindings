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
	[Register("QBLPlacesGetQuery", true)]
	public unsafe partial class QBLPlacesGetQuery : QBLPlacesQuery {
		[CompilerGenerated]
		const string selInitWithPlaceID_ = "initWithPlaceID:";
		static readonly IntPtr selInitWithPlaceID_Handle = Selector.GetHandle ("initWithPlaceID:");
		[CompilerGenerated]
		const string selInitWithRequest_ = "initWithRequest:";
		static readonly IntPtr selInitWithRequest_Handle = Selector.GetHandle ("initWithRequest:");
		[CompilerGenerated]
		const string selPagedRequest = "pagedRequest";
		static readonly IntPtr selPagedRequestHandle = Selector.GetHandle ("pagedRequest");
		[CompilerGenerated]
		const string selPlaceID = "placeID";
		static readonly IntPtr selPlaceIDHandle = Selector.GetHandle ("placeID");
		[CompilerGenerated]
		const string selSetPlaceID_ = "setPlaceID:";
		static readonly IntPtr selSetPlaceID_Handle = Selector.GetHandle ("setPlaceID:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBLPlacesGetQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBLPlacesGetQuery () : base (NSObjectFlag.Empty)
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
		public QBLPlacesGetQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLPlacesGetQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLPlacesGetQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPlaceID:")]
		[CompilerGenerated]
		public QBLPlacesGetQuery (global::System.UInt32 placeID)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selInitWithPlaceID_Handle, placeID), "initWithPlaceID:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selInitWithPlaceID_Handle, placeID), "initWithPlaceID:");
			}
		}
		
		[Export ("initWithRequest:")]
		[CompilerGenerated]
		public QBLPlacesGetQuery (PagedRequest _pagedRequest)
			: base (NSObjectFlag.Empty)
		{
			if (_pagedRequest == null)
				throw new ArgumentNullException ("_pagedRequest");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithRequest_Handle, _pagedRequest.Handle), "initWithRequest:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithRequest_Handle, _pagedRequest.Handle), "initWithRequest:");
			}
		}
		
		[CompilerGenerated]
		object __mt_PagedRequest_var;
		[CompilerGenerated]
		public virtual PagedRequest PagedRequest {
			[Export ("pagedRequest")]
			get {
				PagedRequest ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PagedRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPagedRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<PagedRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPagedRequestHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PagedRequest_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 PlaceID {
			[Export ("placeID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPlaceIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPlaceIDHandle);
				}
			}
			
			[Export ("setPlaceID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPlaceID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPlaceID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PagedRequest_var = null;
			}
		}
	} /* class QBLPlacesGetQuery */
}
