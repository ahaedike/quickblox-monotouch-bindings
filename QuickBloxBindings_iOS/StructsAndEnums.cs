using System;

namespace QuickBlox
{
	public enum QBVideoChatConferenceType  {
		Undefined = 0,
		AudioAndVideo = 1,
		Audio = 2
	}
	
	public enum QBPresenseShow {
		Away = 1,
		Chat = 2,
		DND = 3,
		XA = 4
	}
	
	public enum QBChatServiceError  {
		ConnectionRefused,
		ConnectionClosed,
		ConnectionTimeout
	}
	
	public enum QBVideoChatState {
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
	
	public enum QBMEventType {
		OneShot,
		FixedDate,
		PeriodDate,
		MultiShot
	}

	public enum QBMNotificationType {
		Push,
		Email,
		Request,
		Pull
	}

	public enum QBMPushType {
		APNS = 1,
		GCM = 2,
		MPNS = 3,
		BBPS = 4
	}

	public enum QBMNotificatioChannel {
		Email,
		APNS,
		GCM,
		MPNS,
		BBPS,
		Pull,
		HttpRequest
	}
	
	public enum QBServerZone {
		Stage,
		Development,
		Production
	}
	
	public enum QBLogLevel  {
		Nothing,
		Debug
	}
	
	public enum QBCOPermissionsAccess {
		Open,
		Owner,
		NotAllowed,
		OpenForUsersIDs,
		OpenForGroups
	}
	
	public enum QBSessionType  {
		ApplicationOnly,
		User,
		SocialUser
	}
	
}

