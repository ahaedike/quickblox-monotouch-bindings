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
	[Register("QBCBlobUploadQuery", true)]
	public unsafe partial class QBCBlobUploadQuery : NSObject {
		[CompilerGenerated]
		const string selBlobWithWriteAccess = "blobWithWriteAccess";
		static readonly IntPtr selBlobWithWriteAccessHandle = Selector.GetHandle ("blobWithWriteAccess");
		[CompilerGenerated]
		const string selSetBlobWithWriteAccess_ = "setBlobWithWriteAccess:";
		static readonly IntPtr selSetBlobWithWriteAccess_Handle = Selector.GetHandle ("setBlobWithWriteAccess:");
		[CompilerGenerated]
		const string selFile = "file";
		static readonly IntPtr selFileHandle = Selector.GetHandle ("file");
		[CompilerGenerated]
		const string selSetFile_ = "setFile:";
		static readonly IntPtr selSetFile_Handle = Selector.GetHandle ("setFile:");
		[CompilerGenerated]
		const string selInitWithBlobWithWriteAccessFile_ = "initWithBlobWithWriteAccess:file:";
		static readonly IntPtr selInitWithBlobWithWriteAccessFile_Handle = Selector.GetHandle ("initWithBlobWithWriteAccess:file:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCBlobUploadQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCBlobUploadQuery () : base (NSObjectFlag.Empty)
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
		public QBCBlobUploadQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobUploadQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlobUploadQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithBlobWithWriteAccess:file:")]
		[CompilerGenerated]
		public QBCBlobUploadQuery (QBCBlob blobWithWriteAccess, NSData data)
			: base (NSObjectFlag.Empty)
		{
			if (blobWithWriteAccess == null)
				throw new ArgumentNullException ("blobWithWriteAccess");
			if (data == null)
				throw new ArgumentNullException ("data");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithBlobWithWriteAccessFile_Handle, blobWithWriteAccess.Handle, data.Handle), "initWithBlobWithWriteAccess:file:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithBlobWithWriteAccessFile_Handle, blobWithWriteAccess.Handle, data.Handle), "initWithBlobWithWriteAccess:file:");
			}
		}
		
		[CompilerGenerated]
		object __mt_BlobWithWriteAccess_var;
		[CompilerGenerated]
		public virtual QBCBlob BlobWithWriteAccess {
			[Export ("blobWithWriteAccess", ArgumentSemantic.Retain)]
			get {
				QBCBlob ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBCBlob> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBlobWithWriteAccessHandle));
				} else {
					ret =  Runtime.GetNSObject<QBCBlob> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBlobWithWriteAccessHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BlobWithWriteAccess_var = ret;
				return ret;
			}
			
			[Export ("setBlobWithWriteAccess:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBlobWithWriteAccess_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBlobWithWriteAccess_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BlobWithWriteAccess_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_File_var;
		[CompilerGenerated]
		public virtual NSData File {
			[Export ("file", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileHandle));
				} else {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFileHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_File_var = ret;
				return ret;
			}
			
			[Export ("setFile:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFile_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFile_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_File_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BlobWithWriteAccess_var = null;
				__mt_File_var = null;
			}
		}
	} /* class QBCBlobUploadQuery */
}
