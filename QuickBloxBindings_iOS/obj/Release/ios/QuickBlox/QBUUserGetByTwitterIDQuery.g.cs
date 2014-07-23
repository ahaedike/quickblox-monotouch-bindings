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
	[Register("QBUUserGetByTwitterIDQuery", true)]
	public unsafe partial class QBUUserGetByTwitterIDQuery : QBUUserQuery {
		[CompilerGenerated]
		const string selInitWithUserTwitterID_ = "initWithUserTwitterID:";
		static readonly IntPtr selInitWithUserTwitterID_Handle = Selector.GetHandle ("initWithUserTwitterID:");
		[CompilerGenerated]
		const string selSetUserTwitterID_ = "setUserTwitterID:";
		static readonly IntPtr selSetUserTwitterID_Handle = Selector.GetHandle ("setUserTwitterID:");
		[CompilerGenerated]
		const string selUserTwitterID = "userTwitterID";
		static readonly IntPtr selUserTwitterIDHandle = Selector.GetHandle ("userTwitterID");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBUUserGetByTwitterIDQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBUUserGetByTwitterIDQuery () : base (NSObjectFlag.Empty)
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
		public QBUUserGetByTwitterIDQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUserGetByTwitterIDQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUUserGetByTwitterIDQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithUserTwitterID:")]
		[CompilerGenerated]
		public QBUUserGetByTwitterIDQuery (string userTwitterID)
			: base (NSObjectFlag.Empty)
		{
			if (userTwitterID == null)
				throw new ArgumentNullException ("userTwitterID");
			var nsuserTwitterID = NSString.CreateNative (userTwitterID);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithUserTwitterID_Handle, nsuserTwitterID), "initWithUserTwitterID:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithUserTwitterID_Handle, nsuserTwitterID), "initWithUserTwitterID:");
			}
			NSString.ReleaseNative (nsuserTwitterID);
			
		}
		
		[CompilerGenerated]
		public virtual string UserTwitterID {
			[Export ("userTwitterID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserTwitterIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserTwitterIDHandle));
				}
			}
			
			[Export ("setUserTwitterID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserTwitterID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserTwitterID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class QBUUserGetByTwitterIDQuery */
}
