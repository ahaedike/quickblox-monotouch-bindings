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
	[Register("QBUGetUsersQuery", true)]
	public unsafe partial class QBUGetUsersQuery : QBUUserQuery {
		[CompilerGenerated]
		const string selEmails = "emails";
		static readonly IntPtr selEmailsHandle = Selector.GetHandle ("emails");
		[CompilerGenerated]
		const string selExtendedRequest = "extendedRequest";
		static readonly IntPtr selExtendedRequestHandle = Selector.GetHandle ("extendedRequest");
		[CompilerGenerated]
		const string selFacebookIDs = "facebookIDs";
		static readonly IntPtr selFacebookIDsHandle = Selector.GetHandle ("facebookIDs");
		[CompilerGenerated]
		const string selIds = "ids";
		static readonly IntPtr selIdsHandle = Selector.GetHandle ("ids");
		[CompilerGenerated]
		const string selInitWithRequest_ = "initWithRequest:";
		static readonly IntPtr selInitWithRequest_Handle = Selector.GetHandle ("initWithRequest:");
		[CompilerGenerated]
		const string selLogins = "logins";
		static readonly IntPtr selLoginsHandle = Selector.GetHandle ("logins");
		[CompilerGenerated]
		const string selPagedRequest = "pagedRequest";
		static readonly IntPtr selPagedRequestHandle = Selector.GetHandle ("pagedRequest");
		[CompilerGenerated]
		const string selPhoneNumbers = "phoneNumbers";
		static readonly IntPtr selPhoneNumbersHandle = Selector.GetHandle ("phoneNumbers");
		[CompilerGenerated]
		const string selSetEmails_ = "setEmails:";
		static readonly IntPtr selSetEmails_Handle = Selector.GetHandle ("setEmails:");
		[CompilerGenerated]
		const string selSetExtendedRequest_ = "setExtendedRequest:";
		static readonly IntPtr selSetExtendedRequest_Handle = Selector.GetHandle ("setExtendedRequest:");
		[CompilerGenerated]
		const string selSetFacebookIDs_ = "setFacebookIDs:";
		static readonly IntPtr selSetFacebookIDs_Handle = Selector.GetHandle ("setFacebookIDs:");
		[CompilerGenerated]
		const string selSetIds_ = "setIds:";
		static readonly IntPtr selSetIds_Handle = Selector.GetHandle ("setIds:");
		[CompilerGenerated]
		const string selSetLogins_ = "setLogins:";
		static readonly IntPtr selSetLogins_Handle = Selector.GetHandle ("setLogins:");
		[CompilerGenerated]
		const string selSetPagedRequest_ = "setPagedRequest:";
		static readonly IntPtr selSetPagedRequest_Handle = Selector.GetHandle ("setPagedRequest:");
		[CompilerGenerated]
		const string selSetPhoneNumbers_ = "setPhoneNumbers:";
		static readonly IntPtr selSetPhoneNumbers_Handle = Selector.GetHandle ("setPhoneNumbers:");
		[CompilerGenerated]
		const string selSetTwitterIDs_ = "setTwitterIDs:";
		static readonly IntPtr selSetTwitterIDs_Handle = Selector.GetHandle ("setTwitterIDs:");
		[CompilerGenerated]
		const string selTwitterIDs = "twitterIDs";
		static readonly IntPtr selTwitterIDsHandle = Selector.GetHandle ("twitterIDs");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBUGetUsersQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBUGetUsersQuery () : base (NSObjectFlag.Empty)
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
		public QBUGetUsersQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUGetUsersQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUGetUsersQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRequest:")]
		[CompilerGenerated]
		public QBUGetUsersQuery (PagedRequest _pagedRequest)
			: base (NSObjectFlag.Empty)
		{
			if (_pagedRequest == null)
				throw new ArgumentNullException ("_pagedRequest");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithRequest_Handle, _pagedRequest.Handle), "initWithRequest:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithRequest_Handle, _pagedRequest.Handle), "initWithRequest:");
			}
		}
		
		[CompilerGenerated]
		object __mt_Emails_var;
		[CompilerGenerated]
		public virtual NSObject[] Emails {
			[Export ("emails", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEmailsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEmailsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Emails_var = ret;
				return ret;
			}
			
			[Export ("setEmails:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetEmails_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetEmails_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Emails_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ExtendedRequest_var;
		[CompilerGenerated]
		public virtual NSDictionary ExtendedRequest {
			[Export ("extendedRequest", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selExtendedRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selExtendedRequestHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ExtendedRequest_var = ret;
				return ret;
			}
			
			[Export ("setExtendedRequest:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetExtendedRequest_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetExtendedRequest_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ExtendedRequest_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_FacebookIDs_var;
		[CompilerGenerated]
		public virtual NSObject[] FacebookIDs {
			[Export ("facebookIDs", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFacebookIDsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFacebookIDsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FacebookIDs_var = ret;
				return ret;
			}
			
			[Export ("setFacebookIDs:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFacebookIDs_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFacebookIDs_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_FacebookIDs_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Ids {
			[Export ("ids", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIdsHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIdsHandle));
				}
			}
			
			[Export ("setIds:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetIds_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetIds_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Logins_var;
		[CompilerGenerated]
		public virtual NSObject[] Logins {
			[Export ("logins", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLoginsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLoginsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Logins_var = ret;
				return ret;
			}
			
			[Export ("setLogins:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLogins_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLogins_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Logins_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_PagedRequest_var;
		[CompilerGenerated]
		public virtual PagedRequest PagedRequest {
			[Export ("pagedRequest", ArgumentSemantic.Retain)]
			get {
				PagedRequest ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PagedRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPagedRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<PagedRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPagedRequestHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PagedRequest_var = ret;
				return ret;
			}
			
			[Export ("setPagedRequest:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPagedRequest_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPagedRequest_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_PagedRequest_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_PhoneNumbers_var;
		[CompilerGenerated]
		public virtual NSObject[] PhoneNumbers {
			[Export ("phoneNumbers", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPhoneNumbersHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPhoneNumbersHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PhoneNumbers_var = ret;
				return ret;
			}
			
			[Export ("setPhoneNumbers:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPhoneNumbers_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPhoneNumbers_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_PhoneNumbers_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_TwitterIDs_var;
		[CompilerGenerated]
		public virtual NSObject[] TwitterIDs {
			[Export ("twitterIDs", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTwitterIDsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTwitterIDsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TwitterIDs_var = ret;
				return ret;
			}
			
			[Export ("setTwitterIDs:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTwitterIDs_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTwitterIDs_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_TwitterIDs_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Emails_var = null;
				__mt_ExtendedRequest_var = null;
				__mt_FacebookIDs_var = null;
				__mt_Logins_var = null;
				__mt_PagedRequest_var = null;
				__mt_PhoneNumbers_var = null;
				__mt_TwitterIDs_var = null;
			}
		}
	} /* class QBUGetUsersQuery */
}
