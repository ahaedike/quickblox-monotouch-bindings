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
	[Register("QBRequest", true)]
	public unsafe partial class QBRequest : NSObject {
		[CompilerGenerated]
		const string selCreateEventSuccessBlockErrorBlock_ = "createEvent:successBlock:errorBlock:";
		static readonly IntPtr selCreateEventSuccessBlockErrorBlock_Handle = Selector.GetHandle ("createEvent:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selCreatePushTokenSuccessBlockErrorBlock_ = "createPushToken:successBlock:errorBlock:";
		static readonly IntPtr selCreatePushTokenSuccessBlockErrorBlock_Handle = Selector.GetHandle ("createPushToken:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selCreateSessionWithExtendedParametersSuccessBlockErrorBlock_ = "createSessionWithExtendedParameters:successBlock:errorBlock:";
		static readonly IntPtr selCreateSessionWithExtendedParametersSuccessBlockErrorBlock_Handle = Selector.GetHandle ("createSessionWithExtendedParameters:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selCreateSubscriptionSuccessBlockErrorBlock_ = "createSubscription:successBlock:errorBlock:";
		static readonly IntPtr selCreateSubscriptionSuccessBlockErrorBlock_Handle = Selector.GetHandle ("createSubscription:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selDeleteEventWithIDSuccessBlockErrorBlock_ = "deleteEventWithID:successBlock:errorBlock:";
		static readonly IntPtr selDeleteEventWithIDSuccessBlockErrorBlock_Handle = Selector.GetHandle ("deleteEventWithID:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selDeletePushTokenWithIDSuccessBlockErrorBlock_ = "deletePushTokenWithID:successBlock:errorBlock:";
		static readonly IntPtr selDeletePushTokenWithIDSuccessBlockErrorBlock_Handle = Selector.GetHandle ("deletePushTokenWithID:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selDeleteSubscriptionWithIDSuccessBlockErrorBlock_ = "deleteSubscriptionWithID:successBlock:errorBlock:";
		static readonly IntPtr selDeleteSubscriptionWithIDSuccessBlockErrorBlock_Handle = Selector.GetHandle ("deleteSubscriptionWithID:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selEventsForPageSuccessBlockErrorBlock_ = "eventsForPage:successBlock:errorBlock:";
		static readonly IntPtr selEventsForPageSuccessBlockErrorBlock_Handle = Selector.GetHandle ("eventsForPage:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selEventWithIDSuccessBlockErrorBlock_ = "eventWithID:successBlock:errorBlock:";
		static readonly IntPtr selEventWithIDSuccessBlockErrorBlock_Handle = Selector.GetHandle ("eventWithID:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selRegisterSubscriptionForDeviceTokenSuccessBlockErrorBlock_ = "registerSubscriptionForDeviceToken:successBlock:errorBlock:";
		static readonly IntPtr selRegisterSubscriptionForDeviceTokenSuccessBlockErrorBlock_Handle = Selector.GetHandle ("registerSubscriptionForDeviceToken:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selSendPushToUsersSuccessBlockErrorBlock_ = "sendPush:toUsers:successBlock:errorBlock:";
		static readonly IntPtr selSendPushToUsersSuccessBlockErrorBlock_Handle = Selector.GetHandle ("sendPush:toUsers:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selSendPushToUsersWithAnyOfTheseTagsSuccessBlockErrorBlock_ = "sendPush:toUsersWithAnyOfTheseTags:successBlock:errorBlock:";
		static readonly IntPtr selSendPushToUsersWithAnyOfTheseTagsSuccessBlockErrorBlock_Handle = Selector.GetHandle ("sendPush:toUsersWithAnyOfTheseTags:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selSendPushWithTextToUsersSuccessBlockErrorBlock_ = "sendPushWithText:toUsers:successBlock:errorBlock:";
		static readonly IntPtr selSendPushWithTextToUsersSuccessBlockErrorBlock_Handle = Selector.GetHandle ("sendPushWithText:toUsers:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selSendPushWithTextToUsersWithAnyOfTheseTagsSuccessBlockErrorBlock_ = "sendPushWithText:toUsersWithAnyOfTheseTags:successBlock:errorBlock:";
		static readonly IntPtr selSendPushWithTextToUsersWithAnyOfTheseTagsSuccessBlockErrorBlock_Handle = Selector.GetHandle ("sendPushWithText:toUsersWithAnyOfTheseTags:successBlock:errorBlock:");
		[CompilerGenerated]
		const string selSubscriptionsWithSuccessBlockErrorBlock_ = "subscriptionsWithSuccessBlock:errorBlock:";
		static readonly IntPtr selSubscriptionsWithSuccessBlockErrorBlock_Handle = Selector.GetHandle ("subscriptionsWithSuccessBlock:errorBlock:");
		[CompilerGenerated]
		const string selUnregisterSubscriptionWithSuccessBlockErrorBlock_ = "unregisterSubscriptionWithSuccessBlock:errorBlock:";
		static readonly IntPtr selUnregisterSubscriptionWithSuccessBlockErrorBlock_Handle = Selector.GetHandle ("unregisterSubscriptionWithSuccessBlock:errorBlock:");
		[CompilerGenerated]
		const string selUpdateEventSuccessBlockErrorBlock_ = "updateEvent:successBlock:errorBlock:";
		static readonly IntPtr selUpdateEventSuccessBlockErrorBlock_Handle = Selector.GetHandle ("updateEvent:successBlock:errorBlock:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBRequest () : base (NSObjectFlag.Empty)
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
		public QBRequest (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("createEvent:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void CreateEvent (QBMEvent evnt, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseEventsCallback))]ResponseEventsCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (evnt == null)
				throw new ArgumentNullException ("evnt");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseEventsCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateEventSuccessBlockErrorBlock_Handle, evnt.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("createPushToken:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void CreatePushToken (QBMPushToken pushToken, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseTokenCallback))]ResponseTokenCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (pushToken == null)
				throw new ArgumentNullException ("pushToken");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseTokenCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreatePushTokenSuccessBlockErrorBlock_Handle, pushToken.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("createSessionWithExtendedParameters:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void CreateSession (QBSessionParameters parameters, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDSessionCallback))]SessionCallback success, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseCallback))]ResponseCallback error)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (error == null)
				throw new ArgumentNullException ("error");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDSessionCallback.Handler, success);
			BlockLiteral *block_ptr_error;
			BlockLiteral block_error;
			block_error = new BlockLiteral ();
			block_ptr_error = &block_error;
			block_error.SetupBlock (Trampolines.SDResponseCallback.Handler, error);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateSessionWithExtendedParametersSuccessBlockErrorBlock_Handle, parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_error);
			block_ptr_success->CleanupBlock ();
			block_ptr_error->CleanupBlock ();
			
		}
		
		[Export ("createSubscription:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void CreateSubscription (QBMSubscription subscriber, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseSubscribeCallback))]ResponseSubscribeCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (subscriber == null)
				throw new ArgumentNullException ("subscriber");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseSubscribeCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateSubscriptionSuccessBlockErrorBlock_Handle, subscriber.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("deleteEventWithID:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void DeleteEventWithID (global::System.UInt32 ID, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseCallback))]ResponseCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeleteEventWithIDSuccessBlockErrorBlock_Handle, ID, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("deletePushTokenWithID:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void DeletePushTokenWithID (global::System.UInt32 ID, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseCallback))]ResponseCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeletePushTokenWithIDSuccessBlockErrorBlock_Handle, ID, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("deleteSubscriptionWithID:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void DeleteSubscriptionWithID (global::System.UInt32 ID, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseCallback))]ResponseCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeleteSubscriptionWithIDSuccessBlockErrorBlock_Handle, ID, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("eventsForPage:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void EventsForPage (QBGeneralResponsePage page, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponsePageEventsCallback))]ResponsePageEventsCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (page == null)
				throw new ArgumentNullException ("page");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponsePageEventsCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selEventsForPageSuccessBlockErrorBlock_Handle, page.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("eventWithID:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void EventWithID (global::System.UInt32 ID, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseEventCallback))]ResponseEventCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseEventCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selEventWithIDSuccessBlockErrorBlock_Handle, ID, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("registerSubscriptionForDeviceToken:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void RegisterSubscriptionForDeviceToken (NSData deviceToken, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseSubscribeCallback))]ResponseSubscribeCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (deviceToken == null)
				throw new ArgumentNullException ("deviceToken");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseSubscribeCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selRegisterSubscriptionForDeviceTokenSuccessBlockErrorBlock_Handle, deviceToken.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("sendPush:toUsers:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void SendPushToUsers (QBMPushMessage pushMessage, string usersIDs, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseEventCallback))]ResponseEventCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (pushMessage == null)
				throw new ArgumentNullException ("pushMessage");
			if (usersIDs == null)
				throw new ArgumentNullException ("usersIDs");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			var nsusersIDs = NSString.CreateNative (usersIDs);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseEventCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selSendPushToUsersSuccessBlockErrorBlock_Handle, pushMessage.Handle, nsusersIDs, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			NSString.ReleaseNative (nsusersIDs);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("sendPush:toUsersWithAnyOfTheseTags:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void SendPushToUsersWithTags (QBMPushMessage pushMessage, string usersTags, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseEventCallback))]ResponseEventCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (pushMessage == null)
				throw new ArgumentNullException ("pushMessage");
			if (usersTags == null)
				throw new ArgumentNullException ("usersTags");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			var nsusersTags = NSString.CreateNative (usersTags);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseEventCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selSendPushToUsersWithAnyOfTheseTagsSuccessBlockErrorBlock_Handle, pushMessage.Handle, nsusersTags, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			NSString.ReleaseNative (nsusersTags);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("sendPushWithText:toUsers:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void SendPushWithText (string text, string usersIDs, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseEventsCallback))]ResponseEventsCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			if (usersIDs == null)
				throw new ArgumentNullException ("usersIDs");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			var nstext = NSString.CreateNative (text);
			var nsusersIDs = NSString.CreateNative (usersIDs);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseEventsCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selSendPushWithTextToUsersSuccessBlockErrorBlock_Handle, nstext, nsusersIDs, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			NSString.ReleaseNative (nstext);
			NSString.ReleaseNative (nsusersIDs);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("sendPushWithText:toUsersWithAnyOfTheseTags:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void SendPushWithTextToUsersWithTaqgs (string text, string usersTags, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseEventsCallback))]ResponseEventsCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			if (usersTags == null)
				throw new ArgumentNullException ("usersTags");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			var nstext = NSString.CreateNative (text);
			var nsusersTags = NSString.CreateNative (usersTags);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseEventsCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selSendPushWithTextToUsersWithAnyOfTheseTagsSuccessBlockErrorBlock_Handle, nstext, nsusersTags, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			NSString.ReleaseNative (nstext);
			NSString.ReleaseNative (nsusersTags);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("subscriptionsWithSuccessBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void Subscriptions ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseSubscribeCallback))]ResponseSubscribeCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseSubscribeCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selSubscriptionsWithSuccessBlockErrorBlock_Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("unregisterSubscriptionWithSuccessBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void UnregisterSubscriptionWithSuccessBlock ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseCallback))]ResponseCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selUnregisterSubscriptionWithSuccessBlockErrorBlock_Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
		[Export ("updateEvent:successBlock:errorBlock:")]
		[CompilerGenerated]
		public unsafe static void UpdateEvent (QBMEvent evnt, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDResponseEventCallback))]ResponseEventCallback successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDQBErrorBlock))]QBErrorBlock errorBlock)
		{
			if (evnt == null)
				throw new ArgumentNullException ("evnt");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDResponseEventCallback.Handler, successBlock);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDQBErrorBlock.Handler, errorBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateEventSuccessBlockErrorBlock_Handle, evnt.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_errorBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_errorBlock->CleanupBlock ();
			
		}
		
	} /* class QBRequest */
	public delegate void QBErrorBlock (QBError error);
	public delegate void ResponseCallback (QBResponse response);
	public delegate void ResponseEventCallback (QBResponse response, QBMEvent evnt);
	public delegate void ResponseEventsCallback (QBResponse response, NSObject[] evnts);
	public delegate void ResponsePageEventsCallback (QBResponse response, QBGeneralResponsePage page, NSObject[] evnts);
	public delegate void ResponseSubscribeCallback (QBResponse response, NSObject[] subscribers);
	public delegate void ResponseTokenCallback (QBResponse response, QBMPushToken token);
	public delegate void SessionCallback (QBResponse response, QBASession session);
}
