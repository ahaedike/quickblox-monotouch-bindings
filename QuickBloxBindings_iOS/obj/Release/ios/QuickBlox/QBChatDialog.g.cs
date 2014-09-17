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
	[Register("QBChatDialog", true)]
	public unsafe partial class QBChatDialog : NSObject {
		[CompilerGenerated]
		const string selChatRoom = "chatRoom";
		static readonly IntPtr selChatRoomHandle = Selector.GetHandle ("chatRoom");
		[CompilerGenerated]
		const string selID = "ID";
		static readonly IntPtr selIDHandle = Selector.GetHandle ("ID");
		[CompilerGenerated]
		const string selLastMessageDate = "lastMessageDate";
		static readonly IntPtr selLastMessageDateHandle = Selector.GetHandle ("lastMessageDate");
		[CompilerGenerated]
		const string selLastMessageText = "lastMessageText";
		static readonly IntPtr selLastMessageTextHandle = Selector.GetHandle ("lastMessageText");
		[CompilerGenerated]
		const string selLastMessageUserID = "lastMessageUserID";
		static readonly IntPtr selLastMessageUserIDHandle = Selector.GetHandle ("lastMessageUserID");
		[CompilerGenerated]
		const string selName = "name";
		static readonly IntPtr selNameHandle = Selector.GetHandle ("name");
		[CompilerGenerated]
		const string selOccupantIDs = "occupantIDs";
		static readonly IntPtr selOccupantIDsHandle = Selector.GetHandle ("occupantIDs");
		[CompilerGenerated]
		const string selPhoto = "photo";
		static readonly IntPtr selPhotoHandle = Selector.GetHandle ("photo");
		[CompilerGenerated]
		const string selRecipientID = "recipientID";
		static readonly IntPtr selRecipientIDHandle = Selector.GetHandle ("recipientID");
		[CompilerGenerated]
		const string selRoomJID = "roomJID";
		static readonly IntPtr selRoomJIDHandle = Selector.GetHandle ("roomJID");
		[CompilerGenerated]
		const string selSetID_ = "setID:";
		static readonly IntPtr selSetID_Handle = Selector.GetHandle ("setID:");
		[CompilerGenerated]
		const string selSetLastMessageDate_ = "setLastMessageDate:";
		static readonly IntPtr selSetLastMessageDate_Handle = Selector.GetHandle ("setLastMessageDate:");
		[CompilerGenerated]
		const string selSetLastMessageText_ = "setLastMessageText:";
		static readonly IntPtr selSetLastMessageText_Handle = Selector.GetHandle ("setLastMessageText:");
		[CompilerGenerated]
		const string selSetLastMessageUserID_ = "setLastMessageUserID:";
		static readonly IntPtr selSetLastMessageUserID_Handle = Selector.GetHandle ("setLastMessageUserID:");
		[CompilerGenerated]
		const string selSetName_ = "setName:";
		static readonly IntPtr selSetName_Handle = Selector.GetHandle ("setName:");
		[CompilerGenerated]
		const string selSetOccupantIDs_ = "setOccupantIDs:";
		static readonly IntPtr selSetOccupantIDs_Handle = Selector.GetHandle ("setOccupantIDs:");
		[CompilerGenerated]
		const string selSetPhoto_ = "setPhoto:";
		static readonly IntPtr selSetPhoto_Handle = Selector.GetHandle ("setPhoto:");
		[CompilerGenerated]
		const string selSetRoomJID_ = "setRoomJID:";
		static readonly IntPtr selSetRoomJID_Handle = Selector.GetHandle ("setRoomJID:");
		[CompilerGenerated]
		const string selSetType_ = "setType:";
		static readonly IntPtr selSetType_Handle = Selector.GetHandle ("setType:");
		[CompilerGenerated]
		const string selSetUnreadMessagesCount_ = "setUnreadMessagesCount:";
		static readonly IntPtr selSetUnreadMessagesCount_Handle = Selector.GetHandle ("setUnreadMessagesCount:");
		[CompilerGenerated]
		const string selSetUserID_ = "setUserID:";
		static readonly IntPtr selSetUserID_Handle = Selector.GetHandle ("setUserID:");
		[CompilerGenerated]
		const string selType = "type";
		static readonly IntPtr selTypeHandle = Selector.GetHandle ("type");
		[CompilerGenerated]
		const string selUnreadMessagesCount = "unreadMessagesCount";
		static readonly IntPtr selUnreadMessagesCountHandle = Selector.GetHandle ("unreadMessagesCount");
		[CompilerGenerated]
		const string selUserID = "userID";
		static readonly IntPtr selUserIDHandle = Selector.GetHandle ("userID");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBChatDialog");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBChatDialog () : base (NSObjectFlag.Empty)
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
		public QBChatDialog (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatDialog (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatDialog (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_ChatRoom_var;
		[CompilerGenerated]
		public virtual QBChatRoom ChatRoom {
			[Export ("chatRoom")]
			get {
				QBChatRoom ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBChatRoom> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selChatRoomHandle));
				} else {
					ret =  Runtime.GetNSObject<QBChatRoom> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selChatRoomHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ChatRoom_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ID {
			[Export ("ID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIDHandle));
				}
			}
			
			[Export ("setID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_LastMessageDate_var;
		[CompilerGenerated]
		public virtual NSDate LastMessageDate {
			[Export ("lastMessageDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLastMessageDateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLastMessageDateHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LastMessageDate_var = ret;
				return ret;
			}
			
			[Export ("setLastMessageDate:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLastMessageDate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLastMessageDate_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LastMessageDate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string LastMessageText {
			[Export ("lastMessageText", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLastMessageTextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLastMessageTextHandle));
				}
			}
			
			[Export ("setLastMessageText:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLastMessageText_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLastMessageText_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 LastMessageUserID {
			[Export ("lastMessageUserID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selLastMessageUserIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selLastMessageUserIDHandle);
				}
			}
			
			[Export ("setLastMessageUserID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetLastMessageUserID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetLastMessageUserID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNameHandle));
				}
			}
			
			[Export ("setName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_OccupantIDs_var;
		[CompilerGenerated]
		public virtual NSObject[] OccupantIDs {
			[Export ("occupantIDs")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOccupantIDsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOccupantIDsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OccupantIDs_var = ret;
				return ret;
			}
			
			[Export ("setOccupantIDs:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOccupantIDs_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOccupantIDs_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_OccupantIDs_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Photo {
			[Export ("photo", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPhotoHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPhotoHandle));
				}
			}
			
			[Export ("setPhoto:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPhoto_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPhoto_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual int RecipientID {
			[Export ("recipientID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selRecipientIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selRecipientIDHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string RoomJID {
			[Export ("roomJID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRoomJIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRoomJIDHandle));
				}
			}
			
			[Export ("setRoomJID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRoomJID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRoomJID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual QBChatDialogType Type {
			[Export ("type")]
			get {
				if (IsDirectBinding) {
					return (QBChatDialogType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selTypeHandle);
				} else {
					return (QBChatDialogType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selTypeHandle);
				}
			}
			
			[Export ("setType:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetType_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetType_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 UnreadMessagesCount {
			[Export ("unreadMessagesCount")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selUnreadMessagesCountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selUnreadMessagesCountHandle);
				}
			}
			
			[Export ("setUnreadMessagesCount:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetUnreadMessagesCount_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetUnreadMessagesCount_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 UserID {
			[Export ("userID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selUserIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selUserIDHandle);
				}
			}
			
			[Export ("setUserID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetUserID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetUserID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ChatRoom_var = null;
				__mt_LastMessageDate_var = null;
				__mt_OccupantIDs_var = null;
			}
		}
	} /* class QBChatDialog */
}
