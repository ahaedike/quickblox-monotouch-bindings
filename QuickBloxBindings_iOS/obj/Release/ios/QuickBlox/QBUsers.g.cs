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
	[Register("QBUsers", true)]
	public unsafe partial class QBUsers : QBBaseModule {
		[CompilerGenerated]
		const string selDeleteUserWithExternalIDDelegate_ = "deleteUserWithExternalID:delegate:";
		static readonly IntPtr selDeleteUserWithExternalIDDelegate_Handle = Selector.GetHandle ("deleteUserWithExternalID:delegate:");
		[CompilerGenerated]
		const string selDeleteUserWithExternalIDDelegateContext_ = "deleteUserWithExternalID:delegate:context:";
		static readonly IntPtr selDeleteUserWithExternalIDDelegateContext_Handle = Selector.GetHandle ("deleteUserWithExternalID:delegate:context:");
		[CompilerGenerated]
		const string selDeleteUserWithIDDelegate_ = "deleteUserWithID:delegate:";
		static readonly IntPtr selDeleteUserWithIDDelegate_Handle = Selector.GetHandle ("deleteUserWithID:delegate:");
		[CompilerGenerated]
		const string selDeleteUserWithIDDelegateContext_ = "deleteUserWithID:delegate:context:";
		static readonly IntPtr selDeleteUserWithIDDelegateContext_Handle = Selector.GetHandle ("deleteUserWithID:delegate:context:");
		[CompilerGenerated]
		const string selLogInWithSocialProviderAccessTokenAccessTokenSecretDelegate_ = "logInWithSocialProvider:accessToken:accessTokenSecret:delegate:";
		static readonly IntPtr selLogInWithSocialProviderAccessTokenAccessTokenSecretDelegate_Handle = Selector.GetHandle ("logInWithSocialProvider:accessToken:accessTokenSecret:delegate:");
		[CompilerGenerated]
		const string selLogInWithSocialProviderAccessTokenAccessTokenSecretDelegateContext_ = "logInWithSocialProvider:accessToken:accessTokenSecret:delegate:context:";
		static readonly IntPtr selLogInWithSocialProviderAccessTokenAccessTokenSecretDelegateContext_Handle = Selector.GetHandle ("logInWithSocialProvider:accessToken:accessTokenSecret:delegate:context:");
		[CompilerGenerated]
		const string selLogInWithSocialProviderScopeDelegate_ = "logInWithSocialProvider:scope:delegate:";
		static readonly IntPtr selLogInWithSocialProviderScopeDelegate_Handle = Selector.GetHandle ("logInWithSocialProvider:scope:delegate:");
		[CompilerGenerated]
		const string selLogInWithSocialProviderScopeDelegateContext_ = "logInWithSocialProvider:scope:delegate:context:";
		static readonly IntPtr selLogInWithSocialProviderScopeDelegateContext_Handle = Selector.GetHandle ("logInWithSocialProvider:scope:delegate:context:");
		[CompilerGenerated]
		const string selLogInWithUserEmailPasswordDelegate_ = "logInWithUserEmail:password:delegate:";
		static readonly IntPtr selLogInWithUserEmailPasswordDelegate_Handle = Selector.GetHandle ("logInWithUserEmail:password:delegate:");
		[CompilerGenerated]
		const string selLogInWithUserEmailPasswordDelegateContext_ = "logInWithUserEmail:password:delegate:context:";
		static readonly IntPtr selLogInWithUserEmailPasswordDelegateContext_Handle = Selector.GetHandle ("logInWithUserEmail:password:delegate:context:");
		[CompilerGenerated]
		const string selLogInWithUserLoginPasswordDelegate_ = "logInWithUserLogin:password:delegate:";
		static readonly IntPtr selLogInWithUserLoginPasswordDelegate_Handle = Selector.GetHandle ("logInWithUserLogin:password:delegate:");
		[CompilerGenerated]
		const string selLogInWithUserLoginPasswordDelegateContext_ = "logInWithUserLogin:password:delegate:context:";
		static readonly IntPtr selLogInWithUserLoginPasswordDelegateContext_Handle = Selector.GetHandle ("logInWithUserLogin:password:delegate:context:");
		[CompilerGenerated]
		const string selLogOutWithDelegate_ = "logOutWithDelegate:";
		static readonly IntPtr selLogOutWithDelegate_Handle = Selector.GetHandle ("logOutWithDelegate:");
		[CompilerGenerated]
		const string selLogOutWithDelegateContext_ = "logOutWithDelegate:context:";
		static readonly IntPtr selLogOutWithDelegateContext_Handle = Selector.GetHandle ("logOutWithDelegate:context:");
		[CompilerGenerated]
		const string selResetUserPasswordWithEmailDelegate_ = "resetUserPasswordWithEmail:delegate:";
		static readonly IntPtr selResetUserPasswordWithEmailDelegate_Handle = Selector.GetHandle ("resetUserPasswordWithEmail:delegate:");
		[CompilerGenerated]
		const string selResetUserPasswordWithEmailDelegateContext_ = "resetUserPasswordWithEmail:delegate:context:";
		static readonly IntPtr selResetUserPasswordWithEmailDelegateContext_Handle = Selector.GetHandle ("resetUserPasswordWithEmail:delegate:context:");
		[CompilerGenerated]
		const string selSignUpDelegate_ = "signUp:delegate:";
		static readonly IntPtr selSignUpDelegate_Handle = Selector.GetHandle ("signUp:delegate:");
		[CompilerGenerated]
		const string selSignUpDelegateContext_ = "signUp:delegate:context:";
		static readonly IntPtr selSignUpDelegateContext_Handle = Selector.GetHandle ("signUp:delegate:context:");
		[CompilerGenerated]
		const string selUpdateUserDelegate_ = "updateUser:delegate:";
		static readonly IntPtr selUpdateUserDelegate_Handle = Selector.GetHandle ("updateUser:delegate:");
		[CompilerGenerated]
		const string selUpdateUserDelegateContext_ = "updateUser:delegate:context:";
		static readonly IntPtr selUpdateUserDelegateContext_Handle = Selector.GetHandle ("updateUser:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithDelegate_ = "usersWithDelegate:";
		static readonly IntPtr selUsersWithDelegate_Handle = Selector.GetHandle ("usersWithDelegate:");
		[CompilerGenerated]
		const string selUsersWithDelegateContext_ = "usersWithDelegate:context:";
		static readonly IntPtr selUsersWithDelegateContext_Handle = Selector.GetHandle ("usersWithDelegate:context:");
		[CompilerGenerated]
		const string selUsersWithEmailsDelegate_ = "usersWithEmails:delegate:";
		static readonly IntPtr selUsersWithEmailsDelegate_Handle = Selector.GetHandle ("usersWithEmails:delegate:");
		[CompilerGenerated]
		const string selUsersWithEmailsDelegateContext_ = "usersWithEmails:delegate:context:";
		static readonly IntPtr selUsersWithEmailsDelegateContext_Handle = Selector.GetHandle ("usersWithEmails:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithEmailsPagedRequestDelegate_ = "usersWithEmails:pagedRequest:delegate:";
		static readonly IntPtr selUsersWithEmailsPagedRequestDelegate_Handle = Selector.GetHandle ("usersWithEmails:pagedRequest:delegate:");
		[CompilerGenerated]
		const string selUsersWithEmailsPagedRequestDelegateContext_ = "usersWithEmails:pagedRequest:delegate:context:";
		static readonly IntPtr selUsersWithEmailsPagedRequestDelegateContext_Handle = Selector.GetHandle ("usersWithEmails:pagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithExtendedRequestDelegate_ = "usersWithExtendedRequest:delegate:";
		static readonly IntPtr selUsersWithExtendedRequestDelegate_Handle = Selector.GetHandle ("usersWithExtendedRequest:delegate:");
		[CompilerGenerated]
		const string selUsersWithExtendedRequestDelegateContext_ = "usersWithExtendedRequest:delegate:context:";
		static readonly IntPtr selUsersWithExtendedRequestDelegateContext_Handle = Selector.GetHandle ("usersWithExtendedRequest:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithFacebookIDsDelegate_ = "usersWithFacebookIDs:delegate:";
		static readonly IntPtr selUsersWithFacebookIDsDelegate_Handle = Selector.GetHandle ("usersWithFacebookIDs:delegate:");
		[CompilerGenerated]
		const string selUsersWithFacebookIDsDelegateContext_ = "usersWithFacebookIDs:delegate:context:";
		static readonly IntPtr selUsersWithFacebookIDsDelegateContext_Handle = Selector.GetHandle ("usersWithFacebookIDs:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithFacebookIDsPagedRequestDelegate_ = "usersWithFacebookIDs:pagedRequest:delegate:";
		static readonly IntPtr selUsersWithFacebookIDsPagedRequestDelegate_Handle = Selector.GetHandle ("usersWithFacebookIDs:pagedRequest:delegate:");
		[CompilerGenerated]
		const string selUsersWithFacebookIDsPagedRequestDelegateContext_ = "usersWithFacebookIDs:pagedRequest:delegate:context:";
		static readonly IntPtr selUsersWithFacebookIDsPagedRequestDelegateContext_Handle = Selector.GetHandle ("usersWithFacebookIDs:pagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithFullNameDelegate_ = "usersWithFullName:delegate:";
		static readonly IntPtr selUsersWithFullNameDelegate_Handle = Selector.GetHandle ("usersWithFullName:delegate:");
		[CompilerGenerated]
		const string selUsersWithFullNameDelegateContext_ = "usersWithFullName:delegate:context:";
		static readonly IntPtr selUsersWithFullNameDelegateContext_Handle = Selector.GetHandle ("usersWithFullName:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithFullNamePagedRequestDelegate_ = "usersWithFullName:pagedRequest:delegate:";
		static readonly IntPtr selUsersWithFullNamePagedRequestDelegate_Handle = Selector.GetHandle ("usersWithFullName:pagedRequest:delegate:");
		[CompilerGenerated]
		const string selUsersWithFullNamePagedRequestDelegateContext_ = "usersWithFullName:pagedRequest:delegate:context:";
		static readonly IntPtr selUsersWithFullNamePagedRequestDelegateContext_Handle = Selector.GetHandle ("usersWithFullName:pagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithIDsDelegate_ = "usersWithIDs:delegate:";
		static readonly IntPtr selUsersWithIDsDelegate_Handle = Selector.GetHandle ("usersWithIDs:delegate:");
		[CompilerGenerated]
		const string selUsersWithIDsDelegateContext_ = "usersWithIDs:delegate:context:";
		static readonly IntPtr selUsersWithIDsDelegateContext_Handle = Selector.GetHandle ("usersWithIDs:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithIDsPagedRequestDelegate_ = "usersWithIDs:pagedRequest:delegate:";
		static readonly IntPtr selUsersWithIDsPagedRequestDelegate_Handle = Selector.GetHandle ("usersWithIDs:pagedRequest:delegate:");
		[CompilerGenerated]
		const string selUsersWithIDsPagedRequestDelegateContext_ = "usersWithIDs:pagedRequest:delegate:context:";
		static readonly IntPtr selUsersWithIDsPagedRequestDelegateContext_Handle = Selector.GetHandle ("usersWithIDs:pagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithLoginsDelegate_ = "usersWithLogins:delegate:";
		static readonly IntPtr selUsersWithLoginsDelegate_Handle = Selector.GetHandle ("usersWithLogins:delegate:");
		[CompilerGenerated]
		const string selUsersWithLoginsDelegateContext_ = "usersWithLogins:delegate:context:";
		static readonly IntPtr selUsersWithLoginsDelegateContext_Handle = Selector.GetHandle ("usersWithLogins:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithLoginsPagedRequestDelegate_ = "usersWithLogins:pagedRequest:delegate:";
		static readonly IntPtr selUsersWithLoginsPagedRequestDelegate_Handle = Selector.GetHandle ("usersWithLogins:pagedRequest:delegate:");
		[CompilerGenerated]
		const string selUsersWithLoginsPagedRequestDelegateContext_ = "usersWithLogins:pagedRequest:delegate:context:";
		static readonly IntPtr selUsersWithLoginsPagedRequestDelegateContext_Handle = Selector.GetHandle ("usersWithLogins:pagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithPagedRequestDelegate_ = "usersWithPagedRequest:delegate:";
		static readonly IntPtr selUsersWithPagedRequestDelegate_Handle = Selector.GetHandle ("usersWithPagedRequest:delegate:");
		[CompilerGenerated]
		const string selUsersWithPagedRequestDelegateContext_ = "usersWithPagedRequest:delegate:context:";
		static readonly IntPtr selUsersWithPagedRequestDelegateContext_Handle = Selector.GetHandle ("usersWithPagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithPhoneNumbersDelegate_ = "usersWithPhoneNumbers:delegate:";
		static readonly IntPtr selUsersWithPhoneNumbersDelegate_Handle = Selector.GetHandle ("usersWithPhoneNumbers:delegate:");
		[CompilerGenerated]
		const string selUsersWithPhoneNumbersDelegateContext_ = "usersWithPhoneNumbers:delegate:context:";
		static readonly IntPtr selUsersWithPhoneNumbersDelegateContext_Handle = Selector.GetHandle ("usersWithPhoneNumbers:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithPhoneNumbersPagedRequestDelegate_ = "usersWithPhoneNumbers:pagedRequest:delegate:";
		static readonly IntPtr selUsersWithPhoneNumbersPagedRequestDelegate_Handle = Selector.GetHandle ("usersWithPhoneNumbers:pagedRequest:delegate:");
		[CompilerGenerated]
		const string selUsersWithPhoneNumbersPagedRequestDelegateContext_ = "usersWithPhoneNumbers:pagedRequest:delegate:context:";
		static readonly IntPtr selUsersWithPhoneNumbersPagedRequestDelegateContext_Handle = Selector.GetHandle ("usersWithPhoneNumbers:pagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithTagsDelegate_ = "usersWithTags:delegate:";
		static readonly IntPtr selUsersWithTagsDelegate_Handle = Selector.GetHandle ("usersWithTags:delegate:");
		[CompilerGenerated]
		const string selUsersWithTagsDelegateContext_ = "usersWithTags:delegate:context:";
		static readonly IntPtr selUsersWithTagsDelegateContext_Handle = Selector.GetHandle ("usersWithTags:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithTagsPagedRequestDelegate_ = "usersWithTags:pagedRequest:delegate:";
		static readonly IntPtr selUsersWithTagsPagedRequestDelegate_Handle = Selector.GetHandle ("usersWithTags:pagedRequest:delegate:");
		[CompilerGenerated]
		const string selUsersWithTagsPagedRequestDelegateContext_ = "usersWithTags:pagedRequest:delegate:context:";
		static readonly IntPtr selUsersWithTagsPagedRequestDelegateContext_Handle = Selector.GetHandle ("usersWithTags:pagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithTwitterIDsDelegate_ = "usersWithTwitterIDs:delegate:";
		static readonly IntPtr selUsersWithTwitterIDsDelegate_Handle = Selector.GetHandle ("usersWithTwitterIDs:delegate:");
		[CompilerGenerated]
		const string selUsersWithTwitterIDsDelegateContext_ = "usersWithTwitterIDs:delegate:context:";
		static readonly IntPtr selUsersWithTwitterIDsDelegateContext_Handle = Selector.GetHandle ("usersWithTwitterIDs:delegate:context:");
		[CompilerGenerated]
		const string selUsersWithTwitterIDsPagedRequestDelegate_ = "usersWithTwitterIDs:pagedRequest:delegate:";
		static readonly IntPtr selUsersWithTwitterIDsPagedRequestDelegate_Handle = Selector.GetHandle ("usersWithTwitterIDs:pagedRequest:delegate:");
		[CompilerGenerated]
		const string selUsersWithTwitterIDsPagedRequestDelegateContext_ = "usersWithTwitterIDs:pagedRequest:delegate:context:";
		static readonly IntPtr selUsersWithTwitterIDsPagedRequestDelegateContext_Handle = Selector.GetHandle ("usersWithTwitterIDs:pagedRequest:delegate:context:");
		[CompilerGenerated]
		const string selUserWithEmailDelegate_ = "userWithEmail:delegate:";
		static readonly IntPtr selUserWithEmailDelegate_Handle = Selector.GetHandle ("userWithEmail:delegate:");
		[CompilerGenerated]
		const string selUserWithEmailDelegateContext_ = "userWithEmail:delegate:context:";
		static readonly IntPtr selUserWithEmailDelegateContext_Handle = Selector.GetHandle ("userWithEmail:delegate:context:");
		[CompilerGenerated]
		const string selUserWithExternalIDDelegate_ = "userWithExternalID:delegate:";
		static readonly IntPtr selUserWithExternalIDDelegate_Handle = Selector.GetHandle ("userWithExternalID:delegate:");
		[CompilerGenerated]
		const string selUserWithExternalIDDelegateContext_ = "userWithExternalID:delegate:context:";
		static readonly IntPtr selUserWithExternalIDDelegateContext_Handle = Selector.GetHandle ("userWithExternalID:delegate:context:");
		[CompilerGenerated]
		const string selUserWithFacebookIDDelegate_ = "userWithFacebookID:delegate:";
		static readonly IntPtr selUserWithFacebookIDDelegate_Handle = Selector.GetHandle ("userWithFacebookID:delegate:");
		[CompilerGenerated]
		const string selUserWithFacebookIDDelegateContext_ = "userWithFacebookID:delegate:context:";
		static readonly IntPtr selUserWithFacebookIDDelegateContext_Handle = Selector.GetHandle ("userWithFacebookID:delegate:context:");
		[CompilerGenerated]
		const string selUserWithIDDelegate_ = "userWithID:delegate:";
		static readonly IntPtr selUserWithIDDelegate_Handle = Selector.GetHandle ("userWithID:delegate:");
		[CompilerGenerated]
		const string selUserWithIDDelegateContext_ = "userWithID:delegate:context:";
		static readonly IntPtr selUserWithIDDelegateContext_Handle = Selector.GetHandle ("userWithID:delegate:context:");
		[CompilerGenerated]
		const string selUserWithLoginDelegate_ = "userWithLogin:delegate:";
		static readonly IntPtr selUserWithLoginDelegate_Handle = Selector.GetHandle ("userWithLogin:delegate:");
		[CompilerGenerated]
		const string selUserWithLoginDelegateContext_ = "userWithLogin:delegate:context:";
		static readonly IntPtr selUserWithLoginDelegateContext_Handle = Selector.GetHandle ("userWithLogin:delegate:context:");
		[CompilerGenerated]
		const string selUserWithTwitterIDDelegate_ = "userWithTwitterID:delegate:";
		static readonly IntPtr selUserWithTwitterIDDelegate_Handle = Selector.GetHandle ("userWithTwitterID:delegate:");
		[CompilerGenerated]
		const string selUserWithTwitterIDDelegateContext_ = "userWithTwitterID:delegate:context:";
		static readonly IntPtr selUserWithTwitterIDDelegateContext_Handle = Selector.GetHandle ("userWithTwitterID:delegate:context:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("QBUsers");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QBUsers () : base (NSObjectFlag.Empty)
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
		public QBUsers (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUsers (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public QBUsers (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("deleteUserWithExternalID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteUserWithExternalID (global::System.UInt32 userExternalID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeleteUserWithExternalIDDelegate_Handle, userExternalID, _delegate.Handle));
		}
		
		[Export ("deleteUserWithExternalID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteUserWithExternalID (global::System.UInt32 userExternalID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeleteUserWithExternalIDDelegateContext_Handle, userExternalID, _delegate.Handle, context.Handle));
		}
		
		[Export ("deleteUserWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject DeleteUserWithID (global::System.UInt32 userID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selDeleteUserWithIDDelegate_Handle, userID, _delegate.Handle));
		}
		
		[Export ("deleteUserWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject DeleteUserWithID (global::System.UInt32 userID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selDeleteUserWithIDDelegateContext_Handle, userID, _delegate.Handle, context.Handle));
		}
		
		[Export ("logInWithSocialProvider:scope:delegate:")]
		[CompilerGenerated]
		public static NSObject LogInWithSocialProvider (string provider, NSObject[] scope, NSObject _delegate)
		{
			if (provider == null)
				throw new ArgumentNullException ("provider");
			if (scope == null)
				throw new ArgumentNullException ("scope");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsprovider = NSString.CreateNative (provider);
			var nsa_scope = NSArray.FromNSObjects (scope);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selLogInWithSocialProviderScopeDelegate_Handle, nsprovider, nsa_scope.Handle, _delegate.Handle));
			NSString.ReleaseNative (nsprovider);
			nsa_scope.Dispose ();
			
			return ret;
		}
		
		[Export ("logInWithSocialProvider:scope:delegate:context:")]
		[CompilerGenerated]
		public static NSObject LogInWithSocialProvider (string provider, NSObject[] scope, NSObject _delegate, NSObject context)
		{
			if (provider == null)
				throw new ArgumentNullException ("provider");
			if (scope == null)
				throw new ArgumentNullException ("scope");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsprovider = NSString.CreateNative (provider);
			var nsa_scope = NSArray.FromNSObjects (scope);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selLogInWithSocialProviderScopeDelegateContext_Handle, nsprovider, nsa_scope.Handle, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsprovider);
			nsa_scope.Dispose ();
			
			return ret;
		}
		
		[Export ("logInWithSocialProvider:accessToken:accessTokenSecret:delegate:")]
		[CompilerGenerated]
		public static NSObject LogInWithSocialProvider (string provider, string accessToken, string accessTokenSecret, NSObject _delegate)
		{
			if (provider == null)
				throw new ArgumentNullException ("provider");
			if (accessToken == null)
				throw new ArgumentNullException ("accessToken");
			if (accessTokenSecret == null)
				throw new ArgumentNullException ("accessTokenSecret");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsprovider = NSString.CreateNative (provider);
			var nsaccessToken = NSString.CreateNative (accessToken);
			var nsaccessTokenSecret = NSString.CreateNative (accessTokenSecret);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selLogInWithSocialProviderAccessTokenAccessTokenSecretDelegate_Handle, nsprovider, nsaccessToken, nsaccessTokenSecret, _delegate.Handle));
			NSString.ReleaseNative (nsprovider);
			NSString.ReleaseNative (nsaccessToken);
			NSString.ReleaseNative (nsaccessTokenSecret);
			
			return ret;
		}
		
		[Export ("logInWithSocialProvider:accessToken:accessTokenSecret:delegate:context:")]
		[CompilerGenerated]
		public static NSObject LogInWithSocialProvider (string provider, string accessToken, string accessTokenSecret, NSObject _delegate, NSObject context)
		{
			if (provider == null)
				throw new ArgumentNullException ("provider");
			if (accessToken == null)
				throw new ArgumentNullException ("accessToken");
			if (accessTokenSecret == null)
				throw new ArgumentNullException ("accessTokenSecret");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsprovider = NSString.CreateNative (provider);
			var nsaccessToken = NSString.CreateNative (accessToken);
			var nsaccessTokenSecret = NSString.CreateNative (accessTokenSecret);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selLogInWithSocialProviderAccessTokenAccessTokenSecretDelegateContext_Handle, nsprovider, nsaccessToken, nsaccessTokenSecret, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsprovider);
			NSString.ReleaseNative (nsaccessToken);
			NSString.ReleaseNative (nsaccessTokenSecret);
			
			return ret;
		}
		
		[Export ("logInWithUserEmail:password:delegate:")]
		[CompilerGenerated]
		public static NSObject LogInWithUserEmail (string email, string password, NSObject _delegate)
		{
			if (email == null)
				throw new ArgumentNullException ("email");
			if (password == null)
				throw new ArgumentNullException ("password");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsemail = NSString.CreateNative (email);
			var nspassword = NSString.CreateNative (password);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selLogInWithUserEmailPasswordDelegate_Handle, nsemail, nspassword, _delegate.Handle));
			NSString.ReleaseNative (nsemail);
			NSString.ReleaseNative (nspassword);
			
			return ret;
		}
		
		[Export ("logInWithUserEmail:password:delegate:context:")]
		[CompilerGenerated]
		public static NSObject LogInWithUserEmail (string email, string password, NSObject _delegate, NSObject context)
		{
			if (email == null)
				throw new ArgumentNullException ("email");
			if (password == null)
				throw new ArgumentNullException ("password");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsemail = NSString.CreateNative (email);
			var nspassword = NSString.CreateNative (password);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selLogInWithUserEmailPasswordDelegateContext_Handle, nsemail, nspassword, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsemail);
			NSString.ReleaseNative (nspassword);
			
			return ret;
		}
		
		[Export ("logInWithUserLogin:password:delegate:")]
		[CompilerGenerated]
		public static NSObject LogInWithUserLogin (string login, string password, NSObject _delegate)
		{
			if (login == null)
				throw new ArgumentNullException ("login");
			if (password == null)
				throw new ArgumentNullException ("password");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nslogin = NSString.CreateNative (login);
			var nspassword = NSString.CreateNative (password);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selLogInWithUserLoginPasswordDelegate_Handle, nslogin, nspassword, _delegate.Handle));
			NSString.ReleaseNative (nslogin);
			NSString.ReleaseNative (nspassword);
			
			return ret;
		}
		
		[Export ("logInWithUserLogin:password:delegate:context:")]
		[CompilerGenerated]
		public static NSObject LogInWithUserLogin (string login, string password, NSObject _delegate, NSObject context)
		{
			if (login == null)
				throw new ArgumentNullException ("login");
			if (password == null)
				throw new ArgumentNullException ("password");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nslogin = NSString.CreateNative (login);
			var nspassword = NSString.CreateNative (password);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selLogInWithUserLoginPasswordDelegateContext_Handle, nslogin, nspassword, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nslogin);
			NSString.ReleaseNative (nspassword);
			
			return ret;
		}
		
		[Export ("logOutWithDelegate:")]
		[CompilerGenerated]
		public static NSObject LogOutWithDelegate (NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selLogOutWithDelegate_Handle, _delegate.Handle));
		}
		
		[Export ("logOutWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject LogOutWithDelegate (NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selLogOutWithDelegateContext_Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("resetUserPasswordWithEmail:delegate:")]
		[CompilerGenerated]
		public static NSObject ResetUserPasswordWithEmail (string email, NSObject _delegate)
		{
			if (email == null)
				throw new ArgumentNullException ("email");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsemail = NSString.CreateNative (email);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selResetUserPasswordWithEmailDelegate_Handle, nsemail, _delegate.Handle));
			NSString.ReleaseNative (nsemail);
			
			return ret;
		}
		
		[Export ("resetUserPasswordWithEmail:delegate:context:")]
		[CompilerGenerated]
		public static NSObject ResetUserPasswordWithEmail (string email, NSObject _delegate, NSObject context)
		{
			if (email == null)
				throw new ArgumentNullException ("email");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsemail = NSString.CreateNative (email);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selResetUserPasswordWithEmailDelegateContext_Handle, nsemail, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsemail);
			
			return ret;
		}
		
		[Export ("signUp:delegate:")]
		[CompilerGenerated]
		public static NSObject SignUp (QBUUser user, NSObject _delegate)
		{
			if (user == null)
				throw new ArgumentNullException ("user");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selSignUpDelegate_Handle, user.Handle, _delegate.Handle));
		}
		
		[Export ("signUp:delegate:context:")]
		[CompilerGenerated]
		public static NSObject SignUp (QBUUser user, NSObject _delegate, NSObject context)
		{
			if (user == null)
				throw new ArgumentNullException ("user");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selSignUpDelegateContext_Handle, user.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("updateUser:delegate:")]
		[CompilerGenerated]
		public static NSObject UpdateUser (QBUUser user, NSObject _delegate)
		{
			if (user == null)
				throw new ArgumentNullException ("user");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUpdateUserDelegate_Handle, user.Handle, _delegate.Handle));
		}
		
		[Export ("updateUser:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UpdateUser (QBUUser user, NSObject _delegate, NSObject context)
		{
			if (user == null)
				throw new ArgumentNullException ("user");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUpdateUserDelegateContext_Handle, user.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("usersWithDelegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithDelegate (NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selUsersWithDelegate_Handle, _delegate.Handle));
		}
		
		[Export ("usersWithDelegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithDelegate (NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUsersWithDelegateContext_Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("usersWithEmails:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithEmails (NSObject[] emails, NSObject _delegate)
		{
			if (emails == null)
				throw new ArgumentNullException ("emails");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_emails = NSArray.FromNSObjects (emails);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUsersWithEmailsDelegate_Handle, nsa_emails.Handle, _delegate.Handle));
			nsa_emails.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithEmails:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithEmails (NSObject[] emails, NSObject _delegate, NSObject context)
		{
			if (emails == null)
				throw new ArgumentNullException ("emails");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_emails = NSArray.FromNSObjects (emails);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithEmailsDelegateContext_Handle, nsa_emails.Handle, _delegate.Handle, context.Handle));
			nsa_emails.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithEmails:pagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithEmails (NSObject[] emails, PagedRequest pagedRequest, NSObject _delegate)
		{
			if (emails == null)
				throw new ArgumentNullException ("emails");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_emails = NSArray.FromNSObjects (emails);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithEmailsPagedRequestDelegate_Handle, nsa_emails.Handle, pagedRequest.Handle, _delegate.Handle));
			nsa_emails.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithEmails:pagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithEmails (NSObject[] emails, PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (emails == null)
				throw new ArgumentNullException ("emails");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_emails = NSArray.FromNSObjects (emails);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithEmailsPagedRequestDelegateContext_Handle, nsa_emails.Handle, pagedRequest.Handle, _delegate.Handle, context.Handle));
			nsa_emails.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithExtendedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithExtendedRequest (NSDictionary extendedRequest, NSObject _delegate)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUsersWithExtendedRequestDelegate_Handle, extendedRequest.Handle, _delegate.Handle));
		}
		
		[Export ("usersWithExtendedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithExtendedRequest (NSDictionary extendedRequest, NSObject _delegate, NSObject context)
		{
			if (extendedRequest == null)
				throw new ArgumentNullException ("extendedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithExtendedRequestDelegateContext_Handle, extendedRequest.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("usersWithFacebookIDs:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithFacebookIDs (NSObject[] facebookIDs, NSObject _delegate)
		{
			if (facebookIDs == null)
				throw new ArgumentNullException ("facebookIDs");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_facebookIDs = NSArray.FromNSObjects (facebookIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUsersWithFacebookIDsDelegate_Handle, nsa_facebookIDs.Handle, _delegate.Handle));
			nsa_facebookIDs.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithFacebookIDs:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithFacebookIDs (NSObject[] facebookIDs, NSObject _delegate, NSObject context)
		{
			if (facebookIDs == null)
				throw new ArgumentNullException ("facebookIDs");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_facebookIDs = NSArray.FromNSObjects (facebookIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithFacebookIDsDelegateContext_Handle, nsa_facebookIDs.Handle, _delegate.Handle, context.Handle));
			nsa_facebookIDs.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithFacebookIDs:pagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithFacebookIDs (NSObject[] facebookIDs, PagedRequest pagedRequest, NSObject _delegate)
		{
			if (facebookIDs == null)
				throw new ArgumentNullException ("facebookIDs");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_facebookIDs = NSArray.FromNSObjects (facebookIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithFacebookIDsPagedRequestDelegate_Handle, nsa_facebookIDs.Handle, pagedRequest.Handle, _delegate.Handle));
			nsa_facebookIDs.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithFacebookIDs:pagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithFacebookIDs (NSObject[] facebookIDs, PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (facebookIDs == null)
				throw new ArgumentNullException ("facebookIDs");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_facebookIDs = NSArray.FromNSObjects (facebookIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithFacebookIDsPagedRequestDelegateContext_Handle, nsa_facebookIDs.Handle, pagedRequest.Handle, _delegate.Handle, context.Handle));
			nsa_facebookIDs.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithFullName:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithFullName (string userFullName, NSObject _delegate)
		{
			if (userFullName == null)
				throw new ArgumentNullException ("userFullName");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsuserFullName = NSString.CreateNative (userFullName);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUsersWithFullNameDelegate_Handle, nsuserFullName, _delegate.Handle));
			NSString.ReleaseNative (nsuserFullName);
			
			return ret;
		}
		
		[Export ("usersWithFullName:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithFullName (string userFullName, NSObject _delegate, NSObject context)
		{
			if (userFullName == null)
				throw new ArgumentNullException ("userFullName");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsuserFullName = NSString.CreateNative (userFullName);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithFullNameDelegateContext_Handle, nsuserFullName, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsuserFullName);
			
			return ret;
		}
		
		[Export ("usersWithFullName:pagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithFullName (string userFullName, PagedRequest pagedRequest, NSObject _delegate)
		{
			if (userFullName == null)
				throw new ArgumentNullException ("userFullName");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsuserFullName = NSString.CreateNative (userFullName);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithFullNamePagedRequestDelegate_Handle, nsuserFullName, pagedRequest.Handle, _delegate.Handle));
			NSString.ReleaseNative (nsuserFullName);
			
			return ret;
		}
		
		[Export ("usersWithFullName:pagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithFullName (string userFullName, PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (userFullName == null)
				throw new ArgumentNullException ("userFullName");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsuserFullName = NSString.CreateNative (userFullName);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithFullNamePagedRequestDelegateContext_Handle, nsuserFullName, pagedRequest.Handle, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsuserFullName);
			
			return ret;
		}
		
		[Export ("usersWithIDs:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithIDs (string ids, NSObject _delegate)
		{
			if (ids == null)
				throw new ArgumentNullException ("ids");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsids = NSString.CreateNative (ids);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUsersWithIDsDelegate_Handle, nsids, _delegate.Handle));
			NSString.ReleaseNative (nsids);
			
			return ret;
		}
		
		[Export ("usersWithIDs:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithIDs (string ids, NSObject _delegate, NSObject context)
		{
			if (ids == null)
				throw new ArgumentNullException ("ids");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsids = NSString.CreateNative (ids);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithIDsDelegateContext_Handle, nsids, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsids);
			
			return ret;
		}
		
		[Export ("usersWithIDs:pagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithIDs (string ids, PagedRequest pagedRequest, NSObject _delegate)
		{
			if (ids == null)
				throw new ArgumentNullException ("ids");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsids = NSString.CreateNative (ids);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithIDsPagedRequestDelegate_Handle, nsids, pagedRequest.Handle, _delegate.Handle));
			NSString.ReleaseNative (nsids);
			
			return ret;
		}
		
		[Export ("usersWithIDs:pagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithIDs (string ids, PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (ids == null)
				throw new ArgumentNullException ("ids");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsids = NSString.CreateNative (ids);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithIDsPagedRequestDelegateContext_Handle, nsids, pagedRequest.Handle, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsids);
			
			return ret;
		}
		
		[Export ("usersWithLogins:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithLogins (NSObject[] logins, NSObject _delegate)
		{
			if (logins == null)
				throw new ArgumentNullException ("logins");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_logins = NSArray.FromNSObjects (logins);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUsersWithLoginsDelegate_Handle, nsa_logins.Handle, _delegate.Handle));
			nsa_logins.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithLogins:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithLogins (NSObject[] logins, NSObject _delegate, NSObject context)
		{
			if (logins == null)
				throw new ArgumentNullException ("logins");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_logins = NSArray.FromNSObjects (logins);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithLoginsDelegateContext_Handle, nsa_logins.Handle, _delegate.Handle, context.Handle));
			nsa_logins.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithLogins:pagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithLogins (NSObject[] logins, PagedRequest pagedRequest, NSObject _delegate)
		{
			if (logins == null)
				throw new ArgumentNullException ("logins");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_logins = NSArray.FromNSObjects (logins);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithLoginsPagedRequestDelegate_Handle, nsa_logins.Handle, pagedRequest.Handle, _delegate.Handle));
			nsa_logins.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithLogins:pagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithLogins (NSObject[] logins, PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (logins == null)
				throw new ArgumentNullException ("logins");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_logins = NSArray.FromNSObjects (logins);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithLoginsPagedRequestDelegateContext_Handle, nsa_logins.Handle, pagedRequest.Handle, _delegate.Handle, context.Handle));
			nsa_logins.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithPagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUsersWithPagedRequestDelegate_Handle, pagedRequest.Handle, _delegate.Handle));
		}
		
		[Export ("usersWithPagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithPagedRequestDelegateContext_Handle, pagedRequest.Handle, _delegate.Handle, context.Handle));
		}
		
		[Export ("usersWithPhoneNumbers:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithPhoneNumbers (NSObject[] phoneNumbers, NSObject _delegate)
		{
			if (phoneNumbers == null)
				throw new ArgumentNullException ("phoneNumbers");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_phoneNumbers = NSArray.FromNSObjects (phoneNumbers);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUsersWithPhoneNumbersDelegate_Handle, nsa_phoneNumbers.Handle, _delegate.Handle));
			nsa_phoneNumbers.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithPhoneNumbers:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithPhoneNumbers (NSObject[] phoneNumbers, NSObject _delegate, NSObject context)
		{
			if (phoneNumbers == null)
				throw new ArgumentNullException ("phoneNumbers");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_phoneNumbers = NSArray.FromNSObjects (phoneNumbers);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithPhoneNumbersDelegateContext_Handle, nsa_phoneNumbers.Handle, _delegate.Handle, context.Handle));
			nsa_phoneNumbers.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithPhoneNumbers:pagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithPhoneNumbers (NSObject[] phoneNumbers, PagedRequest pagedRequest, NSObject _delegate)
		{
			if (phoneNumbers == null)
				throw new ArgumentNullException ("phoneNumbers");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_phoneNumbers = NSArray.FromNSObjects (phoneNumbers);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithPhoneNumbersPagedRequestDelegate_Handle, nsa_phoneNumbers.Handle, pagedRequest.Handle, _delegate.Handle));
			nsa_phoneNumbers.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithPhoneNumbers:pagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithPhoneNumbers (NSObject[] phoneNumbers, PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (phoneNumbers == null)
				throw new ArgumentNullException ("phoneNumbers");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_phoneNumbers = NSArray.FromNSObjects (phoneNumbers);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithPhoneNumbersPagedRequestDelegateContext_Handle, nsa_phoneNumbers.Handle, pagedRequest.Handle, _delegate.Handle, context.Handle));
			nsa_phoneNumbers.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithTags:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithTags (NSObject[] tags, NSObject _delegate)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_tags = NSArray.FromNSObjects (tags);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUsersWithTagsDelegate_Handle, nsa_tags.Handle, _delegate.Handle));
			nsa_tags.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithTags:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithTags (NSObject[] tags, NSObject _delegate, NSObject context)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_tags = NSArray.FromNSObjects (tags);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithTagsDelegateContext_Handle, nsa_tags.Handle, _delegate.Handle, context.Handle));
			nsa_tags.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithTags:pagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithTags (NSObject[] tags, PagedRequest pagedRequest, NSObject _delegate)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_tags = NSArray.FromNSObjects (tags);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithTagsPagedRequestDelegate_Handle, nsa_tags.Handle, pagedRequest.Handle, _delegate.Handle));
			nsa_tags.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithTags:pagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithTags (NSObject[] tags, PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_tags = NSArray.FromNSObjects (tags);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithTagsPagedRequestDelegateContext_Handle, nsa_tags.Handle, pagedRequest.Handle, _delegate.Handle, context.Handle));
			nsa_tags.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithTwitterIDs:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithTwitterIDs (NSObject[] twitterIDs, NSObject _delegate)
		{
			if (twitterIDs == null)
				throw new ArgumentNullException ("twitterIDs");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_twitterIDs = NSArray.FromNSObjects (twitterIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUsersWithTwitterIDsDelegate_Handle, nsa_twitterIDs.Handle, _delegate.Handle));
			nsa_twitterIDs.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithTwitterIDs:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithTwitterIDs (NSObject[] twitterIDs, NSObject _delegate, NSObject context)
		{
			if (twitterIDs == null)
				throw new ArgumentNullException ("twitterIDs");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_twitterIDs = NSArray.FromNSObjects (twitterIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithTwitterIDsDelegateContext_Handle, nsa_twitterIDs.Handle, _delegate.Handle, context.Handle));
			nsa_twitterIDs.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithTwitterIDs:pagedRequest:delegate:")]
		[CompilerGenerated]
		public static NSObject UsersWithTwitterIDs (NSObject[] twitterIDs, PagedRequest pagedRequest, NSObject _delegate)
		{
			if (twitterIDs == null)
				throw new ArgumentNullException ("twitterIDs");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsa_twitterIDs = NSArray.FromNSObjects (twitterIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithTwitterIDsPagedRequestDelegate_Handle, nsa_twitterIDs.Handle, pagedRequest.Handle, _delegate.Handle));
			nsa_twitterIDs.Dispose ();
			
			return ret;
		}
		
		[Export ("usersWithTwitterIDs:pagedRequest:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UsersWithTwitterIDs (NSObject[] twitterIDs, PagedRequest pagedRequest, NSObject _delegate, NSObject context)
		{
			if (twitterIDs == null)
				throw new ArgumentNullException ("twitterIDs");
			if (pagedRequest == null)
				throw new ArgumentNullException ("pagedRequest");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsa_twitterIDs = NSArray.FromNSObjects (twitterIDs);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selUsersWithTwitterIDsPagedRequestDelegateContext_Handle, nsa_twitterIDs.Handle, pagedRequest.Handle, _delegate.Handle, context.Handle));
			nsa_twitterIDs.Dispose ();
			
			return ret;
		}
		
		[Export ("userWithEmail:delegate:")]
		[CompilerGenerated]
		public static NSObject UserWithEmail (string userEmail, NSObject _delegate)
		{
			if (userEmail == null)
				throw new ArgumentNullException ("userEmail");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsuserEmail = NSString.CreateNative (userEmail);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUserWithEmailDelegate_Handle, nsuserEmail, _delegate.Handle));
			NSString.ReleaseNative (nsuserEmail);
			
			return ret;
		}
		
		[Export ("userWithEmail:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UserWithEmail (string userEmail, NSObject _delegate, NSObject context)
		{
			if (userEmail == null)
				throw new ArgumentNullException ("userEmail");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsuserEmail = NSString.CreateNative (userEmail);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUserWithEmailDelegateContext_Handle, nsuserEmail, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsuserEmail);
			
			return ret;
		}
		
		[Export ("userWithExternalID:delegate:")]
		[CompilerGenerated]
		public static NSObject UserWithExternalID (global::System.UInt32 userExternalID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selUserWithExternalIDDelegate_Handle, userExternalID, _delegate.Handle));
		}
		
		[Export ("userWithExternalID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UserWithExternalID (global::System.UInt32 userExternalID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selUserWithExternalIDDelegateContext_Handle, userExternalID, _delegate.Handle, context.Handle));
		}
		
		[Export ("userWithFacebookID:delegate:")]
		[CompilerGenerated]
		public static NSObject UserWithFacebookID (string userFacebookID, NSObject _delegate)
		{
			if (userFacebookID == null)
				throw new ArgumentNullException ("userFacebookID");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsuserFacebookID = NSString.CreateNative (userFacebookID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUserWithFacebookIDDelegate_Handle, nsuserFacebookID, _delegate.Handle));
			NSString.ReleaseNative (nsuserFacebookID);
			
			return ret;
		}
		
		[Export ("userWithFacebookID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UserWithFacebookID (string userFacebookID, NSObject _delegate, NSObject context)
		{
			if (userFacebookID == null)
				throw new ArgumentNullException ("userFacebookID");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsuserFacebookID = NSString.CreateNative (userFacebookID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUserWithFacebookIDDelegateContext_Handle, nsuserFacebookID, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsuserFacebookID);
			
			return ret;
		}
		
		[Export ("userWithID:delegate:")]
		[CompilerGenerated]
		public static NSObject UserWithID (global::System.UInt32 userID, NSObject _delegate)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, selUserWithIDDelegate_Handle, userID, _delegate.Handle));
		}
		
		[Export ("userWithID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UserWithID (global::System.UInt32 userID, NSObject _delegate, NSObject context)
		{
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			return  Runtime.GetNSObject<NSObject> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (class_ptr, selUserWithIDDelegateContext_Handle, userID, _delegate.Handle, context.Handle));
		}
		
		[Export ("userWithLogin:delegate:")]
		[CompilerGenerated]
		public static NSObject UserWithLogin (string userLogin, NSObject _delegate)
		{
			if (userLogin == null)
				throw new ArgumentNullException ("userLogin");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsuserLogin = NSString.CreateNative (userLogin);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUserWithLoginDelegate_Handle, nsuserLogin, _delegate.Handle));
			NSString.ReleaseNative (nsuserLogin);
			
			return ret;
		}
		
		[Export ("userWithLogin:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UserWithLogin (string userLogin, NSObject _delegate, NSObject context)
		{
			if (userLogin == null)
				throw new ArgumentNullException ("userLogin");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsuserLogin = NSString.CreateNative (userLogin);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUserWithLoginDelegateContext_Handle, nsuserLogin, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsuserLogin);
			
			return ret;
		}
		
		[Export ("userWithTwitterID:delegate:")]
		[CompilerGenerated]
		public static NSObject UserWithTwitterID (string userTwitterID, NSObject _delegate)
		{
			if (userTwitterID == null)
				throw new ArgumentNullException ("userTwitterID");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			var nsuserTwitterID = NSString.CreateNative (userTwitterID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selUserWithTwitterIDDelegate_Handle, nsuserTwitterID, _delegate.Handle));
			NSString.ReleaseNative (nsuserTwitterID);
			
			return ret;
		}
		
		[Export ("userWithTwitterID:delegate:context:")]
		[CompilerGenerated]
		public static NSObject UserWithTwitterID (string userTwitterID, NSObject _delegate, NSObject context)
		{
			if (userTwitterID == null)
				throw new ArgumentNullException ("userTwitterID");
			if (_delegate == null)
				throw new ArgumentNullException ("_delegate");
			if (context == null)
				throw new ArgumentNullException ("context");
			var nsuserTwitterID = NSString.CreateNative (userTwitterID);
			
			NSObject ret;
			ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selUserWithTwitterIDDelegateContext_Handle, nsuserTwitterID, _delegate.Handle, context.Handle));
			NSString.ReleaseNative (nsuserTwitterID);
			
			return ret;
		}
		
	} /* class QBUsers */
}
