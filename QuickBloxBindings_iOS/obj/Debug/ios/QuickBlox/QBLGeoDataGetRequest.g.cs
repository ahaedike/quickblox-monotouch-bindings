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
	[Register("QBLGeoDataGetRequest", true)]
	public unsafe partial class QBLGeoDataGetRequest : PagedRequest {
		[CompilerGenerated]
		const string selCreatedAt = "createdAt";
		static readonly IntPtr selCreatedAtHandle = Selector.GetHandle ("createdAt");
		[CompilerGenerated]
		const string selSetCreatedAt_ = "setCreatedAt:";
		static readonly IntPtr selSetCreatedAt_Handle = Selector.GetHandle ("setCreatedAt:");
		[CompilerGenerated]
		const string selUserID = "userID";
		static readonly IntPtr selUserIDHandle = Selector.GetHandle ("userID");
		[CompilerGenerated]
		const string selSetUserID_ = "setUserID:";
		static readonly IntPtr selSetUserID_Handle = Selector.GetHandle ("setUserID:");
		[CompilerGenerated]
		const string selUserIDs = "userIDs";
		static readonly IntPtr selUserIDsHandle = Selector.GetHandle ("userIDs");
		[CompilerGenerated]
		const string selSetUserIDs_ = "setUserIDs:";
		static readonly IntPtr selSetUserIDs_Handle = Selector.GetHandle ("setUserIDs:");
		[CompilerGenerated]
		const string selUserName = "userName";
		static readonly IntPtr selUserNameHandle = Selector.GetHandle ("userName");
		[CompilerGenerated]
		const string selSetUserName_ = "setUserName:";
		static readonly IntPtr selSetUserName_Handle = Selector.GetHandle ("setUserName:");
		[CompilerGenerated]
		const string selMinCreatedAt = "minCreatedAt";
		static readonly IntPtr selMinCreatedAtHandle = Selector.GetHandle ("minCreatedAt");
		[CompilerGenerated]
		const string selSetMinCreatedAt_ = "setMinCreatedAt:";
		static readonly IntPtr selSetMinCreatedAt_Handle = Selector.GetHandle ("setMinCreatedAt:");
		[CompilerGenerated]
		const string selMaxCreatedAt = "maxCreatedAt";
		static readonly IntPtr selMaxCreatedAtHandle = Selector.GetHandle ("maxCreatedAt");
		[CompilerGenerated]
		const string selSetMaxCreatedAt_ = "setMaxCreatedAt:";
		static readonly IntPtr selSetMaxCreatedAt_Handle = Selector.GetHandle ("setMaxCreatedAt:");
		[CompilerGenerated]
		const string selRadius = "radius";
		static readonly IntPtr selRadiusHandle = Selector.GetHandle ("radius");
		[CompilerGenerated]
		const string selSetRadius_ = "setRadius:";
		static readonly IntPtr selSetRadius_Handle = Selector.GetHandle ("setRadius:");
		[CompilerGenerated]
		const string selSortAsc = "sortAsc";
		static readonly IntPtr selSortAscHandle = Selector.GetHandle ("sortAsc");
		[CompilerGenerated]
		const string selSetSortAsc_ = "setSortAsc:";
		static readonly IntPtr selSetSortAsc_Handle = Selector.GetHandle ("setSortAsc:");
		[CompilerGenerated]
		const string selLastOnly = "lastOnly";
		static readonly IntPtr selLastOnlyHandle = Selector.GetHandle ("lastOnly");
		[CompilerGenerated]
		const string selSetLastOnly_ = "setLastOnly:";
		static readonly IntPtr selSetLastOnly_Handle = Selector.GetHandle ("setLastOnly:");
		[CompilerGenerated]
		const string selStatus = "status";
		static readonly IntPtr selStatusHandle = Selector.GetHandle ("status");
		[CompilerGenerated]
		const string selSetStatus_ = "setStatus:";
		static readonly IntPtr selSetStatus_Handle = Selector.GetHandle ("setStatus:");
		[CompilerGenerated]
		const string selCurrentPosition = "currentPosition";
		static readonly IntPtr selCurrentPositionHandle = Selector.GetHandle ("currentPosition");
		[CompilerGenerated]
		const string selSetCurrentPosition_ = "setCurrentPosition:";
		static readonly IntPtr selSetCurrentPosition_Handle = Selector.GetHandle ("setCurrentPosition:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBLGeoDataGetRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBLGeoDataGetRequest () : base (NSObjectFlag.Empty)
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
		public QBLGeoDataGetRequest (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGeoDataGetRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLGeoDataGetRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
		object __mt_UserIDs_var;
		[CompilerGenerated]
		public virtual NSObject[] UserIDs {
			[Export ("userIDs", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserIDsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserIDsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserIDs_var = ret;
				return ret;
			}
			
			[Export ("setUserIDs:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserIDs_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserIDs_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_UserIDs_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string UserName {
			[Export ("userName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserNameHandle));
				}
			}
			
			[Export ("setUserName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_MinCreatedAt_var;
		[CompilerGenerated]
		public virtual NSDate MinCreatedAt {
			[Export ("minCreatedAt", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMinCreatedAtHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMinCreatedAtHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_MinCreatedAt_var = ret;
				return ret;
			}
			
			[Export ("setMinCreatedAt:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMinCreatedAt_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMinCreatedAt_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_MinCreatedAt_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_MaxCreatedAt_var;
		[CompilerGenerated]
		public virtual NSDate MaxCreatedAt {
			[Export ("maxCreatedAt", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMaxCreatedAtHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMaxCreatedAtHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_MaxCreatedAt_var = ret;
				return ret;
			}
			
			[Export ("setMaxCreatedAt:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMaxCreatedAt_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMaxCreatedAt_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_MaxCreatedAt_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float Radius {
			[Export ("radius")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRadiusHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRadiusHandle);
				}
			}
			
			[Export ("setRadius:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRadius_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRadius_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SortAsc {
			[Export ("sortAsc")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSortAscHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSortAscHandle);
				}
			}
			
			[Export ("setSortAsc:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSortAsc_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSortAsc_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool LastOnly {
			[Export ("lastOnly")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selLastOnlyHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selLastOnlyHandle);
				}
			}
			
			[Export ("setLastOnly:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLastOnly_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetLastOnly_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Status {
			[Export ("status")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStatusHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selStatusHandle);
				}
			}
			
			[Export ("setStatus:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetStatus_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetStatus_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreLocation.CLLocationCoordinate2D CurrentPosition {
			[Export ("currentPosition")]
			get {
				global::MonoTouch.CoreLocation.CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, selCurrentPositionHandle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, selCurrentPositionHandle);
				}
				return ret;
			}
			
			[Export ("setCurrentPosition:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_CLLocationCoordinate2D (this.Handle, selSetCurrentPosition_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D (this.SuperHandle, selSetCurrentPosition_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CreatedAt_var = null;
				__mt_UserIDs_var = null;
				__mt_MinCreatedAt_var = null;
				__mt_MaxCreatedAt_var = null;
			}
		}
	} /* class QBLGeoDataGetRequest */
}
