

using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.AudioToolbox;
using MonoTouch.CoreData;
using MonoTouch.AVFoundation;
using MonoTouch.Accelerate;
using MonoTouch.CoreMedia;
using MonoTouch.CoreLocation;
using MonoTouch.MobileCoreServices;
using MonoTouch.SystemConfiguration;
using MonoTouch.CoreGraphics;


//  http://stackoverflow.com/questions/10879411/monotouch-binding-syntax-for-blocks

//  Command line 'sharpie' to ggenerate binding for single file:
//  sharpie --sdk=iphoneos7.1 --scope=/path/to/framework/Headers -r -n=QuickBlox /path/to/framework/Headers/QBChat.h


namespace QuickBlox
{




	[BaseType (typeof (NSObject))]
	public partial interface Request {

		[Export ("parameters")]
		NSDictionary Parameters { get; }

		[Static, Export ("request")]
		Request Create();
	}



	[BaseType (typeof (NSObject))]
	public partial interface Result {

		[Export ("errors")]
		NSObject [] Errors { get; }

		[Export ("success")]
		bool Success { get; }

		[Export ("status")]
		uint Status { get; }

		[Export ("request", ArgumentSemantic.Retain)]
		Request Request { get; set; }

	}


	[BaseType (typeof (Result))]
	public partial interface QBDialogsPagedResult {

		[Export ("dialogs")]
		NSObject [] Dialogs { get; }

		[Export ("dialogsUsersIDs")]
		NSSet DialogsUsersIDs { get; }
	}


	[BaseType (typeof (Result))]
	public partial interface QBChatHistoryMessageResult {

		[Export ("messages")]
		NSMutableArray Messages { get; }
	}



	[BaseType (typeof (Result))]
	public partial interface QBChatDialogResult {

		[Export ("dialog")]
		QBChatDialog Dialog { get; }
	}



	[BaseType (typeof (NSObject))]
	[Model, Protocol]
	public interface QBActionStatusDelegate {

		[Export ("completedWithResult:")]
		void CompletedWithResult(Result result);

		[Export ("completedWithResult:context:")]
		void CompletedWithResultInContext (Result result, NSObject contextInfo);

		[Export ("progress")]
		float Progress { set; }

	}

	[BaseType (typeof (NSObject))]
	public partial interface QBContactList {

		[Export ("contacts")]
		NSObject[] Contacts { get; }

		[Export ("pendingApproval")]
		NSObject[] PendingApproval { get; }

	}


	[BaseType (typeof (NSObject))]
	public partial interface QBChatAbstractMessage {

		[Export ("ID", ArgumentSemantic.Copy)]
		string ID { get; set; }

		[Export ("text", ArgumentSemantic.Copy)]
		string Text { get; set; }

		[Export ("recipientID")]
		uint RecipientID { get; set; }

		[Export ("senderID")]
		uint SenderID { get; set; }

		[Export ("datetime", ArgumentSemantic.Retain)]
		NSDate Datetime { get; set; }

		[Export ("customParameters", ArgumentSemantic.Retain)]
		NSMutableDictionary CustomParameters { get; set; }

		[Export ("attachments", ArgumentSemantic.Retain)]
		NSObject [] Attachments { get; set; }
	}


	[BaseType (typeof (QBChatAbstractMessage))]
	public partial interface QBChatMessage {

		[Export ("senderNick", ArgumentSemantic.Copy)]
		string SenderNick { get; set; }

		[Export ("delayed")]
		bool Delayed { get; set; }

		[Export ("customObjectsClassName", ArgumentSemantic.Copy)]
		string CustomObjectsClassName { get; set; }

		[Export ("customObjectsAdditionalParameters", ArgumentSemantic.Copy)]
		NSDictionary CustomObjectsAdditionalParameters { get; set; }

		[Export ("markable")]
		bool Markable { get; set; }

		[Static, Export ("message")]
		QBChatMessage CreateMessage ();

		[Static, Export ("markableMessage")]
		QBChatMessage CreateMarkableMessage();

		[Export ("saveWhenDeliveredToCustomObjectsWithClassName:additionalParameters:")]
		void SaveWhenDeliveredToCustomObjectsWithClassName (string classname, NSDictionary additionalParameters);
	}


	[BaseType (typeof (NSObject))]
	public partial interface QBChatRoom {

		[Export ("name")]
		string Name { get; }

		[Export ("JID")]
		string JID { get; }

		[Export ("isJoined")]
		bool IsJoined { get; }

		[Export ("initWithRoomName:")]
		IntPtr Constructor (string roomName);

		[Export ("initWithRoomName:nickname:")]
		IntPtr Constructor (string roomName, string nickname);

		[Export ("initWithRoomJID:")]
		IntPtr InitWithRoomJID (string roomJID);

		[Export ("initWithRoomJID:nickname:")]
		IntPtr InitWithRoomJIDAndNickName (string roomJID, string nickname);

		[Export ("addUsers:")]
		void AddUsers (NSObject [] users);

		[Export ("deleteUsers:")]
		void DeleteUsers (NSObject [] users);

		[Export ("sendMessage:")]
		void SendMessage (QBChatMessage message);

