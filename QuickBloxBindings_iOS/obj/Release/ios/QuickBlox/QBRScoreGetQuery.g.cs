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
	[Register("QBRScoreGetQuery", true)]
	public unsafe partial class QBRScoreGetQuery : QBRScoreQuery {
		[CompilerGenerated]
		const string selAdditionalRequest = "additionalRequest";
		static readonly IntPtr selAdditionalRequestHandle = Selector.GetHandle ("additionalRequest");
		[CompilerGenerated]
		const string selGameModeId = "gameModeId";
		static readonly IntPtr selGameModeIdHandle = Selector.GetHandle ("gameModeId");
		[CompilerGenerated]
		const string selInitWithScoreId_ = "initWithScoreId:";
		static readonly IntPtr selInitWithScoreId_Handle = Selector.GetHandle ("initWithScoreId:");
		[CompilerGenerated]
		const string selInitWithTopNGameModeIdExtendedRequest_ = "initWithTopN:gameModeId:extendedRequest:";
		static readonly IntPtr selInitWithTopNGameModeIdExtendedRequest_Handle = Selector.GetHandle ("initWithTopN:gameModeId:extendedRequest:");
		[CompilerGenerated]
		const string selInitWithUserIdExtendedRequest_ = "initWithUserId:extendedRequest:";
		static readonly IntPtr selInitWithUserIdExtendedRequest_Handle = Selector.GetHandle ("initWithUserId:extendedRequest:");
		[CompilerGenerated]
		const string selScoreId = "scoreId";
		static readonly IntPtr selScoreIdHandle = Selector.GetHandle ("scoreId");
		[CompilerGenerated]
		const string selTopN = "topN";
		static readonly IntPtr selTopNHandle = Selector.GetHandle ("topN");
		[CompilerGenerated]
		const string selUserId = "userId";
		static readonly IntPtr selUserIdHandle = Selector.GetHandle ("userId");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBRScoreGetQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBRScoreGetQuery () : base (NSObjectFlag.Empty)
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
		public QBRScoreGetQuery (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRScoreGetQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRScoreGetQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithScoreId:")]
		[CompilerGenerated]
		public QBRScoreGetQuery (global::System.UInt32 _scoreId)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selInitWithScoreId_Handle, _scoreId), "initWithScoreId:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selInitWithScoreId_Handle, _scoreId), "initWithScoreId:");
			}
		}
		
		[Export ("initWithUserId:extendedRequest:")]
		[CompilerGenerated]
		public QBRScoreGetQuery (global::System.UInt32 _userId, QBRScoreGetRequest extendedRequest)
			: base (NSObjectFlag.Empty)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, selInitWithUserIdExtendedRequest_Handle, _userId, extendedRequest.Handle), "initWithUserId:extendedRequest:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, selInitWithUserIdExtendedRequest_Handle, _userId, extendedRequest.Handle), "initWithUserId:extendedRequest:");
			}
		}
		
		[Export ("initWithTopN:gameModeId:extendedRequest:")]
		[CompilerGenerated]
		public QBRScoreGetQuery (int _topN, int _gameModeId, QBRScoreGetRequest extendedRequest)
			: base (NSObjectFlag.Empty)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int_int_IntPtr (this.Handle, selInitWithTopNGameModeIdExtendedRequest_Handle, _topN, _gameModeId, extendedRequest.Handle), "initWithTopN:gameModeId:extendedRequest:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int_int_IntPtr (this.SuperHandle, selInitWithTopNGameModeIdExtendedRequest_Handle, _topN, _gameModeId, extendedRequest.Handle), "initWithTopN:gameModeId:extendedRequest:");
			}
		}
		
		[CompilerGenerated]
		object __mt_AdditionalRequest_var;
		[CompilerGenerated]
		public virtual QBRScoreGetRequest AdditionalRequest {
			[Export ("additionalRequest")]
			get {
				QBRScoreGetRequest ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QBRScoreGetRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAdditionalRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<QBRScoreGetRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAdditionalRequestHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalRequest_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 GameModeId {
			[Export ("gameModeId")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selGameModeIdHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selGameModeIdHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 ScoreId {
			[Export ("scoreId")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selScoreIdHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selScoreIdHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int TopN {
			[Export ("topN")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTopNHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selTopNHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 UserId {
			[Export ("userId")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selUserIdHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selUserIdHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AdditionalRequest_var = null;
			}
		}
	} /* class QBRScoreGetQuery */
}
