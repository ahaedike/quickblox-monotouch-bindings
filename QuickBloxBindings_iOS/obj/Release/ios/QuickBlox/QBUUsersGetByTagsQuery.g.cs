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
	[Register("QBUUsersGetByTagsQuery", true)]
	public unsafe partial class QBUUsersGetByTagsQuery : QBUUserQuery {
		[CompilerGenerated]
		const string selInitWithTags_ = "initWithTags:";
		static readonly IntPtr selInitWithTags_Handle = Selector.GetHandle ("initWithTags:");
		[CompilerGenerated]
		const string selInitWithTagsPagedRequest_ = "initWithTags:pagedRequest:";
		static readonly IntPtr selInitWithTagsPagedRequest_Handle = Selector.GetHandle ("initWithTags:pagedRequest:");
		[CompilerGenerated]
		const string selPagedRequest = "pagedRequest";
		static readonly IntPtr selPagedRequestHandle = Selector.GetHandle ("pagedRequest");
		[CompilerGenerated]
		const string selSetPagedRequest_ = "setPagedRequest:";
		static readonly IntPtr selSetPagedRequest_Handle = Selector.GetHandle ("setPagedRequest:");
		[CompilerGenerated]
		const string selSetTags_ = "setTags:";
		static readonly IntPtr selSetTags_Handle = Selector.GetHandle ("setTags:");
		[CompilerGenerated]
		const string selTags = "tags";
		static readonly IntPtr selTagsHandle = Selector.GetHandle ("tags");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBUUsersGetByTagsQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBUUsersGetByTagsQuery () : base (NSObjectFlag.Empty)
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
		public QBUUsersGetByTagsQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUsersGetByTagsQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUsersGetByTagsQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTags:")]
		[CompilerGenerated]
		public QBUUsersGetByTagsQuery (NSObject[] _tags)
			: base (NSObjectFlag.Empty)
		{
			if (_tags == null)
				throw new ArgumentNullException ("_tags");
			var nsa__tags = NSArray.FromNSObjects (_tags);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithTags_Handle, nsa__tags.Handle), "initWithTags:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithTags_Handle, nsa__tags.Handle), "initWithTags:");
			}
			nsa__tags.Dispose ();
			
		}
		
		[Export ("initWithTags:pagedRequest:")]
		[CompilerGenerated]
		public QBUUsersGetByTagsQuery (NSObject[] _tags, PagedRequest _pagedRequest)
			: base (NSObjectFlag.Empty)
		{
			if (_tags == null)
				throw new ArgumentNullException ("_tags");
			if (_pagedRequest == null)
				throw new ArgumentNullException ("_pagedRequest");
			var nsa__tags = NSArray.FromNSObjects (_tags);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithTagsPagedRequest_Handle, nsa__tags.Handle, _pagedRequest.Handle), "initWithTags:pagedRequest:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithTagsPagedRequest_Handle, nsa__tags.Handle, _pagedRequest.Handle), "initWithTags:pagedRequest:");
			}
			nsa__tags.Dispose ();
			
		}
		
		[CompilerGenerated]
		object __mt_PagedRequest_var;
		[CompilerGenerated]
		public virtual PagedRequest PagedRequest {
			[Export ("pagedRequest", ArgumentSemantic.Retain)]
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
			
			[Export ("setPagedRequest:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPagedRequest_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPagedRequest_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PagedRequest_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Tags_var;
		[CompilerGenerated]
		public virtual NSObject[] Tags {
			[Export ("tags", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTagsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTagsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Tags_var = ret;
				return ret;
			}
			
			[Export ("setTags:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTags_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTags_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Tags_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PagedRequest_var = null;
				__mt_Tags_var = null;
			}
		}
	} /* class QBUUsersGetByTagsQuery */
}
