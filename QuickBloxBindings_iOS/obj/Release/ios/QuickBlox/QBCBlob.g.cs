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
	[Register("QBCBlob", true)]
	public unsafe partial class QBCBlob : Entity {
		[CompilerGenerated]
		const string selBlob = "blob";
		static readonly IntPtr selBlobHandle = Selector.GetHandle ("blob");
		[CompilerGenerated]
		const string selBlobObjectAccess = "blobObjectAccess";
		static readonly IntPtr selBlobObjectAccessHandle = Selector.GetHandle ("blobObjectAccess");
		[CompilerGenerated]
		const string selCompletedAt = "completedAt";
		static readonly IntPtr selCompletedAtHandle = Selector.GetHandle ("completedAt");
		[CompilerGenerated]
		const string selContentType = "contentType";
		static readonly IntPtr selContentTypeHandle = Selector.GetHandle ("contentType");
		[CompilerGenerated]
		const string selIsNew = "isNew";
		static readonly IntPtr selIsNewHandle = Selector.GetHandle ("isNew");
		[CompilerGenerated]
		const string selIsPublic = "isPublic";
		static readonly IntPtr selIsPublicHandle = Selector.GetHandle ("isPublic");
		[CompilerGenerated]
		const string selLastReadAccessTs = "lastReadAccessTs";
		static readonly IntPtr selLastReadAccessTsHandle = Selector.GetHandle ("lastReadAccessTs");
		[CompilerGenerated]
		const string selLifetime = "lifetime";
		static readonly IntPtr selLifetimeHandle = Selector.GetHandle ("lifetime");
		[CompilerGenerated]
		const string selName = "name";
		static readonly IntPtr selNameHandle = Selector.GetHandle ("name");
		[CompilerGenerated]
		const string selPublicUrl = "publicUrl";
		static readonly IntPtr selPublicUrlHandle = Selector.GetHandle ("publicUrl");
		[CompilerGenerated]
		const string selRefCount = "refCount";
		static readonly IntPtr selRefCountHandle = Selector.GetHandle ("refCount");
		[CompilerGenerated]
		const string selSetBlobObjectAccess_ = "setBlobObjectAccess:";
		static readonly IntPtr selSetBlobObjectAccess_Handle = Selector.GetHandle ("setBlobObjectAccess:");
		[CompilerGenerated]
		const string selSetCompletedAt_ = "setCompletedAt:";
		static readonly IntPtr selSetCompletedAt_Handle = Selector.GetHandle ("setCompletedAt:");
		[CompilerGenerated]
		const string selSetContentType_ = "setContentType:";
		static readonly IntPtr selSetContentType_Handle = Selector.GetHandle ("setContentType:");
		[CompilerGenerated]
		const string selSetIsNew_ = "setIsNew:";
		static readonly IntPtr selSetIsNew_Handle = Selector.GetHandle ("setIsNew:");
		[CompilerGenerated]
		const string selSetIsPublic_ = "setIsPublic:";
		static readonly IntPtr selSetIsPublic_Handle = Selector.GetHandle ("setIsPublic:");
		[CompilerGenerated]
		const string selSetLastReadAccessTs_ = "setLastReadAccessTs:";
		static readonly IntPtr selSetLastReadAccessTs_Handle = Selector.GetHandle ("setLastReadAccessTs:");
		[CompilerGenerated]
		const string selSetLifetime_ = "setLifetime:";
		static readonly IntPtr selSetLifetime_Handle = Selector.GetHandle ("setLifetime:");
		[CompilerGenerated]
		const string selSetName_ = "setName:";
		static readonly IntPtr selSetName_Handle = Selector.GetHandle ("setName:");
		[CompilerGenerated]
		const string selSetRefCount_ = "setRefCount:";
		static readonly IntPtr selSetRefCount_Handle = Selector.GetHandle ("setRefCount:");
		[CompilerGenerated]
		const string selSetSize_ = "setSize:";
		static readonly IntPtr selSetSize_Handle = Selector.GetHandle ("setSize:");
		[CompilerGenerated]
		const string selSetStatus_ = "setStatus:";
		static readonly IntPtr selSetStatus_Handle = Selector.GetHandle ("setStatus:");
		[CompilerGenerated]
		const string selSetTags_ = "setTags:";
		static readonly IntPtr selSetTags_Handle = Selector.GetHandle ("setTags:");
		[CompilerGenerated]
		const string selSetUID_ = "setUID:";
		static readonly IntPtr selSetUID_Handle = Selector.GetHandle ("setUID:");
		[CompilerGenerated]
		const string selSize = "size";
		static readonly IntPtr selSizeHandle = Selector.GetHandle ("size");
		[CompilerGenerated]
		const string selStatus = "status";
		static readonly IntPtr selStatusHandle = Selector.GetHandle ("status");
		[CompilerGenerated]
		const string selTags = "tags";
		static readonly IntPtr selTagsHandle = Selector.GetHandle ("tags");
		[CompilerGenerated]
		const string selUID = "UID";
		static readonly IntPtr selUIDHandle = Selector.GetHandle ("UID");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCBlob");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCBlob () : base (NSObjectFlag.Empty)
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
		public QBCBlob (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlob (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCBlob (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		static object __mt_Blob_var_static;
		[CompilerGenerated]
		public static QBCBlob Blob {
			[Export ("blob")]
			get {
				QBCBlob ret;
				ret =  Runtime.GetNSObject<QBCBlob> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selBlobHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Blob_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BlobObjectAccess_var;
		[CompilerGenerated]
		public virtual QBCBlobObjectAccess BlobObjectAccess {
			[Export ("blobObjectAccess", ArgumentSemantic.Retain)]
			get {
				QBCBlobObjectAccess ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBCBlobObjectAccess> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBlobObjectAccessHandle));
				} else {
					ret =  Runtime.GetNSObject<QBCBlobObjectAccess> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBlobObjectAccessHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BlobObjectAccess_var = ret;
				return ret;
			}
			
			[Export ("setBlobObjectAccess:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBlobObjectAccess_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBlobObjectAccess_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BlobObjectAccess_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_CompletedAt_var;
		[CompilerGenerated]
		public virtual NSDate CompletedAt {
			[Export ("completedAt", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCompletedAtHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCompletedAtHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CompletedAt_var = ret;
				return ret;
			}
			
			[Export ("setCompletedAt:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCompletedAt_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCompletedAt_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CompletedAt_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string ContentType {
			[Export ("contentType", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentTypeHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContentTypeHandle));
				}
			}
			
			[Export ("setContentType:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetContentType_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetContentType_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsNew {
			[Export ("isNew")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsNewHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsNewHandle);
				}
			}
			
			[Export ("setIsNew:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsNew_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsNew_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsPublic {
			[Export ("isPublic")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPublicHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsPublicHandle);
				}
			}
			
			[Export ("setIsPublic:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsPublic_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsPublic_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_LastReadAccessTs_var;
		[CompilerGenerated]
		public virtual NSDate LastReadAccessTs {
			[Export ("lastReadAccessTs", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLastReadAccessTsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLastReadAccessTsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LastReadAccessTs_var = ret;
				return ret;
			}
			
			[Export ("setLastReadAccessTs:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLastReadAccessTs_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLastReadAccessTs_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LastReadAccessTs_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Lifetime {
			[Export ("lifetime")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selLifetimeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selLifetimeHandle);
				}
			}
			
			[Export ("setLifetime:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetLifetime_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetLifetime_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNameHandle));
				}
			}
			
			[Export ("setName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string PublicUrl {
			[Export ("publicUrl")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPublicUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPublicUrlHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 RefCount {
			[Export ("refCount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selRefCountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selRefCountHandle);
				}
			}
			
			[Export ("setRefCount:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetRefCount_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetRefCount_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Size {
			[Export ("size")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selSizeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selSizeHandle);
				}
			}
			
			[Export ("setSize:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetSize_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetSize_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual QBCBlobStatus Status {
			[Export ("status")]
			get {
				if (IsDirectBinding) {
					return (QBCBlobStatus) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStatusHandle);
				} else {
					return (QBCBlobStatus) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selStatusHandle);
				}
			}
			
			[Export ("setStatus:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetStatus_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetStatus_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Tags {
			[Export ("tags", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTagsHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTagsHandle));
				}
			}
			
			[Export ("setTags:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTags_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTags_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UID {
			[Export ("UID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUIDHandle));
				}
			}
			
			[Export ("setUID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BlobObjectAccess_var = null;
				__mt_CompletedAt_var = null;
				__mt_LastReadAccessTs_var = null;
			}
		}
	} /* class QBCBlob */
}
