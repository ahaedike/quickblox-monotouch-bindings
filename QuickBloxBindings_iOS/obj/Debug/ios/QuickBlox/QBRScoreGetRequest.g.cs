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
	[Register("QBRScoreGetRequest", true)]
	public unsafe partial class QBRScoreGetRequest : PagedRequest {
		[CompilerGenerated]
		const string selSortAsc = "sortAsc";
		static readonly IntPtr selSortAscHandle = Selector.GetHandle ("sortAsc");
		[CompilerGenerated]
		const string selSetSortAsc_ = "setSortAsc:";
		static readonly IntPtr selSetSortAsc_Handle = Selector.GetHandle ("setSortAsc:");
		[CompilerGenerated]
		const string selSortBy = "sortBy";
		static readonly IntPtr selSortByHandle = Selector.GetHandle ("sortBy");
		[CompilerGenerated]
		const string selSetSortBy_ = "setSortBy:";
		static readonly IntPtr selSetSortBy_Handle = Selector.GetHandle ("setSortBy:");
		[CompilerGenerated]
		const string selGameModeID = "gameModeID";
		static readonly IntPtr selGameModeIDHandle = Selector.GetHandle ("gameModeID");
		[CompilerGenerated]
		const string selSetGameModeID_ = "setGameModeID:";
		static readonly IntPtr selSetGameModeID_Handle = Selector.GetHandle ("setGameModeID:");
		[CompilerGenerated]
		const string selGameModeAdditionalParametersFilters = "gameModeAdditionalParametersFilters";
		static readonly IntPtr selGameModeAdditionalParametersFiltersHandle = Selector.GetHandle ("gameModeAdditionalParametersFilters");
		[CompilerGenerated]
		const string selSetGameModeAdditionalParametersFilters_ = "setGameModeAdditionalParametersFilters:";
		static readonly IntPtr selSetGameModeAdditionalParametersFilters_Handle = Selector.GetHandle ("setGameModeAdditionalParametersFilters:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBRScoreGetRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBRScoreGetRequest () : base (NSObjectFlag.Empty)
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
		public QBRScoreGetRequest (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRScoreGetRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBRScoreGetRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual bool SortAsc {
			[Export ("sortAsc")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSortAscHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSortAscHandle);
				}
			}
			
			[Export ("setSortAsc:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSortAsc_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSortAsc_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual QBRScoreSortByKind SortBy {
			[Export ("sortBy")]
			get {
				if (IsDirectBinding) {
					return (QBRScoreSortByKind) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSortByHandle);
				} else {
					return (QBRScoreSortByKind) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSortByHandle);
				}
			}
			
			[Export ("setSortBy:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetSortBy_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetSortBy_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 GameModeID {
			[Export ("gameModeID")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selGameModeIDHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selGameModeIDHandle);
				}
			}
			
			[Export ("setGameModeID:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetGameModeID_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetGameModeID_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_GameModeAdditionalParametersFilters_var;
		[CompilerGenerated]
		public virtual NSDictionary GameModeAdditionalParametersFilters {
			[Export ("gameModeAdditionalParametersFilters", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGameModeAdditionalParametersFiltersHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGameModeAdditionalParametersFiltersHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_GameModeAdditionalParametersFilters_var = ret;
				return ret;
			}
			
			[Export ("setGameModeAdditionalParametersFilters:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetGameModeAdditionalParametersFilters_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetGameModeAdditionalParametersFilters_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_GameModeAdditionalParametersFilters_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_GameModeAdditionalParametersFilters_var = null;
			}
		}
	} /* class QBRScoreGetRequest */
}
