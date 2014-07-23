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
	[Register("QBCBlobAnswer", true)]
	public unsafe partial class QBCBlobAnswer : EntityAnswer {
		[CompilerGenerated]
		const string selBlob = "blob";
		static readonly IntPtr selBlobHandle = Selector.GetHandle ("blob");
		[CompilerGenerated]
		const string selBlobObjectAccessAnswer = "blobObjectAccessAnswer";
		static readonly IntPtr selBlobObjectAccessAnswerHandle = Selector.GetHandle ("blobObjectAccessAnswer");
		[CompilerGenerated]
		const string selSetBlobObjectAccessAnswer_ = "setBlobObjectAccessAnswer:";
		static readonly IntPtr selSetBlobObjectAccessAnswer_Handle = Selector.GetHandle ("setBlobObjectAccessAnswer:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCBlobAnswer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCBlobAnswer () : base (NSObjectFlag.Empty)
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
		public QBCBlobAnswer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobAnswer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobAnswer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_Blob_var;
		[CompilerGenerated]
		public virtual QBCBlob Blob {
			[Export ("blob")]
			get {
				QBCBlob ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBCBlob> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBlobHandle));
				} else {
					ret =  Runtime.GetNSObject<QBCBlob> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBlobHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Blob_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BlobObjectAccessAnswer_var;
		[CompilerGenerated]
		public virtual QBCBlobObjectAccessAnswer BlobObjectAccessAnswer {
			[Export ("blobObjectAccessAnswer", ArgumentSemantic.Retain)]
			get {
				QBCBlobObjectAccessAnswer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBCBlobObjectAccessAnswer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBlobObjectAccessAnswerHandle));
				} else {
					ret =  Runtime.GetNSObject<QBCBlobObjectAccessAnswer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBlobObjectAccessAnswerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BlobObjectAccessAnswer_var = ret;
				return ret;
			}
			
			[Export ("setBlobObjectAccessAnswer:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBlobObjectAccessAnswer_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBlobObjectAccessAnswer_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BlobObjectAccessAnswer_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Blob_var = null;
				__mt_BlobObjectAccessAnswer_var = null;
			}
		}
	} /* class QBCBlobAnswer */
}
