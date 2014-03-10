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
	[Register("QBChatRoomOccupant", true)]
	public unsafe partial class QBChatRoomOccupant : NSObject {
		[CompilerGenerated]
		const string selNickname = "nickname";
		static readonly IntPtr selNicknameHandle = Selector.GetHandle ("nickname");
		[CompilerGenerated]
		const string selParameters = "parameters";
		static readonly IntPtr selParametersHandle = Selector.GetHandle ("parameters");
		[CompilerGenerated]
		const string selOccupantWithUserNicknameParameters_ = "occupantWithUserNickname:parameters:";
		static readonly IntPtr selOccupantWithUserNicknameParameters_Handle = Selector.GetHandle ("occupantWithUserNickname:parameters:");
		[CompilerGenerated]
		const string selInitWithUserNicknameParameters_ = "initWithUserNickname:parameters:";
		static readonly IntPtr selInitWithUserNicknameParameters_Handle = Selector.GetHandle ("initWithUserNickname:parameters:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBChatRoomOccupant");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBChatRoomOccupant () : base (NSObjectFlag.Empty)
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
		public QBChatRoomOccupant (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatRoomOccupant (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBChatRoomOccupant (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("occupantWithUserNickname:parameters:")]
		[CompilerGenerated]
		public static QBChatRoomOccupant OccupantWithUserNickname (string aNickname, NSDictionary parameters)
		{
			if (aNickname == null)
				throw new ArgumentNullException ("aNickname");
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			var nsaNickname = NSString.CreateNative (aNickname);
			
			QBChatRoomOccupant ret;
			ret =  Runtime.GetNSObject<QBChatRoomOccupant> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selOccupantWithUserNicknameParameters_Handle, nsaNickname, parameters.Handle));
			NSString.ReleaseNative (nsaNickname);
			
			return ret;
		}
		
		[Export ("initWithUserNickname:parameters:")]
		[CompilerGenerated]
		public QBChatRoomOccupant (string aNickname, NSDictionary parameters)
			: base (NSObjectFlag.Empty)
		{
			if (aNickname == null)
				throw new ArgumentNullException ("aNickname");
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			var nsaNickname = NSString.CreateNative (aNickname);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithUserNicknameParameters_Handle, nsaNickname, parameters.Handle), "initWithUserNickname:parameters:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithUserNicknameParameters_Handle, nsaNickname, parameters.Handle), "initWithUserNickname:parameters:");
			}
			NSString.ReleaseNative (nsaNickname);
			
		}
		
		[CompilerGenerated]
		public virtual string Nickname {
			[Export ("nickname")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNicknameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNicknameHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Parameters_var;
		[CompilerGenerated]
		public virtual NSDictionary Parameters {
			[Export ("parameters")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParametersHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParametersHandle));
				}
				MarkDirty ();
				__mt_Parameters_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Parameters_var = null;
			}
		}
	} /* class QBChatRoomOccupant */
}
