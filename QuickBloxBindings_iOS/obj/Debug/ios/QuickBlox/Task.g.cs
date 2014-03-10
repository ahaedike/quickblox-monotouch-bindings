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
	[Register("Task", true)]
	public unsafe partial class Task : Performer {
		[CompilerGenerated]
		const string selItemsCount = "itemsCount";
		static readonly IntPtr selItemsCountHandle = Selector.GetHandle ("itemsCount");
		[CompilerGenerated]
		const string selSetItemsCount_ = "setItemsCount:";
		static readonly IntPtr selSetItemsCount_Handle = Selector.GetHandle ("setItemsCount:");
		[CompilerGenerated]
		const string selCurrentItem = "currentItem";
		static readonly IntPtr selCurrentItemHandle = Selector.GetHandle ("currentItem");
		[CompilerGenerated]
		const string selSetCurrentItem_ = "setCurrentItem:";
		static readonly IntPtr selSetCurrentItem_Handle = Selector.GetHandle ("setCurrentItem:");
		[CompilerGenerated]
		const string selSetProgress_ = "setProgress:";
		static readonly IntPtr selSetProgress_Handle = Selector.GetHandle ("setProgress:");
		[CompilerGenerated]
		const string selSetUploadProgress_ = "setUploadProgress:";
		static readonly IntPtr selSetUploadProgress_Handle = Selector.GetHandle ("setUploadProgress:");
		[CompilerGenerated]
		const string selCompletedWithResult_ = "completedWithResult:";
		static readonly IntPtr selCompletedWithResult_Handle = Selector.GetHandle ("completedWithResult:");
		[CompilerGenerated]
		const string selCompletedWithResultContext_ = "completedWithResult:context:";
		static readonly IntPtr selCompletedWithResultContext_Handle = Selector.GetHandle ("completedWithResult:context:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Task");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Task () : base (NSObjectFlag.Empty)
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
		public Task (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Task (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Task (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("completedWithResult:")]
		[CompilerGenerated]
		public virtual void CompletedWithResult (Result result)
		{
			if (result == null)
				throw new ArgumentNullException ("result");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCompletedWithResult_Handle, result.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selCompletedWithResult_Handle, result.Handle);
			}
		}
		
		[Export ("completedWithResult:context:")]
		[CompilerGenerated]
		public virtual void Context (Result result, NSObject contextInfo)
		{
			if (result == null)
				throw new ArgumentNullException ("result");
			if (contextInfo == null)
				throw new ArgumentNullException ("contextInfo");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selCompletedWithResultContext_Handle, result.Handle, contextInfo.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selCompletedWithResultContext_Handle, result.Handle, contextInfo.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 ItemsCount {
			[Export ("itemsCount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selItemsCountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selItemsCountHandle);
				}
			}
			
			[Export ("setItemsCount:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetItemsCount_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetItemsCount_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 CurrentItem {
			[Export ("currentItem")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selCurrentItemHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selCurrentItemHandle);
				}
			}
			
			[Export ("setCurrentItem:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetCurrentItem_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetCurrentItem_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float Progress {
			[Export ("setProgress:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetProgress_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetProgress_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float UploadActionProgress {
			[Export ("setUploadProgress:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetUploadProgress_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetUploadProgress_Handle, value);
				}
			}
		}
		
	} /* class Task */
}
