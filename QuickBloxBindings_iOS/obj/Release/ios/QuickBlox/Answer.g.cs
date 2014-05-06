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
	[Register("Answer", true)]
	public unsafe partial class Answer : NSObject {
		[CompilerGenerated]
		const string selAllocResult = "allocResult";
		static readonly IntPtr selAllocResultHandle = Selector.GetHandle ("allocResult");
		[CompilerGenerated]
		const string selErrors = "errors";
		static readonly IntPtr selErrorsHandle = Selector.GetHandle ("errors");
		[CompilerGenerated]
		const string selQuery = "query";
		static readonly IntPtr selQueryHandle = Selector.GetHandle ("query");
		[CompilerGenerated]
		const string selSetErrors_ = "setErrors:";
		static readonly IntPtr selSetErrors_Handle = Selector.GetHandle ("setErrors:");
		[CompilerGenerated]
		const string selSetQuery_ = "setQuery:";
		static readonly IntPtr selSetQuery_Handle = Selector.GetHandle ("setQuery:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Answer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Answer () : base (NSObjectFlag.Empty)
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
		public Answer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Answer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Answer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("allocResult")]
		[CompilerGenerated]
		public virtual Result AllocResult ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<Result> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAllocResultHandle));
			} else {
				return  Runtime.GetNSObject<Result> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAllocResultHandle));
			}
		}
		
		[CompilerGenerated]
		object __mt_Errors_var;
		[CompilerGenerated]
		public virtual NSMutableArray Errors {
			[Export ("errors", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selErrorsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selErrorsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Errors_var = ret;
				return ret;
			}
			
			[Export ("setErrors:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetErrors_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetErrors_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Errors_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Query_var;
		[CompilerGenerated]
		public virtual QBQuery Query {
			[Export ("query", ArgumentSemantic.UnsafeUnretained)]
			get {
				QBQuery ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBQuery> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selQueryHandle));
				} else {
					ret =  Runtime.GetNSObject<QBQuery> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selQueryHandle));
				}
				MarkDirty ();
				__mt_Query_var = ret;
				return ret;
			}
			
			[Export ("setQuery:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetQuery_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetQuery_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Query_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Errors_var = null;
				__mt_Query_var = null;
			}
		}
	} /* class Answer */
}
