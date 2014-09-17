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
	[Register("QBError", true)]
	public unsafe partial class QBError : NSObject {
		[CompilerGenerated]
		const string selError = "error";
		static readonly IntPtr selErrorHandle = Selector.GetHandle ("error");
		[CompilerGenerated]
		const string selErrorWithError_ = "errorWithError:";
		static readonly IntPtr selErrorWithError_Handle = Selector.GetHandle ("errorWithError:");
		[CompilerGenerated]
		const string selReasons = "reasons";
		static readonly IntPtr selReasonsHandle = Selector.GetHandle ("reasons");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBError");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBError () : base (NSObjectFlag.Empty)
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
		public QBError (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBError (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBError (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("errorWithError:")]
		[CompilerGenerated]
		public static QBError ErrorWithError (NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			return  Runtime.GetNSObject<QBError> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selErrorWithError_Handle, error.Handle));
		}
		
		[CompilerGenerated]
		object __mt_Error_var;
		[CompilerGenerated]
		public virtual NSError Error {
			[Export ("error")]
			get {
				NSError ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selErrorHandle));
				} else {
					ret =  Runtime.GetNSObject<NSError> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selErrorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Error_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Reasons_var;
		[CompilerGenerated]
		public virtual NSDictionary Reasons {
			[Export ("reasons")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selReasonsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selReasonsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Reasons_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Error_var = null;
				__mt_Reasons_var = null;
			}
		}
	} /* class QBError */
}
