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
	[Register("QBChat", true)]
	public unsafe partial class QBChat : NSObject {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selContactList = "contactList";
		static readonly IntPtr selContactListHandle = Selector.GetHandle ("contactList");
		[CompilerGenerated]
		const string selRegisteredVideoChatInstances = "registeredVideoChatInstances";
		static readonly IntPtr selRegisteredVideoChatInstancesHandle = Selector.GetHandle ("registeredVideoChatInstances");
		[CompilerGenerated]
		const string selInstance = "instance";
		static readonly IntPtr selInstanceHandle = Selector.GetHandle ("instance");
		[CompilerGenerated]
		const string selIsLoggedIn = "isLoggedIn";
		static readonly IntPtr selIsLoggedInHandle = Selector.GetHandle ("isLoggedIn");
		[CompilerGenerated]
		const string selCurrentUser = "currentUser";
		static readonly IntPtr selCurrentUserHandle = Selector.GetHandle ("currentUser");
		[CompilerGenerated]
		const string selRequestAllRooms = "requestAllRooms";
		static readonly IntPtr selRequestAllRoomsHandle = Selector.GetHandle ("requestAllRooms");
		[CompilerGenerated]
		const string selCreateAndRegisterVideoChatInstance = "createAndRegisterVideoChatInstance";
		static readonly IntPtr selCreateAndRegisterVideoChatInstanceHandle = Selector.GetHandle ("createAndRegisterVideoChatInstance");
		[CompilerGenerated]
		const string selLoginWithUser_ = "loginWithUser:";
		static readonly IntPtr selLoginWithUser_Handle = Selector.GetHandle ("loginWithUser:");
		[CompilerGenerated]
		const string selLogout = "logout";
		static readonly IntPtr selLogoutHandle = Selector.GetHandle ("logout");
		[CompilerGenerated]
		const string selSendMessage_ = "sendMessage:";
		static readonly IntPtr selSendMessage_Handle = Selector.GetHandle ("sendMessage:");
		[CompilerGenerated]
		const string selSendPresence = "sendPresence";
		static readonly IntPtr selSendPresenceHandle = Selector.GetHandle ("sendPresence");
		[CompilerGenerated]
		const string selSendPresenceWithStatus_ = "sendPresenceWithStatus:";
		static readonly IntPtr selSendPresenceWithStatus_Handle = Selector.GetHandle ("sendPresenceWithStatus:");
		[CompilerGenerated]
		const string selSendDirectPresenceWithStatusToUser_ = "sendDirectPresenceWithStatus:toUser:";
		static readonly IntPtr selSendDirectPresenceWithStatusToUser_Handle = Selector.GetHandle ("sendDirectPresenceWithStatus:toUser:");
		[CompilerGenerated]
		const string selAddUserToContactListRequest_ = "addUserToContactListRequest:";
		static readonly IntPtr selAddUserToContactListRequest_Handle = Selector.GetHandle ("addUserToContactListRequest:");
		[CompilerGenerated]
		const string selRemoveUserFromContactList_ = "removeUserFromContactList:";
		static readonly IntPtr selRemoveUserFromContactList_Handle = Selector.GetHandle ("removeUserFromContactList:");
		[CompilerGenerated]
		const string selConfirmAddContactRequest_ = "confirmAddContactRequest:";
		static readonly IntPtr selConfirmAddContactRequest_Handle = Selector.GetHandle ("confirmAddContactRequest:");
		[CompilerGenerated]
		const string selRejectAddContactRequest_ = "rejectAddContactRequest:";
		static readonly IntPtr selRejectAddContactRequest_Handle = Selector.GetHandle ("rejectAddContactRequest:");
		[CompilerGenerated]
		const string selCreateOrJoinRoomWithNameMembersOnlyPersistent_ = "createOrJoinRoomWithName:membersOnly:persistent:";
		static readonly IntPtr selCreateOrJoinRoomWithNameMembersOnlyPersistent_Handle = Selector.GetHandle ("createOrJoinRoomWithName:membersOnly:persistent:");
		[CompilerGenerated]
		const string selCreateOrJoinRoomWithNameNicknameMembersOnlyPersistent_ = "createOrJoinRoomWithName:nickname:membersOnly:persistent:";
		static readonly IntPtr selCreateOrJoinRoomWithNameNicknameMembersOnlyPersistent_Handle = Selector.GetHandle ("createOrJoinRoomWithName:nickname:membersOnly:persistent:");
		[CompilerGenerated]
		const string selJoinRoom_ = "joinRoom:";
		static readonly IntPtr selJoinRoom_Handle = Selector.GetHandle ("joinRoom:");
		[CompilerGenerated]
		const string selLeaveRoom_ = "leaveRoom:";
		static readonly IntPtr selLeaveRoom_Handle = Selector.GetHandle ("leaveRoom:");
		[CompilerGenerated]
		const string selDestroyRoom_ = "destroyRoom:";
		static readonly IntPtr selDestroyRoom_Handle = Selector.GetHandle ("destroyRoom:");
		[CompilerGenerated]
		const string selSendMessageToRoom_ = "sendMessage:toRoom:";
		static readonly IntPtr selSendMessageToRoom_Handle = Selector.GetHandle ("sendMessage:toRoom:");
		[CompilerGenerated]
		const string selSendPresenceWithParametersToRoom_ = "sendPresenceWithParameters:toRoom:";
		static readonly IntPtr selSendPresenceWithParametersToRoom_Handle = Selector.GetHandle ("sendPresenceWithParameters:toRoom:");
		[CompilerGenerated]
		const string selSendPresenceWithStatusShowPriorityCustomParametersToRoom_ = "sendPresenceWithStatus:show:priority:customParameters:toRoom:";
		static readonly IntPtr selSendPresenceWithStatusShowPriorityCustomParametersToRoom_Handle = Selector.GetHandle ("sendPresenceWithStatus:show:priority:customParameters:toRoom:");
		[CompilerGenerated]
		const string selRequestRoomInformation_ = "requestRoomInformation:";
		static readonly IntPtr selRequestRoomInformation_Handle = Selector.GetHandle ("requestRoomInformation:");
		[CompilerGenerated]
		const string selRequestRoomUsers_ = "requestRoomUsers:";
		static readonly IntPtr selRequestRoomUsers_Handle = Selector.GetHandle ("requestRoomUsers:");
		[CompilerGenerated]
		const string selRequestRoomOnlineUsers_ = "requestRoomOnlineUsers:";
		static readonly IntPtr selRequestRoomOnlineUsers_Handle = Selector.GetHandle ("requestRoomOnlineUsers:");
		[CompilerGenerated]
		const string selAddUsersToRoom_ = "addUsers:toRoom:";
		static readonly IntPtr selAddUsersToRoom_Handle = Selector.GetHandle ("addUsers:toRoom:");
		[CompilerGenerated]
		const string selDeleteUsersFromRoom_ = "deleteUsers:fromRoom:";
		static readonly IntPtr selDeleteUsersFromRoom_Handle = Selector.GetHandle ("deleteUsers:fromRoom:");
		[CompilerGenerated]
		const string selCreateAndRegisterVideoChatInstanceWithSessionID_ = "createAndRegisterVideoChatInstanceWithSessionID:";
		static readonly IntPtr selCreateAndRegisterVideoChatInstanceWithSessionID_Handle = Selector.GetHandle ("createAndRegisterVideoChatInstanceWithSessionID:");
		[CompilerGenerated]
		const string selUnregisterVideoChatInstance_ = "unregisterVideoChatInstance:";
		static readonly IntPtr selUnregisterVideoChatInstance_Handle = Selector.GetHandle ("unregisterVideoChatInstance:");
		[CompilerGenerated]
		const string selSendGetIQWithXmlnsNode_ = "sendGetIQWithXmlns:node:";
		static readonly IntPtr selSendGetIQWithXmlnsNode_Handle = Selector.GetHandle ("sendGetIQWithXmlns:node:");
		
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
		
		[Export ("sendPresenceWithStatus:show:priority:customParameters:toRoom:")]
		[CompilerGenerated]
		public virtual bool SendPresenceWithStatus (string status, QBPresenseShow show, short priority, NSDictionary customParameters, QBChatRoom room)
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
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_int_short_IntPtr_IntPtr (this.Handle, selSendPresenceWithStatusShowPriorityCustomParametersToRoom_Handle, nsstatus, (int)show, priority, customParameters.Handle, room.Handle);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_int_short_IntPtr_IntPtr (this.SuperHandle, selSendPresenceWithStatusShowPriorityCustomParametersToRoom_Handle, nsstatus, (int)show, priority, customParameters.Handle, room.Handle);
			}
			NSString.ReleaseNative (nsstatus);
			
			return ret;
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
		
		[Export ("sendGetIQWithXmlns:node:")]
		[CompilerGenerated]
		public virtual void SendGetIQWithXmlns (string xmlns, string node)
		{
			if (xmlns == null)
				throw new ArgumentNullException ("xmlns");
			if (node == null)
				throw new ArgumentNullException ("node");
			var nsxmlns = NSString.CreateNative (xmlns);
			var nsnode = NSString.CreateNative (node);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSendGetIQWithXmlnsNode_Handle, nsxmlns, nsnode);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSendGetIQWithXmlnsNode_Handle, nsxmlns, nsnode);
			}
			NSString.ReleaseNative (nsxmlns);
			NSString.ReleaseNative (nsnode);
			
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
				MarkDirty ();
				__mt_ContactList_var = ret;
				return ret;
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
				MarkDirty ();
				__mt_RegisteredVideoChatInstances_var = ret;
				return ret;
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
				MarkDirty ();
				__mt_CurrentUser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool RequestAllRooms {
			[Export ("requestAllRooms")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRequestAllRoomsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selRequestAllRoomsHandle);
				}
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
				MarkDirty ();
				__mt_CreateAndRegisterVideoChatInstance_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_ContactList_var = null;
				__mt_RegisteredVideoChatInstances_var = null;
				__mt_CurrentUser_var = null;
				__mt_CreateAndRegisterVideoChatInstance_var = null;
			}
		}
	} /* class QBChat */
}
