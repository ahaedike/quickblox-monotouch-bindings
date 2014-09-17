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
	[Register("QBGeneralResponsePage", true)]
	public unsafe partial class QBGeneralResponsePage : NSObject {
		[CompilerGenerated]
		const string selCurrentPage = "currentPage";
		static readonly IntPtr selCurrentPageHandle = Selector.GetHandle ("currentPage");
		[CompilerGenerated]
		const string selPerPage = "perPage";
		static readonly IntPtr selPerPageHandle = Selector.GetHandle ("perPage");
		[CompilerGenerated]
		const string selResponsePageWithCurrentPagePerPage_ = "responsePageWithCurrentPage:perPage:";
		static readonly IntPtr selResponsePageWithCurrentPagePerPage_Handle = Selector.GetHandle ("responsePageWithCurrentPage:perPage:");
		[CompilerGenerated]
		const string selResponsePageWithCurrentPagePerPageTotalEntries_ = "responsePageWithCurrentPage:perPage:totalEntries:";
		static readonly IntPtr selResponsePageWithCurrentPagePerPageTotalEntries_Handle = Selector.GetHandle ("responsePageWithCurrentPage:perPage:totalEntries:");
		[CompilerGenerated]
		const string selSetCurrentPage_ = "setCurrentPage:";
		static readonly IntPtr selSetCurrentPage_Handle = Selector.GetHandle ("setCurrentPage:");
		[CompilerGenerated]
		const string selSetPerPage_ = "setPerPage:";
		static readonly IntPtr selSetPerPage_Handle = Selector.GetHandle ("setPerPage:");
		[CompilerGenerated]
		const string selTotalEntries = "totalEntries";
		static readonly IntPtr selTotalEntriesHandle = Selector.GetHandle ("totalEntries");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBGeneralResponsePage");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBGeneralResponsePage () : base (NSObjectFlag.Empty)
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
		public QBGeneralResponsePage (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBGeneralResponsePage (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBGeneralResponsePage (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("responsePageWithCurrentPage:perPage:totalEntries:")]
		[CompilerGenerated]
		public static QBGeneralResponsePage ResponsePageWithCurrentPage (global::System.UInt32 currentPage, global::System.UInt32 perPage, global::System.UInt32 totalEntries)
		{
			return  Runtime.GetNSObject<QBGeneralResponsePage> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_UInt32_UInt32 (class_ptr, selResponsePageWithCurrentPagePerPageTotalEntries_Handle, currentPage, perPage, totalEntries));
		}
		
		[Export ("responsePageWithCurrentPage:perPage:")]
		[CompilerGenerated]
		public static QBGeneralResponsePage ResponsePageWithCurrentPage (global::System.UInt32 currentPage, global::System.UInt32 perPage)
		{
			return  Runtime.GetNSObject<QBGeneralResponsePage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_UInt32 (class_ptr, selResponsePageWithCurrentPagePerPage_Handle, currentPage, perPage));
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 CurrentPage {
			[Export ("currentPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selCurrentPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selCurrentPageHandle);
				}
			}
			
			[Export ("setCurrentPage:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetCurrentPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetCurrentPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 PerPage {
			[Export ("perPage")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPerPageHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPerPageHandle);
				}
			}
			
			[Export ("setPerPage:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPerPage_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPerPage_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 TotalEntries {
			[Export ("totalEntries")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selTotalEntriesHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selTotalEntriesHandle);
				}
			}
			
		}
		
	} /* class QBGeneralResponsePage */
}
