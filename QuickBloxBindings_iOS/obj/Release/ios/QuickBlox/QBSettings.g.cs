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
	[Register("QBSettings", true)]
	public unsafe partial class QBSettings : NSObject {
		[CompilerGenerated]
		const string selApplicationID = "applicationID";
		static readonly IntPtr selApplicationIDHandle = Selector.GetHandle ("applicationID");
		[CompilerGenerated]
		const string selAuthorizationKey = "authorizationKey";
		static readonly IntPtr selAuthorizationKeyHandle = Selector.GetHandle ("authorizationKey");
		[CompilerGenerated]
		const string selAuthorizationSecret = "authorizationSecret";
		static readonly IntPtr selAuthorizationSecretHandle = Selector.GetHandle ("authorizationSecret");
		[CompilerGenerated]
		const string selContentBucket = "contentBucket";
		static readonly IntPtr selContentBucketHandle = Selector.GetHandle ("contentBucket");
		[CompilerGenerated]
		const string selEnableSessionExpirationAutoHandler_ = "enableSessionExpirationAutoHandler:";
		static readonly IntPtr selEnableSessionExpirationAutoHandler_Handle = Selector.GetHandle ("enableSessionExpirationAutoHandler:");
		[CompilerGenerated]
		const string selIsEnabledSessionExpirationAutoHandler = "isEnabledSessionExpirationAutoHandler";
		static readonly IntPtr selIsEnabledSessionExpirationAutoHandlerHandle = Selector.GetHandle ("isEnabledSessionExpirationAutoHandler");
		[CompilerGenerated]
		const string selIsUseHTTPS = "isUseHTTPS";
		static readonly IntPtr selIsUseHTTPSHandle = Selector.GetHandle ("isUseHTTPS");
		[CompilerGenerated]
		const string selIsUseProductionEnvironmentForPushNotifications = "isUseProductionEnvironmentForPushNotifications";
		static readonly IntPtr selIsUseProductionEnvironmentForPushNotificationsHandle = Selector.GetHandle ("isUseProductionEnvironmentForPushNotifications");
		[CompilerGenerated]
		const string selLogLevel = "logLevel";
		static readonly IntPtr selLogLevelHandle = Selector.GetHandle ("logLevel");
		[CompilerGenerated]
		const string selRestAPIVersion = "restAPIVersion";
		static readonly IntPtr selRestAPIVersionHandle = Selector.GetHandle ("restAPIVersion");
		[CompilerGenerated]
		const string selServerApiDomain = "serverApiDomain";
		static readonly IntPtr selServerApiDomainHandle = Selector.GetHandle ("serverApiDomain");
		[CompilerGenerated]
		const string selServerChatDomain = "serverChatDomain";
		static readonly IntPtr selServerChatDomainHandle = Selector.GetHandle ("serverChatDomain");
		[CompilerGenerated]
		const string selServerDomain = "serverDomain";
		static readonly IntPtr selServerDomainHandle = Selector.GetHandle ("serverDomain");
		[CompilerGenerated]
		const string selServerZone = "serverZone";
		static readonly IntPtr selServerZoneHandle = Selector.GetHandle ("serverZone");
		[CompilerGenerated]
		const string selServerZoneAsString = "serverZoneAsString";
		static readonly IntPtr selServerZoneAsStringHandle = Selector.GetHandle ("serverZoneAsString");
		[CompilerGenerated]
		const string selSetApplicationID_ = "setApplicationID:";
		static readonly IntPtr selSetApplicationID_Handle = Selector.GetHandle ("setApplicationID:");
		[CompilerGenerated]
		const string selSetAuthorizationKey_ = "setAuthorizationKey:";
		static readonly IntPtr selSetAuthorizationKey_Handle = Selector.GetHandle ("setAuthorizationKey:");
		[CompilerGenerated]
		const string selSetAuthorizationSecret_ = "setAuthorizationSecret:";
		static readonly IntPtr selSetAuthorizationSecret_Handle = Selector.GetHandle ("setAuthorizationSecret:");
		[CompilerGenerated]
		const string selSetContentBucket_ = "setContentBucket:";
		static readonly IntPtr selSetContentBucket_Handle = Selector.GetHandle ("setContentBucket:");
		[CompilerGenerated]
		const string selSetLogLevel_ = "setLogLevel:";
		static readonly IntPtr selSetLogLevel_Handle = Selector.GetHandle ("setLogLevel:");
		[CompilerGenerated]
		const string selSetRestAPIVersion_ = "setRestAPIVersion:";
		static readonly IntPtr selSetRestAPIVersion_Handle = Selector.GetHandle ("setRestAPIVersion:");
		[CompilerGenerated]
		const string selSetServerApiDomain_ = "setServerApiDomain:";
		static readonly IntPtr selSetServerApiDomain_Handle = Selector.GetHandle ("setServerApiDomain:");
		[CompilerGenerated]
		const string selSetServerChatDomain_ = "setServerChatDomain:";
		static readonly IntPtr selSetServerChatDomain_Handle = Selector.GetHandle ("setServerChatDomain:");
		[CompilerGenerated]
		const string selSetServerDomain_ = "setServerDomain:";
		static readonly IntPtr selSetServerDomain_Handle = Selector.GetHandle ("setServerDomain:");
		[CompilerGenerated]
		const string selSetServerZone_ = "setServerZone:";
		static readonly IntPtr selSetServerZone_Handle = Selector.GetHandle ("setServerZone:");
		[CompilerGenerated]
		const string selSetTimeOutSeconds_ = "setTimeOutSeconds:";
		static readonly IntPtr selSetTimeOutSeconds_Handle = Selector.GetHandle ("setTimeOutSeconds:");
		[CompilerGenerated]
		const string selSetVideoChatConfiguration_ = "setVideoChatConfiguration:";
		static readonly IntPtr selSetVideoChatConfiguration_Handle = Selector.GetHandle ("setVideoChatConfiguration:");
		[CompilerGenerated]
		const string selTimeOutSeconds = "timeOutSeconds";
		static readonly IntPtr selTimeOutSecondsHandle = Selector.GetHandle ("timeOutSeconds");
		[CompilerGenerated]
		const string selUseHTTPS_ = "useHTTPS:";
		static readonly IntPtr selUseHTTPS_Handle = Selector.GetHandle ("useHTTPS:");
		[CompilerGenerated]
		const string selUseProductionEnvironmentForPushNotifications_ = "useProductionEnvironmentForPushNotifications:";
		static readonly IntPtr selUseProductionEnvironmentForPushNotifications_Handle = Selector.GetHandle ("useProductionEnvironmentForPushNotifications:");
		[CompilerGenerated]
		const string selVideoChatConfiguration = "videoChatConfiguration";
		static readonly IntPtr selVideoChatConfigurationHandle = Selector.GetHandle ("videoChatConfiguration");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBSettings");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBSettings () : base (NSObjectFlag.Empty)
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
		public QBSettings (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBSettings (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBSettings (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("enableSessionExpirationAutoHandler:")]
		[CompilerGenerated]
		public static void EnableSessionExpirationAutoHandler (bool isEnable)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selEnableSessionExpirationAutoHandler_Handle, isEnable);
		}
		
		[Export ("useHTTPS:")]
		[CompilerGenerated]
		public static void UseHTTPS (bool useHTTPS)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selUseHTTPS_Handle, useHTTPS);
		}
		
		[Export ("useProductionEnvironmentForPushNotifications:")]
		[CompilerGenerated]
		public static void UseProductionEnvironmentForPushNotifications (bool useProductionEnvironment)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selUseProductionEnvironmentForPushNotifications_Handle, useProductionEnvironment);
		}
		
		[CompilerGenerated]
		public static global::System.UInt32 ApplicationID {
			[Export ("applicationID")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (class_ptr, selApplicationIDHandle);
			}
			
			[Export ("setApplicationID:")]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (class_ptr, selSetApplicationID_Handle, value);
			}
		}
		
		[CompilerGenerated]
		public static string AuthorizationKey {
			[Export ("authorizationKey")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selAuthorizationKeyHandle));
			}
			
			[Export ("setAuthorizationKey:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetAuthorizationKey_Handle, nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public static string AuthorizationSecret {
			[Export ("authorizationSecret")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selAuthorizationSecretHandle));
			}
			
			[Export ("setAuthorizationSecret:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetAuthorizationSecret_Handle, nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public static string ContentBucket {
			[Export ("contentBucket")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selContentBucketHandle));
			}
			
			[Export ("setContentBucket:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetContentBucket_Handle, nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public static bool IsEnabledSessionExpirationAutoHandler {
			[Export ("isEnabledSessionExpirationAutoHandler")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsEnabledSessionExpirationAutoHandlerHandle);
			}
			
		}
		
		[CompilerGenerated]
		public static bool IsUseHTTPS {
			[Export ("isUseHTTPS")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsUseHTTPSHandle);
			}
			
		}
		
		[CompilerGenerated]
		public static bool IsUseProductionEnvironmentForPushNotifications {
			[Export ("isUseProductionEnvironmentForPushNotifications")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsUseProductionEnvironmentForPushNotificationsHandle);
			}
			
		}
		
		[CompilerGenerated]
		public static QBLogLevel LogLevel {
			[Export ("logLevel")]
			get {
				return (QBLogLevel) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (class_ptr, selLogLevelHandle);
			}
			
			[Export ("setLogLevel:")]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (class_ptr, selSetLogLevel_Handle, (int)value);
			}
		}
		
		[CompilerGenerated]
		public static string RestAPIVersion {
			[Export ("restAPIVersion")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selRestAPIVersionHandle));
			}
			
			[Export ("setRestAPIVersion:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetRestAPIVersion_Handle, nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public static string ServerApiDomain {
			[Export ("serverApiDomain")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selServerApiDomainHandle));
			}
			
			[Export ("setServerApiDomain:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetServerApiDomain_Handle, nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public static string ServerChatDomain {
			[Export ("serverChatDomain")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selServerChatDomainHandle));
			}
			
			[Export ("setServerChatDomain:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetServerChatDomain_Handle, nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public static string ServerDomain {
			[Export ("serverDomain")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selServerDomainHandle));
			}
			
			[Export ("setServerDomain:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetServerDomain_Handle, nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public static QBServerZone ServerZone {
			[Export ("serverZone")]
			get {
				return (QBServerZone) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (class_ptr, selServerZoneHandle);
			}
			
			[Export ("setServerZone:")]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (class_ptr, selSetServerZone_Handle, (int)value);
			}
		}
		
		[CompilerGenerated]
		public static string ServerZoneAsString {
			[Export ("serverZoneAsString")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selServerZoneAsStringHandle));
			}
			
		}
		
		[CompilerGenerated]
		public static int TimeOutSeconds {
			[Export ("timeOutSeconds")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (class_ptr, selTimeOutSecondsHandle);
			}
			
			[Export ("setTimeOutSeconds:")]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (class_ptr, selSetTimeOutSeconds_Handle, value);
			}
		}
		
		[CompilerGenerated]
		static object __mt_VideoChatConfiguration_var_static;
		[CompilerGenerated]
		public static NSDictionary VideoChatConfiguration {
			[Export ("videoChatConfiguration")]
			get {
				NSDictionary ret;
				ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selVideoChatConfigurationHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_VideoChatConfiguration_var_static = ret;
				return ret;
			}
			
			[Export ("setVideoChatConfiguration:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetVideoChatConfiguration_Handle, value.Handle);
			}
		}
		
	} /* class QBSettings */
}
