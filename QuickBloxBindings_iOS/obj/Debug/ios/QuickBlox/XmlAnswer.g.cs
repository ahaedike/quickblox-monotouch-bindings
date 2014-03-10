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
	[Register("XmlAnswer", true)]
	public unsafe partial class XmlAnswer : RestAnswer {
		[CompilerGenerated]
		const string selElements = "elements";
		static readonly IntPtr selElementsHandle = Selector.GetHandle ("elements");
		[CompilerGenerated]
		const string selSetElements_ = "setElements:";
		static readonly IntPtr selSetElements_Handle = Selector.GetHandle ("setElements:");
		[CompilerGenerated]
		const string selCurrentElement = "currentElement";
		static readonly IntPtr selCurrentElementHandle = Selector.GetHandle ("currentElement");
		[CompilerGenerated]
		const string selPrevElement = "prevElement";
		static readonly IntPtr selPrevElementHandle = Selector.GetHandle ("prevElement");
		[CompilerGenerated]
		const string selPrevPrevElement = "prevPrevElement";
		static readonly IntPtr selPrevPrevElementHandle = Selector.GetHandle ("prevPrevElement");
		[CompilerGenerated]
		const string selPrevPrevPrevElement = "prevPrevPrevElement";
		static readonly IntPtr selPrevPrevPrevElementHandle = Selector.GetHandle ("prevPrevPrevElement");
		[CompilerGenerated]
		const string selPrevPrevPrevPrevElement = "prevPrevPrevPrevElement";
		static readonly IntPtr selPrevPrevPrevPrevElementHandle = Selector.GetHandle ("prevPrevPrevPrevElement");
		[CompilerGenerated]
		const string selPrevPrevPrevPrevPrevElement = "prevPrevPrevPrevPrevElement";
		static readonly IntPtr selPrevPrevPrevPrevPrevElementHandle = Selector.GetHandle ("prevPrevPrevPrevPrevElement");
		[CompilerGenerated]
		const string selEncodeEncoding = "encodeEncoding";
		static readonly IntPtr selEncodeEncodingHandle = Selector.GetHandle ("encodeEncoding");
		[CompilerGenerated]
		const string selSetEncodeEncoding_ = "setEncodeEncoding:";
		static readonly IntPtr selSetEncodeEncoding_Handle = Selector.GetHandle ("setEncodeEncoding:");
		[CompilerGenerated]
		const string selDecodeEncoding = "decodeEncoding";
		static readonly IntPtr selDecodeEncodingHandle = Selector.GetHandle ("decodeEncoding");
		[CompilerGenerated]
		const string selSetDecodeEncoding_ = "setDecodeEncoding:";
		static readonly IntPtr selSetDecodeEncoding_Handle = Selector.GetHandle ("setDecodeEncoding:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selDefaultEncodeEncoding = "defaultEncodeEncoding";
		static readonly IntPtr selDefaultEncodeEncodingHandle = Selector.GetHandle ("defaultEncodeEncoding");
		[CompilerGenerated]
		const string selDefaultDecodeEncoding = "defaultDecodeEncoding";
		static readonly IntPtr selDefaultDecodeEncodingHandle = Selector.GetHandle ("defaultDecodeEncoding");
		[CompilerGenerated]
		const string selLoadFromUrlParseError_ = "LoadFromUrl:parseError:";
		static readonly IntPtr selLoadFromUrlParseError_Handle = Selector.GetHandle ("LoadFromUrl:parseError:");
		[CompilerGenerated]
		const string selLoadStringEncodingParseError_ = "loadString:encoding:parseError:";
		static readonly IntPtr selLoadStringEncodingParseError_Handle = Selector.GetHandle ("loadString:encoding:parseError:");
		[CompilerGenerated]
		const string selLoadStringParseError_ = "loadString:parseError:";
		static readonly IntPtr selLoadStringParseError_Handle = Selector.GetHandle ("loadString:parseError:");
		[CompilerGenerated]
		const string selLoadDataParseError_ = "loadData:parseError:";
		static readonly IntPtr selLoadDataParseError_Handle = Selector.GetHandle ("loadData:parseError:");
		[CompilerGenerated]
		const string selHandleElementAttributes_ = "handleElement:attributes:";
		static readonly IntPtr selHandleElementAttributes_Handle = Selector.GetHandle ("handleElement:attributes:");
		[CompilerGenerated]
		const string selHandleEndOfElement_ = "handleEndOfElement:";
		static readonly IntPtr selHandleEndOfElement_Handle = Selector.GetHandle ("handleEndOfElement:");
		[CompilerGenerated]
		const string selHandleTextCurrentElement_ = "handleText:currentElement:";
		static readonly IntPtr selHandleTextCurrentElement_Handle = Selector.GetHandle ("handleText:currentElement:");
		[CompilerGenerated]
		const string selHandleDataCurrentElement_ = "handleData:currentElement:";
		static readonly IntPtr selHandleDataCurrentElement_Handle = Selector.GetHandle ("handleData:currentElement:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("XmlAnswer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public XmlAnswer () : base (NSObjectFlag.Empty)
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
		public XmlAnswer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public XmlAnswer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public XmlAnswer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("LoadFromUrl:parseError:")]
		[CompilerGenerated]
		public virtual NSObject LoadFromUrl (NSUrl URL, out NSError error)
		{
			if (URL == null)
				throw new ArgumentNullException ("URL");
			IntPtr errorPtr = Marshal.AllocHGlobal(IntPtr.Size);
			Marshal.WriteIntPtr(errorPtr, IntPtr.Zero);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selLoadFromUrlParseError_Handle, URL.Handle, errorPtr));
			} else {
				ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selLoadFromUrlParseError_Handle, URL.Handle, errorPtr));
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("loadString:encoding:parseError:")]
		[CompilerGenerated]
		public virtual NSObject LoadString (string xmlString, NSStringEncoding encoding, out NSError error)
		{
			if (xmlString == null)
				throw new ArgumentNullException ("xmlString");
			IntPtr errorPtr = Marshal.AllocHGlobal(IntPtr.Size);
			Marshal.WriteIntPtr(errorPtr, IntPtr.Zero);
			
			var nsxmlString = NSString.CreateNative (xmlString);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, selLoadStringEncodingParseError_Handle, nsxmlString, (UInt32)encoding, errorPtr));
			} else {
				ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr (this.SuperHandle, selLoadStringEncodingParseError_Handle, nsxmlString, (UInt32)encoding, errorPtr));
			}
			NSString.ReleaseNative (nsxmlString);
			
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("loadString:parseError:")]
		[CompilerGenerated]
		public virtual NSObject LoadString (string xmlString, out NSError error)
		{
			if (xmlString == null)
				throw new ArgumentNullException ("xmlString");
			IntPtr errorPtr = Marshal.AllocHGlobal(IntPtr.Size);
			Marshal.WriteIntPtr(errorPtr, IntPtr.Zero);
			
			var nsxmlString = NSString.CreateNative (xmlString);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selLoadStringParseError_Handle, nsxmlString, errorPtr));
			} else {
				ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selLoadStringParseError_Handle, nsxmlString, errorPtr));
			}
			NSString.ReleaseNative (nsxmlString);
			
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("loadData:parseError:")]
		[CompilerGenerated]
		public virtual NSObject LoadData (NSData data, out NSError error)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			IntPtr errorPtr = Marshal.AllocHGlobal(IntPtr.Size);
			Marshal.WriteIntPtr(errorPtr, IntPtr.Zero);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selLoadDataParseError_Handle, data.Handle, errorPtr));
			} else {
				ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selLoadDataParseError_Handle, data.Handle, errorPtr));
			}
			
			IntPtr errorValue = Marshal.ReadIntPtr(errorPtr);
			error = errorValue != IntPtr.Zero ? Runtime.GetNSObject<NSError> (errorValue) : null;
			Marshal.FreeHGlobal(errorPtr);
			
			return ret;
		}
		
		[Export ("handleElement:attributes:")]
		[CompilerGenerated]
		public virtual void HandleElement (string elementName, NSDictionary attributeDict)
		{
			if (elementName == null)
				throw new ArgumentNullException ("elementName");
			if (attributeDict == null)
				throw new ArgumentNullException ("attributeDict");
			var nselementName = NSString.CreateNative (elementName);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selHandleElementAttributes_Handle, nselementName, attributeDict.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selHandleElementAttributes_Handle, nselementName, attributeDict.Handle);
			}
			NSString.ReleaseNative (nselementName);
			
		}
		
		[Export ("handleEndOfElement:")]
		[CompilerGenerated]
		public virtual void HandleEndOfElement (string elementName)
		{
			if (elementName == null)
				throw new ArgumentNullException ("elementName");
			var nselementName = NSString.CreateNative (elementName);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selHandleEndOfElement_Handle, nselementName);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selHandleEndOfElement_Handle, nselementName);
			}
			NSString.ReleaseNative (nselementName);
			
		}
		
		[Export ("handleText:currentElement:")]
		[CompilerGenerated]
		public virtual void HandleText (string text, string element)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			if (element == null)
				throw new ArgumentNullException ("element");
			var nstext = NSString.CreateNative (text);
			var nselement = NSString.CreateNative (element);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selHandleTextCurrentElement_Handle, nstext, nselement);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selHandleTextCurrentElement_Handle, nstext, nselement);
			}
			NSString.ReleaseNative (nstext);
			NSString.ReleaseNative (nselement);
			
		}
		
		[Export ("handleData:currentElement:")]
		[CompilerGenerated]
		public virtual void HandleData (NSData data, string element)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (element == null)
				throw new ArgumentNullException ("element");
			var nselement = NSString.CreateNative (element);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selHandleDataCurrentElement_Handle, data.Handle, nselement);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selHandleDataCurrentElement_Handle, data.Handle, nselement);
			}
			NSString.ReleaseNative (nselement);
			
		}
		
		[CompilerGenerated]
		object __mt_Elements_var;
		[CompilerGenerated]
		public virtual NSMutableArray Elements {
			[Export ("elements", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selElementsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selElementsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Elements_var = ret;
				return ret;
			}
			
			[Export ("setElements:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetElements_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetElements_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Elements_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string CurrentElement {
			[Export ("currentElement")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCurrentElementHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCurrentElementHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PrevElement {
			[Export ("prevElement")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPrevElementHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPrevElementHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PrevPrevElement {
			[Export ("prevPrevElement")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPrevPrevElementHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPrevPrevElementHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PrevPrevPrevElement {
			[Export ("prevPrevPrevElement")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPrevPrevPrevElementHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPrevPrevPrevElementHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PrevPrevPrevPrevElement {
			[Export ("prevPrevPrevPrevElement")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPrevPrevPrevPrevElementHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPrevPrevPrevPrevElementHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PrevPrevPrevPrevPrevElement {
			[Export ("prevPrevPrevPrevPrevElement")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPrevPrevPrevPrevPrevElementHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPrevPrevPrevPrevPrevElementHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSStringEncoding EncodeEncoding {
			[Export ("encodeEncoding")]
			get {
				if (IsDirectBinding) {
					return (NSStringEncoding) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selEncodeEncodingHandle);
				} else {
					return (NSStringEncoding) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selEncodeEncodingHandle);
				}
			}
			
			[Export ("setEncodeEncoding:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetEncodeEncoding_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetEncodeEncoding_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSStringEncoding DecodeEncoding {
			[Export ("decodeEncoding")]
			get {
				if (IsDirectBinding) {
					return (NSStringEncoding) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selDecodeEncodingHandle);
				} else {
					return (NSStringEncoding) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selDecodeEncodingHandle);
				}
			}
			
			[Export ("setDecodeEncoding:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetDecodeEncoding_Handle, (UInt32)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetDecodeEncoding_Handle, (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual XmlAnswer Delegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				XmlAnswer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<XmlAnswer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<XmlAnswer> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public static NSStringEncoding DefaultEncodeEncoding {
			[Export ("defaultEncodeEncoding")]
			get {
				return (NSStringEncoding) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (class_ptr, selDefaultEncodeEncodingHandle);
			}
			
		}
		
		[CompilerGenerated]
		public static NSStringEncoding DefaultDecodeEncoding {
			[Export ("defaultDecodeEncoding")]
			get {
				return (NSStringEncoding) MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (class_ptr, selDefaultDecodeEncodingHandle);
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Elements_var = null;
				__mt_Delegate_var = null;
			}
		}
	} /* class XmlAnswer */
}