		[Export ("joinRoom")]
		void JoinRoom ();

		[Export ("joinRoomWithHistoryAttribute:")]
		void JoinRoomWithHistoryAttribute (NSDictionary historyAttribute);

		[Export ("leaveRoom")]
		void LeaveRoom ();

		[Export ("requestUsers")]
		void RequestUsers ();

		[Export ("requestOnlineUsers")]
		void RequestOnlineUsers ();

		[Export ("requestInformation")]
		void RequestInformation ();
	}



	[BaseType (typeof (NSObject))]
	[Model, Protocol]
	public partial interface QBChatDelegate {

		[Export ("chatDidLogin")]
		void ChatDidLogin ();

		[Export ("chatDidNotLogin")]
		void ChatDidNotLogin ();

		[Export ("chatDidNotSendMessage:error:")]
		void ChatDidNotSendMessage (QBChatMessage message, NSError error);

		[Export ("chatDidReceiveMessage:")]
		void  ChatDidReceiveMessage(QBChatMessage message);

		[Export ("chatDidFailWithError:")]
		void ChatDidFailWithError (int code);

		[Export ("chatDidReceivePresenceOfUser:type:")]
		void ChatDidReceivePresenceOfUser (uint userID, string type);

		[Export ("chatDidReceiveContactAddRequestFromUser:")]
		void  ChatDidReceiveContactAddRequestFromUser(uint userID);

		[Export ("chatContactListDidChange:")]
		void  ChatContactListDidChange(QBContactList contactList);

		[Export ("chatDidReceiveContactItemActivity:isOnline:status:")]
		void ChatDidReceiveContactItemActivity (uint userID, bool isOnline, string status);

		[Export ("chatDidReceiveListOfRooms:")]
		void ChatDidReceiveListOfRooms (NSObject [] rooms);

		[Export ("chatRoomDidReceiveMessage:fromRoom:")]
		void ChatRoomDidReceiveMessage (QBChatMessage message, string roomName);

		[Export ("chatRoomDidReceiveMessage:fromRoomJID:")]
		void ChatRoomDidReceiveMessageFromRoomJID (QBChatMessage message, string roomJID);

		[Export ("chatRoomDidReceiveInformation:room:")]
		void ChatRoomDidReceiveInformation (NSDictionary information, string roomName);

		[Export ("chatRoomDidCreate:")]
		void  ChatRoomDidCreate(string roomName);

		[Export ("chatRoomDidEnter:")]
		void  ChatRoomDidEnter(QBChatRoom room);

		[Export ("chatRoomDidNotEnter:error:")]
		void ChatRoomDidNotEnter (string roomName, NSError error);

		[Export ("chatRoomDidNotEnterRoomWithJID:error:")]
		void ChatRoomDidNotEnterRoomWithJID (string roomJID, NSError error);

		[Export ("chatRoomDidLeave:")]
		void ChatRoomDidLeave (string roomName);

		[Export ("chatRoomDidLeaveRoomWithJID:")]
		void ChatRoomDidLeaveRoomWithJID (string roomJID);

		[Export ("chatRoomDidDestroy:")]
		void  ChatRoomDidDestroy(string roomName);

		[Export ("chatRoomDidChangeOnlineUsers:room:")]
		void ChatRoomDidChangeOnlineUsers (NSObject [] onlineUsers, string roomName);

		[Export ("chatRoomDidChangeOnlineUsers:roomJID:")]
		void ChatRoomDidChangeOnlineUsersFromRoomJID (NSObject [] onlineUsers, string roomJID);

		[Export ("chatRoomDidReceiveListOfUsers:room:")]
		void ChatRoomDidReceiveListOfUsers (NSObject [] users, string roomName);

		[Export ("chatRoomDidReceiveListOfOnlineUsers:room:")]
		void ChatRoomDidReceiveListOfOnlineUsers (NSObject [] users, string roomName);

		[Export ("chatRoomDidReceiveListOfOnlineUsers:roomJID:")]
		void ChatRoomDidReceiveListOfOnlineUsersFromRoomJID (NSObject [] users, string roomJID);

		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:")]
		void ChatDidReceiveCallRequestFromUser (uint userID, string sessionID, QBVideoChatConferenceType conferenceType);

		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:customParameters:")]
		void chatDidReceiveCallRequestFromUserWithParameters (uint userID, string sessionID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters);

		[Export ("chatCallUserDidNotAnswer:")]
		void  CallUserDidNotAnswer(uint userID);

		[Export ("chatCallDidAcceptByUser:")]
		void  CallDidAcceptByUser(uint userID);

		[Export ("chatCallDidAcceptByUser:customParameters:")]
		void CallDidAcceptByUserWithCustomParameters (uint userID, NSDictionary customParameters);

		[Export ("chatCallDidRejectByUser:")]
		void  CallDidRejectByUser(uint userID);

		[Export ("chatCallDidStopByUser:status:")]
		void CallDidStopByUser (uint userID, string status);

		[Export ("chatCallDidStopByUser:status:customParameters:")]
		void CallDidStopByUserWithCustomParameters (uint userID, string status, NSDictionary customParameters);

