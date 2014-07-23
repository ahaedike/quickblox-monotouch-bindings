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
	[Register("QBRGameModeParameterValuePagedAnswer", true)]
	public unsafe partial class QBRGameModeParameterValuePagedAnswer : PagedAnswer {
		[CompilerGenerated]
		const string selGameModeParemeterValues = "gameModeParemeterValues";
		static readonly IntPtr selGameModeParemeterValuesHandle = Selector.GetHandle ("gameModeParemeterValues");
		[CompilerGenerated]
		const string selSetGameModeParemeterValues_ = "setGameModeParemeterValues:";
		static readonly IntPtr selSetGameModeParemeterValues_Handle = Selector.GetHandle ("setGameModeParemeterValues:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBRGameModeParameterValuePagedAnswer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBRGameModeParameterValuePagedAnswer () : base (NSObjectFlag.Empty)
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
		public QBRGameModeParameterValuePagedAnswer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRGameModeParameterValuePagedAnswer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRGameModeParameterValuePagedAnswer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_GameModeParemeterValues_var;
		[CompilerGenerated]
		public virtual NSMutableArray GameModeParemeterValues {
			[Export ("gameModeParemeterValues", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGameModeParemeterValuesHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGameModeParemeterValuesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_GameModeParemeterValues_var = ret;
				return ret;
			}
			
			[Export ("setGameModeParemeterValues:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetGameModeParemeterValues_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetGameModeParemeterValues_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_GameModeParemeterValues_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_GameModeParemeterValues_var = null;
			}
		}
	} /* class QBRGameModeParameterValuePagedAnswer */
}
