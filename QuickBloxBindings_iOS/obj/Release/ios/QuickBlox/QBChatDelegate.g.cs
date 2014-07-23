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
	[Register("QBChatDelegate", true)]
	[Model]
	public unsafe partial class QBChatDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBChatDelegate () : base (NSObjectFlag.Empty)
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
		public QBChatDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("chatCallDidAcceptByUser:")]
		[CompilerGenerated]
		public virtual void ChatCallDidAcceptByUser (global::System.UInt32 userID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallDidAcceptByUser:customParameters:")]
		[CompilerGenerated]
		public virtual void ChatCallDidAcceptByUserCustomParameters (global::System.UInt32 userID, NSDictionary customParameters)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallDidRejectByUser:")]
		[CompilerGenerated]
		public virtual void ChatCallDidRejectByUser (global::System.UInt32 userID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallDidStartWithUser:sessionID:")]
		[CompilerGenerated]
		public virtual void ChatCallDidStartWithUserSessionID (global::System.UInt32 userID, string sessionID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallDidStopByUser:status:")]
		[CompilerGenerated]
		public virtual void ChatCallDidStopByUserStatus (global::System.UInt32 userID, string status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallDidStopByUser:status:customParameters:")]
		[CompilerGenerated]
		public virtual void ChatCallDidStopByUserStatus (global::System.UInt32 userID, string status, NSDictionary customParameters)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatCallUserDidNotAnswer:")]
		[CompilerGenerated]
		public virtual void ChatCallUserDidNotAnswer (global::System.UInt32 userID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatContactListDidChange:")]
		[CompilerGenerated]
		public virtual void ChatContactListDidChange (QBContactList contactList)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidEexceedWriteAudioQueueMaxOperationsThresholdWithCount:")]
		[CompilerGenerated]
		public virtual void ChatDidEexceedWriteAudioQueueMaxOperationsThresholdWithCount (global::System.UInt32 operationsInQueue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidEexceedWriteVideoQueueMaxOperationsThresholdWithCount:")]
		[CompilerGenerated]
		public virtual void ChatDidEexceedWriteVideoQueueMaxOperationsThresholdWithCount (global::System.UInt32 operationsInQueue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidFailWithError:")]
		[CompilerGenerated]
		public virtual void ChatDidFailWithError (int code)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidLogin")]
		[CompilerGenerated]
		public virtual void ChatDidLogin ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidNotLogin")]
		[CompilerGenerated]
		public virtual void ChatDidNotLogin ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidNotSendMessage:")]
		[CompilerGenerated]
		public virtual void ChatDidNotSendMessage (QBChatMessage message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidPassConnectionStep:totalSteps:")]
		[CompilerGenerated]
		public virtual void ChatDidPassConnectionStepTotalSteps (global::System.UInt32 step, global::System.UInt32 totalSteps)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveCallRequestFromUserWithSessionID (global::System.UInt32 userID, string sessionID, QBVideoChatConferenceType conferenceType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:customParameters:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveCallRequestFromUserWithSessionID (global::System.UInt32 userID, string sessionID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveContactAddRequestFromUser:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveContactAddRequestFromUser (global::System.UInt32 userID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveListOfRooms:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveListOfRooms (NSObject[] rooms)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveMessage:")]
		[CompilerGenerated]
		public virtual void ChatDidReceiveMessage (QBChatMessage message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceivePresenceOfUser:type:")]
		[CompilerGenerated]
		public virtual void ChatDidReceivePresenceOfUserType (global::System.UInt32 userID, string type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidChangeOnlineUsers:room:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidChangeOnlineUsersRoom (NSObject[] onlineUsers, string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidChangeOnlineUsers:roomJID:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidChangeOnlineUsersRoomJID (NSObject[] onlineUsers, string roomJID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidCreate:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidCreate (string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidDestroy:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidDestroy (string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidEnter:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidEnter (QBChatRoom room)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidLeave:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidLeave (string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidLeaveRoomWithJID:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidLeaveRoomWithJID (string roomJID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidNotEnter:error:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidNotEnterError (string roomName, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidNotEnterRoomWithJID:error:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidNotEnterRoomWithJIDError (string roomJID, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveInformation:room:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveInformationFromRoom (NSDictionary information, string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveListOfOnlineUsers:room:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveListOfOnlineUsersRoom (NSObject[] users, string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveListOfOnlineUsers:roomJID:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveListOfOnlineUsersRoomJID (NSObject[] users, string roomJID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveListOfUsers:room:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveListOfUsersRoom (NSObject[] users, string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveMessage:fromRoom:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveMessageFromRoom (QBChatMessage message, string roomName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatRoomDidReceiveMessage:fromRoomJID:")]
		[CompilerGenerated]
		public virtual void ChatRoomDidReceiveMessageFromRoomJID (QBChatMessage message, string roomJID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatTURNServerDidDisconnect")]
		[CompilerGenerated]
		public virtual void ChatTURNServerDidDisconnect ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatTURNServerdidFailWithError:")]
		[CompilerGenerated]
		public virtual void ChatTURNServerdidFailWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didReceiveAudioBuffer:")]
		[CompilerGenerated]
		public virtual void DidReceiveAudioBuffer (global::MonoTouch.AudioToolbox.AudioBuffer buffer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didStartUseTURNForVideoChat")]
		[CompilerGenerated]
		public virtual void DidStartUseTURNForVideoChat ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("chatDidReceiveContactItemActivity:isOnline:status:")]
		[CompilerGenerated]
		public virtual void IsOnline (global::System.UInt32 userID, bool isOnline, string status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class QBChatDelegate */
}
