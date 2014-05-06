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
	[Register("QBCustomObjects", true)]
	public unsafe partial class QBCustomObjects : QBBaseModule {
		[CompilerGenerated]
		const string selCreateObjectDelegate_ = "createObject:delegate:";
		static readonly IntPtr selCreateObjectDelegate_Handle = Selector.GetHandle ("createObject:delegate:");
		[CompilerGenerated]
		const string selCreateObjectDelegateContext_ = "createObject:delegate:context:";
		static readonly IntPtr selCreateObjectDelegateContext_Handle = Selector.GetHandle ("createObject:delegate:context:");
		[CompilerGenerated]
		const string selCreateObjectsClassNameDelegate_ = "createObjects:className:delegate:";
		static readonly IntPtr selCreateObjectsClassNameDelegate_Handle = Selector.GetHandle ("createObjects:className:delegate:");
		[CompilerGenerated]
		const string selCreateObjectsClassNameDelegateContext_ = "createObjects:className:delegate:context:";
		static readonly IntPtr selCreateObjectsClassNameDelegateContext_Handle = Selector.GetHandle ("createObjects:className:delegate:context:");
		[CompilerGenerated]
		const string selDeleteFileFromClassNameObjectIDFileFieldNameDelegate_ = "deleteFileFromClassName:objectID:fileFieldName:delegate:";
		static readonly IntPtr selDeleteFileFromClassNameObjectIDFileFieldNameDelegate_Handle = Selector.GetHandle ("deleteFileFromClassName:objectID:fileFieldName:delegate:");
		[CompilerGenerated]
		const string selDeleteFileFromClassNameObjectIDFileFieldNameDelegateContext_ = "deleteFileFromClassName:objectID:fileFieldName:delegate:context:";
		static readonly IntPtr selDeleteFileFromClassNameObjectIDFileFieldNameDelegateContext_Handle = Selector.GetHandle ("deleteFileFromClassName:objectID:fileFieldName:delegate:context:");
		[CompilerGenerated]
		const string selDeleteObjectsWithIDsClassNameDelegate_ = "deleteObjectsWithIDs:className:delegate:";
		static readonly IntPtr selDeleteObjectsWithIDsClassNameDelegate_Handle = Selector.GetHandle ("deleteObjectsWithIDs:className:delegate:");
		[CompilerGenerated]
		const string selDeleteObjectsWithIDsClassNameDelegateContext_ = "deleteObjectsWithIDs:className:delegate:context:";
		static readonly IntPtr selDeleteObjectsWithIDsClassNameDelegateContext_Handle = Selector.GetHandle ("deleteObjectsWithIDs:className:delegate:context:");
		[CompilerGenerated]
		const string selDeleteObjectWithIDClassNameDelegate_ = "deleteObjectWithID:className:delegate:";
		static readonly IntPtr selDeleteObjectWithIDClassNameDelegate_Handle = Selector.GetHandle ("deleteObjectWithID:className:delegate:");
		[CompilerGenerated]
		const string selDeleteObjectWithIDClassNameDelegateContext_ = "deleteObjectWithID:className:delegate:context:";
		static readonly IntPtr selDeleteObjectWithIDClassNameDelegateContext_Handle = Selector.GetHandle ("deleteObjectWithID:className:delegate:context:");
		[CompilerGenerated]
		const string selDownloadFileFromClassNameObjectIDFileFieldNameDelegate_ = "downloadFileFromClassName:objectID:fileFieldName:delegate:";
		static readonly IntPtr selDownloadFileFromClassNameObjectIDFileFieldNameDelegate_Handle = Selector.GetHandle ("downloadFileFromClassName:objectID:fileFieldName:delegate:");
		[CompilerGenerated]
		const string selDownloadFileFromClassNameObjectIDFileFieldNameDelegateContext_ = "downloadFileFromClassName:objectID:fileFieldName:delegate:context:";
		static readonly IntPtr selDownloadFileFromClassNameObjectIDFileFieldNameDelegateContext_Handle = Selector.GetHandle ("downloadFileFromClassName:objectID:fileFieldName:delegate:context:");
		[CompilerGenerated]
		const string selObjectsWithClassNameDelegate_ = "objectsWithClassName:delegate:";
		static readonly IntPtr selObjectsWithClassNameDelegate_Handle = Selector.GetHandle ("objectsWithClassName:delegate:");
		[CompilerGenerated]
		const string selObjectsWithClassNameDelegateContext_ = "objectsWithClassName:delegate:context:";
		static readonly IntPtr selObjectsWithClassNameDelegateContext_Handle = Selector.GetHandle ("objectsWithClassName:delegate:context:");
		[CompilerGenerated]
		const string selObjectsWithClassNameExtendedRequestDelegate_ = "objectsWithClassName:extendedRequest:delegate:";
		static readonly IntPtr selObjectsWithClassNameExtendedRequestDelegate_Handle = Selector.GetHandle ("objectsWithClassName:extendedRequest:delegate:");
		[CompilerGenerated]
		const string selObjectsWithClassNameExtendedRequestDelegateContext_ = "objectsWithClassName:extendedRequest:delegate:context:";
		static readonly IntPtr selObjectsWithClassNameExtendedRequestDelegateContext_Handle = Selector.GetHandle ("objectsWithClassName:extendedRequest:delegate:context:");
		[CompilerGenerated]
		const string selObjectsWithClassNameIDsDelegate_ = "objectsWithClassName:IDs:delegate:";
		static readonly IntPtr selObjectsWithClassNameIDsDelegate_Handle = Selector.GetHandle ("objectsWithClassName:IDs:delegate:");
		[CompilerGenerated]
		const string selObjectsWithClassNameIDsDelegateContext_ = "objectsWithClassName:IDs:delegate:context:";
		static readonly IntPtr selObjectsWithClassNameIDsDelegateContext_Handle = Selector.GetHandle ("objectsWithClassName:IDs:delegate:context:");
		[CompilerGenerated]
		const string selObjectWithClassNameIDDelegate_ = "objectWithClassName:ID:delegate:";
		static readonly IntPtr selObjectWithClassNameIDDelegate_Handle = Selector.GetHandle ("objectWithClassName:ID:delegate:");
		[CompilerGenerated]
		const string selObjectWithClassNameIDDelegateContext_ = "objectWithClassName:ID:delegate:context:";
		static readonly IntPtr selObjectWithClassNameIDDelegateContext_Handle = Selector.GetHandle ("objectWithClassName:ID:delegate:context:");
		[CompilerGenerated]
		const string selPermissionsForObjectWithClassNameIDDelegate_ = "permissionsForObjectWithClassName:ID:delegate:";
		static readonly IntPtr selPermissionsForObjectWithClassNameIDDelegate_Handle = Selector.GetHandle ("permissionsForObjectWithClassName:ID:delegate:");
		[CompilerGenerated]
		const string selPermissionsForObjectWithClassNameIDDelegateContext_ = "permissionsForObjectWithClassName:ID:delegate:context:";
		static readonly IntPtr selPermissionsForObjectWithClassNameIDDelegateContext_Handle = Selector.GetHandle ("permissionsForObjectWithClassName:ID:delegate:context:");
		[CompilerGenerated]
		const string selUpdateObjectDelegate_ = "updateObject:delegate:";
		static readonly IntPtr selUpdateObjectDelegate_Handle = Selector.GetHandle ("updateObject:delegate:");
		[CompilerGenerated]
		const string selUpdateObjectDelegateContext_ = "updateObject:delegate:context:";
		static readonly IntPtr selUpdateObjectDelegateContext_Handle = Selector.GetHandle ("updateObject:delegate:context:");
		[CompilerGenerated]
		const string selUpdateObjectSpecialUpdateOperatorsDelegate_ = "updateObject:specialUpdateOperators:delegate:";
		static readonly IntPtr selUpdateObjectSpecialUpdateOperatorsDelegate_Handle = Selector.GetHandle ("updateObject:specialUpdateOperators:delegate:");
		[CompilerGenerated]
		const string selUpdateObjectSpecialUpdateOperatorsDelegateContext_ = "updateObject:specialUpdateOperators:delegate:context:";
		static readonly IntPtr selUpdateObjectSpecialUpdateOperatorsDelegateContext_Handle = Selector.GetHandle ("updateObject:specialUpdateOperators:delegate:context:");
		[CompilerGenerated]
		const string selUpdateObjectsClassNameDelegate_ = "updateObjects:className:delegate:";
		static readonly IntPtr selUpdateObjectsClassNameDelegate_Handle = Selector.GetHandle ("updateObjects:className:delegate:");
		[CompilerGenerated]
		const string selUpdateObjectsClassNameDelegateContext_ = "updateObjects:className:delegate:context:";
		static readonly IntPtr selUpdateObjectsClassNameDelegateContext_Handle = Selector.GetHandle ("updateObjects:className:delegate:context:");
		[CompilerGenerated]
		const string selUploadFileClassNameObjectIDFileFieldNameDelegate_ = "uploadFile:className:objectID:fileFieldName:delegate:";
		static readonly IntPtr selUploadFileClassNameObjectIDFileFieldNameDelegate_Handle = Selector.GetHandle ("uploadFile:className:objectID:fileFieldName:delegate:");
		[CompilerGenerated]
		const string selUploadFileClassNameObjectIDFileFieldNameDelegateContext_ = "uploadFile:className:objectID:fileFieldName:delegate:context:";
		static readonly IntPtr selUploadFileClassNameObjectIDFileFieldNameDelegateContext_Handle = Selector.GetHandle ("uploadFile:className:objectID:fileFieldName:delegate:context:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCustomObjects");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCustomObjects () : base (NSObjectFlag.Empty)
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
		public QBCustomObjects (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCustomObjects (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCustomObjects (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("createObject:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateObject (QBCOCustomObject obj, NSObject del)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateObjectDelegate_Handle, obj.Handle, del.Handle));
		}
		
		[Export ("createObject:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateObject (QBCOCustomObject obj, NSObject del, NSObject context)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateObjectDelegateContext_Handle, obj.Handle, del.Handle, context.Handle));
		}
		
		[Export ("createObjects:className:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateObjects (NSObject[] objects, string className, NSObject del)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (className == null)
				throw new ArgumentNullException ("className");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsa_objects = NSArray.FromNSObjects (objects);
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateObjectsClassNameDelegate_Handle, nsa_objects.Handle, nsclassName, del.Handle));
			nsa_objects.Dispose ();
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("createObjects:className:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateObjects (NSObject[] objects, string className, NSObject del, NSObject context)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (className == null)
				throw new ArgumentNullException ("className");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_objects = NSArray.FromNSObjects (objects);
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selCreateObjectsClassNameDelegateContext_Handle, nsa_objects.Handle, nsclassName, del.Handle, context.Handle));
			nsa_objects.Dispose ();
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("deleteFileFromClassName:objectID:fileFieldName:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteFileFromClassName (string className, string objectID, string fileFieldName, NSObject del)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (objectID == null)
				throw new ArgumentNullException ("objectID");
			if (fileFieldName == null)
				throw new ArgumentNullException ("fileFieldName");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsclassName = NSString.CreateNative (className);
			var nsobjectID = NSString.CreateNative (objectID);
			var nsfileFieldName = NSString.CreateNative (fileFieldName);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selDeleteFileFromClassNameObjectIDFileFieldNameDelegate_Handle, nsclassName, nsobjectID, nsfileFieldName, del.Handle));
			NSString.ReleaseNative (nsclassName);
			NSString.ReleaseNative (nsobjectID);
			NSString.ReleaseNative (nsfileFieldName);
			
			return ret;
		}
		
		[Export ("deleteFileFromClassName:objectID:fileFieldName:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteFileFromClassName (string className, string objectID, string fileFieldName, NSObject del, NSObject context)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (objectID == null)
				throw new ArgumentNullException ("objectID");
			if (fileFieldName == null)
				throw new ArgumentNullException ("fileFieldName");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsclassName = NSString.CreateNative (className);
			var nsobjectID = NSString.CreateNative (objectID);
			var nsfileFieldName = NSString.CreateNative (fileFieldName);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selDeleteFileFromClassNameObjectIDFileFieldNameDelegateContext_Handle, nsclassName, nsobjectID, nsfileFieldName, del.Handle, context.Handle));
			NSString.ReleaseNative (nsclassName);
			NSString.ReleaseNative (nsobjectID);
			NSString.ReleaseNative (nsfileFieldName);
			
			return ret;
		}
		
		[Export ("deleteObjectsWithIDs:className:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteObjectsWithIDs (NSObject[] objectsIDs, string className, NSObject del)
		{
			if (objectsIDs == null)
				throw new ArgumentNullException ("objectsIDs");
			if (className == null)
				throw new ArgumentNullException ("className");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsa_objectsIDs = NSArray.FromNSObjects (objectsIDs);
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selDeleteObjectsWithIDsClassNameDelegate_Handle, nsa_objectsIDs.Handle, nsclassName, del.Handle));
			nsa_objectsIDs.Dispose ();
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("deleteObjectsWithIDs:className:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteObjectsWithIDs (NSObject[] objectsIDs, string className, NSObject del, NSObject context)
		{
			if (objectsIDs == null)
				throw new ArgumentNullException ("objectsIDs");
			if (className == null)
				throw new ArgumentNullException ("className");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_objectsIDs = NSArray.FromNSObjects (objectsIDs);
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selDeleteObjectsWithIDsClassNameDelegateContext_Handle, nsa_objectsIDs.Handle, nsclassName, del.Handle, context.Handle));
			nsa_objectsIDs.Dispose ();
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("deleteObjectWithID:className:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteObjectWithID (string objectID, string className, NSObject del)
		{
			if (objectID == null)
				throw new ArgumentNullException ("objectID");
			if (className == null)
				throw new ArgumentNullException ("className");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsobjectID = NSString.CreateNative (objectID);
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selDeleteObjectWithIDClassNameDelegate_Handle, nsobjectID, nsclassName, del.Handle));
			NSString.ReleaseNative (nsobjectID);
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("deleteObjectWithID:className:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteObjectWithID (string objectID, string className, NSObject del, NSObject context)
		{
			if (objectID == null)
				throw new ArgumentNullException ("objectID");
			if (className == null)
				throw new ArgumentNullException ("className");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsobjectID = NSString.CreateNative (objectID);
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selDeleteObjectWithIDClassNameDelegateContext_Handle, nsobjectID, nsclassName, del.Handle, context.Handle));
			NSString.ReleaseNative (nsobjectID);
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("downloadFileFromClassName:objectID:fileFieldName:delegate:")]
		[CompilerGenerated]
		public static NSObject DownloadFileFromClassName (string className, string objectID, string fileFieldName, NSObject del)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (objectID == null)
				throw new ArgumentNullException ("objectID");
			if (fileFieldName == null)
				throw new ArgumentNullException ("fileFieldName");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsclassName = NSString.CreateNative (className);
			var nsobjectID = NSString.CreateNative (objectID);
			var nsfileFieldName = NSString.CreateNative (fileFieldName);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selDownloadFileFromClassNameObjectIDFileFieldNameDelegate_Handle, nsclassName, nsobjectID, nsfileFieldName, del.Handle));
			NSString.ReleaseNative (nsclassName);
			NSString.ReleaseNative (nsobjectID);
			NSString.ReleaseNative (nsfileFieldName);
			
			return ret;
		}
		
		[Export ("downloadFileFromClassName:objectID:fileFieldName:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DownloadFileFromClassName (string className, string objectID, string fileFieldName, NSObject del, NSObject context)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (objectID == null)
				throw new ArgumentNullException ("objectID");
			if (fileFieldName == null)
				throw new ArgumentNullException ("fileFieldName");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsclassName = NSString.CreateNative (className);
			var nsobjectID = NSString.CreateNative (objectID);
			var nsfileFieldName = NSString.CreateNative (fileFieldName);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selDownloadFileFromClassNameObjectIDFileFieldNameDelegateContext_Handle, nsclassName, nsobjectID, nsfileFieldName, del.Handle, context.Handle));
			NSString.ReleaseNative (nsclassName);
			NSString.ReleaseNative (nsobjectID);
			NSString.ReleaseNative (nsfileFieldName);
			
			return ret;
		}
		
		[Export ("objectsWithClassName:IDs:delegate:")]
		[CompilerGenerated]
		public static NSObject ObjectsWithClassName (string className, NSObject[] IDs, NSObject del)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (IDs == null)
				throw new ArgumentNullException ("IDs");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsclassName = NSString.CreateNative (className);
			var nsa_IDs = NSArray.FromNSObjects (IDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selObjectsWithClassNameIDsDelegate_Handle, nsclassName, nsa_IDs.Handle, del.Handle));
			NSString.ReleaseNative (nsclassName);
			nsa_IDs.Dispose ();
			
			return ret;
		}
		
		[Export ("objectsWithClassName:IDs:delegate:context:")]
		[CompilerGenerated]
		public static NSObject ObjectsWithClassName (string className, NSObject[] IDs, NSObject del, NSObject context)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (IDs == null)
				throw new ArgumentNullException ("IDs");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsclassName = NSString.CreateNative (className);
			var nsa_IDs = NSArray.FromNSObjects (IDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selObjectsWithClassNameIDsDelegateContext_Handle, nsclassName, nsa_IDs.Handle, del.Handle, context.Handle));
			NSString.ReleaseNative (nsclassName);
			nsa_IDs.Dispose ();
			
			return ret;
		}
		
		[Export ("objectsWithClassName:delegate:")]
		[CompilerGenerated]
		public static NSObject ObjectsWithClassName (string className, NSObject del)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selObjectsWithClassNameDelegate_Handle, nsclassName, del.Handle));
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("objectsWithClassName:delegate:context:")]
		[CompilerGenerated]
		public static NSObject ObjectsWithClassName (string className, NSObject del, NSObject context)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selObjectsWithClassNameDelegateContext_Handle, nsclassName, del.Handle, context.Handle));
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("objectsWithClassName:extendedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject ObjectsWithClassName (string className, NSMutableDictionary extendedRequest, NSObject del)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selObjectsWithClassNameExtendedRequestDelegate_Handle, nsclassName, extendedRequest.Handle, del.Handle));
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("objectsWithClassName:extendedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject ObjectsWithClassName (string className, NSMutableDictionary extendedRequest, NSObject del, NSObject context)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selObjectsWithClassNameExtendedRequestDelegateContext_Handle, nsclassName, extendedRequest.Handle, del.Handle, context.Handle));
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("objectWithClassName:ID:delegate:")]
		[CompilerGenerated]
		public static NSObject ObjectWithClassName (string className, string ID, NSObject del)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (ID == null)
				throw new ArgumentNullException ("ID");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsclassName = NSString.CreateNative (className);
			var nsID = NSString.CreateNative (ID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selObjectWithClassNameIDDelegate_Handle, nsclassName, nsID, del.Handle));
			NSString.ReleaseNative (nsclassName);
			NSString.ReleaseNative (nsID);
			
			return ret;
		}
		
		[Export ("objectWithClassName:ID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject ObjectWithClassName (string className, string ID, NSObject del, NSObject context)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (ID == null)
				throw new ArgumentNullException ("ID");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsclassName = NSString.CreateNative (className);
			var nsID = NSString.CreateNative (ID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selObjectWithClassNameIDDelegateContext_Handle, nsclassName, nsID, del.Handle, context.Handle));
			NSString.ReleaseNative (nsclassName);
			NSString.ReleaseNative (nsID);
			
			return ret;
		}
		
		[Export ("permissionsForObjectWithClassName:ID:delegate:")]
		[CompilerGenerated]
		public static NSObject PermissionsForObjectWithClassName (string className, string ID, NSObject del)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (ID == null)
				throw new ArgumentNullException ("ID");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsclassName = NSString.CreateNative (className);
			var nsID = NSString.CreateNative (ID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selPermissionsForObjectWithClassNameIDDelegate_Handle, nsclassName, nsID, del.Handle));
			NSString.ReleaseNative (nsclassName);
			NSString.ReleaseNative (nsID);
			
			return ret;
		}
		
		[Export ("permissionsForObjectWithClassName:ID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject PermissionsForObjectWithClassName (string className, string ID, NSObject del, NSObject context)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (ID == null)
				throw new ArgumentNullException ("ID");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsclassName = NSString.CreateNative (className);
			var nsID = NSString.CreateNative (ID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selPermissionsForObjectWithClassNameIDDelegateContext_Handle, nsclassName, nsID, del.Handle, context.Handle));
			NSString.ReleaseNative (nsclassName);
			NSString.ReleaseNative (nsID);
			
			return ret;
		}
		
		[Export ("updateObject:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateObject (QBCOCustomObject obj, NSObject del)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdateObjectDelegate_Handle, obj.Handle, del.Handle));
		}
		
		[Export ("updateObject:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateObject (QBCOCustomObject obj, NSObject del, NSObject context)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateObjectDelegateContext_Handle, obj.Handle, del.Handle, context.Handle));
		}
		
		[Export ("updateObject:specialUpdateOperators:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateObject (QBCOCustomObject obj, NSMutableDictionary specialUpdateOperators, NSObject del)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (specialUpdateOperators == null)
				throw new ArgumentNullException ("specialUpdateOperators");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateObjectSpecialUpdateOperatorsDelegate_Handle, obj.Handle, specialUpdateOperators.Handle, del.Handle));
		}
		
		[Export ("updateObject:specialUpdateOperators:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateObject (QBCOCustomObject obj, NSMutableDictionary specialUpdateOperators, NSObject del, NSObject context)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (specialUpdateOperators == null)
				throw new ArgumentNullException ("specialUpdateOperators");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateObjectSpecialUpdateOperatorsDelegateContext_Handle, obj.Handle, specialUpdateOperators.Handle, del.Handle, context.Handle));
		}
		
		[Export ("updateObjects:className:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateObjects (NSObject[] objects, string className, NSObject del)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (className == null)
				throw new ArgumentNullException ("className");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsa_objects = NSArray.FromNSObjects (objects);
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateObjectsClassNameDelegate_Handle, nsa_objects.Handle, nsclassName, del.Handle));
			nsa_objects.Dispose ();
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("updateObjects:className:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateObjects (NSObject[] objects, string className, NSObject del, NSObject context)
		{
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (className == null)
				throw new ArgumentNullException ("className");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_objects = NSArray.FromNSObjects (objects);
			var nsclassName = NSString.CreateNative (className);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateObjectsClassNameDelegateContext_Handle, nsa_objects.Handle, nsclassName, del.Handle, context.Handle));
			nsa_objects.Dispose ();
			NSString.ReleaseNative (nsclassName);
			
			return ret;
		}
		
		[Export ("uploadFile:className:objectID:fileFieldName:delegate:")]
		[CompilerGenerated]
		public static NSObject UploadFile (QBCOFile file, string className, string objectID, string fileFieldName, NSObject del)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			if (className == null)
				throw new ArgumentNullException ("className");
			if (objectID == null)
				throw new ArgumentNullException ("objectID");
			if (fileFieldName == null)
				throw new ArgumentNullException ("fileFieldName");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsclassName = NSString.CreateNative (className);
			var nsobjectID = NSString.CreateNative (objectID);
			var nsfileFieldName = NSString.CreateNative (fileFieldName);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUploadFileClassNameObjectIDFileFieldNameDelegate_Handle, file.Handle, nsclassName, nsobjectID, nsfileFieldName, del.Handle));
			NSString.ReleaseNative (nsclassName);
			NSString.ReleaseNative (nsobjectID);
			NSString.ReleaseNative (nsfileFieldName);
			
			return ret;
		}
		
		[Export ("uploadFile:className:objectID:fileFieldName:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UploadFile (QBCOFile file, string className, string objectID, string fileFieldName, NSObject del, NSObject context)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			if (className == null)
				throw new ArgumentNullException ("className");
			if (objectID == null)
				throw new ArgumentNullException ("objectID");
			if (fileFieldName == null)
				throw new ArgumentNullException ("fileFieldName");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsclassName = NSString.CreateNative (className);
			var nsobjectID = NSString.CreateNative (objectID);
			var nsfileFieldName = NSString.CreateNative (fileFieldName);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUploadFileClassNameObjectIDFileFieldNameDelegateContext_Handle, file.Handle, nsclassName, nsobjectID, nsfileFieldName, del.Handle, context.Handle));
			NSString.ReleaseNative (nsclassName);
			NSString.ReleaseNative (nsobjectID);
			NSString.ReleaseNative (nsfileFieldName);
			
			return ret;
		}
		
	} /* class QBCustomObjects */
}
