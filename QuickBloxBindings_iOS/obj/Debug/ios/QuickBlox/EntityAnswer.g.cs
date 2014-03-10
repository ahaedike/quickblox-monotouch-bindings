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
	[Register("EntityAnswer", true)]
	public unsafe partial class EntityAnswer : XmlAnswer {
		[CompilerGenerated]
		const string selEntity = "entity";
		static readonly IntPtr selEntityHandle = Selector.GetHandle ("entity");
		[CompilerGenerated]
		const string selSetEntity_ = "setEntity:";
		static readonly IntPtr selSetEntity_Handle = Selector.GetHandle ("setEntity:");
		[CompilerGenerated]
		const string selEntityElementName = "entityElementName";
		static readonly IntPtr selEntityElementNameHandle = Selector.GetHandle ("entityElementName");
		[CompilerGenerated]
		const string selEntityClass = "entityClass";
		static readonly IntPtr selEntityClassHandle = Selector.GetHandle ("entityClass");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("EntityAnswer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public EntityAnswer () : base (NSObjectFlag.Empty)
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
		public EntityAnswer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public EntityAnswer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public EntityAnswer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_Entity_var;
		[CompilerGenerated]
		public virtual Entity Entity {
			[Export ("entity", ArgumentSemantic.Retain)]
			get {
				Entity ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<Entity> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEntityHandle));
				} else {
					ret =  Runtime.GetNSObject<Entity> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEntityHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Entity_var = ret;
				return ret;
			}
			
			[Export ("setEntity:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetEntity_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetEntity_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Entity_var = value;
			}
		}
		
		[CompilerGenerated]
		public static string EntityElementName {
			[Export ("entityElementName")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selEntityElementNameHandle));
			}
			
		}
		
		[CompilerGenerated]
		public static Class EntityClass {
			[Export ("entityClass")]
			get {
				return new Class (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selEntityClassHandle));
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Entity_var = null;
			}
		}
	} /* class EntityAnswer */
}
