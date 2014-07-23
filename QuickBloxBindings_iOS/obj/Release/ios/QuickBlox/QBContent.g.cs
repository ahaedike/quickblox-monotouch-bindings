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
	[Register("QBContent", true)]
	public unsafe partial class QBContent : QBBaseModule {
		[CompilerGenerated]
		const string selBlobObjectAccessWithBlobIDDelegate_ = "blobObjectAccessWithBlobID:delegate:";
		static readonly IntPtr selBlobObjectAccessWithBlobIDDelegate_Handle = Selector.GetHandle ("blobObjectAccessWithBlobID:delegate:");
		[CompilerGenerated]
		const string selBlobObjectAccessWithBlobIDDelegateContext_ = "blobObjectAccessWithBlobID:delegate:context:";
		static readonly IntPtr selBlobObjectAccessWithBlobIDDelegateContext_Handle = Selector.GetHandle ("blobObjectAccessWithBlobID:delegate:context:");
		[CompilerGenerated]
		const string selBlobsWithDelegate_ = "blobsWithDelegate:";
		static readonly IntPtr selBlobsWithDelegate_Handle = Selector.GetHandle ("blobsWithDelegate:");
		[CompilerGenerated]
		const string selBlobsWithDelegateContext_ = "blobsWithDelegate:context:";
		static readonly IntPtr selBlobsWithDelegateContext_Handle = Selector.GetHandle ("blobsWithDelegate:context:");
		[CompilerGenerated]
		const string selBlobsWithPagedRequestDelegate_ = "blobsWithPagedRequest:delegate:";
		static readonly IntPtr selBlobsWithPagedRequestDelegate_Handle = Selector.GetHandle ("blobsWithPagedRequest:delegate:");
		[CompilerGenerated]
		const string selBlobsWithPagedRequestDelegateContext_ = "blobsWithPagedRequest:delegate:context:";
		static readonly IntPtr selBlobsWithPagedRequestDelegateContext_Handle = Selector.GetHandle ("blobsWithPagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selBlobWithIDDelegate_ = "blobWithID:delegate:";
		static readonly IntPtr selBlobWithIDDelegate_Handle = Selector.GetHandle ("blobWithID:delegate:");
		[CompilerGenerated]
		const string selBlobWithIDDelegateContext_ = "blobWithID:delegate:context:";
		static readonly IntPtr selBlobWithIDDelegateContext_Handle = Selector.GetHandle ("blobWithID:delegate:context:");
		[CompilerGenerated]
		const string selCompleteBlobWithIDSizeDelegate_ = "completeBlobWithID:size:delegate:";
		static readonly IntPtr selCompleteBlobWithIDSizeDelegate_Handle = Selector.GetHandle ("completeBlobWithID:size:delegate:");
		[CompilerGenerated]
		const string selCompleteBlobWithIDSizeDelegateContext_ = "completeBlobWithID:size:delegate:context:";
		static readonly IntPtr selCompleteBlobWithIDSizeDelegateContext_Handle = Selector.GetHandle ("completeBlobWithID:size:delegate:context:");
		[CompilerGenerated]
		const string selCreateBlobDelegate_ = "createBlob:delegate:";
		static readonly IntPtr selCreateBlobDelegate_Handle = Selector.GetHandle ("createBlob:delegate:");
		[CompilerGenerated]
		const string selCreateBlobDelegateContext_ = "createBlob:delegate:context:";
		static readonly IntPtr selCreateBlobDelegateContext_Handle = Selector.GetHandle ("createBlob:delegate:context:");
		[CompilerGenerated]
		const string selDeleteBlobWithIDDelegate_ = "deleteBlobWithID:delegate:";
		static readonly IntPtr selDeleteBlobWithIDDelegate_Handle = Selector.GetHandle ("deleteBlobWithID:delegate:");
		[CompilerGenerated]
		const string selDeleteBlobWithIDDelegateContext_ = "deleteBlobWithID:delegate:context:";
		static readonly IntPtr selDeleteBlobWithIDDelegateContext_Handle = Selector.GetHandle ("deleteBlobWithID:delegate:context:");
		[CompilerGenerated]
		const string selDownloadFileWithUIDDelegate_ = "downloadFileWithUID:delegate:";
		static readonly IntPtr selDownloadFileWithUIDDelegate_Handle = Selector.GetHandle ("downloadFileWithUID:delegate:");
		[CompilerGenerated]
		const string selDownloadFileWithUIDDelegateContext_ = "downloadFileWithUID:delegate:context:";
		static readonly IntPtr selDownloadFileWithUIDDelegateContext_Handle = Selector.GetHandle ("downloadFileWithUID:delegate:context:");
		[CompilerGenerated]
		const string selRetainBlobWithIDDelegate_ = "retainBlobWithID:delegate:";
		static readonly IntPtr selRetainBlobWithIDDelegate_Handle = Selector.GetHandle ("retainBlobWithID:delegate:");
		[CompilerGenerated]
		const string selRetainBlobWithIDDelegateContext_ = "retainBlobWithID:delegate:context:";
		static readonly IntPtr selRetainBlobWithIDDelegateContext_Handle = Selector.GetHandle ("retainBlobWithID:delegate:context:");
		[CompilerGenerated]
		const string selTaggedBlobsWithDelegate_ = "taggedBlobsWithDelegate:";
		static readonly IntPtr selTaggedBlobsWithDelegate_Handle = Selector.GetHandle ("taggedBlobsWithDelegate:");
		[CompilerGenerated]
		const string selTaggedBlobsWithDelegateContext_ = "taggedBlobsWithDelegate:context:";
		static readonly IntPtr selTaggedBlobsWithDelegateContext_Handle = Selector.GetHandle ("taggedBlobsWithDelegate:context:");
		[CompilerGenerated]
		const string selTaggedBlobsWithPagedRequestDelegate_ = "taggedBlobsWithPagedRequest:delegate:";
		static readonly IntPtr selTaggedBlobsWithPagedRequestDelegate_Handle = Selector.GetHandle ("taggedBlobsWithPagedRequest:delegate:");
		[CompilerGenerated]
		const string selTaggedBlobsWithPagedRequestDelegateContext_ = "taggedBlobsWithPagedRequest:delegate:context:";
		static readonly IntPtr selTaggedBlobsWithPagedRequestDelegateContext_Handle = Selector.GetHandle ("taggedBlobsWithPagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selTDownloadFileWithBlobIDDelegate_ = "TDownloadFileWithBlobID:delegate:";
		static readonly IntPtr selTDownloadFileWithBlobIDDelegate_Handle = Selector.GetHandle ("TDownloadFileWithBlobID:delegate:");
		[CompilerGenerated]
		const string selTDownloadFileWithBlobIDDelegateContext_ = "TDownloadFileWithBlobID:delegate:context:";
		static readonly IntPtr selTDownloadFileWithBlobIDDelegateContext_Handle = Selector.GetHandle ("TDownloadFileWithBlobID:delegate:context:");
		[CompilerGenerated]
		const string selTUpdateFileWithDataFileDelegate_ = "TUpdateFileWithData:file:delegate:";
		static readonly IntPtr selTUpdateFileWithDataFileDelegate_Handle = Selector.GetHandle ("TUpdateFileWithData:file:delegate:");
		[CompilerGenerated]
		const string selTUpdateFileWithDataFileDelegateContext_ = "TUpdateFileWithData:file:delegate:context:";
		static readonly IntPtr selTUpdateFileWithDataFileDelegateContext_Handle = Selector.GetHandle ("TUpdateFileWithData:file:delegate:context:");
		[CompilerGenerated]
		const string selTUploadFileFileNameContentTypeIsPublicDelegate_ = "TUploadFile:fileName:contentType:isPublic:delegate:";
		static readonly IntPtr selTUploadFileFileNameContentTypeIsPublicDelegate_Handle = Selector.GetHandle ("TUploadFile:fileName:contentType:isPublic:delegate:");
		[CompilerGenerated]
		const string selTUploadFileFileNameContentTypeIsPublicDelegateContext_ = "TUploadFile:fileName:contentType:isPublic:delegate:context:";
		static readonly IntPtr selTUploadFileFileNameContentTypeIsPublicDelegateContext_Handle = Selector.GetHandle ("TUploadFile:fileName:contentType:isPublic:delegate:context:");
		[CompilerGenerated]
		const string selUpdateBlobDelegate_ = "updateBlob:delegate:";
		static readonly IntPtr selUpdateBlobDelegate_Handle = Selector.GetHandle ("updateBlob:delegate:");
		[CompilerGenerated]
		const string selUpdateBlobDelegateContext_ = "updateBlob:delegate:context:";
		static readonly IntPtr selUpdateBlobDelegateContext_Handle = Selector.GetHandle ("updateBlob:delegate:context:");
		[CompilerGenerated]
		const string selUploadFileBlobWithWriteAccessDelegate_ = "uploadFile:blobWithWriteAccess:delegate:";
		static readonly IntPtr selUploadFileBlobWithWriteAccessDelegate_Handle = Selector.GetHandle ("uploadFile:blobWithWriteAccess:delegate:");
		[CompilerGenerated]
		const string selUploadFileBlobWithWriteAccessDelegateContext_ = "uploadFile:blobWithWriteAccess:delegate:context:";
		static readonly IntPtr selUploadFileBlobWithWriteAccessDelegateContext_Handle = Selector.GetHandle ("uploadFile:blobWithWriteAccess:delegate:context:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBContent");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBContent () : base (NSObjectFlag.Empty)
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
		public QBContent (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBContent (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBContent (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("blobObjectAccessWithBlobID:delegate:")]
		[CompilerGenerated]
		public static NSObject BlobObjectAccessWithBlobID (global::System.UInt32 blobID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selBlobObjectAccessWithBlobIDDelegate_Handle, blobID, _delegate.Handle));
		}
		
		[Export ("blobObjectAccessWithBlobID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject BlobObjectAccessWithBlobID (global::System.UInt32 blobID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selBlobObjectAccessWithBlobIDDelegateContext_Handle, blobID, _delegate.Handle, context.Handle));
		}
		
		[Export ("blobsWithDelegate:")]
		[CompilerGenerated]
		public static NSObject BlobsWithDelegate (NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selBlobsWithDelegate_Handle, _delegate.Handle));
		}
		
		[Export ("blobsWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject BlobsWithDelegate (NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selBlobsWithDelegateContext_Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("blobsWithPagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject BlobsWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selBlobsWithPagedRequestDelegate_Handle, pagedRequest.Handle, _delegate.Handle));
		}
		
		[Export ("blobsWithPagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject BlobsWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selBlobsWithPagedRequestDelegateContext_Handle, pagedRequest.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("blobWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject BlobWithID (global::System.UInt32 blobID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selBlobWithIDDelegate_Handle, blobID, _delegate.Handle));
		}
		
		[Export ("blobWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject BlobWithID (global::System.UInt32 blobID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selBlobWithIDDelegateContext_Handle, blobID, _delegate.Handle, context.Handle));
		}
		
		[Export ("completeBlobWithID:size:delegate:")]
		[CompilerGenerated]
		public static NSObject CompleteBlobWithID (global::System.UInt32 blobID, global::System.UInt32 size, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_UInt32_IntPtr (class_ptr, selCompleteBlobWithIDSizeDelegate_Handle, blobID, size, _delegate.Handle));
		}
		
		[Export ("completeBlobWithID:size:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CompleteBlobWithID (global::System.UInt32 blobID, global::System.UInt32 size, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_UInt32_IntPtr_IntPtr (class_ptr, selCompleteBlobWithIDSizeDelegateContext_Handle, blobID, size, _delegate.Handle, context.Handle));
		}
		
		[Export ("createBlob:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateBlob (QBCBlob blob, NSObject _delegate)
		{
			if (blob == null)
				throw new ArgumentNullException ("blob");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateBlobDelegate_Handle, blob.Handle, _delegate.Handle));
		}
		
		[Export ("createBlob:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateBlob (QBCBlob blob, NSObject _delegate, NSObject context)
		{
			if (blob == null)
				throw new ArgumentNullException ("blob");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateBlobDelegateContext_Handle, blob.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("deleteBlobWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteBlobWithID (global::System.UInt32 blobID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeleteBlobWithIDDelegate_Handle, blobID, _delegate.Handle));
		}
		
		[Export ("deleteBlobWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteBlobWithID (global::System.UInt32 blobID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeleteBlobWithIDDelegateContext_Handle, blobID, _delegate.Handle, context.Handle));
		}
		
		[Export ("downloadFileWithUID:delegate:")]
		[CompilerGenerated]
		public static NSObject DownloadFileWithUID (string UID, NSObject _delegate)
		{
			if (UID == null)
				throw new ArgumentNullException ("UID");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsUID = NSString.CreateNative (UID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selDownloadFileWithUIDDelegate_Handle, nsUID, _delegate.Handle));
			NSString.ReleaseNative (nsUID);
			
			return ret;
		}
		
		[Export ("downloadFileWithUID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DownloadFileWithUID (string UID, NSObject _delegate, NSObject context)
		{
			if (UID == null)
				throw new ArgumentNullException ("UID");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsUID = NSString.CreateNative (UID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selDownloadFileWithUIDDelegateContext_Handle, nsUID, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsUID);
			
			return ret;
		}
		
		[Export ("retainBlobWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject RetainBlobWithID (global::System.UInt32 blobID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selRetainBlobWithIDDelegate_Handle, blobID, _delegate.Handle));
		}
		
		[Export ("retainBlobWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject RetainBlobWithID (global::System.UInt32 blobID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selRetainBlobWithIDDelegateContext_Handle, blobID, _delegate.Handle, context.Handle));
		}
		
		[Export ("taggedBlobsWithDelegate:")]
		[CompilerGenerated]
		public static NSObject TaggedBlobsWithDelegate (NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selTaggedBlobsWithDelegate_Handle, _delegate.Handle));
		}
		
		[Export ("taggedBlobsWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject TaggedBlobsWithDelegate (NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selTaggedBlobsWithDelegateContext_Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("taggedBlobsWithPagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject TaggedBlobsWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selTaggedBlobsWithPagedRequestDelegate_Handle, pagedRequest.Handle, _delegate.Handle));
		}
		
		[Export ("taggedBlobsWithPagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TaggedBlobsWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selTaggedBlobsWithPagedRequestDelegateContext_Handle, pagedRequest.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("TDownloadFileWithBlobID:delegate:")]
		[CompilerGenerated]
		public static NSObject TDownloadFileWithBlobID (global::System.UInt32 blobID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selTDownloadFileWithBlobIDDelegate_Handle, blobID, _delegate.Handle));
		}
		
		[Export ("TDownloadFileWithBlobID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TDownloadFileWithBlobID (global::System.UInt32 blobID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selTDownloadFileWithBlobIDDelegateContext_Handle, blobID, _delegate.Handle, context.Handle));
		}
		
		[Export ("TUpdateFileWithData:file:delegate:")]
		[CompilerGenerated]
		public static NSObject TUpdateFileWithData (NSData data, QBCBlob file, NSObject _delegate)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (file == null)
				throw new ArgumentNullException ("file");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selTUpdateFileWithDataFileDelegate_Handle, data.Handle, file.Handle, _delegate.Handle));
		}
		
		[Export ("TUpdateFileWithData:file:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TUpdateFileWithData (NSData data, QBCBlob file, NSObject _delegate, NSObject context)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (file == null)
				throw new ArgumentNullException ("file");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selTUpdateFileWithDataFileDelegateContext_Handle, data.Handle, file.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("TUploadFile:fileName:contentType:isPublic:delegate:")]
		[CompilerGenerated]
		public static NSObject TUploadFile (NSData data, string fileName, string contentType, bool isPublic, NSObject _delegate)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			if (contentType == null)
				throw new ArgumentNullException ("contentType");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsfileName = NSString.CreateNative (fileName);
			var nscontentType = NSString.CreateNative (contentType);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr (class_ptr, selTUploadFileFileNameContentTypeIsPublicDelegate_Handle, data.Handle, nsfileName, nscontentType, isPublic, _delegate.Handle));
			NSString.ReleaseNative (nsfileName);
			NSString.ReleaseNative (nscontentType);
			
			return ret;
		}
		
		[Export ("TUploadFile:fileName:contentType:isPublic:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TUploadFile (NSData data, string fileName, string contentType, bool isPublic, NSObject _delegate, NSObject context)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			if (contentType == null)
				throw new ArgumentNullException ("contentType");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsfileName = NSString.CreateNative (fileName);
			var nscontentType = NSString.CreateNative (contentType);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr_IntPtr (class_ptr, selTUploadFileFileNameContentTypeIsPublicDelegateContext_Handle, data.Handle, nsfileName, nscontentType, isPublic, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsfileName);
			NSString.ReleaseNative (nscontentType);
			
			return ret;
		}
		
		[Export ("updateBlob:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateBlob (QBCBlob blob, NSObject _delegate)
		{
			if (blob == null)
				throw new ArgumentNullException ("blob");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdateBlobDelegate_Handle, blob.Handle, _delegate.Handle));
		}
		
		[Export ("updateBlob:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateBlob (QBCBlob blob, NSObject _delegate, NSObject context)
		{
			if (blob == null)
				throw new ArgumentNullException ("blob");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateBlobDelegateContext_Handle, blob.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("uploadFile:blobWithWriteAccess:delegate:")]
		[CompilerGenerated]
		public static NSObject UploadFile (NSData data, QBCBlob blobWithWriteAccess, NSObject _delegate)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (blobWithWriteAccess == null)
				throw new ArgumentNullException ("blobWithWriteAccess");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUploadFileBlobWithWriteAccessDelegate_Handle, data.Handle, blobWithWriteAccess.Handle, _delegate.Handle));
		}
		
		[Export ("uploadFile:blobWithWriteAccess:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UploadFile (NSData data, QBCBlob blobWithWriteAccess, NSObject _delegate, NSObject context)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (blobWithWriteAccess == null)
				throw new ArgumentNullException ("blobWithWriteAccess");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUploadFileBlobWithWriteAccessDelegateContext_Handle, data.Handle, blobWithWriteAccess.Handle, _delegate.Handle, context.Handle));
		}
		
	} /* class QBContent */
}
