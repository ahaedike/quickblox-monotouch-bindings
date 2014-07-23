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
	[Register("AsyncCanceler", true)]
	public unsafe partial class AsyncCanceler : NSObject {
		[CompilerGenerated]
		const string selCancel = "cancel";
		static readonly IntPtr selCancelHandle = Selector.GetHandle ("cancel");
		[CompilerGenerated]
		const string selCancelable = "cancelable";
		static readonly IntPtr selCancelableHandle = Selector.GetHandle ("cancelable");
		[CompilerGenerated]
		const string selCancelerFor_ = "cancelerFor:";
		static readonly IntPtr selCancelerFor_Handle = Selector.GetHandle ("cancelerFor:");
		[CompilerGenerated]
		const string selSetCancelable_ = "setCancelable:";
		static readonly IntPtr selSetCancelable_Handle = Selector.GetHandle ("setCancelable:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AsyncCanceler");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AsyncCanceler () : base (NSObjectFlag.Empty)
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
		public AsyncCanceler (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public AsyncCanceler (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public AsyncCanceler (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cancel")]
		[CompilerGenerated]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCancelHandle);
			}
		}
		
		[Export ("cancelerFor:")]
		[CompilerGenerated]
		public static AsyncCanceler CancelerFor (NSObject cancelable)
		{
			if (cancelable == null)
				throw new ArgumentNullException ("cancelable");
			return  Runtime.GetNSObject<AsyncCanceler> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selCancelerFor_Handle, cancelable.Handle));
		}
		
		[CompilerGenerated]
		object __mt_Cancelable_var;
		[CompilerGenerated]
		public virtual NSObject Cancelable {
			[Export ("cancelable", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCancelableHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCancelableHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Cancelable_var = ret;
				return ret;
			}
			
			[Export ("setCancelable:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCancelable_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCancelable_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Cancelable_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Cancelable_var = null;
			}
		}
	} /* class AsyncCanceler */
}
