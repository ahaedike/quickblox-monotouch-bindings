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
	[Register("QBChatDialogCreateQuery", true)]
	public unsafe partial class QBChatDialogCreateQuery : QBChatQuery {
		[CompilerGenerated]
		const string selDialog = "dialog";
		static readonly IntPtr selDialogHandle = Selector.GetHandle ("dialog");
		[CompilerGenerated]
		const string selInitWithDialog_ = "initWithDialog:";
		static readonly IntPtr selInitWithDialog_Handle = Selector.GetHandle ("initWithDialog:");
		[CompilerGenerated]
		const string selSetDialog_ = "setDialog:";
		static readonly IntPtr selSetDialog_Handle = Selector.GetHandle ("setDialog:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBChatDialogCreateQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBChatDialogCreateQuery () : base (NSObjectFlag.Empty)
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
		public QBChatDialogCreateQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatDialogCreateQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatDialogCreateQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDialog:")]
		[CompilerGenerated]
		public QBChatDialogCreateQuery (QBChatDialog dialog)
			: base (NSObjectFlag.Empty)
		{
			if (dialog == null)
				throw new ArgumentNullException ("dialog");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDialog_Handle, dialog.Handle), "initWithDialog:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDialog_Handle, dialog.Handle), "initWithDialog:");
			}
		}
		
		[CompilerGenerated]
		object __mt_Dialog_var;
		[CompilerGenerated]
		public virtual QBChatDialog Dialog {
			[Export ("dialog", ArgumentSemantic.Retain)]
			get {
				QBChatDialog ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBChatDialog> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDialogHandle));
				} else {
					ret =  Runtime.GetNSObject<QBChatDialog> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDialogHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Dialog_var = ret;
				return ret;
			}
			
			[Export ("setDialog:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDialog_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDialog_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Dialog_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Dialog_var = null;
			}
		}
	} /* class QBChatDialogCreateQuery */
}
