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
	[Register("QBMSubscription", true)]
	public unsafe partial class QBMSubscription : Entity {
		[CompilerGenerated]
		const string selDevicePlatform = "devicePlatform";
		static readonly IntPtr selDevicePlatformHandle = Selector.GetHandle ("devicePlatform");
		[CompilerGenerated]
		const string selDeviceUDID = "deviceUDID";
		static readonly IntPtr selDeviceUDIDHandle = Selector.GetHandle ("deviceUDID");
		[CompilerGenerated]
		const string selNotificationChannel = "notificationChannel";
		static readonly IntPtr selNotificationChannelHandle = Selector.GetHandle ("notificationChannel");
		[CompilerGenerated]
		const string selNotificationChannelFromString_ = "notificationChannelFromString:";
		static readonly IntPtr selNotificationChannelFromString_Handle = Selector.GetHandle ("notificationChannelFromString:");
		[CompilerGenerated]
		const string selNotificationChannelToString_ = "notificationChannelToString:";
		static readonly IntPtr selNotificationChannelToString_Handle = Selector.GetHandle ("notificationChannelToString:");
		[CompilerGenerated]
		const string selSetDevicePlatform_ = "setDevicePlatform:";
		static readonly IntPtr selSetDevicePlatform_Handle = Selector.GetHandle ("setDevicePlatform:");
		[CompilerGenerated]
		const string selSetDeviceUDID_ = "setDeviceUDID:";
		static readonly IntPtr selSetDeviceUDID_Handle = Selector.GetHandle ("setDeviceUDID:");
		[CompilerGenerated]
		const string selSetNotificationChannel_ = "setNotificationChannel:";
		static readonly IntPtr selSetNotificationChannel_Handle = Selector.GetHandle ("setNotificationChannel:");
		[CompilerGenerated]
		const string selSetUrl_ = "setUrl:";
		static readonly IntPtr selSetUrl_Handle = Selector.GetHandle ("setUrl:");
		[CompilerGenerated]
		const string selSubscription = "subscription";
		static readonly IntPtr selSubscriptionHandle = Selector.GetHandle ("subscription");
		[CompilerGenerated]
		const string selUrl = "url";
		static readonly IntPtr selUrlHandle = Selector.GetHandle ("url");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMSubscription");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMSubscription () : base (NSObjectFlag.Empty)
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
		public QBMSubscription (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMSubscription (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMSubscription (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("notificationChannelFromString:")]
		[CompilerGenerated]
		public static QBMNotificatioChannel NotificationChannelFromString (string notificationChannel)
		{
			if (notificationChannel == null)
				throw new ArgumentNullException ("notificationChannel");
			var nsnotificationChannel = NSString.CreateNative (notificationChannel);
			
			QBMNotificatioChannel ret;
			ret = (QBMNotificatioChannel) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (class_ptr, selNotificationChannelFromString_Handle, nsnotificationChannel);
			NSString.ReleaseNative (nsnotificationChannel);
			
			return ret;
		}
		
		[Export ("notificationChannelToString:")]
		[CompilerGenerated]
		public static string NotificationChannelToString (QBMNotificatioChannel notificationChannel)
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (class_ptr, selNotificationChannelToString_Handle, (int)notificationChannel));
		}
		
		[CompilerGenerated]
		public virtual string DevicePlatform {
			[Export ("devicePlatform", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDevicePlatformHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDevicePlatformHandle));
				}
			}
			
			[Export ("setDevicePlatform:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDevicePlatform_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDevicePlatform_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string DeviceUDID {
			[Export ("deviceUDID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDeviceUDIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDeviceUDIDHandle));
				}
			}
			
			[Export ("setDeviceUDID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDeviceUDID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDeviceUDID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual QBMNotificatioChannel NotificationChannel {
			[Export ("notificationChannel")]
			get {
				if (IsDirectBinding) {
					return (QBMNotificatioChannel) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNotificationChannelHandle);
				} else {
					return (QBMNotificatioChannel) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNotificationChannelHandle);
				}
			}
			
			[Export ("setNotificationChannel:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetNotificationChannel_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetNotificationChannel_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		static object __mt_Subscription_var_static;
		[CompilerGenerated]
		public static QBMSubscription Subscription {
			[Export ("subscription")]
			get {
				QBMSubscription ret;
				ret =  Runtime.GetNSObject<QBMSubscription> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSubscriptionHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Subscription_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Url {
			[Export ("url", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUrlHandle));
				}
			}
			
			[Export ("setUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class QBMSubscription */
}
