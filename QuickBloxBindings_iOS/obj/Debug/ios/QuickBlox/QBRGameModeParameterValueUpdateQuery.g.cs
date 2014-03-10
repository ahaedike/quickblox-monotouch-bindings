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
	[Register("QBRGameModeParameterValueUpdateQuery", true)]
	public unsafe partial class QBRGameModeParameterValueUpdateQuery : NSObject {
		[CompilerGenerated]
		const string selGameModeParameterValue = "gameModeParameterValue";
		static readonly IntPtr selGameModeParameterValueHandle = Selector.GetHandle ("gameModeParameterValue");
		[CompilerGenerated]
		const string selInitWithGameModeParameterValue_ = "initWithGameModeParameterValue:";
		static readonly IntPtr selInitWithGameModeParameterValue_Handle = Selector.GetHandle ("initWithGameModeParameterValue:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBRGameModeParameterValueUpdateQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBRGameModeParameterValueUpdateQuery () : base (NSObjectFlag.Empty)
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
		public QBRGameModeParameterValueUpdateQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRGameModeParameterValueUpdateQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRGameModeParameterValueUpdateQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithGameModeParameterValue:")]
		[CompilerGenerated]
		public QBRGameModeParameterValueUpdateQuery (QBRGameModeParameterValue gameModeParameterValue)
			: base (NSObjectFlag.Empty)
		{
			if (gameModeParameterValue == null)
				throw new ArgumentNullException ("gameModeParameterValue");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithGameModeParameterValue_Handle, gameModeParameterValue.Handle), "initWithGameModeParameterValue:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithGameModeParameterValue_Handle, gameModeParameterValue.Handle), "initWithGameModeParameterValue:");
			}
		}
		
		[CompilerGenerated]
		object __mt_GameModeParameterValue_var;
		[CompilerGenerated]
		public virtual QBRGameModeParameterValue GameModeParameterValue {
			[Export ("gameModeParameterValue")]
			get {
				QBRGameModeParameterValue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBRGameModeParameterValue> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGameModeParameterValueHandle));
				} else {
					ret =  Runtime.GetNSObject<QBRGameModeParameterValue> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGameModeParameterValueHandle));
				}
				MarkDirty ();
				__mt_GameModeParameterValue_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_GameModeParameterValue_var = null;
			}
		}
	} /* class QBRGameModeParameterValueUpdateQuery */
}
