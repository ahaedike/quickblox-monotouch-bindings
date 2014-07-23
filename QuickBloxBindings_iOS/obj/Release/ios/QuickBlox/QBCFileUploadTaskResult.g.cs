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
	[Register("QBCFileUploadTaskResult", true)]
	public unsafe partial class QBCFileUploadTaskResult : TaskResult {
		[CompilerGenerated]
		const string selResultWithBlob_ = "resultWithBlob:";
		static readonly IntPtr selResultWithBlob_Handle = Selector.GetHandle ("resultWithBlob:");
		[CompilerGenerated]
		const string selUploadedBlob = "uploadedBlob";
		static readonly IntPtr selUploadedBlobHandle = Selector.GetHandle ("uploadedBlob");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCFileUploadTaskResult");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCFileUploadTaskResult () : base (NSObjectFlag.Empty)
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
		public QBCFileUploadTaskResult (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCFileUploadTaskResult (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCFileUploadTaskResult (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("resultWithBlob:")]
		[CompilerGenerated]
		public static QBCFileUploadTaskResult ResultWithBlob (QBCBlob uploadedBlob)
		{
			if (uploadedBlob == null)
				throw new ArgumentNullException ("uploadedBlob");
			return  Runtime.GetNSObject<QBCFileUploadTaskResult> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selResultWithBlob_Handle, uploadedBlob.Handle));
		}
		
		[CompilerGenerated]
		object __mt_UploadedBlob_var;
		[CompilerGenerated]
		public virtual QBCBlob UploadedBlob {
			[Export ("uploadedBlob")]
			get {
				QBCBlob ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBCBlob> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUploadedBlobHandle));
				} else {
					ret =  Runtime.GetNSObject<QBCBlob> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUploadedBlobHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UploadedBlob_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_UploadedBlob_var = null;
			}
		}
	} /* class QBCFileUploadTaskResult */
}
