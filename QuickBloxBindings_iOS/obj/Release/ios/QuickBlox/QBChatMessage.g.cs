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
	public unsafe partial class QBChatMessage : QBChatAbstractMessage {
		[CompilerGenerated]
		const string selCustomObjectsAdditionalParameters = "customObjectsAdditionalParameters";
		static readonly IntPtr selCustomObjectsAdditionalParametersHandle = Selector.GetHandle ("customObjectsAdditionalParameters");
		[CompilerGenerated]
		const string selCustomObjectsClassName = "customObjectsClassName";
		static readonly IntPtr selCustomObjectsClassNameHandle = Selector.GetHandle ("customObjectsClassName");
		[CompilerGenerated]
		const string selDelayed = "delayed";
		static readonly IntPtr selDelayedHandle = Selector.GetHandle ("delayed");
		[CompilerGenerated]
		const string selMessage = "message";
		static readonly IntPtr selMessageHandle = Selector.GetHandle ("message");
		[CompilerGenerated]
		const string selSaveWhenDeliveredToCustomObjectsWithClassNameAdditionalParameters_ = "saveWhenDeliveredToCustomObjectsWithClassName:additionalParameters:";
		static readonly IntPtr selSaveWhenDeliveredToCustomObjectsWithClassNameAdditionalParameters_Handle = Selector.GetHandle ("saveWhenDeliveredToCustomObjectsWithClassName:additionalParameters:");
		[CompilerGenerated]
		const string selSenderNick = "senderNick";
		static readonly IntPtr selSenderNickHandle = Selector.GetHandle ("senderNick");
		[CompilerGenerated]
		const string selSetCustomObjectsAdditionalParameters_ = "setCustomObjectsAdditionalParameters:";
		static readonly IntPtr selSetCustomObjectsAdditionalParameters_Handle = Selector.GetHandle ("setCustomObjectsAdditionalParameters:");
		[CompilerGenerated]
		const string selSetCustomObjectsClassName_ = "setCustomObjectsClassName:";
		static readonly IntPtr selSetCustomObjectsClassName_Handle = Selector.GetHandle ("setCustomObjectsClassName:");
		[CompilerGenerated]
		const string selSetDelayed_ = "setDelayed:";
		static readonly IntPtr selSetDelayed_Handle = Selector.GetHandle ("setDelayed:");
		[CompilerGenerated]
		const string selSetSenderNick_ = "setSenderNick:";
		static readonly IntPtr selSetSenderNick_Handle = Selector.GetHandle ("setSenderNick:");
		
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
			[Export ("customObjectsAdditionalParameters", ArgumentSemantic.Copy)]
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
			
			[Export ("setCustomObjectsAdditionalParameters:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCustomObjectsAdditionalParameters_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCustomObjectsAdditionalParameters_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CustomObjectsAdditionalParameters_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string CustomObjectsClassName {
			[Export ("customObjectsClassName", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCustomObjectsClassNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCustomObjectsClassNameHandle));
				}
			}
			
			[Export ("setCustomObjectsClassName:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCustomObjectsClassName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCustomObjectsClassName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CustomObjectsAdditionalParameters_var = null;
			}
		}
	} /* class QBChatMessage */
}
