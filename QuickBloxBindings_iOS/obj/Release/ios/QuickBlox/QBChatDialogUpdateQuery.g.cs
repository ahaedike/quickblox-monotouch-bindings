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
	[Register("QBChatDialogUpdateQuery", true)]
	public unsafe partial class QBChatDialogUpdateQuery : QBChatQuery {
		[CompilerGenerated]
		const string selChatDialogID = "chatDialogID";
		static readonly IntPtr selChatDialogIDHandle = Selector.GetHandle ("chatDialogID");
		[CompilerGenerated]
		const string selExtendedRequest = "extendedRequest";
		static readonly IntPtr selExtendedRequestHandle = Selector.GetHandle ("extendedRequest");
		[CompilerGenerated]
		const string selInitWithChatDialogIDExtendedRequest_ = "initWithChatDialogID:extendedRequest:";
		static readonly IntPtr selInitWithChatDialogIDExtendedRequest_Handle = Selector.GetHandle ("initWithChatDialogID:extendedRequest:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBChatDialogUpdateQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBChatDialogUpdateQuery () : base (NSObjectFlag.Empty)
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
		public QBChatDialogUpdateQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatDialogUpdateQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatDialogUpdateQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithChatDialogID:extendedRequest:")]
		[CompilerGenerated]
		public QBChatDialogUpdateQuery (string dialogID, NSMutableDictionary extendedRequest)
			: base (NSObjectFlag.Empty)
		{
			if (dialogID == null)
				throw new ArgumentNullException ("dialogID");
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			var nsdialogID = NSString.CreateNative (dialogID);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithChatDialogIDExtendedRequest_Handle, nsdialogID, extendedRequest.Handle), "initWithChatDialogID:extendedRequest:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithChatDialogIDExtendedRequest_Handle, nsdialogID, extendedRequest.Handle), "initWithChatDialogID:extendedRequest:");
			}
			NSString.ReleaseNative (nsdialogID);
			
		}
		
		[CompilerGenerated]
		public virtual string ChatDialogID {
			[Export ("chatDialogID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selChatDialogIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selChatDialogIDHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ExtendedRequest_var;
		[CompilerGenerated]
		public virtual NSMutableDictionary ExtendedRequest {
			[Export ("extendedRequest", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selExtendedRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selExtendedRequestHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ExtendedRequest_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ExtendedRequest_var = null;
			}
		}
	} /* class QBChatDialogUpdateQuery */
}
