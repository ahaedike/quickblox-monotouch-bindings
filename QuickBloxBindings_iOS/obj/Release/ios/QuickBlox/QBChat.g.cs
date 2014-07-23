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
	[Register("QBChat", true)]
	public unsafe partial class QBChat : NSObject {
		[CompilerGenerated]
		const string selAddUsersToRoom_ = "addUsers:toRoom:";
		static readonly IntPtr selAddUsersToRoom_Handle = Selector.GetHandle ("addUsers:toRoom:");
		[CompilerGenerated]
		const string selAddUserToContactListRequest_ = "addUserToContactListRequest:";
		static readonly IntPtr selAddUserToContactListRequest_Handle = Selector.GetHandle ("addUserToContactListRequest:");
		[CompilerGenerated]
		const string selConfirmAddContactRequest_ = "confirmAddContactRequest:";
		static readonly IntPtr selConfirmAddContactRequest_Handle = Selector.GetHandle ("confirmAddContactRequest:");
		[CompilerGenerated]
		const string selContactList = "contactList";
		static readonly IntPtr selContactListHandle = Selector.GetHandle ("contactList");
		[CompilerGenerated]
		const string selCreateAndRegisterVideoChatInstance = "createAndRegisterVideoChatInstance";
		static readonly IntPtr selCreateAndRegisterVideoChatInstanceHandle = Selector.GetHandle ("createAndRegisterVideoChatInstance");
		[CompilerGenerated]
		const string selCreateAndRegisterVideoChatInstanceWithSessionID_ = "createAndRegisterVideoChatInstanceWithSessionID:";
		static readonly IntPtr selCreateAndRegisterVideoChatInstanceWithSessionID_Handle = Selector.GetHandle ("createAndRegisterVideoChatInstanceWithSessionID:");
		[CompilerGenerated]
		const string selCreateDialogDelegate_ = "createDialog:delegate:";
		static readonly IntPtr selCreateDialogDelegate_Handle = Selector.GetHandle ("createDialog:delegate:");
		[CompilerGenerated]
		const string selCreateDialogDelegateContext_ = "createDialog:delegate:context:";
		static readonly IntPtr selCreateDialogDelegateContext_Handle = Selector.GetHandle ("createDialog:delegate:context:");
		[CompilerGenerated]
		const string selCreateOrJoinRoomWithJIDMembersOnlyPersistentHistoryAttribute_ = "createOrJoinRoomWithJID:membersOnly:persistent:historyAttribute:";
		static readonly IntPtr selCreateOrJoinRoomWithJIDMembersOnlyPersistentHistoryAttribute_Handle = Selector.GetHandle ("createOrJoinRoomWithJID:membersOnly:persistent:historyAttribute:");
		[CompilerGenerated]
		const string selCreateOrJoinRoomWithJIDNicknameMembersOnlyPersistentHistoryAttribute_ = "createOrJoinRoomWithJID:nickname:membersOnly:persistent:historyAttribute:";
		static readonly IntPtr selCreateOrJoinRoomWithJIDNicknameMembersOnlyPersistentHistoryAttribute_Handle = Selector.GetHandle ("createOrJoinRoomWithJID:nickname:membersOnly:persistent:historyAttribute:");
		[CompilerGenerated]
		const string selCreateOrJoinRoomWithNameMembersOnlyPersistent_ = "createOrJoinRoomWithName:membersOnly:persistent:";
		static readonly IntPtr selCreateOrJoinRoomWithNameMembersOnlyPersistent_Handle = Selector.GetHandle ("createOrJoinRoomWithName:membersOnly:persistent:");
		[CompilerGenerated]
		const string selCreateOrJoinRoomWithNameNicknameMembersOnlyPersistent_ = "createOrJoinRoomWithName:nickname:membersOnly:persistent:";
		static readonly IntPtr selCreateOrJoinRoomWithNameNicknameMembersOnlyPersistent_Handle = Selector.GetHandle ("createOrJoinRoomWithName:nickname:membersOnly:persistent:");
		[CompilerGenerated]
		const string selCurrentUser = "currentUser";
		static readonly IntPtr selCurrentUserHandle = Selector.GetHandle ("currentUser");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selDeleteMessageWithIDDelegate_ = "deleteMessageWithID:delegate:";
		static readonly IntPtr selDeleteMessageWithIDDelegate_Handle = Selector.GetHandle ("deleteMessageWithID:delegate:");
		[CompilerGenerated]
		const string selDeleteMessageWithIDDelegateContext_ = "deleteMessageWithID:delegate:context:";
		static readonly IntPtr selDeleteMessageWithIDDelegateContext_Handle = Selector.GetHandle ("deleteMessageWithID:delegate:context:");
		[CompilerGenerated]
		const string selDeleteUsersFromRoom_ = "deleteUsers:fromRoom:";
		static readonly IntPtr selDeleteUsersFromRoom_Handle = Selector.GetHandle ("deleteUsers:fromRoom:");
		[CompilerGenerated]
		const string selDestroyRoom_ = "destroyRoom:";
		static readonly IntPtr selDestroyRoom_Handle = Selector.GetHandle ("destroyRoom:");
		[CompilerGenerated]
		const string selDialogsWithDelegate_ = "dialogsWithDelegate:";
		static readonly IntPtr selDialogsWithDelegate_Handle = Selector.GetHandle ("dialogsWithDelegate:");
		[CompilerGenerated]
		const string selDialogsWithDelegateContext_ = "dialogsWithDelegate:context:";
		static readonly IntPtr selDialogsWithDelegateContext_Handle = Selector.GetHandle ("dialogsWithDelegate:context:");
		[CompilerGenerated]
		const string selDialogsWithExtendedRequestDelegate_ = "dialogsWithExtendedRequest:delegate:";
		static readonly IntPtr selDialogsWithExtendedRequestDelegate_Handle = Selector.GetHandle ("dialogsWithExtendedRequest:delegate:");
		[CompilerGenerated]
		const string selDialogsWithExtendedRequestDelegateContext_ = "dialogsWithExtendedRequest:delegate:context:";
		static readonly IntPtr selDialogsWithExtendedRequestDelegateContext_Handle = Selector.GetHandle ("dialogsWithExtendedRequest:delegate:context:");
		[CompilerGenerated]
		const string selInstance = "instance";
		static readonly IntPtr selInstanceHandle = Selector.GetHandle ("instance");
		[CompilerGenerated]
		const string selIsLoggedIn = "isLoggedIn";
		static readonly IntPtr selIsLoggedInHandle = Selector.GetHandle ("isLoggedIn");
		[CompilerGenerated]
		const string selJoinRoom_ = "joinRoom:";
		static readonly IntPtr selJoinRoom_Handle = Selector.GetHandle ("joinRoom:");
		[CompilerGenerated]
		const string selJoinRoomHistoryAttribute_ = "joinRoom:historyAttribute:";
		static readonly IntPtr selJoinRoomHistoryAttribute_Handle = Selector.GetHandle ("joinRoom:historyAttribute:");
		[CompilerGenerated]
		const string selLeaveRoom_ = "leaveRoom:";
		static readonly IntPtr selLeaveRoom_Handle = Selector.GetHandle ("leaveRoom:");
		[CompilerGenerated]
		const string selLoginWithUser_ = "loginWithUser:";
		static readonly IntPtr selLoginWithUser_Handle = Selector.GetHandle ("loginWithUser:");
		[CompilerGenerated]
		const string selLogout = "logout";
		static readonly IntPtr selLogoutHandle = Selector.GetHandle ("logout");
		[CompilerGenerated]
		const string selMessagesWithDialogIDDelegate_ = "messagesWithDialogID:delegate:";
		static readonly IntPtr selMessagesWithDialogIDDelegate_Handle = Selector.GetHandle ("messagesWithDialogID:delegate:");
		[CompilerGenerated]
		const string selMessagesWithDialogIDDelegateContext_ = "messagesWithDialogID:delegate:context:";
		static readonly IntPtr selMessagesWithDialogIDDelegateContext_Handle = Selector.GetHandle ("messagesWithDialogID:delegate:context:");
		[CompilerGenerated]
		const string selMessagesWithDialogIDExtendedRequestDelegate_ = "messagesWithDialogID:extendedRequest:delegate:";
		static readonly IntPtr selMessagesWithDialogIDExtendedRequestDelegate_Handle = Selector.GetHandle ("messagesWithDialogID:extendedRequest:delegate:");
		[CompilerGenerated]
		const string selMessagesWithDialogIDExtendedRequestDelegateContext_ = "messagesWithDialogID:extendedRequest:delegate:context:";
		static readonly IntPtr selMessagesWithDialogIDExtendedRequestDelegateContext_Handle = Selector.GetHandle ("messagesWithDialogID:extendedRequest:delegate:context:");
		[CompilerGenerated]
		const string selRegisteredVideoChatInstances = "registeredVideoChatInstances";
		static readonly IntPtr selRegisteredVideoChatInstancesHandle = Selector.GetHandle ("registeredVideoChatInstances");
		[CompilerGenerated]
		const string selRejectAddContactRequest_ = "rejectAddContactRequest:";
		static readonly IntPtr selRejectAddContactRequest_Handle = Selector.GetHandle ("rejectAddContactRequest:");
		[CompilerGenerated]
		const string selRemoveUserFromContactList_ = "removeUserFromContactList:";
		static readonly IntPtr selRemoveUserFromContactList_Handle = Selector.GetHandle ("removeUserFromContactList:");
		[CompilerGenerated]
		const string selRequestAllRooms = "requestAllRooms";
		static readonly IntPtr selRequestAllRoomsHandle = Selector.GetHandle ("requestAllRooms");
		[CompilerGenerated]
		const string selRequestRoomInformation_ = "requestRoomInformation:";
		static readonly IntPtr selRequestRoomInformation_Handle = Selector.GetHandle ("requestRoomInformation:");
		[CompilerGenerated]
		const string selRequestRoomOnlineUsers_ = "requestRoomOnlineUsers:";
		static readonly IntPtr selRequestRoomOnlineUsers_Handle = Selector.GetHandle ("requestRoomOnlineUsers:");
		[CompilerGenerated]
		const string selRequestRoomUsers_ = "requestRoomUsers:";
		static readonly IntPtr selRequestRoomUsers_Handle = Selector.GetHandle ("requestRoomUsers:");
		[CompilerGenerated]
		const string selSendChatMessageToRoom_ = "sendChatMessage:toRoom:";
		static readonly IntPtr selSendChatMessageToRoom_Handle = Selector.GetHandle ("sendChatMessage:toRoom:");
		[CompilerGenerated]
		const string selSendDirectPresenceWithStatusToUser_ = "sendDirectPresenceWithStatus:toUser:";
		static readonly IntPtr selSendDirectPresenceWithStatusToUser_Handle = Selector.GetHandle ("sendDirectPresenceWithStatus:toUser:");
		[CompilerGenerated]
		const string selSendMessage_ = "sendMessage:";
		static readonly IntPtr selSendMessage_Handle = Selector.GetHandle ("sendMessage:");
		[CompilerGenerated]
		const string selSendMessageToRoom_ = "sendMessage:toRoom:";
		static readonly IntPtr selSendMessageToRoom_Handle = Selector.GetHandle ("sendMessage:toRoom:");
		[CompilerGenerated]
		const string selSendPresence = "sendPresence";
		static readonly IntPtr selSendPresenceHandle = Selector.GetHandle ("sendPresence");
		[CompilerGenerated]
		const string selSendPresenceWithParametersToRoom_ = "sendPresenceWithParameters:toRoom:";
		static readonly IntPtr selSendPresenceWithParametersToRoom_Handle = Selector.GetHandle ("sendPresenceWithParameters:toRoom:");
		[CompilerGenerated]
		const string selSendPresenceWithStatus_ = "sendPresenceWithStatus:";
		static readonly IntPtr selSendPresenceWithStatus_Handle = Selector.GetHandle ("sendPresenceWithStatus:");
		[CompilerGenerated]
		const string selSendPresenceWithStatusShowPriorityCustomParametersToRoom_ = "sendPresenceWithStatus:show:priority:customParameters:toRoom:";
		static readonly IntPtr selSendPresenceWithStatusShowPriorityCustomParametersToRoom_Handle = Selector.GetHandle ("sendPresenceWithStatus:show:priority:customParameters:toRoom:");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selSetUseMutualSubscriptionForContactList_ = "setUseMutualSubscriptionForContactList:";
		static readonly IntPtr selSetUseMutualSubscriptionForContactList_Handle = Selector.GetHandle ("setUseMutualSubscriptionForContactList:");
		[CompilerGenerated]
		const string selUnregisterVideoChatInstance_ = "unregisterVideoChatInstance:";
		static readonly IntPtr selUnregisterVideoChatInstance_Handle = Selector.GetHandle ("unregisterVideoChatInstance:");
		[CompilerGenerated]
		const string selUpdateDialogWithIDExtendedRequestDelegate_ = "updateDialogWithID:extendedRequest:delegate:";
		static readonly IntPtr selUpdateDialogWithIDExtendedRequestDelegate_Handle = Selector.GetHandle ("updateDialogWithID:extendedRequest:delegate:");
		[CompilerGenerated]
		const string selUpdateDialogWithIDExtendedRequestDelegateContext_ = "updateDialogWithID:extendedRequest:delegate:context:";
		static readonly IntPtr selUpdateDialogWithIDExtendedRequestDelegateContext_Handle = Selector.GetHandle ("updateDialogWithID:extendedRequest:delegate:context:");
		[CompilerGenerated]
		const string selUpdateMessageDelegate_ = "updateMessage:delegate:";
		static readonly IntPtr selUpdateMessageDelegate_Handle = Selector.GetHandle ("updateMessage:delegate:");
		[CompilerGenerated]
		const string selUpdateMessageDelegateContext_ = "updateMessage:delegate:context:";
		static readonly IntPtr selUpdateMessageDelegateContext_Handle = Selector.GetHandle ("updateMessage:delegate:context:");
		[CompilerGenerated]
		const string selUseMutualSubscriptionForContactList = "useMutualSubscriptionForContactList";
		static readonly IntPtr selUseMutualSubscriptionForContactListHandle = Selector.GetHandle ("useMutualSubscriptionForContactList");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBChat");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBChat () : base (NSObjectFlag.Empty)
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
		public QBChat (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChat (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChat (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addUsers:toRoom:")]
		[CompilerGenerated]
		public virtual bool AddUsers (NSObject[] usersIDs, QBChatRoom room)
		{
			if (usersIDs == null)
				throw new ArgumentNullException ("usersIDs");
			if (room == null)
				throw new ArgumentNullException ("room");
			var nsa_usersIDs = NSArray.FromNSObjects (usersIDs);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selAddUsersToRoom_Handle, nsa_usersIDs.Handle, room.Handle);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selAddUsersToRoom_Handle, nsa_usersIDs.Handle, room.Handle);
			}
			nsa_usersIDs.Dispose ();
			
			return ret;
		}
		
		[Export ("addUserToContactListRequest:")]
		[CompilerGenerated]
		public virtual bool AddUserToContactListRequest (global::System.UInt32 userID)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selAddUserToContactListRequest_Handle, userID);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selAddUserToContactListRequest_Handle, userID);
			}
		}
		
		[Export ("confirmAddContactRequest:")]
		[CompilerGenerated]
		public virtual bool ConfirmAddContactRequest (global::System.UInt32 userID)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selConfirmAddContactRequest_Handle, userID);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selConfirmAddContactRequest_Handle, userID);
			}
		}
		
		[Export ("createAndRegisterVideoChatInstanceWithSessionID:")]
		[CompilerGenerated]
		public virtual QBVideoChat CreateAndRegisterVideoChatInstanceWithSessionID (string sessionID)
		{
			if (sessionID == null)
				throw new ArgumentNullException ("sessionID");
			var nssessionID = NSString.CreateNative (sessionID);
			
			QBVideoChat ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<QBVideoChat> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selCreateAndRegisterVideoChatInstanceWithSessionID_Handle, nssessionID));
			} else {
				ret =  Runtime.GetNSObject<QBVideoChat> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selCreateAndRegisterVideoChatInstanceWithSessionID_Handle, nssessionID));
			}
			NSString.ReleaseNative (nssessionID);
			
			return ret;
		}
		
		[Export ("createDialog:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateDialog (QBChatDialog dialog, NSObject _delegate)
		{
			if (dialog == null)
				throw new ArgumentNullException ("dialog");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateDialogDelegate_Handle, dialog.Handle, _delegate.Handle));
		}
		
		[Export ("createDialog:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateDialog (QBChatDialog dialog, NSObject _delegate, NSObject context)
		{
			if (dialog == null)
				throw new ArgumentNullException ("dialog");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateDialogDelegateContext_Handle, dialog.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("createOrJoinRoomWithJID:membersOnly:persistent:historyAttribute:")]
		[CompilerGenerated]
		public virtual bool CreateOrJoinRoomWithJID (string roomJID, bool isMembersOnly, bool isPersistent, NSDictionary historyAttribute)
		{
			if (roomJID == null)
				throw new ArgumentNullException ("roomJID");
			if (historyAttribute == null)
				throw new ArgumentNullException ("historyAttribute");
			var nsroomJID = NSString.CreateNative (roomJID);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool_bool_IntPtr (this.Handle, selCreateOrJoinRoomWithJIDMembersOnlyPersistentHistoryAttribute_Handle, nsroomJID, isMembersOnly, isPersistent, historyAttribute.Handle);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool_bool_IntPtr (this.SuperHandle, selCreateOrJoinRoomWithJIDMembersOnlyPersistentHistoryAttribute_Handle, nsroomJID, isMembersOnly, isPersistent, historyAttribute.Handle);
			}
			NSString.ReleaseNative (nsroomJID);
			
			return ret;
		}
		
		[Export ("createOrJoinRoomWithJID:nickname:membersOnly:persistent:historyAttribute:")]
		[CompilerGenerated]
		public virtual bool CreateOrJoinRoomWithJID (string roomJID, string nickname, bool isMembersOnly, bool isPersistent, NSDictionary historyAttribute)
		{
			if (roomJID == null)
				throw new ArgumentNullException ("roomJID");
			if (nickname == null)
				throw new ArgumentNullException ("nickname");
			if (historyAttribute == null)
				throw new ArgumentNullException ("historyAttribute");
			var nsroomJID = NSString.CreateNative (roomJID);
			var nsnickname = NSString.CreateNative (nickname);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_bool_bool_IntPtr (this.Handle, selCreateOrJoinRoomWithJIDNicknameMembersOnlyPersistentHistoryAttribute_Handle, nsroomJID, nsnickname, isMembersOnly, isPersistent, historyAttribute.Handle);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_bool_bool_IntPtr (this.SuperHandle, selCreateOrJoinRoomWithJIDNicknameMembersOnlyPersistentHistoryAttribute_Handle, nsroomJID, nsnickname, isMembersOnly, isPersistent, historyAttribute.Handle);
			}
			NSString.ReleaseNative (nsroomJID);
			NSString.ReleaseNative (nsnickname);
			
			return ret;
		}
		
		[Export ("createOrJoinRoomWithName:membersOnly:persistent:")]
		[CompilerGenerated]
		public virtual bool CreateOrJoinRoomWithName (string name, bool isMembersOnly, bool isPersistent)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool_bool (this.Handle, selCreateOrJoinRoomWithNameMembersOnlyPersistent_Handle, nsname, isMembersOnly, isPersistent);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool_bool (this.SuperHandle, selCreateOrJoinRoomWithNameMembersOnlyPersistent_Handle, nsname, isMembersOnly, isPersistent);
			}
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("createOrJoinRoomWithName:nickname:membersOnly:persistent:")]
		[CompilerGenerated]
		public virtual bool CreateOrJoinRoomWithName (string name, string nickname, bool isMembersOnly, bool isPersistent)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (nickname == null)
				throw new ArgumentNullException ("nickname");
			var nsname = NSString.CreateNative (name);
			var nsnickname = NSString.CreateNative (nickname);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_bool_bool (this.Handle, selCreateOrJoinRoomWithNameNicknameMembersOnlyPersistent_Handle, nsname, nsnickname, isMembersOnly, isPersistent);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_bool_bool (this.SuperHandle, selCreateOrJoinRoomWithNameNicknameMembersOnlyPersistent_Handle, nsname, nsnickname, isMembersOnly, isPersistent);
			}
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsnickname);
			
			return ret;
		}
		
		[Export ("deleteMessageWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteMessageWithID (string messageID, NSObject _delegate)
		{
			if (messageID == null)
				throw new ArgumentNullException ("messageID");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsmessageID = NSString.CreateNative (messageID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selDeleteMessageWithIDDelegate_Handle, nsmessageID, _delegate.Handle));
			NSString.ReleaseNative (nsmessageID);
			
			return ret;
		}
		
		[Export ("deleteMessageWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteMessageWithID (string messageID, NSObject _delegate, NSObject context)
		{
			if (messageID == null)
				throw new ArgumentNullException ("messageID");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsmessageID = NSString.CreateNative (messageID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selDeleteMessageWithIDDelegateContext_Handle, nsmessageID, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsmessageID);
			
			return ret;
		}
		
		[Export ("deleteUsers:fromRoom:")]
		[CompilerGenerated]
		public virtual bool DeleteUsers (NSObject[] usersIDs, QBChatRoom room)
		{
			if (usersIDs == null)
				throw new ArgumentNullException ("usersIDs");
			if (room == null)
				throw new ArgumentNullException ("room");
			var nsa_usersIDs = NSArray.FromNSObjects (usersIDs);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selDeleteUsersFromRoom_Handle, nsa_usersIDs.Handle, room.Handle);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selDeleteUsersFromRoom_Handle, nsa_usersIDs.Handle, room.Handle);
			}
			nsa_usersIDs.Dispose ();
			
			return ret;
		}
		
		[Export ("destroyRoom:")]
		[CompilerGenerated]
		public virtual bool DestroyRoom (QBChatRoom room)
		{
			if (room == null)
				throw new ArgumentNullException ("room");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selDestroyRoom_Handle, room.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selDestroyRoom_Handle, room.Handle);
			}
		}
		
		[Export ("dialogsWithDelegate:")]
		[CompilerGenerated]
		public static NSObject DialogsWithDelegate (NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selDialogsWithDelegate_Handle, _delegate.Handle));
		}
		
		[Export ("dialogsWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject DialogsWithDelegate (NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selDialogsWithDelegateContext_Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("dialogsWithExtendedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject DialogsWithExtendedRequest (NSMutableDictionary extendedRequest, NSObject _delegate)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selDialogsWithExtendedRequestDelegate_Handle, extendedRequest.Handle, _delegate.Handle));
		}
		
		[Export ("dialogsWithExtendedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DialogsWithExtendedRequest (NSMutableDictionary extendedRequest, NSObject _delegate, NSObject context)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selDialogsWithExtendedRequestDelegateContext_Handle, extendedRequest.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("joinRoom:")]
		[CompilerGenerated]
		public virtual bool JoinRoom (QBChatRoom room)
		{
			if (room == null)
				throw new ArgumentNullException ("room");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selJoinRoom_Handle, room.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selJoinRoom_Handle, room.Handle);
			}
		}
		
		[Export ("joinRoom:historyAttribute:")]
		[CompilerGenerated]
		public virtual bool JoinRoom (QBChatRoom room, NSDictionary historyAttribute)
		{
			if (room == null)
				throw new ArgumentNullException ("room");
			if (historyAttribute == null)
				throw new ArgumentNullException ("historyAttribute");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selJoinRoomHistoryAttribute_Handle, room.Handle, historyAttribute.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selJoinRoomHistoryAttribute_Handle, room.Handle, historyAttribute.Handle);
			}
		}
		
		[Export ("leaveRoom:")]
		[CompilerGenerated]
		public virtual bool LeaveRoom (QBChatRoom room)
		{
			if (room == null)
				throw new ArgumentNullException ("room");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selLeaveRoom_Handle, room.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selLeaveRoom_Handle, room.Handle);
			}
		}
		
		[Export ("loginWithUser:")]
		[CompilerGenerated]
		public virtual bool LoginWithUser (QBUUser user)
		{
			if (user == null)
				throw new ArgumentNullException ("user");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selLoginWithUser_Handle, user.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selLoginWithUser_Handle, user.Handle);
			}
		}
		
		[Export ("logout")]
		[CompilerGenerated]
		public virtual bool Logout ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selLogoutHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selLogoutHandle);
			}
		}
		
		[Export ("messagesWithDialogID:delegate:")]
		[CompilerGenerated]
		public static NSObject MessagesWithDialogID (string dialogID, NSObject _delegate)
		{
			if (dialogID == null)
				throw new ArgumentNullException ("dialogID");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsdialogID = NSString.CreateNative (dialogID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selMessagesWithDialogIDDelegate_Handle, nsdialogID, _delegate.Handle));
			NSString.ReleaseNative (nsdialogID);
			
			return ret;
		}
		
		[Export ("messagesWithDialogID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject MessagesWithDialogID (string dialogID, NSObject _delegate, NSObject context)
		{
			if (dialogID == null)
				throw new ArgumentNullException ("dialogID");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsdialogID = NSString.CreateNative (dialogID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selMessagesWithDialogIDDelegateContext_Handle, nsdialogID, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsdialogID);
			
			return ret;
		}
		
		[Export ("messagesWithDialogID:extendedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject MessagesWithDialogID (string dialogID, NSMutableDictionary extendedRequest, NSObject _delegate)
		{
			if (dialogID == null)
				throw new ArgumentNullException ("dialogID");
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsdialogID = NSString.CreateNative (dialogID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selMessagesWithDialogIDExtendedRequestDelegate_Handle, nsdialogID, extendedRequest.Handle, _delegate.Handle));
			NSString.ReleaseNative (nsdialogID);
			
			return ret;
		}
		
		[Export ("messagesWithDialogID:extendedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject MessagesWithDialogID (string dialogID, NSMutableDictionary extendedRequest, NSObject _delegate, NSObject context)
		{
			if (dialogID == null)
				throw new ArgumentNullException ("dialogID");
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsdialogID = NSString.CreateNative (dialogID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selMessagesWithDialogIDExtendedRequestDelegateContext_Handle, nsdialogID, extendedRequest.Handle, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsdialogID);
			
			return ret;
		}
		
		[Export ("rejectAddContactRequest:")]
		[CompilerGenerated]
		public virtual bool RejectAddContactRequest (global::System.UInt32 userID)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selRejectAddContactRequest_Handle, userID);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selRejectAddContactRequest_Handle, userID);
			}
		}
		
		[Export ("removeUserFromContactList:")]
		[CompilerGenerated]
		public virtual bool RemoveUserFromContactList (global::System.UInt32 userID)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, selRemoveUserFromContactList_Handle, userID);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (this.SuperHandle, selRemoveUserFromContactList_Handle, userID);
			}
		}
		
		[Export ("requestAllRooms")]
		[CompilerGenerated]
		public virtual bool RequestAllRooms ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRequestAllRoomsHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selRequestAllRoomsHandle);
			}
		}
		
		[Export ("requestRoomInformation:")]
		[CompilerGenerated]
		public virtual bool RequestRoomInformation (QBChatRoom room)
		{
			if (room == null)
				throw new ArgumentNullException ("room");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selRequestRoomInformation_Handle, room.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selRequestRoomInformation_Handle, room.Handle);
			}
		}
		
		[Export ("requestRoomOnlineUsers:")]
		[CompilerGenerated]
		public virtual bool RequestRoomOnlineUsers (QBChatRoom room)
		{
			if (room == null)
				throw new ArgumentNullException ("room");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selRequestRoomOnlineUsers_Handle, room.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selRequestRoomOnlineUsers_Handle, room.Handle);
			}
		}
		
		[Export ("requestRoomUsers:")]
		[CompilerGenerated]
		public virtual bool RequestRoomUsers (QBChatRoom room)
		{
			if (room == null)
				throw new ArgumentNullException ("room");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selRequestRoomUsers_Handle, room.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selRequestRoomUsers_Handle, room.Handle);
			}
		}
		
		[Export ("sendChatMessage:toRoom:")]
		[CompilerGenerated]
		public virtual bool SendChatMessage (QBChatMessage message, QBChatRoom room)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (room == null)
				throw new ArgumentNullException ("room");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSendChatMessageToRoom_Handle, message.Handle, room.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSendChatMessageToRoom_Handle, message.Handle, room.Handle);
			}
		}
		
		[Export ("sendDirectPresenceWithStatus:toUser:")]
		[CompilerGenerated]
		public virtual bool SendDirectPresenceWithStatus (string status, global::System.UInt32 userID)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_UInt32 (this.Handle, selSendDirectPresenceWithStatusToUser_Handle, nsstatus, userID);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selSendDirectPresenceWithStatusToUser_Handle, nsstatus, userID);
			}
			NSString.ReleaseNative (nsstatus);
			
			return ret;
		}
		
		[Export ("sendMessage:")]
		[CompilerGenerated]
		public virtual bool SendMessage (QBChatMessage message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSendMessage_Handle, message.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSendMessage_Handle, message.Handle);
			}
		}
		
		[Export ("sendMessage:toRoom:")]
		[CompilerGenerated]
		public virtual bool SendMessage (string message, QBChatRoom room)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (room == null)
				throw new ArgumentNullException ("room");
			var nsmessage = NSString.CreateNative (message);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSendMessageToRoom_Handle, nsmessage, room.Handle);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSendMessageToRoom_Handle, nsmessage, room.Handle);
			}
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[Export ("sendPresence")]
		[CompilerGenerated]
		public virtual bool SendPresence ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSendPresenceHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSendPresenceHandle);
			}
		}
		
		[Export ("sendPresenceWithParameters:toRoom:")]
		[CompilerGenerated]
		public virtual bool SendPresenceWithParameters (NSDictionary parameters, QBChatRoom room)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (room == null)
				throw new ArgumentNullException ("room");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSendPresenceWithParametersToRoom_Handle, parameters.Handle, room.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSendPresenceWithParametersToRoom_Handle, parameters.Handle, room.Handle);
			}
		}
		
		[Export ("sendPresenceWithStatus:")]
		[CompilerGenerated]
		public virtual bool SendPresenceWithStatus (string status)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			var nsstatus = NSString.CreateNative (status);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSendPresenceWithStatus_Handle, nsstatus);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSendPresenceWithStatus_Handle, nsstatus);
			}
			NSString.ReleaseNative (nsstatus);
			
			return ret;
		}
		
		[Export ("sendPresenceWithStatus:show:priority:customParameters:toRoom:")]
		[CompilerGenerated]
		public virtual bool SendPresenceWithStatus (string status, bool show, short priority, NSDictionary customParameters, QBChatRoom room)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			if (customParameters == null)
				throw new ArgumentNullException ("customParameters");
			if (room == null)
				throw new ArgumentNullException ("room");
			var nsstatus = NSString.CreateNative (status);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool_short_IntPtr_IntPtr (this.Handle, selSendPresenceWithStatusShowPriorityCustomParametersToRoom_Handle, nsstatus, show, priority, customParameters.Handle, room.Handle);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool_short_IntPtr_IntPtr (this.SuperHandle, selSendPresenceWithStatusShowPriorityCustomParametersToRoom_Handle, nsstatus, show, priority, customParameters.Handle, room.Handle);
			}
			NSString.ReleaseNative (nsstatus);
			
			return ret;
		}
		
		[Export ("unregisterVideoChatInstance:")]
		[CompilerGenerated]
		public virtual void UnregisterVideoChatInstance (QBVideoChat videoChat)
		{
			if (videoChat == null)
				throw new ArgumentNullException ("videoChat");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selUnregisterVideoChatInstance_Handle, videoChat.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selUnregisterVideoChatInstance_Handle, videoChat.Handle);
			}
		}
		
		[Export ("updateDialogWithID:extendedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateDialogWithID (string dialogID, NSMutableDictionary extendedRequest, NSObject _delegate)
		{
			if (dialogID == null)
				throw new ArgumentNullException ("dialogID");
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsdialogID = NSString.CreateNative (dialogID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateDialogWithIDExtendedRequestDelegate_Handle, nsdialogID, extendedRequest.Handle, _delegate.Handle));
			NSString.ReleaseNative (nsdialogID);
			
			return ret;
		}
		
		[Export ("updateDialogWithID:extendedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateDialogWithID (string dialogID, NSMutableDictionary extendedRequest, NSObject _delegate, NSObject context)
		{
			if (dialogID == null)
				throw new ArgumentNullException ("dialogID");
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsdialogID = NSString.CreateNative (dialogID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateDialogWithIDExtendedRequestDelegateContext_Handle, nsdialogID, extendedRequest.Handle, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsdialogID);
			
			return ret;
		}
		
		[Export ("updateMessage:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateMessage (QBChatHistoryMessage message, NSObject _delegate)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdateMessageDelegate_Handle, message.Handle, _delegate.Handle));
		}
		
		[Export ("updateMessage:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateMessage (QBChatHistoryMessage message, NSObject _delegate, NSObject context)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateMessageDelegateContext_Handle, message.Handle, _delegate.Handle, context.Handle));
		}
		
		[CompilerGenerated]
		object __mt_ContactList_var;
		[CompilerGenerated]
		public virtual QBContactList ContactList {
			[Export ("contactList")]
			get {
				QBContactList ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBContactList> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContactListHandle));
				} else {
					ret =  Runtime.GetNSObject<QBContactList> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContactListHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContactList_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CreateAndRegisterVideoChatInstance_var;
		[CompilerGenerated]
		public virtual QBVideoChat CreateAndRegisterVideoChatInstance {
			[Export ("createAndRegisterVideoChatInstance")]
			get {
				QBVideoChat ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBVideoChat> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCreateAndRegisterVideoChatInstanceHandle));
				} else {
					ret =  Runtime.GetNSObject<QBVideoChat> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCreateAndRegisterVideoChatInstanceHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CreateAndRegisterVideoChatInstance_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CurrentUser_var;
		[CompilerGenerated]
		public virtual QBUUser CurrentUser {
			[Export ("currentUser")]
			get {
				QBUUser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBUUser> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCurrentUserHandle));
				} else {
					ret =  Runtime.GetNSObject<QBUUser> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCurrentUserHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CurrentUser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual QBChatDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Retain)]
			get {
				QBChatDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBChatDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<QBChatDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		static object __mt_Instance_var_static;
		[CompilerGenerated]
		public static QBChat Instance {
			[Export ("instance")]
			get {
				QBChat ret;
				ret =  Runtime.GetNSObject<QBChat> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selInstanceHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Instance_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsLoggedIn {
			[Export ("isLoggedIn")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLoggedInHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLoggedInHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RegisteredVideoChatInstances_var;
		[CompilerGenerated]
		public virtual NSMutableArray RegisteredVideoChatInstances {
			[Export ("registeredVideoChatInstances")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRegisteredVideoChatInstancesHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRegisteredVideoChatInstancesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RegisteredVideoChatInstances_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool UseMutualSubscriptionForContactList {
			[Export ("useMutualSubscriptionForContactList")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseMutualSubscriptionForContactListHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseMutualSubscriptionForContactListHandle);
				}
			}
			
			[Export ("setUseMutualSubscriptionForContactList:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseMutualSubscriptionForContactList_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseMutualSubscriptionForContactList_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ContactList_var = null;
				__mt_CreateAndRegisterVideoChatInstance_var = null;
				__mt_CurrentUser_var = null;
				__mt_Delegate_var = null;
				__mt_RegisteredVideoChatInstances_var = null;
			}
		}
	} /* class QBChat */
}