		[Export ("chatCallDidStartWithUser:sessionID:")]
		void CallDidStartWithUser (uint userID, string sessionID);

		[Export ("didStartUseTURNForVideoChat")]
		void DidStartUseTURNForVideoChat ();

		[Export ("didReceiveAudioBuffer:")]
		void  DidReceiveAudioBuffe(AudioBuffer buffer);

		[Export ("chatDidReceivePrivacyListNames:")]
		void  ChatDidReceivePrivacyListNames( NSObject [] listNames);

		[Export ("chatDidReceivePrivacyList:")]
		void  ChatDidReceivePrivacyList(QBPrivacyList privacyList);

		[Export ("chatDidNotReceivePrivacyListNamesDueToError:")]
		void ChatDidNotReceivePrivacyListNames (NSObject error);

		[Export ("chatDidNotReceivePrivacyListWithName:error:")]
		void ChatDidNotReceivePrivacyListWithName (string name, NSObject error);

		[Export ("chatDidSetPrivacyListWithName:")]
		void ChatDidSetPrivacyListWithName (string name);

		[Export ("chatDidSetActivePrivacyListWithName:")]
		void  ChatDidSetActivePrivacyListWithName(string name);

		[Export ("chatDidSetDefaultPrivacyListWithName:")]
		void  ChatDidSetDefaultPrivacyListWithNam(string name);

		[Export ("chatDidNotSetPrivacyListWithName:error:")]
		void ChatDidNotSetPrivacyListWithName (string name, NSObject error);

		[Export ("chatDidNotSetActivePrivacyListWithName:error:")]
		void ChatDidNotSetActivePrivacyListWithName (string name, NSObject error);

		[Export ("chatDidNotSetDefaultPrivacyListWithName:error:")]
		void ChatDidNotSetDefaultPrivacyListWithName (string name, NSObject error);

		[Export ("chatDidRemovedPrivacyListWithName:")]
		void ChatDidRemovedPrivacyListWithName (string name);

		[Export ("chatDidReceiveUserIsTypingFromUserWithID:")]
		void ChatDidReceiveUserIsTypingFromUserWithID (uint userID);

		[Export ("chatDidReceiveUserStopTypingFromUserWithID:")]
		void ChatDidReceiveUserStopTypingFromUserWithID (uint userID);

		[Export ("chatDidDeliverMessageWithPacketID:")]
		void ChatDidDeliverMessageWithPacketID (string packetID);

		[Export ("chatTURNServerDidDisconnect")]
		void ChatTURNServerDidDisconnect ();

		[Export ("chatTURNServerdidFailWithError:")]
		void ChatTURNServerdidFailWithError (NSError error);

		[Export ("chatDidPassConnectionStep:totalSteps:")]
		void ChatDidPassConnectionStep (uint step, uint totalSteps);

		[Export ("chatDidExceedWriteVideoQueueMaxOperationsThresholdWithCount:")]
		void  ChatDidExceedWriteVideoQueueMaxOperationsThresholdWithCount(uint operationsInQueue);

		[Export ("chatDidExceedWriteAudioQueueMaxOperationsThresholdWithCount:")]
		void  ChatDidExceedWriteAudioQueueMaxOperationsThresholdWithCount(uint operationsInQueue);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBVideoChat {

		[Export ("isUseCustomVideoChatCaptureSession")]
		bool IsUseCustomVideoChatCaptureSession { get; set; }

		[Export ("isUseCustomAudioChatSession")]
		bool IsUseCustomAudioChatSession { get; set; }

		[Export ("viewToRenderOpponentVideoStream", ArgumentSemantic.Retain)]
		UIView ViewToRenderOpponentVideoStream { get; set; }

		[Export ("viewToRenderOwnVideoStream", ArgumentSemantic.Retain)]
		UIView ViewToRenderOwnVideoStream { get; set; }

		[Export ("videoChatOpponentID")]
		uint VideoChatOpponentID { get; }

		[Export ("relayUsed")]
		bool RelayUsed { [Bind ("isRelayUsed")] get; }

		[Export ("useBackCamera")]
		bool UseBackCamera { get; set; }

		[Export ("useHeadphone")]
		bool UseHeadphone { get; set; }

		[Export ("cameraFlashEnabled")]
		bool CameraFlashEnabled { [Bind ("isCameraFlashEnabled")] get; set; }

		[Export ("microphoneEnabled")]
		bool MicrophoneEnabled { [Bind ("isMicrophoneEnabled")] get; set; }

		[Export ("sessionID", ArgumentSemantic.Retain)]
		string SessionID { get; }

		[Export ("state")]
		QBVideoChatState State { get; }

		[Export ("callUser:conferenceType:")]
		void CallUser (uint userID, QBVideoChatConferenceType conferenceType);

		[Export ("callUser:conferenceType:customParameters:")]
		void CallUser (uint userID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters);

		[Export ("cancelCall")]
		void CancelCall ();

		[Export ("acceptCallWithOpponentID:conferenceType:")]
		void AcceptCallWithOpponentID (uint userID, QBVideoChatConferenceType conferenceType);

		[Export ("acceptCallWithOpponentID:conferenceType:customParameters:")]
		void AcceptCallWithOpponentID (uint userID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters);

		[Export ("rejectCallWithOpponentID:")]
		void RejectCallWithOpponentID (uint userID);

		[Export ("finishCall")]
		void FinishCall ();

		[Export ("finishCallWithCustomParameters:")]
		void FinishCallWithCustomParameters (NSDictionary customParameters);

		[Export ("videoOutputPreset")]
		string VideoOutputPreset { set; }

		[Export ("canSetVideoOutputPreset:")]
		bool CanSetVideoOutputPreset (string preset);

		[Export ("processVideoChatCaptureVideoSample:")]
		void ProcessVideoChatCaptureVideoSample (CMSampleBuffer sampleBuffer);

		[Export ("processVideoChatCaptureAudioBuffer:")]
		void ProcessVideoChatCaptureAudioBuffer (AudioBuffer buffer);

		[Export ("drainWriteVideoQueue")]
		void DrainWriteVideoQueue ();

		[Export ("drainWriteAudioQueue")]
		void DrainWriteAudioQueue ();

		[Export ("suspendStream:")]
		void SuspendStream (bool isSuspend);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBChatDialog {

		[Export ("ID", ArgumentSemantic.Retain)]
		string ID { get; set; }

		[Export ("roomJID", ArgumentSemantic.Retain)]
		string RoomJID { get; set; }

		[Export ("type")]
		QBChatDialogType Type { get; set; }

		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; set; }

		[Export ("photo", ArgumentSemantic.Retain)]
		string Photo { get; set; }

		[Export ("lastMessageText", ArgumentSemantic.Retain)]
		string LastMessageText { get; set; }

		[Export ("lastMessageDate", ArgumentSemantic.Retain)]
		NSDate LastMessageDate { get; set; }

		[Export ("lastMessageUserID")]
		uint LastMessageUserID { get; set; }

		[Export ("unreadMessagesCount")]
		uint UnreadMessagesCount { get; set; }

		[Export ("occupantIDs")]
		NSObject [] OccupantIDs { get; set; }

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("recipientID")]
		int RecipientID { get; }

