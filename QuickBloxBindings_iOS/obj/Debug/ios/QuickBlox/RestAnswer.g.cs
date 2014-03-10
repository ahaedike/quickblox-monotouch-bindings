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
	[Register("RestAnswer", true)]
	public unsafe partial class RestAnswer : Answer {
		[CompilerGenerated]
		const string selKind = "kind";
		static readonly IntPtr selKindHandle = Selector.GetHandle ("kind");
		[CompilerGenerated]
		const string selResponse = "response";
		static readonly IntPtr selResponseHandle = Selector.GetHandle ("response");
		[CompilerGenerated]
		const string selInitWithResponse_ = "initWithResponse:";
		static readonly IntPtr selInitWithResponse_Handle = Selector.GetHandle ("initWithResponse:");
		[CompilerGenerated]
		const string selLoad = "load";
		static readonly IntPtr selLoadHandle = Selector.GetHandle ("load");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("RestAnswer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RestAnswer () : base (NSObjectFlag.Empty)
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
		public RestAnswer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public RestAnswer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public RestAnswer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithResponse:")]
		[CompilerGenerated]
		public RestAnswer (QBRestResponse response)
			: base (NSObjectFlag.Empty)
		{
			if (response == null)
				throw new ArgumentNullException ("response");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithResponse_Handle, response.Handle), "initWithResponse:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithResponse_Handle, response.Handle), "initWithResponse:");
			}
		}
		
		[Export ("load")]
		[CompilerGenerated]
		public virtual void Load ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selLoadHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selLoadHandle);
			}
		}
		
		[CompilerGenerated]
		public virtual RestAnswerKind Kind {
			[Export ("kind")]
			get {
				if (IsDirectBinding) {
					return (RestAnswerKind) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selKindHandle);
				} else {
					return (RestAnswerKind) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selKindHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Response_var;
		[CompilerGenerated]
		public virtual QBRestResponse Response {
			[Export ("response")]
			get {
				QBRestResponse ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBRestResponse> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selResponseHandle));
				} else {
					ret =  Runtime.GetNSObject<QBRestResponse> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selResponseHandle));
				}
				MarkDirty ();
				__mt_Response_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Response_var = null;
			}
		}
	} /* class RestAnswer */
}
