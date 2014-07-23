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
	[Register("QBMPushMessage", true)]
	public unsafe partial class QBMPushMessage : QBMPushMessageBase {
		[CompilerGenerated]
		const string selAdditionalInfo = "additionalInfo";
		static readonly IntPtr selAdditionalInfoHandle = Selector.GetHandle ("additionalInfo");
		[CompilerGenerated]
		const string selAlertBody = "alertBody";
		static readonly IntPtr selAlertBodyHandle = Selector.GetHandle ("alertBody");
		[CompilerGenerated]
		const string selBadge = "badge";
		static readonly IntPtr selBadgeHandle = Selector.GetHandle ("badge");
		[CompilerGenerated]
		const string selLocalizedActionKey = "localizedActionKey";
		static readonly IntPtr selLocalizedActionKeyHandle = Selector.GetHandle ("localizedActionKey");
		[CompilerGenerated]
		const string selLocalizedBodyArguments = "localizedBodyArguments";
		static readonly IntPtr selLocalizedBodyArgumentsHandle = Selector.GetHandle ("localizedBodyArguments");
		[CompilerGenerated]
		const string selLocalizedBodyKey = "localizedBodyKey";
		static readonly IntPtr selLocalizedBodyKeyHandle = Selector.GetHandle ("localizedBodyKey");
		[CompilerGenerated]
		const string selPushMessage = "pushMessage";
		static readonly IntPtr selPushMessageHandle = Selector.GetHandle ("pushMessage");
		[CompilerGenerated]
		const string selSetAdditionalInfo_ = "setAdditionalInfo:";
		static readonly IntPtr selSetAdditionalInfo_Handle = Selector.GetHandle ("setAdditionalInfo:");
		[CompilerGenerated]
		const string selSetAlertBody_ = "setAlertBody:";
		static readonly IntPtr selSetAlertBody_Handle = Selector.GetHandle ("setAlertBody:");
		[CompilerGenerated]
		const string selSetBadge_ = "setBadge:";
		static readonly IntPtr selSetBadge_Handle = Selector.GetHandle ("setBadge:");
		[CompilerGenerated]
		const string selSetLocalizedActionKey_ = "setLocalizedActionKey:";
		static readonly IntPtr selSetLocalizedActionKey_Handle = Selector.GetHandle ("setLocalizedActionKey:");
		[CompilerGenerated]
		const string selSetLocalizedBodyArguments_ = "setLocalizedBodyArguments:";
		static readonly IntPtr selSetLocalizedBodyArguments_Handle = Selector.GetHandle ("setLocalizedBodyArguments:");
		[CompilerGenerated]
		const string selSetLocalizedBodyKey_ = "setLocalizedBodyKey:";
		static readonly IntPtr selSetLocalizedBodyKey_Handle = Selector.GetHandle ("setLocalizedBodyKey:");
		[CompilerGenerated]
		const string selSetSoundFile_ = "setSoundFile:";
		static readonly IntPtr selSetSoundFile_Handle = Selector.GetHandle ("setSoundFile:");
		[CompilerGenerated]
		const string selSoundFile = "soundFile";
		static readonly IntPtr selSoundFileHandle = Selector.GetHandle ("soundFile");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMPushMessage");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMPushMessage () : base (NSObjectFlag.Empty)
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
		public QBMPushMessage (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMPushMessage (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMPushMessage (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_AdditionalInfo_var;
		[CompilerGenerated]
		public virtual NSDictionary AdditionalInfo {
			[Export ("additionalInfo", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAdditionalInfoHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAdditionalInfoHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalInfo_var = ret;
				return ret;
			}
			
			[Export ("setAdditionalInfo:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAdditionalInfo_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAdditionalInfo_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalInfo_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string AlertBody {
			[Export ("alertBody", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAlertBodyHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAlertBodyHandle));
				}
			}
			
			[Export ("setAlertBody:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAlertBody_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAlertBody_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Badge_var;
		[CompilerGenerated]
		public virtual NSNumber Badge {
			[Export ("badge", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBadgeHandle));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBadgeHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Badge_var = ret;
				return ret;
			}
			
			[Export ("setBadge:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBadge_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBadge_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Badge_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string LocalizedActionKey {
			[Export ("localizedActionKey", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocalizedActionKeyHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLocalizedActionKeyHandle));
				}
			}
			
			[Export ("setLocalizedActionKey:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLocalizedActionKey_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLocalizedActionKey_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_LocalizedBodyArguments_var;
		[CompilerGenerated]
		public virtual NSObject[] LocalizedBodyArguments {
			[Export ("localizedBodyArguments", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocalizedBodyArgumentsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLocalizedBodyArgumentsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LocalizedBodyArguments_var = ret;
				return ret;
			}
			
			[Export ("setLocalizedBodyArguments:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLocalizedBodyArguments_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLocalizedBodyArguments_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_LocalizedBodyArguments_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string LocalizedBodyKey {
			[Export ("localizedBodyKey", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocalizedBodyKeyHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLocalizedBodyKeyHandle));
				}
			}
			
			[Export ("setLocalizedBodyKey:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLocalizedBodyKey_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLocalizedBodyKey_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		static object __mt_PushMessage_var_static;
		[CompilerGenerated]
		public static QBMPushMessage PushMessage {
			[Export ("pushMessage")]
			get {
				QBMPushMessage ret;
				ret =  Runtime.GetNSObject<QBMPushMessage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selPushMessageHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_PushMessage_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SoundFile {
			[Export ("soundFile", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSoundFileHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSoundFileHandle));
				}
			}
			
			[Export ("setSoundFile:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSoundFile_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSoundFile_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AdditionalInfo_var = null;
				__mt_Badge_var = null;
				__mt_LocalizedBodyArguments_var = null;
			}
		}
	} /* class QBMPushMessage */
}