		[Export ("chatRoom")]
		QBChatRoom ChatRoom { get; }
	}


	[BaseType (typeof (QBChatAbstractMessage))]
	public partial interface QBChatHistoryMessage {

		[Export ("dialogID", ArgumentSemantic.Copy)]
		string DialogID { get; set; }

		[Export ("read")]
		bool Read { [Bind ("isRead")] get; set; }
	}



	[BaseType (typeof (NSObject))]
	public partial interface QBChat {

		[Export ("delegate", ArgumentSemantic.Retain)]
		QBChatDelegate Delegate { get; set; }

		[Export ("contactList")]
		QBContactList ContactList { get; }

		[Export ("useMutualSubscriptionForContactList")]
		bool UseMutualSubscriptionForContactList { get; set; }

		[Export ("registeredVideoChatInstances")]
		NSMutableArray RegisteredVideoChatInstances { get; }

		[Static, Export ("instance")]
		QBChat Instance { get; }

		[Export ("loginWithUser:")]
		bool LoginWithUser (QBUUser user);

		[Export ("isLoggedIn")]
		bool IsLoggedIn { get; }

		[Export ("logout")]
		bool Logout();

		[Export ("sendMessage:")]
		bool SendMessage (QBChatMessage message);

		[Export ("sendMessage:sentBlock:")]
		bool SendMessage (QBChatMessage message, ErrorCallback sentBlock);

		[Export ("sendPresence")]
		bool SendPresence();

		[Export ("sendPresenceWithStatus:")]
		bool SendPresenceWithStatus (string status);

		[Export ("sendDirectPresenceWithStatus:toUser:")]
		bool SendDirectPresenceWithStatus (string status, uint userID);

		[Export ("currentUser")]
		QBUUser CurrentUser { get; }

		[Export ("addUserToContactListRequest:")]
		bool AddUserToContactListRequest (uint userID);

		[Export ("removeUserFromContactList:")]
		bool RemoveUserFromContactList (uint userID);

		[Export ("confirmAddContactRequest:")]
		bool ConfirmAddContactRequest (uint userID);

		[Export ("rejectAddContactRequest:")]
		bool RejectAddContactRequest (uint userID);

		[Export ("createOrJoinRoomWithName:membersOnly:persistent:")]
		bool CreateOrJoinRoomWithName (string name, bool isMembersOnly, bool isPersistent);

		[Export ("createOrJoinRoomWithJID:membersOnly:persistent:historyAttribute:")]
		bool CreateOrJoinRoomWithJID (string roomJID, bool isMembersOnly, bool isPersistent, NSDictionary historyAttribute);

		[Export ("createOrJoinRoomWithName:nickname:membersOnly:persistent:")]
		bool CreateOrJoinRoomWithName (string name, string nickname, bool isMembersOnly, bool isPersistent);

		[Export ("createOrJoinRoomWithJID:nickname:membersOnly:persistent:historyAttribute:")]
		bool CreateOrJoinRoomWithJID (string roomJID, string nickname, bool isMembersOnly, bool isPersistent, NSDictionary historyAttribute);

