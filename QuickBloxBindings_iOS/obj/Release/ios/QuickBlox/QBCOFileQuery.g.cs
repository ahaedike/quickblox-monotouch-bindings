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
	[Register("QBCOFileQuery", true)]
	public unsafe partial class QBCOFileQuery : NSObject {
		[CompilerGenerated]
		const string selClassName = "className";
		static readonly IntPtr selClassNameHandle = Selector.GetHandle ("className");
		[CompilerGenerated]
		const string selObjectID = "objectID";
		static readonly IntPtr selObjectIDHandle = Selector.GetHandle ("objectID");
		[CompilerGenerated]
		const string selFileFieldName = "fileFieldName";
		static readonly IntPtr selFileFieldNameHandle = Selector.GetHandle ("fileFieldName");
		[CompilerGenerated]
		const string selInitWithClassNameObjectIDFileFieldName_ = "initWithClassName:objectID:fileFieldName:";
		static readonly IntPtr selInitWithClassNameObjectIDFileFieldName_Handle = Selector.GetHandle ("initWithClassName:objectID:fileFieldName:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCOFileQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCOFileQuery () : base (NSObjectFlag.Empty)
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
		public QBCOFileQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOFileQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOFileQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithClassName:objectID:fileFieldName:")]
		[CompilerGenerated]
		public QBCOFileQuery (string className, string objectID, string fileFieldName)
			: base (NSObjectFlag.Empty)
		{
			if (className == null)
				throw new ArgumentNullException ("className");
			if (objectID == null)
				throw new ArgumentNullException ("objectID");
			if (fileFieldName == null)
				throw new ArgumentNullException ("fileFieldName");
			var nsclassName = NSString.CreateNative (className);
			var nsobjectID = NSString.CreateNative (objectID);
			var nsfileFieldName = NSString.CreateNative (fileFieldName);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithClassNameObjectIDFileFieldName_Handle, nsclassName, nsobjectID, nsfileFieldName), "initWithClassName:objectID:fileFieldName:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithClassNameObjectIDFileFieldName_Handle, nsclassName, nsobjectID, nsfileFieldName), "initWithClassName:objectID:fileFieldName:");
			}
			NSString.ReleaseNative (nsclassName);
			NSString.ReleaseNative (nsobjectID);
			NSString.ReleaseNative (nsfileFieldName);
			
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
		public virtual string ObjectID {
			[Export ("objectID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selObjectIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selObjectIDHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string FileFieldName {
			[Export ("fileFieldName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileFieldNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFileFieldNameHandle));
				}
			}
			
		}
		
	} /* class QBCOFileQuery */
}
