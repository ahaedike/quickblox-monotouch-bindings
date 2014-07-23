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
	[Register("QBVideoChat", true)]
	public unsafe partial class QBVideoChat : NSObject {
		[CompilerGenerated]
		const string selAcceptCallWithOpponentIDConferenceType_ = "acceptCallWithOpponentID:conferenceType:";
		static readonly IntPtr selAcceptCallWithOpponentIDConferenceType_Handle = Selector.GetHandle ("acceptCallWithOpponentID:conferenceType:");
		[CompilerGenerated]
		const string selAcceptCallWithOpponentIDConferenceTypeCustomParameters_ = "acceptCallWithOpponentID:conferenceType:customParameters:";
		static readonly IntPtr selAcceptCallWithOpponentIDConferenceTypeCustomParameters_Handle = Selector.GetHandle ("acceptCallWithOpponentID:conferenceType:customParameters:");
		[CompilerGenerated]
		const string selCallUserConferenceType_ = "callUser:conferenceType:";
		static readonly IntPtr selCallUserConferenceType_Handle = Selector.GetHandle ("callUser:conferenceType:");
		[CompilerGenerated]
		const string selCallUserConferenceTypeCustomParameters_ = "callUser:conferenceType:customParameters:";
		static readonly IntPtr selCallUserConferenceTypeCustomParameters_Handle = Selector.GetHandle ("callUser:conferenceType:customParameters:");
		[CompilerGenerated]
		const string selCancelCall = "cancelCall";
		static readonly IntPtr selCancelCallHandle = Selector.GetHandle ("cancelCall");
		[CompilerGenerated]
		const string selCanSetVideoOutputPreset_ = "canSetVideoOutputPreset:";
		static readonly IntPtr selCanSetVideoOutputPreset_Handle = Selector.GetHandle ("canSetVideoOutputPreset:");
		[CompilerGenerated]
		const string selDrainWriteAudioQueue = "drainWriteAudioQueue";
		static readonly IntPtr selDrainWriteAudioQueueHandle = Selector.GetHandle ("drainWriteAudioQueue");
		[CompilerGenerated]
		const string selDrainWriteVideoQueue = "drainWriteVideoQueue";
		static readonly IntPtr selDrainWriteVideoQueueHandle = Selector.GetHandle ("drainWriteVideoQueue");
		[CompilerGenerated]
		const string selFinishCall = "finishCall";
		static readonly IntPtr selFinishCallHandle = Selector.GetHandle ("finishCall");
		[CompilerGenerated]
		const string selFinishCallWithCustomParameters_ = "finishCallWithCustomParameters:";
		static readonly IntPtr selFinishCallWithCustomParameters_Handle = Selector.GetHandle ("finishCallWithCustomParameters:");
		[CompilerGenerated]
		const string selIsCameraFlashEnabled = "isCameraFlashEnabled";
		static readonly IntPtr selIsCameraFlashEnabledHandle = Selector.GetHandle ("isCameraFlashEnabled");
		[CompilerGenerated]
		const string selIsMicrophoneEnabled = "isMicrophoneEnabled";
		static readonly IntPtr selIsMicrophoneEnabledHandle = Selector.GetHandle ("isMicrophoneEnabled");
		[CompilerGenerated]
		const string selIsRelayUsed = "isRelayUsed";
		static readonly IntPtr selIsRelayUsedHandle = Selector.GetHandle ("isRelayUsed");
		[CompilerGenerated]
		const string selIsUseCustomAudioChatSession = "isUseCustomAudioChatSession";
		static readonly IntPtr selIsUseCustomAudioChatSessionHandle = Selector.GetHandle ("isUseCustomAudioChatSession");
		[CompilerGenerated]
		const string selIsUseCustomVideoChatCaptureSession = "isUseCustomVideoChatCaptureSession";
		static readonly IntPtr selIsUseCustomVideoChatCaptureSessionHandle = Selector.GetHandle ("isUseCustomVideoChatCaptureSession");
		[CompilerGenerated]
		const string selProcessVideoChatCaptureAudioBuffer_ = "processVideoChatCaptureAudioBuffer:";
		static readonly IntPtr selProcessVideoChatCaptureAudioBuffer_Handle = Selector.GetHandle ("processVideoChatCaptureAudioBuffer:");
		[CompilerGenerated]
		const string selProcessVideoChatCaptureVideoSample_ = "processVideoChatCaptureVideoSample:";
		static readonly IntPtr selProcessVideoChatCaptureVideoSample_Handle = Selector.GetHandle ("processVideoChatCaptureVideoSample:");
		[CompilerGenerated]
		const string selRejectCallWithOpponentID_ = "rejectCallWithOpponentID:";
		static readonly IntPtr selRejectCallWithOpponentID_Handle = Selector.GetHandle ("rejectCallWithOpponentID:");
		[CompilerGenerated]
		const string selSessionID = "sessionID";
		static readonly IntPtr selSessionIDHandle = Selector.GetHandle ("sessionID");
		[CompilerGenerated]
		const string selSetCameraFlashEnabled_ = "setCameraFlashEnabled:";
		static readonly IntPtr selSetCameraFlashEnabled_Handle = Selector.GetHandle ("setCameraFlashEnabled:");
		[CompilerGenerated]
		const string selSetIsUseCustomAudioChatSession_ = "setIsUseCustomAudioChatSession:";
		static readonly IntPtr selSetIsUseCustomAudioChatSession_Handle = Selector.GetHandle ("setIsUseCustomAudioChatSession:");
		[CompilerGenerated]
		const string selSetIsUseCustomVideoChatCaptureSession_ = "setIsUseCustomVideoChatCaptureSession:";
		static readonly IntPtr selSetIsUseCustomVideoChatCaptureSession_Handle = Selector.GetHandle ("setIsUseCustomVideoChatCaptureSession:");
		[CompilerGenerated]
		const string selSetMicrophoneEnabled_ = "setMicrophoneEnabled:";
		static readonly IntPtr selSetMicrophoneEnabled_Handle = Selector.GetHandle ("setMicrophoneEnabled:");
		[CompilerGenerated]
		const string selSetUseBackCamera_ = "setUseBackCamera:";
		static readonly IntPtr selSetUseBackCamera_Handle = Selector.GetHandle ("setUseBackCamera:");
		[CompilerGenerated]
		const string selSetUseHeadphone_ = "setUseHeadphone:";
		static readonly IntPtr selSetUseHeadphone_Handle = Selector.GetHandle ("setUseHeadphone:");
		[CompilerGenerated]
		const string selSetVideoOutputPreset_ = "setVideoOutputPreset:";
		static readonly IntPtr selSetVideoOutputPreset_Handle = Selector.GetHandle ("setVideoOutputPreset:");
		[CompilerGenerated]
		const string selSetViewToRenderOpponentVideoStream_ = "setViewToRenderOpponentVideoStream:";
		static readonly IntPtr selSetViewToRenderOpponentVideoStream_Handle = Selector.GetHandle ("setViewToRenderOpponentVideoStream:");
		[CompilerGenerated]
		const string selSetViewToRenderOwnVideoStream_ = "setViewToRenderOwnVideoStream:";
		static readonly IntPtr selSetViewToRenderOwnVideoStream_Handle = Selector.GetHandle ("setViewToRenderOwnVideoStream:");
		[CompilerGenerated]
		const string selState = "state";
		static readonly IntPtr selStateHandle = Selector.GetHandle ("state");
		[CompilerGenerated]
		const string selSuspendStream_ = "suspendStream:";
		static readonly IntPtr selSuspendStream_Handle = Selector.GetHandle ("suspendStream:");
		[CompilerGenerated]
		const string selUseBackCamera = "useBackCamera";
		static readonly IntPtr selUseBackCameraHandle = Selector.GetHandle ("useBackCamera");
		[CompilerGenerated]
		const string selUseHeadphone = "useHeadphone";
		static readonly IntPtr selUseHeadphoneHandle = Selector.GetHandle ("useHeadphone");
		[CompilerGenerated]
		const string selVideoChatOpponentID = "videoChatOpponentID";
		static readonly IntPtr selVideoChatOpponentIDHandle = Selector.GetHandle ("videoChatOpponentID");
		[CompilerGenerated]
		const string selViewToRenderOpponentVideoStream = "viewToRenderOpponentVideoStream";
		static readonly IntPtr selViewToRenderOpponentVideoStreamHandle = Selector.GetHandle ("viewToRenderOpponentVideoStream");
		[CompilerGenerated]
		const string selViewToRenderOwnVideoStream = "viewToRenderOwnVideoStream";
		static readonly IntPtr selViewToRenderOwnVideoStreamHandle = Selector.GetHandle ("viewToRenderOwnVideoStream");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBVideoChat");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBVideoChat () : base (NSObjectFlag.Empty)
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
		public QBVideoChat (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBVideoChat (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBVideoChat (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("acceptCallWithOpponentID:conferenceType:")]
		[CompilerGenerated]
		public virtual void AcceptCallWithOpponentID (global::System.UInt32 userID, QBVideoChatConferenceType conferenceType)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_UInt32 (this.Handle, selAcceptCallWithOpponentIDConferenceType_Handle, userID, (UInt32)conferenceType);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32_UInt32 (this.SuperHandle, selAcceptCallWithOpponentIDConferenceType_Handle, userID, (UInt32)conferenceType);
			}
		}
		
		[Export ("acceptCallWithOpponentID:conferenceType:customParameters:")]
		[CompilerGenerated]
		public virtual void AcceptCallWithOpponentID (global::System.UInt32 userID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters)
		{
			if (customParameters == null)
				throw new ArgumentNullException ("customParameters");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_UInt32_IntPtr (this.Handle, selAcceptCallWithOpponentIDConferenceTypeCustomParameters_Handle, userID, (UInt32)conferenceType, customParameters.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_UInt32_IntPtr (this.SuperHandle, selAcceptCallWithOpponentIDConferenceTypeCustomParameters_Handle, userID, (UInt32)conferenceType, customParameters.Handle);
			}
		}
		
		[Export ("callUser:conferenceType:")]
		[CompilerGenerated]
		public virtual void CallUser (global::System.UInt32 userID, QBVideoChatConferenceType conferenceType)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32_UInt32 (this.Handle, selCallUserConferenceType_Handle, userID, (UInt32)conferenceType);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32_UInt32 (this.SuperHandle, selCallUserConferenceType_Handle, userID, (UInt32)conferenceType);
			}
		}
		
		[Export ("callUser:conferenceType:customParameters:")]
		[CompilerGenerated]
		public virtual void CallUser (global::System.UInt32 userID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters)
		{
			if (customParameters == null)
				throw new ArgumentNullException ("customParameters");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_UInt32_UInt32_IntPtr (this.Handle, selCallUserConferenceTypeCustomParameters_Handle, userID, (UInt32)conferenceType, customParameters.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32_UInt32_IntPtr (this.SuperHandle, selCallUserConferenceTypeCustomParameters_Handle, userID, (UInt32)conferenceType, customParameters.Handle);
			}
		}
		
		[Export ("cancelCall")]
		[CompilerGenerated]
		public virtual void CancelCall ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelCallHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCancelCallHandle);
			}
		}
		
		[Export ("canSetVideoOutputPreset:")]
		[CompilerGenerated]
		public virtual bool CanSetVideoOutputPreset (string preset)
		{
			if (preset == null)
				throw new ArgumentNullException ("preset");
			var nspreset = NSString.CreateNative (preset);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selCanSetVideoOutputPreset_Handle, nspreset);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selCanSetVideoOutputPreset_Handle, nspreset);
			}
			NSString.ReleaseNative (nspreset);
			
			return ret;
		}
		
		[Export ("drainWriteAudioQueue")]
		[CompilerGenerated]
		public virtual void DrainWriteAudioQueue ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDrainWriteAudioQueueHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDrainWriteAudioQueueHandle);
			}
		}
		
		[Export ("drainWriteVideoQueue")]
		[CompilerGenerated]
		public virtual void DrainWriteVideoQueue ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDrainWriteVideoQueueHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDrainWriteVideoQueueHandle);
			}
		}
		
		[Export ("finishCall")]
		[CompilerGenerated]
		public virtual void FinishCall ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFinishCallHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFinishCallHandle);
			}
		}
		
		[Export ("finishCallWithCustomParameters:")]
		[CompilerGenerated]
		public virtual void FinishCallWithCustomParameters (NSDictionary customParameters)
		{
			if (customParameters == null)
				throw new ArgumentNullException ("customParameters");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selFinishCallWithCustomParameters_Handle, customParameters.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selFinishCallWithCustomParameters_Handle, customParameters.Handle);
			}
		}
		
		[Export ("processVideoChatCaptureAudioBuffer:")]
		[CompilerGenerated]
		public virtual void ProcessVideoChatCaptureAudioBuffer (global::MonoTouch.AudioToolbox.AudioBuffer buffer)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_AudioBuffer (this.Handle, selProcessVideoChatCaptureAudioBuffer_Handle, buffer);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_AudioBuffer (this.SuperHandle, selProcessVideoChatCaptureAudioBuffer_Handle, buffer);
			}
		}
		
		[Export ("processVideoChatCaptureVideoSample:")]
		[CompilerGenerated]
		public virtual void ProcessVideoChatCaptureVideoSample (global::MonoTouch.CoreMedia.CMSampleBuffer sampleBuffer)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selProcessVideoChatCaptureVideoSample_Handle, sampleBuffer.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selProcessVideoChatCaptureVideoSample_Handle, sampleBuffer.Handle);
			}
		}
		
		[Export ("rejectCallWithOpponentID:")]
		[CompilerGenerated]
		public virtual void RejectCallWithOpponentID (global::System.UInt32 userID)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selRejectCallWithOpponentID_Handle, userID);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selRejectCallWithOpponentID_Handle, userID);
			}
		}
		
		[Export ("suspendStream:")]
		[CompilerGenerated]
		public virtual void SuspendStream (bool isSuspend)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSuspendStream_Handle, isSuspend);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSuspendStream_Handle, isSuspend);
			}
		}
		
		[CompilerGenerated]
		public virtual bool CameraFlashEnabled {
			[Export ("isCameraFlashEnabled")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCameraFlashEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsCameraFlashEnabledHandle);
				}
			}
			
			[Export ("setCameraFlashEnabled:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCameraFlashEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCameraFlashEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsUseCustomAudioChatSession {
			[Export ("isUseCustomAudioChatSession")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUseCustomAudioChatSessionHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsUseCustomAudioChatSessionHandle);
				}
			}
			
			[Export ("setIsUseCustomAudioChatSession:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsUseCustomAudioChatSession_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsUseCustomAudioChatSession_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsUseCustomVideoChatCaptureSession {
			[Export ("isUseCustomVideoChatCaptureSession")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUseCustomVideoChatCaptureSessionHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsUseCustomVideoChatCaptureSessionHandle);
				}
			}
			
			[Export ("setIsUseCustomVideoChatCaptureSession:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsUseCustomVideoChatCaptureSession_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsUseCustomVideoChatCaptureSession_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool MicrophoneEnabled {
			[Export ("isMicrophoneEnabled")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMicrophoneEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsMicrophoneEnabledHandle);
				}
			}
			
			[Export ("setMicrophoneEnabled:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMicrophoneEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetMicrophoneEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RelayUsed {
			[Export ("isRelayUsed")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRelayUsedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsRelayUsedHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SessionID {
			[Export ("sessionID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSessionIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSessionIDHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual QBVideoChatState State {
			[Export ("state")]
			get {
				if (IsDirectBinding) {
					return (QBVideoChatState) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selStateHandle);
				} else {
					return (QBVideoChatState) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selStateHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool UseBackCamera {
			[Export ("useBackCamera")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseBackCameraHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseBackCameraHandle);
				}
			}
			
			[Export ("setUseBackCamera:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseBackCamera_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseBackCamera_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseHeadphone {
			[Export ("useHeadphone")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseHeadphoneHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseHeadphoneHandle);
				}
			}
			
			[Export ("setUseHeadphone:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseHeadphone_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseHeadphone_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 VideoChatOpponentID {
			[Export ("videoChatOpponentID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selVideoChatOpponentIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selVideoChatOpponentIDHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string VideoOutputPreset {
			[Export ("setVideoOutputPreset:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetVideoOutputPreset_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetVideoOutputPreset_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_ViewToRenderOpponentVideoStream_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView ViewToRenderOpponentVideoStream {
			[Export ("viewToRenderOpponentVideoStream", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selViewToRenderOpponentVideoStreamHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selViewToRenderOpponentVideoStreamHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ViewToRenderOpponentVideoStream_var = ret;
				return ret;
			}
			
			[Export ("setViewToRenderOpponentVideoStream:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetViewToRenderOpponentVideoStream_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetViewToRenderOpponentVideoStream_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ViewToRenderOpponentVideoStream_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ViewToRenderOwnVideoStream_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView ViewToRenderOwnVideoStream {
			[Export ("viewToRenderOwnVideoStream", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selViewToRenderOwnVideoStreamHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selViewToRenderOwnVideoStreamHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ViewToRenderOwnVideoStream_var = ret;
				return ret;
			}
			
			[Export ("setViewToRenderOwnVideoStream:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetViewToRenderOwnVideoStream_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetViewToRenderOwnVideoStream_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ViewToRenderOwnVideoStream_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ViewToRenderOpponentVideoStream_var = null;
				__mt_ViewToRenderOwnVideoStream_var = null;
			}
		}
	} /* class QBVideoChat */
}
