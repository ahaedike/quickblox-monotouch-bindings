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
	[Register("QBChatRoom", true)]
	public unsafe partial class QBChatRoom : NSObject {
		[CompilerGenerated]
		const string selAddUsers_ = "addUsers:";
		static readonly IntPtr selAddUsers_Handle = Selector.GetHandle ("addUsers:");
		[CompilerGenerated]
		const string selDeleteUsers_ = "deleteUsers:";
		static readonly IntPtr selDeleteUsers_Handle = Selector.GetHandle ("deleteUsers:");
		[CompilerGenerated]
		const string selInitWithRoomJID_ = "initWithRoomJID:";
		static readonly IntPtr selInitWithRoomJID_Handle = Selector.GetHandle ("initWithRoomJID:");
		[CompilerGenerated]
		const string selInitWithRoomJIDNickname_ = "initWithRoomJID:nickname:";
		static readonly IntPtr selInitWithRoomJIDNickname_Handle = Selector.GetHandle ("initWithRoomJID:nickname:");
		[CompilerGenerated]
		const string selInitWithRoomName_ = "initWithRoomName:";
		static readonly IntPtr selInitWithRoomName_Handle = Selector.GetHandle ("initWithRoomName:");
		[CompilerGenerated]
		const string selInitWithRoomNameNickname_ = "initWithRoomName:nickname:";
		static readonly IntPtr selInitWithRoomNameNickname_Handle = Selector.GetHandle ("initWithRoomName:nickname:");
		[CompilerGenerated]
		const string selIsJoined = "isJoined";
		static readonly IntPtr selIsJoinedHandle = Selector.GetHandle ("isJoined");
		[CompilerGenerated]
		const string selJID = "JID";
		static readonly IntPtr selJIDHandle = Selector.GetHandle ("JID");
		[CompilerGenerated]
		const string selJoinRoom = "joinRoom";
		static readonly IntPtr selJoinRoomHandle = Selector.GetHandle ("joinRoom");
		[CompilerGenerated]
		const string selJoinRoomWithHistoryAttribute_ = "joinRoomWithHistoryAttribute:";
		static readonly IntPtr selJoinRoomWithHistoryAttribute_Handle = Selector.GetHandle ("joinRoomWithHistoryAttribute:");
		[CompilerGenerated]
		const string selLeaveRoom = "leaveRoom";
		static readonly IntPtr selLeaveRoomHandle = Selector.GetHandle ("leaveRoom");
		[CompilerGenerated]
		const string selName = "name";
		static readonly IntPtr selNameHandle = Selector.GetHandle ("name");
		[CompilerGenerated]
		const string selRequestInformation = "requestInformation";
		static readonly IntPtr selRequestInformationHandle = Selector.GetHandle ("requestInformation");
		[CompilerGenerated]
		const string selRequestOnlineUsers = "requestOnlineUsers";
		static readonly IntPtr selRequestOnlineUsersHandle = Selector.GetHandle ("requestOnlineUsers");
		[CompilerGenerated]
		const string selRequestUsers = "requestUsers";
		static readonly IntPtr selRequestUsersHandle = Selector.GetHandle ("requestUsers");
		[CompilerGenerated]
		const string selSendMessage_ = "sendMessage:";
		static readonly IntPtr selSendMessage_Handle = Selector.GetHandle ("sendMessage:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBChatRoom");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBChatRoom () : base (NSObjectFlag.Empty)
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
		public QBChatRoom (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatRoom (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatRoom (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRoomName:")]
		[CompilerGenerated]
		public QBChatRoom (string roomName)
			: base (NSObjectFlag.Empty)
		{
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsroomName = NSString.CreateNative (roomName);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithRoomName_Handle, nsroomName), "initWithRoomName:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithRoomName_Handle, nsroomName), "initWithRoomName:");
			}
			NSString.ReleaseNative (nsroomName);
			
		}
		
		[Export ("initWithRoomName:nickname:")]
		[CompilerGenerated]
		public QBChatRoom (string roomName, string nickname)
			: base (NSObjectFlag.Empty)
		{
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			if (nickname == null)
				throw new ArgumentNullException ("nickname");
			var nsroomName = NSString.CreateNative (roomName);
			var nsnickname = NSString.CreateNative (nickname);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithRoomNameNickname_Handle, nsroomName, nsnickname), "initWithRoomName:nickname:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithRoomNameNickname_Handle, nsroomName, nsnickname), "initWithRoomName:nickname:");
			}
			NSString.ReleaseNative (nsroomName);
			NSString.ReleaseNative (nsnickname);
			
		}
		
		[Export ("addUsers:")]
		[CompilerGenerated]
		public virtual void AddUsers (NSObject[] users)
		{
			if (users == null)
				throw new ArgumentNullException ("users");
			var nsa_users = NSArray.FromNSObjects (users);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddUsers_Handle, nsa_users.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddUsers_Handle, nsa_users.Handle);
			}
			nsa_users.Dispose ();
			
		}
		
		[Export ("deleteUsers:")]
		[CompilerGenerated]
		public virtual void DeleteUsers (NSObject[] users)
		{
			if (users == null)
				throw new ArgumentNullException ("users");
			var nsa_users = NSArray.FromNSObjects (users);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDeleteUsers_Handle, nsa_users.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDeleteUsers_Handle, nsa_users.Handle);
			}
			nsa_users.Dispose ();
			
		}
		
		[Export ("initWithRoomJID:")]
		[CompilerGenerated]
		public virtual global::System.IntPtr InitWithRoomJID (string roomJID)
		{
			if (roomJID == null)
				throw new ArgumentNullException ("roomJID");
			var nsroomJID = NSString.CreateNative (roomJID);
			
			global::System.IntPtr ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithRoomJID_Handle, nsroomJID);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithRoomJID_Handle, nsroomJID);
			}
			NSString.ReleaseNative (nsroomJID);
			
			return ret;
		}
		
		[Export ("initWithRoomJID:nickname:")]
		[CompilerGenerated]
		public virtual global::System.IntPtr InitWithRoomJIDAndNickName (string roomJID, string nickname)
		{
			if (roomJID == null)
				throw new ArgumentNullException ("roomJID");
			if (nickname == null)
				throw new ArgumentNullException ("nickname");
			var nsroomJID = NSString.CreateNative (roomJID);
			var nsnickname = NSString.CreateNative (nickname);
			
			global::System.IntPtr ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithRoomJIDNickname_Handle, nsroomJID, nsnickname);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithRoomJIDNickname_Handle, nsroomJID, nsnickname);
			}
			NSString.ReleaseNative (nsroomJID);
			NSString.ReleaseNative (nsnickname);
			
			return ret;
		}
		
		[Export ("joinRoom")]
		[CompilerGenerated]
		public virtual void JoinRoom ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selJoinRoomHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selJoinRoomHandle);
			}
		}
		
		[Export ("joinRoomWithHistoryAttribute:")]
		[CompilerGenerated]
		public virtual void JoinRoomWithHistoryAttribute (NSDictionary historyAttribute)
		{
			if (historyAttribute == null)
				throw new ArgumentNullException ("historyAttribute");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selJoinRoomWithHistoryAttribute_Handle, historyAttribute.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selJoinRoomWithHistoryAttribute_Handle, historyAttribute.Handle);
			}
		}
		
		[Export ("leaveRoom")]
		[CompilerGenerated]
		public virtual void LeaveRoom ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selLeaveRoomHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selLeaveRoomHandle);
			}
		}
		
		[Export ("requestInformation")]
		[CompilerGenerated]
		public virtual void RequestInformation ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRequestInformationHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRequestInformationHandle);
			}
		}
		
		[Export ("requestOnlineUsers")]
		[CompilerGenerated]
		public virtual void RequestOnlineUsers ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRequestOnlineUsersHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRequestOnlineUsersHandle);
			}
		}
		
		[Export ("requestUsers")]
		[CompilerGenerated]
		public virtual void RequestUsers ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRequestUsersHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRequestUsersHandle);
			}
		}
		
		[Export ("sendMessage:")]
		[CompilerGenerated]
		public virtual void SendMessage (QBChatMessage message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSendMessage_Handle, message.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSendMessage_Handle, message.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsJoined {
			[Export ("isJoined")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsJoinedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsJoinedHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string JID {
			[Export ("JID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selJIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selJIDHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNameHandle));
				}
			}
			
		}
		
	} /* class QBChatRoom */
}