		[Export ("joinRoom:")]
		bool JoinRoom (QBChatRoom room);

		[Export ("joinRoom:historyAttribute:")]
		bool JoinRoom (QBChatRoom room, NSDictionary historyAttribute);

		[Export ("leaveRoom:")]
		bool LeaveRoom (QBChatRoom room);

		[Export ("destroyRoom:")]
		bool DestroyRoom (QBChatRoom room);

		[Export ("sendMessage:toRoom:")]
		bool SendMessage (string message, QBChatRoom room);

		[Export ("sendChatMessage:toRoom:")]
		bool SendChatMessage (QBChatMessage message, QBChatRoom room);

		[Export ("sendPresenceWithParameters:toRoom:")]
		bool SendPresenceWithParameters (NSDictionary parameters, QBChatRoom room);

		[Export ("sendPresenceWithStatus:show:priority:customParameters:toRoom:")]
		bool SendPresenceWithStatus (string status, QBPresenseShow show, short priority, NSDictionary customParameters, QBChatRoom room);

		[Export ("requestAllRooms")]
		bool RequestAllRooms();

		[Export ("requestRoomInformation:")]
		bool RequestRoomInformation (QBChatRoom room);

		[Export ("requestRoomUsers:")]
		bool RequestRoomUsers (QBChatRoom room);

		[Export ("requestRoomOnlineUsers:")]
		bool RequestRoomOnlineUsers (QBChatRoom room);

		[Export ("addUsers:toRoom:")]
		bool AddUsers (NSObject [] usersIDs, QBChatRoom room);

		[Export ("deleteUsers:fromRoom:")]
		bool DeleteUsers (NSObject [] usersIDs, QBChatRoom room);

		[Export ("createAndRegisterVideoChatInstance")]
		QBVideoChat CreateAndRegisterVideoChatInstance();

		[Export ("createAndRegisterVideoChatInstanceWithSessionID:")]
		QBVideoChat CreateAndRegisterVideoChatInstanceWithSessionID (string sessionID);

		[Export ("unregisterVideoChatInstance:")]
		void UnregisterVideoChatInstance (QBVideoChat videoChat);

		[Static, Export ("dialogsWithDelegate:")]
		NSObject DialogsWithDelegate (NSObject delgate);

		[Static, Export ("dialogsWithDelegate:context:")]
		NSObject DialogsWithDelegate (NSObject delgate, NSObject context);

		[Static, Export ("dialogsWithExtendedRequest:delegate:")]
		NSObject DialogsWithExtendedRequest (NSMutableDictionary extendedRequest, NSObject delgate);

		[Static, Export ("dialogsWithExtendedRequest:delegate:context:")]
		NSObject DialogsWithExtendedRequest (NSMutableDictionary extendedRequest, NSObject delgate, NSObject context);

		[Static, Export ("createDialog:delegate:")]
		NSObject CreateDialog (QBChatDialog dialog, NSObject delgate);

		[Static, Export ("createDialog:delegate:context:")]
		NSObject CreateDialog (QBChatDialog dialog, NSObject delgate, NSObject context);

		[Static, Export ("updateDialogWithID:extendedRequest:delegate:")]
		NSObject UpdateDialogWithID (string dialogID, NSMutableDictionary extendedRequest, NSObject delgate);

		[Static, Export ("updateDialogWithID:extendedRequest:delegate:context:")]
		NSObject UpdateDialogWithID (string dialogID, NSMutableDictionary extendedRequest, NSObject delgate, NSObject context);

		[Static, Export ("messagesWithDialogID:delegate:")]
		NSObject MessagesWithDialogID (string dialogID, NSObject delgate);

		[Static, Export ("messagesWithDialogID:delegate:context:")]
		NSObject MessagesWithDialogID (string dialogID, NSObject delgate, NSObject context);

		[Static, Export ("messagesWithDialogID:extendedRequest:delegate:")]
		NSObject MessagesWithDialogID (string dialogID, NSMutableDictionary extendedRequest, NSObject delgate);

		[Static, Export ("messagesWithDialogID:extendedRequest:delegate:context:")]
		NSObject MessagesWithDialogID (string dialogID, NSMutableDictionary extendedRequest, NSObject delgate, NSObject context);

		[Static, Export ("createMessage:delegate:")]
		NSObject CreateMessage (QBChatHistoryMessage message, NSObject delgate);

		[Static, Export ("createMessage:delegate:context:")]
		NSObject CreateMessage (QBChatHistoryMessage message, NSObject delgate, NSObject context);

		[Static, Export ("updateMessage:delegate:")]
		NSObject UpdateMessage (QBChatHistoryMessage message, NSObject delgate);

		[Static, Export ("updateMessage:delegate:context:")]
		NSObject UpdateMessage (QBChatHistoryMessage message, NSObject delgate, NSObject context);

		[Static, Export ("markMessagesAsRead:dialogID:delegate:")]
		NSObject MarkMessagesAsRead (NSObject [] messagesIDs, string dialogID, NSObject delgate);

