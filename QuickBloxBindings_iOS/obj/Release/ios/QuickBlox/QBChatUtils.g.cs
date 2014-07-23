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
	[Register("QBChatUtils", true)]
	public unsafe partial class QBChatUtils : NSObject {
		[CompilerGenerated]
		const string selAttachmentsFromXMPPMessage_ = "attachmentsFromXMPPMessage:";
		static readonly IntPtr selAttachmentsFromXMPPMessage_Handle = Selector.GetHandle ("attachmentsFromXMPPMessage:");
		[CompilerGenerated]
		const string selCGImageRotatedByAngleAngle_ = "CGImageRotatedByAngle:angle:";
		static readonly IntPtr selCGImageRotatedByAngleAngle_Handle = Selector.GetHandle ("CGImageRotatedByAngle:angle:");
		[CompilerGenerated]
		const string selCustomParametersFromXMPPMessage_ = "customParametersFromXMPPMessage:";
		static readonly IntPtr selCustomParametersFromXMPPMessage_Handle = Selector.GetHandle ("customParametersFromXMPPMessage:");
		[CompilerGenerated]
		const string selExtractParametersToRequestURLRequestURL_ = "extractParametersToRequestURL:requestURL:";
		static readonly IntPtr selExtractParametersToRequestURLRequestURL_Handle = Selector.GetHandle ("extractParametersToRequestURL:requestURL:");
		[CompilerGenerated]
		const string selGetIPAddress = "getIPAddress";
		static readonly IntPtr selGetIPAddressHandle = Selector.GetHandle ("getIPAddress");
		[CompilerGenerated]
		const string selJIDFromCurrentUserID_ = "JIDFromCurrentUserID:";
		static readonly IntPtr selJIDFromCurrentUserID_Handle = Selector.GetHandle ("JIDFromCurrentUserID:");
		[CompilerGenerated]
		const string selJIDFromUserID_ = "JIDFromUserID:";
		static readonly IntPtr selJIDFromUserID_Handle = Selector.GetHandle ("JIDFromUserID:");
		[CompilerGenerated]
		const string selMessageFromXMPPMessageRoomNick_ = "messageFromXMPPMessage:roomNick:";
		static readonly IntPtr selMessageFromXMPPMessageRoomNick_Handle = Selector.GetHandle ("messageFromXMPPMessage:roomNick:");
		[CompilerGenerated]
		const string selParametersFromPresence_ = "parametersFromPresence:";
		static readonly IntPtr selParametersFromPresence_Handle = Selector.GetHandle ("parametersFromPresence:");
		[CompilerGenerated]
		const string selRoomFromJIDNameAndAddDelegate_ = "roomFromJID:name:andAddDelegate:";
		static readonly IntPtr selRoomFromJIDNameAndAddDelegate_Handle = Selector.GetHandle ("roomFromJID:name:andAddDelegate:");
		[CompilerGenerated]
		const string selRoomJIDFromName_ = "roomJIDFromName:";
		static readonly IntPtr selRoomJIDFromName_Handle = Selector.GetHandle ("roomJIDFromName:");
		[CompilerGenerated]
		const string selRoomNameFromJID_ = "roomNameFromJID:";
		static readonly IntPtr selRoomNameFromJID_Handle = Selector.GetHandle ("roomNameFromJID:");
		[CompilerGenerated]
		const string selRoomNameToValidRoomName_ = "roomNameToValidRoomName:";
		static readonly IntPtr selRoomNameToValidRoomName_Handle = Selector.GetHandle ("roomNameToValidRoomName:");
		[CompilerGenerated]
		const string selSetCustomParametersAttachmentsExtensionNameToXMPPMessage_ = "setCustomParameters:attachments:extensionName:toXMPPMessage:";
		static readonly IntPtr selSetCustomParametersAttachmentsExtensionNameToXMPPMessage_Handle = Selector.GetHandle ("setCustomParameters:attachments:extensionName:toXMPPMessage:");
		[CompilerGenerated]
		const string selUserIDFromJID_ = "userIDFromJID:";
		static readonly IntPtr selUserIDFromJID_Handle = Selector.GetHandle ("userIDFromJID:");
		[CompilerGenerated]
		const string selXmppMessageFromQBChatMessageRoom_ = "xmppMessageFromQBChatMessage:room:";
		static readonly IntPtr selXmppMessageFromQBChatMessageRoom_Handle = Selector.GetHandle ("xmppMessageFromQBChatMessage:room:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBChatUtils");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBChatUtils () : base (NSObjectFlag.Empty)
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
		public QBChatUtils (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatUtils (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatUtils (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("attachmentsFromXMPPMessage:")]
		[CompilerGenerated]
		public static NSObject[] AttachmentsFromXMPPMessage (NSObject xmppMessage)
		{
			if (xmppMessage == null)
				throw new ArgumentNullException ("xmppMessage");
			return NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selAttachmentsFromXMPPMessage_Handle, xmppMessage.Handle));
		}
		
		[Export ("CGImageRotatedByAngle:angle:")]
		[CompilerGenerated]
		public static CGImage CGImageRotatedByAngle (CGImage imgRef, float angle)
		{
			return new global::MonoTouch.CoreGraphics.CGImage (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_float (class_ptr, selCGImageRotatedByAngleAngle_Handle, imgRef.Handle, angle));
		}
		
		[Export ("customParametersFromXMPPMessage:")]
		[CompilerGenerated]
		public static NSMutableDictionary CustomParametersFromXMPPMessage (NSObject message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			return  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selCustomParametersFromXMPPMessage_Handle, message.Handle));
		}
		
		[Export ("extractParametersToRequestURL:requestURL:")]
		[CompilerGenerated]
		public static void ExtractParametersToRequestURL (NSMutableDictionary parameters, NSMutableString requestURL)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (requestURL == null)
				throw new ArgumentNullException ("requestURL");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selExtractParametersToRequestURLRequestURL_Handle, parameters.Handle, requestURL.Handle);
		}
		
		[Export ("JIDFromCurrentUserID:")]
		[CompilerGenerated]
		public static string JIDFromCurrentUserID (global::System.UInt32 userID)
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, selJIDFromCurrentUserID_Handle, userID));
		}
		
		[Export ("JIDFromUserID:")]
		[CompilerGenerated]
		public static string JIDFromUserID (global::System.UInt32 userID)
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, selJIDFromUserID_Handle, userID));
		}
		
		[Export ("messageFromXMPPMessage:roomNick:")]
		[CompilerGenerated]
		public static QBChatMessage MessageFromXMPPMessage (NSObject message, string roomNick)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (roomNick == null)
				throw new ArgumentNullException ("roomNick");
			var nsroomNick = NSString.CreateNative (roomNick);
			
			QBChatMessage ret;
			ret =  Runtime.GetNSObject<QBChatMessage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selMessageFromXMPPMessageRoomNick_Handle, message.Handle, nsroomNick));
			NSString.ReleaseNative (nsroomNick);
			
			return ret;
		}
		
		[Export ("parametersFromPresence:")]
		[CompilerGenerated]
		public static NSDictionary ParametersFromPresence (NSObject presence)
		{
			if (presence == null)
				throw new ArgumentNullException ("presence");
			return  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selParametersFromPresence_Handle, presence.Handle));
		}
		
		[Export ("roomFromJID:name:andAddDelegate:")]
		[CompilerGenerated]
		public static QBChatRoom RoomFromJID (string roomJID, string roomName, bool addDelegate)
		{
			if (roomJID == null)
				throw new ArgumentNullException ("roomJID");
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsroomJID = NSString.CreateNative (roomJID);
			var nsroomName = NSString.CreateNative (roomName);
			
			QBChatRoom ret;
			ret =  Runtime.GetNSObject<QBChatRoom> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (class_ptr, selRoomFromJIDNameAndAddDelegate_Handle, nsroomJID, nsroomName, addDelegate));
			NSString.ReleaseNative (nsroomJID);
			NSString.ReleaseNative (nsroomName);
			
			return ret;
		}
		
		[Export ("roomJIDFromName:")]
		[CompilerGenerated]
		public static string RoomJIDFromName (string roomName)
		{
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsroomName = NSString.CreateNative (roomName);
			
			string ret;
			ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selRoomJIDFromName_Handle, nsroomName));
			NSString.ReleaseNative (nsroomName);
			
			return ret;
		}
		
		[Export ("roomNameFromJID:")]
		[CompilerGenerated]
		public static string RoomNameFromJID (string roomJID)
		{
			if (roomJID == null)
				throw new ArgumentNullException ("roomJID");
			var nsroomJID = NSString.CreateNative (roomJID);
			
			string ret;
			ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selRoomNameFromJID_Handle, nsroomJID));
			NSString.ReleaseNative (nsroomJID);
			
			return ret;
		}
		
		[Export ("roomNameToValidRoomName:")]
		[CompilerGenerated]
		public static string RoomNameToValidRoomName (string roomName)
		{
			if (roomName == null)
				throw new ArgumentNullException ("roomName");
			var nsroomName = NSString.CreateNative (roomName);
			
			string ret;
			ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selRoomNameToValidRoomName_Handle, nsroomName));
			NSString.ReleaseNative (nsroomName);
			
			return ret;
		}
		
		[Export ("setCustomParameters:attachments:extensionName:toXMPPMessage:")]
		[CompilerGenerated]
		public static void SetCustomParameters (NSDictionary customParameters, NSObject[] attachments, string extensionName, NSObject xmppMessage)
		{
			if (customParameters == null)
				throw new ArgumentNullException ("customParameters");
			if (attachments == null)
				throw new ArgumentNullException ("attachments");
			if (extensionName == null)
				throw new ArgumentNullException ("extensionName");
			if (xmppMessage == null)
				throw new ArgumentNullException ("xmppMessage");
			var nsa_attachments = NSArray.FromNSObjects (attachments);
			var nsextensionName = NSString.CreateNative (extensionName);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selSetCustomParametersAttachmentsExtensionNameToXMPPMessage_Handle, customParameters.Handle, nsa_attachments.Handle, nsextensionName, xmppMessage.Handle);
			nsa_attachments.Dispose ();
			NSString.ReleaseNative (nsextensionName);
			
		}
		
		[Export ("userIDFromJID:")]
		[CompilerGenerated]
		public static global::System.UInt32 UserIDFromJID (string jid)
		{
			if (jid == null)
				throw new ArgumentNullException ("jid");
			var nsjid = NSString.CreateNative (jid);
			
			global::System.UInt32 ret;
			ret = ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (class_ptr, selUserIDFromJID_Handle, nsjid);
			NSString.ReleaseNative (nsjid);
			
			return ret;
		}
		
		[Export ("xmppMessageFromQBChatMessage:room:")]
		[CompilerGenerated]
		public static NSObject XmppMessageFromQBChatMessage (QBChatMessage message, QBChatRoom room)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (room == null)
				throw new ArgumentNullException ("room");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selXmppMessageFromQBChatMessageRoom_Handle, message.Handle, room.Handle));
		}
		
		[CompilerGenerated]
		public static string GetIPAddress {
			[Export ("getIPAddress")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selGetIPAddressHandle));
			}
			
		}
		
	} /* class QBChatUtils */
}
