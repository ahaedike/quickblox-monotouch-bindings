using System;

namespace QuickBlox
{

	public enum QBResponseStatusCode {
		Unknown = -1,
		Accepted = 202,
		Created = 201,
		NotFound = 404,
		OK = 200,
		BadRequest = 400,
		ServerError = 500,
		UnAuthorized = 401,
		ValidationFailed = 422
	}
			
	public enum QBPrivacyItemType  {
		USER_ID,
		GROUP,
		SUBSCRIPTION
	}

	public enum QBPrivacyItemAction  {
		ALLOW,
		DENY

	}
		

	public enum BaseServiceErrorType : uint {
		Unknown = 0,
		Validation,
		Parse,
		Connection,
		Server
	}

	public enum RestMethodKind : uint {
		DELETE = 1,
		GET,
		POST,
		PUT
	}

	public enum RestResponseType : uint {
		XML,
		Javascript,
		Plain,
		Binary,
		HTML,
		XHTML_XML,
		Unknown
	}

	public enum RestAnswerKind : uint {
		Unknown,
		Accepted = 202,
		Created = 201,
		NotFound = 404,
		OK = 200,
		BadRequest = 400,
		ServerError = 500,
		UnAuthorized = 401,
		ValidationFailed = 422
	}

	public enum QBLogLevel : uint {
		Nothing,
		Debug
	}

	public enum RestRequestBuildStyle : uint {
		Params,
		MultipartFormData
	}

	public enum FileParameterType : uint {
		Data
	}

	public enum QBSessionType : uint {
		ApplicationOnly,
		User,
		SocialUser
	}

	public enum QBAFURLConnectionOperationSSLPinningMode {
		SSLPinningModeNone,
		SSLPinningModePublicKey,
		SSLPinningModeCertificate
	}

	public enum QBAFHTTPClientParameterEncoding  {
		FormURLParameterEncoding,
		JSONParameterEncoding,
		PropertyListParameterEncoding
	}

	public enum DevicePlatform : uint {
		iOS,
		Android,
		WindowsPhone,
		BlackBerry,
		Undefined
	}

	public enum QBLGeoDataSortByKind : uint {
		GeoDataSortByKindNone,
		GeoDataSortByKindCreatedAt,
		GeoDataSortByKindLatitude,
		GeoDataSortByKindLongitude,
		GeoDataSortByKindDistance
	}

	public enum QBMEventType  {
		OneShot,
		FixedDate,
		PeriodDate
	}

	public enum QBMNotificationType {
		Push,
		Email
	}

	public enum QBMPushType {
		APNS = 1,
		GCM = 2,
		MPNS = 3,
		BBPS = 4
	}

	public enum QBMNotificationChannel {
		Email,
		APNS,
		GCM,
		MPNS,
		BBPS
	}

	public enum QBCBlobStatus {
		New,
		Locked,
		Completed
	}

	public enum QBCBlobObjectAccessType {
		Read,
		Write
	}

	public enum QBRScoreSortByKind : uint {
		ScoreSortByKindNone,
		ScoreSortByKindCreatedAt,
		ScoreSortByKindValue
	}
	public enum QBVideoChatConferenceType : uint {
		Undefined = 0,
		AudioAndVideo = 1,
		Audio = 2
	}

	public enum QBContactListItemStatus : uint {
		Online = 1,
		Offline = 0
	}

	public enum QBPresenseShow : uint {
		Away = 1,
		Chat = 2,
		DND = 3,
		XA = 4
	}

	public enum QBVideoChatState : uint {
		Unknown = 0,
		Calling = 1,
		AcceptCall = 2,
		Binding = 3,
		WaitingOpponentAddressSTUN = 4,
		endingDataSTUN = 5,
		SetupVideoAllocationInProgress = 6,
		SetupVideoAllocationDone = 7,
		SetupVideoSetupPermissionsInProgress = 8,
		SetupVideoSetupPermissionsDone = 9,
		SetupVideoSetupWaitingPeerAttempt = 10,
		SetupVideoSetupConnectionBindInProgress = 11,
		SetupVideoSetupConnectingToRelay = 12,
		SetupVideoWaitingOpponentDataTURN = 13,
		SetuoVideoSendingDataTURN = 14,
		RejectCall = 15
	}

	public enum QBPresenseSubscriptionState : uint {
		None = 1,
		To = 2,
		From = 3,
		Both = 4
	}

	public enum QBChatDialogType : uint {
		PublicGroup = 1,
		Group = 2,
		Private = 3
	}

	public enum QBChatHistoryMessageType : uint {
		Text = 1
	}

	public enum QBChatServiceError  {
		ConnectionRefused,
		ConnectionClosed,
		ConnectionTimeout
	}

	public enum QBCOPermissionsAccess  {
		Open,
		Owner,
		NotAllowed,
		OpenForUsersIDs,
		OpenForGroups
	}


}

