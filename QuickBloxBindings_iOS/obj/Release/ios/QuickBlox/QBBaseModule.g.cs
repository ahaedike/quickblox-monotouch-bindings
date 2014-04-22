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
	[Register("QBBaseModule", true)]
	public unsafe partial class QBBaseModule : NSObject {
		[CompilerGenerated]
		const string selToken = "token";
		static readonly IntPtr selTokenHandle = Selector.GetHandle ("token");
		[CompilerGenerated]
		const string selSetToken_ = "setToken:";
		static readonly IntPtr selSetToken_Handle = Selector.GetHandle ("setToken:");
		[CompilerGenerated]
		const string selTokenExpirationDate = "tokenExpirationDate";
		static readonly IntPtr selTokenExpirationDateHandle = Selector.GetHandle ("tokenExpirationDate");
		[CompilerGenerated]
		const string selSetTokenExpirationDate_ = "setTokenExpirationDate:";
		static readonly IntPtr selSetTokenExpirationDate_Handle = Selector.GetHandle ("setTokenExpirationDate:");
		[CompilerGenerated]
		const string selSessionType = "sessionType";
		static readonly IntPtr selSessionTypeHandle = Selector.GetHandle ("sessionType");
		[CompilerGenerated]
		const string selSetSessionType_ = "setSessionType:";
		static readonly IntPtr selSetSessionType_Handle = Selector.GetHandle ("setSessionType:");
		[CompilerGenerated]
		const string selSessionCreationRequest = "sessionCreationRequest";
		static readonly IntPtr selSessionCreationRequestHandle = Selector.GetHandle ("sessionCreationRequest");
		[CompilerGenerated]
		const string selSetSessionCreationRequest_ = "setSessionCreationRequest:";
		static readonly IntPtr selSetSessionCreationRequest_Handle = Selector.GetHandle ("setSessionCreationRequest:");
		[CompilerGenerated]
		const string selSharedModule = "sharedModule";
		static readonly IntPtr selSharedModuleHandle = Selector.GetHandle ("sharedModule");
		[CompilerGenerated]
		const string selServerEndpointURL = "serverEndpointURL";
		static readonly IntPtr selServerEndpointURLHandle = Selector.GetHandle ("serverEndpointURL");
		[CompilerGenerated]
		const string selChatServerEndpointURL = "chatServerEndpointURL";
		static readonly IntPtr selChatServerEndpointURLHandle = Selector.GetHandle ("chatServerEndpointURL");
		[CompilerGenerated]
		const string selChatMUCServerEndpointURL = "chatMUCServerEndpointURL";
		static readonly IntPtr selChatMUCServerEndpointURLHandle = Selector.GetHandle ("chatMUCServerEndpointURL");
		[CompilerGenerated]
		const string selCreateSharedModule = "createSharedModule";
		static readonly IntPtr selCreateSharedModuleHandle = Selector.GetHandle ("createSharedModule");
		[CompilerGenerated]
		const string selReset = "reset";
		static readonly IntPtr selResetHandle = Selector.GetHandle ("reset");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBBaseModule");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBBaseModule () : base (NSObjectFlag.Empty)
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
		public QBBaseModule (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBBaseModule (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBBaseModule (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("createSharedModule")]
		[CompilerGenerated]
		public static void CreateSharedModule ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selCreateSharedModuleHandle);
		}
		
		[Export ("reset")]
		[CompilerGenerated]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResetHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selResetHandle);
			}
		}
		
		[CompilerGenerated]
		public virtual string Token {
			[Export ("token", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTokenHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTokenHandle));
				}
			}
			
			[Export ("setToken:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetToken_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetToken_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_TokenExpirationDate_var;
		[CompilerGenerated]
		public virtual NSDate TokenExpirationDate {
			[Export ("tokenExpirationDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTokenExpirationDateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTokenExpirationDateHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TokenExpirationDate_var = ret;
				return ret;
			}
			
			[Export ("setTokenExpirationDate:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTokenExpirationDate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTokenExpirationDate_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TokenExpirationDate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual QBSessionType SessionType {
			[Export ("sessionType")]
			get {
				if (IsDirectBinding) {
					return (QBSessionType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSessionTypeHandle);
				} else {
					return (QBSessionType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSessionTypeHandle);
				}
			}
			
			[Export ("setSessionType:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetSessionType_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetSessionType_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SessionCreationRequest_var;
		[CompilerGenerated]
		public virtual QBASessionCreationRequest SessionCreationRequest {
			[Export ("sessionCreationRequest", ArgumentSemantic.Retain)]
			get {
				QBASessionCreationRequest ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBASessionCreationRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSessionCreationRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<QBASessionCreationRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSessionCreationRequestHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SessionCreationRequest_var = ret;
				return ret;
			}
			
			[Export ("setSessionCreationRequest:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSessionCreationRequest_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSessionCreationRequest_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SessionCreationRequest_var = value;
			}
		}
		
		[CompilerGenerated]
		static object __mt_SharedModule_var_static;
		[CompilerGenerated]
		public static QBBaseModule SharedModule {
			[Export ("sharedModule")]
			get {
				QBBaseModule ret;
				ret =  Runtime.GetNSObject<QBBaseModule> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedModuleHandle));
				__mt_SharedModule_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static string ServerEndpointURL {
			[Export ("serverEndpointURL")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selServerEndpointURLHandle));
			}
			
		}
		
		[CompilerGenerated]
		public static string ChatServerEndpointURL {
			[Export ("chatServerEndpointURL")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selChatServerEndpointURLHandle));
			}
			
		}
		
		[CompilerGenerated]
		public static string ChatMUCServerEndpointURL {
			[Export ("chatMUCServerEndpointURL")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selChatMUCServerEndpointURLHandle));
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TokenExpirationDate_var = null;
				__mt_SessionCreationRequest_var = null;
			}
		}
	} /* class QBBaseModule */
}
