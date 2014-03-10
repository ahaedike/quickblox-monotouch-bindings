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
	[Register("QBCBlobObjectAccessAnswer", true)]
	public unsafe partial class QBCBlobObjectAccessAnswer : EntityAnswer {
		[CompilerGenerated]
		const string selParamsBuffer = "paramsBuffer";
		static readonly IntPtr selParamsBufferHandle = Selector.GetHandle ("paramsBuffer");
		[CompilerGenerated]
		const string selSetParamsBuffer_ = "setParamsBuffer:";
		static readonly IntPtr selSetParamsBuffer_Handle = Selector.GetHandle ("setParamsBuffer:");
		[CompilerGenerated]
		const string selBlobObjectAccess = "blobObjectAccess";
		static readonly IntPtr selBlobObjectAccessHandle = Selector.GetHandle ("blobObjectAccess");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCBlobObjectAccessAnswer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCBlobObjectAccessAnswer () : base (NSObjectFlag.Empty)
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
		public QBCBlobObjectAccessAnswer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobObjectAccessAnswer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobObjectAccessAnswer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_ParamsBuffer_var;
		[CompilerGenerated]
		public virtual NSMutableString ParamsBuffer {
			[Export ("paramsBuffer", ArgumentSemantic.Retain)]
			get {
				NSMutableString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamsBufferHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamsBufferHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ParamsBuffer_var = ret;
				return ret;
			}
			
			[Export ("setParamsBuffer:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamsBuffer_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamsBuffer_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ParamsBuffer_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_BlobObjectAccess_var;
		[CompilerGenerated]
		public virtual QBCBlobObjectAccess BlobObjectAccess {
			[Export ("blobObjectAccess")]
			get {
				QBCBlobObjectAccess ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBCBlobObjectAccess> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBlobObjectAccessHandle));
				} else {
					ret =  Runtime.GetNSObject<QBCBlobObjectAccess> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBlobObjectAccessHandle));
				}
				MarkDirty ();
				__mt_BlobObjectAccess_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ParamsBuffer_var = null;
				__mt_BlobObjectAccess_var = null;
			}
		}
	} /* class QBCBlobObjectAccessAnswer */
}
