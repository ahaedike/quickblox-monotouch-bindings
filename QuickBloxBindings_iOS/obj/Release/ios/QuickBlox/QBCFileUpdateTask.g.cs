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
	[Register("QBCFileUpdateTask", true)]
	public unsafe partial class QBCFileUpdateTask : Task {
		[CompilerGenerated]
		const string selBlob = "blob";
		static readonly IntPtr selBlobHandle = Selector.GetHandle ("blob");
		[CompilerGenerated]
		const string selData = "data";
		static readonly IntPtr selDataHandle = Selector.GetHandle ("data");
		[CompilerGenerated]
		const string selSetBlob_ = "setBlob:";
		static readonly IntPtr selSetBlob_Handle = Selector.GetHandle ("setBlob:");
		[CompilerGenerated]
		const string selSetData_ = "setData:";
		static readonly IntPtr selSetData_Handle = Selector.GetHandle ("setData:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCFileUpdateTask");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCFileUpdateTask () : base (NSObjectFlag.Empty)
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
		public QBCFileUpdateTask (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCFileUpdateTask (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCFileUpdateTask (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_Blob_var;
		[CompilerGenerated]
		public virtual QBCBlob Blob {
			[Export ("blob", ArgumentSemantic.Retain)]
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
			
			[Export ("setBlob:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBlob_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBlob_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Blob_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Data_var;
		[CompilerGenerated]
		public virtual NSData Data {
			[Export ("data", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataHandle));
				} else {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Data_var = ret;
				return ret;
			}
			
			[Export ("setData:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetData_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetData_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Data_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Blob_var = null;
				__mt_Data_var = null;
			}
		}
	} /* class QBCFileUpdateTask */
}
