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
	[Register("QBLocation", true)]
	public unsafe partial class QBLocation : QBBaseModule {
		[CompilerGenerated]
		const string selCreateGeoDataAndSendPushWithTextToAllUsersWithinRadiusDelegate_ = "createGeoData:andSendPushWithText:toAllUsersWithinRadius:delegate:";
		static readonly IntPtr selCreateGeoDataAndSendPushWithTextToAllUsersWithinRadiusDelegate_Handle = Selector.GetHandle ("createGeoData:andSendPushWithText:toAllUsersWithinRadius:delegate:");
		[CompilerGenerated]
		const string selCreateGeoDataAndSendPushWithTextToAllUsersWithinRadiusDelegateContext_ = "createGeoData:andSendPushWithText:toAllUsersWithinRadius:delegate:context:";
		static readonly IntPtr selCreateGeoDataAndSendPushWithTextToAllUsersWithinRadiusDelegateContext_Handle = Selector.GetHandle ("createGeoData:andSendPushWithText:toAllUsersWithinRadius:delegate:context:");
		[CompilerGenerated]
		const string selCreateGeoDataDelegate_ = "createGeoData:delegate:";
		static readonly IntPtr selCreateGeoDataDelegate_Handle = Selector.GetHandle ("createGeoData:delegate:");
		[CompilerGenerated]
		const string selCreateGeoDataDelegateContext_ = "createGeoData:delegate:context:";
		static readonly IntPtr selCreateGeoDataDelegateContext_Handle = Selector.GetHandle ("createGeoData:delegate:context:");
		[CompilerGenerated]
		const string selCreatePlaceDelegate_ = "createPlace:delegate:";
		static readonly IntPtr selCreatePlaceDelegate_Handle = Selector.GetHandle ("createPlace:delegate:");
		[CompilerGenerated]
		const string selCreatePlaceDelegateContext_ = "createPlace:delegate:context:";
		static readonly IntPtr selCreatePlaceDelegateContext_Handle = Selector.GetHandle ("createPlace:delegate:context:");
		[CompilerGenerated]
		const string selDeleteGeoDataWithIDDelegate_ = "deleteGeoDataWithID:delegate:";
		static readonly IntPtr selDeleteGeoDataWithIDDelegate_Handle = Selector.GetHandle ("deleteGeoDataWithID:delegate:");
		[CompilerGenerated]
		const string selDeleteGeoDataWithIDDelegateContext_ = "deleteGeoDataWithID:delegate:context:";
		static readonly IntPtr selDeleteGeoDataWithIDDelegateContext_Handle = Selector.GetHandle ("deleteGeoDataWithID:delegate:context:");
		[CompilerGenerated]
		const string selDeleteGeoDataWithRequestDelegate_ = "deleteGeoDataWithRequest:delegate:";
		static readonly IntPtr selDeleteGeoDataWithRequestDelegate_Handle = Selector.GetHandle ("deleteGeoDataWithRequest:delegate:");
		[CompilerGenerated]
		const string selDeleteGeoDataWithRequestDelegateContext_ = "deleteGeoDataWithRequest:delegate:context:";
		static readonly IntPtr selDeleteGeoDataWithRequestDelegateContext_Handle = Selector.GetHandle ("deleteGeoDataWithRequest:delegate:context:");
		[CompilerGenerated]
		const string selDeletePlaceWithIDDelegate_ = "deletePlaceWithID:delegate:";
		static readonly IntPtr selDeletePlaceWithIDDelegate_Handle = Selector.GetHandle ("deletePlaceWithID:delegate:");
		[CompilerGenerated]
		const string selDeletePlaceWithIDDelegateContext_ = "deletePlaceWithID:delegate:context:";
		static readonly IntPtr selDeletePlaceWithIDDelegateContext_Handle = Selector.GetHandle ("deletePlaceWithID:delegate:context:");
		[CompilerGenerated]
		const string selGeoDataWithIDDelegate_ = "geoDataWithID:delegate:";
		static readonly IntPtr selGeoDataWithIDDelegate_Handle = Selector.GetHandle ("geoDataWithID:delegate:");
		[CompilerGenerated]
		const string selGeoDataWithIDDelegateContext_ = "geoDataWithID:delegate:context:";
		static readonly IntPtr selGeoDataWithIDDelegateContext_Handle = Selector.GetHandle ("geoDataWithID:delegate:context:");
		[CompilerGenerated]
		const string selGeoDataWithRequestDelegate_ = "geoDataWithRequest:delegate:";
		static readonly IntPtr selGeoDataWithRequestDelegate_Handle = Selector.GetHandle ("geoDataWithRequest:delegate:");
		[CompilerGenerated]
		const string selGeoDataWithRequestDelegateContext_ = "geoDataWithRequest:delegate:context:";
		static readonly IntPtr selGeoDataWithRequestDelegateContext_Handle = Selector.GetHandle ("geoDataWithRequest:delegate:context:");
		[CompilerGenerated]
		const string selPlacesWithDelegate_ = "placesWithDelegate:";
		static readonly IntPtr selPlacesWithDelegate_Handle = Selector.GetHandle ("placesWithDelegate:");
		[CompilerGenerated]
		const string selPlacesWithDelegateContext_ = "placesWithDelegate:context:";
		static readonly IntPtr selPlacesWithDelegateContext_Handle = Selector.GetHandle ("placesWithDelegate:context:");
		[CompilerGenerated]
		const string selPlacesWithPagedRequestDelegate_ = "placesWithPagedRequest:delegate:";
		static readonly IntPtr selPlacesWithPagedRequestDelegate_Handle = Selector.GetHandle ("placesWithPagedRequest:delegate:");
		[CompilerGenerated]
		const string selPlacesWithPagedRequestDelegateContext_ = "placesWithPagedRequest:delegate:context:";
		static readonly IntPtr selPlacesWithPagedRequestDelegateContext_Handle = Selector.GetHandle ("placesWithPagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selPlaceWithIDDelegate_ = "placeWithID:delegate:";
		static readonly IntPtr selPlaceWithIDDelegate_Handle = Selector.GetHandle ("placeWithID:delegate:");
		[CompilerGenerated]
		const string selPlaceWithIDDelegateContext_ = "placeWithID:delegate:context:";
		static readonly IntPtr selPlaceWithIDDelegateContext_Handle = Selector.GetHandle ("placeWithID:delegate:context:");
		[CompilerGenerated]
		const string selUpdateGeoDataDelegate_ = "updateGeoData:delegate:";
		static readonly IntPtr selUpdateGeoDataDelegate_Handle = Selector.GetHandle ("updateGeoData:delegate:");
		[CompilerGenerated]
		const string selUpdateGeoDataDelegateContext_ = "updateGeoData:delegate:context:";
		static readonly IntPtr selUpdateGeoDataDelegateContext_Handle = Selector.GetHandle ("updateGeoData:delegate:context:");
		[CompilerGenerated]
		const string selUpdatePlaceDelegate_ = "updatePlace:delegate:";
		static readonly IntPtr selUpdatePlaceDelegate_Handle = Selector.GetHandle ("updatePlace:delegate:");
		[CompilerGenerated]
		const string selUpdatePlaceDelegateContext_ = "updatePlace:delegate:context:";
		static readonly IntPtr selUpdatePlaceDelegateContext_Handle = Selector.GetHandle ("updatePlace:delegate:context:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBLocation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBLocation () : base (NSObjectFlag.Empty)
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
		public QBLocation (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLocation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBLocation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("createGeoData:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateGeoData (QBLGeoData geodata, NSObject _delegate)
		{
			if (geodata == null)
				throw new ArgumentNullException ("geodata");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateGeoDataDelegate_Handle, geodata.Handle, _delegate.Handle));
		}
		
		[Export ("createGeoData:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateGeoData (QBLGeoData geodata, NSObject _delegate, NSObject context)
		{
			if (geodata == null)
				throw new ArgumentNullException ("geodata");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateGeoDataDelegateContext_Handle, geodata.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("createGeoData:andSendPushWithText:toAllUsersWithinRadius:delegate:")]
		[CompilerGenerated]
		public static NSObject CreateGeoData (QBLGeoData geodata, string pushText, float radius, NSObject _delegate)
		{
			if (geodata == null)
				throw new ArgumentNullException ("geodata");
			if (pushText == null)
				throw new ArgumentNullException ("pushText");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nspushText = NSString.CreateNative (pushText);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_float_IntPtr (class_ptr, selCreateGeoDataAndSendPushWithTextToAllUsersWithinRadiusDelegate_Handle, geodata.Handle, nspushText, radius, _delegate.Handle));
			NSString.ReleaseNative (nspushText);
			
			return ret;
		}
		
		[Export ("createGeoData:andSendPushWithText:toAllUsersWithinRadius:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateGeoData (QBLGeoData geodata, string pushText, float radius, NSObject _delegate, NSObject context)
		{
			if (geodata == null)
				throw new ArgumentNullException ("geodata");
			if (pushText == null)
				throw new ArgumentNullException ("pushText");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nspushText = NSString.CreateNative (pushText);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_float_IntPtr_IntPtr (class_ptr, selCreateGeoDataAndSendPushWithTextToAllUsersWithinRadiusDelegateContext_Handle, geodata.Handle, nspushText, radius, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nspushText);
			
			return ret;
		}
		
		[Export ("createPlace:delegate:")]
		[CompilerGenerated]
		public static NSObject CreatePlace (QBLPlace place, NSObject _delegate)
		{
			if (place == null)
				throw new ArgumentNullException ("place");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreatePlaceDelegate_Handle, place.Handle, _delegate.Handle));
		}
		
		[Export ("createPlace:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreatePlace (QBLPlace place, NSObject _delegate, NSObject context)
		{
			if (place == null)
				throw new ArgumentNullException ("place");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreatePlaceDelegateContext_Handle, place.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("deleteGeoDataWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteGeoDataWithID (global::System.UInt32 geodataID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeleteGeoDataWithIDDelegate_Handle, geodataID, _delegate.Handle));
		}
		
		[Export ("deleteGeoDataWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteGeoDataWithID (global::System.UInt32 geodataID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeleteGeoDataWithIDDelegateContext_Handle, geodataID, _delegate.Handle, context.Handle));
		}
		
		[Export ("deleteGeoDataWithRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteGeoDataWithRequest (QBLGeoDataDeleteRequest deleteRequest, NSObject _delegate)
		{
			if (deleteRequest == null)
				throw new ArgumentNullException ("deleteRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selDeleteGeoDataWithRequestDelegate_Handle, deleteRequest.Handle, _delegate.Handle));
		}
		
		[Export ("deleteGeoDataWithRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteGeoDataWithRequest (QBLGeoDataDeleteRequest deleteRequest, NSObject _delegate, NSObject context)
		{
			if (deleteRequest == null)
				throw new ArgumentNullException ("deleteRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selDeleteGeoDataWithRequestDelegateContext_Handle, deleteRequest.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("deletePlaceWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeletePlaceWithID (global::System.UInt32 placeID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeletePlaceWithIDDelegate_Handle, placeID, _delegate.Handle));
		}
		
		[Export ("deletePlaceWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeletePlaceWithID (global::System.UInt32 placeID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeletePlaceWithIDDelegateContext_Handle, placeID, _delegate.Handle, context.Handle));
		}
		
		[Export ("geoDataWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject GeoDataWithID (global::System.UInt32 geodataID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selGeoDataWithIDDelegate_Handle, geodataID, _delegate.Handle));
		}
		
		[Export ("geoDataWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject GeoDataWithID (global::System.UInt32 geodataID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selGeoDataWithIDDelegateContext_Handle, geodataID, _delegate.Handle, context.Handle));
		}
		
		[Export ("geoDataWithRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject GeoDataWithRequest (QBLGeoDataGetRequest geodataRequest, NSObject _delegate)
		{
			if (geodataRequest == null)
				throw new ArgumentNullException ("geodataRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selGeoDataWithRequestDelegate_Handle, geodataRequest.Handle, _delegate.Handle));
		}
		
		[Export ("geoDataWithRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject GeoDataWithRequest (QBLGeoDataGetRequest geodataRequest, NSObject _delegate, NSObject context)
		{
			if (geodataRequest == null)
				throw new ArgumentNullException ("geodataRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selGeoDataWithRequestDelegateContext_Handle, geodataRequest.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("placesWithDelegate:")]
		[CompilerGenerated]
		public static NSObject PlacesWithDelegate (NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selPlacesWithDelegate_Handle, _delegate.Handle));
		}
		
		[Export ("placesWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject PlacesWithDelegate (NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selPlacesWithDelegateContext_Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("placesWithPagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject PlacesWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selPlacesWithPagedRequestDelegate_Handle, pagedRequest.Handle, _delegate.Handle));
		}
		
		[Export ("placesWithPagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject PlacesWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selPlacesWithPagedRequestDelegateContext_Handle, pagedRequest.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("placeWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject PlaceWithID (global::System.UInt32 placeID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selPlaceWithIDDelegate_Handle, placeID, _delegate.Handle));
		}
		
		[Export ("placeWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject PlaceWithID (global::System.UInt32 placeID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selPlaceWithIDDelegateContext_Handle, placeID, _delegate.Handle, context.Handle));
		}
		
		[Export ("updateGeoData:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateGeoData (QBLGeoData geodata, NSObject _delegate)
		{
			if (geodata == null)
				throw new ArgumentNullException ("geodata");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdateGeoDataDelegate_Handle, geodata.Handle, _delegate.Handle));
		}
		
		[Export ("updateGeoData:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateGeoData (QBLGeoData geodata, NSObject _delegate, NSObject context)
		{
			if (geodata == null)
				throw new ArgumentNullException ("geodata");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateGeoDataDelegateContext_Handle, geodata.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("updatePlace:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdatePlace (QBLPlace place, NSObject _delegate)
		{
			if (place == null)
				throw new ArgumentNullException ("place");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdatePlaceDelegate_Handle, place.Handle, _delegate.Handle));
		}
		
		[Export ("updatePlace:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdatePlace (QBLPlace place, NSObject _delegate, NSObject context)
		{
			if (place == null)
				throw new ArgumentNullException ("place");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdatePlaceDelegateContext_Handle, place.Handle, _delegate.Handle, context.Handle));
		}
		
	} /* class QBLocation */
}
