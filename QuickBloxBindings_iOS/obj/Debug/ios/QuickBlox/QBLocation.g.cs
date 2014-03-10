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
	[Register("QBLocation", true)]
	public unsafe partial class QBLocation : QBBaseModule {
		[CompilerGenerated]
		const string selCreateGeoDataDelegate_ = "createGeoData:delegate:";
		static readonly IntPtr selCreateGeoDataDelegate_Handle = Selector.GetHandle ("createGeoData:delegate:");
		[CompilerGenerated]
		const string selCreateGeoDataDelegateContext_ = "createGeoData:delegate:context:";
		static readonly IntPtr selCreateGeoDataDelegateContext_Handle = Selector.GetHandle ("createGeoData:delegate:context:");
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
		const string selUpdateGeoDataDelegate_ = "updateGeoData:delegate:";
		static readonly IntPtr selUpdateGeoDataDelegate_Handle = Selector.GetHandle ("updateGeoData:delegate:");
		[CompilerGenerated]
		const string selUpdateGeoDataDelegateContext_ = "updateGeoData:delegate:context:";
		static readonly IntPtr selUpdateGeoDataDelegateContext_Handle = Selector.GetHandle ("updateGeoData:delegate:context:");
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
		const string selCreatePlaceDelegate_ = "createPlace:delegate:";
		static readonly IntPtr selCreatePlaceDelegate_Handle = Selector.GetHandle ("createPlace:delegate:");
		[CompilerGenerated]
		const string selCreatePlaceDelegateContext_ = "createPlace:delegate:context:";
		static readonly IntPtr selCreatePlaceDelegateContext_Handle = Selector.GetHandle ("createPlace:delegate:context:");
		[CompilerGenerated]
		const string selUpdatePlaceDelegate_ = "updatePlace:delegate:";
		static readonly IntPtr selUpdatePlaceDelegate_Handle = Selector.GetHandle ("updatePlace:delegate:");
		[CompilerGenerated]
		const string selUpdatePlaceDelegateContext_ = "updatePlace:delegate:context:";
		static readonly IntPtr selUpdatePlaceDelegateContext_Handle = Selector.GetHandle ("updatePlace:delegate:context:");
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
		const string selDeletePlaceWithIDDelegate_ = "deletePlaceWithID:delegate:";
		static readonly IntPtr selDeletePlaceWithIDDelegate_Handle = Selector.GetHandle ("deletePlaceWithID:delegate:");
		[CompilerGenerated]
		const string selDeletePlaceWithIDDelegateContext_ = "deletePlaceWithID:delegate:context:";
		static readonly IntPtr selDeletePlaceWithIDDelegateContext_Handle = Selector.GetHandle ("deletePlaceWithID:delegate:context:");
		
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
		public static NSObject CreateGeoData (QBLGeoData geodata, NSObject del)
		{
			if (geodata == null)
				throw new ArgumentNullException ("geodata");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreateGeoDataDelegate_Handle, geodata.Handle, del.Handle));
		}
		
		[Export ("createGeoData:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreateGeoData (QBLGeoData geodata, NSObject del, NSObject context)
		{
			if (geodata == null)
				throw new ArgumentNullException ("geodata");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreateGeoDataDelegateContext_Handle, geodata.Handle, del.Handle, context.Handle));
		}
		
		[Export ("geoDataWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject GeoDataWithID (global::System.UInt32 geodataID, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selGeoDataWithIDDelegate_Handle, geodataID, del.Handle));
		}
		
		[Export ("geoDataWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject GeoDataWithID (global::System.UInt32 geodataID, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selGeoDataWithIDDelegateContext_Handle, geodataID, del.Handle, context.Handle));
		}
		
		[Export ("geoDataWithRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject GeoDataWithRequest (QBLGeoDataGetRequest geodataRequest, NSObject del)
		{
			if (geodataRequest == null)
				throw new ArgumentNullException ("geodataRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selGeoDataWithRequestDelegate_Handle, geodataRequest.Handle, del.Handle));
		}
		
		[Export ("geoDataWithRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject GeoDataWithRequest (QBLGeoDataGetRequest geodataRequest, NSObject del, NSObject context)
		{
			if (geodataRequest == null)
				throw new ArgumentNullException ("geodataRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selGeoDataWithRequestDelegateContext_Handle, geodataRequest.Handle, del.Handle, context.Handle));
		}
		
		[Export ("updateGeoData:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateGeoData (QBLGeoData geodata, NSObject del)
		{
			if (geodata == null)
				throw new ArgumentNullException ("geodata");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdateGeoDataDelegate_Handle, geodata.Handle, del.Handle));
		}
		
		[Export ("updateGeoData:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateGeoData (QBLGeoData geodata, NSObject del, NSObject context)
		{
			if (geodata == null)
				throw new ArgumentNullException ("geodata");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateGeoDataDelegateContext_Handle, geodata.Handle, del.Handle, context.Handle));
		}
		
		[Export ("deleteGeoDataWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteGeoDataWithID (global::System.UInt32 geodataID, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeleteGeoDataWithIDDelegate_Handle, geodataID, del.Handle));
		}
		
		[Export ("deleteGeoDataWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteGeoDataWithID (global::System.UInt32 geodataID, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeleteGeoDataWithIDDelegateContext_Handle, geodataID, del.Handle, context.Handle));
		}
		
		[Export ("deleteGeoDataWithRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteGeoDataWithRequest (QBLGeoDataDeleteRequest deleteRequest, NSObject del)
		{
			if (deleteRequest == null)
				throw new ArgumentNullException ("deleteRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selDeleteGeoDataWithRequestDelegate_Handle, deleteRequest.Handle, del.Handle));
		}
		
		[Export ("deleteGeoDataWithRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteGeoDataWithRequest (QBLGeoDataDeleteRequest deleteRequest, NSObject del, NSObject context)
		{
			if (deleteRequest == null)
				throw new ArgumentNullException ("deleteRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selDeleteGeoDataWithRequestDelegateContext_Handle, deleteRequest.Handle, del.Handle, context.Handle));
		}
		
		[Export ("createPlace:delegate:")]
		[CompilerGenerated]
		public static NSObject CreatePlace (QBLPlace place, NSObject del)
		{
			if (place == null)
				throw new ArgumentNullException ("place");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selCreatePlaceDelegate_Handle, place.Handle, del.Handle));
		}
		
		[Export ("createPlace:delegate:context:")]
		[CompilerGenerated]
		public static NSObject CreatePlace (QBLPlace place, NSObject del, NSObject context)
		{
			if (place == null)
				throw new ArgumentNullException ("place");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selCreatePlaceDelegateContext_Handle, place.Handle, del.Handle, context.Handle));
		}
		
		[Export ("updatePlace:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdatePlace (QBLPlace place, NSObject del)
		{
			if (place == null)
				throw new ArgumentNullException ("place");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdatePlaceDelegate_Handle, place.Handle, del.Handle));
		}
		
		[Export ("updatePlace:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdatePlace (QBLPlace place, NSObject del, NSObject context)
		{
			if (place == null)
				throw new ArgumentNullException ("place");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdatePlaceDelegateContext_Handle, place.Handle, del.Handle, context.Handle));
		}
		
		[Export ("placesWithDelegate:")]
		[CompilerGenerated]
		public static NSObject PlacesWithDelegate (NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selPlacesWithDelegate_Handle, del.Handle));
		}
		
		[Export ("placesWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject PlacesWithDelegate (NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selPlacesWithDelegateContext_Handle, del.Handle, context.Handle));
		}
		
		[Export ("placesWithPagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject PlacesWithPagedRequest (PagedRequest pagedRequest, NSObject del)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selPlacesWithPagedRequestDelegate_Handle, pagedRequest.Handle, del.Handle));
		}
		
		[Export ("placesWithPagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject PlacesWithPagedRequest (PagedRequest pagedRequest, NSObject del, NSObject context)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selPlacesWithPagedRequestDelegateContext_Handle, pagedRequest.Handle, del.Handle, context.Handle));
		}
		
		[Export ("placeWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject PlaceWithID (global::System.UInt32 placeID, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selPlaceWithIDDelegate_Handle, placeID, del.Handle));
		}
		
		[Export ("placeWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject PlaceWithID (global::System.UInt32 placeID, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selPlaceWithIDDelegateContext_Handle, placeID, del.Handle, context.Handle));
		}
		
		[Export ("deletePlaceWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeletePlaceWithID (global::System.UInt32 placeID, NSObject del)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeletePlaceWithIDDelegate_Handle, placeID, del.Handle));
		}
		
		[Export ("deletePlaceWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeletePlaceWithID (global::System.UInt32 placeID, NSObject del, NSObject context)
		{
			if (del == null)
				throw new ArgumentNullException ("del");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeletePlaceWithIDDelegateContext_Handle, placeID, del.Handle, context.Handle));
		}
		
		[CompilerGenerated]
		static NSString _MessagesServiceException;
		[Field ("kMessagesServiceException",  "QuickBlox")]
		public static NSString MessagesServiceException {
			get {
				if (_MessagesServiceException == null)
					_MessagesServiceException = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kMessagesServiceException");
				return _MessagesServiceException;
			}
		}
		[CompilerGenerated]
		static NSString _MessagesServiceErrorDomain;
		[Field ("kMessagesServiceErrorDomain",  "QuickBlox")]
		public static NSString MessagesServiceErrorDomain {
			get {
				if (_MessagesServiceErrorDomain == null)
					_MessagesServiceErrorDomain = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kMessagesServiceErrorDomain");
				return _MessagesServiceErrorDomain;
			}
		}
		[CompilerGenerated]
		static NSString _MessagesServiceErrorGetTokenTimeout;
		[Field ("kMessagesServiceErrorGetTokenTimeout",  "QuickBlox")]
		public static NSString MessagesServiceErrorGetTokenTimeout {
			get {
				if (_MessagesServiceErrorGetTokenTimeout == null)
					_MessagesServiceErrorGetTokenTimeout = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kMessagesServiceErrorGetTokenTimeout");
				return _MessagesServiceErrorGetTokenTimeout;
			}
		}
		[CompilerGenerated]
		static NSString _QBMEventMessagePayloadKey;
		[Field ("QBMEventMessagePayloadKey",  "QuickBlox")]
		public static NSString QBMEventMessagePayloadKey {
			get {
				if (_QBMEventMessagePayloadKey == null)
					_QBMEventMessagePayloadKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMEventMessagePayloadKey");
				return _QBMEventMessagePayloadKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMEventMessagePushAlertKey;
		[Field ("QBMEventMessagePushAlertKey",  "QuickBlox")]
		public static NSString QBMEventMessagePushAlertKey {
			get {
				if (_QBMEventMessagePushAlertKey == null)
					_QBMEventMessagePushAlertKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMEventMessagePushAlertKey");
				return _QBMEventMessagePushAlertKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMEventMessagePushBadgeKey;
		[Field ("QBMEventMessagePushBadgeKey",  "QuickBlox")]
		public static NSString QBMEventMessagePushBadgeKey {
			get {
				if (_QBMEventMessagePushBadgeKey == null)
					_QBMEventMessagePushBadgeKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMEventMessagePushBadgeKey");
				return _QBMEventMessagePushBadgeKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMEventMessagePushSoundKey;
		[Field ("QBMEventMessagePushSoundKey",  "QuickBlox")]
		public static NSString QBMEventMessagePushSoundKey {
			get {
				if (_QBMEventMessagePushSoundKey == null)
					_QBMEventMessagePushSoundKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMEventMessagePushSoundKey");
				return _QBMEventMessagePushSoundKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushMessageAdditionalInfoKey;
		[Field ("QBMPushMessageAdditionalInfoKey",  "QuickBlox")]
		public static NSString QBMPushMessageAdditionalInfoKey {
			get {
				if (_QBMPushMessageAdditionalInfoKey == null)
					_QBMPushMessageAdditionalInfoKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMPushMessageAdditionalInfoKey");
				return _QBMPushMessageAdditionalInfoKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushMessageApsKey;
		[Field ("QBMPushMessageApsKey",  "QuickBlox")]
		public static NSString QBMPushMessageApsKey {
			get {
				if (_QBMPushMessageApsKey == null)
					_QBMPushMessageApsKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMPushMessageApsKey");
				return _QBMPushMessageApsKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushMessageAlertKey;
		[Field ("QBMPushMessageAlertKey",  "QuickBlox")]
		public static NSString QBMPushMessageAlertKey {
			get {
				if (_QBMPushMessageAlertKey == null)
					_QBMPushMessageAlertKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMPushMessageAlertKey");
				return _QBMPushMessageAlertKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushMessageAlertBodyKey;
		[Field ("QBMPushMessageAlertBodyKey",  "QuickBlox")]
		public static NSString QBMPushMessageAlertBodyKey {
			get {
				if (_QBMPushMessageAlertBodyKey == null)
					_QBMPushMessageAlertBodyKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMPushMessageAlertBodyKey");
				return _QBMPushMessageAlertBodyKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushMessageAlertActionLocKey;
		[Field ("QBMPushMessageAlertActionLocKey",  "QuickBlox")]
		public static NSString QBMPushMessageAlertActionLocKey {
			get {
				if (_QBMPushMessageAlertActionLocKey == null)
					_QBMPushMessageAlertActionLocKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMPushMessageAlertActionLocKey");
				return _QBMPushMessageAlertActionLocKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushMessageAlertLocKey;
		[Field ("QBMPushMessageAlertLocKey",  "QuickBlox")]
		public static NSString QBMPushMessageAlertLocKey {
			get {
				if (_QBMPushMessageAlertLocKey == null)
					_QBMPushMessageAlertLocKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMPushMessageAlertLocKey");
				return _QBMPushMessageAlertLocKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushMessageAlertLocArgsKey;
		[Field ("QBMPushMessageAlertLocArgsKey",  "QuickBlox")]
		public static NSString QBMPushMessageAlertLocArgsKey {
			get {
				if (_QBMPushMessageAlertLocArgsKey == null)
					_QBMPushMessageAlertLocArgsKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMPushMessageAlertLocArgsKey");
				return _QBMPushMessageAlertLocArgsKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushMessageAlertLaunchImageKey;
		[Field ("QBMPushMessageAlertLaunchImageKey",  "QuickBlox")]
		public static NSString QBMPushMessageAlertLaunchImageKey {
			get {
				if (_QBMPushMessageAlertLaunchImageKey == null)
					_QBMPushMessageAlertLaunchImageKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMPushMessageAlertLaunchImageKey");
				return _QBMPushMessageAlertLaunchImageKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushMessageBadgeKey;
		[Field ("QBMPushMessageBadgeKey",  "QuickBlox")]
		public static NSString QBMPushMessageBadgeKey {
			get {
				if (_QBMPushMessageBadgeKey == null)
					_QBMPushMessageBadgeKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMPushMessageBadgeKey");
				return _QBMPushMessageBadgeKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushMessageSoundKey;
		[Field ("QBMPushMessageSoundKey",  "QuickBlox")]
		public static NSString QBMPushMessageSoundKey {
			get {
				if (_QBMPushMessageSoundKey == null)
					_QBMPushMessageSoundKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMPushMessageSoundKey");
				return _QBMPushMessageSoundKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushMessageRichContentKey;
		[Field ("QBMPushMessageRichContentKey",  "QuickBlox")]
		public static NSString QBMPushMessageRichContentKey {
			get {
				if (_QBMPushMessageRichContentKey == null)
					_QBMPushMessageRichContentKey = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "QBMPushMessageRichContentKey");
				return _QBMPushMessageRichContentKey;
			}
		}
		[CompilerGenerated]
		static NSString _QBMEventTypeOneShot;
		[Field ("kQBMEventTypeOneShot",  "QuickBlox")]
		public static NSString QBMEventTypeOneShot {
			get {
				if (_QBMEventTypeOneShot == null)
					_QBMEventTypeOneShot = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMEventTypeOneShot");
				return _QBMEventTypeOneShot;
			}
		}
		[CompilerGenerated]
		static NSString _QBMEventTypeFixedDate;
		[Field ("kQBMEventTypeFixedDate",  "QuickBlox")]
		public static NSString QBMEventTypeFixedDate {
			get {
				if (_QBMEventTypeFixedDate == null)
					_QBMEventTypeFixedDate = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMEventTypeFixedDate");
				return _QBMEventTypeFixedDate;
			}
		}
		[CompilerGenerated]
		static NSString _QBMEventTypePeriodDate;
		[Field ("kQBMEventTypePeriodDate",  "QuickBlox")]
		public static NSString QBMEventTypePeriodDate {
			get {
				if (_QBMEventTypePeriodDate == null)
					_QBMEventTypePeriodDate = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMEventTypePeriodDate");
				return _QBMEventTypePeriodDate;
			}
		}
		[CompilerGenerated]
		static NSString _QBMEventTypeMultiShot;
		[Field ("kQBMEventTypeMultiShot",  "QuickBlox")]
		public static NSString QBMEventTypeMultiShot {
			get {
				if (_QBMEventTypeMultiShot == null)
					_QBMEventTypeMultiShot = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMEventTypeMultiShot");
				return _QBMEventTypeMultiShot;
			}
		}
		[CompilerGenerated]
		static NSString _QBMNotificationChannelsEmail;
		[Field ("kQBMNotificationChannelsEmail",  "QuickBlox")]
		public static NSString QBMNotificationChannelsEmail {
			get {
				if (_QBMNotificationChannelsEmail == null)
					_QBMNotificationChannelsEmail = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMNotificationChannelsEmail");
				return _QBMNotificationChannelsEmail;
			}
		}
		[CompilerGenerated]
		static NSString _QBMNotificationChannelsAPNS;
		[Field ("kQBMNotificationChannelsAPNS",  "QuickBlox")]
		public static NSString QBMNotificationChannelsAPNS {
			get {
				if (_QBMNotificationChannelsAPNS == null)
					_QBMNotificationChannelsAPNS = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMNotificationChannelsAPNS");
				return _QBMNotificationChannelsAPNS;
			}
		}
		[CompilerGenerated]
		static NSString _QBMNotificationChannelsGCM;
		[Field ("kQBMNotificationChannelsGCM",  "QuickBlox")]
		public static NSString QBMNotificationChannelsGCM {
			get {
				if (_QBMNotificationChannelsGCM == null)
					_QBMNotificationChannelsGCM = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMNotificationChannelsGCM");
				return _QBMNotificationChannelsGCM;
			}
		}
		[CompilerGenerated]
		static NSString _QBMNotificationChannelsMPNS;
		[Field ("kQBMNotificationChannelsMPNS",  "QuickBlox")]
		public static NSString QBMNotificationChannelsMPNS {
			get {
				if (_QBMNotificationChannelsMPNS == null)
					_QBMNotificationChannelsMPNS = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMNotificationChannelsMPNS");
				return _QBMNotificationChannelsMPNS;
			}
		}
		[CompilerGenerated]
		static NSString _QBMNotificationChannelsBBPS;
		[Field ("kQBMNotificationChannelsBBPS",  "QuickBlox")]
		public static NSString QBMNotificationChannelsBBPS {
			get {
				if (_QBMNotificationChannelsBBPS == null)
					_QBMNotificationChannelsBBPS = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMNotificationChannelsBBPS");
				return _QBMNotificationChannelsBBPS;
			}
		}
		[CompilerGenerated]
		static NSString _QBMNotificationChannelsPull;
		[Field ("kQBMNotificationChannelsPull",  "QuickBlox")]
		public static NSString QBMNotificationChannelsPull {
			get {
				if (_QBMNotificationChannelsPull == null)
					_QBMNotificationChannelsPull = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMNotificationChannelsPull");
				return _QBMNotificationChannelsPull;
			}
		}
		[CompilerGenerated]
		static NSString _QBMNotificationChannelsHttpRequest;
		[Field ("kQBMNotificationChannelsHttpRequest",  "QuickBlox")]
		public static NSString QBMNotificationChannelsHttpRequest {
			get {
				if (_QBMNotificationChannelsHttpRequest == null)
					_QBMNotificationChannelsHttpRequest = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMNotificationChannelsHttpRequest");
				return _QBMNotificationChannelsHttpRequest;
			}
		}
		[CompilerGenerated]
		static NSString _QBMNotificationTypePush;
		[Field ("kQBMNotificationTypePush",  "QuickBlox")]
		public static NSString QBMNotificationTypePush {
			get {
				if (_QBMNotificationTypePush == null)
					_QBMNotificationTypePush = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMNotificationTypePush");
				return _QBMNotificationTypePush;
			}
		}
		[CompilerGenerated]
		static NSString _QBMNotificationTypeEmail;
		[Field ("kQBMNotificationTypeEmail",  "QuickBlox")]
		public static NSString QBMNotificationTypeEmail {
			get {
				if (_QBMNotificationTypeEmail == null)
					_QBMNotificationTypeEmail = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMNotificationTypeEmail");
				return _QBMNotificationTypeEmail;
			}
		}
		[CompilerGenerated]
		static NSString _QBMNotificationTypeRequest;
		[Field ("kQBMNotificationTypeRequest",  "QuickBlox")]
		public static NSString QBMNotificationTypeRequest {
			get {
				if (_QBMNotificationTypeRequest == null)
					_QBMNotificationTypeRequest = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMNotificationTypeRequest");
				return _QBMNotificationTypeRequest;
			}
		}
		[CompilerGenerated]
		static NSString _QBMNotificationTypePull;
		[Field ("kQBMNotificationTypePull",  "QuickBlox")]
		public static NSString QBMNotificationTypePull {
			get {
				if (_QBMNotificationTypePull == null)
					_QBMNotificationTypePull = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMNotificationTypePull");
				return _QBMNotificationTypePull;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushTypeAPNS;
		[Field ("kQBMPushTypeAPNS",  "QuickBlox")]
		public static NSString QBMPushTypeAPNS {
			get {
				if (_QBMPushTypeAPNS == null)
					_QBMPushTypeAPNS = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMPushTypeAPNS");
				return _QBMPushTypeAPNS;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushTypeGCM;
		[Field ("kQBMPushTypeGCM",  "QuickBlox")]
		public static NSString QBMPushTypeGCM {
			get {
				if (_QBMPushTypeGCM == null)
					_QBMPushTypeGCM = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMPushTypeGCM");
				return _QBMPushTypeGCM;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushTypeMPNS;
		[Field ("kQBMPushTypeMPNS",  "QuickBlox")]
		public static NSString QBMPushTypeMPNS {
			get {
				if (_QBMPushTypeMPNS == null)
					_QBMPushTypeMPNS = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMPushTypeMPNS");
				return _QBMPushTypeMPNS;
			}
		}
		[CompilerGenerated]
		static NSString _QBMPushTypeBBPS;
		[Field ("kQBMPushTypeBBPS",  "QuickBlox")]
		public static NSString QBMPushTypeBBPS {
			get {
				if (_QBMPushTypeBBPS == null)
					_QBMPushTypeBBPS = Dlfcn.GetStringConstant (Libraries.QuickBlox.Handle, "kQBMPushTypeBBPS");
				return _QBMPushTypeBBPS;
			}
		}
	} /* class QBLocation */
}
