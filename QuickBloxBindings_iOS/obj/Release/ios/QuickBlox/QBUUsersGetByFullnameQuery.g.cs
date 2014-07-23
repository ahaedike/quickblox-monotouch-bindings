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
	[Register("QBUUsersGetByFullnameQuery", true)]
	public unsafe partial class QBUUsersGetByFullnameQuery : QBUUserQuery {
		[CompilerGenerated]
		const string selInitWithUserFullName_ = "initWithUserFullName:";
		static readonly IntPtr selInitWithUserFullName_Handle = Selector.GetHandle ("initWithUserFullName:");
		[CompilerGenerated]
		const string selInitWithUserFullNamePagedRequest_ = "initWithUserFullName:pagedRequest:";
		static readonly IntPtr selInitWithUserFullNamePagedRequest_Handle = Selector.GetHandle ("initWithUserFullName:pagedRequest:");
		[CompilerGenerated]
		const string selPagedRequest = "pagedRequest";
		static readonly IntPtr selPagedRequestHandle = Selector.GetHandle ("pagedRequest");
		[CompilerGenerated]
		const string selSetPagedRequest_ = "setPagedRequest:";
		static readonly IntPtr selSetPagedRequest_Handle = Selector.GetHandle ("setPagedRequest:");
		[CompilerGenerated]
		const string selSetUserFullName_ = "setUserFullName:";
		static readonly IntPtr selSetUserFullName_Handle = Selector.GetHandle ("setUserFullName:");
		[CompilerGenerated]
		const string selUserFullName = "userFullName";
		static readonly IntPtr selUserFullNameHandle = Selector.GetHandle ("userFullName");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBUUsersGetByFullnameQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBUUsersGetByFullnameQuery () : base (NSObjectFlag.Empty)
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
		public QBUUsersGetByFullnameQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUsersGetByFullnameQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUsersGetByFullnameQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithUserFullName:")]
		[CompilerGenerated]
		public QBUUsersGetByFullnameQuery (string _userFullName)
			: base (NSObjectFlag.Empty)
		{
			if (_userFullName == null)
				throw new ArgumentNullException ("_userFullName");
			var ns_userFullName = NSString.CreateNative (_userFullName);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithUserFullName_Handle, ns_userFullName), "initWithUserFullName:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithUserFullName_Handle, ns_userFullName), "initWithUserFullName:");
			}
			NSString.ReleaseNative (ns_userFullName);
			
		}
		
		[Export ("initWithUserFullName:pagedRequest:")]
		[CompilerGenerated]
		public QBUUsersGetByFullnameQuery (string _userFullName, PagedRequest _pagedRequest)
			: base (NSObjectFlag.Empty)
		{
			if (_userFullName == null)
				throw new ArgumentNullException ("_userFullName");
			if (_pagedRequest == null)
				throw new ArgumentNullException ("_pagedRequest");
			var ns_userFullName = NSString.CreateNative (_userFullName);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithUserFullNamePagedRequest_Handle, ns_userFullName, _pagedRequest.Handle), "initWithUserFullName:pagedRequest:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithUserFullNamePagedRequest_Handle, ns_userFullName, _pagedRequest.Handle), "initWithUserFullName:pagedRequest:");
			}
			NSString.ReleaseNative (ns_userFullName);
			
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
		public virtual string UserFullName {
			[Export ("userFullName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserFullNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserFullNameHandle));
				}
			}
			
			[Export ("setUserFullName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserFullName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserFullName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
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
	} /* class QBUUsersGetByFullnameQuery */
}
