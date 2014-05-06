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
	[Register("QBChatMessage", true)]
	public unsafe partial class QBChatMessage : NSObject {
		[CompilerGenerated]
		const string selCustomObjectsAdditionalParameters = "customObjectsAdditionalParameters";
		static readonly IntPtr selCustomObjectsAdditionalParametersHandle = Selector.GetHandle ("customObjectsAdditionalParameters");
		[CompilerGenerated]
		const string selCustomObjectsClassName = "customObjectsClassName";
		static readonly IntPtr selCustomObjectsClassNameHandle = Selector.GetHandle ("customObjectsClassName");
		[CompilerGenerated]
		const string selCustomParameters = "customParameters";
		static readonly IntPtr selCustomParametersHandle = Selector.GetHandle ("customParameters");
		[CompilerGenerated]
		const string selDatetime = "datetime";
		static readonly IntPtr selDatetimeHandle = Selector.GetHandle ("datetime");
		[CompilerGenerated]
		const string selDelayed = "delayed";
		static readonly IntPtr selDelayedHandle = Selector.GetHandle ("delayed");
		[CompilerGenerated]
		const string selID = "ID";
		static readonly IntPtr selIDHandle = Selector.GetHandle ("ID");
		[CompilerGenerated]
		const string selMessage = "message";
		static readonly IntPtr selMessageHandle = Selector.GetHandle ("message");
		[CompilerGenerated]
		const string selRecipientID = "recipientID";
		static readonly IntPtr selRecipientIDHandle = Selector.GetHandle ("recipientID");
		[CompilerGenerated]
		const string selSaveWhenDeliveredToCustomObjectsWithClassNameAdditionalParameters_ = "saveWhenDeliveredToCustomObjectsWithClassName:additionalParameters:";
		static readonly IntPtr selSaveWhenDeliveredToCustomObjectsWithClassNameAdditionalParameters_Handle = Selector.GetHandle ("saveWhenDeliveredToCustomObjectsWithClassName:additionalParameters:");
		[CompilerGenerated]
		const string selSenderID = "senderID";
		static readonly IntPtr selSenderIDHandle = Selector.GetHandle ("senderID");
		[CompilerGenerated]
		const string selSenderNick = "senderNick";
		static readonly IntPtr selSenderNickHandle = Selector.GetHandle ("senderNick");
		[CompilerGenerated]
		const string selSetCustomParameters_ = "setCustomParameters:";
		static readonly IntPtr selSetCustomParameters_Handle = Selector.GetHandle ("setCustomParameters:");
		[CompilerGenerated]
		const string selSetDatetime_ = "setDatetime:";
		static readonly IntPtr selSetDatetime_Handle = Selector.GetHandle ("setDatetime:");
		[CompilerGenerated]
		const string selSetDelayed_ = "setDelayed:";
		static readonly IntPtr selSetDelayed_Handle = Selector.GetHandle ("setDelayed:");
		[CompilerGenerated]
		const string selSetID_ = "setID:";
		static readonly IntPtr selSetID_Handle = Selector.GetHandle ("setID:");
		[CompilerGenerated]
		const string selSetRecipientID_ = "setRecipientID:";
		static readonly IntPtr selSetRecipientID_Handle = Selector.GetHandle ("setRecipientID:");
		[CompilerGenerated]
		const string selSetSenderID_ = "setSenderID:";
		static readonly IntPtr selSetSenderID_Handle = Selector.GetHandle ("setSenderID:");
		[CompilerGenerated]
		const string selSetSenderNick_ = "setSenderNick:";
		static readonly IntPtr selSetSenderNick_Handle = Selector.GetHandle ("setSenderNick:");
		[CompilerGenerated]
		const string selSetText_ = "setText:";
		static readonly IntPtr selSetText_Handle = Selector.GetHandle ("setText:");
		[CompilerGenerated]
		const string selText = "text";
		static readonly IntPtr selTextHandle = Selector.GetHandle ("text");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBChatMessage");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBChatMessage () : base (NSObjectFlag.Empty)
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
		public QBChatMessage (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatMessage (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatMessage (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("saveWhenDeliveredToCustomObjectsWithClassName:additionalParameters:")]
		[CompilerGenerated]
		public virtual void SaveWhenDeliveredToCustomObjectsWithClassName (string classname, NSDictionary additionalParameters)
		{
			if (classname == null)
				throw new ArgumentNullException ("classname");
			if (additionalParameters == null)
				throw new ArgumentNullException ("additionalParameters");
			var nsclassname = NSString.CreateNative (classname);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSaveWhenDeliveredToCustomObjectsWithClassNameAdditionalParameters_Handle, nsclassname, additionalParameters.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSaveWhenDeliveredToCustomObjectsWithClassNameAdditionalParameters_Handle, nsclassname, additionalParameters.Handle);
			}
			NSString.ReleaseNative (nsclassname);
			
		}
		
		[CompilerGenerated]
		object __mt_CustomObjectsAdditionalParameters_var;
		[CompilerGenerated]
		public virtual NSDictionary CustomObjectsAdditionalParameters {
			[Export ("customObjectsAdditionalParameters")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCustomObjectsAdditionalParametersHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCustomObjectsAdditionalParametersHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CustomObjectsAdditionalParameters_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string CustomObjectsClassName {
			[Export ("customObjectsClassName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCustomObjectsClassNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCustomObjectsClassNameHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CustomParameters_var;
		[CompilerGenerated]
		public virtual NSMutableDictionary CustomParameters {
			[Export ("customParameters", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCustomParametersHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCustomParametersHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CustomParameters_var = ret;
				return ret;
			}
			
			[Export ("setCustomParameters:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCustomParameters_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCustomParameters_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CustomParameters_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Datetime_var;
		[CompilerGenerated]
		public virtual NSDate Datetime {
			[Export ("datetime", ArgumentSemantic.Copy)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDatetimeHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDatetimeHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Datetime_var = ret;
				return ret;
			}
			
			[Export ("setDatetime:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDatetime_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDatetime_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Datetime_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Delayed {
			[Export ("delayed")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDelayedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selDelayedHandle);
				}
			}
			
			[Export ("setDelayed:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDelayed_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDelayed_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string ID {
			[Export ("ID", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIDHandle));
				}
			}
			
			[Export ("setID:", ArgumentSemantic.Copy)]
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
		static object __mt_Message_var_static;
		[CompilerGenerated]
		public static QBChatMessage Message {
			[Export ("message")]
			get {
				QBChatMessage ret;
				ret =  Runtime.GetNSObject<QBChatMessage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selMessageHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Message_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 RecipientID {
			[Export ("recipientID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selRecipientIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selRecipientIDHandle);
				}
			}
			
			[Export ("setRecipientID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetRecipientID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetRecipientID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 SenderID {
			[Export ("senderID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selSenderIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selSenderIDHandle);
				}
			}
			
			[Export ("setSenderID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetSenderID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetSenderID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string SenderNick {
			[Export ("senderNick", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSenderNickHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSenderNickHandle));
				}
			}
			
			[Export ("setSenderNick:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSenderNick_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSenderNick_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Text {
			[Export ("text", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextHandle));
				}
			}
			
			[Export ("setText:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetText_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetText_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CustomObjectsAdditionalParameters_var = null;
				__mt_CustomParameters_var = null;
				__mt_Datetime_var = null;
			}
		}
	} /* class QBChatMessage */
}
