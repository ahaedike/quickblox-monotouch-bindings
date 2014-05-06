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
	[Register("QBCOPermissions", true)]
	public unsafe partial class QBCOPermissions : NSObject {
		[CompilerGenerated]
		const string selDeleteAccess = "deleteAccess";
		static readonly IntPtr selDeleteAccessHandle = Selector.GetHandle ("deleteAccess");
		[CompilerGenerated]
		const string selPermissions = "permissions";
		static readonly IntPtr selPermissionsHandle = Selector.GetHandle ("permissions");
		[CompilerGenerated]
		const string selPermissionsAccessFromString_ = "permissionsAccessFromString:";
		static readonly IntPtr selPermissionsAccessFromString_Handle = Selector.GetHandle ("permissionsAccessFromString:");
		[CompilerGenerated]
		const string selPermissionsAccessToString_ = "permissionsAccessToString:";
		static readonly IntPtr selPermissionsAccessToString_Handle = Selector.GetHandle ("permissionsAccessToString:");
		[CompilerGenerated]
		const string selReadAccess = "readAccess";
		static readonly IntPtr selReadAccessHandle = Selector.GetHandle ("readAccess");
		[CompilerGenerated]
		const string selRecordID = "recordID";
		static readonly IntPtr selRecordIDHandle = Selector.GetHandle ("recordID");
		[CompilerGenerated]
		const string selSetDeleteAccess_ = "setDeleteAccess:";
		static readonly IntPtr selSetDeleteAccess_Handle = Selector.GetHandle ("setDeleteAccess:");
		[CompilerGenerated]
		const string selSetReadAccess_ = "setReadAccess:";
		static readonly IntPtr selSetReadAccess_Handle = Selector.GetHandle ("setReadAccess:");
		[CompilerGenerated]
		const string selSetRecordID_ = "setRecordID:";
		static readonly IntPtr selSetRecordID_Handle = Selector.GetHandle ("setRecordID:");
		[CompilerGenerated]
		const string selSetUpdateAccess_ = "setUpdateAccess:";
		static readonly IntPtr selSetUpdateAccess_Handle = Selector.GetHandle ("setUpdateAccess:");
		[CompilerGenerated]
		const string selSetUsersGroupsForDeleteAccess_ = "setUsersGroupsForDeleteAccess:";
		static readonly IntPtr selSetUsersGroupsForDeleteAccess_Handle = Selector.GetHandle ("setUsersGroupsForDeleteAccess:");
		[CompilerGenerated]
		const string selSetUsersGroupsForReadAccess_ = "setUsersGroupsForReadAccess:";
		static readonly IntPtr selSetUsersGroupsForReadAccess_Handle = Selector.GetHandle ("setUsersGroupsForReadAccess:");
		[CompilerGenerated]
		const string selSetUsersGroupsForUpdateAccess_ = "setUsersGroupsForUpdateAccess:";
		static readonly IntPtr selSetUsersGroupsForUpdateAccess_Handle = Selector.GetHandle ("setUsersGroupsForUpdateAccess:");
		[CompilerGenerated]
		const string selSetUsersIDsForDeleteAccess_ = "setUsersIDsForDeleteAccess:";
		static readonly IntPtr selSetUsersIDsForDeleteAccess_Handle = Selector.GetHandle ("setUsersIDsForDeleteAccess:");
		[CompilerGenerated]
		const string selSetUsersIDsForReadAccess_ = "setUsersIDsForReadAccess:";
		static readonly IntPtr selSetUsersIDsForReadAccess_Handle = Selector.GetHandle ("setUsersIDsForReadAccess:");
		[CompilerGenerated]
		const string selSetUsersIDsForUpdateAccess_ = "setUsersIDsForUpdateAccess:";
		static readonly IntPtr selSetUsersIDsForUpdateAccess_Handle = Selector.GetHandle ("setUsersIDsForUpdateAccess:");
		[CompilerGenerated]
		const string selUpdateAccess = "updateAccess";
		static readonly IntPtr selUpdateAccessHandle = Selector.GetHandle ("updateAccess");
		[CompilerGenerated]
		const string selUsersGroupsForDeleteAccess = "usersGroupsForDeleteAccess";
		static readonly IntPtr selUsersGroupsForDeleteAccessHandle = Selector.GetHandle ("usersGroupsForDeleteAccess");
		[CompilerGenerated]
		const string selUsersGroupsForReadAccess = "usersGroupsForReadAccess";
		static readonly IntPtr selUsersGroupsForReadAccessHandle = Selector.GetHandle ("usersGroupsForReadAccess");
		[CompilerGenerated]
		const string selUsersGroupsForUpdateAccess = "usersGroupsForUpdateAccess";
		static readonly IntPtr selUsersGroupsForUpdateAccessHandle = Selector.GetHandle ("usersGroupsForUpdateAccess");
		[CompilerGenerated]
		const string selUsersIDsForDeleteAccess = "usersIDsForDeleteAccess";
		static readonly IntPtr selUsersIDsForDeleteAccessHandle = Selector.GetHandle ("usersIDsForDeleteAccess");
		[CompilerGenerated]
		const string selUsersIDsForReadAccess = "usersIDsForReadAccess";
		static readonly IntPtr selUsersIDsForReadAccessHandle = Selector.GetHandle ("usersIDsForReadAccess");
		[CompilerGenerated]
		const string selUsersIDsForUpdateAccess = "usersIDsForUpdateAccess";
		static readonly IntPtr selUsersIDsForUpdateAccessHandle = Selector.GetHandle ("usersIDsForUpdateAccess");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCOPermissions");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCOPermissions () : base (NSObjectFlag.Empty)
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
		public QBCOPermissions (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOPermissions (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOPermissions (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("permissions")]
		[CompilerGenerated]
		public static QBCOPermissions Permissions ()
		{
			return  Runtime.GetNSObject<QBCOPermissions> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selPermissionsHandle));
		}
		
		[Export ("permissionsAccessFromString:")]
		[CompilerGenerated]
		public static QBCOPermissionsAccess PermissionsAccessFromString (string permissionsAccess)
		{
			if (permissionsAccess == null)
				throw new ArgumentNullException ("permissionsAccess");
			var nspermissionsAccess = NSString.CreateNative (permissionsAccess);
			
			QBCOPermissionsAccess ret;
			ret = (QBCOPermissionsAccess) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (class_ptr, selPermissionsAccessFromString_Handle, nspermissionsAccess);
			NSString.ReleaseNative (nspermissionsAccess);
			
			return ret;
		}
		
		[Export ("permissionsAccessToString:")]
		[CompilerGenerated]
		public static string PermissionsAccessToString (QBCOPermissionsAccess permissionsAccess)
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (class_ptr, selPermissionsAccessToString_Handle, (int)permissionsAccess));
		}
		
		[CompilerGenerated]
		public virtual QBCOPermissionsAccess DeleteAccess {
			[Export ("deleteAccess")]
			get {
				if (IsDirectBinding) {
					return (QBCOPermissionsAccess) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selDeleteAccessHandle);
				} else {
					return (QBCOPermissionsAccess) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selDeleteAccessHandle);
				}
			}
			
			[Export ("setDeleteAccess:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetDeleteAccess_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetDeleteAccess_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual QBCOPermissionsAccess ReadAccess {
			[Export ("readAccess")]
			get {
				if (IsDirectBinding) {
					return (QBCOPermissionsAccess) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selReadAccessHandle);
				} else {
					return (QBCOPermissionsAccess) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selReadAccessHandle);
				}
			}
			
			[Export ("setReadAccess:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetReadAccess_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetReadAccess_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string RecordID {
			[Export ("recordID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRecordIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRecordIDHandle));
				}
			}
			
			[Export ("setRecordID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRecordID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRecordID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual QBCOPermissionsAccess UpdateAccess {
			[Export ("updateAccess")]
			get {
				if (IsDirectBinding) {
					return (QBCOPermissionsAccess) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selUpdateAccessHandle);
				} else {
					return (QBCOPermissionsAccess) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selUpdateAccessHandle);
				}
			}
			
			[Export ("setUpdateAccess:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetUpdateAccess_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetUpdateAccess_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_UsersGroupsForDeleteAccess_var;
		[CompilerGenerated]
		public virtual NSMutableArray UsersGroupsForDeleteAccess {
			[Export ("usersGroupsForDeleteAccess", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersGroupsForDeleteAccessHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersGroupsForDeleteAccessHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersGroupsForDeleteAccess_var = ret;
				return ret;
			}
			
			[Export ("setUsersGroupsForDeleteAccess:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersGroupsForDeleteAccess_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersGroupsForDeleteAccess_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersGroupsForDeleteAccess_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_UsersGroupsForReadAccess_var;
		[CompilerGenerated]
		public virtual NSMutableArray UsersGroupsForReadAccess {
			[Export ("usersGroupsForReadAccess", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersGroupsForReadAccessHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersGroupsForReadAccessHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersGroupsForReadAccess_var = ret;
				return ret;
			}
			
			[Export ("setUsersGroupsForReadAccess:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersGroupsForReadAccess_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersGroupsForReadAccess_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersGroupsForReadAccess_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_UsersGroupsForUpdateAccess_var;
		[CompilerGenerated]
		public virtual NSMutableArray UsersGroupsForUpdateAccess {
			[Export ("usersGroupsForUpdateAccess", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersGroupsForUpdateAccessHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersGroupsForUpdateAccessHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersGroupsForUpdateAccess_var = ret;
				return ret;
			}
			
			[Export ("setUsersGroupsForUpdateAccess:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersGroupsForUpdateAccess_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersGroupsForUpdateAccess_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersGroupsForUpdateAccess_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_UsersIDsForDeleteAccess_var;
		[CompilerGenerated]
		public virtual NSMutableArray UsersIDsForDeleteAccess {
			[Export ("usersIDsForDeleteAccess", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersIDsForDeleteAccessHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersIDsForDeleteAccessHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersIDsForDeleteAccess_var = ret;
				return ret;
			}
			
			[Export ("setUsersIDsForDeleteAccess:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersIDsForDeleteAccess_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersIDsForDeleteAccess_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersIDsForDeleteAccess_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_UsersIDsForReadAccess_var;
		[CompilerGenerated]
		public virtual NSMutableArray UsersIDsForReadAccess {
			[Export ("usersIDsForReadAccess", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersIDsForReadAccessHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersIDsForReadAccessHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersIDsForReadAccess_var = ret;
				return ret;
			}
			
			[Export ("setUsersIDsForReadAccess:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersIDsForReadAccess_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersIDsForReadAccess_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersIDsForReadAccess_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_UsersIDsForUpdateAccess_var;
		[CompilerGenerated]
		public virtual NSMutableArray UsersIDsForUpdateAccess {
			[Export ("usersIDsForUpdateAccess", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersIDsForUpdateAccessHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersIDsForUpdateAccessHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersIDsForUpdateAccess_var = ret;
				return ret;
			}
			
			[Export ("setUsersIDsForUpdateAccess:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersIDsForUpdateAccess_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersIDsForUpdateAccess_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UsersIDsForUpdateAccess_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_UsersGroupsForDeleteAccess_var = null;
				__mt_UsersGroupsForReadAccess_var = null;
				__mt_UsersGroupsForUpdateAccess_var = null;
				__mt_UsersIDsForDeleteAccess_var = null;
				__mt_UsersIDsForReadAccess_var = null;
				__mt_UsersIDsForUpdateAccess_var = null;
			}
		}
	} /* class QBCOPermissions */
}