		[Static, Export ("markMessagesAsRead:dialogID:delegate:context:")]
		NSObject MarkMessagesAsRead (NSObject [] messagesIDs, string dialogID, NSObject delgate, NSObject context);

		[Static, Export ("deleteMessageWithID:delegate:")]
		NSObject DeleteMessageWithID (string messageID, NSObject delgate);

		[Static, Export ("deleteMessageWithID:delegate:context:")]
		NSObject DeleteMessageWithID (string messageID, NSObject delgate, NSObject context);

		[Export ("retrievePrivacyListWithName:")]
		void RetrievePrivacyListWithName (string privacyListName);

		[Export ("retrievePrivacyListNames")]
		void RetrievePrivacyListNames ();

		[Export ("privacyList")]
		QBPrivacyList PrivacyList { set; }

		[Export ("activePrivacyListWithName")]
		string ActivePrivacyListWithName { set; }

		[Export ("defaultPrivacyListWithName")]
		string DefaultPrivacyListWithName { set; }

		[Export ("removePrivacyListWithName:")]
		void RemovePrivacyListWithName (string privacyListName);

		[Export ("sendUserIsTypingToUserWithID:")]
		void SendUserIsTypingToUserWithID (uint userID);

		[Export ("sendUserStopTypingToUserWithID:")]
		void SendUserStopTypingToUserWithID (uint userID);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBPrivacyList {

		[Export ("initWithName:items:")]
		IntPtr Constructor (string name, NSObject [] items);

		[Export ("addObject:")]
		void AddObject (QBPrivacyItem privacyItem);

		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; set; }

		[Export ("items", ArgumentSemantic.Retain)]
		NSMutableArray Items { get; set; }

