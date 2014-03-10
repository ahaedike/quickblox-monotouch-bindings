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
	[Register("QBASessionCreationQuery", true)]
	public unsafe partial class QBASessionCreationQuery : NSObject {
		[CompilerGenerated]
		const string selSessionCreationRequest = "sessionCreationRequest";
		static readonly IntPtr selSessionCreationRequestHandle = Selector.GetHandle ("sessionCreationRequest");
		[CompilerGenerated]
		const string selInitWithRequest_ = "initWithRequest:";
		static readonly IntPtr selInitWithRequest_Handle = Selector.GetHandle ("initWithRequest:");
		[CompilerGenerated]
		const string selSignRequest_ = "signRequest:";
		static readonly IntPtr selSignRequest_Handle = Selector.GetHandle ("signRequest:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBASessionCreationQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBASessionCreationQuery () : base (NSObjectFlag.Empty)
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
		public QBASessionCreationQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBASessionCreationQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBASessionCreationQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRequest:")]
		[CompilerGenerated]
		public QBASessionCreationQuery (QBASessionCreationRequest _sessionCreationRequest)
			: base (NSObjectFlag.Empty)
		{
			if (_sessionCreationRequest == null)
				throw new ArgumentNullException ("_sessionCreationRequest");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithRequest_Handle, _sessionCreationRequest.Handle), "initWithRequest:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithRequest_Handle, _sessionCreationRequest.Handle), "initWithRequest:");
			}
		}
		
		[Export ("signRequest:")]
		[CompilerGenerated]
		public virtual void SignRequest (QBRestRequest request)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSignRequest_Handle, request.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSignRequest_Handle, request.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_SessionCreationRequest_var;
		[CompilerGenerated]
		public virtual QBASessionCreationRequest SessionCreationRequest {
			[Export ("sessionCreationRequest")]
			get {
				QBASessionCreationRequest ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBASessionCreationRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSessionCreationRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<QBASessionCreationRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSessionCreationRequestHandle));
				}
				MarkDirty ();
				__mt_SessionCreationRequest_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SessionCreationRequest_var = null;
			}
		}
	} /* class QBASessionCreationQuery */
}
