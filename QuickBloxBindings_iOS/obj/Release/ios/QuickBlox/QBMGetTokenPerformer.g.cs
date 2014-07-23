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
	[Register("QBMGetTokenPerformer", true)]
	public unsafe partial class QBMGetTokenPerformer : NSObject {
		[CompilerGenerated]
		const string selActionInBg = "actionInBg";
		static readonly IntPtr selActionInBgHandle = Selector.GetHandle ("actionInBg");
		[CompilerGenerated]
		const string selCancel = "cancel";
		static readonly IntPtr selCancelHandle = Selector.GetHandle ("cancel");
		[CompilerGenerated]
		const string selCompleted = "completed";
		static readonly IntPtr selCompletedHandle = Selector.GetHandle ("completed");
		[CompilerGenerated]
		const string selContext = "context";
		static readonly IntPtr selContextHandle = Selector.GetHandle ("context");
		[CompilerGenerated]
		const string selIsCanceled = "isCanceled";
		static readonly IntPtr selIsCanceledHandle = Selector.GetHandle ("isCanceled");
		[CompilerGenerated]
		const string selPerformAction = "performAction";
		static readonly IntPtr selPerformActionHandle = Selector.GetHandle ("performAction");
		[CompilerGenerated]
		const string selPerformDelegate = "performDelegate";
		static readonly IntPtr selPerformDelegateHandle = Selector.GetHandle ("performDelegate");
		[CompilerGenerated]
		const string selSetCompleted_ = "setCompleted:";
		static readonly IntPtr selSetCompleted_Handle = Selector.GetHandle ("setCompleted:");
		[CompilerGenerated]
		const string selSetContext_ = "setContext:";
		static readonly IntPtr selSetContext_Handle = Selector.GetHandle ("setContext:");
		[CompilerGenerated]
		const string selSetIsCanceled_ = "setIsCanceled:";
		static readonly IntPtr selSetIsCanceled_Handle = Selector.GetHandle ("setIsCanceled:");
		[CompilerGenerated]
		const string selSetPerformDelegate_ = "setPerformDelegate:";
		static readonly IntPtr selSetPerformDelegate_Handle = Selector.GetHandle ("setPerformDelegate:");
		[CompilerGenerated]
		const string selTokenRequestTimedOut = "tokenRequestTimedOut";
		static readonly IntPtr selTokenRequestTimedOutHandle = Selector.GetHandle ("tokenRequestTimedOut");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMGetTokenPerformer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMGetTokenPerformer () : base (NSObjectFlag.Empty)
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
		public QBMGetTokenPerformer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMGetTokenPerformer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMGetTokenPerformer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("actionInBg")]
		[CompilerGenerated]
		public virtual void ActionInBg ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selActionInBgHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selActionInBgHandle);
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
		
		[Export ("performAction")]
		[CompilerGenerated]
		public virtual void PerformAction ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPerformActionHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPerformActionHandle);
			}
		}
		
		[Export ("tokenRequestTimedOut")]
		[CompilerGenerated]
		public virtual void TokenRequestTimedOut ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTokenRequestTimedOutHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTokenRequestTimedOutHandle);
			}
		}
		
		[CompilerGenerated]
		public virtual bool Completed {
			[Export ("completed")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCompletedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCompletedHandle);
				}
			}
			
			[Export ("setCompleted:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCompleted_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCompleted_Handle, value);
				}
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
		public virtual bool IsCanceled {
			[Export ("isCanceled")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCanceledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsCanceledHandle);
				}
			}
			
			[Export ("setIsCanceled:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsCanceled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsCanceled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_PerformDelegate_var;
		[CompilerGenerated]
		public virtual NSObject PerformDelegate {
			[Export ("performDelegate", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPerformDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPerformDelegateHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PerformDelegate_var = ret;
				return ret;
			}
			
			[Export ("setPerformDelegate:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPerformDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPerformDelegate_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PerformDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Context_var = null;
				__mt_PerformDelegate_var = null;
			}
		}
	} /* class QBMGetTokenPerformer */
}
