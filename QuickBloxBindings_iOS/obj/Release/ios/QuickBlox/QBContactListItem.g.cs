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
	[Register("QBContactListItem", true)]
	public unsafe partial class QBContactListItem : NSObject {
		[CompilerGenerated]
		const string selIsOnline = "isOnline";
		static readonly IntPtr selIsOnlineHandle = Selector.GetHandle ("isOnline");
		[CompilerGenerated]
		const string selSetOnline_ = "setOnline:";
		static readonly IntPtr selSetOnline_Handle = Selector.GetHandle ("setOnline:");
		[CompilerGenerated]
		const string selSetSubscriptionState_ = "setSubscriptionState:";
		static readonly IntPtr selSetSubscriptionState_Handle = Selector.GetHandle ("setSubscriptionState:");
		[CompilerGenerated]
		const string selSetUserID_ = "setUserID:";
		static readonly IntPtr selSetUserID_Handle = Selector.GetHandle ("setUserID:");
		[CompilerGenerated]
		const string selSubscriptionState = "subscriptionState";
		static readonly IntPtr selSubscriptionStateHandle = Selector.GetHandle ("subscriptionState");
		[CompilerGenerated]
		const string selUserID = "userID";
		static readonly IntPtr selUserIDHandle = Selector.GetHandle ("userID");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBContactListItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBContactListItem () : base (NSObjectFlag.Empty)
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
		public QBContactListItem (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBContactListItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBContactListItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual bool Online {
			[Export ("isOnline")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOnlineHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsOnlineHandle);
				}
			}
			
			[Export ("setOnline:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetOnline_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetOnline_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual QBPresenseSubscriptionState SubscriptionState {
			[Export ("subscriptionState")]
			get {
				if (IsDirectBinding) {
					return (QBPresenseSubscriptionState) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selSubscriptionStateHandle);
				} else {
					return (QBPresenseSubscriptionState) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selSubscriptionStateHandle);
				}
			}
			
			[Export ("setSubscriptionState:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetSubscriptionState_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetSubscriptionState_Handle, (UInt32)value);
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
		
	} /* class QBContactListItem */
}
