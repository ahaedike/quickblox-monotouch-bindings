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
	[Register("QBDialogsPagedResult", true)]
	public unsafe partial class QBDialogsPagedResult : Result {
		[CompilerGenerated]
		const string selDialogs = "dialogs";
		static readonly IntPtr selDialogsHandle = Selector.GetHandle ("dialogs");
		[CompilerGenerated]
		const string selDialogsUsersIDs = "dialogsUsersIDs";
		static readonly IntPtr selDialogsUsersIDsHandle = Selector.GetHandle ("dialogsUsersIDs");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBDialogsPagedResult");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBDialogsPagedResult () : base (NSObjectFlag.Empty)
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
		public QBDialogsPagedResult (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBDialogsPagedResult (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBDialogsPagedResult (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_Dialogs_var;
		[CompilerGenerated]
		public virtual NSObject[] Dialogs {
			[Export ("dialogs")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDialogsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDialogsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Dialogs_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DialogsUsersIDs_var;
		[CompilerGenerated]
		public virtual NSSet DialogsUsersIDs {
			[Export ("dialogsUsersIDs")]
			get {
				NSSet ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDialogsUsersIDsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSSet> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDialogsUsersIDsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DialogsUsersIDs_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Dialogs_var = null;
				__mt_DialogsUsersIDs_var = null;
			}
		}
	} /* class QBDialogsPagedResult */
}