		[Export ("count")]
		uint Count { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBPrivacyItem {

		[Export ("initWithType:valueForType:action:")]
		IntPtr Constructor (QBPrivacyItemType type, uint valueForType, QBPrivacyItemAction action);

		[Export ("type")]
		QBPrivacyItemType Type { get; set; }

		[Export ("valueForType")]
		uint ValueForType { get; set; }

		[Export ("action")]
		QBPrivacyItemAction Action { get; set; }
	}


	[BaseType (typeof (Entity))]
	public partial interface QBUUser {

		[Export ("externalUserID")]
		uint ExternalUserID { get; set; }

		[Export ("blobID")]
		int BlobID { get; set; }

		[Export ("facebookID", ArgumentSemantic.Retain)]
		string FacebookID { get; set; }

		[Export ("twitterID", ArgumentSemantic.Retain)]
		string TwitterID { get; set; }

		[Export ("fullName", ArgumentSemantic.Retain)]
		string FullName { get; set; }

		[Export ("email", ArgumentSemantic.Retain)]
		string Email { get; set; }

		[Export ("login", ArgumentSemantic.Retain)]
		string Login { get; set; }

		[Export ("phone", ArgumentSemantic.Retain)]
		string Phone { get; set; }

		[Export ("website", ArgumentSemantic.Retain)]
		string Website { get; set; }

		[Export ("tags", ArgumentSemantic.Retain)]
		NSMutableArray Tags { get; set; }

		[Export ("password", ArgumentSemantic.Retain)]
		string Password { get; set; }

		[Export ("oldPassword", ArgumentSemantic.Retain)]
		string OldPassword { get; set; }

		[Export ("lastRequestAt", ArgumentSemantic.Retain)]
		NSDate LastRequestAt { get; set; }

		[Export ("customData", ArgumentSemantic.Retain)]
		string CustomData { get; set; }

		[Static, Export ("user")]
		QBUUser User { get; }
	}




	[BaseType (typeof (NSObject))]
	public partial interface QBResponse {

		[Export ("success")]
		bool Success { [Bind ("isSuccess")] get; }

		[Export ("status")]
		QBResponseStatusCode Status { get; }

		[Export ("headers")]
		NSDictionary Headers { get; }

		[Export ("data")]
		NSData Data { get; }

		[Export ("error")]
		QBError Error { get; }

		[Export ("requestUrl")]
		NSUrl RequestUrl { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface Entity {

		[Export ("ID")]
		uint ID { get; set; }

		[Export ("createdAt", ArgumentSemantic.Retain)]
		NSDate CreatedAt { get; set; }

		[Export ("updatedAt", ArgumentSemantic.Retain)]
		NSDate UpdatedAt { get; set; }
	}


	[BaseType (typeof (Entity))]
	public partial interface QBASession {

		[Export ("token", ArgumentSemantic.Retain)]
		string Token { get; set; }

		[Export ("applicationID")]
		uint ApplicationID { get; set; }

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("deviceID")]
		uint DeviceID { get; set; }

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("nonce")]
		int Nonce { get; set; }
	}


	[BaseType (typeof (NSObject))]
	public partial interface QBApplication {

		[Static, Export ("sharedApplication")]
		QBApplication Shared { get; }

		[Export ("applicationId")]
		uint ApplicationID { get; set; }

	}

	[BaseType (typeof (NSObject))]
	public partial interface QBConnection {

		[Static, Export ("registerServiceKey:")]
		void RegisterServiceKey (string key);

		[Static, Export ("registerServiceSecret:")]
		void RegisterServiceSecret (string secret);

	}


	[BaseType (typeof (NSObject))]
	public partial interface QBSettings {

		[Static, Export ("setAccountKey:")]
		void SetAccountKey (string key);

		[Static, Export ("useProductionEnvironmentForPushNotifications:")]
		void UseProductionEnvironmentForPushNotifications (bool useProductionEnvironment);

	}


	[BaseType (typeof (NSObject))]
	public partial interface QBSessionParameters {

		[Export ("userLogin")]
		string UserLogin { get; set; }

		[Export ("userPassword")]
		string UserPassword { get; set; }

	}


	public delegate void SessionCallback (QBResponse response, QBASession session);
	public delegate void ResponseCallback (QBResponse response);
	public delegate void ResponseTokenCallback (QBResponse response, QBMPushToken token);
	public delegate void ResponseEventCallback (QBResponse response, QBMEvent evnt);
	public delegate void ResponseEventsCallback (QBResponse response, NSObject[] evnts);
	public delegate void ResponsePageEventsCallback (QBResponse response, QBGeneralResponsePage page, NSObject[] evnts);
	public delegate void ResponseSubscribeCallback (QBResponse response, NSObject[] subscribers);
	public delegate void ErrorCallback (NSError response);
	public delegate void QBErrorBlock (QBError error);

	[BaseType (typeof (NSObject))]
	public partial interface QBGeneralResponsePage {

		[Export ("totalEntries")]
		uint TotalEntries { get; }

		[Export ("currentPage")]
		uint CurrentPage { get; set; }

		[Export ("perPage")]
		uint PerPage { get; set; }

		[Static, Export ("responsePageWithCurrentPage:perPage:totalEntries:")]
		QBGeneralResponsePage ResponsePageWithCurrentPage (uint currentPage, uint perPage, uint totalEntries);

		[Static, Export ("responsePageWithCurrentPage:perPage:")]
		QBGeneralResponsePage ResponsePageWithCurrentPage (uint currentPage, uint perPage);
	}

	[BaseType (typeof (Entity))]
	public partial interface QBMPushToken {

		[Export ("clientIdentificationSequence", ArgumentSemantic.Retain)]
		string ClientIdentificationSequence { get; set; }

		[Export ("isEnvironmentDevelopment")]
		bool IsEnvironmentDevelopment { get; set; }

		[Static, Export ("pushToken")]
		QBMPushToken CreatePushToken ();
	}

	[BaseType (typeof (Entity))]
	public partial interface QBMEvent {

		[Export ("active")]
		bool Active { get; set; }

		[Export ("notificationType")]
		QBMNotificationType NotificationType { get; set; }

		[Export ("pushType")]
		QBMPushType PushType { get; set; }

		[Export ("usersIDs", ArgumentSemantic.Retain)]
		string UsersIDs { get; set; }

		[Export ("usersExternalIDs", ArgumentSemantic.Retain)]
		string UsersExternalIDs { get; set; }

		[Export ("usersTagsAny", ArgumentSemantic.Retain)]
		string UsersTagsAny { get; set; }

		[Export ("usersTagsAll", ArgumentSemantic.Retain)]
		string UsersTagsAll { get; set; }

		[Export ("usersTagsExclude", ArgumentSemantic.Retain)]
		string UsersTagsExclude { get; set; }

		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; set; }

		[Export ("isDevelopmentEnvironment")]
		bool IsDevelopmentEnvironment { get; set; }

		[Export ("message", ArgumentSemantic.Retain)]
		NSObject Message { get; set; }

		[Export ("type")]
		QBMEventType Type { get; set; }

		[Export ("date", ArgumentSemantic.Retain)]
		NSDate Date { get; set; }

		[Export ("endDate", ArgumentSemantic.Retain)]
		NSDate EndDate { get; set; }

		[Export ("period")]
		uint Period { get; set; }

		[Export ("occuredCount")]
		uint OccuredCount { get; set; }

		[Export ("senderID")]
		uint SenderID { get; set; }

		[Static, Export ("event")]
		QBMEvent CreateEvent ();

		[Export ("prepareMessage")]
		void PrepareMessage ();

		[Static, Export ("eventTypeFromString:")]
		QBMEventType EventTypeFromString (string eventType);

		[Static, Export ("eventTypeToString:")]
		string EventTypeToString (QBMEventType eventType);

		[Static, Export ("notificationTypeFromString:")]
		QBMNotificationType NotificationTypeFromString (string notificationType);

		[Static, Export ("notificationTypeToString:")]
		string NotificationTypeToString (QBMNotificationType notificationType);

		[Static, Export ("pushTypeFromString:")]
		QBMPushType PushTypeFromString (string pushType);

		[Static, Export ("pushTypeToString:")]
		string PushTypeToString (QBMPushType pushType);

		[Static, Export ("messageToString:")]
		string MessageToString (NSDictionary message);

		[Static, Export ("messageFromString:")]
		NSDictionary MessageFromString (string message);
	}

	[BaseType (typeof (Entity))]
	public partial interface QBMSubscription {

		[Export ("notificationChannel")]
		QBMNotificationChannel NotificationChannel { get; set; }

