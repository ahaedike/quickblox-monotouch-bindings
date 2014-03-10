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
	[Register("QBRGameModeUpdateQuery", true)]
	public unsafe partial class QBRGameModeUpdateQuery : NSObject {
		[CompilerGenerated]
		const string selGameMode = "gameMode";
		static readonly IntPtr selGameModeHandle = Selector.GetHandle ("gameMode");
		[CompilerGenerated]
		const string selSetGameMode_ = "setGameMode:";
		static readonly IntPtr selSetGameMode_Handle = Selector.GetHandle ("setGameMode:");
		[CompilerGenerated]
		const string selInitWithGameMode_ = "initWithGameMode:";
		static readonly IntPtr selInitWithGameMode_Handle = Selector.GetHandle ("initWithGameMode:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBRGameModeUpdateQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBRGameModeUpdateQuery () : base (NSObjectFlag.Empty)
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
		public QBRGameModeUpdateQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRGameModeUpdateQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRGameModeUpdateQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithGameMode:")]
		[CompilerGenerated]
		public QBRGameModeUpdateQuery (QBRGameMode gameMode)
			: base (NSObjectFlag.Empty)
		{
			if (gameMode == null)
				throw new ArgumentNullException ("gameMode");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithGameMode_Handle, gameMode.Handle), "initWithGameMode:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithGameMode_Handle, gameMode.Handle), "initWithGameMode:");
			}
		}
		
		[CompilerGenerated]
		object __mt_GameMode_var;
		[CompilerGenerated]
		public virtual QBRGameMode GameMode {
			[Export ("gameMode", ArgumentSemantic.Retain)]
			get {
				QBRGameMode ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBRGameMode> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGameModeHandle));
				} else {
					ret =  Runtime.GetNSObject<QBRGameMode> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGameModeHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_GameMode_var = ret;
				return ret;
			}
			
			[Export ("setGameMode:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetGameMode_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetGameMode_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_GameMode_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_GameMode_var = null;
			}
		}
	} /* class QBRGameModeUpdateQuery */
}
