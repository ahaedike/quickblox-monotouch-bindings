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

namespace MonoTouch.ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DErrorCallback (IntPtr block, IntPtr response);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDErrorCallback {
			static internal readonly DErrorCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DErrorCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr response) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::QuickBlox.ErrorCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ( Runtime.GetNSObject<MonoTouch.Foundation.NSError> (response));
			}
		} /* class SDErrorCallback */
		
		internal class NIDErrorCallback {
			IntPtr blockPtr;
			DErrorCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDErrorCallback (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DErrorCallback) Runtime.GetDelegateForBlock (block->invoke, typeof (DErrorCallback));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::QuickBlox.ErrorCallback Create (IntPtr block)
			{
				return new NIDErrorCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSError response)
			{
				if (response == null)
					throw new ArgumentNullException ("response");
				invoker (blockPtr, response.Handle);
			}
		} /* class NIDErrorCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DResponseEventsCallback (IntPtr block, IntPtr response, IntPtr evnts);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDResponseEventsCallback {
			static internal readonly DResponseEventsCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DResponseEventsCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr response, IntPtr evnts) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::QuickBlox.ResponseEventsCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ( Runtime.GetNSObject<QuickBlox.QBResponse> (response), NSArray.ArrayFromHandle<NSObject> (evnts));
			}
		} /* class SDResponseEventsCallback */
		
		internal class NIDResponseEventsCallback {
			IntPtr blockPtr;
			DResponseEventsCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDResponseEventsCallback (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DResponseEventsCallback) Runtime.GetDelegateForBlock (block->invoke, typeof (DResponseEventsCallback));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::QuickBlox.ResponseEventsCallback Create (IntPtr block)
			{
				return new NIDResponseEventsCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::QuickBlox.QBResponse response, NSObject[] evnts)
			{
				if (response == null)
					throw new ArgumentNullException ("response");
				if (evnts == null)
					throw new ArgumentNullException ("evnts");
				var nsa_evnts = NSArray.FromNSObjects (evnts);
				
				invoker (blockPtr, response.Handle, nsa_evnts.Handle);
				nsa_evnts.Dispose ();
				
			}
		} /* class NIDResponseEventsCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DQBErrorBlock (IntPtr block, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDQBErrorBlock {
			static internal readonly DQBErrorBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DQBErrorBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::QuickBlox.QBErrorBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ( Runtime.GetNSObject<QuickBlox.QBError> (error));
			}
		} /* class SDQBErrorBlock */
		
		internal class NIDQBErrorBlock {
			IntPtr blockPtr;
			DQBErrorBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDQBErrorBlock (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DQBErrorBlock) Runtime.GetDelegateForBlock (block->invoke, typeof (DQBErrorBlock));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::QuickBlox.QBErrorBlock Create (IntPtr block)
			{
				return new NIDQBErrorBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::QuickBlox.QBError error)
			{
				if (error == null)
					throw new ArgumentNullException ("error");
				invoker (blockPtr, error.Handle);
			}
		} /* class NIDQBErrorBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DResponseTokenCallback (IntPtr block, IntPtr response, IntPtr token);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDResponseTokenCallback {
			static internal readonly DResponseTokenCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DResponseTokenCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr response, IntPtr token) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::QuickBlox.ResponseTokenCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ( Runtime.GetNSObject<QuickBlox.QBResponse> (response),  Runtime.GetNSObject<QuickBlox.QBMPushToken> (token));
			}
		} /* class SDResponseTokenCallback */
		
		internal class NIDResponseTokenCallback {
			IntPtr blockPtr;
			DResponseTokenCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDResponseTokenCallback (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DResponseTokenCallback) Runtime.GetDelegateForBlock (block->invoke, typeof (DResponseTokenCallback));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::QuickBlox.ResponseTokenCallback Create (IntPtr block)
			{
				return new NIDResponseTokenCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::QuickBlox.QBResponse response, global::QuickBlox.QBMPushToken token)
			{
				if (response == null)
					throw new ArgumentNullException ("response");
				if (token == null)
					throw new ArgumentNullException ("token");
				invoker (blockPtr, response.Handle, token.Handle);
			}
		} /* class NIDResponseTokenCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DSessionCallback (IntPtr block, IntPtr response, IntPtr session);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSessionCallback {
			static internal readonly DSessionCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSessionCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr response, IntPtr session) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::QuickBlox.SessionCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ( Runtime.GetNSObject<QuickBlox.QBResponse> (response),  Runtime.GetNSObject<QuickBlox.QBASession> (session));
			}
		} /* class SDSessionCallback */
		
		internal class NIDSessionCallback {
			IntPtr blockPtr;
			DSessionCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDSessionCallback (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DSessionCallback) Runtime.GetDelegateForBlock (block->invoke, typeof (DSessionCallback));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::QuickBlox.SessionCallback Create (IntPtr block)
			{
				return new NIDSessionCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::QuickBlox.QBResponse response, global::QuickBlox.QBASession session)
			{
				if (response == null)
					throw new ArgumentNullException ("response");
				if (session == null)
					throw new ArgumentNullException ("session");
				invoker (blockPtr, response.Handle, session.Handle);
			}
		} /* class NIDSessionCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DResponseCallback (IntPtr block, IntPtr response);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDResponseCallback {
			static internal readonly DResponseCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DResponseCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr response) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::QuickBlox.ResponseCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ( Runtime.GetNSObject<QuickBlox.QBResponse> (response));
			}
		} /* class SDResponseCallback */
		
		internal class NIDResponseCallback {
			IntPtr blockPtr;
			DResponseCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDResponseCallback (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DResponseCallback) Runtime.GetDelegateForBlock (block->invoke, typeof (DResponseCallback));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::QuickBlox.ResponseCallback Create (IntPtr block)
			{
				return new NIDResponseCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::QuickBlox.QBResponse response)
			{
				if (response == null)
					throw new ArgumentNullException ("response");
				invoker (blockPtr, response.Handle);
			}
		} /* class NIDResponseCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DResponseSubscribeCallback (IntPtr block, IntPtr response, IntPtr subscribers);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDResponseSubscribeCallback {
			static internal readonly DResponseSubscribeCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DResponseSubscribeCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr response, IntPtr subscribers) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::QuickBlox.ResponseSubscribeCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ( Runtime.GetNSObject<QuickBlox.QBResponse> (response), NSArray.ArrayFromHandle<NSObject> (subscribers));
			}
		} /* class SDResponseSubscribeCallback */
		
		internal class NIDResponseSubscribeCallback {
			IntPtr blockPtr;
			DResponseSubscribeCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDResponseSubscribeCallback (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DResponseSubscribeCallback) Runtime.GetDelegateForBlock (block->invoke, typeof (DResponseSubscribeCallback));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::QuickBlox.ResponseSubscribeCallback Create (IntPtr block)
			{
				return new NIDResponseSubscribeCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::QuickBlox.QBResponse response, NSObject[] subscribers)
			{
				if (response == null)
					throw new ArgumentNullException ("response");
				if (subscribers == null)
					throw new ArgumentNullException ("subscribers");
				var nsa_subscribers = NSArray.FromNSObjects (subscribers);
				
				invoker (blockPtr, response.Handle, nsa_subscribers.Handle);
				nsa_subscribers.Dispose ();
				
			}
		} /* class NIDResponseSubscribeCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DResponsePageEventsCallback (IntPtr block, IntPtr response, IntPtr page, IntPtr evnts);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDResponsePageEventsCallback {
			static internal readonly DResponsePageEventsCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DResponsePageEventsCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr response, IntPtr page, IntPtr evnts) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::QuickBlox.ResponsePageEventsCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ( Runtime.GetNSObject<QuickBlox.QBResponse> (response),  Runtime.GetNSObject<QuickBlox.QBGeneralResponsePage> (page), NSArray.ArrayFromHandle<NSObject> (evnts));
			}
		} /* class SDResponsePageEventsCallback */
		
		internal class NIDResponsePageEventsCallback {
			IntPtr blockPtr;
			DResponsePageEventsCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDResponsePageEventsCallback (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DResponsePageEventsCallback) Runtime.GetDelegateForBlock (block->invoke, typeof (DResponsePageEventsCallback));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::QuickBlox.ResponsePageEventsCallback Create (IntPtr block)
			{
				return new NIDResponsePageEventsCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::QuickBlox.QBResponse response, global::QuickBlox.QBGeneralResponsePage page, NSObject[] evnts)
			{
				if (response == null)
					throw new ArgumentNullException ("response");
				if (page == null)
					throw new ArgumentNullException ("page");
				if (evnts == null)
					throw new ArgumentNullException ("evnts");
				var nsa_evnts = NSArray.FromNSObjects (evnts);
				
				invoker (blockPtr, response.Handle, page.Handle, nsa_evnts.Handle);
				nsa_evnts.Dispose ();
				
			}
		} /* class NIDResponsePageEventsCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DResponseEventCallback (IntPtr block, IntPtr response, IntPtr evnt);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDResponseEventCallback {
			static internal readonly DResponseEventCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DResponseEventCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr response, IntPtr evnt) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::QuickBlox.ResponseEventCallback) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del ( Runtime.GetNSObject<QuickBlox.QBResponse> (response),  Runtime.GetNSObject<QuickBlox.QBMEvent> (evnt));
			}
		} /* class SDResponseEventCallback */
		
		internal class NIDResponseEventCallback {
			IntPtr blockPtr;
			DResponseEventCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDResponseEventCallback (BlockLiteral *block)
			{
				blockPtr = (IntPtr) block;
				invoker = (DResponseEventCallback) Runtime.GetDelegateForBlock (block->invoke, typeof (DResponseEventCallback));
			}
			[Preserve (Conditional=true)]
			public unsafe static global::QuickBlox.ResponseEventCallback Create (IntPtr block)
			{
				return new NIDResponseEventCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::QuickBlox.QBResponse response, global::QuickBlox.QBMEvent evnt)
			{
				if (response == null)
					throw new ArgumentNullException ("response");
				if (evnt == null)
					throw new ArgumentNullException ("evnt");
				invoker (blockPtr, response.Handle, evnt.Handle);
			}
		} /* class NIDResponseEventCallback */
	}
}
