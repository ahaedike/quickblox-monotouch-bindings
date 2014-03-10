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
	[Register("QBAudioIOService", true)]
	public unsafe partial class QBAudioIOService : NSObject {
		[CompilerGenerated]
		const string selInputAvailable = "inputAvailable";
		static readonly IntPtr selInputAvailableHandle = Selector.GetHandle ("inputAvailable");
		[CompilerGenerated]
		const string selRunning = "running";
		static readonly IntPtr selRunningHandle = Selector.GetHandle ("running");
		[CompilerGenerated]
		const string selNumInputChannels = "numInputChannels";
		static readonly IntPtr selNumInputChannelsHandle = Selector.GetHandle ("numInputChannels");
		[CompilerGenerated]
		const string selNumOutputChannels = "numOutputChannels";
		static readonly IntPtr selNumOutputChannelsHandle = Selector.GetHandle ("numOutputChannels");
		[CompilerGenerated]
		const string selManagingFromApplication = "managingFromApplication";
		static readonly IntPtr selManagingFromApplicationHandle = Selector.GetHandle ("managingFromApplication");
		[CompilerGenerated]
		const string selSetManagingFromApplication_ = "setManagingFromApplication:";
		static readonly IntPtr selSetManagingFromApplication_Handle = Selector.GetHandle ("setManagingFromApplication:");
		[CompilerGenerated]
		const string selShared = "shared";
		static readonly IntPtr selSharedHandle = Selector.GetHandle ("shared");
		[CompilerGenerated]
		const string selStart = "start";
		static readonly IntPtr selStartHandle = Selector.GetHandle ("start");
		[CompilerGenerated]
		const string selStop = "stop";
		static readonly IntPtr selStopHandle = Selector.GetHandle ("stop");
		[CompilerGenerated]
		const string selSetupAudioSession = "setupAudioSession";
		static readonly IntPtr selSetupAudioSessionHandle = Selector.GetHandle ("setupAudioSession");
		[CompilerGenerated]
		const string selRouteToSpeaker = "routeToSpeaker";
		static readonly IntPtr selRouteToSpeakerHandle = Selector.GetHandle ("routeToSpeaker");
		[CompilerGenerated]
		const string selRouteToHeadphone = "routeToHeadphone";
		static readonly IntPtr selRouteToHeadphoneHandle = Selector.GetHandle ("routeToHeadphone");
		[CompilerGenerated]
		const string selEncodePCMtoiLBC_ = "encodePCMtoiLBC:";
		static readonly IntPtr selEncodePCMtoiLBC_Handle = Selector.GetHandle ("encodePCMtoiLBC:");
		[CompilerGenerated]
		const string selDecodeiLBCtoPCM_ = "decodeiLBCtoPCM:";
		static readonly IntPtr selDecodeiLBCtoPCM_Handle = Selector.GetHandle ("decodeiLBCtoPCM:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBAudioIOService");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBAudioIOService () : base (NSObjectFlag.Empty)
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
		public QBAudioIOService (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBAudioIOService (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBAudioIOService (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("start")]
		[CompilerGenerated]
		public virtual void Start ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStartHandle);
			}
		}
		
		[Export ("stop")]
		[CompilerGenerated]
		public virtual void Stop ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStopHandle);
			}
		}
		
		[Export ("setupAudioSession")]
		[CompilerGenerated]
		public virtual void SetupAudioSession ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetupAudioSessionHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selSetupAudioSessionHandle);
			}
		}
		
		[Export ("routeToSpeaker")]
		[CompilerGenerated]
		public virtual void RouteToSpeaker ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRouteToSpeakerHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRouteToSpeakerHandle);
			}
		}
		
		[Export ("routeToHeadphone")]
		[CompilerGenerated]
		public virtual void RouteToHeadphone ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRouteToHeadphoneHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRouteToHeadphoneHandle);
			}
		}
		
		[Export ("encodePCMtoiLBC:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.AudioToolbox.AudioBuffer EncodePCMtoiLBC (global::MonoTouch.AudioToolbox.AudioBuffer pcmData)
		{
			global::MonoTouch.AudioToolbox.AudioBuffer ret;
			if (IsDirectBinding) {
				ApiDefinition.Messaging.AudioBuffer_objc_msgSend_stret_AudioBuffer (out ret, this.Handle, selEncodePCMtoiLBC_Handle, pcmData);
			} else {
				ApiDefinition.Messaging.AudioBuffer_objc_msgSendSuper_stret_AudioBuffer (out ret, this.SuperHandle, selEncodePCMtoiLBC_Handle, pcmData);
			}
			return ret;
		}
		
		[Export ("decodeiLBCtoPCM:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.AudioToolbox.AudioBuffer DecodeiLBCtoPCM (global::MonoTouch.AudioToolbox.AudioBuffer iLBCData)
		{
			global::MonoTouch.AudioToolbox.AudioBuffer ret;
			if (IsDirectBinding) {
				ApiDefinition.Messaging.AudioBuffer_objc_msgSend_stret_AudioBuffer (out ret, this.Handle, selDecodeiLBCtoPCM_Handle, iLBCData);
			} else {
				ApiDefinition.Messaging.AudioBuffer_objc_msgSendSuper_stret_AudioBuffer (out ret, this.SuperHandle, selDecodeiLBCtoPCM_Handle, iLBCData);
			}
			return ret;
		}
		
		[CompilerGenerated]
		public virtual bool InputAvailable {
			[Export ("inputAvailable")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selInputAvailableHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selInputAvailableHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Running {
			[Export ("running")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRunningHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selRunningHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 NumInputChannels {
			[Export ("numInputChannels")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selNumInputChannelsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selNumInputChannelsHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 NumOutputChannels {
			[Export ("numOutputChannels")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selNumOutputChannelsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selNumOutputChannelsHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ManagingFromApplication {
			[Export ("managingFromApplication")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selManagingFromApplicationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selManagingFromApplicationHandle);
				}
			}
			
			[Export ("setManagingFromApplication:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetManagingFromApplication_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetManagingFromApplication_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		static object __mt_Shared_var_static;
		[CompilerGenerated]
		public static QBAudioIOService Shared {
			[Export ("shared")]
			get {
				QBAudioIOService ret;
				ret =  Runtime.GetNSObject<QBAudioIOService> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedHandle));
				__mt_Shared_var_static = ret;
				return ret;
			}
			
		}
		
	} /* class QBAudioIOService */
}
