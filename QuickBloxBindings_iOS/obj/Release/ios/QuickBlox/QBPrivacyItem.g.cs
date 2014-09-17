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
	[Register("QBPrivacyItem", true)]
	public unsafe partial class QBPrivacyItem : NSObject {
		[CompilerGenerated]
		const string selAction = "action";
		static readonly IntPtr selActionHandle = Selector.GetHandle ("action");
		[CompilerGenerated]
		const string selInitWithTypeValueForTypeAction_ = "initWithType:valueForType:action:";
		static readonly IntPtr selInitWithTypeValueForTypeAction_Handle = Selector.GetHandle ("initWithType:valueForType:action:");
		[CompilerGenerated]
		const string selSetAction_ = "setAction:";
		static readonly IntPtr selSetAction_Handle = Selector.GetHandle ("setAction:");
		[CompilerGenerated]
		const string selSetType_ = "setType:";
		static readonly IntPtr selSetType_Handle = Selector.GetHandle ("setType:");
		[CompilerGenerated]
		const string selSetValueForType_ = "setValueForType:";
		static readonly IntPtr selSetValueForType_Handle = Selector.GetHandle ("setValueForType:");
		[CompilerGenerated]
		const string selType = "type";
		static readonly IntPtr selTypeHandle = Selector.GetHandle ("type");
		[CompilerGenerated]
		const string selValueForType = "valueForType";
		static readonly IntPtr selValueForTypeHandle = Selector.GetHandle ("valueForType");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBPrivacyItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBPrivacyItem () : base (NSObjectFlag.Empty)
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
		public QBPrivacyItem (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBPrivacyItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBPrivacyItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithType:valueForType:action:")]
		[CompilerGenerated]
		public QBPrivacyItem (QBPrivacyItemType type, global::System.UInt32 valueForType, QBPrivacyItemAction action)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_int_UInt32_int (this.Handle, selInitWithTypeValueForTypeAction_Handle, (int)type, valueForType, (int)action), "initWithType:valueForType:action:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_UInt32_int (this.SuperHandle, selInitWithTypeValueForTypeAction_Handle, (int)type, valueForType, (int)action), "initWithType:valueForType:action:");
			}
		}
		
		[CompilerGenerated]
		public virtual QBPrivacyItemAction Action {
			[Export ("action")]
			get {
				if (IsDirectBinding) {
					return (QBPrivacyItemAction) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selActionHandle);
				} else {
					return (QBPrivacyItemAction) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selActionHandle);
				}
			}
			
			[Export ("setAction:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetAction_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetAction_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual QBPrivacyItemType Type {
			[Export ("type")]
			get {
				if (IsDirectBinding) {
					return (QBPrivacyItemType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTypeHandle);
				} else {
					return (QBPrivacyItemType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selTypeHandle);
				}
			}
			
			[Export ("setType:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetType_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetType_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 ValueForType {
			[Export ("valueForType")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selValueForTypeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selValueForTypeHandle);
				}
			}
			
			[Export ("setValueForType:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetValueForType_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetValueForType_Handle, value);
				}
			}
		}
		
	} /* class QBPrivacyItem */
}
