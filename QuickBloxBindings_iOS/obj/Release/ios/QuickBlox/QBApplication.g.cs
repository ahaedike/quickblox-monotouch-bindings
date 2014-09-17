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
	[Register("QBApplication", true)]
	public unsafe partial class QBApplication : NSObject {
		[CompilerGenerated]
		const string selApplicationId = "applicationId";
		static readonly IntPtr selApplicationIdHandle = Selector.GetHandle ("applicationId");
		[CompilerGenerated]
		const string selSetApplicationId_ = "setApplicationId:";
		static readonly IntPtr selSetApplicationId_Handle = Selector.GetHandle ("setApplicationId:");
		[CompilerGenerated]
		const string selSharedApplication = "sharedApplication";
		static readonly IntPtr selSharedApplicationHandle = Selector.GetHandle ("sharedApplication");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBApplication");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBApplication () : base (NSObjectFlag.Empty)
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
		public QBApplication (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBApplication (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBApplication (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::System.UInt32 ApplicationID {
			[Export ("applicationId")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selApplicationIdHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selApplicationIdHandle);
				}
			}
			
			[Export ("setApplicationId:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetApplicationId_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetApplicationId_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		static object __mt_Shared_var_static;
		[CompilerGenerated]
		public static QBApplication Shared {
			[Export ("sharedApplication")]
			get {
				QBApplication ret;
				ret =  Runtime.GetNSObject<QBApplication> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedApplicationHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Shared_var_static = ret;
				return ret;
			}
			
		}
		
	} /* class QBApplication */
}
