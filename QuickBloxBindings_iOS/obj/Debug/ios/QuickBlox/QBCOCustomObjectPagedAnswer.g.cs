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
	[Register("QBCOCustomObjectPagedAnswer", true)]
	public unsafe partial class QBCOCustomObjectPagedAnswer : XmlAnswer {
		[CompilerGenerated]
		const string selObjects = "objects";
		static readonly IntPtr selObjectsHandle = Selector.GetHandle ("objects");
		[CompilerGenerated]
		const string selCount = "count";
		static readonly IntPtr selCountHandle = Selector.GetHandle ("count");
		[CompilerGenerated]
		const string selSkip = "skip";
		static readonly IntPtr selSkipHandle = Selector.GetHandle ("skip");
		[CompilerGenerated]
		const string selLimit = "limit";
		static readonly IntPtr selLimitHandle = Selector.GetHandle ("limit");
		[CompilerGenerated]
		const string selNotFoundObjectsIDs = "notFoundObjectsIDs";
		static readonly IntPtr selNotFoundObjectsIDsHandle = Selector.GetHandle ("notFoundObjectsIDs");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCOCustomObjectPagedAnswer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCOCustomObjectPagedAnswer () : base (NSObjectFlag.Empty)
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
		public QBCOCustomObjectPagedAnswer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOCustomObjectPagedAnswer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOCustomObjectPagedAnswer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_Objects_var;
		[CompilerGenerated]
		public virtual NSMutableArray Objects {
			[Export ("objects")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selObjectsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selObjectsHandle));
				}
				MarkDirty ();
				__mt_Objects_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Count {
			[Export ("count")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selCountHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selCountHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Skip {
			[Export ("skip")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selSkipHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selSkipHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 Limit {
			[Export ("limit")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selLimitHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selLimitHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_NotFoundObjectsIDs_var;
		[CompilerGenerated]
		public virtual NSObject[] NotFoundObjectsIDs {
			[Export ("notFoundObjectsIDs")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNotFoundObjectsIDsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNotFoundObjectsIDsHandle));
				}
				MarkDirty ();
				__mt_NotFoundObjectsIDs_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Objects_var = null;
				__mt_NotFoundObjectsIDs_var = null;
			}
		}
	} /* class QBCOCustomObjectPagedAnswer */
}
