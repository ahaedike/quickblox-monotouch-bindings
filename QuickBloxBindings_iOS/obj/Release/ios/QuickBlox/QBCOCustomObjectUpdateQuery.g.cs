//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace QuickBlox {
	[Register("QBCOCustomObjectUpdateQuery", true)]
	public unsafe partial class QBCOCustomObjectUpdateQuery : NSObject {
		[CompilerGenerated]
		const string selObject = "object";
		static readonly IntPtr selObjectHandle = Selector.GetHandle ("object");
		[CompilerGenerated]
		const string selSpecialUpdateOperators = "specialUpdateOperators";
		static readonly IntPtr selSpecialUpdateOperatorsHandle = Selector.GetHandle ("specialUpdateOperators");
		[CompilerGenerated]
		const string selInitWithObjectSpecialUpdateOperators_ = "initWithObject:specialUpdateOperators:";
		static readonly IntPtr selInitWithObjectSpecialUpdateOperators_Handle = Selector.GetHandle ("initWithObject:specialUpdateOperators:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCOCustomObjectUpdateQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCOCustomObjectUpdateQuery () : base (NSObjectFlag.Empty)
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
		public QBCOCustomObjectUpdateQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOCustomObjectUpdateQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOCustomObjectUpdateQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithObject:specialUpdateOperators:")]
		[CompilerGenerated]
		public QBCOCustomObjectUpdateQuery (QBCOCustomObject _object, NSMutableDictionary specialUpdateOperators)
			: base (NSObjectFlag.Empty)
		{
			if (_object == null)
				throw new ArgumentNullException ("_object");
			if (specialUpdateOperators == null)
				throw new ArgumentNullException ("specialUpdateOperators");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithObjectSpecialUpdateOperators_Handle, _object.Handle, specialUpdateOperators.Handle), "initWithObject:specialUpdateOperators:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithObjectSpecialUpdateOperators_Handle, _object.Handle, specialUpdateOperators.Handle), "initWithObject:specialUpdateOperators:");
			}
		}
		
		[CompilerGenerated]
		object __mt_Object_var;
		[CompilerGenerated]
		public virtual QBCOCustomObject Object {
			[Export ("object")]
			get {
				QBCOCustomObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBCOCustomObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selObjectHandle));
				} else {
					ret =  Runtime.GetNSObject<QBCOCustomObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selObjectHandle));
				}
				MarkDirty ();
				__mt_Object_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SpecialUpdateOperators_var;
		[CompilerGenerated]
		public virtual NSMutableDictionary SpecialUpdateOperators {
			[Export ("specialUpdateOperators")]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSpecialUpdateOperatorsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSpecialUpdateOperatorsHandle));
				}
				MarkDirty ();
				__mt_SpecialUpdateOperators_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Object_var = null;
				__mt_SpecialUpdateOperators_var = null;
			}
		}
	} /* class QBCOCustomObjectUpdateQuery */
}
