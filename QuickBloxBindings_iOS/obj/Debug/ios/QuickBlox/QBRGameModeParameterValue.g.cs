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
	[Register("QBRGameModeParameterValue", true)]
	public unsafe partial class QBRGameModeParameterValue : Entity {
		[CompilerGenerated]
		const string selGameModeParameterID = "gameModeParameterID";
		static readonly IntPtr selGameModeParameterIDHandle = Selector.GetHandle ("gameModeParameterID");
		[CompilerGenerated]
		const string selSetGameModeParameterID_ = "setGameModeParameterID:";
		static readonly IntPtr selSetGameModeParameterID_Handle = Selector.GetHandle ("setGameModeParameterID:");
		[CompilerGenerated]
		const string selScoreID = "scoreID";
		static readonly IntPtr selScoreIDHandle = Selector.GetHandle ("scoreID");
		[CompilerGenerated]
		const string selSetScoreID_ = "setScoreID:";
		static readonly IntPtr selSetScoreID_Handle = Selector.GetHandle ("setScoreID:");
		[CompilerGenerated]
		const string selValue = "value";
		static readonly IntPtr selValueHandle = Selector.GetHandle ("value");
		[CompilerGenerated]
		const string selSetValue_ = "setValue:";
		static readonly IntPtr selSetValue_Handle = Selector.GetHandle ("setValue:");
		[CompilerGenerated]
		const string selGameModeParameterValue = "gameModeParameterValue";
		static readonly IntPtr selGameModeParameterValueHandle = Selector.GetHandle ("gameModeParameterValue");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBRGameModeParameterValue");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBRGameModeParameterValue () : base (NSObjectFlag.Empty)
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
		public QBRGameModeParameterValue (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRGameModeParameterValue (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRGameModeParameterValue (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::System.UInt32 GameModeParameterID {
			[Export ("gameModeParameterID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selGameModeParameterIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selGameModeParameterIDHandle);
				}
			}
			
			[Export ("setGameModeParameterID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetGameModeParameterID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetGameModeParameterID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 ScoreID {
			[Export ("scoreID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selScoreIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selScoreIDHandle);
				}
			}
			
			[Export ("setScoreID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetScoreID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetScoreID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Value {
			[Export ("value", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selValueHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selValueHandle));
				}
			}
			
			[Export ("setValue:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetValue_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetValue_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		static object __mt_GameModeParameterValue_var_static;
		[CompilerGenerated]
		public static QBRGameModeParameterValue GameModeParameterValue {
			[Export ("gameModeParameterValue")]
			get {
				QBRGameModeParameterValue ret;
				ret =  Runtime.GetNSObject<QBRGameModeParameterValue> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selGameModeParameterValueHandle));
				__mt_GameModeParameterValue_var_static = ret;
				return ret;
			}
			
		}
		
	} /* class QBRGameModeParameterValue */
}
