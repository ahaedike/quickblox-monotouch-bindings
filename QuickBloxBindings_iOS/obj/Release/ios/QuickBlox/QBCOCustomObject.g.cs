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
	[Register("QBCOCustomObject", true)]
	public unsafe partial class QBCOCustomObject : NSObject {
		[CompilerGenerated]
		const string selClassName = "className";
		static readonly IntPtr selClassNameHandle = Selector.GetHandle ("className");
		[CompilerGenerated]
		const string selCreatedAt = "createdAt";
		static readonly IntPtr selCreatedAtHandle = Selector.GetHandle ("createdAt");
		[CompilerGenerated]
		const string selCustomObject = "customObject";
		static readonly IntPtr selCustomObjectHandle = Selector.GetHandle ("customObject");
		[CompilerGenerated]
		const string selFields = "fields";
		static readonly IntPtr selFieldsHandle = Selector.GetHandle ("fields");
		[CompilerGenerated]
		const string selID = "ID";
		static readonly IntPtr selIDHandle = Selector.GetHandle ("ID");
		[CompilerGenerated]
		const string selParentID = "parentID";
		static readonly IntPtr selParentIDHandle = Selector.GetHandle ("parentID");
		[CompilerGenerated]
		const string selPermissions = "permissions";
		static readonly IntPtr selPermissionsHandle = Selector.GetHandle ("permissions");
		[CompilerGenerated]
		const string selSetClassName_ = "setClassName:";
		static readonly IntPtr selSetClassName_Handle = Selector.GetHandle ("setClassName:");
		[CompilerGenerated]
		const string selSetCreatedAt_ = "setCreatedAt:";
		static readonly IntPtr selSetCreatedAt_Handle = Selector.GetHandle ("setCreatedAt:");
		[CompilerGenerated]
		const string selSetFields_ = "setFields:";
		static readonly IntPtr selSetFields_Handle = Selector.GetHandle ("setFields:");
		[CompilerGenerated]
		const string selSetID_ = "setID:";
		static readonly IntPtr selSetID_Handle = Selector.GetHandle ("setID:");
		[CompilerGenerated]
		const string selSetParentID_ = "setParentID:";
		static readonly IntPtr selSetParentID_Handle = Selector.GetHandle ("setParentID:");
		[CompilerGenerated]
		const string selSetPermissions_ = "setPermissions:";
		static readonly IntPtr selSetPermissions_Handle = Selector.GetHandle ("setPermissions:");
		[CompilerGenerated]
		const string selSetUpdatedAt_ = "setUpdatedAt:";
		static readonly IntPtr selSetUpdatedAt_Handle = Selector.GetHandle ("setUpdatedAt:");
		[CompilerGenerated]
		const string selSetUserID_ = "setUserID:";
		static readonly IntPtr selSetUserID_Handle = Selector.GetHandle ("setUserID:");
		[CompilerGenerated]
		const string selUpdatedAt = "updatedAt";
		static readonly IntPtr selUpdatedAtHandle = Selector.GetHandle ("updatedAt");
		[CompilerGenerated]
		const string selUserID = "userID";
		static readonly IntPtr selUserIDHandle = Selector.GetHandle ("userID");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCOCustomObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCOCustomObject () : base (NSObjectFlag.Empty)
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
		public QBCOCustomObject (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOCustomObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOCustomObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string ClassName {
			[Export ("className", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selClassNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selClassNameHandle));
				}
			}
			
			[Export ("setClassName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetClassName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetClassName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_CreatedAt_var;
		[CompilerGenerated]
		public virtual NSDate CreatedAt {
			[Export ("createdAt", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCreatedAtHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCreatedAtHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CreatedAt_var = ret;
				return ret;
			}
			
			[Export ("setCreatedAt:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCreatedAt_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCreatedAt_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CreatedAt_var = value;
			}
		}
		
		[CompilerGenerated]
		static object __mt_CustomObject_var_static;
		[CompilerGenerated]
		public static QBCOCustomObject CustomObject {
			[Export ("customObject")]
			get {
				QBCOCustomObject ret;
				ret =  Runtime.GetNSObject<QBCOCustomObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selCustomObjectHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_CustomObject_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Fields_var;
		[CompilerGenerated]
		public virtual NSMutableDictionary Fields {
			[Export ("fields", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFieldsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFieldsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Fields_var = ret;
				return ret;
			}
			
			[Export ("setFields:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFields_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFields_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Fields_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string ID {
			[Export ("ID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIDHandle));
				}
			}
			
			[Export ("setID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParentID {
			[Export ("parentID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParentIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParentIDHandle));
				}
			}
			
			[Export ("setParentID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParentID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParentID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Permissions_var;
		[CompilerGenerated]
		public virtual QBCOPermissions Permissions {
			[Export ("permissions", ArgumentSemantic.Retain)]
			get {
				QBCOPermissions ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBCOPermissions> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPermissionsHandle));
				} else {
					ret =  Runtime.GetNSObject<QBCOPermissions> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPermissionsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Permissions_var = ret;
				return ret;
			}
			
			[Export ("setPermissions:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPermissions_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPermissions_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Permissions_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_UpdatedAt_var;
		[CompilerGenerated]
		public virtual NSDate UpdatedAt {
			[Export ("updatedAt", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUpdatedAtHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUpdatedAtHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UpdatedAt_var = ret;
				return ret;
			}
			
			[Export ("setUpdatedAt:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUpdatedAt_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUpdatedAt_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UpdatedAt_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 UserID {
			[Export ("userID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selUserIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selUserIDHandle);
				}
			}
			
			[Export ("setUserID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetUserID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetUserID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CreatedAt_var = null;
				__mt_Fields_var = null;
				__mt_Permissions_var = null;
				__mt_UpdatedAt_var = null;
			}
		}
	} /* class QBCOCustomObject */
}
