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
	[Register("QBRGameModeParameterValueAnswer", true)]
	public unsafe partial class QBRGameModeParameterValueAnswer : EntityAnswer {
		[CompilerGenerated]
		const string selGameModeParameterValue = "gameModeParameterValue";
		static readonly IntPtr selGameModeParameterValueHandle = Selector.GetHandle ("gameModeParameterValue");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBRGameModeParameterValueAnswer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBRGameModeParameterValueAnswer () : base (NSObjectFlag.Empty)
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
		public QBRGameModeParameterValueAnswer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRGameModeParameterValueAnswer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRGameModeParameterValueAnswer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
				if (!IsNewRefcountEnabled ())
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
	} /* class QBRGameModeParameterValueAnswer */
}