		[Export ("deviceUDID", ArgumentSemantic.Retain)]
		string DeviceUDID { get; set; }

		[Export ("devicePlatform", ArgumentSemantic.Retain)]
		string DevicePlatform { get; set; }

		[Export ("url", ArgumentSemantic.Retain)]
		string Url { get; set; }

		[Static, Export ("subscription")]
		QBMSubscription CreateSubscription();

		[Static, Export ("notificationChannelFromString:")]
		QBMNotificationChannel NotificationChannelFromString (string notificationChannel);

		[Static, Export ("notificationChannelToString:")]
		string NotificationChannelToString (QBMNotificationChannel notificationChannel);
	}


	[BaseType (typeof (NSObject))]
	public partial interface QBRequest {

		[Static, Export ("createSessionWithExtendedParameters:successBlock:errorBlock:")]
		void CreateSession (QBSessionParameters parameters, SessionCallback success, ResponseCallback error);


		[Static, Export ("createPushToken:successBlock:errorBlock:")]
		void CreatePushToken (QBMPushToken pushToken, ResponseTokenCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("deletePushTokenWithID:successBlock:errorBlock:")]
		void DeletePushTokenWithID (uint ID, ResponseCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("createSubscription:successBlock:errorBlock:")]
		void CreateSubscription (QBMSubscription subscriber, ResponseSubscribeCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("subscriptionsWithSuccessBlock:errorBlock:")]
		void Subscriptions (ResponseSubscribeCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("deleteSubscriptionWithID:successBlock:errorBlock:")]
		void DeleteSubscriptionWithID (uint ID, ResponseCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("createEvent:successBlock:errorBlock:")]
		void CreateEvent (QBMEvent evnt, ResponseEventsCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("eventsForPage:successBlock:errorBlock:")]
		void EventsForPage (QBGeneralResponsePage page, ResponsePageEventsCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("eventWithID:successBlock:errorBlock:")]
		void EventWithID (uint ID, ResponseEventCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("updateEvent:successBlock:errorBlock:")]
		void UpdateEvent (QBMEvent evnt, ResponseEventCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("deleteEventWithID:successBlock:errorBlock:")]
		void DeleteEventWithID (uint ID, ResponseCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("registerSubscriptionForDeviceToken:successBlock:errorBlock:")]
		void RegisterSubscriptionForDeviceToken (NSData deviceToken, ResponseSubscribeCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("unregisterSubscriptionWithSuccessBlock:errorBlock:")]
		void UnregisterSubscriptionWithSuccessBlock (ResponseCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("sendPush:toUsers:successBlock:errorBlock:")]
		void SendPushToUsers (QBMPushMessage pushMessage, string usersIDs, ResponseEventCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("sendPushWithText:toUsers:successBlock:errorBlock:")]
		void SendPushWithText (string text, string usersIDs, ResponseEventsCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("sendPush:toUsersWithAnyOfTheseTags:successBlock:errorBlock:")]
		void SendPushToUsersWithTags (QBMPushMessage pushMessage, string usersTags, ResponseEventCallback successBlock, QBErrorBlock errorBlock);

		[Static, Export ("sendPushWithText:toUsersWithAnyOfTheseTags:successBlock:errorBlock:")]
		void SendPushWithTextToUsersWithTaqgs (string text, string usersTags, ResponseEventsCallback successBlock, QBErrorBlock errorBlock);

	}


	[BaseType (typeof (NSObject))]
	public partial interface QBMPushMessageBase {

		[Export ("payloadDict", ArgumentSemantic.Retain)]
		NSMutableDictionary PayloadDict { get; set; }

		[Export ("initWithPayload:")]
		IntPtr Constructor (NSDictionary payload);

		[Export ("json")]
		string Json { get; }

		[Export ("charsLeft")]
		int CharsLeft { get; }
	}

	[BaseType (typeof (QBMPushMessageBase))]
	public partial interface QBMPushMessage {

		[Export ("alertBody", ArgumentSemantic.Retain)]
		string AlertBody { get; set; }

		[Export ("badge", ArgumentSemantic.Retain)]
		NSNumber Badge { get; set; }

		[Export ("soundFile", ArgumentSemantic.Retain)]
		string SoundFile { get; set; }

		[Export ("localizedBodyKey", ArgumentSemantic.Retain)]
		string LocalizedBodyKey { get; set; }

		[Export ("localizedBodyArguments", ArgumentSemantic.Retain)]
		NSObject [] LocalizedBodyArguments { get; set; }

		[Export ("localizedActionKey", ArgumentSemantic.Retain)]
		string LocalizedActionKey { get; set; }

		[Export ("additionalInfo", ArgumentSemantic.Retain)]
		NSDictionary AdditionalInfo { get; set; }

		[Static, Export ("pushMessage")]
		QBMPushMessage CreatePushMessage ();
	}


	[BaseType (typeof (NSObject))]
	public partial interface QBError {

		[Export ("reasons")]
		NSDictionary Reasons { get; }

		[Export ("error")]
		NSError Error { get; }

		[Static, Export ("errorWithError:")]
		QBError ErrorWithError (NSError error);
	}
}



