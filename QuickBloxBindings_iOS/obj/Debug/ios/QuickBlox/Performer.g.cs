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
	[Register("Performer", true)]
	public unsafe partial class Performer : NSObject {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selCanceler = "canceler";
		static readonly IntPtr selCancelerHandle = Selector.GetHandle ("canceler");
		[CompilerGenerated]
		const string selSetCanceler_ = "setCanceler:";
		static readonly IntPtr selSetCanceler_Handle = Selector.GetHandle ("setCanceler:");
		[CompilerGenerated]
		const string selContext = "context";
		static readonly IntPtr selContextHandle = Selector.GetHandle ("context");
		[CompilerGenerated]
		const string selSetContext_ = "setContext:";
		static readonly IntPtr selSetContext_Handle = Selector.GetHandle ("setContext:");
		[CompilerGenerated]
		const string selPerformAsyncWithDelegate_ = "performAsyncWithDelegate:";
		static readonly IntPtr selPerformAsyncWithDelegate_Handle = Selector.GetHandle ("performAsyncWithDelegate:");
		[CompilerGenerated]
		const string selPerformAsyncWithDelegateContext_ = "performAsyncWithDelegate:context:";
		static readonly IntPtr selPerformAsyncWithDelegateContext_Handle = Selector.GetHandle ("performAsyncWithDelegate:context:");
		[CompilerGenerated]
		const string selCancel = "cancel";
		static readonly IntPtr selCancelHandle = Selector.GetHandle ("cancel");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Performer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Performer () : base (NSObjectFlag.Empty)
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
		public Performer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Performer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Performer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("performAsyncWithDelegate:")]
		[CompilerGenerated]
		public virtual NSObject PerformAsyncWithDelegate (NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selPerformAsyncWithDelegate_Handle, del.Handle));
			} else {
				return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selPerformAsyncWithDelegate_Handle, del.Handle));
			}
		}
		
		[Export ("performAsyncWithDelegate:context:")]
		[CompilerGenerated]
		public virtual NSObject PerformAsyncWithDelegate (NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selPerformAsyncWithDelegateContext_Handle, del.Handle, context.Handle));
			} else {
				return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selPerformAsyncWithDelegateContext_Handle, del.Handle, context.Handle));
			}
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
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual NSObject Delegate {
			[Export ("delegate", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Canceler_var;
		[CompilerGenerated]
		public virtual NSObject Canceler {
			[Export ("canceler", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCancelerHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCancelerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Canceler_var = ret;
				return ret;
			}
			
			[Export ("setCanceler:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCanceler_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCanceler_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Canceler_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Context_var;
		[CompilerGenerated]
		public virtual NSObject Context {
			[Export ("context", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContextHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContextHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Context_var = ret;
				return ret;
			}
			
			[Export ("setContext:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetContext_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetContext_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Context_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_Canceler_var = null;
				__mt_Context_var = null;
			}
		}
	} /* class Performer */
}
