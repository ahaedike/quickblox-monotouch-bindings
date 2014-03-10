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
	[Register("QBCOUtils", true)]
	public unsafe partial class QBCOUtils : NSObject {
		[CompilerGenerated]
		const string selExtractFieldsToRequestParamsRequestParamsKeyFormat_ = "extractFieldsToRequestParams:requestParams:keyFormat:";
		static readonly IntPtr selExtractFieldsToRequestParamsRequestParamsKeyFormat_Handle = Selector.GetHandle ("extractFieldsToRequestParams:requestParams:keyFormat:");
		[CompilerGenerated]
		const string selExtractPermissionsToRequestParamsRequestParamsKeyFormat_ = "extractPermissionsToRequestParams:requestParams:keyFormat:";
		static readonly IntPtr selExtractPermissionsToRequestParamsRequestParamsKeyFormat_Handle = Selector.GetHandle ("extractPermissionsToRequestParams:requestParams:keyFormat:");
		[CompilerGenerated]
		const string selExtractSpecialUpdateOperatorsToRequestParamsRequestParamsKeyFormat_ = "extractSpecialUpdateOperatorsToRequestParams:requestParams:keyFormat:";
		static readonly IntPtr selExtractSpecialUpdateOperatorsToRequestParamsRequestParamsKeyFormat_Handle = Selector.GetHandle ("extractSpecialUpdateOperatorsToRequestParams:requestParams:keyFormat:");
		[CompilerGenerated]
		const string selExtractParametersToRequestURLRequestURLKeyFormat_ = "extractParametersToRequestURL:requestURL:keyFormat:";
		static readonly IntPtr selExtractParametersToRequestURLRequestURLKeyFormat_Handle = Selector.GetHandle ("extractParametersToRequestURL:requestURL:keyFormat:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBCOUtils");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBCOUtils () : base (NSObjectFlag.Empty)
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
		public QBCOUtils (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOUtils (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBCOUtils (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("extractFieldsToRequestParams:requestParams:keyFormat:")]
		[CompilerGenerated]
		public static void ExtractFieldsToRequestParams (QBCOCustomObject record, NSMutableDictionary requestParams, string keyFormat)
		{
			if (record == null)
				throw new ArgumentNullException ("record");
			if (requestParams == null)
				throw new ArgumentNullException ("requestParams");
			if (keyFormat == null)
				throw new ArgumentNullException ("keyFormat");
			var nskeyFormat = NSString.CreateNative (keyFormat);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selExtractFieldsToRequestParamsRequestParamsKeyFormat_Handle, record.Handle, requestParams.Handle, nskeyFormat);
			NSString.ReleaseNative (nskeyFormat);
			
		}
		
		[Export ("extractPermissionsToRequestParams:requestParams:keyFormat:")]
		[CompilerGenerated]
		public static void ExtractPermissionsToRequestParams (QBCOCustomObject record, NSMutableDictionary requestParams, string keyFormat)
		{
			if (record == null)
				throw new ArgumentNullException ("record");
			if (requestParams == null)
				throw new ArgumentNullException ("requestParams");
			if (keyFormat == null)
				throw new ArgumentNullException ("keyFormat");
			var nskeyFormat = NSString.CreateNative (keyFormat);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selExtractPermissionsToRequestParamsRequestParamsKeyFormat_Handle, record.Handle, requestParams.Handle, nskeyFormat);
			NSString.ReleaseNative (nskeyFormat);
			
		}
		
		[Export ("extractSpecialUpdateOperatorsToRequestParams:requestParams:keyFormat:")]
		[CompilerGenerated]
		public static void ExtractSpecialUpdateOperatorsToRequestParams (NSDictionary specialUpdateOperators, NSMutableDictionary requestParams, string keyFormat)
		{
			if (specialUpdateOperators == null)
				throw new ArgumentNullException ("specialUpdateOperators");
			if (requestParams == null)
				throw new ArgumentNullException ("requestParams");
			if (keyFormat == null)
				throw new ArgumentNullException ("keyFormat");
			var nskeyFormat = NSString.CreateNative (keyFormat);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selExtractSpecialUpdateOperatorsToRequestParamsRequestParamsKeyFormat_Handle, specialUpdateOperators.Handle, requestParams.Handle, nskeyFormat);
			NSString.ReleaseNative (nskeyFormat);
			
		}
		
		[Export ("extractParametersToRequestURL:requestURL:keyFormat:")]
		[CompilerGenerated]
		public static void ExtractParametersToRequestURL (NSDictionary parameters, NSMutableString requestURL, string keyFormat)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (requestURL == null)
				throw new ArgumentNullException ("requestURL");
			if (keyFormat == null)
				throw new ArgumentNullException ("keyFormat");
			var nskeyFormat = NSString.CreateNative (keyFormat);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selExtractParametersToRequestURLRequestURLKeyFormat_Handle, parameters.Handle, requestURL.Handle, nskeyFormat);
			NSString.ReleaseNative (nskeyFormat);
			
		}
		
	} /* class QBCOUtils */
}
