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
	[Register("QBCOCustomObjectGetQuery", true)]
	public unsafe partial class QBCOCustomObjectGetQuery : NSObject {
		[CompilerGenerated]
		const string selClassName = "className";
		static readonly IntPtr selClassNameHandle = Selector.GetHandle ("className");
		[CompilerGenerated]
		const string selGetRequest = "getRequest";
		static readonly IntPtr selGetRequestHandle = Selector.GetHandle ("getRequest");
		[CompilerGenerated]
		const string selID = "ID";
		static readonly IntPtr selIDHandle = Selector.GetHandle ("ID");
		[CompilerGenerated]
		const string selIDs = "IDs";
		static readonly IntPtr selIDsHandle = Selector.GetHandle ("IDs");
		[CompilerGenerated]
		const string selInitWithClassNameID_ = "initWithClassName:ID:";
		static readonly IntPtr selInitWithClassNameID_Handle = Selector.GetHandle ("initWithClassName:ID:");
		[CompilerGenerated]
		const string selInitWithClassNameIDs_ = "initWithClassName:IDs:";
		static readonly IntPtr selInitWithClassNameIDs_Handle = Selector.GetHandle ("initWithClassName:IDs:");
		[CompilerGenerated]
		const string selInitWithClassNameRequest_ = "initWithClassName:request:";
		static readonly IntPtr selInitWithClassNameRequest_Handle = Selector.GetHandle ("initWithClassName:request:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCOCustomObjectGetQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCOCustomObjectGetQuery () : base (NSObjectFlag.Empty)
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
		public QBCOCustomObjectGetQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOCustomObjectGetQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOCustomObjectGetQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithClassName:request:")]
		[CompilerGenerated]
		public QBCOCustomObjectGetQuery (string _className, NSMutableDictionary _getRequest)
			: base (NSObjectFlag.Empty)
		{
			if (_className == null)
				throw new ArgumentNullException ("_className");
			if (_getRequest == null)
				throw new ArgumentNullException ("_getRequest");
			var ns_className = NSString.CreateNative (_className);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithClassNameRequest_Handle, ns_className, _getRequest.Handle), "initWithClassName:request:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithClassNameRequest_Handle, ns_className, _getRequest.Handle), "initWithClassName:request:");
			}
			NSString.ReleaseNative (ns_className);
			
		}
		
		[Export ("initWithClassName:ID:")]
		[CompilerGenerated]
		public QBCOCustomObjectGetQuery (string _className, string _ID)
			: base (NSObjectFlag.Empty)
		{
			if (_className == null)
				throw new ArgumentNullException ("_className");
			if (_ID == null)
				throw new ArgumentNullException ("_ID");
			var ns_className = NSString.CreateNative (_className);
			var ns_ID = NSString.CreateNative (_ID);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithClassNameID_Handle, ns_className, ns_ID), "initWithClassName:ID:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithClassNameID_Handle, ns_className, ns_ID), "initWithClassName:ID:");
			}
			NSString.ReleaseNative (ns_className);
			NSString.ReleaseNative (ns_ID);
			
		}
		
		[Export ("initWithClassName:IDs:")]
		[CompilerGenerated]
		public QBCOCustomObjectGetQuery (string _className, NSObject[] _IDs)
			: base (NSObjectFlag.Empty)
		{
			if (_className == null)
				throw new ArgumentNullException ("_className");
			if (_IDs == null)
				throw new ArgumentNullException ("_IDs");
			var ns_className = NSString.CreateNative (_className);
			var nsa__IDs = NSArray.FromNSObjects (_IDs);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithClassNameIDs_Handle, ns_className, nsa__IDs.Handle), "initWithClassName:IDs:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithClassNameIDs_Handle, ns_className, nsa__IDs.Handle), "initWithClassName:IDs:");
			}
			NSString.ReleaseNative (ns_className);
			nsa__IDs.Dispose ();
			
		}
		
		[CompilerGenerated]
		public virtual string ClassName {
			[Export ("className")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selClassNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selClassNameHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_GetRequest_var;
		[CompilerGenerated]
		public virtual NSMutableDictionary GetRequest {
			[Export ("getRequest")]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGetRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGetRequestHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_GetRequest_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ID {
			[Export ("ID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIDHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_IDs_var;
		[CompilerGenerated]
		public virtual NSObject[] IDs {
			[Export ("IDs")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIDsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIDsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_IDs_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_GetRequest_var = null;
				__mt_IDs_var = null;
			}
		}
	} /* class QBCOCustomObjectGetQuery */
}
