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
	[Register("QBCOCustomObjectsUpdateQuery", true)]
	public unsafe partial class QBCOCustomObjectsUpdateQuery : NSObject {
		[CompilerGenerated]
		const string selClassName = "className";
		static readonly IntPtr selClassNameHandle = Selector.GetHandle ("className");
		[CompilerGenerated]
		const string selInitWithObjectsClassNameSpecialUpdateOperators_ = "initWithObjects:className:specialUpdateOperators:";
		static readonly IntPtr selInitWithObjectsClassNameSpecialUpdateOperators_Handle = Selector.GetHandle ("initWithObjects:className:specialUpdateOperators:");
		[CompilerGenerated]
		const string selObjects = "objects";
		static readonly IntPtr selObjectsHandle = Selector.GetHandle ("objects");
		[CompilerGenerated]
		const string selSpecialUpdateOperators = "specialUpdateOperators";
		static readonly IntPtr selSpecialUpdateOperatorsHandle = Selector.GetHandle ("specialUpdateOperators");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCOCustomObjectsUpdateQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCOCustomObjectsUpdateQuery () : base (NSObjectFlag.Empty)
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
		public QBCOCustomObjectsUpdateQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOCustomObjectsUpdateQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOCustomObjectsUpdateQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithObjects:className:specialUpdateOperators:")]
		[CompilerGenerated]
		public QBCOCustomObjectsUpdateQuery (NSObject[] objects, string className, NSObject[] specialUpdateOperators)
			: base (NSObjectFlag.Empty)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (className == null)
				throw new ArgumentNullException ("className");
			if (specialUpdateOperators == null)
				throw new ArgumentNullException ("specialUpdateOperators");
			var nsa_objects = NSArray.FromNSObjects (objects);
			var nsclassName = NSString.CreateNative (className);
			var nsa_specialUpdateOperators = NSArray.FromNSObjects (specialUpdateOperators);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithObjectsClassNameSpecialUpdateOperators_Handle, nsa_objects.Handle, nsclassName, nsa_specialUpdateOperators.Handle), "initWithObjects:className:specialUpdateOperators:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithObjectsClassNameSpecialUpdateOperators_Handle, nsa_objects.Handle, nsclassName, nsa_specialUpdateOperators.Handle), "initWithObjects:className:specialUpdateOperators:");
			}
			nsa_objects.Dispose ();
			NSString.ReleaseNative (nsclassName);
			nsa_specialUpdateOperators.Dispose ();
			
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
		object __mt_Objects_var;
		[CompilerGenerated]
		public virtual NSObject[] Objects {
			[Export ("objects")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selObjectsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selObjectsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Objects_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SpecialUpdateOperators_var;
		[CompilerGenerated]
		public virtual NSObject[] SpecialUpdateOperators {
			[Export ("specialUpdateOperators")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSpecialUpdateOperatorsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSpecialUpdateOperatorsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SpecialUpdateOperators_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Objects_var = null;
				__mt_SpecialUpdateOperators_var = null;
			}
		}
	} /* class QBCOCustomObjectsUpdateQuery */
}
