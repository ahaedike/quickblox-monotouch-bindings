

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


namespace QuickBlox
{
	
	
	[BaseType (typeof (NSObject))]
	public partial interface QBSettings {

		[Static, Export ("applicationID")]
		uint ApplicationID { get; set; }

		[Static, Export ("authorizationKey")]
		string AuthorizationKey { get; set; }

		[Static, Export ("authorizationSecret")]
		string AuthorizationSecret { get; set; }

		[Static, Export ("serverDomain")]
		string ServerDomain { get; set; }
		
		[Static, Export ("serverApiDomain")]
		string ServerApiDomain { get; set; }

		[Static, Export ("serverChatDomain")]
		string ServerChatDomain { get; set; }

		[Static, Export ("serverZone")]
		QBServerZone ServerZone { get; set; }

		[Static, Export ("serverZoneAsString")]
		string ServerZoneAsString { get; }

		[Static, Export ("useHTTPS:")]
		void UseHTTPS (bool useHTTPS);

		[Static, Export ("isUseHTTPS")]
		bool IsUseHTTPS { get; }

		[Static, Export ("logLevel")]
		QBLogLevel LogLevel { get; set; }

		[Static, Export ("timeOutSeconds")]
		int TimeOutSeconds { get; set; }

		[Static, Export ("restAPIVersion")]
		string RestAPIVersion { get; set; }

		[Static, Export ("enableSessionExpirationAutoHandler:")]
		void EnableSessionExpirationAutoHandler (bool isEnable);

		[Static, Export ("isEnabledSessionExpirationAutoHandler")]
		bool IsEnabledSessionExpirationAutoHandler { get; }

		[Static, Export ("useProductionEnvironmentForPushNotifications:")]
		void UseProductionEnvironmentForPushNotifications (bool useProductionEnvironment);

		[Static, Export ("isUseProductionEnvironmentForPushNotifications")]
		bool IsUseProductionEnvironmentForPushNotifications { get; }

		[Static, Export ("contentBucket")]
		string ContentBucket { get; set; }

		[Static, Export ("videoChatConfiguration")]
		NSDictionary VideoChatConfiguration { get; set; }
	}
	
	[BaseType (typeof (NSObject))]
	public interface QBAuth {

