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
	[Register("QBCOMultiDeleteQuery", true)]
	public unsafe partial class QBCOMultiDeleteQuery : NSObject {
		[CompilerGenerated]
		const string selClassName = "className";
		static readonly IntPtr selClassNameHandle = Selector.GetHandle ("className");
		[CompilerGenerated]
		const string selInitWithClassNameObjectsIDs_ = "initWithClassName:objectsIDs:";
		static readonly IntPtr selInitWithClassNameObjectsIDs_Handle = Selector.GetHandle ("initWithClassName:objectsIDs:");
		[CompilerGenerated]
		const string selObjectsIDs = "objectsIDs";
		static readonly IntPtr selObjectsIDsHandle = Selector.GetHandle ("objectsIDs");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCOMultiDeleteQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCOMultiDeleteQuery () : base (NSObjectFlag.Empty)
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
		public QBCOMultiDeleteQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOMultiDeleteQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOMultiDeleteQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithClassName:objectsIDs:")]
		[CompilerGenerated]
		public QBCOMultiDeleteQuery (string className, NSObject[] objectsIDs)
			: base (NSObjectFlag.Empty)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (objectsIDs == null)
				throw new ArgumentNullException ("objectsIDs");
			var nsclassName = NSString.CreateNative (className);
			var nsa_objectsIDs = NSArray.FromNSObjects (objectsIDs);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithClassNameObjectsIDs_Handle, nsclassName, nsa_objectsIDs.Handle), "initWithClassName:objectsIDs:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithClassNameObjectsIDs_Handle, nsclassName, nsa_objectsIDs.Handle), "initWithClassName:objectsIDs:");
			}
			NSString.ReleaseNative (nsclassName);
			nsa_objectsIDs.Dispose ();
			
		}
		
		[CompilerGenerated]
		public virtual string ClassName {
			[Export ("className")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selClassNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selClassNameHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ObjectsIDs_var;
		[CompilerGenerated]
		public virtual NSObject[] ObjectsIDs {
			[Export ("objectsIDs")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selObjectsIDsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selObjectsIDsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ObjectsIDs_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ObjectsIDs_var = null;
			}
		}
	} /* class QBCOMultiDeleteQuery */
}
