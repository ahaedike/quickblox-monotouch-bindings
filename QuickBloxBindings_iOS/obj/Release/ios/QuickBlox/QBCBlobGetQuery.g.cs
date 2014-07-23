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
	[Register("QBCBlobGetQuery", true)]
	public unsafe partial class QBCBlobGetQuery : QBCBlobQuery {
		[CompilerGenerated]
		const string selBlobId = "blobId";
		static readonly IntPtr selBlobIdHandle = Selector.GetHandle ("blobId");
		[CompilerGenerated]
		const string selInitWithBlobId_ = "initWithBlobId:";
		static readonly IntPtr selInitWithBlobId_Handle = Selector.GetHandle ("initWithBlobId:");
		[CompilerGenerated]
		const string selInitWithPagedRequestIsTaggedGet_ = "initWithPagedRequest:isTaggedGet:";
		static readonly IntPtr selInitWithPagedRequestIsTaggedGet_Handle = Selector.GetHandle ("initWithPagedRequest:isTaggedGet:");
		[CompilerGenerated]
		const string selPagedRequest = "pagedRequest";
		static readonly IntPtr selPagedRequestHandle = Selector.GetHandle ("pagedRequest");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCBlobGetQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCBlobGetQuery () : base (NSObjectFlag.Empty)
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
		public QBCBlobGetQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobGetQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobGetQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithBlobId:")]
		[CompilerGenerated]
		public QBCBlobGetQuery (global::System.UInt32 blobid)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selInitWithBlobId_Handle, blobid), "initWithBlobId:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selInitWithBlobId_Handle, blobid), "initWithBlobId:");
			}
		}
		
		[Export ("initWithPagedRequest:isTaggedGet:")]
		[CompilerGenerated]
		public QBCBlobGetQuery (PagedRequest pagedRequest, bool isTaggedGet)
			: base (NSObjectFlag.Empty)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (this.Handle, selInitWithPagedRequestIsTaggedGet_Handle, pagedRequest.Handle, isTaggedGet), "initWithPagedRequest:isTaggedGet:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selInitWithPagedRequestIsTaggedGet_Handle, pagedRequest.Handle, isTaggedGet), "initWithPagedRequest:isTaggedGet:");
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 BlobId {
			[Export ("blobId")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selBlobIdHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selBlobIdHandle);
				}
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PagedRequest_var = null;
			}
		}
	} /* class QBCBlobGetQuery */
}
