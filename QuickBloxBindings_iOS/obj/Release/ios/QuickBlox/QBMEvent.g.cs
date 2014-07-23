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
	[Register("QBMEvent", true)]
	public unsafe partial class QBMEvent : Entity {
		[CompilerGenerated]
		const string selActive = "active";
		static readonly IntPtr selActiveHandle = Selector.GetHandle ("active");
		[CompilerGenerated]
		const string selDate = "date";
		static readonly IntPtr selDateHandle = Selector.GetHandle ("date");
		[CompilerGenerated]
		const string selEndDate = "endDate";
		static readonly IntPtr selEndDateHandle = Selector.GetHandle ("endDate");
		[CompilerGenerated]
		const string selEvent = "event";
		static readonly IntPtr selEventHandle = Selector.GetHandle ("event");
		[CompilerGenerated]
		const string selIsDevelopmentEnvironment = "isDevelopmentEnvironment";
		static readonly IntPtr selIsDevelopmentEnvironmentHandle = Selector.GetHandle ("isDevelopmentEnvironment");
		[CompilerGenerated]
		const string selMessage = "message";
		static readonly IntPtr selMessageHandle = Selector.GetHandle ("message");
		[CompilerGenerated]
		const string selMessageFromString_ = "messageFromString:";
		static readonly IntPtr selMessageFromString_Handle = Selector.GetHandle ("messageFromString:");
		[CompilerGenerated]
		const string selMessageToString_ = "messageToString:";
		static readonly IntPtr selMessageToString_Handle = Selector.GetHandle ("messageToString:");
		[CompilerGenerated]
		const string selName = "name";
		static readonly IntPtr selNameHandle = Selector.GetHandle ("name");
		[CompilerGenerated]
		const string selNotificationType = "notificationType";
		static readonly IntPtr selNotificationTypeHandle = Selector.GetHandle ("notificationType");
		[CompilerGenerated]
		const string selNotificationTypeFromString_ = "notificationTypeFromString:";
		static readonly IntPtr selNotificationTypeFromString_Handle = Selector.GetHandle ("notificationTypeFromString:");
		[CompilerGenerated]
		const string selNotificationTypeToString_ = "notificationTypeToString:";
		static readonly IntPtr selNotificationTypeToString_Handle = Selector.GetHandle ("notificationTypeToString:");
		[CompilerGenerated]
		const string selOccuredCount = "occuredCount";
		static readonly IntPtr selOccuredCountHandle = Selector.GetHandle ("occuredCount");
		[CompilerGenerated]
		const string selPeriod = "period";
		static readonly IntPtr selPeriodHandle = Selector.GetHandle ("period");
		[CompilerGenerated]
		const string selPrepareMessage = "prepareMessage";
		static readonly IntPtr selPrepareMessageHandle = Selector.GetHandle ("prepareMessage");
		[CompilerGenerated]
		const string selPushType = "pushType";
		static readonly IntPtr selPushTypeHandle = Selector.GetHandle ("pushType");
		[CompilerGenerated]
		const string selPushTypeFromString_ = "pushTypeFromString:";
		static readonly IntPtr selPushTypeFromString_Handle = Selector.GetHandle ("pushTypeFromString:");
		[CompilerGenerated]
		const string selPushTypeToString_ = "pushTypeToString:";
		static readonly IntPtr selPushTypeToString_Handle = Selector.GetHandle ("pushTypeToString:");
		[CompilerGenerated]
		const string selSenderID = "senderID";
		static readonly IntPtr selSenderIDHandle = Selector.GetHandle ("senderID");
		[CompilerGenerated]
		const string selSetActive_ = "setActive:";
		static readonly IntPtr selSetActive_Handle = Selector.GetHandle ("setActive:");
		[CompilerGenerated]
		const string selSetDate_ = "setDate:";
		static readonly IntPtr selSetDate_Handle = Selector.GetHandle ("setDate:");
		[CompilerGenerated]
		const string selSetEndDate_ = "setEndDate:";
		static readonly IntPtr selSetEndDate_Handle = Selector.GetHandle ("setEndDate:");
		[CompilerGenerated]
		const string selSetIsDevelopmentEnvironment_ = "setIsDevelopmentEnvironment:";
		static readonly IntPtr selSetIsDevelopmentEnvironment_Handle = Selector.GetHandle ("setIsDevelopmentEnvironment:");
		[CompilerGenerated]
		const string selSetMessage_ = "setMessage:";
		static readonly IntPtr selSetMessage_Handle = Selector.GetHandle ("setMessage:");
		[CompilerGenerated]
		const string selSetName_ = "setName:";
		static readonly IntPtr selSetName_Handle = Selector.GetHandle ("setName:");
		[CompilerGenerated]
		const string selSetNotificationType_ = "setNotificationType:";
		static readonly IntPtr selSetNotificationType_Handle = Selector.GetHandle ("setNotificationType:");
		[CompilerGenerated]
		const string selSetOccuredCount_ = "setOccuredCount:";
		static readonly IntPtr selSetOccuredCount_Handle = Selector.GetHandle ("setOccuredCount:");
		[CompilerGenerated]
		const string selSetPeriod_ = "setPeriod:";
		static readonly IntPtr selSetPeriod_Handle = Selector.GetHandle ("setPeriod:");
		[CompilerGenerated]
		const string selSetPushType_ = "setPushType:";
		static readonly IntPtr selSetPushType_Handle = Selector.GetHandle ("setPushType:");
		[CompilerGenerated]
		const string selSetSenderID_ = "setSenderID:";
		static readonly IntPtr selSetSenderID_Handle = Selector.GetHandle ("setSenderID:");
		[CompilerGenerated]
		const string selSetType_ = "setType:";
		static readonly IntPtr selSetType_Handle = Selector.GetHandle ("setType:");
		[CompilerGenerated]
		const string selSetUsersExternalIDs_ = "setUsersExternalIDs:";
		static readonly IntPtr selSetUsersExternalIDs_Handle = Selector.GetHandle ("setUsersExternalIDs:");
		[CompilerGenerated]
		const string selSetUsersIDs_ = "setUsersIDs:";
		static readonly IntPtr selSetUsersIDs_Handle = Selector.GetHandle ("setUsersIDs:");
		[CompilerGenerated]
		const string selSetUsersTagsAll_ = "setUsersTagsAll:";
		static readonly IntPtr selSetUsersTagsAll_Handle = Selector.GetHandle ("setUsersTagsAll:");
		[CompilerGenerated]
		const string selSetUsersTagsAny_ = "setUsersTagsAny:";
		static readonly IntPtr selSetUsersTagsAny_Handle = Selector.GetHandle ("setUsersTagsAny:");
		[CompilerGenerated]
		const string selSetUsersTagsExclude_ = "setUsersTagsExclude:";
		static readonly IntPtr selSetUsersTagsExclude_Handle = Selector.GetHandle ("setUsersTagsExclude:");
		[CompilerGenerated]
		const string selType = "type";
		static readonly IntPtr selTypeHandle = Selector.GetHandle ("type");
		[CompilerGenerated]
		const string selUsersExternalIDs = "usersExternalIDs";
		static readonly IntPtr selUsersExternalIDsHandle = Selector.GetHandle ("usersExternalIDs");
		[CompilerGenerated]
		const string selUsersIDs = "usersIDs";
		static readonly IntPtr selUsersIDsHandle = Selector.GetHandle ("usersIDs");
		[CompilerGenerated]
		const string selUsersTagsAll = "usersTagsAll";
		static readonly IntPtr selUsersTagsAllHandle = Selector.GetHandle ("usersTagsAll");
		[CompilerGenerated]
		const string selUsersTagsAny = "usersTagsAny";
		static readonly IntPtr selUsersTagsAnyHandle = Selector.GetHandle ("usersTagsAny");
		[CompilerGenerated]
		const string selUsersTagsExclude = "usersTagsExclude";
		static readonly IntPtr selUsersTagsExcludeHandle = Selector.GetHandle ("usersTagsExclude");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMEvent");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMEvent () : base (NSObjectFlag.Empty)
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
		public QBMEvent (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMEvent (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMEvent (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("messageFromString:")]
		[CompilerGenerated]
		public static NSDictionary MessageFromString (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selMessageFromString_Handle, nsmessage));
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[Export ("messageToString:")]
		[CompilerGenerated]
		public static string MessageToString (NSDictionary message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selMessageToString_Handle, message.Handle));
		}
		
		[Export ("notificationTypeFromString:")]
		[CompilerGenerated]
		public static QBMNotificationType NotificationTypeFromString (string notificationType)
		{
			if (notificationType == null)
				throw new ArgumentNullException ("notificationType");
			var nsnotificationType = NSString.CreateNative (notificationType);
			
			QBMNotificationType ret;
			ret = (QBMNotificationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (class_ptr, selNotificationTypeFromString_Handle, nsnotificationType);
			NSString.ReleaseNative (nsnotificationType);
			
			return ret;
		}
		
		[Export ("notificationTypeToString:")]
		[CompilerGenerated]
		public static string NotificationTypeToString (QBMNotificationType notificationType)
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (class_ptr, selNotificationTypeToString_Handle, (int)notificationType));
		}
		
		[Export ("prepareMessage")]
		[CompilerGenerated]
		public virtual void PrepareMessage ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrepareMessageHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPrepareMessageHandle);
			}
		}
		
		[Export ("pushTypeFromString:")]
		[CompilerGenerated]
		public static QBMPushType PushTypeFromString (string pushType)
		{
			if (pushType == null)
				throw new ArgumentNullException ("pushType");
			var nspushType = NSString.CreateNative (pushType);
			
			QBMPushType ret;
			ret = (QBMPushType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (class_ptr, selPushTypeFromString_Handle, nspushType);
			NSString.ReleaseNative (nspushType);
			
			return ret;
		}
		
		[Export ("pushTypeToString:")]
		[CompilerGenerated]
		public static string PushTypeToString (QBMPushType pushType)
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (class_ptr, selPushTypeToString_Handle, (int)pushType));
		}
		
		[CompilerGenerated]
		public virtual bool Active {
			[Export ("active")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selActiveHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selActiveHandle);
				}
			}
			
			[Export ("setActive:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetActive_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetActive_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Date_var;
		[CompilerGenerated]
		public virtual NSDate Date {
			[Export ("date", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDateHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Date_var = ret;
				return ret;
			}
			
			[Export ("setDate:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDate_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Date_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_EndDate_var;
		[CompilerGenerated]
		public virtual NSDate EndDate {
			[Export ("endDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEndDateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEndDateHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_EndDate_var = ret;
				return ret;
			}
			
			[Export ("setEndDate:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetEndDate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetEndDate_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_EndDate_var = value;
			}
		}
		
		[CompilerGenerated]
		static object __mt_Event_var_static;
		[CompilerGenerated]
		public static QBMEvent Event {
			[Export ("event")]
			get {
				QBMEvent ret;
				ret =  Runtime.GetNSObject<QBMEvent> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selEventHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Event_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsDevelopmentEnvironment {
			[Export ("isDevelopmentEnvironment")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDevelopmentEnvironmentHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsDevelopmentEnvironmentHandle);
				}
			}
			
			[Export ("setIsDevelopmentEnvironment:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsDevelopmentEnvironment_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsDevelopmentEnvironment_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Message_var;
		[CompilerGenerated]
		public virtual NSObject Message {
			[Export ("message", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMessageHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMessageHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Message_var = ret;
				return ret;
			}
			
			[Export ("setMessage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMessage_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMessage_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Message_var = value;
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
		public virtual QBMNotificationType NotificationType {
			[Export ("notificationType")]
			get {
				if (IsDirectBinding) {
					return (QBMNotificationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNotificationTypeHandle);
				} else {
					return (QBMNotificationType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNotificationTypeHandle);
				}
			}
			
			[Export ("setNotificationType:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetNotificationType_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetNotificationType_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 OccuredCount {
			[Export ("occuredCount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selOccuredCountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selOccuredCountHandle);
				}
			}
			
			[Export ("setOccuredCount:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetOccuredCount_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetOccuredCount_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Period {
			[Export ("period")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPeriodHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPeriodHandle);
				}
			}
			
			[Export ("setPeriod:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPeriod_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPeriod_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual QBMPushType PushType {
			[Export ("pushType")]
			get {
				if (IsDirectBinding) {
					return (QBMPushType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPushTypeHandle);
				} else {
					return (QBMPushType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPushTypeHandle);
				}
			}
			
			[Export ("setPushType:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPushType_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPushType_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 SenderID {
			[Export ("senderID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selSenderIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selSenderIDHandle);
				}
			}
			
			[Export ("setSenderID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetSenderID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetSenderID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual QBMEventType Type {
			[Export ("type")]
			get {
				if (IsDirectBinding) {
					return (QBMEventType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTypeHandle);
				} else {
					return (QBMEventType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selTypeHandle);
				}
			}
			
			[Export ("setType:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetType_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetType_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string UsersExternalIDs {
			[Export ("usersExternalIDs", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersExternalIDsHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersExternalIDsHandle));
				}
			}
			
			[Export ("setUsersExternalIDs:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersExternalIDs_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersExternalIDs_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UsersIDs {
			[Export ("usersIDs", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersIDsHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersIDsHandle));
				}
			}
			
			[Export ("setUsersIDs:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersIDs_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersIDs_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UsersTagsAll {
			[Export ("usersTagsAll", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersTagsAllHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersTagsAllHandle));
				}
			}
			
			[Export ("setUsersTagsAll:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersTagsAll_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersTagsAll_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UsersTagsAny {
			[Export ("usersTagsAny", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersTagsAnyHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersTagsAnyHandle));
				}
			}
			
			[Export ("setUsersTagsAny:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersTagsAny_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersTagsAny_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string UsersTagsExclude {
			[Export ("usersTagsExclude", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUsersTagsExcludeHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUsersTagsExcludeHandle));
				}
			}
			
			[Export ("setUsersTagsExclude:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUsersTagsExclude_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUsersTagsExclude_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Date_var = null;
				__mt_EndDate_var = null;
				__mt_Message_var = null;
			}
		}
	} /* class QBMEvent */
}
