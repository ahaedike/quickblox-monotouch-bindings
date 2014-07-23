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
	[Register("QBMEventCreateQuery", true)]
	public unsafe partial class QBMEventCreateQuery : QBMEventQuery {
		[CompilerGenerated]
		const string selEvent = "event";
		static readonly IntPtr selEventHandle = Selector.GetHandle ("event");
		[CompilerGenerated]
		const string selInitWithEvent_ = "initWithEvent:";
		static readonly IntPtr selInitWithEvent_Handle = Selector.GetHandle ("initWithEvent:");
		[CompilerGenerated]
		const string selSetEvent_ = "setEvent:";
		static readonly IntPtr selSetEvent_Handle = Selector.GetHandle ("setEvent:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMEventCreateQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMEventCreateQuery () : base (NSObjectFlag.Empty)
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
		public QBMEventCreateQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMEventCreateQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMEventCreateQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithEvent:")]
		[CompilerGenerated]
		public QBMEventCreateQuery (QBMEvent _event)
			: base (NSObjectFlag.Empty)
		{
			if (_event == null)
				throw new ArgumentNullException ("_event");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithEvent_Handle, _event.Handle), "initWithEvent:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithEvent_Handle, _event.Handle), "initWithEvent:");
			}
		}
		
		[CompilerGenerated]
		object __mt_Event_var;
		[CompilerGenerated]
		public virtual QBMEvent Event {
			[Export ("event", ArgumentSemantic.Retain)]
			get {
				QBMEvent ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBMEvent> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEventHandle));
				} else {
					ret =  Runtime.GetNSObject<QBMEvent> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEventHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Event_var = ret;
				return ret;
			}
			
			[Export ("setEvent:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetEvent_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetEvent_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Event_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Event_var = null;
			}
		}
	} /* class QBMEventCreateQuery */
}
