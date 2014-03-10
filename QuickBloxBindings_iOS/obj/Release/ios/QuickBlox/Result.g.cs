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
	[Register("Result", true)]
	public unsafe partial class Result : NSObject {
		[CompilerGenerated]
		const string selErrors = "errors";
		static readonly IntPtr selErrorsHandle = Selector.GetHandle ("errors");
		[CompilerGenerated]
		const string selSuccess = "success";
		static readonly IntPtr selSuccessHandle = Selector.GetHandle ("success");
		[CompilerGenerated]
		const string selStatus = "status";
		static readonly IntPtr selStatusHandle = Selector.GetHandle ("status");
		[CompilerGenerated]
		const string selRequest = "request";
		static readonly IntPtr selRequestHandle = Selector.GetHandle ("request");
		[CompilerGenerated]
		const string selSetRequest_ = "setRequest:";
		static readonly IntPtr selSetRequest_Handle = Selector.GetHandle ("setRequest:");
		[CompilerGenerated]
		const string selAnswer = "answer";
		static readonly IntPtr selAnswerHandle = Selector.GetHandle ("answer");
		[CompilerGenerated]
		const string selSetAnswer_ = "setAnswer:";
		static readonly IntPtr selSetAnswer_Handle = Selector.GetHandle ("setAnswer:");
		[CompilerGenerated]
		const string selInitWithRequestAnswer_ = "initWithRequest:answer:";
		static readonly IntPtr selInitWithRequestAnswer_Handle = Selector.GetHandle ("initWithRequest:answer:");
		[CompilerGenerated]
		const string selInitWithAnswer_ = "initWithAnswer:";
		static readonly IntPtr selInitWithAnswer_Handle = Selector.GetHandle ("initWithAnswer:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Result");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Result () : base (NSObjectFlag.Empty)
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
		public Result (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Result (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Result (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRequest:answer:")]
		[CompilerGenerated]
		public Result (Request req, Answer answ)
			: base (NSObjectFlag.Empty)
		{
			if (req == null)
				throw new ArgumentNullException ("req");
			if (answ == null)
				throw new ArgumentNullException ("answ");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithRequestAnswer_Handle, req.Handle, answ.Handle), "initWithRequest:answer:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithRequestAnswer_Handle, req.Handle, answ.Handle), "initWithRequest:answer:");
			}
		}
		
		[Export ("initWithAnswer:")]
		[CompilerGenerated]
		public Result (Answer answ)
			: base (NSObjectFlag.Empty)
		{
			if (answ == null)
				throw new ArgumentNullException ("answ");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithAnswer_Handle, answ.Handle), "initWithAnswer:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithAnswer_Handle, answ.Handle), "initWithAnswer:");
			}
		}
		
		[CompilerGenerated]
		object __mt_Errors_var;
		[CompilerGenerated]
		public virtual NSObject[] Errors {
			[Export ("errors")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selErrorsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selErrorsHandle));
				}
				MarkDirty ();
				__mt_Errors_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Success {
			[Export ("success")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSuccessHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSuccessHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Status {
			[Export ("status")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selStatusHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selStatusHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Request_var;
		[CompilerGenerated]
		public virtual Request Request {
			[Export ("request", ArgumentSemantic.Retain)]
			get {
				Request ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<Request> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<Request> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRequestHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Request_var = ret;
				return ret;
			}
			
			[Export ("setRequest:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRequest_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRequest_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Request_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Answer_var;
		[CompilerGenerated]
		public virtual Answer Answer {
			[Export ("answer", ArgumentSemantic.Retain)]
			get {
				Answer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<Answer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnswerHandle));
				} else {
					ret =  Runtime.GetNSObject<Answer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnswerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Answer_var = ret;
				return ret;
			}
			
			[Export ("setAnswer:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnswer_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnswer_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Answer_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Errors_var = null;
				__mt_Request_var = null;
				__mt_Answer_var = null;
			}
		}
	} /* class Result */
}
