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
	[Register("QBMSubscriptionCreateQuery", true)]
	public unsafe partial class QBMSubscriptionCreateQuery : QBMSubscriptionQuery {
		[CompilerGenerated]
		const string selInitWithSubscription_ = "initWithSubscription:";
		static readonly IntPtr selInitWithSubscription_Handle = Selector.GetHandle ("initWithSubscription:");
		[CompilerGenerated]
		const string selSetSubscription_ = "setSubscription:";
		static readonly IntPtr selSetSubscription_Handle = Selector.GetHandle ("setSubscription:");
		[CompilerGenerated]
		const string selSubscription = "subscription";
		static readonly IntPtr selSubscriptionHandle = Selector.GetHandle ("subscription");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBMSubscriptionCreateQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBMSubscriptionCreateQuery () : base (NSObjectFlag.Empty)
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
		public QBMSubscriptionCreateQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMSubscriptionCreateQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBMSubscriptionCreateQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithSubscription:")]
		[CompilerGenerated]
		public QBMSubscriptionCreateQuery (QBMSubscription tsubscription)
			: base (NSObjectFlag.Empty)
		{
			if (tsubscription == null)
				throw new ArgumentNullException ("tsubscription");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithSubscription_Handle, tsubscription.Handle), "initWithSubscription:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithSubscription_Handle, tsubscription.Handle), "initWithSubscription:");
			}
		}
		
		[CompilerGenerated]
		object __mt_Subscription_var;
		[CompilerGenerated]
		public virtual QBMSubscription Subscription {
			[Export ("subscription", ArgumentSemantic.Retain)]
			get {
				QBMSubscription ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBMSubscription> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSubscriptionHandle));
				} else {
					ret =  Runtime.GetNSObject<QBMSubscription> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSubscriptionHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Subscription_var = ret;
				return ret;
			}
			
			[Export ("setSubscription:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSubscription_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSubscription_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Subscription_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Subscription_var = null;
			}
		}
	} /* class QBMSubscriptionCreateQuery */
}