		[Static, Export ("createSessionWithDelegate:")]
		Cancelable CreateSessionWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("createSessionWithDelegate:context:")]
		Cancelable CreateSessionWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("createSessionWithExtendedRequest:delegate:")]
		NSObject CreateSessionWithExtendedRequest (QBASessionCreationRequest extendedRequest, NSObject del);

		[Static, Export ("createSessionWithExtendedRequest:delegate:context:")]
		NSObject CreateSessionWithExtendedRequest (QBASessionCreationRequest extendedRequest, NSObject del,  NSObject context);

		[Static, Export ("destroySessionWithDelegate:")]
		NSObject DestroySessionWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("destroySessionWithDelegate:context:")]
		NSObject DestroySessionWithDelegate (QBActionStatusDelegate del, NSObject context);
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBUsers {

		[Static, Export ("logInWithUserLogin:password:delegate:")]
		NSObject LogInWithUserLogin (string login, string password, QBActionStatusDelegate del);

		[Static, Export ("logInWithUserLogin:password:delegate:context:")]
		NSObject LogInWithUserLogin (string login, string password, QBActionStatusDelegate del,  NSObject context);

		[Static, Export ("logInWithUserEmail:password:delegate:")]
		NSObject LogInWithUserEmail (string email, string password, QBActionStatusDelegate del);

		[Static, Export ("logInWithUserEmail:password:delegate:context:")]
		NSObject LogInWithUserEmail (string email, string password, QBActionStatusDelegate del,  NSObject context);

		[Static, Export ("logInWithSocialProvider:scope:delegate:")]
		NSObject LogInWithSocialProvider (string provider, NSObject [] scope, QBActionStatusDelegate del);

		[Static, Export ("logInWithSocialProvider:scope:delegate:context:")]
		NSObject LogInWithSocialProvider (string provider, NSObject [] scope, QBActionStatusDelegate del,  NSObject context);

		[Static, Export ("logInWithSocialProvider:accessToken:accessTokenSecret:delegate:")]
		NSObject LogInWithSocialProvider (string provider, string accessToken, string accessTokenSecret, QBActionStatusDelegate del);

		[Static, Export ("logInWithSocialProvider:accessToken:accessTokenSecret:delegate:context:")]
		NSObject LogInWithSocialProvider (string provider, string accessToken, string accessTokenSecret, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("logOutWithDelegate:")]
		NSObject LogOutWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("logOutWithDelegate:context:")]
		NSObject LogOutWithDelegate (NSObject del, QBActionStatusDelegate context);

		[Static, Export ("usersWithDelegate:")]
		NSObject UsersWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("usersWithDelegate:context:")]
		NSObject UsersWithDelegate (NSObject del, QBActionStatusDelegate context);

		[Static, Export ("usersWithPagedRequest:delegate:")]
		NSObject UsersWithPagedRequest (PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithPagedRequest:delegate:context:")]
		NSObject UsersWithPagedRequest (PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("signUp:delegate:")]
		NSObject SignUp (QBUUser user, QBActionStatusDelegate del);

		[Static, Export ("signUp:delegate:context:")]
		NSObject SignUp (QBUUser user, NSObject del, QBActionStatusDelegate context);

		[Static, Export ("userWithID:delegate:")]
		NSObject UserWithID (uint userID, QBActionStatusDelegate del);

		[Static, Export ("userWithID:delegate:context:")]
		NSObject UserWithID (uint userID, NSObject del, QBActionStatusDelegate context);

		[Static, Export ("usersWithIDs:delegate:")]
		NSObject UsersWithIDs (string ids, QBActionStatusDelegate del);

		[Static, Export ("usersWithIDs:delegate:context:")]
		NSObject UsersWithIDs (string ids, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithIDs:pagedRequest:delegate:")]
		NSObject UsersWithIDs (string ids, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithIDs:pagedRequest:delegate:context:")]
		NSObject UsersWithIDs (string ids, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("userWithLogin:delegate:")]
		NSObject UserWithLogin (string userLogin, QBActionStatusDelegate del);

		[Static, Export ("userWithLogin:delegate:context:")]
		NSObject UserWithLogin (string userLogin, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithLogins:delegate:")]
		NSObject UsersWithLogins (string[] logins, QBActionStatusDelegate del);

		[Static, Export ("usersWithLogins:delegate:context:")]
		NSObject UsersWithLogins (string[] logins, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithLogins:pagedRequest:delegate:")]
		NSObject UsersWithLogins (string[] logins, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithLogins:pagedRequest:delegate:context:")]
		NSObject UsersWithLogins (string[] logins, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithFullName:delegate:")]
		NSObject UsersWithFullName (string userFullName, QBActionStatusDelegate del);

		[Static, Export ("usersWithFullName:delegate:context:")]
		NSObject UsersWithFullName (string userFullName, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithFullName:pagedRequest:delegate:")]
		NSObject UsersWithFullName (string userFullName, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithFullName:pagedRequest:delegate:context:")]
		NSObject UsersWithFullName (string userFullName, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithTags:delegate:")]
		NSObject UsersWithTags (string[] tags, QBActionStatusDelegate del);

		[Static, Export ("usersWithTags:delegate:context:")]
		NSObject UsersWithTags (string[] tags, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithTags:pagedRequest:delegate:")]
		NSObject UsersWithTags (string[] tags, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithTags:pagedRequest:delegate:context:")]
		NSObject UsersWithTags (string[] tags, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithPhoneNumbers:delegate:")]
		NSObject UsersWithPhoneNumbers (string[] tags, QBActionStatusDelegate del);

		[Static, Export ("usersWithPhoneNumbers:delegate:context:")]
		NSObject UsersWithPhoneNumbers (string[] tags, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithPhoneNumbers:pagedRequest:delegate:")]
		NSObject UsersWithPhoneNumbers (string[] tags, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithPhoneNumbers:pagedRequest:delegate:context:")]
		NSObject UsersWithPhoneNumbers (string[] tags, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("userWithFacebookID:delegate:")]
		NSObject UserWithFacebookID (string userFacebookID, QBActionStatusDelegate del);

		[Static, Export ("userWithFacebookID:delegate:context:")]
		NSObject UserWithFacebookID (string userFacebookID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithFacebookIDs:delegate:")]
		NSObject UsersWithFacebookIDs (string[] facebookIDs, QBActionStatusDelegate del);

		[Static, Export ("usersWithFacebookIDs:delegate:context:")]
		NSObject UsersWithFacebookIDs (string[] facebookIDs, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithFacebookIDs:pagedRequest:delegate:")]
		NSObject UsersWithFacebookIDs (string[] facebookIDs, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithFacebookIDs:pagedRequest:delegate:context:")]
		NSObject UsersWithFacebookIDs (string[] facebookIDs, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("userWithTwitterID:delegate:")]
		NSObject UserWithTwitterID (string userTwitterID, QBActionStatusDelegate del);

		[Static, Export ("userWithTwitterID:delegate:context:")]
		NSObject UserWithTwitterID (string userTwitterID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithTwitterIDs:delegate:")]
		NSObject UsersWithTwitterIDs (string[] twitterIDs, QBActionStatusDelegate del);

		[Static, Export ("usersWithTwitterIDs:delegate:context:")]
		NSObject UsersWithTwitterIDs (string[] twitterIDs, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithTwitterIDs:pagedRequest:delegate:")]
		NSObject UsersWithTwitterIDs (string[] twitterIDs, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithTwitterIDs:pagedRequest:delegate:context:")]
		NSObject UsersWithTwitterIDs (string[] twitterIDs, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("userWithEmail:delegate:")]
		NSObject UserWithEmail (string userEmail, QBActionStatusDelegate del);

		[Static, Export ("userWithEmail:delegate:context:")]
		NSObject UserWithEmail (string userEmail, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithEmails:delegate:")]
		NSObject UsersWithEmails (string[] emails, QBActionStatusDelegate del);

		[Static, Export ("usersWithEmails:delegate:context:")]
		NSObject UsersWithEmails (string[] emails, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithEmails:pagedRequest:delegate:")]
		NSObject UsersWithEmails (string[] emails, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithEmails:pagedRequest:delegate:context:")]
		NSObject UsersWithEmails (string[] emails, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("userWithExternalID:delegate:")]
		NSObject UserWithExternalID (uint userExternalID, QBActionStatusDelegate del);

		[Static, Export ("userWithExternalID:delegate:context:")]
		NSObject UserWithExternalID (uint userExternalID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("updateUser:delegate:")]
		NSObject UpdateUser (QBUUser user, QBActionStatusDelegate del);

		[Static, Export ("updateUser:delegate:context:")]
		NSObject UpdateUser (QBUUser user, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("deleteUserWithID:delegate:")]
		NSObject DeleteUserWithID (uint userID, QBActionStatusDelegate del);

		[Static, Export ("deleteUserWithID:delegate:context:")]
		NSObject DeleteUserWithID (uint userID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("deleteUserWithExternalID:delegate:")]
		NSObject DeleteUserWithExternalID (uint userExternalID, QBActionStatusDelegate del);

		[Static, Export ("deleteUserWithExternalID:delegate:context:")]
		NSObject DeleteUserWithExternalID (uint userExternalID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("resetUserPasswordWithEmail:delegate:")]
		NSObject ResetUserPasswordWithEmail (string email, QBActionStatusDelegate del);

		[Static, Export ("resetUserPasswordWithEmail:delegate:context:")]
		NSObject ResetUserPasswordWithEmail (string email, QBActionStatusDelegate del, NSObject context);
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
	public partial interface QBUUser {

		[Export ("externalUserID")]
		uint ExternalUserID { get; set; }

		[Export ("blobID")]
		uint BlobID { get; set; }

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

		[Static, Export ("user")]
		QBUUser User ();
	}
	
	
	[BaseType (typeof (NSObject))]
	[Model]
	public partial interface Cancelable {
		[Export ("cancel")]
		void Cancel ();
	}
	
	
	[BaseType (typeof (NSObject))]
	[Model]
	public interface QBActionStatusDelegate {
		
		[Export ("completedWithResult:")]
		void CompletedWithResult(Result result);

		[Export ("completedWithResult:context:")]
		void Context (Result result, NSObject contextInfo);

		[Export ("progress")]
		float Progress { set; }

		[Export ("uploadProgress")]
		float UploadActionProgress { set; }
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

		[Export ("answer", ArgumentSemantic.Retain)]
		Answer Answer { get; set; }

		[Export ("initWithRequest:answer:")]
		IntPtr Constructor (Request req, Answer answ);

		[Export ("initWithAnswer:")]
		IntPtr Constructor (Answer answ);
	}
	
	[BaseType (typeof (Result))]
	public partial interface QBUUserResult {

		[Export ("user")]
		QBUUser User { get; }
	}
	
	[BaseType (typeof (QBUUserResult))]
	public partial interface QBUUserLogInResult {

		[Export ("socialProviderToken")]
		string SocialProviderToken { get; }

		[Export ("socialProviderTokenExpiresAt")]
		NSDate SocialProviderTokenExpiresAt { get; }
	}
	
	[BaseType (typeof (Result))]
	public partial interface PagedResult {

		[Export ("currentPage")]
		uint CurrentPage { get; }

		[Export ("totalPages")]
		uint TotalPages { get; }

		[Export ("perPage")]
		uint PerPage { get; }

		[Export ("totalEntries")]
		uint TotalEntries { get; }
	}

	
	[BaseType (typeof (PagedResult))]
	public partial interface QBUUserPagedResult {

		[Export ("users")]
		NSObject [] Users { get; }
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface Request {

		[Export ("parameters")]
		NSDictionary Parameters { get; }

		[Static, Export ("request")]
		Request CreateRequest ();
		
	}
	
	[BaseType (typeof (Request))]
	public partial interface PagedRequest {

		[Export ("page")]
		uint Page { get; set; }

		[Export ("perPage")]
		uint PerPage { get; set; }
	}
	
	
	[BaseType (typeof (Request))]
	public partial interface QBASessionCreationRequest {

		[Export ("socialProvider", ArgumentSemantic.Retain)]
		string SocialProvider { get; set; }

		[Export ("scope", ArgumentSemantic.Retain)]
		NSObject [] Scope { get; set; }

		[Export ("socialProviderAccessToken", ArgumentSemantic.Retain)]
		string SocialProviderAccessToken { get; set; }

		[Export ("socialProviderAccessTokenSecret", ArgumentSemantic.Retain)]
		string SocialProviderAccessTokenSecret { get; set; }

		[Export ("userLogin", ArgumentSemantic.Retain)]
		string UserLogin { get; set; }

		[Export ("userEmail", ArgumentSemantic.Retain)]
		string UserEmail { get; set; }

		[Export ("userPassword", ArgumentSemantic.Retain)]
		string UserPassword { get; set; }

	}

	
	
	[BaseType (typeof (NSObject))]
	public partial interface Answer {

		[Export ("errors", ArgumentSemantic.Retain)]
		NSMutableArray Errors { get; set; }

		[Export ("query", ArgumentSemantic.Assign)]
		QBQuery Query { get; set; }

		[Export ("allocResult")]
		Result AllocResult ();
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBQuery  {
		//Empty binding to compile
	}

	
	[BaseType (typeof (NSObject))]
	public partial interface QBChat {

		[Export ("delegate", ArgumentSemantic.Retain)]
		QBChatDelegate Delegate { get; set; }

		[Export ("contactList")]
		QBContactList ContactList { get; }

		[Export ("registeredVideoChatInstances")]
		NSMutableArray RegisteredVideoChatInstances { get; }

		[Static, Export ("instance")]
		QBChat Instance { get; }

		[Export ("loginWithUser:")]
		bool LoginWithUser (QBUUser user);

		[Export ("isLoggedIn")]
		bool IsLoggedIn { get; }

		[Export ("logout")]
		bool Logout ();

		[Export ("sendMessage:")]
		bool SendMessage (QBChatMessage message);

		[Export ("sendPresence")]
		bool SendPresence ();

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

		[Export ("createOrJoinRoomWithName:nickname:membersOnly:persistent:")]
		bool CreateOrJoinRoomWithName (string name, string nickname, bool isMembersOnly, bool isPersistent);

		[Export ("joinRoom:")]
		bool JoinRoom (QBChatRoom room);

		[Export ("leaveRoom:")]
		bool LeaveRoom (QBChatRoom room);

		[Export ("destroyRoom:")]
		bool DestroyRoom (QBChatRoom room);

		[Export ("sendMessage:toRoom:")]
		bool SendMessage (string message, QBChatRoom room);

		[Export ("sendPresenceWithParameters:toRoom:")]
		bool SendPresenceWithParameters (NSDictionary parameters, QBChatRoom room);

		[Export ("sendPresenceWithStatus:show:priority:customParameters:toRoom:")]
		bool SendPresenceWithStatus (string status, QBPresenseShow show, short priority, NSDictionary customParameters, QBChatRoom room);

		[Export ("requestAllRooms")]
		bool RequestAllRooms { get; }

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
		QBVideoChat CreateAndRegisterVideoChatInstance { get; }

		[Export ("createAndRegisterVideoChatInstanceWithSessionID:")]
		QBVideoChat CreateAndRegisterVideoChatInstanceWithSessionID (string sessionID);

		[Export ("unregisterVideoChatInstance:")]
		void UnregisterVideoChatInstance (QBVideoChat videoChat);

		[Export ("sendGetIQWithXmlns:node:")]
		void SendGetIQWithXmlns (string xmlns, string node);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface QBChatDelegate {
		
		[Export ("chatDidLogin")]
		void ChatDidLogin ();

		[Export ("chatDidNotLogin")]
		void ChatDidNotLogin ();

		[Export ("chatDidNotSendMessage:")]
		void  ChatDidNotSendMessage(QBChatMessage message);

		[Export ("chatDidReceiveMessage:")]
		void  ChatDidReceiveMessage(QBChatMessage message);

		[Export ("chatDidFailWithError:")]
		void  ChatDidFailWithError(int code);

		[Export ("chatDidReceivePresenceOfUser:type:")]
		void Type (uint userID, string type);

		[Export ("chatDidReceiveContactAddRequestFromUser:")]
		void  ChatDidReceiveContactAddRequestFromUser(uint userID);

		[Export ("chatContactListDidChange:")]
		void  ChatContactListDidChange(QBContactList contactList);

		[Export ("chatDidReceiveContactItemActivity:isOnline:status:")]
		void IsOnline (uint userID, bool isOnline, string status);

		[Export ("chatDidReceiveListOfRooms:")]
		void ChatDidReceiveListOfRooms(NSObject [] rooms);

		[Export ("chatRoomDidReceiveMessage:fromRoom:")]
		void FromRoom (QBChatMessage message, string roomName);

		[Export ("chatRoomDidReceiveInformation:room:")]
		void Room (NSDictionary information, string roomName);

		[Export ("chatRoomDidCreate:")]
		void  ChatRoomDidCreate(string roomName);

		[Export ("chatRoomDidEnter:")]
		void  ChatRoomDidEnter(QBChatRoom room);

		[Export ("chatRoomDidNotEnter:error:")]
		void Error (string roomName, NSError error);

		[Export ("chatRoomDidLeave:")]
		void  ChatRoomDidLeave(string roomName);

		[Export ("chatRoomDidDestroy:")]
		void  ChatRoomDidDestroy(string roomName);

		[Export ("chatRoomDidChangeOnlineUsers:room:")]
		void RoomChange (NSObject [] onlineUsers, string roomName);

		[Export ("chatRoomDidReceiveListOfUsers:room:")]
		void RoomUsers (NSObject [] users, string roomName);

		[Export ("chatRoomDidReceiveListOfOnlineUsers:room:")]
		void RoomOnline (NSObject [] users, string roomName);

		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:")]
		void WithSessionID (uint userID, string sessionID, QBVideoChatConferenceType conferenceType);

		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:customParameters:")]
		void WithSessionID (uint userID, string sessionID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters);

		[Export ("chatCallUserDidNotAnswer:")]
		void  ChatCallUserDidNotAnswer(uint userID);

		[Export ("chatCallDidAcceptByUser:")]
		void  ChatCallDidAcceptByUser(uint userID);

		[Export ("chatCallDidAcceptByUser:customParameters:")]
		void CustomParameters (uint userID, NSDictionary customParameters);

		[Export ("chatCallDidRejectByUser:")]
		void  ChatCallDidRejectByUser(uint userID);

		[Export ("chatCallDidStopByUser:status:")]
		void Status (uint userID, string status);

		[Export ("chatCallDidStopByUser:status:customParameters:")]
		void Status (uint userID, string status, NSDictionary customParameters);

		[Export ("chatCallDidStartWithUser:sessionID:")]
		void SessionID (uint userID, string sessionID);

		[Export ("didStartUseTURNForVideoChat")]
		void DidStartUseTURNForVideoChat ();

		[Export ("chatTURNServerDidDisconnect")]
		void ChatTURNServerDidDisconnect ();

		[Export ("chatTURNServerdidFailWithError:")]
		void  ChatTURNServerdidFailWithError(NSError error);

		[Export ("chatDidPassConnectionStep:totalSteps:")]
		void TotalSteps (uint step, uint totalSteps);

		[Export ("chatDidEexceedWriteVideoQueueMaxOperationsThresholdWithCount:")]
		void  ChatDidEexceedWriteVideoQueueMaxOperationsThresholdWithCount(uint operationsInQueue);
		
		[Export ("didReceiveAudioBuffer:")]
		void  DidReceiveAudioBuffer(AudioBuffer buffer);
	
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBContactList {
	
		[Export ("contacts")]
		NSObject [] Contacts { get; }

		[Export ("pendingApproval")]
		NSObject [] PendingApproval { get; }

	}

	[BaseType (typeof (NSObject))]
	public partial interface QBContactListItem {

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("online")]
		bool Online { [Bind ("isOnline")] get; set; }
	
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBChatMessage {
	
		[Export ("ID", ArgumentSemantic.Copy)]
		string ID { get; set; }

		[Export ("text", ArgumentSemantic.Copy)]
		string Text { get; set; }

		[Export ("recipientID")]
		uint RecipientID { get; set; }

		[Export ("senderID")]
		uint SenderID { get; set; }

		[Export ("senderNick", ArgumentSemantic.Copy)]
		string SenderNick { get; set; }

		[Export ("datetime", ArgumentSemantic.Copy)]
		NSDate Datetime { get; set; }

		[Export ("delayed")]
		bool Delayed { get; set; }

		[Export ("customParameters", ArgumentSemantic.Retain)]
		NSMutableDictionary CustomParameters { get; set; }

		[Static, Export ("message")]
		QBChatMessage Message { get; }

		[Export ("saveWhenDeliveredToCustomObjectsWithClassName:additionalParameters:")]
		void SaveWhenDeliveredToCustomObjectsWithClassName (string classname, NSDictionary additionalParameters);

		[Export ("customObjectsClassName")]
		string CustomObjectsClassName { get; }

		[Export ("customObjectsAdditionalParameters")]
		NSDictionary CustomObjectsAdditionalParameters { get; }

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

		[Export ("addUsers:")]
		void AddUsers (NSObject [] users);

		[Export ("deleteUsers:")]
		void DeleteUsers (NSObject [] users);

		[Export ("sendMessage:")]
		void SendMessage (QBChatMessage message);

		[Export ("joinRoom")]
		void JoinRoom ();

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
	public partial interface QBChatRoomOccupant {

		[Static, Export ("occupantWithUserNickname:parameters:")]
		QBChatRoomOccupant OccupantWithUserNickname (string aNickname, NSDictionary parameters);

		[Export ("initWithUserNickname:parameters:")]
		IntPtr Constructor (string aNickname, NSDictionary parameters);

		[Export ("nickname")]
		string Nickname { get; }

		[Export ("parameters")]
		NSDictionary Parameters { get; }

	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBVideoChat  {

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

		[Export ("drainWriteVideoQueue")]
		void DrainWriteVideoQueue ();

		[Export ("drainWriteAudioQueue")]
		void DrainWriteAudioQueue ();

		[Export ("suspendStream:")]
		void SuspendStream (bool isSuspend);

	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBMessages {

		[Static, Export ("createPushToken:delegate:")]
		NSObject CreatePushToken (QBMPushToken pushToken, QBActionStatusDelegate del);

		[Static, Export ("createPushToken:delegate:context:")]
		NSObject CreatePushToken (QBMPushToken pushToken, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("deletePushTokenWithID:delegate:")]
		NSObject DeletePushTokenWithID (uint ID, NSObject del);

		[Static, Export ("deletePushTokenWithID:delegate:context:")]
		NSObject DeletePushTokenWithID (uint ID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("createSubscription:delegate:")]
		NSObject CreateSubscription (QBMSubscription subscriber, QBActionStatusDelegate del);

		[Static, Export ("createSubscription:delegate:context:")]
		NSObject CreateSubscription (QBMSubscription subscriber, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("subscriptionsWithDelegate:")]
		NSObject SubscriptionsWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("subscriptionsWithDelegate:context:")]
		NSObject SubscriptionsWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("deleteSubscriptionWithID:delegate:")]
		NSObject DeleteSubscriptionWithID (uint ID, QBActionStatusDelegate del);

		[Static, Export ("deleteSubscriptionWithID:delegate:context:")]
		NSObject DeleteSubscriptionWithID (uint ID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("createEvent:delegate:")]
		NSObject CreateEvent (QBMEvent evt, QBActionStatusDelegate del);

		[Static, Export ("createEvent:delegate:context:")]
		NSObject CreateEvent (QBMEvent evt, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("eventWithID:delegate:")]
		NSObject EventWithID (uint ID, QBActionStatusDelegate del);

		[Static, Export ("eventWithID:delegate:context:")]
		NSObject EventWithID (uint ID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("updateEvent:delegate:")]
		NSObject UpdateEvent (QBMEvent evt, QBActionStatusDelegate del);

		[Static, Export ("updateEvent:delegate:context:")]
		NSObject UpdateEvent (QBMEvent evt, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("deleteEventWithID:delegate:")]
		NSObject DeleteEventWithID (uint ID, QBActionStatusDelegate del);

		[Static, Export ("deleteEventWithID:delegate:context:")]
		NSObject DeleteEventWithID (uint ID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("eventsWithDelegate:")]
		NSObject EventsWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("eventsWithDelegate:context:")]
		NSObject EventsWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("eventsWithPagedRequest:delegate:")]
		NSObject EventsWithPagedRequest (PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("eventsWithPagedRequest:delegate:context:")]
		NSObject EventsWithPagedRequest (PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("pullEventsWithDelegate:")]
		NSObject PullEventsWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("pullEventsWithDelegate:context:")]
		NSObject PullEventsWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TRegisterSubscriptionWithDelegate:")]
		NSObject TRegisterSubscriptionWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("TRegisterSubscriptionWithDelegate:context:")]
		NSObject TRegisterSubscriptionWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TUnregisterSubscriptionWithDelegate:")]
		NSObject TUnregisterSubscriptionWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("TUnregisterSubscriptionWithDelegate:context:")]
		NSObject TUnregisterSubscriptionWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPush:toUsers:delegate:")]
		NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, QBActionStatusDelegate del);

		[Static, Export ("TSendPush:toUsers:delegate:context:")]
		NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPushWithText:toUsers:delegate:")]
		NSObject TSendPushWithText (string text, string usersIDs, QBActionStatusDelegate del);

		[Static, Export ("TSendPushWithText:toUsers:delegate:context:")]
		NSObject TSendPushWithText (string text, string usersIDs, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPush:toUsersWithAnyOfTheseTags:delegate:")]
		NSObject TSendPushWithTags (QBMPushMessage pushMessage, string usersTags, QBActionStatusDelegate del);

		[Static, Export ("TSendPush:toUsersWithAnyOfTheseTags:delegate:context:")]
		NSObject TSendPushWithTags (QBMPushMessage pushMessage, string usersTags, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:")]
		NSObject TSendPushWithTextWithTags (string text, string usersTags, QBActionStatusDelegate del);

		[Static, Export ("TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:context:")]
		NSObject TSendPushWithTextWithTags (string text, string usersTags, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPush:toUsers:isDevelopmentEnvironment:delegate:")]
		NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, bool isDevelopmentEnvironment, QBActionStatusDelegate del);

		[Static, Export ("TSendPush:toUsers:isDevelopmentEnvironment:delegate:context:")]
		NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, bool isDevelopmentEnvironment, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPush:toUsersWithAnyOfTheseTags:isDevelopmentEnvironment:delegate:")]
		NSObject TSendPushWithAnyOfTags (QBMPushMessage pushMessage, string usersTags, bool isDevelopmentEnvironment, QBActionStatusDelegate del);

		[Static, Export ("TSendPush:toUsersWithAnyOfTheseTags:isDevelopmentEnvironment:delegate:context:")]
		NSObject TSendPushWithAnyOfTags (QBMPushMessage pushMessage, string usersTags, bool isDevelopmentEnvironment, QBActionStatusDelegate del, NSObject context);
	}
	
	[BaseType (typeof (Entity))]
	public partial interface QBMPushToken {

		[Export ("clientIdentificationSequence", ArgumentSemantic.Retain)]
		string ClientIdentificationSequence { get; set; }

		[Export ("isEnvironmentDevelopment")]
		bool IsEnvironmentDevelopment { get; set; }

		[Static, Export ("pushToken")]
		QBMPushToken PushToken { get; }
	}
	
	[BaseType (typeof (Entity))]
	public partial interface QBMSubscription {

		[Export ("notificationChannel")]
		QBMNotificatioChannel NotificationChannel { get; set; }

		[Export ("deviceUDID", ArgumentSemantic.Retain)]
		string DeviceUDID { get; set; }

		[Export ("devicePlatform", ArgumentSemantic.Retain)]
		string DevicePlatform { get; set; }

		[Export ("url", ArgumentSemantic.Retain)]
		string Url { get; set; }

		[Static, Export ("subscription")]
		QBMSubscription Subscription { get; }

		[Static, Export ("notificationChannelFromString:")]
		QBMNotificatioChannel NotificationChannelFromString (string notificationChannel);

		[Static, Export ("notificationChannelToString:")]
		string NotificationChannelToString (QBMNotificatioChannel notificationChannel);
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
		QBMEvent Event { get; }

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
		QBMPushMessage PushMessage ();
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
}



