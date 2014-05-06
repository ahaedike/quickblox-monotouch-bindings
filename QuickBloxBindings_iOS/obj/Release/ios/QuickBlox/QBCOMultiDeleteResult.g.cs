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
	[Register("QBCOMultiDeleteResult", true)]
	public unsafe partial class QBCOMultiDeleteResult : Result {
		[CompilerGenerated]
		const string selDeletedObjectsIDs = "deletedObjectsIDs";
		static readonly IntPtr selDeletedObjectsIDsHandle = Selector.GetHandle ("deletedObjectsIDs");
		[CompilerGenerated]
		const string selNotFoundObjectsIDs = "notFoundObjectsIDs";
		static readonly IntPtr selNotFoundObjectsIDsHandle = Selector.GetHandle ("notFoundObjectsIDs");
		[CompilerGenerated]
		const string selWrongPermissionsObjectsIDs = "wrongPermissionsObjectsIDs";
		static readonly IntPtr selWrongPermissionsObjectsIDsHandle = Selector.GetHandle ("wrongPermissionsObjectsIDs");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCOMultiDeleteResult");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCOMultiDeleteResult () : base (NSObjectFlag.Empty)
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
		public QBCOMultiDeleteResult (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOMultiDeleteResult (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOMultiDeleteResult (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_DeletedObjectsIDs_var;
		[CompilerGenerated]
		public virtual NSObject[] DeletedObjectsIDs {
			[Export ("deletedObjectsIDs")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDeletedObjectsIDsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDeletedObjectsIDsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DeletedObjectsIDs_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_NotFoundObjectsIDs_var;
		[CompilerGenerated]
		public virtual NSObject[] NotFoundObjectsIDs {
			[Export ("notFoundObjectsIDs")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNotFoundObjectsIDsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNotFoundObjectsIDsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_NotFoundObjectsIDs_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_WrongPermissionsObjectsIDs_var;
		[CompilerGenerated]
		public virtual NSObject[] WrongPermissionsObjectsIDs {
			[Export ("wrongPermissionsObjectsIDs")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWrongPermissionsObjectsIDsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWrongPermissionsObjectsIDsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_WrongPermissionsObjectsIDs_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DeletedObjectsIDs_var = null;
				__mt_NotFoundObjectsIDs_var = null;
				__mt_WrongPermissionsObjectsIDs_var = null;
			}
		}
	} /* class QBCOMultiDeleteResult */
}
