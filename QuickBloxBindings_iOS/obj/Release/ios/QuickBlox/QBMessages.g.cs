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
	[Register("QBMessages", true)]
	public unsafe partial class QBMessages : NSObject {
		[CompilerGenerated]
		const string selCreateEventDelegate_ = "createEvent:delegate:";
		static readonly IntPtr selCreateEventDelegate_Handle = Selector.GetHandle ("createEvent:delegate:");
		[CompilerGenerated]
		const string selCreateEventDelegateContext_ = "createEvent:delegate:context:";
		static readonly IntPtr selCreateEventDelegateContext_Handle = Selector.GetHandle ("createEvent:delegate:context:");
		[CompilerGenerated]
		const string selCreatePushTokenDelegate_ = "createPushToken:delegate:";
		static readonly IntPtr selCreatePushTokenDelegate_Handle = Selector.GetHandle ("createPushToken:delegate:");
		[CompilerGenerated]
		const string selCreatePushTokenDelegateContext_ = "createPushToken:delegate:context:";
		static readonly IntPtr selCreatePushTokenDelegateContext_Handle = Selector.GetHandle ("createPushToken:delegate:context:");
		[CompilerGenerated]
		const string selCreateSubscriptionDelegate_ = "createSubscription:delegate:";
		static readonly IntPtr selCreateSubscriptionDelegate_Handle = Selector.GetHandle ("createSubscription:delegate:");
		[CompilerGenerated]
		const string selCreateSubscriptionDelegateContext_ = "createSubscription:delegate:context:";
		static readonly IntPtr selCreateSubscriptionDelegateContext_Handle = Selector.GetHandle ("createSubscription:delegate:context:");
		[CompilerGenerated]
		const string selDeleteEventWithIDDelegate_ = "deleteEventWithID:delegate:";
		static readonly IntPtr selDeleteEventWithIDDelegate_Handle = Selector.GetHandle ("deleteEventWithID:delegate:");
		[CompilerGenerated]
		const string selDeleteEventWithIDDelegateContext_ = "deleteEventWithID:delegate:context:";
		static readonly IntPtr selDeleteEventWithIDDelegateContext_Handle = Selector.GetHandle ("deleteEventWithID:delegate:context:");
		[CompilerGenerated]
		const string selDeletePushTokenWithIDDelegate_ = "deletePushTokenWithID:delegate:";
		static readonly IntPtr selDeletePushTokenWithIDDelegate_Handle = Selector.GetHandle ("deletePushTokenWithID:delegate:");
		[CompilerGenerated]
		const string selDeletePushTokenWithIDDelegateContext_ = "deletePushTokenWithID:delegate:context:";
		static readonly IntPtr selDeletePushTokenWithIDDelegateContext_Handle = Selector.GetHandle ("deletePushTokenWithID:delegate:context:");
		[CompilerGenerated]
		const string selDeleteSubscriptionWithIDDelegate_ = "deleteSubscriptionWithID:delegate:";
		static readonly IntPtr selDeleteSubscriptionWithIDDelegate_Handle = Selector.GetHandle ("deleteSubscriptionWithID:delegate:");
		[CompilerGenerated]
		const string selDeleteSubscriptionWithIDDelegateContext_ = "deleteSubscriptionWithID:delegate:context:";
		static readonly IntPtr selDeleteSubscriptionWithIDDelegateContext_Handle = Selector.GetHandle ("deleteSubscriptionWithID:delegate:context:");
		[CompilerGenerated]
		const string selEventsWithDelegate_ = "eventsWithDelegate:";
		static readonly IntPtr selEventsWithDelegate_Handle = Selector.GetHandle ("eventsWithDelegate:");
		[CompilerGenerated]
		const string selEventsWithDelegateContext_ = "eventsWithDelegate:context:";
		static readonly IntPtr selEventsWithDelegateContext_Handle = Selector.GetHandle ("eventsWithDelegate:context:");
		[CompilerGenerated]
		const string selEventsWithPagedRequestDelegate_ = "eventsWithPagedRequest:delegate:";
		static readonly IntPtr selEventsWithPagedRequestDelegate_Handle = Selector.GetHandle ("eventsWithPagedRequest:delegate:");
		[CompilerGenerated]
		const string selEventsWithPagedRequestDelegateContext_ = "eventsWithPagedRequest:delegate:context:";
		static readonly IntPtr selEventsWithPagedRequestDelegateContext_Handle = Selector.GetHandle ("eventsWithPagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selEventWithIDDelegate_ = "eventWithID:delegate:";
		static readonly IntPtr selEventWithIDDelegate_Handle = Selector.GetHandle ("eventWithID:delegate:");
		[CompilerGenerated]
		const string selEventWithIDDelegateContext_ = "eventWithID:delegate:context:";
		static readonly IntPtr selEventWithIDDelegateContext_Handle = Selector.GetHandle ("eventWithID:delegate:context:");
		[CompilerGenerated]
		const string selPullEventsWithDelegate_ = "pullEventsWithDelegate:";
		static readonly IntPtr selPullEventsWithDelegate_Handle = Selector.GetHandle ("pullEventsWithDelegate:");
		[CompilerGenerated]
		const string selPullEventsWithDelegateContext_ = "pullEventsWithDelegate:context:";
		static readonly IntPtr selPullEventsWithDelegateContext_Handle = Selector.GetHandle ("pullEventsWithDelegate:context:");
		[CompilerGenerated]
		const string selSubscriptionsWithDelegate_ = "subscriptionsWithDelegate:";
		static readonly IntPtr selSubscriptionsWithDelegate_Handle = Selector.GetHandle ("subscriptionsWithDelegate:");
		[CompilerGenerated]
		const string selSubscriptionsWithDelegateContext_ = "subscriptionsWithDelegate:context:";
		static readonly IntPtr selSubscriptionsWithDelegateContext_Handle = Selector.GetHandle ("subscriptionsWithDelegate:context:");
		[CompilerGenerated]
		const string selTRegisterSubscriptionWithDelegate_ = "TRegisterSubscriptionWithDelegate:";
		static readonly IntPtr selTRegisterSubscriptionWithDelegate_Handle = Selector.GetHandle ("TRegisterSubscriptionWithDelegate:");
		[CompilerGenerated]
		const string selTRegisterSubscriptionWithDelegateContext_ = "TRegisterSubscriptionWithDelegate:context:";
		static readonly IntPtr selTRegisterSubscriptionWithDelegateContext_Handle = Selector.GetHandle ("TRegisterSubscriptionWithDelegate:context:");
		[CompilerGenerated]
		const string selTSendPushToUsersDelegate_ = "TSendPush:toUsers:delegate:";
		static readonly IntPtr selTSendPushToUsersDelegate_Handle = Selector.GetHandle ("TSendPush:toUsers:delegate:");
		[CompilerGenerated]
		const string selTSendPushToUsersDelegateContext_ = "TSendPush:toUsers:delegate:context:";
		static readonly IntPtr selTSendPushToUsersDelegateContext_Handle = Selector.GetHandle ("TSendPush:toUsers:delegate:context:");
		[CompilerGenerated]
		const string selTSendPushToUsersIsDevelopmentEnvironmentDelegate_ = "TSendPush:toUsers:isDevelopmentEnvironment:delegate:";
		static readonly IntPtr selTSendPushToUsersIsDevelopmentEnvironmentDelegate_Handle = Selector.GetHandle ("TSendPush:toUsers:isDevelopmentEnvironment:delegate:");
		[CompilerGenerated]
		const string selTSendPushToUsersIsDevelopmentEnvironmentDelegateContext_ = "TSendPush:toUsers:isDevelopmentEnvironment:delegate:context:";
		static readonly IntPtr selTSendPushToUsersIsDevelopmentEnvironmentDelegateContext_Handle = Selector.GetHandle ("TSendPush:toUsers:isDevelopmentEnvironment:delegate:context:");
		[CompilerGenerated]
		const string selTSendPushToUsersWithAnyOfTheseTagsDelegate_ = "TSendPush:toUsersWithAnyOfTheseTags:delegate:";
		static readonly IntPtr selTSendPushToUsersWithAnyOfTheseTagsDelegate_Handle = Selector.GetHandle ("TSendPush:toUsersWithAnyOfTheseTags:delegate:");
		[CompilerGenerated]
		const string selTSendPushToUsersWithAnyOfTheseTagsDelegateContext_ = "TSendPush:toUsersWithAnyOfTheseTags:delegate:context:";
		static readonly IntPtr selTSendPushToUsersWithAnyOfTheseTagsDelegateContext_Handle = Selector.GetHandle ("TSendPush:toUsersWithAnyOfTheseTags:delegate:context:");
		[CompilerGenerated]
		const string selTSendPushToUsersWithAnyOfTheseTagsIsDevelopmentEnvironmentDelegate_ = "TSendPush:toUsersWithAnyOfTheseTags:isDevelopmentEnvironment:delegate:";
		static readonly IntPtr selTSendPushToUsersWithAnyOfTheseTagsIsDevelopmentEnvironmentDelegate_Handle = Selector.GetHandle ("TSendPush:toUsersWithAnyOfTheseTags:isDevelopmentEnvironment:delegate:");
		[CompilerGenerated]
		const string selTSendPushToUsersWithAnyOfTheseTagsIsDevelopmentEnvironmentDelegateContext_ = "TSendPush:toUsersWithAnyOfTheseTags:isDevelopmentEnvironment:delegate:context:";
		static readonly IntPtr selTSendPushToUsersWithAnyOfTheseTagsIsDevelopmentEnvironmentDelegateContext_Handle = Selector.GetHandle ("TSendPush:toUsersWithAnyOfTheseTags:isDevelopmentEnvironment:delegate:context:");
		[CompilerGenerated]
		const string selTSendPushWithTextToUsersDelegate_ = "TSendPushWithText:toUsers:delegate:";
		static readonly IntPtr selTSendPushWithTextToUsersDelegate_Handle = Selector.GetHandle ("TSendPushWithText:toUsers:delegate:");
		[CompilerGenerated]
		const string selTSendPushWithTextToUsersDelegateContext_ = "TSendPushWithText:toUsers:delegate:context:";
		static readonly IntPtr selTSendPushWithTextToUsersDelegateContext_Handle = Selector.GetHandle ("TSendPushWithText:toUsers:delegate:context:");
		[CompilerGenerated]
		const string selTSendPushWithTextToUsersWithAnyOfTheseTagsDelegate_ = "TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:";
		static readonly IntPtr selTSendPushWithTextToUsersWithAnyOfTheseTagsDelegate_Handle = Selector.GetHandle ("TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:");
		[CompilerGenerated]
		const string selTSendPushWithTextToUsersWithAnyOfTheseTagsDelegateContext_ = "TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:context:";
		static readonly IntPtr selTSendPushWithTextToUsersWithAnyOfTheseTagsDelegateContext_Handle = Selector.GetHandle ("TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:context:");
		[CompilerGenerated]
		const string selTUnregisterSubscriptionWithDelegate_ = "TUnregisterSubscriptionWithDelegate:";
		static readonly IntPtr selTUnregisterSubscriptionWithDelegate_Handle = Selector.GetHandle ("TUnregisterSubscriptionWithDelegate:");
		[CompilerGenerated]
		const string selTUnregisterSubscriptionWithDelegateContext_ = "TUnregisterSubscriptionWithDelegate:context:";
		static readonly IntPtr selTUnregisterSubscriptionWithDelegateContext_Handle = Selector.GetHandle ("TUnregisterSubscriptionWithDelegate:context:");
		[CompilerGenerated]
		const string selUpdateEventDelegate_ = "updateEvent:delegate:";
		static readonly IntPtr selUpdateEventDelegate_Handle = Selector.GetHandle ("updateEvent:delegate:");
		[CompilerGenerated]
		const string selUpdateEventDelegateContext_ = "updateEvent:delegate:context:";
		static readonly IntPtr selUpdateEventDelegateContext_Handle = Selector.GetHandle ("updateEvent:delegate:context:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMessages");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMessages () : base (NSObjectFlag.Empty)
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
		public QBMessages (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMessages (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMessages (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("createEvent:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateEvent (QBMEvent evt, QBActionStatusDelegate del)
		{
			if (evt == null)
				throw new ArgumentNullException ("evt");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateEventDelegate_Handle, evt.Handle, del.Handle));
		}
		
		[Export ("createEvent:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateEvent (QBMEvent evt, QBActionStatusDelegate del, NSObject context)
		{
			if (evt == null)
				throw new ArgumentNullException ("evt");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateEventDelegateContext_Handle, evt.Handle, del.Handle, context.Handle));
		}
		
		[Export ("createPushToken:delegate:")]
		[CompilerGenerated]
		public static NSObject CreatePushToken (QBMPushToken pushToken, QBActionStatusDelegate del)
		{
			if (pushToken == null)
				throw new ArgumentNullException ("pushToken");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreatePushTokenDelegate_Handle, pushToken.Handle, del.Handle));
		}
		
		[Export ("createPushToken:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreatePushToken (QBMPushToken pushToken, QBActionStatusDelegate del, NSObject context)
		{
			if (pushToken == null)
				throw new ArgumentNullException ("pushToken");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreatePushTokenDelegateContext_Handle, pushToken.Handle, del.Handle, context.Handle));
		}
		
		[Export ("createSubscription:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateSubscription (QBMSubscription subscriber, QBActionStatusDelegate del)
		{
			if (subscriber == null)
				throw new ArgumentNullException ("subscriber");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateSubscriptionDelegate_Handle, subscriber.Handle, del.Handle));
		}
		
		[Export ("createSubscription:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateSubscription (QBMSubscription subscriber, QBActionStatusDelegate del, NSObject context)
		{
			if (subscriber == null)
				throw new ArgumentNullException ("subscriber");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateSubscriptionDelegateContext_Handle, subscriber.Handle, del.Handle, context.Handle));
		}
		
		[Export ("deleteEventWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteEventWithID (global::System.UInt32 ID, QBActionStatusDelegate del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeleteEventWithIDDelegate_Handle, ID, del.Handle));
		}
		
		[Export ("deleteEventWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteEventWithID (global::System.UInt32 ID, QBActionStatusDelegate del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeleteEventWithIDDelegateContext_Handle, ID, del.Handle, context.Handle));
		}
		
		[Export ("deletePushTokenWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeletePushTokenWithID (global::System.UInt32 ID, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeletePushTokenWithIDDelegate_Handle, ID, del.Handle));
		}
		
		[Export ("deletePushTokenWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeletePushTokenWithID (global::System.UInt32 ID, QBActionStatusDelegate del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeletePushTokenWithIDDelegateContext_Handle, ID, del.Handle, context.Handle));
		}
		
		[Export ("deleteSubscriptionWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteSubscriptionWithID (global::System.UInt32 ID, QBActionStatusDelegate del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeleteSubscriptionWithIDDelegate_Handle, ID, del.Handle));
		}
		
		[Export ("deleteSubscriptionWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteSubscriptionWithID (global::System.UInt32 ID, QBActionStatusDelegate del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeleteSubscriptionWithIDDelegateContext_Handle, ID, del.Handle, context.Handle));
		}
		
		[Export ("eventsWithDelegate:")]
		[CompilerGenerated]
		public static NSObject EventsWithDelegate (QBActionStatusDelegate del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selEventsWithDelegate_Handle, del.Handle));
		}
		
		[Export ("eventsWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject EventsWithDelegate (QBActionStatusDelegate del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selEventsWithDelegateContext_Handle, del.Handle, context.Handle));
		}
		
		[Export ("eventsWithPagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject EventsWithPagedRequest (PagedRequest pagedRequest, QBActionStatusDelegate del)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selEventsWithPagedRequestDelegate_Handle, pagedRequest.Handle, del.Handle));
		}
		
		[Export ("eventsWithPagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject EventsWithPagedRequest (PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selEventsWithPagedRequestDelegateContext_Handle, pagedRequest.Handle, del.Handle, context.Handle));
		}
		
		[Export ("eventWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject EventWithID (global::System.UInt32 ID, QBActionStatusDelegate del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selEventWithIDDelegate_Handle, ID, del.Handle));
		}
		
		[Export ("eventWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject EventWithID (global::System.UInt32 ID, QBActionStatusDelegate del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selEventWithIDDelegateContext_Handle, ID, del.Handle, context.Handle));
		}
		
		[Export ("pullEventsWithDelegate:")]
		[CompilerGenerated]
		public static NSObject PullEventsWithDelegate (QBActionStatusDelegate del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selPullEventsWithDelegate_Handle, del.Handle));
		}
		
		[Export ("pullEventsWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject PullEventsWithDelegate (QBActionStatusDelegate del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selPullEventsWithDelegateContext_Handle, del.Handle, context.Handle));
		}
		
		[Export ("subscriptionsWithDelegate:")]
		[CompilerGenerated]
		public static NSObject SubscriptionsWithDelegate (QBActionStatusDelegate del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selSubscriptionsWithDelegate_Handle, del.Handle));
		}
		
		[Export ("subscriptionsWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject SubscriptionsWithDelegate (QBActionStatusDelegate del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selSubscriptionsWithDelegateContext_Handle, del.Handle, context.Handle));
		}
		
		[Export ("TRegisterSubscriptionWithDelegate:")]
		[CompilerGenerated]
		public static NSObject TRegisterSubscriptionWithDelegate (QBActionStatusDelegate del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selTRegisterSubscriptionWithDelegate_Handle, del.Handle));
		}
		
		[Export ("TRegisterSubscriptionWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject TRegisterSubscriptionWithDelegate (QBActionStatusDelegate del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selTRegisterSubscriptionWithDelegateContext_Handle, del.Handle, context.Handle));
		}
		
		[Export ("TSendPush:toUsers:delegate:")]
		[CompilerGenerated]
		public static NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, QBActionStatusDelegate del)
		{
			if (pushMessage == null)
				throw new ArgumentNullException ("pushMessage");
			if (usersIDs == null)
				throw new ArgumentNullException ("usersIDs");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsusersIDs = NSString.CreateNative (usersIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selTSendPushToUsersDelegate_Handle, pushMessage.Handle, nsusersIDs, del.Handle));
			NSString.ReleaseNative (nsusersIDs);
			
			return ret;
		}
		
		[Export ("TSendPush:toUsers:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, QBActionStatusDelegate del, NSObject context)
		{
			if (pushMessage == null)
				throw new ArgumentNullException ("pushMessage");
			if (usersIDs == null)
				throw new ArgumentNullException ("usersIDs");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsusersIDs = NSString.CreateNative (usersIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selTSendPushToUsersDelegateContext_Handle, pushMessage.Handle, nsusersIDs, del.Handle, context.Handle));
			NSString.ReleaseNative (nsusersIDs);
			
			return ret;
		}
		
		[Export ("TSendPush:toUsers:isDevelopmentEnvironment:delegate:")]
		[CompilerGenerated]
		public static NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, bool isDevelopmentEnvironment, QBActionStatusDelegate del)
		{
			if (pushMessage == null)
				throw new ArgumentNullException ("pushMessage");
			if (usersIDs == null)
				throw new ArgumentNullException ("usersIDs");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsusersIDs = NSString.CreateNative (usersIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool_IntPtr (class_ptr, selTSendPushToUsersIsDevelopmentEnvironmentDelegate_Handle, pushMessage.Handle, nsusersIDs, isDevelopmentEnvironment, del.Handle));
			NSString.ReleaseNative (nsusersIDs);
			
			return ret;
		}
		
		[Export ("TSendPush:toUsers:isDevelopmentEnvironment:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, bool isDevelopmentEnvironment, QBActionStatusDelegate del, NSObject context)
		{
			if (pushMessage == null)
				throw new ArgumentNullException ("pushMessage");
			if (usersIDs == null)
				throw new ArgumentNullException ("usersIDs");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsusersIDs = NSString.CreateNative (usersIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool_IntPtr_IntPtr (class_ptr, selTSendPushToUsersIsDevelopmentEnvironmentDelegateContext_Handle, pushMessage.Handle, nsusersIDs, isDevelopmentEnvironment, del.Handle, context.Handle));
			NSString.ReleaseNative (nsusersIDs);
			
			return ret;
		}
		
		[Export ("TSendPush:toUsersWithAnyOfTheseTags:isDevelopmentEnvironment:delegate:")]
		[CompilerGenerated]
		public static NSObject TSendPushWithAnyOfTags (QBMPushMessage pushMessage, string usersTags, bool isDevelopmentEnvironment, QBActionStatusDelegate del)
		{
			if (pushMessage == null)
				throw new ArgumentNullException ("pushMessage");
			if (usersTags == null)
				throw new ArgumentNullException ("usersTags");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsusersTags = NSString.CreateNative (usersTags);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool_IntPtr (class_ptr, selTSendPushToUsersWithAnyOfTheseTagsIsDevelopmentEnvironmentDelegate_Handle, pushMessage.Handle, nsusersTags, isDevelopmentEnvironment, del.Handle));
			NSString.ReleaseNative (nsusersTags);
			
			return ret;
		}
		
		[Export ("TSendPush:toUsersWithAnyOfTheseTags:isDevelopmentEnvironment:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TSendPushWithAnyOfTags (QBMPushMessage pushMessage, string usersTags, bool isDevelopmentEnvironment, QBActionStatusDelegate del, NSObject context)
		{
			if (pushMessage == null)
				throw new ArgumentNullException ("pushMessage");
			if (usersTags == null)
				throw new ArgumentNullException ("usersTags");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsusersTags = NSString.CreateNative (usersTags);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool_IntPtr_IntPtr (class_ptr, selTSendPushToUsersWithAnyOfTheseTagsIsDevelopmentEnvironmentDelegateContext_Handle, pushMessage.Handle, nsusersTags, isDevelopmentEnvironment, del.Handle, context.Handle));
			NSString.ReleaseNative (nsusersTags);
			
			return ret;
		}
		
		[Export ("TSendPush:toUsersWithAnyOfTheseTags:delegate:")]
		[CompilerGenerated]
		public static NSObject TSendPushWithTags (QBMPushMessage pushMessage, string usersTags, QBActionStatusDelegate del)
		{
			if (pushMessage == null)
				throw new ArgumentNullException ("pushMessage");
			if (usersTags == null)
				throw new ArgumentNullException ("usersTags");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nsusersTags = NSString.CreateNative (usersTags);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selTSendPushToUsersWithAnyOfTheseTagsDelegate_Handle, pushMessage.Handle, nsusersTags, del.Handle));
			NSString.ReleaseNative (nsusersTags);
			
			return ret;
		}
		
		[Export ("TSendPush:toUsersWithAnyOfTheseTags:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TSendPushWithTags (QBMPushMessage pushMessage, string usersTags, QBActionStatusDelegate del, NSObject context)
		{
			if (pushMessage == null)
				throw new ArgumentNullException ("pushMessage");
			if (usersTags == null)
				throw new ArgumentNullException ("usersTags");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsusersTags = NSString.CreateNative (usersTags);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selTSendPushToUsersWithAnyOfTheseTagsDelegateContext_Handle, pushMessage.Handle, nsusersTags, del.Handle, context.Handle));
			NSString.ReleaseNative (nsusersTags);
			
			return ret;
		}
		
		[Export ("TSendPushWithText:toUsers:delegate:")]
		[CompilerGenerated]
		public static NSObject TSendPushWithText (string text, string usersIDs, QBActionStatusDelegate del)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			if (usersIDs == null)
				throw new ArgumentNullException ("usersIDs");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nstext = NSString.CreateNative (text);
			var nsusersIDs = NSString.CreateNative (usersIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selTSendPushWithTextToUsersDelegate_Handle, nstext, nsusersIDs, del.Handle));
			NSString.ReleaseNative (nstext);
			NSString.ReleaseNative (nsusersIDs);
			
			return ret;
		}
		
		[Export ("TSendPushWithText:toUsers:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TSendPushWithText (string text, string usersIDs, QBActionStatusDelegate del, NSObject context)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			if (usersIDs == null)
				throw new ArgumentNullException ("usersIDs");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nstext = NSString.CreateNative (text);
			var nsusersIDs = NSString.CreateNative (usersIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selTSendPushWithTextToUsersDelegateContext_Handle, nstext, nsusersIDs, del.Handle, context.Handle));
			NSString.ReleaseNative (nstext);
			NSString.ReleaseNative (nsusersIDs);
			
			return ret;
		}
		
		[Export ("TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:")]
		[CompilerGenerated]
		public static NSObject TSendPushWithTextWithTags (string text, string usersTags, QBActionStatusDelegate del)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			if (usersTags == null)
				throw new ArgumentNullException ("usersTags");
			if (del == null)
				throw new ArgumentNullException ("del");
			var nstext = NSString.CreateNative (text);
			var nsusersTags = NSString.CreateNative (usersTags);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selTSendPushWithTextToUsersWithAnyOfTheseTagsDelegate_Handle, nstext, nsusersTags, del.Handle));
			NSString.ReleaseNative (nstext);
			NSString.ReleaseNative (nsusersTags);
			
			return ret;
		}
		
		[Export ("TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:context:")]
		[CompilerGenerated]
		public static NSObject TSendPushWithTextWithTags (string text, string usersTags, QBActionStatusDelegate del, NSObject context)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			if (usersTags == null)
				throw new ArgumentNullException ("usersTags");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nstext = NSString.CreateNative (text);
			var nsusersTags = NSString.CreateNative (usersTags);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selTSendPushWithTextToUsersWithAnyOfTheseTagsDelegateContext_Handle, nstext, nsusersTags, del.Handle, context.Handle));
			NSString.ReleaseNative (nstext);
			NSString.ReleaseNative (nsusersTags);
			
			return ret;
		}
		
		[Export ("TUnregisterSubscriptionWithDelegate:")]
		[CompilerGenerated]
		public static NSObject TUnregisterSubscriptionWithDelegate (QBActionStatusDelegate del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selTUnregisterSubscriptionWithDelegate_Handle, del.Handle));
		}
		
		[Export ("TUnregisterSubscriptionWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject TUnregisterSubscriptionWithDelegate (QBActionStatusDelegate del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selTUnregisterSubscriptionWithDelegateContext_Handle, del.Handle, context.Handle));
		}
		
		[Export ("updateEvent:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateEvent (QBMEvent evt, QBActionStatusDelegate del)
		{
			if (evt == null)
				throw new ArgumentNullException ("evt");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdateEventDelegate_Handle, evt.Handle, del.Handle));
		}
		
		[Export ("updateEvent:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateEvent (QBMEvent evt, QBActionStatusDelegate del, NSObject context)
		{
			if (evt == null)
				throw new ArgumentNullException ("evt");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateEventDelegateContext_Handle, evt.Handle, del.Handle, context.Handle));
		}
		
	} /* class QBMessages */
}
