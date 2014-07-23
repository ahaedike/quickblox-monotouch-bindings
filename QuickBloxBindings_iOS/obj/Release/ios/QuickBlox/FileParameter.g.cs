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
	[Register("FileParameter", true)]
	public unsafe partial class FileParameter : NSObject {
		[CompilerGenerated]
		const string selContentType = "contentType";
		static readonly IntPtr selContentTypeHandle = Selector.GetHandle ("contentType");
		[CompilerGenerated]
		const string selFileData = "fileData";
		static readonly IntPtr selFileDataHandle = Selector.GetHandle ("fileData");
		[CompilerGenerated]
		const string selFileName = "fileName";
		static readonly IntPtr selFileNameHandle = Selector.GetHandle ("fileName");
		[CompilerGenerated]
		const string selFilePath = "filePath";
		static readonly IntPtr selFilePathHandle = Selector.GetHandle ("filePath");
		[CompilerGenerated]
		const string selParamName = "paramName";
		static readonly IntPtr selParamNameHandle = Selector.GetHandle ("paramName");
		[CompilerGenerated]
		const string selSetContentType_ = "setContentType:";
		static readonly IntPtr selSetContentType_Handle = Selector.GetHandle ("setContentType:");
		[CompilerGenerated]
		const string selSetFileData_ = "setFileData:";
		static readonly IntPtr selSetFileData_Handle = Selector.GetHandle ("setFileData:");
		[CompilerGenerated]
		const string selSetFileName_ = "setFileName:";
		static readonly IntPtr selSetFileName_Handle = Selector.GetHandle ("setFileName:");
		[CompilerGenerated]
		const string selSetFilePath_ = "setFilePath:";
		static readonly IntPtr selSetFilePath_Handle = Selector.GetHandle ("setFilePath:");
		[CompilerGenerated]
		const string selSetParamName_ = "setParamName:";
		static readonly IntPtr selSetParamName_Handle = Selector.GetHandle ("setParamName:");
		[CompilerGenerated]
		const string selSetType_ = "setType:";
		static readonly IntPtr selSetType_Handle = Selector.GetHandle ("setType:");
		[CompilerGenerated]
		const string selType = "type";
		static readonly IntPtr selTypeHandle = Selector.GetHandle ("type");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("FileParameter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FileParameter () : base (NSObjectFlag.Empty)
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
		public FileParameter (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public FileParameter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public FileParameter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string ContentType {
			[Export ("contentType", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentTypeHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selContentTypeHandle));
				}
			}
			
			[Export ("setContentType:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetContentType_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetContentType_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_FileData_var;
		[CompilerGenerated]
		public virtual NSData FileData {
			[Export ("fileData", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileDataHandle));
				} else {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFileDataHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_FileData_var = ret;
				return ret;
			}
			
			[Export ("setFileData:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFileData_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFileData_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_FileData_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string FileName {
			[Export ("fileName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFileNameHandle));
				}
			}
			
			[Export ("setFileName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFileName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFileName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string FilePath {
			[Export ("filePath", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFilePathHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFilePathHandle));
				}
			}
			
			[Export ("setFilePath:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFilePath_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFilePath_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamName {
			[Export ("paramName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamNameHandle));
				}
			}
			
			[Export ("setParamName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual FileParameterType Type {
			[Export ("type")]
			get {
				if (IsDirectBinding) {
					return (FileParameterType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selTypeHandle);
				} else {
					return (FileParameterType) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selTypeHandle);
				}
			}
			
			[Export ("setType:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetType_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetType_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FileData_var = null;
			}
		}
	} /* class FileParameter */
}
