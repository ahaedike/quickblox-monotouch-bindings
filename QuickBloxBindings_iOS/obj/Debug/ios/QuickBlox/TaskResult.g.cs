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
	[Register("TaskResult", true)]
	public unsafe partial class TaskResult : Result {
		[CompilerGenerated]
		const string selErrorsList = "errorsList";
		static readonly IntPtr selErrorsListHandle = Selector.GetHandle ("errorsList");
		[CompilerGenerated]
		const string selSetErrorsList_ = "setErrorsList:";
		static readonly IntPtr selSetErrorsList_Handle = Selector.GetHandle ("setErrorsList:");
		[CompilerGenerated]
		const string selFailedResult = "failedResult";
		static readonly IntPtr selFailedResultHandle = Selector.GetHandle ("failedResult");
		[CompilerGenerated]
		const string selSetFailedResult_ = "setFailedResult:";
		static readonly IntPtr selSetFailedResult_Handle = Selector.GetHandle ("setFailedResult:");
		[CompilerGenerated]
		const string selFailedWithResult_ = "failedWithResult:";
		static readonly IntPtr selFailedWithResult_Handle = Selector.GetHandle ("failedWithResult:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TaskResult");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TaskResult () : base (NSObjectFlag.Empty)
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
		public TaskResult (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TaskResult (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TaskResult (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("failedWithResult:")]
		[CompilerGenerated]
		public static TaskResult FailedWithResult (Result result)
		{
			if (result == null)
				throw new ArgumentNullException ("result");
			return  Runtime.GetNSObject<TaskResult> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selFailedWithResult_Handle, result.Handle));
		}
		
		[CompilerGenerated]
		object __mt_ErrorsList_var;
		[CompilerGenerated]
		public virtual NSMutableArray ErrorsList {
			[Export ("errorsList", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selErrorsListHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selErrorsListHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ErrorsList_var = ret;
				return ret;
			}
			
			[Export ("setErrorsList:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetErrorsList_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetErrorsList_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ErrorsList_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_FailedResult_var;
		[CompilerGenerated]
		public virtual Result FailedResult {
			[Export ("failedResult", ArgumentSemantic.Retain)]
			get {
				Result ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<Result> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFailedResultHandle));
				} else {
					ret =  Runtime.GetNSObject<Result> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFailedResultHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FailedResult_var = ret;
				return ret;
			}
			
			[Export ("setFailedResult:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFailedResult_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFailedResult_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FailedResult_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ErrorsList_var = null;
				__mt_FailedResult_var = null;
			}
		}
	} /* class TaskResult */
}
