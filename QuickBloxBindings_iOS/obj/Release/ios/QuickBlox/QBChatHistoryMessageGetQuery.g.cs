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
	[Register("QBChatHistoryMessageGetQuery", true)]
	public unsafe partial class QBChatHistoryMessageGetQuery : QBChatQuery {
		[CompilerGenerated]
		const string selInitWithDialogID_ = "initWithDialogID:";
		static readonly IntPtr selInitWithDialogID_Handle = Selector.GetHandle ("initWithDialogID:");
		[CompilerGenerated]
		const string selInitWithDialogIDExtendedRequest_ = "initWithDialogID:extendedRequest:";
		static readonly IntPtr selInitWithDialogIDExtendedRequest_Handle = Selector.GetHandle ("initWithDialogID:extendedRequest:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBChatHistoryMessageGetQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBChatHistoryMessageGetQuery () : base (NSObjectFlag.Empty)
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
		public QBChatHistoryMessageGetQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatHistoryMessageGetQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatHistoryMessageGetQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDialogID:")]
		[CompilerGenerated]
		public QBChatHistoryMessageGetQuery (string _dialogID)
			: base (NSObjectFlag.Empty)
		{
			if (_dialogID == null)
				throw new ArgumentNullException ("_dialogID");
			var ns_dialogID = NSString.CreateNative (_dialogID);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithDialogID_Handle, ns_dialogID), "initWithDialogID:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithDialogID_Handle, ns_dialogID), "initWithDialogID:");
			}
			NSString.ReleaseNative (ns_dialogID);
			
		}
		
		[Export ("initWithDialogID:extendedRequest:")]
		[CompilerGenerated]
		public QBChatHistoryMessageGetQuery (string _dialogID, NSMutableDictionary extendedRequest)
			: base (NSObjectFlag.Empty)
		{
			if (_dialogID == null)
				throw new ArgumentNullException ("_dialogID");
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			var ns_dialogID = NSString.CreateNative (_dialogID);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithDialogIDExtendedRequest_Handle, ns_dialogID, extendedRequest.Handle), "initWithDialogID:extendedRequest:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithDialogIDExtendedRequest_Handle, ns_dialogID, extendedRequest.Handle), "initWithDialogID:extendedRequest:");
			}
			NSString.ReleaseNative (ns_dialogID);
			
		}
		
	} /* class QBChatHistoryMessageGetQuery */
}
