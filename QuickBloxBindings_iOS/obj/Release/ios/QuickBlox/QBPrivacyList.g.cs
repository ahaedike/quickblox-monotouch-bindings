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
	[Register("QBPrivacyList", true)]
	public unsafe partial class QBPrivacyList : NSObject {
		[CompilerGenerated]
		const string selAddObject_ = "addObject:";
		static readonly IntPtr selAddObject_Handle = Selector.GetHandle ("addObject:");
		[CompilerGenerated]
		const string selCount = "count";
		static readonly IntPtr selCountHandle = Selector.GetHandle ("count");
		[CompilerGenerated]
		const string selInitWithNameItems_ = "initWithName:items:";
		static readonly IntPtr selInitWithNameItems_Handle = Selector.GetHandle ("initWithName:items:");
		[CompilerGenerated]
		const string selItems = "items";
		static readonly IntPtr selItemsHandle = Selector.GetHandle ("items");
		[CompilerGenerated]
		const string selName = "name";
		static readonly IntPtr selNameHandle = Selector.GetHandle ("name");
		[CompilerGenerated]
		const string selSetItems_ = "setItems:";
		static readonly IntPtr selSetItems_Handle = Selector.GetHandle ("setItems:");
		[CompilerGenerated]
		const string selSetName_ = "setName:";
		static readonly IntPtr selSetName_Handle = Selector.GetHandle ("setName:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBPrivacyList");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBPrivacyList () : base (NSObjectFlag.Empty)
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
		public QBPrivacyList (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBPrivacyList (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBPrivacyList (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithName:items:")]
		[CompilerGenerated]
		public QBPrivacyList (string name, NSObject[] items)
			: base (NSObjectFlag.Empty)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (items == null)
				throw new ArgumentNullException ("items");
			var nsname = NSString.CreateNative (name);
			var nsa_items = NSArray.FromNSObjects (items);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithNameItems_Handle, nsname, nsa_items.Handle), "initWithName:items:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithNameItems_Handle, nsname, nsa_items.Handle), "initWithName:items:");
			}
			NSString.ReleaseNative (nsname);
			nsa_items.Dispose ();
			
		}
		
		[Export ("addObject:")]
		[CompilerGenerated]
		public virtual void AddObject (QBPrivacyItem privacyItem)
		{
			if (privacyItem == null)
				throw new ArgumentNullException ("privacyItem");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddObject_Handle, privacyItem.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddObject_Handle, privacyItem.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Count {
			[Export ("count")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selCountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selCountHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Items_var;
		[CompilerGenerated]
		public virtual NSMutableArray Items {
			[Export ("items", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selItemsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selItemsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Items_var = ret;
				return ret;
			}
			
			[Export ("setItems:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetItems_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetItems_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Items_var = value;
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Items_var = null;
			}
		}
	} /* class QBPrivacyList */
}
