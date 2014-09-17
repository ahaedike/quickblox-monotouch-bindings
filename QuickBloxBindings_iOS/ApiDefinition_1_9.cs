

using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.AudioToolbox;
using MonoTouch.CoreData;
using MonoTouch.AVFoundation;
using MonoTouch.Accelerate;
using MonoTouch.CoreMedia;
using MonoTouch.CoreLocation;
using MonoTouch.MobileCoreServices;
using MonoTouch.SystemConfiguration;
using MonoTouch.CoreGraphics;


namespace QuickBlox
{
	

	[Model]
	public partial interface Cancelable {

		[Export ("cancel")]
		void Cancel ();
	}



	[BaseType (typeof (NSObject))]
	[Model, Protocol]
	public interface QBActionStatusDelegate {
		
		[Export ("completedWithResult:")]
		void CompletedWithResult(Result result);

		[Export ("completedWithResult:context:")]
		void CompletedWithResultInContext (Result result, NSObject contextInfo);

		[Export ("progress")]
		float Progress { set; }

		[Export ("uploadProgress")]
		float UploadActionProgress { set; }
	}

	[Model]
	public partial interface RestRequestDelegate {

		[Export ("completedWithResponse:")]
		void  CompletedWithResponse(QBRestResponse response);

	}

	[Model]
	public partial interface Perform {

		
	}



	[BaseType (typeof (NSObject))]
	public partial interface QBAudioIOService {

		
		[Export ("inputAvailable")]
		bool InputAvailable { get; }

		[Export ("running")]
		bool Running { get; }

		[Export ("numInputChannels")]
		UInt32 NumInputChannels { get; }

		[Export ("numOutputChannels")]
		UInt32 NumOutputChannels { get; }

		[Export ("managingFromApplication")]
		bool ManagingFromApplication { get; set; }

		[Static, Export ("shared")]
		QBAudioIOService Shared { get; }

		[Export ("start")]
		void Start ();

		[Export ("stop")]
		void Stop ();

		[Export ("setupAudioSession")]
		void SetupAudioSession ();

		[Export ("routeToSpeaker")]
		void RouteToSpeaker ();

		[Export ("routeToHeadphone")]
		void RouteToHeadphone ();

		[Export ("encodePCMtoiLBC:")]
		AudioBuffer EncodePCMtoiLBC (AudioBuffer pcmData);

		[Export ("decodeiLBCtoPCM:")]
		AudioBuffer DecodeiLBCtoPCM (AudioBuffer iLBCData);

	}



	[BaseType (typeof (NSOperation))]
	public partial interface QBAFURLConnectionOperation {

		
	}

	[BaseType (typeof (QBAFURLConnectionOperation))]
	public partial interface QBAFHTTPRequestOperation {

		
	}
		

	[BaseType (typeof (NSObject))]
	public partial interface QBAFHTTPClient {


	}

	[Model]
	public partial interface QBAFMultipartFormData {

		
	}

	[BaseType (typeof (QBAFHTTPClient))]
	public partial interface QBAPIClient {

		[Static, Export ("shared")]
		QBAPIClient Shared { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface EncodeHelper {

		[Static, Export ("urlencode:")]
		string Urlencode (string unencodedString);

		[Static, Export ("urldecode:")]
		string Urldecode (string encodedString);
	}

	[BaseType (typeof (NSObject))]
	public partial interface DataHelper {

		[Static, Export ("stringFromData:encoding:")]
		string StringFromData (NSData data, NSStringEncoding encoding);

		[Static, Export ("stringFromData:")]
		string StringFromData (NSData data);

		[Static, Export ("dataFromString:encoding:")]
		NSData DataFromString (string _string, NSStringEncoding encoding);

		[Static, Export ("dataFromString:")]
		NSData DataFromString (string _string);

		[Static, Export ("parseIntFromData:")]
		uint ParseIntFromData (NSData data);

		[Static, Export ("isJPEGValid:")]
		bool IsJPEGValid (NSData jpeg);

		[Static, Export ("gzipInflate:")]
		NSData GzipInflate (NSData data);

		[Static, Export ("gzipDeflate:")]
		NSData GzipDeflate (NSData data);

		[Static, Export ("dataFromHexString:")]
		NSData DataFromHexString (string hexString);
	}

	[BaseType (typeof (NSObject))]
	public partial interface AsyncLogger {

		[Static, Export ("LogF:")]
		void LogF (string _string);
	}

	[BaseType (typeof (NSObject))]
	public partial interface AsyncCanceler : Cancelable {

		[Export ("cancelable", ArgumentSemantic.Retain)]
		NSObject Cancelable { get; set; }

		[Static, Export ("cancelerFor:")]
		AsyncCanceler CancelerFor (NSObject cancelable);
	}

	[BaseType (typeof (NSObject))]
	public partial interface SignHelper {

		[Static, Export ("signData:withSecret:")]
		string SignData (NSData data, string secret);

		[Static, Export ("signClearText:withSecret:")]
		string SignClearText (string text, string secret);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBArrayToStringHelper {

		[Static, Export ("convert:")]
		string Convert (NSObject [] array);
	}

	[BaseType (typeof (NSObject))]
	public partial interface DateTimeHelper {

		[Static, Export ("dateFromISO8601:")]
		NSDate DateFromISO8601 (string str);

		[Static, Export ("dateFromQBTokenHeader:")]
		NSDate DateFromQBTokenHeader (string str);
	}

	[BaseType (typeof (NSObject))]
	public partial interface Performer : Perform, Cancelable {

		[Export ("delegate", ArgumentSemantic.Retain)]
		NSObject Delegate { get; set; }

		[Export ("canceler", ArgumentSemantic.Retain)]
		NSObject Canceler { get; set; }


		[Export ("context", ArgumentSemantic.Retain)]
		NSObject Context { get; set; }
	}

	[Category, BaseType (typeof (Performer))]
	public partial interface ActionPerform_Performer {

		[Export ("performInBgAsyncWithDelegate:")]
		void PerformInBgAsyncWithDelegate (NSObject _delegate);

		[Export ("actionInBg")]
		void ActionInBg ();

		[Export ("prepare")]
		void Prepare ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface FileParameter {

		[Export ("paramName", ArgumentSemantic.Retain)]
		string ParamName { get; set; }

		[Export ("fileName", ArgumentSemantic.Retain)]
		string FileName { get; set; }

		[Export ("filePath", ArgumentSemantic.Retain)]
		string FilePath { get; set; }

		[Export ("contentType", ArgumentSemantic.Retain)]
		string ContentType { get; set; }

		[Export ("fileData", ArgumentSemantic.Retain)]
		NSData FileData { get; set; }

		[Export ("type")]
		FileParameterType Type { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface Entity {

		[Export ("ID")]
		uint ID { get; set; }

		[Export ("createdAt", ArgumentSemantic.Retain)]
		NSDate CreatedAt { get; set; }

		[Export ("updatedAt", ArgumentSemantic.Retain)]
		NSDate UpdatedAt { get; set; }
	}



	[BaseType (typeof (NSObject))]
	public partial interface QBSettings {

		[Static, Export ("applicationID")]
		uint ApplicationID { get; set; }

		[Static, Export ("authorizationKey")]
		string AuthorizationKey { get; set; }

		[Static, Export ("authorizationSecret")]
		string AuthorizationSecret { get; set; }

		[Static, Export ("accountKey")]
		string AccountKey { get; set; }

		[Static, Export ("serverApiDomain")]
		string ServerApiDomain { get; set; }

		[Static, Export ("serverChatDomain")]
		string ServerChatDomain { get; set; }

		[Static, Export ("tURNServerDomain")]
		string TURNServerDomain { get; set; }

		[Static, Export ("contentBucket")]
		string ContentBucket { get; set; }

		[Static, Export ("useHTTPS:")]
		void UseHTTPS (bool useHTTPS);

		[Static, Export ("isUseHTTPS")]
		bool IsUseHTTPS { get; }

		[Static, Export ("useTLSForChat:")]
		void UseTLSForChat (bool useTLSForChat);

		[Static, Export ("isUseTLSForChat")]
		bool IsUseTLSForChat { get; }

		[Static, Export ("chatSOCKS5ProxyHost")]
		string ChatSOCKS5ProxyHost { get; set; }

		[Static, Export ("chatSOCKS5ProxyPort")]
		uint ChatSOCKS5ProxyPort { get; set; }

		[Static, Export ("logLevel")]
		QBLogLevel LogLevel { get; set; }

		[Static, Export ("timeOutSeconds")]
		int TimeOutSeconds { get; set; }

		[Static, Export ("restAPIVersion")]
		string RestAPIVersion { get; set; }

		[Static, Export ("enableSessionExpirationAutoHandler:")]
		void EnableSessionExpirationAutoHandler (bool isEnable);

		[Static, Export ("isEnabledSessionExpirationAutoHandler")]
		bool IsEnabledSessionExpirationAutoHandler { get; }

		[Static, Export ("useProductionEnvironmentForPushNotifications:")]
		void UseProductionEnvironmentForPushNotifications (bool useProductionEnvironment);

		[Static, Export ("isUseProductionEnvironmentForPushNotifications")]
		bool IsUseProductionEnvironmentForPushNotifications { get; }

		[Static, Export ("videoChatConfiguration")]
		NSDictionary VideoChatConfiguration { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBRestRequest : Cancelable {

		[Export ("method")]
		RestMethodKind Method { get; set; }

		[Export ("delegate", ArgumentSemantic.Retain)]
		NSObject Delegate { get; set; }

		[Export ("URL", ArgumentSemantic.Retain)]
		NSUrl URL { get; set; }

		[Export ("headers", ArgumentSemantic.Retain)]
		NSDictionary Headers { get; set; }

		[Export ("parameters", ArgumentSemantic.Retain)]
		NSDictionary Parameters { get; set; }

		[Export ("files", ArgumentSemantic.Retain)]
		NSObject [] Files { get; set; }

		[Export ("rawBodyWithoutEncode")]
		NSData RawBodyWithoutEncode { get; }

		[Export ("httpMethod")]
		string HttpMethod { get; }

		[Export ("finalURL")]
		string FinalURL { get; }


		[Export ("canceler", ArgumentSemantic.Retain)]
		NSObject Canceler { get; set; }

		[Export ("buildStyle")]
		RestRequestBuildStyle BuildStyle { get; set; }

		[Export ("asyncRequestWithdelegate:")]
		void AsyncRequestWithdelegate (NSObject _delegate);

	}

	[BaseType (typeof (NSObject))]
	public partial interface QBRestResponse {

		[Export ("responseObject")]
		NSObject ResponseObject { get; }

		[Export ("responseObjectAsString")]
		string ResponseObjectAsString { get; }

		[Export ("AFHTTPRequestOperation")]
		NSObject AFHTTPRequestOperation { get; }

		[Export ("error")]
		NSError Error { get; }

		[Export ("status")]
		uint Status { get; }

		[Export ("headers")]
		NSDictionary Headers { get; }

		[Export ("responseType")]
		RestResponseType ResponseType { get; }

		[Export ("contentType")]
		string ContentType { get; }

		[Export ("encoding")]
		NSStringEncoding Encoding { get; }

		[Export ("initWithResponseObject:AFHTTPRequestOperation:error:")]
		IntPtr Constructor (NSObject responseObject, QBAFHTTPRequestOperation AFHTTPRequestOperation, NSError error);
	}

	[BaseType (typeof (NSObject))]
	public partial interface Answer {

		[Export ("errors", ArgumentSemantic.Retain)]
		NSMutableArray Errors { get; set; }

		[Export ("query", ArgumentSemantic.Assign)]
		QBQuery Query { get; set; }

		[Export ("allocResult")]
		Result AllocResult { get; }
	}

	[BaseType (typeof (Answer))]
	public partial interface RestAnswer {

		[Export ("kind")]
		RestAnswerKind Kind { get; }

		[Export ("response")]
		QBRestResponse Response { get; }

		[Export ("initWithResponse:")]
		IntPtr Constructor (QBRestResponse response);

		[Export ("load")]
		void Load ();
	}

	[BaseType (typeof (RestAnswer))]
	public partial interface XmlAnswer {

		[Export ("elements", ArgumentSemantic.Retain)]
		NSMutableArray Elements { get; set; }

		[Export ("currentElement")]
		string CurrentElement { get; }

		[Export ("prevElement")]
		string PrevElement { get; }

		[Export ("prevPrevElement")]
		string PrevPrevElement { get; }

		[Export ("prevPrevPrevElement")]
		string PrevPrevPrevElement { get; }

		[Export ("prevPrevPrevPrevElement")]
		string PrevPrevPrevPrevElement { get; }

		[Export ("prevPrevPrevPrevPrevElement")]
		string PrevPrevPrevPrevPrevElement { get; }

		[Export ("encodeEncoding")]
		NSStringEncoding EncodeEncoding { get; set; }

		[Export ("decodeEncoding")]
		NSStringEncoding DecodeEncoding { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		XmlAnswer Delegate { get; set; }

		[Static, Export ("defaultEncodeEncoding")]
		NSStringEncoding DefaultEncodeEncoding { get; }

		[Static, Export ("defaultDecodeEncoding")]
		NSStringEncoding DefaultDecodeEncoding { get; }

		[Export ("LoadFromUrl:parseError:")]
		NSObject LoadFromUrl (NSUrl URL, out NSError error);

		[Export ("loadString:encoding:parseError:")]
		NSObject LoadString (string xmlString, NSStringEncoding encoding, out NSError error);

		[Export ("loadString:parseError:")]
		NSObject LoadString (string xmlString, out NSError error);

		[Export ("loadData:parseError:")]
		NSObject LoadData (NSData data, out NSError error);

		[Export ("handleElement:attributes:")]
		void HandleElement (string elementName, NSDictionary attributeDict);

		[Export ("handleEndOfElement:")]
		void HandleEndOfElement (string elementName);

		[Export ("handleText:currentElement:")]
		void HandleText (string text, string element);

		[Export ("handleData:currentElement:")]
		void HandleData (NSData data, string element);
	}

	[BaseType (typeof (XmlAnswer))]
	public partial interface BinaryAnswer {

		[Export ("loadedData")]
		NSData LoadedData { get; }
	}

	[BaseType (typeof (XmlAnswer))]
	public partial interface PagedAnswer {

		[Export ("currentPage")]
		uint CurrentPage { get; set; }

		[Export ("perPage")]
		uint PerPage { get; set; }

		[Export ("totalEntries")]
		uint TotalEntries { get; set; }
	}

	[BaseType (typeof (RestAnswer))]
	public partial interface SocialLoginAnswer {

		[Export ("session", ArgumentSemantic.Retain)]
		NSObject Session { get; set; }

		[Export ("user", ArgumentSemantic.Retain)]
		NSObject User { get; set; }

		[Export ("socialProviderToken", ArgumentSemantic.Retain)]
		string SocialProviderToken { get; set; }

		[Export ("socialProviderTokenExpiresAt", ArgumentSemantic.Retain)]
		NSDate SocialProviderTokenExpiresAt { get; set; }

		[Export ("returnResult")]
		void ReturnResult ();

		[Export ("populateAnswer:headers:")]
		void PopulateAnswer (string responce, NSDictionary headers);
	}

	[BaseType (typeof (XmlAnswer))]
	public partial interface EntityAnswer {

		[Export ("entity", ArgumentSemantic.Retain)]
		Entity Entity { get; set; }


		[Static, Export ("entityClass")]
		Class EntityClass { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBQuery : Perform, RestRequestDelegate, Cancelable, QBActionStatusDelegate {

		[Export ("delegate", ArgumentSemantic.Retain)]
		NSObject Delegate { get; set; }

		[Export ("canceler", ArgumentSemantic.Retain)]
		NSObject Canceler { get; set; }



		[Export ("context", ArgumentSemantic.Retain)]
		NSObject Context { get; set; }

		[Export ("requestBuildStyle")]
		RestRequestBuildStyle RequestBuildStyle { get; set; }

		[Export ("allocAnswer")]
		RestAnswer AllocAnswer { get; }

		[Export ("url")]
		string Url { get; set; }

		[Export ("finishedSuccess")]
		void FinishedSuccess ();

		[Export ("upRequest")]
		QBRestRequest upRequest { set; }

		[Export ("body")]
		QBRestRequest Body { set; }

		[Export ("params")]
		QBRestRequest Params { set; }

		[Export ("headers")]
		QBRestRequest Headers { set; }

		[Export ("method")]
		QBRestRequest Method { set; }

		[Export ("files")]
		QBRestRequest Files { set; }
	}




	[BaseType (typeof (NSObject))]
	public partial interface Request {

		[Export ("parameters")]
		NSDictionary Parameters { get; }

		[Static, Export ("request")]
		Request CreateRequest ();

	}

	[BaseType (typeof (Request))]
	public partial interface PagedRequest {

		[Export ("page")]
		uint Page { get; set; }

		[Export ("perPage")]
		uint PerPage { get; set; }
	}


	[BaseType (typeof (NSObject))]
	public partial interface Result {

		[Export ("errors")]
		NSObject [] Errors { get; }

		[Export ("success")]
		bool Success { get; }

		[Export ("status")]
		uint Status { get; }

		[Export ("request", ArgumentSemantic.Retain)]
		Request Request { get; set; }

		[Export ("answer", ArgumentSemantic.Retain)]
		Answer Answer { get; set; }

		[Export ("initWithRequest:answer:")]
		IntPtr Constructor (Request req, Answer answ);

		[Export ("initWithAnswer:")]
		IntPtr Constructor (Answer answ);
	}



	[BaseType (typeof (Result))]
	public partial interface TaskResult {

		[Export ("errorsList", ArgumentSemantic.Retain)]
		NSMutableArray ErrorsList { get; set; }

		[Export ("failedResult", ArgumentSemantic.Retain)]
		Result FailedResult { get; set; }

		[Static, Export ("failedWithResult:")]
		TaskResult FailedWithResult (Result result);
	}

	[BaseType (typeof (Result))]
	public partial interface PagedResult {

		[Export ("currentPage")]
		uint CurrentPage { get; }

		[Export ("totalPages")]
		uint TotalPages { get; }

		[Export ("perPage")]
		uint PerPage { get; }

		[Export ("totalEntries")]
		uint TotalEntries { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface BinaryResult {

		[Export ("data")]
		NSData Data { get; }
	}

	[BaseType (typeof (Performer))]
	public partial interface Task : QBActionStatusDelegate {

		[Export ("itemsCount")]
		uint ItemsCount { get; set; }

		[Export ("currentItem")]
		uint CurrentItem { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBBaseModule {

		[Export ("token", ArgumentSemantic.Retain)]
		string Token { get; set; }

		[Export ("tokenExpirationDate", ArgumentSemantic.Retain)]
		NSDate TokenExpirationDate { get; set; }

		[Export ("sessionType")]
		QBSessionType SessionType { get; set; }

		[Export ("sessionCreationRequest", ArgumentSemantic.Retain)]
		QBASessionCreationRequest SessionCreationRequest { get; set; }

		[Static, Export ("createSharedModule")]
		void CreateSharedModule ();

		[Static, Export ("sharedModule")]
		QBBaseModule SharedModule { get; }

		[Export ("reset")]
		void Reset ();

		[Static, Export ("serverEndpointURL")]
		string ServerEndpointURL { get; }

		[Static, Export ("chatServerEndpointURL")]
		string ChatServerEndpointURL { get; }

		[Static, Export ("chatMUCServerEndpointURL")]
		string ChatMUCServerEndpointURL { get; }

		[Static, Export ("contentBucketName")]
		string ContentBucketName { get; }

		[Static, Export ("turnServerEndpointURL")]
		string TurnServerEndpointURL { get; }
	}

	[BaseType (typeof (UIView))]
	public partial interface QBSocialLoginDialog  {

		[Export ("answer", ArgumentSemantic.Retain)]
		SocialLoginAnswer Answer { get; set; }

		[Export ("request")]
		Request Request { get; }

		[Export ("operation")]
		NSObject Operation { get; }

		[Export ("showWithHTML:andBaseURL:")]
		void ShowWithHTML (string html, NSUrl baseURL);

		[Export ("hide")]
		void Hide ();
	}



	[BaseType (typeof (Entity))]
	public partial interface QBASession {

		[Export ("token", ArgumentSemantic.Retain)]
		string Token { get; set; }

		[Export ("applicationID")]
		uint ApplicationID { get; set; }

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("deviceID")]
		uint DeviceID { get; set; }

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("nonce")]
		int Nonce { get; set; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBAAuthSessionCreationResult {

		[Export ("session")]
		QBASession Session { get; }

		[Export ("token")]
		string Token { get; }

		[Export ("socialProviderToken")]
		string SocialProviderToken { get; }

		[Export ("socialProviderTokenExpiresAt")]
		NSDate SocialProviderTokenExpiresAt { get; }
	}

	[BaseType (typeof (Answer))]
	public partial interface QBAAuthSessionCreationAnswer {

		[Export ("session")]
		QBASession Session { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBASessionCreationQuery {

		[Export ("sessionCreationRequest")]
		QBASessionCreationRequest SessionCreationRequest { get; }

		[Export ("initWithRequest:")]
		IntPtr Constructor (QBASessionCreationRequest _sessionCreationRequest);

		[Export ("signRequest:")]
		void SignRequest (QBRestRequest request);
	}

	[BaseType (typeof (Request))]
	public partial interface QBASessionCreationRequest {

		[Export ("socialProvider", ArgumentSemantic.Retain)]
		string SocialProvider { get; set; }

		[Export ("scope", ArgumentSemantic.Retain)]
		NSObject [] Scope { get; set; }

		[Export ("socialProviderAccessToken", ArgumentSemantic.Retain)]
		string SocialProviderAccessToken { get; set; }

		[Export ("socialProviderAccessTokenSecret", ArgumentSemantic.Retain)]
		string SocialProviderAccessTokenSecret { get; set; }

		[Export ("userLogin", ArgumentSemantic.Retain)]
		string UserLogin { get; set; }

		[Export ("userEmail", ArgumentSemantic.Retain)]
		string UserEmail { get; set; }

		[Export ("userPassword", ArgumentSemantic.Retain)]
		string UserPassword { get; set; }

		[Static, Export ("request")]
		QBASessionCreationRequest CreateRequest ();
	}

	[BaseType (typeof (QBBaseModule))]
	public partial interface QBAuth {

		[Static, Export ("createSessionWithDelegate:")]
		NSObject CreateSessionWithDelegate (QBActionStatusDelegate _delegate);

		[Static, Export ("createSessionWithDelegate:context:")]
		NSObject CreateSessionWithDelegate (QBActionStatusDelegate _delegate, NSObject context);

		[Static, Export ("createSessionWithExtendedRequest:delegate:")]
		NSObject CreateSessionWithExtendedRequest (Request extendedRequest, QBActionStatusDelegate _delegate);

		[Static, Export ("createSessionWithExtendedRequest:delegate:context:")]
		NSObject CreateSessionWithExtendedRequest (Request extendedRequest, QBActionStatusDelegate _delegate, NSObject context);

		[Static, Export ("destroySessionWithDelegate:")]
		NSObject DestroySessionWithDelegate (QBActionStatusDelegate _delegate);

		[Static, Export ("destroySessionWithDelegate:context:")]
		NSObject DestroySessionWithDelegate (QBActionStatusDelegate _delegate, NSObject context);
	}

	[BaseType (typeof (Entity))]
	public partial interface QBUUser {

		[Export ("externalUserID")]
		uint ExternalUserID { get; set; }

		[Export ("blobID")]
		int BlobID { get; set; }

		[Export ("facebookID", ArgumentSemantic.Retain)]
		string FacebookID { get; set; }

		[Export ("twitterID", ArgumentSemantic.Retain)]
		string TwitterID { get; set; }

		[Export ("fullName", ArgumentSemantic.Retain)]
		string FullName { get; set; }

		[Export ("email", ArgumentSemantic.Retain)]
		string Email { get; set; }

		[Export ("login", ArgumentSemantic.Retain)]
		string Login { get; set; }

		[Export ("phone", ArgumentSemantic.Retain)]
		string Phone { get; set; }

		[Export ("website", ArgumentSemantic.Retain)]
		string Website { get; set; }

		[Export ("tags", ArgumentSemantic.Retain)]
		NSMutableArray Tags { get; set; }

		[Export ("password", ArgumentSemantic.Retain)]
		string Password { get; set; }

		[Export ("oldPassword", ArgumentSemantic.Retain)]
		string OldPassword { get; set; }

		[Export ("lastRequestAt", ArgumentSemantic.Retain)]
		NSDate LastRequestAt { get; set; }

		[Export ("customData", ArgumentSemantic.Retain)]
		string CustomData { get; set; }

		[Static, Export ("user")]
		QBUUser User { get; }
	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBUUserAnswer {

		[Export ("user")]
		QBUUser User { get; }
	}

	[BaseType (typeof (PagedAnswer))]
	public partial interface QBUUserPagedAnswer {

		[Export ("users", ArgumentSemantic.Retain)]
		NSMutableArray Users { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBUUserQuery {
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserLogInQuery {

		[Export ("user", ArgumentSemantic.Retain)]
		QBUUser User { get; set; }

		[Export ("socialProvider", ArgumentSemantic.Retain)]
		string SocialProvider { get; set; }

		[Export ("socialProviderScope", ArgumentSemantic.Retain)]
		NSObject [] SocialProviderScope { get; set; }

		[Export ("socialProviderAccessToken", ArgumentSemantic.Retain)]
		string SocialProviderAccessToken { get; set; }

		[Export ("socialProviderAccessTokenSecret", ArgumentSemantic.Retain)]
		string SocialProviderAccessTokenSecret { get; set; }

		[Export ("initWithQBUUser:")]
		IntPtr Constructor (QBUUser user);

		[Export ("initWithSocialProvider:andScope:")]
		IntPtr Constructor (string socialProvider, NSObject [] scope);

		[Export ("initWithSocialProvider:accessToken:accessTokenSecret:")]
		IntPtr Constructor (string socialProvider, string accessToken, string accessTokenSecret);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserCreateQuery {

		[Export ("user", ArgumentSemantic.Retain)]
		QBUUser User { get; set; }

		[Export ("initWithUser:")]
		IntPtr Constructor (QBUUser _user);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUGetUsersQuery {

		[Export ("pagedRequest", ArgumentSemantic.Retain)]
		PagedRequest PagedRequest { get; set; }

		[Export ("ids", ArgumentSemantic.Retain)]
		string Ids { get; set; }

		[Export ("logins", ArgumentSemantic.Retain)]
		NSObject [] Logins { get; set; }

		[Export ("emails", ArgumentSemantic.Retain)]
		NSObject [] Emails { get; set; }

		[Export ("phoneNumbers", ArgumentSemantic.Retain)]
		NSObject [] PhoneNumbers { get; set; }

		[Export ("facebookIDs", ArgumentSemantic.Retain)]
		NSObject [] FacebookIDs { get; set; }

		[Export ("twitterIDs", ArgumentSemantic.Retain)]
		NSObject [] TwitterIDs { get; set; }

		[Export ("extendedRequest", ArgumentSemantic.Retain)]
		NSDictionary ExtendedRequest { get; set; }

		[Export ("initWithRequest:")]
		IntPtr Constructor (PagedRequest _pagedRequest);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserGetByIDQuery {

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("initWithUserID:")]
		IntPtr Constructor (uint userID);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserGetByLoginQuery {

		[Export ("userLogin", ArgumentSemantic.Retain)]
		string UserLogin { get; set; }

		[Export ("initWithUserLogin:")]
		IntPtr Constructor (string userLogin);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUsersGetByFullnameQuery {

		[Export ("userFullName", ArgumentSemantic.Retain)]
		string UserFullName { get; set; }

		[Export ("pagedRequest", ArgumentSemantic.Retain)]
		PagedRequest PagedRequest { get; set; }

		[Export ("initWithUserFullName:")]
		IntPtr Constructor (string _userFullName);

		[Export ("initWithUserFullName:pagedRequest:")]
		IntPtr Constructor (string _userFullName, PagedRequest _pagedRequest);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserGetByFacebookIDQuery {

		[Export ("userFacebookID", ArgumentSemantic.Retain)]
		string UserFacebookID { get; set; }

		[Export ("initWithUserFacebookID:")]
		IntPtr Constructor (string userFacebookID);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserGetByTwitterIDQuery {

		[Export ("userTwitterID", ArgumentSemantic.Retain)]
		string UserTwitterID { get; set; }

		[Export ("initWithUserTwitterID:")]
		IntPtr Constructor (string userTwitterID);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserGetByEmailQuery {

		[Export ("userEmail", ArgumentSemantic.Retain)]
		string UserEmail { get; set; }

		[Export ("initWithUserEmail:")]
		IntPtr Constructor (string userEmail);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUsersGetByTagsQuery {

		[Export ("tags", ArgumentSemantic.Retain)]
		NSObject [] Tags { get; set; }

		[Export ("pagedRequest", ArgumentSemantic.Retain)]
		PagedRequest PagedRequest { get; set; }

		[Export ("initWithTags:")]
		IntPtr Constructor (NSObject [] _tags);

		[Export ("initWithTags:pagedRequest:")]
		IntPtr Constructor (NSObject [] _tags, PagedRequest _pagedRequest);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserGetByExternalIDQuery {

		[Export ("externalUserID")]
		uint ExternalUserID { get; set; }

		[Export ("initWithExternalUserID:")]
		IntPtr Constructor (uint externalUserID);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserUpdateQuery {

		[Export ("user", ArgumentSemantic.Retain)]
		QBUUser User { get; set; }

		[Export ("initWithUser:")]
		IntPtr Constructor (QBUUser tuser);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserDeleteByIDQuery {

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("initWithUserID:")]
		IntPtr Constructor (uint userID);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserDeleteByExternalIDQuery {

		[Export ("externalUserID")]
		uint ExternalUserID { get; set; }

		[Export ("initWithExternalUserID:")]
		IntPtr Constructor (uint externalUserID);
	}

	[BaseType (typeof (QBUUserQuery))]
	public partial interface QBUUserResetPasswordQuery {

		[Export ("email", ArgumentSemantic.Retain)]
		string Email { get; set; }

		[Export ("initWithEmail:")]
		IntPtr Constructor (string email);
	}

	[BaseType (typeof (Result))]
	public partial interface QBUUserResult {

		[Export ("user")]
		QBUUser User { get; }
	}

	[BaseType (typeof (PagedResult))]
	public partial interface QBUUserPagedResult {

		[Export ("users")]
		NSObject [] Users { get; }
	}

	[BaseType (typeof (QBUUserResult))]
	public partial interface QBUUserLogInResult {

		[Export ("socialProviderToken")]
		string SocialProviderToken { get; }

		[Export ("socialProviderTokenExpiresAt")]
		NSDate SocialProviderTokenExpiresAt { get; }
	}

	[BaseType (typeof (QBBaseModule))]
	public partial interface QBUsers {

		[Static, Export ("logInWithUserLogin:password:delegate:")]
		NSObject LogInWithUserLogin (string login, string password, NSObject _delegate);

		[Static, Export ("logInWithUserLogin:password:delegate:context:")]
		NSObject LogInWithUserLogin (string login, string password, NSObject _delegate, NSObject context);

		[Static, Export ("logInWithUserEmail:password:delegate:")]
		NSObject LogInWithUserEmail (string email, string password, NSObject _delegate);

		[Static, Export ("logInWithUserEmail:password:delegate:context:")]
		NSObject LogInWithUserEmail (string email, string password, NSObject _delegate, NSObject context);

		[Static, Export ("logInWithSocialProvider:scope:delegate:")]
		NSObject LogInWithSocialProvider (string provider, NSObject [] scope, NSObject _delegate);

		[Static, Export ("logInWithSocialProvider:scope:delegate:context:")]
		NSObject LogInWithSocialProvider (string provider, NSObject [] scope, NSObject _delegate, NSObject context);

		[Static, Export ("logInWithSocialProvider:accessToken:accessTokenSecret:delegate:")]
		NSObject LogInWithSocialProvider (string provider, string accessToken, string accessTokenSecret, NSObject _delegate);

		[Static, Export ("logInWithSocialProvider:accessToken:accessTokenSecret:delegate:context:")]
		NSObject LogInWithSocialProvider (string provider, string accessToken, string accessTokenSecret, NSObject _delegate, NSObject context);

		[Static, Export ("logOutWithDelegate:")]
		NSObject LogOutWithDelegate (NSObject _delegate);

		[Static, Export ("logOutWithDelegate:context:")]
		NSObject LogOutWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("usersWithDelegate:")]
		NSObject UsersWithDelegate (NSObject _delegate);

		[Static, Export ("usersWithDelegate:context:")]
		NSObject UsersWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("usersWithPagedRequest:delegate:")]
		NSObject UsersWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("usersWithPagedRequest:delegate:context:")]
		NSObject UsersWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithExtendedRequest:delegate:")]
		NSObject UsersWithExtendedRequest (NSDictionary extendedRequest, NSObject _delegate);

		[Static, Export ("usersWithExtendedRequest:delegate:context:")]
		NSObject UsersWithExtendedRequest (NSDictionary extendedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("signUp:delegate:")]
		NSObject SignUp (QBUUser user, NSObject _delegate);

		[Static, Export ("signUp:delegate:context:")]
		NSObject SignUp (QBUUser user, NSObject _delegate, NSObject context);

		[Static, Export ("userWithID:delegate:")]
		NSObject UserWithID (uint userID, NSObject _delegate);

		[Static, Export ("userWithID:delegate:context:")]
		NSObject UserWithID (uint userID, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithIDs:delegate:")]
		NSObject UsersWithIDs (string ids, NSObject _delegate);

		[Static, Export ("usersWithIDs:delegate:context:")]
		NSObject UsersWithIDs (string ids, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithIDs:pagedRequest:delegate:")]
		NSObject UsersWithIDs (string ids, PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("usersWithIDs:pagedRequest:delegate:context:")]
		NSObject UsersWithIDs (string ids, PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("userWithLogin:delegate:")]
		NSObject UserWithLogin (string userLogin, NSObject _delegate);

		[Static, Export ("userWithLogin:delegate:context:")]
		NSObject UserWithLogin (string userLogin, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithLogins:delegate:")]
		NSObject UsersWithLogins (NSObject [] logins, NSObject _delegate);

		[Static, Export ("usersWithLogins:delegate:context:")]
		NSObject UsersWithLogins (NSObject [] logins, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithLogins:pagedRequest:delegate:")]
		NSObject UsersWithLogins (NSObject [] logins, PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("usersWithLogins:pagedRequest:delegate:context:")]
		NSObject UsersWithLogins (NSObject [] logins, PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithFullName:delegate:")]
		NSObject UsersWithFullName (string userFullName, NSObject _delegate);

		[Static, Export ("usersWithFullName:delegate:context:")]
		NSObject UsersWithFullName (string userFullName, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithFullName:pagedRequest:delegate:")]
		NSObject UsersWithFullName (string userFullName, PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("usersWithFullName:pagedRequest:delegate:context:")]
		NSObject UsersWithFullName (string userFullName, PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithTags:delegate:")]
		NSObject UsersWithTags (NSObject [] tags, NSObject _delegate);

		[Static, Export ("usersWithTags:delegate:context:")]
		NSObject UsersWithTags (NSObject [] tags, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithTags:pagedRequest:delegate:")]
		NSObject UsersWithTags (NSObject [] tags, PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("usersWithTags:pagedRequest:delegate:context:")]
		NSObject UsersWithTags (NSObject [] tags, PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithPhoneNumbers:delegate:")]
		NSObject UsersWithPhoneNumbers (NSObject [] phoneNumbers, NSObject _delegate);

		[Static, Export ("usersWithPhoneNumbers:delegate:context:")]
		NSObject UsersWithPhoneNumbers (NSObject [] phoneNumbers, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithPhoneNumbers:pagedRequest:delegate:")]
		NSObject UsersWithPhoneNumbers (NSObject [] phoneNumbers, PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("usersWithPhoneNumbers:pagedRequest:delegate:context:")]
		NSObject UsersWithPhoneNumbers (NSObject [] phoneNumbers, PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("userWithFacebookID:delegate:")]
		NSObject UserWithFacebookID (string userFacebookID, NSObject _delegate);

		[Static, Export ("userWithFacebookID:delegate:context:")]
		NSObject UserWithFacebookID (string userFacebookID, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithFacebookIDs:delegate:")]
		NSObject UsersWithFacebookIDs (NSObject [] facebookIDs, NSObject _delegate);

		[Static, Export ("usersWithFacebookIDs:delegate:context:")]
		NSObject UsersWithFacebookIDs (NSObject [] facebookIDs, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithFacebookIDs:pagedRequest:delegate:")]
		NSObject UsersWithFacebookIDs (NSObject [] facebookIDs, PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("usersWithFacebookIDs:pagedRequest:delegate:context:")]
		NSObject UsersWithFacebookIDs (NSObject [] facebookIDs, PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("userWithTwitterID:delegate:")]
		NSObject UserWithTwitterID (string userTwitterID, NSObject _delegate);

		[Static, Export ("userWithTwitterID:delegate:context:")]
		NSObject UserWithTwitterID (string userTwitterID, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithTwitterIDs:delegate:")]
		NSObject UsersWithTwitterIDs (NSObject [] twitterIDs, NSObject _delegate);

		[Static, Export ("usersWithTwitterIDs:delegate:context:")]
		NSObject UsersWithTwitterIDs (NSObject [] twitterIDs, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithTwitterIDs:pagedRequest:delegate:")]
		NSObject UsersWithTwitterIDs (NSObject [] twitterIDs, PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("usersWithTwitterIDs:pagedRequest:delegate:context:")]
		NSObject UsersWithTwitterIDs (NSObject [] twitterIDs, PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("userWithEmail:delegate:")]
		NSObject UserWithEmail (string userEmail, NSObject _delegate);

		[Static, Export ("userWithEmail:delegate:context:")]
		NSObject UserWithEmail (string userEmail, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithEmails:delegate:")]
		NSObject UsersWithEmails (NSObject [] emails, NSObject _delegate);

		[Static, Export ("usersWithEmails:delegate:context:")]
		NSObject UsersWithEmails ( NSObject [] emails, NSObject _delegate, NSObject context);

		[Static, Export ("usersWithEmails:pagedRequest:delegate:")]
		NSObject UsersWithEmails (NSObject [] emails, PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("usersWithEmails:pagedRequest:delegate:context:")]
		NSObject UsersWithEmails (NSObject [] emails, PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("userWithExternalID:delegate:")]
		NSObject UserWithExternalID (uint userExternalID, NSObject _delegate);

		[Static, Export ("userWithExternalID:delegate:context:")]
		NSObject UserWithExternalID (uint userExternalID, NSObject _delegate, NSObject context);

		[Static, Export ("updateUser:delegate:")]
		NSObject UpdateUser (QBUUser user, NSObject _delegate);

		[Static, Export ("updateUser:delegate:context:")]
		NSObject UpdateUser (QBUUser user, NSObject _delegate, NSObject context);

		[Static, Export ("deleteUserWithID:delegate:")]
		NSObject DeleteUserWithID (uint userID, NSObject _delegate);

		[Static, Export ("deleteUserWithID:delegate:context:")]
		NSObject DeleteUserWithID (uint userID, NSObject _delegate, NSObject context);

		[Static, Export ("deleteUserWithExternalID:delegate:")]
		NSObject DeleteUserWithExternalID (uint userExternalID, NSObject _delegate);

		[Static, Export ("deleteUserWithExternalID:delegate:context:")]
		NSObject DeleteUserWithExternalID (uint userExternalID, NSObject _delegate, NSObject context);

		[Static, Export ("resetUserPasswordWithEmail:delegate:")]
		NSObject ResetUserPasswordWithEmail (string email, NSObject _delegate);

		[Static, Export ("resetUserPasswordWithEmail:delegate:context:")]
		NSObject ResetUserPasswordWithEmail (string email, NSObject _delegate, NSObject context);
	}



	[BaseType (typeof (NSObject))]
	public partial interface QBLGPConst {

		[Static, Export ("coordinateWithLatitude:longitude:")]
		CLLocationCoordinate2D CoordinateWithLatitude (float latitude, float longitude);

		[Static, Export ("coordinate:isEqualTo:")]
		bool Coordinate (CLLocationCoordinate2D coordinate1, CLLocationCoordinate2D coRestRequestBuildStyleordinate2);

	}

	[BaseType (typeof (NSObject))]
	public partial interface QBLLocationDataSource  {

		[Export ("currentLocation")]
		CLLocation CurrentLocation { get; }

		[Export ("locationManager")]
		CLLocationManager LocationManager { get; }

		[Export ("locationAvailable")]
		bool LocationAvailable { get; }

		[Static, Export ("instance")]
		QBLLocationDataSource Instance { get; }

		[Export ("setActionForLocationUpdate:target:")]
		void SetActionForLocationUpdate (Selector action, NSObject target);

		[Export ("distanceFilter")]
		float DistanceFilter { set; }

		[Export ("desiredAccuracy")]
		float DesiredAccuracy { set; }
	}

	[BaseType (typeof (Entity))]
	public partial interface QBLGeoData {

		[Export ("latitude")]
		double Latitude { get; set; }

		[Export ("longitude")]
		double Longitude { get; set; }

		[Export ("status", ArgumentSemantic.Retain)]
		string Status { get; set; }

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("user", ArgumentSemantic.Retain)]
		QBUUser User { get; set; }

		[Export ("applicationID")]
		uint ApplicationID { get; set; }

		[Export ("createdAtTimestamp")]
		uint CreatedAtTimestamp { get; set; }

		[Static, Export ("geoData")]
		QBLGeoData GeoData { get; }

		[Static, Export ("currentGeoData")]
		QBLGeoData CurrentGeoData { get; }

		[Export ("location")]
		CLLocation Location { get; }
	}

	[BaseType (typeof (Entity))]
	public partial interface QBLPlace {

		[Export ("latitude")]
		double Latitude { get; set; }

		[Export ("longitude")]
		double Longitude { get; set; }

		[Export ("address", ArgumentSemantic.Retain)]
		string Address { get; set; }

		[Export ("placeDescription", ArgumentSemantic.Retain)]
		string PlaceDescription { get; set; }

		[Export ("title", ArgumentSemantic.Retain)]
		string Title { get; set; }

		[Export ("geoDataID")]
		uint GeoDataID { get; set; }

		[Export ("photoID")]
		uint PhotoID { get; set; }

		[Static, Export ("place")]
		QBLPlace Place { get; }
	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBLGeoDataAnswer {

		[Export ("geoData")]
		QBLGeoData GeoData { get; }
	}

	[BaseType (typeof (PagedAnswer))]
	public partial interface QBLGeoDataPagedAnswer {

		[Export ("geodata", ArgumentSemantic.Retain)]
		NSMutableArray Geodata { get; set; }
	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBLPlaceAnswer {

		[Export ("place")]
		QBLPlace Place { get; }
	}

	[BaseType (typeof (PagedAnswer))]
	public partial interface QBLPlacePagedAnswer {

		[Export ("places", ArgumentSemantic.Retain)]
		NSMutableArray Places { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBLGeoDataQuery {

	}

	[BaseType (typeof (QBLGeoDataQuery))]
	public partial interface QBLGeoDataCreateQuery {

		[Export ("geodata")]
		QBLGeoData Geodata { get; }

		[Export ("pushText", ArgumentSemantic.Retain)]
		string PushText { get; set; }

		[Export ("radius")]
		float Radius { get; set; }

		[Export ("initWithGeoData:")]
		IntPtr Constructor (QBLGeoData _geodata);
	}

	[BaseType (typeof (QBLGeoDataQuery))]
	public partial interface QBLGeoDataUpdateQuery {

		[Export ("geodata")]
		QBLGeoData Geodata { get; }

		[Export ("initWithGeoData:")]
		IntPtr Constructor (QBLGeoData _geodata);
	}

	[BaseType (typeof (QBLGeoDataQuery))]
	public partial interface QBLGeoDataGetQuery {

		[Export ("geodataID")]
		uint GeodataID { get; set; }

		[Export ("searchRequest")]
		QBLGeoDataGetRequest SearchRequest { get; }

		[Export ("initWithRequest:")]
		IntPtr Constructor (QBLGeoDataGetRequest _searchrequest);

		[Export ("initWithGeoDataID:")]
		IntPtr Constructor (uint geodataID);
	}

	[BaseType (typeof (QBLGeoDataQuery))]
	public partial interface QBLGeoDataDeleteQuery {

		[Export ("deleteRequest")]
		QBLGeoDataDeleteRequest DeleteRequest { get; }

		[Export ("geodataID")]
		uint GeodataID { get; set; }

		[Export ("initWithRequest:")]
		IntPtr Constructor (QBLGeoDataDeleteRequest _deleteRequest);

		[Export ("initWithGeoDataID:")]
		IntPtr Constructor (uint geodataID);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBLPlacesQuery {
	}


	[BaseType (typeof (QBLPlacesQuery))]
	public partial interface QBLPlaceCreateQuery {

		[Export ("place")]
		QBLPlace Place { get; }

		[Export ("initWithPlace:")]
		IntPtr Constructor (QBLPlace _place);
	}

	[BaseType (typeof (QBLPlacesQuery))]
	public partial interface QBLPlaceUpdateQuery {

		[Export ("place", ArgumentSemantic.Retain)]
		QBLPlace Place { get; set; }

		[Export ("initWithPlace:")]
		IntPtr Constructor (QBLPlace place);
	}

	[BaseType (typeof (QBLPlacesQuery))]
	public partial interface QBLPlaceDeleteQuery {

		[Export ("placeID")]
		uint PlaceID { get; set; }

		[Export ("initWithPlaceID:")]
		IntPtr Constructor (uint placeID);
	}

	[BaseType (typeof (QBLPlacesQuery))]
	public partial interface QBLPlacesGetQuery {

		[Export ("pagedRequest")]
		PagedRequest PagedRequest { get; }

		[Export ("placeID")]
		uint PlaceID { get; set; }

		[Export ("initWithPlaceID:")]
		IntPtr Constructor (uint placeID);

		[Export ("initWithRequest:")]
		IntPtr Constructor (PagedRequest _pagedRequest);
	}

	[BaseType (typeof (PagedRequest))]
	public partial interface QBLGeoDataGetRequest {

		[Export ("createdAt", ArgumentSemantic.Retain)]
		NSDate CreatedAt { get; set; }

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("userIDs", ArgumentSemantic.Retain)]
		NSObject [] UserIDs { get; set; }

		[Export ("userName", ArgumentSemantic.Retain)]
		string UserName { get; set; }

		[Export ("minCreatedAt", ArgumentSemantic.Retain)]
		NSDate MinCreatedAt { get; set; }

		[Export ("maxCreatedAt", ArgumentSemantic.Retain)]
		NSDate MaxCreatedAt { get; set; }

		[Export ("radius")]
		float Radius { get; set; }

		[Export ("sortAsc")]
		bool SortAsc { get; set; }

	
		[Export ("lastOnly")]
		bool LastOnly { get; set; }

		[Export ("status")]
		bool Status { get; set; }

		[Export ("currentPosition")]
		CLLocationCoordinate2D CurrentPosition { get; set; }
	}

	[BaseType (typeof (Request))]
	public partial interface QBLGeoDataDeleteRequest {

		[Export ("days")]
		uint Days { get; set; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBLGeoDataResult {

		[Export ("geoData")]
		QBLGeoData GeoData { get; }
	}

	[BaseType (typeof (PagedResult))]
	public partial interface QBLGeoDataPagedResult {

		[Export ("geodata")]
		NSObject [] Geodata { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBLPlaceResult {

		[Export ("place")]
		QBLPlace Place { get; }
	}

	[BaseType (typeof (PagedResult))]
	public partial interface QBLPlacePagedResult {

		[Export ("places")]
		NSObject [] Places { get; }
	}

	[BaseType (typeof (QBBaseModule))]
	public partial interface QBLocation {

		[Static, Export ("createGeoData:delegate:")]
		NSObject CreateGeoData (QBLGeoData geodata, NSObject _delegate);

		[Static, Export ("createGeoData:delegate:context:")]
		NSObject CreateGeoData (QBLGeoData geodata, NSObject _delegate, NSObject context);

		[Static, Export ("createGeoData:andSendPushWithText:toAllUsersWithinRadius:delegate:")]
		NSObject CreateGeoData (QBLGeoData geodata, string pushText, float radius, NSObject _delegate);

		[Static, Export ("createGeoData:andSendPushWithText:toAllUsersWithinRadius:delegate:context:")]
		NSObject CreateGeoData (QBLGeoData geodata, string pushText, float radius, NSObject _delegate, NSObject context);

		[Static, Export ("geoDataWithID:delegate:")]
		NSObject GeoDataWithID (uint geodataID, NSObject _delegate);

		[Static, Export ("geoDataWithID:delegate:context:")]
		NSObject GeoDataWithID (uint geodataID, NSObject _delegate, NSObject context);

		[Static, Export ("geoDataWithRequest:delegate:")]
		NSObject GeoDataWithRequest (QBLGeoDataGetRequest geodataRequest, NSObject _delegate);

		[Static, Export ("geoDataWithRequest:delegate:context:")]
		NSObject GeoDataWithRequest (QBLGeoDataGetRequest geodataRequest, NSObject _delegate, NSObject context);

		[Static, Export ("updateGeoData:delegate:")]
		NSObject UpdateGeoData (QBLGeoData geodata, NSObject _delegate);

		[Static, Export ("updateGeoData:delegate:context:")]
		NSObject UpdateGeoData (QBLGeoData geodata, NSObject _delegate, NSObject context);

		[Static, Export ("deleteGeoDataWithID:delegate:")]
		NSObject DeleteGeoDataWithID (uint geodataID, NSObject _delegate);

		[Static, Export ("deleteGeoDataWithID:delegate:context:")]
		NSObject DeleteGeoDataWithID (uint geodataID, NSObject _delegate, NSObject context);

		[Static, Export ("deleteGeoDataWithRequest:delegate:")]
		NSObject DeleteGeoDataWithRequest (QBLGeoDataDeleteRequest deleteRequest, NSObject _delegate);

		[Static, Export ("deleteGeoDataWithRequest:delegate:context:")]
		NSObject DeleteGeoDataWithRequest (QBLGeoDataDeleteRequest deleteRequest, NSObject _delegate, NSObject context);

		[Static, Export ("createPlace:delegate:")]
		NSObject CreatePlace (QBLPlace place, NSObject _delegate);

		[Static, Export ("createPlace:delegate:context:")]
		NSObject CreatePlace (QBLPlace place, NSObject _delegate, NSObject context);

		[Static, Export ("updatePlace:delegate:")]
		NSObject UpdatePlace (QBLPlace place, NSObject _delegate);

		[Static, Export ("updatePlace:delegate:context:")]
		NSObject UpdatePlace (QBLPlace place, NSObject _delegate, NSObject context);

		[Static, Export ("placesWithDelegate:")]
		NSObject PlacesWithDelegate (NSObject _delegate);

		[Static, Export ("placesWithDelegate:context:")]
		NSObject PlacesWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("placesWithPagedRequest:delegate:")]
		NSObject PlacesWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("placesWithPagedRequest:delegate:context:")]
		NSObject PlacesWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("placeWithID:delegate:")]
		NSObject PlaceWithID (uint placeID, NSObject _delegate);

		[Static, Export ("placeWithID:delegate:context:")]
		NSObject PlaceWithID (uint placeID, NSObject _delegate, NSObject context);

		[Static, Export ("deletePlaceWithID:delegate:")]
		NSObject DeletePlaceWithID (uint placeID, NSObject _delegate);

		[Static, Export ("deletePlaceWithID:delegate:context:")]
		NSObject DeletePlaceWithID (uint placeID, NSObject _delegate, NSObject context);

	}


	[BaseType (typeof (Entity))]
	public partial interface QBMPushToken {

		[Export ("clientIdentificationSequence", ArgumentSemantic.Retain)]
		string ClientIdentificationSequence { get; set; }

		[Export ("isEnvironmentDevelopment")]
		bool IsEnvironmentDevelopment { get; set; }

		[Static, Export ("pushToken")]
		QBMPushToken PushToken { get; }
	}

	[BaseType (typeof (Entity))]
	public partial interface QBMSubscription {

		[Export ("notificationChannel")]
		QBMNotificationChannel NotificationChannel { get; set; }

		[Export ("deviceUDID", ArgumentSemantic.Retain)]
		string DeviceUDID { get; set; }

		[Export ("devicePlatform", ArgumentSemantic.Retain)]
		string DevicePlatform { get; set; }

		[Export ("url", ArgumentSemantic.Retain)]
		string Url { get; set; }

		[Static, Export ("subscription")]
		QBMSubscription Subscription { get; }

	}

	[BaseType (typeof (Entity))]
	public partial interface QBMEvent {

		[Export ("active")]
		bool Active { get; set; }

		[Export ("notificationType")]
		QBMNotificationType NotificationType { get; set; }

		[Export ("pushType")]
		QBMPushType PushType { get; set; }

		[Export ("usersIDs", ArgumentSemantic.Retain)]
		string UsersIDs { get; set; }

		[Export ("usersExternalIDs", ArgumentSemantic.Retain)]
		string UsersExternalIDs { get; set; }

		[Export ("usersTagsAny", ArgumentSemantic.Retain)]
		string UsersTagsAny { get; set; }

		[Export ("usersTagsAll", ArgumentSemantic.Retain)]
		string UsersTagsAll { get; set; }

		[Export ("usersTagsExclude", ArgumentSemantic.Retain)]
		string UsersTagsExclude { get; set; }

		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; set; }

		[Export ("isDevelopmentEnvironment")]
		bool IsDevelopmentEnvironment { get; set; }

		[Export ("message", ArgumentSemantic.Retain)]
		NSObject Message { get; set; }

		[Export ("type")]
		QBMEventType Type { get; set; }

		[Export ("date", ArgumentSemantic.Retain)]
		NSDate Date { get; set; }

		[Export ("endDate", ArgumentSemantic.Retain)]
		NSDate EndDate { get; set; }

		[Export ("period")]
		uint Period { get; set; }

		[Export ("occuredCount")]
		uint OccuredCount { get; set; }

		[Export ("senderID")]
		uint SenderID { get; set; }

		[Static, Export ("event")]
		QBMEvent Event { get; }

		[Export ("prepareMessage")]
		void PrepareMessage ();


		[Static, Export ("notificationTypeFromString:")]
		QBMNotificationType NotificationTypeFromString (string notificationType);

		[Static, Export ("notificationTypeToString:")]
		string NotificationTypeToString (QBMNotificationType notificationType);

		[Static, Export ("pushTypeFromString:")]
		QBMPushType PushTypeFromString (string pushType);

		[Static, Export ("pushTypeToString:")]
		string PushTypeToString (QBMPushType pushType);

		[Static, Export ("messageToString:")]
		string MessageToString (NSDictionary message);

		[Static, Export ("messageFromString:")]
		NSDictionary MessageFromString (string message);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBMPushMessageBase {

		[Export ("payloadDict", ArgumentSemantic.Retain)]
		NSMutableDictionary PayloadDict { get; set; }

		[Export ("initWithPayload:")]
		IntPtr Constructor (NSDictionary payload);

		[Export ("json")]
		string Json { get; }

		[Export ("charsLeft")]
		int CharsLeft { get; }
	}

	[BaseType (typeof (QBMPushMessageBase))]
	public partial interface QBMPushMessage {

		[Export ("alertBody", ArgumentSemantic.Retain)]
		string AlertBody { get; set; }

		[Export ("badge", ArgumentSemantic.Retain)]
		NSNumber Badge { get; set; }

		[Export ("soundFile", ArgumentSemantic.Retain)]
		string SoundFile { get; set; }

		[Export ("localizedBodyKey", ArgumentSemantic.Retain)]
		string LocalizedBodyKey { get; set; }

		[Export ("localizedBodyArguments", ArgumentSemantic.Retain)]
		NSObject [] LocalizedBodyArguments { get; set; }

		[Export ("localizedActionKey", ArgumentSemantic.Retain)]
		string LocalizedActionKey { get; set; }

		[Export ("additionalInfo", ArgumentSemantic.Retain)]
		NSDictionary AdditionalInfo { get; set; }

		[Static, Export ("pushMessage")]
		QBMPushMessage PushMessage { get; }
	}

	[BaseType (typeof (QBMEvent))]
	public partial interface QBMApplePushEvent {

		[Export ("pushMessage", ArgumentSemantic.Retain)]
		QBMPushMessage PushMessage { get; set; }

		[Static, Export ("pushEvent")]
		QBMApplePushEvent PushEvent { get; }
	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBMPushTokenAnswer {

		[Export ("pushToken")]
		QBMPushToken PushToken { get; }
	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBMSubscriptionAnswer {

		[Export ("subscriptions")]
		NSMutableArray Subscriptions { get; }
	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBMEventAnswer {

		[Export ("event")]
		QBMEvent Event { get; }
	}

	[BaseType (typeof (PagedAnswer))]
	public partial interface QBMEventPagedAnswer {

		[Export ("events", ArgumentSemantic.Retain)]
		NSMutableArray Events { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBMPushTokenQuery {
	}


	[BaseType (typeof (QBMPushTokenQuery))]
	public partial interface QBMPushTokenCreateQuery {

		[Export ("pushToken", ArgumentSemantic.Retain)]
		QBMPushToken PushToken { get; set; }

		[Export ("initWithPushToken:")]
		IntPtr Constructor (QBMPushToken token);
	}

	[BaseType (typeof (QBMPushTokenQuery))]
	public partial interface QBMPushTokenDeleteQuery {

		[Export ("ID")]
		uint ID { get; set; }

		[Export ("initWithPushTokenID:")]
		IntPtr Constructor (uint ID);
	}


	[BaseType (typeof (NSObject))]
	public partial interface QBMSubscriptionQuery {

	}


	[BaseType (typeof (QBMSubscriptionQuery))]
	public partial interface QBMSubscriptionCreateQuery {

		[Export ("subscription", ArgumentSemantic.Retain)]
		QBMSubscription Subscription { get; set; }

		[Export ("initWithSubscription:")]
		IntPtr Constructor (QBMSubscription tsubscription);
	}

	[BaseType (typeof (QBMSubscriptionQuery))]
	public partial interface QBMSubscriptionDeleteQuery {

		[Export ("ID")]
		uint ID { get; set; }

		[Export ("initWithSubscriptionID:")]
		IntPtr Constructor (uint ID);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBMEventQuery {

	}



	[BaseType (typeof (QBMEventQuery))]
	public partial interface QBMEventCreateQuery {

		[Export ("event", ArgumentSemantic.Retain)]
		QBMEvent Event { get; set; }

		[Export ("initWithEvent:")]
		IntPtr Constructor (QBMEvent _event);
	}



	[BaseType (typeof (QBMEventQuery))]
	public partial interface QBMEventUpdateQuery {

		[Export ("event", ArgumentSemantic.Retain)]
		QBMEvent Event { get; set; }

		[Export ("initWithEvent:")]
		IntPtr Constructor (QBMEvent _event);
	}

	[BaseType (typeof (QBMEventQuery))]
	public partial interface QBMEventDeleteQuery {

		[Export ("eventID")]
		uint EventID { get; set; }

		[Export ("initWithEventID:")]
		IntPtr Constructor (uint geodataID);
	}

	[BaseType (typeof (Result))]
	public partial interface QBMPushTokenResult {

		[Export ("pushToken")]
		QBMPushToken PushToken { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBMSubscriptionResult {

		[Export ("subscriptions")]
		NSObject [] Subscriptions { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBMEventResult {

		[Export ("event")]
		QBMEvent Event { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBMEventPagedResult {

		[Export ("events")]
		NSObject [] Events { get; }
	}

	[BaseType (typeof (TaskResult))]
	public partial interface QBMGetTokenTaskResult {

		[Export ("token", ArgumentSemantic.Retain)]
		string Token { get; set; }
	}

	[BaseType (typeof (TaskResult))]
	public partial interface QBMRegisterSubscriptionTaskResult {

		[Export ("subscriptions", ArgumentSemantic.Retain)]
		NSObject [] Subscriptions { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBMGetTokenPerformer : Perform, Cancelable {

		[Export ("performDelegate", ArgumentSemantic.Retain)]
		NSObject PerformDelegate { get; set; }

		[Export ("context", ArgumentSemantic.Retain)]
		NSObject Context { get; set; }



		[Export ("completed")]
		bool Completed { get; set; }

		[Export ("isCanceled")]
		bool IsCanceled { get; set; }

		[Export ("actionInBg")]
		void ActionInBg ();

		[Export ("performAction")]
		void PerformAction ();

		[Export ("tokenRequestTimedOut")]
		void TokenRequestTimedOut ();
	}

	[BaseType (typeof (Task))]
	public partial interface QBMSendPushTask {

		[Export ("usersIDs", ArgumentSemantic.Retain)]
		string UsersIDs { get; set; }

		[Export ("usersTagsAny", ArgumentSemantic.Retain)]
		string UsersTagsAny { get; set; }

		[Export ("pushMessage", ArgumentSemantic.Retain)]
		QBMPushMessage PushMessage { get; set; }

		[Export ("simplePushText", ArgumentSemantic.Retain)]
		string SimplePushText { get; set; }

		[Export ("isDevelopmentEnvironment")]
		bool IsDevelopmentEnvironment { get; set; }
	}

	[BaseType (typeof (QBBaseModule))]
	public partial interface QBMessages {

		[Static, Export ("createPushToken:delegate:")]
		NSObject CreatePushToken (QBMPushToken pushToken, NSObject _delegate);

		[Static, Export ("createPushToken:delegate:context:")]
		NSObject CreatePushToken (QBMPushToken pushToken, NSObject _delegate, NSObject context);

		[Static, Export ("deletePushTokenWithID:delegate:")]
		NSObject DeletePushTokenWithID (uint ID, NSObject _delegate);

		[Static, Export ("deletePushTokenWithID:delegate:context:")]
		NSObject DeletePushTokenWithID (uint ID, NSObject _delegate, NSObject context);

		[Static, Export ("createSubscription:delegate:")]
		NSObject CreateSubscription (QBMSubscription subscriber, NSObject _delegate);

		[Static, Export ("createSubscription:delegate:context:")]
		NSObject CreateSubscription (QBMSubscription subscriber, NSObject _delegate, NSObject context);

		[Static, Export ("subscriptionsWithDelegate:")]
		NSObject SubscriptionsWithDelegate (NSObject _delegate);

		[Static, Export ("subscriptionsWithDelegate:context:")]
		NSObject SubscriptionsWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("deleteSubscriptionWithID:delegate:")]
		NSObject DeleteSubscriptionWithID (uint ID, NSObject _delegate);

		[Static, Export ("deleteSubscriptionWithID:delegate:context:")]
		NSObject DeleteSubscriptionWithID (uint ID, NSObject _delegate, NSObject context);

		[Static, Export ("createEvent:delegate:")]
		NSObject CreateEvent (QBMEvent _event, NSObject _delegate);

		[Static, Export ("createEvent:delegate:context:")]
		NSObject CreateEvent (QBMEvent _event, NSObject _delegate, NSObject context);

		[Static, Export ("eventWithID:delegate:")]
		NSObject EventWithID (uint ID, NSObject _delegate);

		[Static, Export ("eventWithID:delegate:context:")]
		NSObject EventWithID (uint ID, NSObject _delegate, NSObject context);

		[Static, Export ("updateEvent:delegate:")]
		NSObject UpdateEvent (QBMEvent _event, NSObject _delegate);

		[Static, Export ("updateEvent:delegate:context:")]
		NSObject UpdateEvent (QBMEvent _event, NSObject _delegate, NSObject context);

		[Static, Export ("deleteEventWithID:delegate:")]
		NSObject DeleteEventWithID (uint ID, NSObject _delegate);

		[Static, Export ("deleteEventWithID:delegate:context:")]
		NSObject DeleteEventWithID (uint ID, NSObject _delegate, NSObject context);

		[Static, Export ("eventsWithDelegate:")]
		NSObject EventsWithDelegate (NSObject _delegate);

		[Static, Export ("eventsWithDelegate:context:")]
		NSObject EventsWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("eventsWithPagedRequest:delegate:")]
		NSObject EventsWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("eventsWithPagedRequest:delegate:context:")]
		NSObject EventsWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("pullEventsWithDelegate:")]
		NSObject PullEventsWithDelegate (NSObject _delegate);

		[Static, Export ("pullEventsWithDelegate:context:")]
		NSObject PullEventsWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("TRegisterSubscriptionWithDelegate:")]
		NSObject TRegisterSubscriptionWithDelegate (NSObject _delegate);

		[Static, Export ("TRegisterSubscriptionWithDelegate:context:")]
		NSObject TRegisterSubscriptionWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("TUnregisterSubscriptionWithDelegate:")]
		NSObject TUnregisterSubscriptionWithDelegate (NSObject _delegate);

		[Static, Export ("TUnregisterSubscriptionWithDelegate:context:")]
		NSObject TUnregisterSubscriptionWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("TSendPush:toUsers:delegate:")]
		NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, NSObject _delegate);

		[Static, Export ("TSendPush:toUsers:delegate:context:")]
		NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, NSObject _delegate, NSObject context);

		[Static, Export ("TSendPushWithText:toUsers:delegate:")]
		NSObject TSendPushWithText (string text, string usersIDs, NSObject _delegate);

		[Static, Export ("TSendPushWithText:toUsers:delegate:context:")]
		NSObject TSendPushWithText (string text, string usersIDs, NSObject _delegate, NSObject context);

		[Static, Export ("TSendPush:toUsersWithAnyOfTheseTags:delegate:")]
		NSObject TSendPushWithTags (QBMPushMessage pushMessage, string usersTags, NSObject _delegate);

		[Static, Export ("TSendPush:toUsersWithAnyOfTheseTags:delegate:context:")]
		NSObject TSendPushWithTagsAndContext (QBMPushMessage pushMessage, string usersTags, NSObject _delegate, NSObject context);

		[Static, Export ("TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:")]
		NSObject TSendPushWithTextAndTags (string text, string usersTags, NSObject _delegate);

		[Static, Export ("TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:context:")]
		NSObject TSendPushWithTextWithContext (string text, string usersTags, NSObject _delegate, NSObject context);
	}



	[BaseType (typeof (Entity))]
	public partial interface QBCBlobObjectAccess {

		[Export ("blobID")]
		uint BlobID { get; set; }

		[Export ("expires", ArgumentSemantic.Retain)]
		NSDate Expires { get; set; }

		[Export ("urlWithParams", ArgumentSemantic.Retain)]
		string UrlWithParams { get; set; }

		[Export ("params", ArgumentSemantic.Retain)]
		NSDictionary Params { get; set; }

		[Export ("url", ArgumentSemantic.Retain)]
		NSUrl Url { get; set; }

		[Export ("expired")]
		bool Expired { get; }
	}

	[BaseType (typeof (Entity))]
	public partial interface QBCBlob {

		[Export ("contentType", ArgumentSemantic.Retain)]
		string ContentType { get; set; }

		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; set; }

		[Export ("status")]
		QBCBlobStatus Status { get; set; }

		[Export ("completedAt", ArgumentSemantic.Retain)]
		NSDate CompletedAt { get; set; }

		[Export ("size")]
		uint Size { get; set; }

		[Export ("UID", ArgumentSemantic.Retain)]
		string UID { get; set; }

		[Export ("lastReadAccessTs", ArgumentSemantic.Retain)]
		NSDate LastReadAccessTs { get; set; }

		[Export ("lifetime")]
		uint Lifetime { get; set; }

		[Export ("blobObjectAccess", ArgumentSemantic.Retain)]
		QBCBlobObjectAccess BlobObjectAccess { get; set; }

		[Export ("refCount")]
		uint RefCount { get; set; }

		[Export ("tags", ArgumentSemantic.Retain)]
		string Tags { get; set; }

		[Export ("isPublic")]
		bool IsPublic { get; set; }

		[Export ("isNew")]
		bool IsNew { get; set; }

		[Static, Export ("blob")]
		QBCBlob Blob { get; }

		[Export ("publicUrl")]
		string PublicUrl { get; }

	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBCBlobObjectAccessAnswer {

		[Export ("paramsBuffer", ArgumentSemantic.Retain)]
		NSMutableString ParamsBuffer { get; set; }

		[Export ("blobObjectAccess")]
		QBCBlobObjectAccess BlobObjectAccess { get; }
	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBCBlobAnswer {

		[Export ("blob")]
		QBCBlob Blob { get; }

		[Export ("blobObjectAccessAnswer", ArgumentSemantic.Retain)]
		QBCBlobObjectAccessAnswer BlobObjectAccessAnswer { get; set; }
	}

	[BaseType (typeof (PagedAnswer))]
	public partial interface QBCBlobPagedAnswer {

		[Export ("blobs", ArgumentSemantic.Retain)]
		NSMutableArray Blobs { get; set; }
	}

	[BaseType (typeof (XmlAnswer))]
	public partial interface QBCS3Answer {

		[Export ("code", ArgumentSemantic.Retain)]
		NSMutableString Code { get; set; }

		[Export ("message", ArgumentSemantic.Retain)]
		NSMutableString Message { get; set; }

		[Export ("requestId", ArgumentSemantic.Retain)]
		NSMutableString RequestId { get; set; }

		[Export ("hostId", ArgumentSemantic.Retain)]
		NSMutableString HostId { get; set; }
	}

	[BaseType (typeof (QBCS3Answer))]
	public partial interface QBCS3PostAnswer {

		[Export ("location", ArgumentSemantic.Retain)]
		NSUrl Location { get; set; }

		[Export ("bucket", ArgumentSemantic.Retain)]
		string Bucket { get; set; }

		[Export ("key", ArgumentSemantic.Retain)]
		string Key { get; set; }

		[Export ("eTag", ArgumentSemantic.Retain)]
		string ETag { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCBlobQuery {


	}


	[BaseType (typeof (QBCBlobQuery))]
	public partial interface QBCBlobCreateQuery {

		[Export ("blob")]
		QBCBlob Blob { get; }

		[Export ("initWithBlob:")]
		IntPtr Constructor (QBCBlob blob);
	}

	[BaseType (typeof (QBCBlobQuery))]
	public partial interface QBCBlobGetQuery {

		[Export ("blobId")]
		uint BlobId { get; }

		[Export ("pagedRequest")]
		PagedRequest PagedRequest { get; }

		[Export ("initWithBlobId:")]
		IntPtr Constructor (uint blobid);

		[Export ("initWithPagedRequest:isTaggedGet:")]
		IntPtr Constructor (PagedRequest pagedRequest, bool isTaggedGet);
	}

	[BaseType (typeof (QBCBlobQuery))]
	public partial interface QBCBlobDeleteQuery {

		[Export ("blobId")]
		uint BlobId { get; }

		[Export ("initWithBlobId:")]
		IntPtr Constructor (uint blobid);
	}

	[BaseType (typeof (QBCBlobQuery))]
	public partial interface QBCBlobUpdateQuery {

		[Export ("blob")]
		QBCBlob Blob { get; }

		[Export ("initWithBlob:")]
		IntPtr Constructor (QBCBlob blob);
	}

	[BaseType (typeof (QBCBlobQuery))]
	public partial interface QBCBlobCompleteQuery {

		[Export ("blobId")]
		uint BlobId { get; }

		[Export ("size")]
		uint Size { get; }

		[Export ("initWithBlobId:size:")]
		IntPtr Constructor (uint blobid, uint size);
	}

	[BaseType (typeof (QBCBlobQuery))]
	public partial interface QBCBlobRetainQuery {

		[Export ("blobId")]
		uint BlobId { get; }

		[Export ("initWithBlobId:")]
		IntPtr Constructor (uint blobid);
	}

	[BaseType (typeof (QBCBlobQuery))]
	public partial interface QBCBlobDownloadQuery {

		[Export ("UID")]
		string UID { get; }

		[Export ("initWithBlobUID:")]
		IntPtr Constructor (string blobUID);
	}

	[BaseType (typeof (QBCBlobQuery))]
	public partial interface QBCBlobUploadQuery {

		[Export ("blobWithWriteAccess", ArgumentSemantic.Retain)]
		QBCBlob BlobWithWriteAccess { get; set; }

		[Export ("file", ArgumentSemantic.Retain)]
		NSData File { get; set; }

		[Export ("initWithBlobWithWriteAccess:file:")]
		IntPtr Constructor (QBCBlob blobWithWriteAccess, NSData data);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCBlobObjectAccessQuery {

	}


	[BaseType (typeof (QBCBlobObjectAccessQuery))]
	public partial interface QBCBlobObjectAccessGetQuery {

		[Export ("blobId")]
		uint BlobId { get; }

		[Export ("initWithBlobId:")]
		IntPtr Constructor (uint blobid);
	}

	[BaseType (typeof (Result))]
	public partial interface QBCBlobObjectAccessResult {

		[Export ("blobObjectAccess")]
		QBCBlobObjectAccess BlobObjectAccess { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCBlobResult {

		[Export ("blob")]
		QBCBlob Blob { get; }
	}

	[BaseType (typeof (PagedResult))]
	public partial interface QBCBlobPagedResult {

		[Export ("blobs")]
		NSObject [] Blobs { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCFileResult {

		[Export ("data")]
		NSData Data { get; }
	}

	[BaseType (typeof (TaskResult))]
	public partial interface QBCFileUploadTaskResult {

		[Export ("uploadedBlob")]
		QBCBlob UploadedBlob { get; }

		[Static, Export ("resultWithBlob:")]
		QBCFileUploadTaskResult ResultWithBlob (QBCBlob uploadedBlob);
	}

	[BaseType (typeof (TaskResult))]
	public partial interface QBCFileDownloadTaskResult {

		[Export ("file")]
		NSData File { get; }

		[Export ("blob")]
		QBCBlob Blob { get; }

		[Static, Export ("resultWithFile:blob:")]
		QBCFileDownloadTaskResult ResultWithFile (NSData file, QBCBlob blob);
	}

	[BaseType (typeof (Task))]
	public partial interface QBCFileDownloadTask {

		[Export ("blobID")]
		uint BlobID { get; set; }

		[Export ("blob", ArgumentSemantic.Retain)]
		QBCBlob Blob { get; set; }
	}

	[BaseType (typeof (Task))]
	public partial interface QBCFileUploadTask {

		[Export ("contentType", ArgumentSemantic.Retain)]
		string ContentType { get; set; }

		[Export ("fileName", ArgumentSemantic.Retain)]
		string FileName { get; set; }

		[Export ("data", ArgumentSemantic.Retain)]
		NSData Data { get; set; }

		[Export ("blob", ArgumentSemantic.Retain)]
		QBCBlob Blob { get; set; }

		[Export ("isPublic")]
		bool IsPublic { get; set; }
	}

	[BaseType (typeof (Task))]
	public partial interface QBCFileUpdateTask {

		[Export ("data", ArgumentSemantic.Retain)]
		NSData Data { get; set; }

		[Export ("blob", ArgumentSemantic.Retain)]
		QBCBlob Blob { get; set; }
	}

	[BaseType (typeof (QBBaseModule))]
	public partial interface QBContent {

		[Static, Export ("createBlob:delegate:")]
		NSObject CreateBlob (QBCBlob blob, NSObject _delegate);

		[Static, Export ("createBlob:delegate:context:")]
		NSObject CreateBlob (QBCBlob blob, NSObject _delegate, NSObject context);

		[Static, Export ("blobWithID:delegate:")]
		NSObject BlobWithID (uint blobID, NSObject _delegate);

		[Static, Export ("blobWithID:delegate:context:")]
		NSObject BlobWithID (uint blobID, NSObject _delegate, NSObject context);

		[Static, Export ("blobsWithDelegate:")]
		NSObject BlobsWithDelegate (NSObject _delegate);

		[Static, Export ("blobsWithDelegate:context:")]
		NSObject BlobsWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("blobsWithPagedRequest:delegate:")]
		NSObject BlobsWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("blobsWithPagedRequest:delegate:context:")]
		NSObject BlobsWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("taggedBlobsWithDelegate:")]
		NSObject TaggedBlobsWithDelegate (NSObject _delegate);

		[Static, Export ("taggedBlobsWithDelegate:context:")]
		NSObject TaggedBlobsWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("taggedBlobsWithPagedRequest:delegate:")]
		NSObject TaggedBlobsWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate);

		[Static, Export ("taggedBlobsWithPagedRequest:delegate:context:")]
		NSObject TaggedBlobsWithPagedRequest (PagedRequest pagedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("updateBlob:delegate:")]
		NSObject UpdateBlob (QBCBlob blob, NSObject _delegate);

		[Static, Export ("updateBlob:delegate:context:")]
		NSObject UpdateBlob (QBCBlob blob, NSObject _delegate, NSObject context);

		[Static, Export ("deleteBlobWithID:delegate:")]
		NSObject DeleteBlobWithID (uint blobID, NSObject _delegate);

		[Static, Export ("deleteBlobWithID:delegate:context:")]
		NSObject DeleteBlobWithID (uint blobID, NSObject _delegate, NSObject context);

		[Static, Export ("retainBlobWithID:delegate:")]
		NSObject RetainBlobWithID (uint blobID, NSObject _delegate);

		[Static, Export ("retainBlobWithID:delegate:context:")]
		NSObject RetainBlobWithID (uint blobID, NSObject _delegate, NSObject context);

		[Static, Export ("completeBlobWithID:size:delegate:")]
		NSObject CompleteBlobWithID (uint blobID, uint size, NSObject _delegate);

		[Static, Export ("completeBlobWithID:size:delegate:context:")]
		NSObject CompleteBlobWithID (uint blobID, uint size, NSObject _delegate, NSObject context);

		[Static, Export ("blobObjectAccessWithBlobID:delegate:")]
		NSObject BlobObjectAccessWithBlobID (uint blobID, NSObject _delegate);

		[Static, Export ("blobObjectAccessWithBlobID:delegate:context:")]
		NSObject BlobObjectAccessWithBlobID (uint blobID, NSObject _delegate, NSObject context);

		[Static, Export ("uploadFile:blobWithWriteAccess:delegate:")]
		NSObject UploadFile (NSData data, QBCBlob blobWithWriteAccess, NSObject _delegate);

		[Static, Export ("uploadFile:blobWithWriteAccess:delegate:context:")]
		NSObject UploadFile (NSData data, QBCBlob blobWithWriteAccess, NSObject _delegate, NSObject context);

		[Static, Export ("downloadFileWithUID:delegate:")]
		NSObject DownloadFileWithUID (string UID, NSObject _delegate);

		[Static, Export ("downloadFileWithUID:delegate:context:")]
		NSObject DownloadFileWithUID (string UID, NSObject _delegate, NSObject context);

		[Static, Export ("TUploadFile:fileName:contentType:isPublic:delegate:")]
		NSObject TUploadFile (NSData data, string fileName, string contentType, bool isPublic, NSObject _delegate);

		[Static, Export ("TUploadFile:fileName:contentType:isPublic:delegate:context:")]
		NSObject TUploadFile (NSData data, string fileName, string contentType, bool isPublic, NSObject _delegate, NSObject context);

		[Static, Export ("TUpdateFileWithData:file:delegate:")]
		NSObject TUpdateFileWithData (NSData data, QBCBlob file, NSObject _delegate);

		[Static, Export ("TUpdateFileWithData:file:delegate:context:")]
		NSObject TUpdateFileWithData (NSData data, QBCBlob file, NSObject _delegate, NSObject context);

		[Static, Export ("TDownloadFileWithBlobID:delegate:")]
		NSObject TDownloadFileWithBlobID (uint blobID, NSObject _delegate);

		[Static, Export ("TDownloadFileWithBlobID:delegate:context:")]
		NSObject TDownloadFileWithBlobID (uint blobID, NSObject _delegate, NSObject context);
	}


	[BaseType (typeof (Entity))]
	public partial interface QBRGameMode {

		[Export ("title", ArgumentSemantic.Retain)]
		string Title { get; set; }

		[Export ("applicationID")]
		uint ApplicationID { get; set; }

		[Export ("userID")]
		uint UserID { get; set; }

		[Static, Export ("gameMode")]
		QBRGameMode GameMode { get; }
	}

	[BaseType (typeof (Entity))]
	public partial interface QBRScore {

		[Export ("gameModeID")]
		uint GameModeID { get; set; }

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("value")]
		uint Value { get; set; }

		[Export ("gameModeParameterValues")]
		NSObject [] GameModeParameterValues { get; set; }

		[Static, Export ("score")]
		QBRScore Score { get; }
	}

	[BaseType (typeof (Entity))]
	public partial interface QBRAverage {

		[Export ("gameModeID")]
		uint GameModeID { get; set; }

		[Export ("value")]
		float Value { get; set; }
	}

	[BaseType (typeof (Entity))]
	public partial interface QBRGameModeParameterValue {

		[Export ("gameModeParameterID")]
		uint GameModeParameterID { get; set; }

		[Export ("scoreID")]
		uint ScoreID { get; set; }

		[Export ("value", ArgumentSemantic.Copy)]
		string Value { get; set; }

		[Static, Export ("gameModeParameterValue")]
		QBRGameModeParameterValue GameModeParameterValue { get; }
	}

	[BaseType (typeof (PagedRequest))]
	public partial interface QBRScoreGetRequest {

		[Export ("sortAsc")]
		bool SortAsc { get; set; }

	
		[Export ("gameModeID")]
		uint GameModeID { get; set; }

		[Export ("gameModeAdditionalParametersFilters", ArgumentSemantic.Retain)]
		NSDictionary GameModeAdditionalParametersFilters { get; set; }
	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBRGameModeParameterValueAnswer {

		[Export ("gameModeParameterValue")]
		QBRGameModeParameterValue GameModeParameterValue { get; }
	}

	[BaseType (typeof (PagedAnswer))]
	public partial interface QBRGameModeParameterValuePagedAnswer {

		[Export ("gameModeParemeterValues", ArgumentSemantic.Retain)]
		NSMutableArray GameModeParemeterValues { get; set; }
	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBRGameModeAnswer {

		[Export ("gamemode")]
		QBRGameMode Gamemode { get; }
	}

	[BaseType (typeof (PagedAnswer))]
	public partial interface QBRGameModePagedAnswer {

		[Export ("gameModes", ArgumentSemantic.Retain)]
		NSMutableArray GameModes { get; set; }
	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBRScoreAnswer {

		[Export ("score")]
		QBRScore Score { get; }
	}

	[BaseType (typeof (PagedAnswer))]
	public partial interface QBRScorePagedAnswer {

		[Export ("scores", ArgumentSemantic.Retain)]
		NSMutableArray Scores { get; set; }
	}

	[BaseType (typeof (EntityAnswer))]
	public partial interface QBRAverageAnswer {

		[Export ("average")]
		QBRAverage Average { get; }
	}

	[BaseType (typeof (PagedAnswer))]
	public partial interface QBRAveragePagedAnswer {

		[Export ("averages", ArgumentSemantic.Retain)]
		NSMutableArray Averages { get; set; }
	}



	[BaseType (typeof (NSObject))]
	public partial interface QBRGameModeQuery {

	}



	[BaseType (typeof (QBRGameModeQuery))]
	public partial interface QBRGameModeCreateQuery {

		[Export ("title", ArgumentSemantic.Retain)]
		string Title { get; set; }

		[Export ("initWithTitle:")]
		IntPtr Constructor (string _title);
	}

	[BaseType (typeof (QBRGameModeQuery))]
	public partial interface QBRGameModeDeleteQuery {

		[Export ("gameModeId")]
		uint GameModeId { get; set; }

		[Export ("initWithGameModeID:")]
		IntPtr Constructor (uint game_mode_id);
	}

	[BaseType (typeof (QBRGameModeQuery))]
	public partial interface QBRGameModeGetQuery {

		[Export ("pagedRequest")]
		PagedRequest PagedRequest { get; }

		[Export ("gameModeID")]
		uint GameModeID { get; set; }

		[Export ("initWithGameModeID:")]
		IntPtr Constructor (uint gameModeID);

		[Export ("initWithRequest:")]
		IntPtr Constructor (PagedRequest _pagedRequest);
	}

	[BaseType (typeof (QBRGameModeQuery))]
	public partial interface QBRGameModeUpdateQuery {

		[Export ("gameMode", ArgumentSemantic.Retain)]
		QBRGameMode GameMode { get; set; }

		[Export ("initWithGameMode:")]
		IntPtr Constructor (QBRGameMode gameMode);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBRScoreQuery {

	}

	[BaseType (typeof (QBRScoreQuery))]
	public partial interface QBRScoreCreateQuery {

		[Export ("score")]
		QBRScore Score { get; }

		[Export ("initWithScore:")]
		IntPtr Constructor (QBRScore _score);
	}

	[BaseType (typeof (QBRScoreQuery))]
	public partial interface QBRScoreUpdateQuery {

		[Export ("score")]
		QBRScore Score { get; }

		[Export ("initWithScore:")]
		IntPtr Constructor (QBRScore _score);
	}

	[BaseType (typeof (QBRScoreQuery))]
	public partial interface QBRScoreDeleteQuery {

		[Export ("scoreId")]
		uint ScoreId { get; }

		[Export ("initWithScoreId:")]
		IntPtr Constructor (uint _scoreId);
	}

	[BaseType (typeof (QBRScoreQuery))]
	public partial interface QBRScoreGetQuery {

		[Export ("scoreId")]
		uint ScoreId { get; }

		[Export ("userId")]
		uint UserId { get; }

		[Export ("topN")]
		int TopN { get; }

		[Export ("gameModeId")]
		uint GameModeId { get; }

		[Export ("additionalRequest")]
		QBRScoreGetRequest AdditionalRequest { get; }

		[Export ("initWithScoreId:")]
		IntPtr Constructor (uint _scoreId);

		[Export ("initWithUserId:extendedRequest:")]
		IntPtr Constructor (uint _userId, QBRScoreGetRequest extendedRequest);

		[Export ("initWithTopN:gameModeId:extendedRequest:")]
		IntPtr Constructor (int _topN, int _gameModeId, QBRScoreGetRequest extendedRequest);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBRAverageQuery {

	}

	[BaseType (typeof (NSObject))]
	public partial interface QBRGameModeParameterValueQuery {

	}

	[BaseType (typeof (QBRAverageQuery))]
	public partial interface QBRAverageGetQuery {

		[Export ("gameModeId")]
		uint GameModeId { get; }

		[Export ("initWithGameModeId:")]
		IntPtr Constructor (uint _gameModeId);
	}

	[BaseType (typeof (QBRGameModeParameterValueQuery))]
	public partial interface QBRGameModeParameterValueCreateQuery {

		[Export ("gameModeParameterValue")]
		QBRGameModeParameterValue GameModeParameterValue { get; }

		[Export ("initWithGameModeParameterValue:")]
		IntPtr Constructor (QBRGameModeParameterValue gameModeParameterValue);
	}

	[BaseType (typeof (QBRGameModeParameterValueQuery))]
	public partial interface QBRGameModeParameterValueGetQuery {

		[Export ("gameModeParameterValueID")]
		uint GameModeParameterValueID { get; }

		[Export ("initWithGameModeParameterValueID:")]
		IntPtr Constructor (uint gameModeParameterValueID);
	}

	[BaseType (typeof (QBRGameModeParameterValueQuery))]
	public partial interface QBRGameModeParameterValueUpdateQuery {

		[Export ("gameModeParameterValue")]
		QBRGameModeParameterValue GameModeParameterValue { get; }

		[Export ("initWithGameModeParameterValue:")]
		IntPtr Constructor (QBRGameModeParameterValue gameModeParameterValue);
	}

	[BaseType (typeof (Result))]
	public partial interface QBRGameModeResult {

		[Export ("gameMode")]
		QBRGameMode GameMode { get; }
	}

	[BaseType (typeof (PagedResult))]
	public partial interface QBRGameModePagedResult {

		[Export ("gameModes")]
		NSObject [] GameModes { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBRScoreResult {

		[Export ("score")]
		QBRScore Score { get; }
	}

	[BaseType (typeof (PagedResult))]
	public partial interface QBRScorePagedResult {

		[Export ("scores")]
		NSObject [] Scores { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBRAverageResult {

		[Export ("average")]
		QBRAverage Average { get; }
	}

	[BaseType (typeof (PagedResult))]
	public partial interface QBRAveragePagedResult {

		[Export ("averages")]
		NSObject [] Averages { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBRGameModeParameterValueResult {

		[Export ("gameModeParameterValue")]
		QBRGameModeParameterValue GameModeParameterValue { get; }
	}

	[BaseType (typeof (PagedResult))]
	public partial interface QBRGameModeParameterValuePagedResult {

		[Export ("gameModeParameterValues")]
		NSObject [] GameModeParameterValues { get; }
	}

	[BaseType (typeof (QBBaseModule))]
	public partial interface QBRatings {

		[Static, Export ("createGameModeWithTitle:delegate:")]
		NSObject CreateGameModeWithTitle (string title, NSObject _delegate);

		[Static, Export ("createGameModeWithTitle:delegate:context:")]
		NSObject CreateGameModeWithTitle (string title, NSObject _delegate, NSObject context);

		[Static, Export ("gameModeWithID:delegate:")]
		NSObject GameModeWithID (uint gameModeId, NSObject _delegate);

		[Static, Export ("gameModeWithID:delegate:context:")]
		NSObject GameModeWithID (uint gameModeId, NSObject _delegate, NSObject context);

		[Static, Export ("gameModesWithDelegate:")]
		NSObject GameModesWithDelegate (NSObject _delegate);

		[Static, Export ("gameModesWithDelegate:context:")]
		NSObject GameModesWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("updateGameMode:delegate:")]
		NSObject UpdateGameMode (QBRGameMode gameMode, NSObject _delegate);

		[Static, Export ("updateGameMode:delegate:context:")]
		NSObject UpdateGameMode (QBRGameMode gameMode, NSObject _delegate, NSObject context);

		[Static, Export ("deleteGameModeWithID:delegate:")]
		NSObject DeleteGameModeWithID (uint gameModeId, NSObject _delegate);

		[Static, Export ("deleteGameModeWithID:delegate:context:")]
		NSObject DeleteGameModeWithID (uint gameModeId, NSObject _delegate, NSObject context);

		[Static, Export ("createScore:delegate:")]
		NSObject CreateScore (QBRScore score, NSObject _delegate);

		[Static, Export ("createScore:delegate:context:")]
		NSObject CreateScore (QBRScore score, NSObject _delegate, NSObject context);

		[Static, Export ("updateScore:delegate:")]
		NSObject UpdateScore (QBRScore score, NSObject _delegate);

		[Static, Export ("updateScore:delegate:context:")]
		NSObject UpdateScore (QBRScore score, NSObject _delegate, NSObject context);

		[Static, Export ("scoreWithID:delegate:")]
		NSObject ScoreWithID (uint scoreId, NSObject _delegate);

		[Static, Export ("scoreWithID:delegate:context:")]
		NSObject ScoreWithID (uint scoreId, NSObject _delegate, NSObject context);

		[Static, Export ("deleteScoreWithID:delegate:")]
		NSObject DeleteScoreWithID (uint scoreId, NSObject _delegate);

		[Static, Export ("deleteScoreWithID:delegate:context:")]
		NSObject DeleteScoreWithID (uint scoreId, NSObject _delegate, NSObject context);

		[Static, Export ("topNScores:gameModeID:delegate:")]
		NSObject TopNScores (int topN, uint gameModeID, NSObject _delegate);

		[Static, Export ("topNScores:gameModeID:delegate:context:")]
		NSObject TopNScores (int topN, uint gameModeID, NSObject _delegate, NSObject context);

		[Static, Export ("topNScores:gameModeID:extendedRequest:delegate:")]
		NSObject TopNScores (int topN, uint gameModeID, QBRScoreGetRequest extendedRequest, NSObject _delegate);

		[Static, Export ("topNScores:gameModeID:extendedRequest:delegate:context:")]
		NSObject TopNScores (int topN, uint gameModeID, QBRScoreGetRequest extendedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("scoresWithUserID:delegate:")]
		NSObject ScoresWithUserID (uint userID, NSObject _delegate);

		[Static, Export ("scoresWithUserID:delegate:context:")]
		NSObject ScoresWithUserID (uint userID, NSObject _delegate, NSObject context);

		[Static, Export ("scoresWithUserID:extendedRequest:delegate:")]
		NSObject ScoresWithUserID (uint userID, QBRScoreGetRequest extendedRequest, NSObject _delegate);

		[Static, Export ("scoresWithUserID:extendedRequest:delegate:context:")]
		NSObject ScoresWithUserID (uint userID, QBRScoreGetRequest extendedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("averageWithGameModeID:delegate:")]
		NSObject AverageWithGameModeID (uint gameModeId, NSObject _delegate);

		[Static, Export ("averageWithGameModeID:delegate:context:")]
		NSObject AverageWithGameModeID (uint gameModeId, NSObject _delegate, NSObject context);

		[Static, Export ("averagesForApplicationWithDelegate:")]
		NSObject AveragesForApplicationWithDelegate (NSObject _delegate);

		[Static, Export ("averagesForApplicationWithDelegate:context:")]
		NSObject AveragesForApplicationWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("createGameModeParameterValue:delegate:")]
		NSObject CreateGameModeParameterValue (QBRGameModeParameterValue gameModeParameterValue, NSObject _delegate);

		[Static, Export ("createGameModeParameterValue:delegate:context:")]
		NSObject CreateGameModeParameterValue (QBRGameModeParameterValue gameModeParameterValue, NSObject _delegate, NSObject context);

		[Static, Export ("gameModeParameterValueWithID:delegate:")]
		NSObject GameModeParameterValueWithID (uint gameModeParameterValueID, NSObject _delegate);

		[Static, Export ("gameModeParameterValueWithID:delegate:context:")]
		NSObject GameModeParameterValueWithID (uint gameModeParameterValueID, NSObject _delegate, NSObject context);

		[Static, Export ("updateGameModeParameterValue:delegate:")]
		NSObject UpdateGameModeParameterValue (QBRGameModeParameterValue gameModeParameterValue, NSObject _delegate);

		[Static, Export ("updateGameModeParameterValue:delegate:context:")]
		NSObject UpdateGameModeParameterValue (QBRGameModeParameterValue gameModeParameterValue, NSObject _delegate, NSObject context);
	}



	[BaseType (typeof (NSObject))]
	[Model, Protocol]
	public partial interface QBChatDelegate {

		[Export ("chatDidLogin")]
		void ChatDidLogin ();

		[Export ("chatDidNotLogin")]
		void ChatDidNotLogin ();

		[Export ("chatDidNotSendMessage:")]
		void  ChatDidNotSendMessage(QBChatMessage message);

		[Export ("chatDidReceiveMessage:")]
		void  ChatDidReceiveMessage(QBChatMessage message);

		[Export ("chatDidFailWithError:")]
		void  ChatDidFailWithError(int code);

		[Export ("chatDidReceivePresenceOfUser:type:")]
		void ChatDidReceivePresenceOfUserType (uint userID, string type);

		[Export ("chatDidReceiveContactAddRequestFromUser:")]
		void  ChatDidReceiveContactAddRequestFromUser(uint userID);

		[Export ("chatContactListDidChange:")]
		void ChatContactListDidChange(QBContactList contactList);

		[Export ("chatDidReceiveContactItemActivity:isOnline:status:")]
		void IsOnline (uint userID, bool isOnline, string status);

		[Export ("chatDidReceiveListOfRooms:")]
		void  ChatDidReceiveListOfRooms(NSObject [] rooms);

		[Export ("chatRoomDidReceiveMessage:fromRoom:")]
		void ChatRoomDidReceiveMessageFromRoom (QBChatMessage message, string roomName);

		[Export ("chatRoomDidReceiveMessage:fromRoomJID:")]
		void ChatRoomDidReceiveMessageFromRoomJID (QBChatMessage message, string roomJID);

		[Export ("chatRoomDidReceiveInformation:room:")]
		void ChatRoomDidReceiveInformationFromRoom (NSDictionary information, string roomName);

		[Export ("chatRoomDidCreate:")]
		void  ChatRoomDidCreate(string roomName);

		[Export ("chatRoomDidEnter:")]
		void ChatRoomDidEnter(QBChatRoom room);

		[Export ("chatRoomDidNotEnter:error:")]
		void ChatRoomDidNotEnterError (string roomName, NSError error);

		[Export ("chatRoomDidNotEnterRoomWithJID:error:")]
		void ChatRoomDidNotEnterRoomWithJIDError (string roomJID, NSError error);

		[Export ("chatRoomDidLeave:")]
		void  ChatRoomDidLeave(string roomName);

		[Export ("chatRoomDidLeaveRoomWithJID:")]
		void  ChatRoomDidLeaveRoomWithJID(string roomJID);

		[Export ("chatRoomDidDestroy:")]
		void  ChatRoomDidDestroy(string roomName);

		[Export ("chatRoomDidChangeOnlineUsers:room:")]
		void ChatRoomDidChangeOnlineUsersRoom ( NSObject [] onlineUsers, string roomName);

		[Export ("chatRoomDidChangeOnlineUsers:roomJID:")]
		void ChatRoomDidChangeOnlineUsersRoomJID (NSObject [] onlineUsers, string roomJID);

		[Export ("chatRoomDidReceiveListOfUsers:room:")]
		void ChatRoomDidReceiveListOfUsersRoom ( NSObject [] users, string roomName);

		[Export ("chatRoomDidReceiveListOfOnlineUsers:room:")]
		void ChatRoomDidReceiveListOfOnlineUsersRoom (NSObject [] users, string roomName);

		[Export ("chatRoomDidReceiveListOfOnlineUsers:roomJID:")]
		void ChatRoomDidReceiveListOfOnlineUsersRoomJID (NSObject [] users, string roomJID);

		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:")]
		void ChatDidReceiveCallRequestFromUserWithSessionID (uint userID, string sessionID, QBVideoChatConferenceType conferenceType);

		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:customParameters:")]
		void ChatDidReceiveCallRequestFromUserWithSessionID (uint userID, string sessionID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters);

		[Export ("chatCallUserDidNotAnswer:")]
		void  ChatCallUserDidNotAnswer(uint userID);

		[Export ("chatCallDidAcceptByUser:")]
		void  ChatCallDidAcceptByUser(uint userID);

		[Export ("chatCallDidAcceptByUser:customParameters:")]
		void ChatCallDidAcceptByUserCustomParameters (uint userID, NSDictionary customParameters);

		[Export ("chatCallDidRejectByUser:")]
		void  ChatCallDidRejectByUser(uint userID);

		[Export ("chatCallDidStopByUser:status:")]
		void ChatCallDidStopByUserStatus (uint userID, string status);

		[Export ("chatCallDidStopByUser:status:customParameters:")]
		void ChatCallDidStopByUserStatus (uint userID, string status, NSDictionary customParameters);

		[Export ("chatCallDidStartWithUser:sessionID:")]
		void ChatCallDidStartWithUserSessionID (uint userID, string sessionID);

		[Export ("didStartUseTURNForVideoChat")]
		void DidStartUseTURNForVideoChat ();

		[Export ("chatTURNServerDidDisconnect")]
		void ChatTURNServerDidDisconnect ();

		[Export ("chatTURNServerdidFailWithError:")]
		void  ChatTURNServerdidFailWithError(NSError error);

		[Export ("chatDidPassConnectionStep:totalSteps:")]
		void ChatDidPassConnectionStepTotalSteps (uint step, uint totalSteps);

		[Export ("chatDidEexceedWriteVideoQueueMaxOperationsThresholdWithCount:")]
		void  ChatDidEexceedWriteVideoQueueMaxOperationsThresholdWithCount(uint operationsInQueue);

		[Export ("chatDidEexceedWriteAudioQueueMaxOperationsThresholdWithCount:")]
		void  ChatDidEexceedWriteAudioQueueMaxOperationsThresholdWithCount(uint operationsInQueue);

		[Export ("didReceiveAudioBuffer:")]
		void  DidReceiveAudioBuffer(AudioBuffer buffer);

	
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBChatAbstractMessage {

		[Export ("ID", ArgumentSemantic.Copy)]
		string ID { get; set; }

		[Export ("text", ArgumentSemantic.Copy)]
		string Text { get; set; }

		[Export ("recipientID")]
		uint RecipientID { get; set; }

		[Export ("senderID")]
		uint SenderID { get; set; }

		[Export ("datetime", ArgumentSemantic.Copy)]
		NSDate Datetime { get; set; }

		[Export ("customParameters", ArgumentSemantic.Copy)]
		NSMutableDictionary CustomParameters { get; set; }

		[Export ("attachments", ArgumentSemantic.Copy)]
		NSObject [] Attachments { get; set; }
	}

	[BaseType (typeof (QBChatAbstractMessage))]
	public partial interface QBChatMessage {

		[Export ("senderNick", ArgumentSemantic.Copy)]
		string SenderNick { get; set; }

		[Export ("delayed")]
		bool Delayed { get; set; }

		[Export ("customObjectsClassName", ArgumentSemantic.Copy)]
		string CustomObjectsClassName { get; set; }

		[Export ("customObjectsAdditionalParameters", ArgumentSemantic.Copy)]
		NSDictionary CustomObjectsAdditionalParameters { get; set; }

		[Static, Export ("message")]
		QBChatMessage Message { get; }

		[Export ("saveWhenDeliveredToCustomObjectsWithClassName:additionalParameters:")]
		void SaveWhenDeliveredToCustomObjectsWithClassName (string classname, NSDictionary additionalParameters);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBChatRoom {

		[Export ("name")]
		string Name { get; }

		[Export ("JID")]
		string JID { get; }

		[Export ("isJoined")]
		bool IsJoined { get; }

		[Export ("initWithRoomName:")]
		IntPtr Constructor (string roomName);

		[Export ("initWithRoomName:nickname:")]
		IntPtr Constructor (string roomName, string nickname);

		[Export ("initWithRoomJID:")]
		IntPtr InitWithRoomJID (string roomJID);

		[Export ("initWithRoomJID:nickname:")]
		IntPtr InitWithRoomJIDAndNickname (string roomJID, string nickname);

		[Export ("addUsers:")]
		void AddUsers (NSObject [] users);

		[Export ("deleteUsers:")]
		void DeleteUsers (NSObject [] users);

		[Export ("sendMessage:")]
		void SendMessage (QBChatMessage message);

		[Export ("joinRoom")]
		void JoinRoom ();

		[Export ("joinRoomWithHistoryAttribute:")]
		void JoinRoomWithHistoryAttribute (NSDictionary historyAttribute);

		[Export ("leaveRoom")]
		void LeaveRoom ();

		[Export ("requestUsers")]
		void RequestUsers ();

		[Export ("requestOnlineUsers")]
		void RequestOnlineUsers ();

		[Export ("requestInformation")]
		void RequestInformation ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBChatRoomOccupant {

		[Static, Export ("occupantWithUserNickname:parameters:")]
		QBChatRoomOccupant OccupantWithUserNickname (string aNickname, NSDictionary parameters);

		[Export ("initWithUserNickname:parameters:")]
		IntPtr Constructor (string aNickname, NSDictionary parameters);

		[Export ("nickname")]
		string Nickname { get; }

		[Export ("parameters")]
		NSDictionary Parameters { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBContactList {

		[Export ("contacts")]
		NSObject [] Contacts { get; }

		[Export ("pendingApproval")]
		NSObject [] PendingApproval { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBContactListItem {

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("online")]
		bool Online { [Bind ("isOnline")] get; set; }

		[Export ("subscriptionState")]
		QBPresenseSubscriptionState SubscriptionState { get; set; }

	}

	[BaseType (typeof (NSObject))]
	public partial interface QBChatDialog {

		[Export ("ID", ArgumentSemantic.Retain)]
		string ID { get; set; }

		[Export ("roomJID", ArgumentSemantic.Retain)]
		string RoomJID { get; set; }

		[Export ("type")]
		QBChatDialogType Type { get; set; }

		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; set; }

		[Export ("lastMessageText", ArgumentSemantic.Retain)]
		string LastMessageText { get; set; }

		[Export ("lastMessageDate", ArgumentSemantic.Retain)]
		NSDate LastMessageDate { get; set; }

		[Export ("lastMessageUserID")]
		uint LastMessageUserID { get; set; }

		[Export ("unreadMessagesCount")]
		uint UnreadMessagesCount { get; set; }

		[Export ("occupantIDs", ArgumentSemantic.Retain)]
		NSNumber [] OccupantIDs { get; set; }

		[Export ("recipientID")]
		int RecipientID { get; }

		[Export ("chatRoom")]
		QBChatRoom ChatRoom { get; }
	}

	[BaseType (typeof (QBChatAbstractMessage))]
	public partial interface QBChatHistoryMessage {

		[Export ("dialogID", ArgumentSemantic.Copy)]
		string DialogID { get; set; }

		[Export ("read")]
		bool Read { [Bind ("isRead")] get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBChatAttachment {

		[Export ("type", ArgumentSemantic.Retain)]
		string Type { get; set; }

		[Export ("url", ArgumentSemantic.Retain)]
		string Url { get; set; }

		[Export ("ID", ArgumentSemantic.Retain)]
		string ID { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBVideoChat  {

		[Export ("isUseCustomVideoChatCaptureSession")]
		bool IsUseCustomVideoChatCaptureSession { get; set; }

		[Export ("isUseCustomAudioChatSession")]
		bool IsUseCustomAudioChatSession { get; set; }

		[Export ("viewToRenderOpponentVideoStream", ArgumentSemantic.Retain)]
		UIView ViewToRenderOpponentVideoStream { get; set; }

		[Export ("viewToRenderOwnVideoStream", ArgumentSemantic.Retain)]
		UIView ViewToRenderOwnVideoStream { get; set; }

		[Export ("videoChatOpponentID")]
		uint VideoChatOpponentID { get; }

		[Export ("relayUsed")]
		bool RelayUsed { [Bind ("isRelayUsed")] get; }

		[Export ("useBackCamera")]
		bool UseBackCamera { get; set; }

		[Export ("useHeadphone")]
		bool UseHeadphone { get; set; }

		[Export ("cameraFlashEnabled")]
		bool CameraFlashEnabled { [Bind ("isCameraFlashEnabled")] get; set; }

		[Export ("microphoneEnabled")]
		bool MicrophoneEnabled { [Bind ("isMicrophoneEnabled")] get; set; }

		[Export ("sessionID", ArgumentSemantic.Retain)]
		string SessionID { get; }

		[Export ("state")]
		QBVideoChatState State { get; }

		[Export ("callUser:conferenceType:")]
		void CallUser (uint userID, QBVideoChatConferenceType conferenceType);

		[Export ("callUser:conferenceType:customParameters:")]
		void CallUser (uint userID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters);

		[Export ("cancelCall")]
		void CancelCall ();

		[Export ("acceptCallWithOpponentID:conferenceType:")]
		void AcceptCallWithOpponentID (uint userID, QBVideoChatConferenceType conferenceType);

		[Export ("acceptCallWithOpponentID:conferenceType:customParameters:")]
		void AcceptCallWithOpponentID (uint userID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters);

		[Export ("rejectCallWithOpponentID:")]
		void RejectCallWithOpponentID (uint userID);

		[Export ("finishCall")]
		void FinishCall ();

		[Export ("finishCallWithCustomParameters:")]
		void FinishCallWithCustomParameters (NSDictionary customParameters);

		[Export ("videoOutputPreset")]
		string VideoOutputPreset { set; }

		[Export ("canSetVideoOutputPreset:")]
		bool CanSetVideoOutputPreset (string preset);

		[Export ("processVideoChatCaptureVideoSample:")]
		void ProcessVideoChatCaptureVideoSample (CMSampleBuffer sampleBuffer);

		[Export ("processVideoChatCaptureAudioBuffer:")]
		void ProcessVideoChatCaptureAudioBuffer (AudioBuffer buffer);

		[Export ("drainWriteVideoQueue")]
		void DrainWriteVideoQueue ();

		[Export ("drainWriteAudioQueue")]
		void DrainWriteAudioQueue ();

		[Export ("suspendStream:")]
		void SuspendStream (bool isSuspend);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBChat {

		[Export ("delegate", ArgumentSemantic.Retain)]
		QBChatDelegate Delegate { get; set; }

		[Export ("contactList")]
		QBContactList ContactList { get; }

		[Export ("useMutualSubscriptionForContactList")]
		bool UseMutualSubscriptionForContactList { get; set; }

		[Export ("registeredVideoChatInstances")]
		NSMutableArray RegisteredVideoChatInstances { get; }

		[Static, Export ("instance")]
		QBChat Instance { get; }

		[Export ("loginWithUser:")]
		bool LoginWithUser (QBUUser user);

		[Export ("isLoggedIn")]
		bool IsLoggedIn { get; }

		[Export ("logout")]
		bool Logout ();

		[Export ("sendMessage:")]
		bool SendMessage (QBChatMessage message);

		[Export ("sendPresence")]
		bool SendPresence ();

		[Export ("sendPresenceWithStatus:")]
		bool SendPresenceWithStatus (string status);

		[Export ("sendDirectPresenceWithStatus:toUser:")]
		bool SendDirectPresenceWithStatus (string status, uint userID);

		[Export ("currentUser")]
		QBUUser CurrentUser { get; }

		[Export ("addUserToContactListRequest:")]
		bool AddUserToContactListRequest (uint userID);

		[Export ("removeUserFromContactList:")]
		bool RemoveUserFromContactList (uint userID);

		[Export ("confirmAddContactRequest:")]
		bool ConfirmAddContactRequest (uint userID);

		[Export ("rejectAddContactRequest:")]
		bool RejectAddContactRequest (uint userID);

		[Export ("createOrJoinRoomWithName:membersOnly:persistent:")]
		bool CreateOrJoinRoomWithName (string name, bool isMembersOnly, bool isPersistent);

		[Export ("createOrJoinRoomWithJID:membersOnly:persistent:historyAttribute:")]
		bool CreateOrJoinRoomWithJID (string roomJID, bool isMembersOnly, bool isPersistent, NSDictionary historyAttribute);

		[Export ("createOrJoinRoomWithName:nickname:membersOnly:persistent:")]
		bool CreateOrJoinRoomWithName (string name, string nickname, bool isMembersOnly, bool isPersistent);

		[Export ("createOrJoinRoomWithJID:nickname:membersOnly:persistent:historyAttribute:")]
		bool CreateOrJoinRoomWithJID (string roomJID, string nickname, bool isMembersOnly, bool isPersistent, NSDictionary historyAttribute);

		[Export ("joinRoom:")]
		bool JoinRoom (QBChatRoom room);

		[Export ("joinRoom:historyAttribute:")]
		bool JoinRoom (QBChatRoom room, NSDictionary historyAttribute);

		[Export ("leaveRoom:")]
		bool LeaveRoom (QBChatRoom room);

		[Export ("destroyRoom:")]
		bool DestroyRoom (QBChatRoom room);

		[Export ("sendMessage:toRoom:")]
		bool SendMessage (string message, QBChatRoom room);

		[Export ("sendChatMessage:toRoom:")]
		bool SendChatMessage (QBChatMessage message, QBChatRoom room);

		[Export ("sendPresenceWithParameters:toRoom:")]
		bool SendPresenceWithParameters (NSDictionary parameters, QBChatRoom room);

		[Export ("sendPresenceWithStatus:show:priority:customParameters:toRoom:")]
		bool SendPresenceWithStatus (string status, bool show, short priority, NSDictionary customParameters, QBChatRoom room);

		[Export ("requestAllRooms")]
		bool RequestAllRooms ();

		[Export ("requestRoomInformation:")]
		bool RequestRoomInformation (QBChatRoom room);

		[Export ("requestRoomUsers:")]
		bool RequestRoomUsers (QBChatRoom room);

		[Export ("requestRoomOnlineUsers:")]
		bool RequestRoomOnlineUsers (QBChatRoom room);

		[Export ("addUsers:toRoom:")]
		bool AddUsers ( NSObject [] usersIDs, QBChatRoom room);

		[Export ("deleteUsers:fromRoom:")]
		bool DeleteUsers ( NSObject [] usersIDs, QBChatRoom room);

		[Export ("createAndRegisterVideoChatInstance")]
		QBVideoChat CreateAndRegisterVideoChatInstance { get; }

		[Export ("createAndRegisterVideoChatInstanceWithSessionID:")]
		QBVideoChat CreateAndRegisterVideoChatInstanceWithSessionID (string sessionID);

		[Export ("unregisterVideoChatInstance:")]
		void UnregisterVideoChatInstance (QBVideoChat videoChat);

		[Static, Export ("dialogsWithDelegate:")]
		NSObject DialogsWithDelegate (NSObject _delegate);

		[Static, Export ("dialogsWithDelegate:context:")]
		NSObject DialogsWithDelegate (NSObject _delegate, NSObject context);

		[Static, Export ("dialogsWithExtendedRequest:delegate:")]
		NSObject DialogsWithExtendedRequest (NSMutableDictionary extendedRequest, NSObject _delegate);

		[Static, Export ("dialogsWithExtendedRequest:delegate:context:")]
		NSObject DialogsWithExtendedRequest (NSMutableDictionary extendedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("createDialog:delegate:")]
		NSObject CreateDialog (QBChatDialog dialog, NSObject _delegate);

		[Static, Export ("createDialog:delegate:context:")]
		NSObject CreateDialog (QBChatDialog dialog, NSObject _delegate, NSObject context);

		[Static, Export ("updateDialogWithID:extendedRequest:delegate:")]
		NSObject UpdateDialogWithID (string dialogID, NSMutableDictionary extendedRequest, NSObject _delegate);

		[Static, Export ("updateDialogWithID:extendedRequest:delegate:context:")]
		NSObject UpdateDialogWithID (string dialogID, NSMutableDictionary extendedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("messagesWithDialogID:delegate:")]
		NSObject MessagesWithDialogID (string dialogID, NSObject _delegate);

		[Static, Export ("messagesWithDialogID:delegate:context:")]
		NSObject MessagesWithDialogID (string dialogID, NSObject _delegate, NSObject context);

		[Static, Export ("messagesWithDialogID:extendedRequest:delegate:")]
		NSObject MessagesWithDialogID (string dialogID, NSMutableDictionary extendedRequest, NSObject _delegate);

		[Static, Export ("messagesWithDialogID:extendedRequest:delegate:context:")]
		NSObject MessagesWithDialogID (string dialogID, NSMutableDictionary extendedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("updateMessage:delegate:")]
		NSObject UpdateMessage (QBChatHistoryMessage message, NSObject _delegate);

		[Static, Export ("updateMessage:delegate:context:")]
		NSObject UpdateMessage (QBChatHistoryMessage message, NSObject _delegate, NSObject context);

		[Static, Export ("deleteMessageWithID:delegate:")]
		NSObject DeleteMessageWithID (string messageID, NSObject _delegate);

		[Static, Export ("deleteMessageWithID:delegate:context:")]
		NSObject DeleteMessageWithID (string messageID, NSObject _delegate, NSObject context);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBChatQuery {

	}

	[BaseType (typeof (QBChatQuery))]
	public partial interface QBDialogGetQuery {

		[Export ("getRequest")]
		NSMutableDictionary GetRequest { get; }

		[Export ("initWithGetRequest:")]
		IntPtr Constructor (NSMutableDictionary _getRequest);
	}

	[BaseType (typeof (QBChatQuery))]
	public partial interface QBChatHistoryMessageGetQuery {

		[Export ("initWithDialogID:")]
		IntPtr Constructor (string _dialogID);

		[Export ("initWithDialogID:extendedRequest:")]
		IntPtr Constructor (string _dialogID, NSMutableDictionary extendedRequest);
	}

	[BaseType (typeof (QBChatQuery))]
	public partial interface QBChatDialogCreateQuery {

		[Export ("dialog", ArgumentSemantic.Retain)]
		QBChatDialog Dialog { get; set; }

		[Export ("initWithDialog:")]
		IntPtr Constructor (QBChatDialog dialog);
	}

	[BaseType (typeof (QBChatQuery))]
	public partial interface QBChatDialogUpdateQuery {

		[Export ("chatDialogID", ArgumentSemantic.Retain)]
		string ChatDialogID { get; }

		[Export ("extendedRequest", ArgumentSemantic.Retain)]
		NSMutableDictionary ExtendedRequest { get; }

		[Export ("initWithChatDialogID:extendedRequest:")]
		IntPtr Constructor (string dialogID, NSMutableDictionary extendedRequest);
	}

	[BaseType (typeof (QBChatQuery))]
	public partial interface QBChatHistoryMessageUpdateQuery {

		[Export ("message", ArgumentSemantic.Retain)]
		QBChatHistoryMessage Message { get; }

		[Export ("initWithMessage:")]
		IntPtr Constructor (QBChatHistoryMessage message);
	}

	[BaseType (typeof (QBChatQuery))]
	public partial interface QBChatHistoryMessageDeleteQuery {

		[Export ("messageID", ArgumentSemantic.Retain)]
		string MessageID { get; }

		[Export ("initWithMessageID:")]
		IntPtr Constructor (string messageID);
	}

	[BaseType (typeof (XmlAnswer))]
	public partial interface QBChatDialogAnswer {

		[Export ("dialog", ArgumentSemantic.Retain)]
		QBChatDialog Dialog { get; set; }
	}

	[BaseType (typeof (XmlAnswer))]
	public partial interface QBChatDialogPagedAnswer {

		[Export ("dialogs")]
		NSMutableArray Dialogs { get; }
	}

	[BaseType (typeof (XmlAnswer))]
	public partial interface QBChatHistoryMessageAnswer {

		[Export ("messages")]
		NSMutableArray Messages { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBDialogsPagedResult {

		[Export ("dialogs")]
		NSObject [] Dialogs { get; }

		[Export ("dialogsUsersIDs")]
		NSSet DialogsUsersIDs { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBChatHistoryMessageResult {

		[Export ("messages")]
		NSMutableArray Messages { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBChatDialogResult {

		[Export ("dialog")]
		QBChatDialog Dialog { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBChatUtils {

		[Static, Export ("JIDFromCurrentUserID:")]
		string JIDFromCurrentUserID (uint userID);

		[Static, Export ("JIDFromUserID:")]
		string JIDFromUserID (uint userID);

		[Static, Export ("userIDFromJID:")]
		uint UserIDFromJID (string jid);

		[Static, Export ("messageFromXMPPMessage:roomNick:")]
		QBChatMessage MessageFromXMPPMessage (NSObject message, string roomNick);

		[Static, Export ("xmppMessageFromQBChatMessage:room:")]
		NSObject XmppMessageFromQBChatMessage (QBChatMessage message, QBChatRoom room);

		[Static, Export ("parametersFromPresence:")]
		NSDictionary ParametersFromPresence (NSObject presence);

		[Static, Export ("roomNameFromJID:")]
		string RoomNameFromJID (string roomJID);

		[Static, Export ("roomJIDFromName:")]
		string RoomJIDFromName (string roomName);

		[Static, Export ("roomFromJID:name:andAddDelegate:")]
		QBChatRoom RoomFromJID (string roomJID, string roomName, bool addDelegate);

		[Static, Export ("roomNameToValidRoomName:")]
		string RoomNameToValidRoomName (string roomName);

		[Static, Export ("CGImageRotatedByAngle:angle:")]
		CGImage CGImageRotatedByAngle (CGImage imgRef, float angle);

		[Static, Export ("customParametersFromXMPPMessage:")]
		NSMutableDictionary CustomParametersFromXMPPMessage (NSObject message);

		[Static, Export ("attachmentsFromXMPPMessage:")]
		NSObject [] AttachmentsFromXMPPMessage (NSObject xmppMessage);

		[Static, Export ("setCustomParameters:attachments:extensionName:toXMPPMessage:")]
		void SetCustomParameters (NSDictionary customParameters, NSObject [] attachments, string extensionName, NSObject xmppMessage);

		[Static, Export ("getIPAddress")]
		string GetIPAddress { get; }

		[Static, Export ("extractParametersToRequestURL:requestURL:")]
		void ExtractParametersToRequestURL (NSMutableDictionary parameters, NSMutableString requestURL);
	}



	[BaseType (typeof (NSObject))]
	public partial interface QBCOCustomObject {

		[Export ("ID", ArgumentSemantic.Retain)]
		string ID { get; set; }

		[Export ("parentID", ArgumentSemantic.Retain)]
		string ParentID { get; set; }

		[Export ("createdAt", ArgumentSemantic.Retain)]
		NSDate CreatedAt { get; set; }

		[Export ("updatedAt", ArgumentSemantic.Retain)]
		NSDate UpdatedAt { get; set; }

		[Export ("className", ArgumentSemantic.Retain)]
		string ClassName { get; set; }

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("fields", ArgumentSemantic.Retain)]
		NSMutableDictionary Fields { get; set; }

		[Export ("permissions", ArgumentSemantic.Retain)]
		QBCOPermissions Permissions { get; set; }

		[Static, Export ("customObject")]
		QBCOCustomObject CustomObject { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOPermissions {

		[Export ("recordID", ArgumentSemantic.Retain)]
		string RecordID { get; set; }

		[Export ("readAccess")]
		QBCOPermissionsAccess ReadAccess { get; set; }

		[Export ("updateAccess")]
		QBCOPermissionsAccess UpdateAccess { get; set; }

		[Export ("deleteAccess")]
		QBCOPermissionsAccess DeleteAccess { get; set; }

		[Export ("usersIDsForReadAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersIDsForReadAccess { get; set; }

		[Export ("usersGroupsForReadAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersGroupsForReadAccess { get; set; }

		[Export ("usersIDsForUpdateAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersIDsForUpdateAccess { get; set; }

		[Export ("usersGroupsForUpdateAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersGroupsForUpdateAccess { get; set; }

		[Export ("usersIDsForDeleteAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersIDsForDeleteAccess { get; set; }

		[Export ("usersGroupsForDeleteAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersGroupsForDeleteAccess { get; set; }

		[Static, Export ("permissions")]
		QBCOPermissions Permissions { get; }

	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOFile {

		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; set; }

		[Export ("contentType", ArgumentSemantic.Retain)]
		string ContentType { get; set; }

		[Export ("data", ArgumentSemantic.Retain)]
		NSData Data { get; set; }

		[Static, Export ("file")]
		QBCOFile File { get; }
	}

	[BaseType (typeof (XmlAnswer))]
	public partial interface QBCOPermissionsAnswer {

		[Export ("permissions")]
		QBCOPermissions Permissions { get; }
	}

	[BaseType (typeof (XmlAnswer))]
	public partial interface QBCOCustomObjectAnswer {

		[Export ("object")]
		QBCOCustomObject NSObject { get; }
	}

	[BaseType (typeof (XmlAnswer))]
	public partial interface QBCOMultiDeleteAnswer {

		[Export ("deletedObjectsIDs")]
		NSObject [] DeletedObjectsIDs { get; }

		[Export ("notFoundObjectsIDs")]
		NSObject [] NotFoundObjectsIDs { get; }

		[Export ("wrongPermissionsObjectsIDs")]
		NSObject [] WrongPermissionsObjectsIDs { get; }
	}

	[BaseType (typeof (XmlAnswer))]
	public partial interface QBCOCustomObjectPagedAnswer {

		[Export ("objects")]
		NSMutableArray Objects { get; }

		[Export ("count")]
		uint Count { get; }

		[Export ("skip")]
		uint Skip { get; }

		[Export ("limit")]
		uint Limit { get; }

		[Export ("notFoundObjectsIDs")]
		NSObject [] NotFoundObjectsIDs { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOCustomObjectQuery {

	}

	[BaseType (typeof (QBCOCustomObjectQuery))]
	public partial interface QBCOCustomObjectCreateQuery {

		[Export ("object")]
		QBCOCustomObject NSObject { get; }

		[Export ("initWithObject:")]
		IntPtr Constructor (QBCOCustomObject _object);
	}

	[BaseType (typeof (QBCOCustomObjectQuery))]
	public partial interface QBCOCustomObjectsCreateQuery {

		[Export ("objects")]
		NSObject [] Objects { get; }

		[Export ("className")]
		string ClassName { get; }

		[Export ("initWithObjects:className:")]
		IntPtr Constructor (NSObject [] objects, string className);
	}

	[BaseType (typeof (QBCOCustomObjectQuery))]
	public partial interface QBCOCustomObjectUpdateQuery {

		[Export ("object")]
		QBCOCustomObject NSObject { get; }

		[Export ("specialUpdateOperators")]
		NSMutableDictionary SpecialUpdateOperators { get; }

		[Export ("initWithObject:specialUpdateOperators:")]
		IntPtr Constructor (QBCOCustomObject _object, NSMutableDictionary specialUpdateOperators);
	}

	[BaseType (typeof (QBCOCustomObjectQuery))]
	public partial interface QBCOCustomObjectsUpdateQuery {

		[Export ("objects")]
		NSObject [] Objects { get; }

		[Export ("className")]
		string ClassName { get; }

		[Export ("specialUpdateOperators")]
		NSObject [] SpecialUpdateOperators { get; }

		[Export ("initWithObjects:className:specialUpdateOperators:")]
		IntPtr Constructor (NSObject [] objects, string className, NSObject [] specialUpdateOperators);
	}

	[BaseType (typeof (QBCOCustomObjectQuery))]
	public partial interface QBCOCustomObjectDeleteQuery {

		[Export ("object")]
		QBCOCustomObject NSObject { get; }

		[Export ("initWithObject:")]
		IntPtr Constructor (QBCOCustomObject _object);
	}

	[BaseType (typeof (QBCOCustomObjectQuery))]
	public partial interface QBCOMultiDeleteQuery {

		[Export ("className")]
		string ClassName { get; }

		[Export ("objectsIDs")]
		NSObject [] ObjectsIDs { get; }

		[Export ("initWithClassName:objectsIDs:")]
		IntPtr Constructor (string className, NSObject [] objectsIDs);
	}

	[BaseType (typeof (QBCOCustomObjectQuery))]
	public partial interface QBCOCustomObjectGetQuery {

		[Export ("getRequest")]
		NSMutableDictionary GetRequest { get; }

		[Export ("className")]
		string ClassName { get; }

		[Export ("ID")]
		string ID { get; }

		[Export ("IDs")]
		NSObject [] IDs { get; }

		[Export ("initWithClassName:request:")]
		IntPtr Constructor (string _className, NSMutableDictionary _getRequest);

		[Export ("initWithClassName:ID:")]
		IntPtr Constructor (string _className, string _ID);

		[Export ("initWithClassName:IDs:")]
		IntPtr Constructor (string _className, NSObject [] _IDs);
	}

	[BaseType (typeof (QBCOCustomObjectQuery))]
	public partial interface QBCOFileQuery {

		[Export ("className")]
		string ClassName { get; }

		[Export ("objectID")]
		string ObjectID { get; }

		[Export ("fileFieldName")]
		string FileFieldName { get; }

		[Export ("initWithClassName:objectID:fileFieldName:")]
		IntPtr Constructor (string className, string objectID, string fileFieldName);
	}

	[BaseType (typeof (QBCOFileQuery))]
	public partial interface QBCOFileUploadQuery {

		[Export ("file", ArgumentSemantic.Retain)]
		QBCOFile File { get; set; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCOCustomObjectResult {

		[Export ("object")]
		QBCOCustomObject NSObject { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCOMultiDeleteResult {

		[Export ("deletedObjectsIDs")]
		NSObject [] DeletedObjectsIDs { get; }

		[Export ("notFoundObjectsIDs")]
		NSObject [] NotFoundObjectsIDs { get; }

		[Export ("wrongPermissionsObjectsIDs")]
		NSObject [] WrongPermissionsObjectsIDs { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCOCustomObjectPagedResult {

		[Export ("objects")]
		NSObject [] Objects { get; }

		[Export ("count")]
		uint Count { get; }

		[Export ("skip")]
		uint Skip { get; }

		[Export ("limit")]
		uint Limit { get; }

		[Export ("notFoundObjectsIDs")]
		NSObject [] NotFoundObjectsIDs { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCOPermissionsResult {

		[Export ("permissions")]
		QBCOPermissions Permissions { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCOFileResult {

		[Export ("data")]
		NSData Data { get; }
	}

	[BaseType (typeof (QBBaseModule))]
	public partial interface QBCustomObjects {

		[Static, Export ("objectWithClassName:ID:delegate:")]
		NSObject ObjectWithClassName (string className, string ID, NSObject _delegate);

		[Static, Export ("objectWithClassName:ID:delegate:context:")]
		NSObject ObjectWithClassName (string className, string ID, NSObject _delegate, NSObject context);

		[Static, Export ("objectsWithClassName:IDs:delegate:")]
		NSObject ObjectsWithClassName (string className, NSObject [] IDs, NSObject _delegate);

		[Static, Export ("objectsWithClassName:IDs:delegate:context:")]
		NSObject ObjectsWithClassName (string className, NSObject [] IDs, NSObject _delegate, NSObject context);

		[Static, Export ("objectsWithClassName:delegate:")]
		NSObject ObjectsWithClassName (string className, NSObject _delegate);

		[Static, Export ("objectsWithClassName:delegate:context:")]
		NSObject ObjectsWithClassName (string className, NSObject _delegate, NSObject context);

		[Static, Export ("objectsWithClassName:extendedRequest:delegate:")]
		NSObject ObjectsWithClassName (string className, NSMutableDictionary extendedRequest, NSObject _delegate);

		[Static, Export ("objectsWithClassName:extendedRequest:delegate:context:")]
		NSObject ObjectsWithClassName (string className, NSMutableDictionary extendedRequest, NSObject _delegate, NSObject context);

		[Static, Export ("createObject:delegate:")]
		NSObject CreateObject (QBCOCustomObject _object, NSObject _delegate);

		[Static, Export ("createObject:delegate:context:")]
		NSObject CreateObject (QBCOCustomObject _object, NSObject _delegate, NSObject context);

		[Static, Export ("createObjects:className:delegate:")]
		NSObject CreateObjects (NSObject [] objects, string className, NSObject _delegate);

		[Static, Export ("createObjects:className:delegate:context:")]
		NSObject CreateObjects (NSObject [] objects, string className, NSObject _delegate, NSObject context);

		[Static, Export ("updateObject:delegate:")]
		NSObject UpdateObject (QBCOCustomObject _object, NSObject _delegate);

		[Static, Export ("updateObject:delegate:context:")]
		NSObject UpdateObject (QBCOCustomObject _object, NSObject _delegate, NSObject context);

		[Static, Export ("updateObject:specialUpdateOperators:delegate:")]
		NSObject UpdateObject (QBCOCustomObject _object, NSMutableDictionary specialUpdateOperators, NSObject _delegate);

		[Static, Export ("updateObject:specialUpdateOperators:delegate:context:")]
		NSObject UpdateObject (QBCOCustomObject _object, NSMutableDictionary specialUpdateOperators, NSObject _delegate, NSObject context);

		[Static, Export ("updateObjects:className:delegate:")]
		NSObject UpdateObjects (NSObject [] objects, string className, NSObject _delegate);

		[Static, Export ("updateObjects:className:delegate:context:")]
		NSObject UpdateObjects (NSObject [] objects, string className, NSObject _delegate, NSObject context);

		[Static, Export ("deleteObjectWithID:className:delegate:")]
		NSObject DeleteObjectWithID (string objectID, string className, NSObject _delegate);

		[Static, Export ("deleteObjectWithID:className:delegate:context:")]
		NSObject DeleteObjectWithID (string objectID, string className, NSObject _delegate, NSObject context);

		[Static, Export ("deleteObjectsWithIDs:className:delegate:")]
		NSObject DeleteObjectsWithIDs  (NSObject [] objectsIDs, string className, NSObject _delegate);

		[Static, Export ("deleteObjectsWithIDs:className:delegate:context:")]
		NSObject DeleteObjectsWithIDs (NSObject [] objectsIDs, string className, NSObject _delegate, NSObject context);

		[Static, Export ("permissionsForObjectWithClassName:ID:delegate:")]
		NSObject PermissionsForObjectWithClassName (string className, string ID, NSObject _delegate);

		[Static, Export ("permissionsForObjectWithClassName:ID:delegate:context:")]
		NSObject PermissionsForObjectWithClassName (string className, string ID, NSObject _delegate, NSObject context);

		[Static, Export ("uploadFile:className:objectID:fileFieldName:delegate:")]
		NSObject UploadFile (QBCOFile file, string className, string objectID, string fileFieldName, NSObject _delegate);

		[Static, Export ("uploadFile:className:objectID:fileFieldName:delegate:context:")]
		NSObject UploadFile (QBCOFile file, string className, string objectID, string fileFieldName, NSObject _delegate, NSObject context);

		[Static, Export ("downloadFileFromClassName:objectID:fileFieldName:delegate:")]
		NSObject DownloadFileFromClassName (string className, string objectID, string fileFieldName, NSObject _delegate);

		[Static, Export ("downloadFileFromClassName:objectID:fileFieldName:delegate:context:")]
		NSObject DownloadFileFromClassName (string className, string objectID, string fileFieldName, NSObject _delegate, NSObject context);

		[Static, Export ("deleteFileFromClassName:objectID:fileFieldName:delegate:")]
		NSObject DeleteFileFromClassName (string className, string objectID, string fileFieldName, NSObject _delegate);

		[Static, Export ("deleteFileFromClassName:objectID:fileFieldName:delegate:context:")]
		NSObject DeleteFileFromClassName (string className, string objectID, string fileFieldName, NSObject _delegate, NSObject context);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOUtils {

		[Static, Export ("extractFieldsToRequestParams:requestParams:keyFormat:")]
		void ExtractFieldsToRequestParams (QBCOCustomObject record, NSMutableDictionary requestParams, string keyFormat);

		[Static, Export ("extractPermissionsToRequestParams:requestParams:keyFormat:")]
		void ExtractPermissionsToRequestParams (QBCOCustomObject record, NSMutableDictionary requestParams, string keyFormat);

		[Static, Export ("extractSpecialUpdateOperatorsToRequestParams:requestParams:keyFormat:")]
		void ExtractSpecialUpdateOperatorsToRequestParams (NSDictionary specialUpdateOperators, NSMutableDictionary requestParams, string keyFormat);

		[Static, Export ("extractParametersToRequestURL:requestURL:keyFormat:")]
		void ExtractParametersToRequestURL (NSDictionary parameters, NSMutableString requestURL, string keyFormat);
	}


	/*
	[BaseType (typeof (NSObject))]
	public partial interface QBSettings {

		[Static, Export ("applicationID")]
		uint ApplicationID { get; set; }

		[Static, Export ("authorizationKey")]
		string AuthorizationKey { get; set; }

		[Static, Export ("authorizationSecret")]
		string AuthorizationSecret { get; set; }

		[Static, Export ("serverDomain")]
		string ServerDomain { get; set; }
		
		[Static, Export ("serverApiDomain")]
		string ServerApiDomain { get; set; }

		[Static, Export ("serverChatDomain")]
		string ServerChatDomain { get; set; }

		[Static, Export ("serverZone")]
		QBServerZone ServerZone { get; set; }

		[Static, Export ("serverZoneAsString")]
		string ServerZoneAsString { get; }

		[Static, Export ("useHTTPS:")]
		void UseHTTPS (bool useHTTPS);

		[Static, Export ("isUseHTTPS")]
		bool IsUseHTTPS { get; }

		[Static, Export ("logLevel")]
		QBLogLevel LogLevel { get; set; }

		[Static, Export ("timeOutSeconds")]
		int TimeOutSeconds { get; set; }

		[Static, Export ("restAPIVersion")]
		string RestAPIVersion { get; set; }

		[Static, Export ("enableSessionExpirationAutoHandler:")]
		void EnableSessionExpirationAutoHandler (bool isEnable);

		[Static, Export ("isEnabledSessionExpirationAutoHandler")]
		bool IsEnabledSessionExpirationAutoHandler { get; }

		[Static, Export ("useProductionEnvironmentForPushNotifications:")]
		void UseProductionEnvironmentForPushNotifications (bool useProductionEnvironment);

		[Static, Export ("isUseProductionEnvironmentForPushNotifications")]
		bool IsUseProductionEnvironmentForPushNotifications { get; }

		[Static, Export ("contentBucket")]
		string ContentBucket { get; set; }

		[Static, Export ("videoChatConfiguration")]
		NSDictionary VideoChatConfiguration { get; set; }
	}
	
	[BaseType (typeof (NSObject))]
	public interface QBAuth {

		[Static, Export ("createSessionWithDelegate:")]
		Cancelable CreateSessionWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("createSessionWithDelegate:context:")]
		Cancelable CreateSessionWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("createSessionWithExtendedRequest:delegate:")]
		NSObject CreateSessionWithExtendedRequest (QBASessionCreationRequest extendedRequest, NSObject del);

		[Static, Export ("createSessionWithExtendedRequest:delegate:context:")]
		NSObject CreateSessionWithExtendedRequest (QBASessionCreationRequest extendedRequest, NSObject del,  NSObject context);

		[Static, Export ("destroySessionWithDelegate:")]
		NSObject DestroySessionWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("destroySessionWithDelegate:context:")]
		NSObject DestroySessionWithDelegate (QBActionStatusDelegate del, NSObject context);
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBUsers {

		[Static, Export ("logInWithUserLogin:password:delegate:")]
		NSObject LogInWithUserLogin (string login, string password, QBActionStatusDelegate del);

		[Static, Export ("logInWithUserLogin:password:delegate:context:")]
		NSObject LogInWithUserLogin (string login, string password, QBActionStatusDelegate del,  NSObject context);

		[Static, Export ("logInWithUserEmail:password:delegate:")]
		NSObject LogInWithUserEmail (string email, string password, QBActionStatusDelegate del);

		[Static, Export ("logInWithUserEmail:password:delegate:context:")]
		NSObject LogInWithUserEmail (string email, string password, QBActionStatusDelegate del,  NSObject context);

		[Static, Export ("logInWithSocialProvider:scope:delegate:")]
		NSObject LogInWithSocialProvider (string provider, NSObject [] scope, QBActionStatusDelegate del);

		[Static, Export ("logInWithSocialProvider:scope:delegate:context:")]
		NSObject LogInWithSocialProvider (string provider, NSObject [] scope, QBActionStatusDelegate del,  NSObject context);

		[Static, Export ("logInWithSocialProvider:accessToken:accessTokenSecret:delegate:")]
		NSObject LogInWithSocialProvider (string provider, string accessToken, string accessTokenSecret, QBActionStatusDelegate del);

		[Static, Export ("logInWithSocialProvider:accessToken:accessTokenSecret:delegate:context:")]
		NSObject LogInWithSocialProvider (string provider, string accessToken, string accessTokenSecret, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("logOutWithDelegate:")]
		NSObject LogOutWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("logOutWithDelegate:context:")]
		NSObject LogOutWithDelegate (NSObject del, QBActionStatusDelegate context);

		[Static, Export ("usersWithDelegate:")]
		NSObject UsersWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("usersWithDelegate:context:")]
		NSObject UsersWithDelegate (NSObject del, QBActionStatusDelegate context);

		[Static, Export ("usersWithPagedRequest:delegate:")]
		NSObject UsersWithPagedRequest (PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithPagedRequest:delegate:context:")]
		NSObject UsersWithPagedRequest (PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("signUp:delegate:")]
		NSObject SignUp (QBUUser user, QBActionStatusDelegate del);

		[Static, Export ("signUp:delegate:context:")]
		NSObject SignUp (QBUUser user, NSObject del, QBActionStatusDelegate context);

		[Static, Export ("userWithID:delegate:")]
		NSObject UserWithID (uint userID, QBActionStatusDelegate del);

		[Static, Export ("userWithID:delegate:context:")]
		NSObject UserWithID (uint userID, NSObject del, QBActionStatusDelegate context);

		[Static, Export ("usersWithIDs:delegate:")]
		NSObject UsersWithIDs (string ids, QBActionStatusDelegate del);

		[Static, Export ("usersWithIDs:delegate:context:")]
		NSObject UsersWithIDs (string ids, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithIDs:pagedRequest:delegate:")]
		NSObject UsersWithIDs (string ids, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithIDs:pagedRequest:delegate:context:")]
		NSObject UsersWithIDs (string ids, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("userWithLogin:delegate:")]
		NSObject UserWithLogin (string userLogin, QBActionStatusDelegate del);

		[Static, Export ("userWithLogin:delegate:context:")]
		NSObject UserWithLogin (string userLogin, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithLogins:delegate:")]
		NSObject UsersWithLogins (string[] logins, QBActionStatusDelegate del);

		[Static, Export ("usersWithLogins:delegate:context:")]
		NSObject UsersWithLogins (string[] logins, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithLogins:pagedRequest:delegate:")]
		NSObject UsersWithLogins (string[] logins, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithLogins:pagedRequest:delegate:context:")]
		NSObject UsersWithLogins (string[] logins, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithFullName:delegate:")]
		NSObject UsersWithFullName (string userFullName, QBActionStatusDelegate del);

		[Static, Export ("usersWithFullName:delegate:context:")]
		NSObject UsersWithFullName (string userFullName, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithFullName:pagedRequest:delegate:")]
		NSObject UsersWithFullName (string userFullName, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithFullName:pagedRequest:delegate:context:")]
		NSObject UsersWithFullName (string userFullName, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithTags:delegate:")]
		NSObject UsersWithTags (string[] tags, QBActionStatusDelegate del);

		[Static, Export ("usersWithTags:delegate:context:")]
		NSObject UsersWithTags (string[] tags, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithTags:pagedRequest:delegate:")]
		NSObject UsersWithTags (string[] tags, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithTags:pagedRequest:delegate:context:")]
		NSObject UsersWithTags (string[] tags, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithPhoneNumbers:delegate:")]
		NSObject UsersWithPhoneNumbers (string[] tags, QBActionStatusDelegate del);

		[Static, Export ("usersWithPhoneNumbers:delegate:context:")]
		NSObject UsersWithPhoneNumbers (string[] tags, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithPhoneNumbers:pagedRequest:delegate:")]
		NSObject UsersWithPhoneNumbers (string[] tags, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithPhoneNumbers:pagedRequest:delegate:context:")]
		NSObject UsersWithPhoneNumbers (string[] tags, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("userWithFacebookID:delegate:")]
		NSObject UserWithFacebookID (string userFacebookID, QBActionStatusDelegate del);

		[Static, Export ("userWithFacebookID:delegate:context:")]
		NSObject UserWithFacebookID (string userFacebookID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithFacebookIDs:delegate:")]
		NSObject UsersWithFacebookIDs (string[] facebookIDs, QBActionStatusDelegate del);

		[Static, Export ("usersWithFacebookIDs:delegate:context:")]
		NSObject UsersWithFacebookIDs (string[] facebookIDs, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithFacebookIDs:pagedRequest:delegate:")]
		NSObject UsersWithFacebookIDs (string[] facebookIDs, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithFacebookIDs:pagedRequest:delegate:context:")]
		NSObject UsersWithFacebookIDs (string[] facebookIDs, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("userWithTwitterID:delegate:")]
		NSObject UserWithTwitterID (string userTwitterID, QBActionStatusDelegate del);

		[Static, Export ("userWithTwitterID:delegate:context:")]
		NSObject UserWithTwitterID (string userTwitterID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithTwitterIDs:delegate:")]
		NSObject UsersWithTwitterIDs (string[] twitterIDs, QBActionStatusDelegate del);

		[Static, Export ("usersWithTwitterIDs:delegate:context:")]
		NSObject UsersWithTwitterIDs (string[] twitterIDs, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithTwitterIDs:pagedRequest:delegate:")]
		NSObject UsersWithTwitterIDs (string[] twitterIDs, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithTwitterIDs:pagedRequest:delegate:context:")]
		NSObject UsersWithTwitterIDs (string[] twitterIDs, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("userWithEmail:delegate:")]
		NSObject UserWithEmail (string userEmail, QBActionStatusDelegate del);

		[Static, Export ("userWithEmail:delegate:context:")]
		NSObject UserWithEmail (string userEmail, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithEmails:delegate:")]
		NSObject UsersWithEmails (string[] emails, QBActionStatusDelegate del);

		[Static, Export ("usersWithEmails:delegate:context:")]
		NSObject UsersWithEmails (string[] emails, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("usersWithEmails:pagedRequest:delegate:")]
		NSObject UsersWithEmails (string[] emails, PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("usersWithEmails:pagedRequest:delegate:context:")]
		NSObject UsersWithEmails (string[] emails, PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("userWithExternalID:delegate:")]
		NSObject UserWithExternalID (uint userExternalID, QBActionStatusDelegate del);

		[Static, Export ("userWithExternalID:delegate:context:")]
		NSObject UserWithExternalID (uint userExternalID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("updateUser:delegate:")]
		NSObject UpdateUser (QBUUser user, QBActionStatusDelegate del);

		[Static, Export ("updateUser:delegate:context:")]
		NSObject UpdateUser (QBUUser user, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("deleteUserWithID:delegate:")]
		NSObject DeleteUserWithID (uint userID, QBActionStatusDelegate del);

		[Static, Export ("deleteUserWithID:delegate:context:")]
		NSObject DeleteUserWithID (uint userID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("deleteUserWithExternalID:delegate:")]
		NSObject DeleteUserWithExternalID (uint userExternalID, QBActionStatusDelegate del);

		[Static, Export ("deleteUserWithExternalID:delegate:context:")]
		NSObject DeleteUserWithExternalID (uint userExternalID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("resetUserPasswordWithEmail:delegate:")]
		NSObject ResetUserPasswordWithEmail (string email, QBActionStatusDelegate del);

		[Static, Export ("resetUserPasswordWithEmail:delegate:context:")]
		NSObject ResetUserPasswordWithEmail (string email, QBActionStatusDelegate del, NSObject context);
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface Entity {

		[Export ("ID")]
		uint ID { get; set; }

		[Export ("createdAt", ArgumentSemantic.Retain)]
		NSDate CreatedAt { get; set; }

		[Export ("updatedAt", ArgumentSemantic.Retain)]
		NSDate UpdatedAt { get; set; }
	}
	
	[BaseType (typeof (Entity))]
	public partial interface QBUUser {

		[Export ("externalUserID")]
		uint ExternalUserID { get; set; }

		[Export ("blobID")]
		uint BlobID { get; set; }

		[Export ("facebookID", ArgumentSemantic.Retain)]
		string FacebookID { get; set; }

		[Export ("twitterID", ArgumentSemantic.Retain)]
		string TwitterID { get; set; }

		[Export ("fullName", ArgumentSemantic.Retain)]
		string FullName { get; set; }

		[Export ("email", ArgumentSemantic.Retain)]
		string Email { get; set; }

		[Export ("login", ArgumentSemantic.Retain)]
		string Login { get; set; }

		[Export ("phone", ArgumentSemantic.Retain)]
		string Phone { get; set; }

		[Export ("website", ArgumentSemantic.Retain)]
		string Website { get; set; }

		[Export ("tags", ArgumentSemantic.Retain)]
		NSMutableArray Tags { get; set; }

		[Export ("password", ArgumentSemantic.Retain)]
		string Password { get; set; }

		[Export ("oldPassword", ArgumentSemantic.Retain)]
		string OldPassword { get; set; }

		[Export ("lastRequestAt", ArgumentSemantic.Retain)]
		NSDate LastRequestAt { get; set; }

		[Static, Export ("user")]
		QBUUser User ();
	}
	
	
	[BaseType (typeof (NSObject))]
	[Model]
	public partial interface Cancelable {
		[Export ("cancel")]
		void Cancel ();
	}
	
	
	[BaseType (typeof (NSObject))]
	[Model, Protocol]
	public interface QBActionStatusDelegate {
		
		[Export ("completedWithResult:")]
		void CompletedWithResult(Result result);

		[Export ("completedWithResult:context:")]
		void Context (Result result, NSObject contextInfo);

		[Export ("progress")]
		float Progress { set; }

		[Export ("uploadProgress")]
		float UploadActionProgress { set; }
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface Result {

		[Export ("errors")]
		NSObject [] Errors { get; }

		[Export ("success")]
		bool Success { get; }

		[Export ("status")]
		uint Status { get; }

		[Export ("request", ArgumentSemantic.Retain)]
		Request Request { get; set; }

		[Export ("answer", ArgumentSemantic.Retain)]
		Answer Answer { get; set; }

		[Export ("initWithRequest:answer:")]
		IntPtr Constructor (Request req, Answer answ);

		[Export ("initWithAnswer:")]
		IntPtr Constructor (Answer answ);
	}
	
	[BaseType (typeof (Result))]
	public partial interface QBUUserResult {

		[Export ("user")]
		QBUUser User { get; }
	}
	
	[BaseType (typeof (QBUUserResult))]
	public partial interface QBUUserLogInResult {

		[Export ("socialProviderToken")]
		string SocialProviderToken { get; }

		[Export ("socialProviderTokenExpiresAt")]
		NSDate SocialProviderTokenExpiresAt { get; }
	}
	
	[BaseType (typeof (Result))]
	public partial interface PagedResult {

		[Export ("currentPage")]
		uint CurrentPage { get; }

		[Export ("totalPages")]
		uint TotalPages { get; }

		[Export ("perPage")]
		uint PerPage { get; }

		[Export ("totalEntries")]
		uint TotalEntries { get; }
	}

	
	[BaseType (typeof (PagedResult))]
	public partial interface QBUUserPagedResult {

		[Export ("users")]
		NSObject [] Users { get; }
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface Request {

		[Export ("parameters")]
		NSDictionary Parameters { get; }

		[Static, Export ("request")]
		Request CreateRequest ();
		
	}
	
	[BaseType (typeof (Request))]
	public partial interface PagedRequest {

		[Export ("page")]
		uint Page { get; set; }

		[Export ("perPage")]
		uint PerPage { get; set; }
	}
	
	
	[BaseType (typeof (Request))]
	public partial interface QBASessionCreationRequest {

		[Export ("socialProvider", ArgumentSemantic.Retain)]
		string SocialProvider { get; set; }

		[Export ("scope", ArgumentSemantic.Retain)]
		NSObject [] Scope { get; set; }

		[Export ("socialProviderAccessToken", ArgumentSemantic.Retain)]
		string SocialProviderAccessToken { get; set; }

		[Export ("socialProviderAccessTokenSecret", ArgumentSemantic.Retain)]
		string SocialProviderAccessTokenSecret { get; set; }

		[Export ("userLogin", ArgumentSemantic.Retain)]
		string UserLogin { get; set; }

		[Export ("userEmail", ArgumentSemantic.Retain)]
		string UserEmail { get; set; }

		[Export ("userPassword", ArgumentSemantic.Retain)]
		string UserPassword { get; set; }

	}

	
	
	[BaseType (typeof (NSObject))]
	public partial interface Answer {

		[Export ("errors", ArgumentSemantic.Retain)]
		NSMutableArray Errors { get; set; }

		[Export ("query", ArgumentSemantic.Assign)]
		QBQuery Query { get; set; }

		[Export ("allocResult")]
		Result AllocResult ();
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBQuery  {
		//Empty binding to compile
	}

	
	[BaseType (typeof (NSObject))]
	public partial interface QBChat {

		[Export ("delegate", ArgumentSemantic.Retain)]
		QBChatDelegate Delegate { get; set; }

		[Export ("contactList")]
		QBContactList ContactList { get; }

		[Export ("registeredVideoChatInstances")]
		NSMutableArray RegisteredVideoChatInstances { get; }

		[Static, Export ("instance")]
		QBChat Instance { get; }

		[Export ("loginWithUser:")]
		bool LoginWithUser (QBUUser user);

		[Export ("isLoggedIn")]
		bool IsLoggedIn { get; }

		[Export ("logout")]
		bool Logout ();

		[Export ("sendMessage:")]
		bool SendMessage (QBChatMessage message);

		[Export ("sendPresence")]
		bool SendPresence ();

		[Export ("sendPresenceWithStatus:")]
		bool SendPresenceWithStatus (string status);

		[Export ("sendDirectPresenceWithStatus:toUser:")]
		bool SendDirectPresenceWithStatus (string status, uint userID);

		[Export ("currentUser")]
		QBUUser CurrentUser { get; }

		[Export ("addUserToContactListRequest:")]
		bool AddUserToContactListRequest (uint userID);

		[Export ("removeUserFromContactList:")]
		bool RemoveUserFromContactList (uint userID);

		[Export ("confirmAddContactRequest:")]
		bool ConfirmAddContactRequest (uint userID);

		[Export ("rejectAddContactRequest:")]
		bool RejectAddContactRequest (uint userID);

		[Export ("createOrJoinRoomWithName:membersOnly:persistent:")]
		bool CreateOrJoinRoomWithName (string name, bool isMembersOnly, bool isPersistent);

		[Export ("createOrJoinRoomWithName:nickname:membersOnly:persistent:")]
		bool CreateOrJoinRoomWithName (string name, string nickname, bool isMembersOnly, bool isPersistent);

		[Export ("joinRoom:")]
		bool JoinRoom (QBChatRoom room);

		[Export ("leaveRoom:")]
		bool LeaveRoom (QBChatRoom room);

		[Export ("destroyRoom:")]
		bool DestroyRoom (QBChatRoom room);

		[Export ("sendMessage:toRoom:")]
		bool SendMessage (string message, QBChatRoom room);

		[Export ("sendPresenceWithParameters:toRoom:")]
		bool SendPresenceWithParameters (NSDictionary parameters, QBChatRoom room);

		[Export ("sendPresenceWithStatus:show:priority:customParameters:toRoom:")]
		bool SendPresenceWithStatus (string status, QBPresenseShow show, short priority, NSDictionary customParameters, QBChatRoom room);

		[Export ("requestAllRooms")]
		bool RequestAllRooms { get; }

		[Export ("requestRoomInformation:")]
		bool RequestRoomInformation (QBChatRoom room);

		[Export ("requestRoomUsers:")]
		bool RequestRoomUsers (QBChatRoom room);

		[Export ("requestRoomOnlineUsers:")]
		bool RequestRoomOnlineUsers (QBChatRoom room);

		[Export ("addUsers:toRoom:")]
		bool AddUsers (NSObject [] usersIDs, QBChatRoom room);

		[Export ("deleteUsers:fromRoom:")]
		bool DeleteUsers (NSObject [] usersIDs, QBChatRoom room);

		[Export ("createAndRegisterVideoChatInstance")]
		QBVideoChat CreateAndRegisterVideoChatInstance { get; }

		[Export ("createAndRegisterVideoChatInstanceWithSessionID:")]
		QBVideoChat CreateAndRegisterVideoChatInstanceWithSessionID (string sessionID);

		[Export ("unregisterVideoChatInstance:")]
		void UnregisterVideoChatInstance (QBVideoChat videoChat);

		[Export ("sendGetIQWithXmlns:node:")]
		void SendGetIQWithXmlns (string xmlns, string node);
	}

	[BaseType (typeof (NSObject))]
	[Model, Protocol]
	public partial interface QBChatDelegate {
		
		[Export ("chatDidLogin")]
		void ChatDidLogin ();

		[Export ("chatDidNotLogin")]
		void ChatDidNotLogin ();

		[Export ("chatDidNotSendMessage:")]
		void  ChatDidNotSendMessage(QBChatMessage message);

		[Export ("chatDidReceiveMessage:")]
		void  ChatDidReceiveMessage(QBChatMessage message);

		[Export ("chatDidFailWithError:")]
		void  ChatDidFailWithError(int code);

		[Export ("chatDidReceivePresenceOfUser:type:")]
		void Type (uint userID, string type);

		[Export ("chatDidReceiveContactAddRequestFromUser:")]
		void  ChatDidReceiveContactAddRequestFromUser(uint userID);

		[Export ("chatContactListDidChange:")]
		void  ChatContactListDidChange(QBContactList contactList);

		[Export ("chatDidReceiveContactItemActivity:isOnline:status:")]
		void IsOnline (uint userID, bool isOnline, string status);

		[Export ("chatDidReceiveListOfRooms:")]
		void ChatDidReceiveListOfRooms(NSObject [] rooms);

		[Export ("chatRoomDidReceiveMessage:fromRoom:")]
		void FromRoom (QBChatMessage message, string roomName);

		[Export ("chatRoomDidReceiveInformation:room:")]
		void Room (NSDictionary information, string roomName);

		[Export ("chatRoomDidCreate:")]
		void  ChatRoomDidCreate(string roomName);

		[Export ("chatRoomDidEnter:")]
		void  ChatRoomDidEnter(QBChatRoom room);

		[Export ("chatRoomDidNotEnter:error:")]
		void Error (string roomName, NSError error);

		[Export ("chatRoomDidLeave:")]
		void  ChatRoomDidLeave(string roomName);

		[Export ("chatRoomDidDestroy:")]
		void  ChatRoomDidDestroy(string roomName);

		[Export ("chatRoomDidChangeOnlineUsers:room:")]
		void RoomChange (NSObject [] onlineUsers, string roomName);

		[Export ("chatRoomDidReceiveListOfUsers:room:")]
		void RoomUsers (NSObject [] users, string roomName);

		[Export ("chatRoomDidReceiveListOfOnlineUsers:room:")]
		void RoomOnline (NSObject [] users, string roomName);

		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:")]
		void WithSessionID (uint userID, string sessionID, QBVideoChatConferenceType conferenceType);

		[Export ("chatDidReceiveCallRequestFromUser:withSessionID:conferenceType:customParameters:")]
		void WithSessionID (uint userID, string sessionID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters);

		[Export ("chatCallUserDidNotAnswer:")]
		void  ChatCallUserDidNotAnswer(uint userID);

		[Export ("chatCallDidAcceptByUser:")]
		void  ChatCallDidAcceptByUser(uint userID);

		[Export ("chatCallDidAcceptByUser:customParameters:")]
		void CustomParameters (uint userID, NSDictionary customParameters);

		[Export ("chatCallDidRejectByUser:")]
		void  ChatCallDidRejectByUser(uint userID);

		[Export ("chatCallDidStopByUser:status:")]
		void Status (uint userID, string status);

		[Export ("chatCallDidStopByUser:status:customParameters:")]
		void Status (uint userID, string status, NSDictionary customParameters);

		[Export ("chatCallDidStartWithUser:sessionID:")]
		void SessionID (uint userID, string sessionID);

		[Export ("didStartUseTURNForVideoChat")]
		void DidStartUseTURNForVideoChat ();

		[Export ("chatTURNServerDidDisconnect")]
		void ChatTURNServerDidDisconnect ();

		[Export ("chatTURNServerdidFailWithError:")]
		void  ChatTURNServerdidFailWithError(NSError error);

		[Export ("chatDidPassConnectionStep:totalSteps:")]
		void TotalSteps (uint step, uint totalSteps);

		[Export ("chatDidEexceedWriteVideoQueueMaxOperationsThresholdWithCount:")]
		void  ChatDidEexceedWriteVideoQueueMaxOperationsThresholdWithCount(uint operationsInQueue);
		
		[Export ("didReceiveAudioBuffer:")]
		void  DidReceiveAudioBuffer(AudioBuffer buffer);
	
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBContactList {
	
		[Export ("contacts")]
		NSObject [] Contacts { get; }

		[Export ("pendingApproval")]
		NSObject [] PendingApproval { get; }

	}

	[BaseType (typeof (NSObject))]
	public partial interface QBContactListItem {

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("online")]
		bool Online { [Bind ("isOnline")] get; set; }
	
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBChatMessage {
	
		[Export ("ID", ArgumentSemantic.Copy)]
		string ID { get; set; }

		[Export ("text", ArgumentSemantic.Copy)]
		string Text { get; set; }

		[Export ("recipientID")]
		uint RecipientID { get; set; }

		[Export ("senderID")]
		uint SenderID { get; set; }

		[Export ("senderNick", ArgumentSemantic.Copy)]
		string SenderNick { get; set; }

		[Export ("datetime", ArgumentSemantic.Copy)]
		NSDate Datetime { get; set; }

		[Export ("delayed")]
		bool Delayed { get; set; }

		[Export ("customParameters", ArgumentSemantic.Retain)]
		NSMutableDictionary CustomParameters { get; set; }

		[Static, Export ("message")]
		QBChatMessage Message { get; }

		[Export ("saveWhenDeliveredToCustomObjectsWithClassName:additionalParameters:")]
		void SaveWhenDeliveredToCustomObjectsWithClassName (string classname, NSDictionary additionalParameters);

		[Export ("customObjectsClassName")]
		string CustomObjectsClassName { get; }

		[Export ("customObjectsAdditionalParameters")]
		NSDictionary CustomObjectsAdditionalParameters { get; }

	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBChatRoom {

		[Export ("name")]
		string Name { get; }

		[Export ("JID")]
		string JID { get; }

		[Export ("isJoined")]
		bool IsJoined { get; }

		[Export ("initWithRoomName:")]
		IntPtr Constructor (string roomName);

		[Export ("initWithRoomName:nickname:")]
		IntPtr Constructor (string roomName, string nickname);

		[Export ("addUsers:")]
		void AddUsers (NSObject [] users);

		[Export ("deleteUsers:")]
		void DeleteUsers (NSObject [] users);

		[Export ("sendMessage:")]
		void SendMessage (QBChatMessage message);

		[Export ("joinRoom")]
		void JoinRoom ();

		[Export ("leaveRoom")]
		void LeaveRoom ();

		[Export ("requestUsers")]
		void RequestUsers ();

		[Export ("requestOnlineUsers")]
		void RequestOnlineUsers ();

		[Export ("requestInformation")]
		void RequestInformation ();
	
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBChatRoomOccupant {

		[Static, Export ("occupantWithUserNickname:parameters:")]
		QBChatRoomOccupant OccupantWithUserNickname (string aNickname, NSDictionary parameters);

		[Export ("initWithUserNickname:parameters:")]
		IntPtr Constructor (string aNickname, NSDictionary parameters);

		[Export ("nickname")]
		string Nickname { get; }

		[Export ("parameters")]
		NSDictionary Parameters { get; }

	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBVideoChat  {

		[Export ("isUseCustomVideoChatCaptureSession")]
		bool IsUseCustomVideoChatCaptureSession { get; set; }

		[Export ("isUseCustomAudioChatSession")]
		bool IsUseCustomAudioChatSession { get; set; }

		[Export ("viewToRenderOpponentVideoStream", ArgumentSemantic.Retain)]
		UIView ViewToRenderOpponentVideoStream { get; set; }

		[Export ("viewToRenderOwnVideoStream", ArgumentSemantic.Retain)]
		UIView ViewToRenderOwnVideoStream { get; set; }

		[Export ("videoChatOpponentID")]
		uint VideoChatOpponentID { get; }

		[Export ("relayUsed")]
		bool RelayUsed { [Bind ("isRelayUsed")] get; }

		[Export ("useBackCamera")]
		bool UseBackCamera { get; set; }

		[Export ("useHeadphone")]
		bool UseHeadphone { get; set; }

		[Export ("cameraFlashEnabled")]
		bool CameraFlashEnabled { [Bind ("isCameraFlashEnabled")] get; set; }

		[Export ("microphoneEnabled")]
		bool MicrophoneEnabled { [Bind ("isMicrophoneEnabled")] get; set; }

		[Export ("sessionID", ArgumentSemantic.Retain)]
		string SessionID { get; }

		[Export ("state")]
		QBVideoChatState State { get; }

		[Export ("callUser:conferenceType:")]
		void CallUser (uint userID, QBVideoChatConferenceType conferenceType);

		[Export ("callUser:conferenceType:customParameters:")]
		void CallUser (uint userID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters);

		[Export ("cancelCall")]
		void CancelCall ();

		[Export ("acceptCallWithOpponentID:conferenceType:")]
		void AcceptCallWithOpponentID (uint userID, QBVideoChatConferenceType conferenceType);

		[Export ("acceptCallWithOpponentID:conferenceType:customParameters:")]
		void AcceptCallWithOpponentID (uint userID, QBVideoChatConferenceType conferenceType, NSDictionary customParameters);

		[Export ("rejectCallWithOpponentID:")]
		void RejectCallWithOpponentID (uint userID);

		[Export ("finishCall")]
		void FinishCall ();

		[Export ("finishCallWithCustomParameters:")]
		void FinishCallWithCustomParameters (NSDictionary customParameters);

		[Export ("videoOutputPreset")]
		string VideoOutputPreset { set; }

		[Export ("canSetVideoOutputPreset:")]
		bool CanSetVideoOutputPreset (string preset);

		[Export ("drainWriteVideoQueue")]
		void DrainWriteVideoQueue ();

		[Export ("drainWriteAudioQueue")]
		void DrainWriteAudioQueue ();

		[Export ("suspendStream:")]
		void SuspendStream (bool isSuspend);

	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBMessages {

		[Static, Export ("createPushToken:delegate:")]
		NSObject CreatePushToken (QBMPushToken pushToken, QBActionStatusDelegate del);

		[Static, Export ("createPushToken:delegate:context:")]
		NSObject CreatePushToken (QBMPushToken pushToken, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("deletePushTokenWithID:delegate:")]
		NSObject DeletePushTokenWithID (uint ID, NSObject del);

		[Static, Export ("deletePushTokenWithID:delegate:context:")]
		NSObject DeletePushTokenWithID (uint ID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("createSubscription:delegate:")]
		NSObject CreateSubscription (QBMSubscription subscriber, QBActionStatusDelegate del);

		[Static, Export ("createSubscription:delegate:context:")]
		NSObject CreateSubscription (QBMSubscription subscriber, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("subscriptionsWithDelegate:")]
		NSObject SubscriptionsWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("subscriptionsWithDelegate:context:")]
		NSObject SubscriptionsWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("deleteSubscriptionWithID:delegate:")]
		NSObject DeleteSubscriptionWithID (uint ID, QBActionStatusDelegate del);

		[Static, Export ("deleteSubscriptionWithID:delegate:context:")]
		NSObject DeleteSubscriptionWithID (uint ID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("createEvent:delegate:")]
		NSObject CreateEvent (QBMEvent evt, QBActionStatusDelegate del);

		[Static, Export ("createEvent:delegate:context:")]
		NSObject CreateEvent (QBMEvent evt, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("eventWithID:delegate:")]
		NSObject EventWithID (uint ID, QBActionStatusDelegate del);

		[Static, Export ("eventWithID:delegate:context:")]
		NSObject EventWithID (uint ID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("updateEvent:delegate:")]
		NSObject UpdateEvent (QBMEvent evt, QBActionStatusDelegate del);

		[Static, Export ("updateEvent:delegate:context:")]
		NSObject UpdateEvent (QBMEvent evt, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("deleteEventWithID:delegate:")]
		NSObject DeleteEventWithID (uint ID, QBActionStatusDelegate del);

		[Static, Export ("deleteEventWithID:delegate:context:")]
		NSObject DeleteEventWithID (uint ID, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("eventsWithDelegate:")]
		NSObject EventsWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("eventsWithDelegate:context:")]
		NSObject EventsWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("eventsWithPagedRequest:delegate:")]
		NSObject EventsWithPagedRequest (PagedRequest pagedRequest, QBActionStatusDelegate del);

		[Static, Export ("eventsWithPagedRequest:delegate:context:")]
		NSObject EventsWithPagedRequest (PagedRequest pagedRequest, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("pullEventsWithDelegate:")]
		NSObject PullEventsWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("pullEventsWithDelegate:context:")]
		NSObject PullEventsWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TRegisterSubscriptionWithDelegate:")]
		NSObject TRegisterSubscriptionWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("TRegisterSubscriptionWithDelegate:context:")]
		NSObject TRegisterSubscriptionWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TUnregisterSubscriptionWithDelegate:")]
		NSObject TUnregisterSubscriptionWithDelegate (QBActionStatusDelegate del);

		[Static, Export ("TUnregisterSubscriptionWithDelegate:context:")]
		NSObject TUnregisterSubscriptionWithDelegate (QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPush:toUsers:delegate:")]
		NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, QBActionStatusDelegate del);

		[Static, Export ("TSendPush:toUsers:delegate:context:")]
		NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPushWithText:toUsers:delegate:")]
		NSObject TSendPushWithText (string text, string usersIDs, QBActionStatusDelegate del);

		[Static, Export ("TSendPushWithText:toUsers:delegate:context:")]
		NSObject TSendPushWithText (string text, string usersIDs, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPush:toUsersWithAnyOfTheseTags:delegate:")]
		NSObject TSendPushWithTags (QBMPushMessage pushMessage, string usersTags, QBActionStatusDelegate del);

		[Static, Export ("TSendPush:toUsersWithAnyOfTheseTags:delegate:context:")]
		NSObject TSendPushWithTags (QBMPushMessage pushMessage, string usersTags, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:")]
		NSObject TSendPushWithTextWithTags (string text, string usersTags, QBActionStatusDelegate del);

		[Static, Export ("TSendPushWithText:toUsersWithAnyOfTheseTags:delegate:context:")]
		NSObject TSendPushWithTextWithTags (string text, string usersTags, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPush:toUsers:isDevelopmentEnvironment:delegate:")]
		NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, bool isDevelopmentEnvironment, QBActionStatusDelegate del);

		[Static, Export ("TSendPush:toUsers:isDevelopmentEnvironment:delegate:context:")]
		NSObject TSendPush (QBMPushMessage pushMessage, string usersIDs, bool isDevelopmentEnvironment, QBActionStatusDelegate del, NSObject context);

		[Static, Export ("TSendPush:toUsersWithAnyOfTheseTags:isDevelopmentEnvironment:delegate:")]
		NSObject TSendPushWithAnyOfTags (QBMPushMessage pushMessage, string usersTags, bool isDevelopmentEnvironment, QBActionStatusDelegate del);

		[Static, Export ("TSendPush:toUsersWithAnyOfTheseTags:isDevelopmentEnvironment:delegate:context:")]
		NSObject TSendPushWithAnyOfTags (QBMPushMessage pushMessage, string usersTags, bool isDevelopmentEnvironment, QBActionStatusDelegate del, NSObject context);
	}
	
	[BaseType (typeof (Entity))]
	public partial interface QBMPushToken {

		[Export ("clientIdentificationSequence", ArgumentSemantic.Retain)]
		string ClientIdentificationSequence { get; set; }

		[Export ("isEnvironmentDevelopment")]
		bool IsEnvironmentDevelopment { get; set; }

		[Static, Export ("pushToken")]
		QBMPushToken PushToken { get; }
	}
	
	[BaseType (typeof (Entity))]
	public partial interface QBMSubscription {

		[Export ("notificationChannel")]
		QBMNotificatioChannel NotificationChannel { get; set; }

		[Export ("deviceUDID", ArgumentSemantic.Retain)]
		string DeviceUDID { get; set; }

		[Export ("devicePlatform", ArgumentSemantic.Retain)]
		string DevicePlatform { get; set; }

		[Export ("url", ArgumentSemantic.Retain)]
		string Url { get; set; }

		[Static, Export ("subscription")]
		QBMSubscription Subscription { get; }

		[Static, Export ("notificationChannelFromString:")]
		QBMNotificatioChannel NotificationChannelFromString (string notificationChannel);

		[Static, Export ("notificationChannelToString:")]
		string NotificationChannelToString (QBMNotificatioChannel notificationChannel);
	}

	[BaseType (typeof (Entity))]
	public partial interface QBMEvent {

		[Export ("active")]
		bool Active { get; set; }

		[Export ("notificationType")]
		QBMNotificationType NotificationType { get; set; }

		[Export ("pushType")]
		QBMPushType PushType { get; set; }

		[Export ("usersIDs", ArgumentSemantic.Retain)]
		string UsersIDs { get; set; }

		[Export ("usersExternalIDs", ArgumentSemantic.Retain)]
		string UsersExternalIDs { get; set; }

		[Export ("usersTagsAny", ArgumentSemantic.Retain)]
		string UsersTagsAny { get; set; }

		[Export ("usersTagsAll", ArgumentSemantic.Retain)]
		string UsersTagsAll { get; set; }

		[Export ("usersTagsExclude", ArgumentSemantic.Retain)]
		string UsersTagsExclude { get; set; }

		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; set; }

		[Export ("isDevelopmentEnvironment")]
		bool IsDevelopmentEnvironment { get; set; }

		[Export ("message", ArgumentSemantic.Retain)]
		NSObject Message { get; set; }

		[Export ("type")]
		QBMEventType Type { get; set; }

		[Export ("date", ArgumentSemantic.Retain)]
		NSDate Date { get; set; }

		[Export ("endDate", ArgumentSemantic.Retain)]
		NSDate EndDate { get; set; }

		[Export ("period")]
		uint Period { get; set; }

		[Export ("occuredCount")]
		uint OccuredCount { get; set; }

		[Export ("senderID")]
		uint SenderID { get; set; }

		[Static, Export ("event")]
		QBMEvent Event { get; }

		[Export ("prepareMessage")]
		void PrepareMessage ();

		[Static, Export ("eventTypeFromString:")]
		QBMEventType EventTypeFromString (string eventType);

		[Static, Export ("eventTypeToString:")]
		string EventTypeToString (QBMEventType eventType);

		[Static, Export ("notificationTypeFromString:")]
		QBMNotificationType NotificationTypeFromString (string notificationType);

		[Static, Export ("notificationTypeToString:")]
		string NotificationTypeToString (QBMNotificationType notificationType);

		[Static, Export ("pushTypeFromString:")]
		QBMPushType PushTypeFromString (string pushType);

		[Static, Export ("pushTypeToString:")]
		string PushTypeToString (QBMPushType pushType);

		[Static, Export ("messageToString:")]
		string MessageToString (NSDictionary message);

		[Static, Export ("messageFromString:")]
		NSDictionary MessageFromString (string message);
	}
	
	[BaseType (typeof (QBMPushMessageBase))]
	public partial interface QBMPushMessage {

		[Export ("alertBody", ArgumentSemantic.Retain)]
		string AlertBody { get; set; }

		[Export ("badge", ArgumentSemantic.Retain)]
		NSNumber Badge { get; set; }

		[Export ("soundFile", ArgumentSemantic.Retain)]
		string SoundFile { get; set; }

		[Export ("localizedBodyKey", ArgumentSemantic.Retain)]
		string LocalizedBodyKey { get; set; }

		[Export ("localizedBodyArguments", ArgumentSemantic.Retain)]
		NSObject [] LocalizedBodyArguments { get; set; }

		[Export ("localizedActionKey", ArgumentSemantic.Retain)]
		string LocalizedActionKey { get; set; }

		[Export ("additionalInfo", ArgumentSemantic.Retain)]
		NSDictionary AdditionalInfo { get; set; }

		[Static, Export ("pushMessage")]
		QBMPushMessage PushMessage ();
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBMPushMessageBase {

		[Export ("payloadDict", ArgumentSemantic.Retain)]
		NSMutableDictionary PayloadDict { get; set; }

		[Export ("initWithPayload:")]
		IntPtr Constructor (NSDictionary payload);

		[Export ("json")]
		string Json { get; }

		[Export ("charsLeft")]
		int CharsLeft { get; }
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBCOCustomObject {

		[Export ("ID", ArgumentSemantic.Retain)]
		string ID { get; set; }

		[Export ("parentID", ArgumentSemantic.Retain)]
		string ParentID { get; set; }

		[Export ("createdAt", ArgumentSemantic.Retain)]
		NSDate CreatedAt { get; set; }

		[Export ("updatedAt", ArgumentSemantic.Retain)]
		NSDate UpdatedAt { get; set; }

		[Export ("className", ArgumentSemantic.Retain)]
		string ClassName { get; set; }

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("fields", ArgumentSemantic.Retain)]
		NSMutableDictionary Fields { get; set; }

		[Export ("permissions", ArgumentSemantic.Retain)]
		QBCOPermissions Permissions { get; set; }

		[Static, Export ("customObject")]
		QBCOCustomObject CustomObject ();
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBCOCustomObjectCreateQuery {

		[Export ("object")]
		QBCOCustomObject NSObject { get; }

		[Export ("initWithObject:")]
		IntPtr Constructor (QBCOCustomObject _object);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOCustomObjectsCreateQuery {

		[Export ("objects")]
		NSObject [] Objects { get; }

		[Export ("className")]
		string ClassName { get; }

		[Export ("initWithObjects:className:")]
		IntPtr Constructor (NSObject [] objects, string className);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOCustomObjectUpdateQuery {

		[Export ("object")]
		QBCOCustomObject NSObject { get; }

		[Export ("specialUpdateOperators")]
		NSMutableDictionary SpecialUpdateOperators { get; }

		[Export ("initWithObject:specialUpdateOperators:")]
		IntPtr Constructor (QBCOCustomObject _object, NSMutableDictionary specialUpdateOperators);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOCustomObjectsUpdateQuery {

		[Export ("objects")]
		NSObject [] Objects { get; }

		[Export ("className")]
		string ClassName { get; }

		[Export ("specialUpdateOperators")]
		NSObject [] SpecialUpdateOperators { get; }

		[Export ("initWithObjects:className:specialUpdateOperators:")]
		IntPtr Constructor (NSObject [] objects, string className, NSObject [] specialUpdateOperators);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOCustomObjectDeleteQuery {

		[Export ("object")]
		QBCOCustomObject NSObject { get; }

		[Export ("initWithObject:")]
		IntPtr Constructor (QBCOCustomObject _object);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOMultiDeleteQuery {

		[Export ("className")]
		string ClassName { get; }

		[Export ("objectsIDs")]
		NSObject [] ObjectsIDs { get; }

		[Export ("initWithClassName:objectsIDs:")]
		IntPtr Constructor (string className, NSObject [] objectsIDs);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOCustomObjectGetQuery {

		[Export ("getRequest")]
		NSMutableDictionary GetRequest { get; }

		[Export ("className")]
		string ClassName { get; }

		[Export ("ID")]
		string ID { get; }

		[Export ("IDs")]
		NSObject [] IDs { get; }

		[Export ("initWithClassName:request:")]
		IntPtr Constructor (string _className, NSMutableDictionary _getRequest);

		[Export ("initWithClassName:ID:")]
		IntPtr Constructor (string _className, string _ID);

		[Export ("initWithClassName:IDs:")]
		IntPtr Constructor (string _className, NSObject [] _IDs);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOFileQuery {

		[Export ("className")]
		string ClassName { get; }

		[Export ("objectID")]
		string ObjectID { get; }

		[Export ("fileFieldName")]
		string FileFieldName { get; }

		[Export ("initWithClassName:objectID:fileFieldName:")]
		IntPtr Constructor (string className, string objectID, string fileFieldName);
	}

	[BaseType (typeof (QBCOFileQuery))]
	public partial interface QBCOFileUploadQuery {

		[Export ("file", ArgumentSemantic.Retain)]
		QBCOFile File { get; set; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCOCustomObjectResult {

		[Export ("object")]
		QBCOCustomObject NSObject { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCOMultiDeleteResult {

		[Export ("deletedObjectsIDs")]
		NSObject [] DeletedObjectsIDs { get; }

		[Export ("notFoundObjectsIDs")]
		NSObject [] NotFoundObjectsIDs { get; }

		[Export ("wrongPermissionsObjectsIDs")]
		NSObject [] WrongPermissionsObjectsIDs { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCOCustomObjectPagedResult {

		[Export ("objects")]
		NSObject [] Objects { get; }

		[Export ("count")]
		uint Count { get; }

		[Export ("skip")]
		uint Skip { get; }

		[Export ("limit")]
		uint Limit { get; }

		[Export ("notFoundObjectsIDs")]
		NSObject [] NotFoundObjectsIDs { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCOPermissionsResult {

		[Export ("permissions")]
		QBCOPermissions Permissions { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBCOFileResult {

		[Export ("data")]
		NSData Data { get; }
	}

	[BaseType (typeof (QBBaseModule))]
	public partial interface QBCustomObjects {

		[Static, Export ("objectWithClassName:ID:delegate:")]
		NSObject ObjectWithClassName (string className, string ID, NSObject del);

		[Static, Export ("objectWithClassName:ID:delegate:context:")]
		NSObject ObjectWithClassName (string className, string ID, NSObject del, NSObject context);

		[Static, Export ("objectsWithClassName:IDs:delegate:")]
		NSObject ObjectsWithClassName (string className, NSObject [] IDs, NSObject del);

		[Static, Export ("objectsWithClassName:IDs:delegate:context:")]
		NSObject ObjectsWithClassName (string className, NSObject [] IDs, NSObject del, NSObject context);

		[Static, Export ("objectsWithClassName:delegate:")]
		NSObject ObjectsWithClassName (string className, NSObject del);

		[Static, Export ("objectsWithClassName:delegate:context:")]
		NSObject ObjectsWithClassName (string className, NSObject del, NSObject context);

		[Static, Export ("objectsWithClassName:extendedRequest:delegate:")]
		NSObject ObjectsWithClassName (string className, NSMutableDictionary extendedRequest, NSObject del);

		[Static, Export ("objectsWithClassName:extendedRequest:delegate:context:")]
		NSObject ObjectsWithClassName (string className, NSMutableDictionary extendedRequest, NSObject del, NSObject context);

		[Static, Export ("createObject:delegate:")]
		NSObject CreateObject (QBCOCustomObject obj, NSObject del);

		[Static, Export ("createObject:delegate:context:")]
		NSObject CreateObject (QBCOCustomObject obj, NSObject del, NSObject context);

		[Static, Export ("createObjects:className:delegate:")]
		NSObject CreateObjects (NSObject [] objects, string className, NSObject del);

		[Static, Export ("createObjects:className:delegate:context:")]
		NSObject CreateObjects (NSObject [] objects, string className, NSObject del, NSObject context);

		[Static, Export ("updateObject:delegate:")]
		NSObject UpdateObject (QBCOCustomObject obj, NSObject del);

		[Static, Export ("updateObject:delegate:context:")]
		NSObject UpdateObject (QBCOCustomObject obj, NSObject del, NSObject context);

		[Static, Export ("updateObject:specialUpdateOperators:delegate:")]
		NSObject UpdateObject (QBCOCustomObject obj, NSMutableDictionary specialUpdateOperators, NSObject del);

		[Static, Export ("updateObject:specialUpdateOperators:delegate:context:")]
		NSObject UpdateObject (QBCOCustomObject obj, NSMutableDictionary specialUpdateOperators, NSObject del, NSObject context);

		[Static, Export ("updateObjects:className:delegate:")]
		NSObject UpdateObjects (NSObject [] objects, string className, NSObject del);

		[Static, Export ("updateObjects:className:delegate:context:")]
		NSObject UpdateObjects (NSObject [] objects, string className, NSObject del, NSObject context);

		[Static, Export ("deleteObjectWithID:className:delegate:")]
		NSObject DeleteObjectWithID (string objectID, string className, NSObject del);

		[Static, Export ("deleteObjectWithID:className:delegate:context:")]
		NSObject DeleteObjectWithID (string objectID, string className, NSObject del, NSObject context);

		[Static, Export ("deleteObjectsWithIDs:className:delegate:")]
		NSObject DeleteObjectsWithIDs (NSObject [] objectsIDs, string className, NSObject del);

		[Static, Export ("deleteObjectsWithIDs:className:delegate:context:")]
		NSObject DeleteObjectsWithIDs (NSObject [] objectsIDs, string className, NSObject del, NSObject context);

		[Static, Export ("permissionsForObjectWithClassName:ID:delegate:")]
		NSObject PermissionsForObjectWithClassName (string className, string ID, NSObject del);

		[Static, Export ("permissionsForObjectWithClassName:ID:delegate:context:")]
		NSObject PermissionsForObjectWithClassName (string className, string ID, NSObject del, NSObject context);

		[Static, Export ("uploadFile:className:objectID:fileFieldName:delegate:")]
		NSObject UploadFile (QBCOFile file, string className, string objectID, string fileFieldName, NSObject del);

		[Static, Export ("uploadFile:className:objectID:fileFieldName:delegate:context:")]
		NSObject UploadFile (QBCOFile file, string className, string objectID, string fileFieldName, NSObject del, NSObject context);

		[Static, Export ("downloadFileFromClassName:objectID:fileFieldName:delegate:")]
		NSObject DownloadFileFromClassName (string className, string objectID, string fileFieldName, NSObject del);

		[Static, Export ("downloadFileFromClassName:objectID:fileFieldName:delegate:context:")]
		NSObject DownloadFileFromClassName (string className, string objectID, string fileFieldName, NSObject del, NSObject context);

		[Static, Export ("deleteFileFromClassName:objectID:fileFieldName:delegate:")]
		NSObject DeleteFileFromClassName (string className, string objectID, string fileFieldName, NSObject del);

		[Static, Export ("deleteFileFromClassName:objectID:fileFieldName:delegate:context:")]
		NSObject DeleteFileFromClassName (string className, string objectID, string fileFieldName, NSObject del, NSObject context);
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBCOPermissions {

		[Export ("recordID", ArgumentSemantic.Retain)]
		string RecordID { get; set; }

		[Export ("readAccess")]
		QBCOPermissionsAccess ReadAccess { get; set; }

		[Export ("updateAccess")]
		QBCOPermissionsAccess UpdateAccess { get; set; }

		[Export ("deleteAccess")]
		QBCOPermissionsAccess DeleteAccess { get; set; }

		[Export ("usersIDsForReadAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersIDsForReadAccess { get; set; }

		[Export ("usersGroupsForReadAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersGroupsForReadAccess { get; set; }

		[Export ("usersIDsForUpdateAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersIDsForUpdateAccess { get; set; }

		[Export ("usersGroupsForUpdateAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersGroupsForUpdateAccess { get; set; }

		[Export ("usersIDsForDeleteAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersIDsForDeleteAccess { get; set; }

		[Export ("usersGroupsForDeleteAccess", ArgumentSemantic.Retain)]
		NSMutableArray UsersGroupsForDeleteAccess { get; set; }

		[Static, Export ("permissions")]
		QBCOPermissions Permissions ();

		[Static, Export ("permissionsAccessFromString:")]
		QBCOPermissionsAccess PermissionsAccessFromString (string permissionsAccess);

		[Static, Export ("permissionsAccessToString:")]
		string PermissionsAccessToString (QBCOPermissionsAccess permissionsAccess);
	}

	[BaseType (typeof (NSObject))]
	public partial interface QBCOFile {

		[Export ("name", ArgumentSemantic.Retain)]
		string Name { get; set; }

		[Export ("contentType", ArgumentSemantic.Retain)]
		string ContentType { get; set; }

		[Export ("data", ArgumentSemantic.Retain)]
		NSData Data { get; set; }

		[Static, Export ("file")]
		QBCOFile File ();
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface QBBaseModule {

		[Export ("token", ArgumentSemantic.Retain)]
		string Token { get; set; }

		[Export ("tokenExpirationDate", ArgumentSemantic.Retain)]
		NSDate TokenExpirationDate { get; set; }

		[Export ("sessionType")]
		QBSessionType SessionType { get; set; }

		[Export ("sessionCreationRequest", ArgumentSemantic.Retain)]
		QBASessionCreationRequest SessionCreationRequest { get; set; }

		[Static, Export ("createSharedModule")]
		void CreateSharedModule ();

		[Static, Export ("sharedModule")]
		QBBaseModule SharedModule { get; }

		[Export ("reset")]
		void Reset ();

		[Static, Export ("serverEndpointURL")]
		string ServerEndpointURL { get; }

		[Static, Export ("chatServerEndpointURL")]
		string ChatServerEndpointURL { get; }

		[Static, Export ("chatMUCServerEndpointURL")]
		string ChatMUCServerEndpointURL { get; }
	}

	[BaseType (typeof (Result))]
	public partial interface QBAAuthSessionCreationResult {

		[Export ("session")]
		QBASession Session { get; }

		[Export ("token")]
		string Token { get; }

		[Export ("socialProviderToken")]
		string SocialProviderToken { get; }

		[Export ("socialProviderTokenExpiresAt")]
		NSDate SocialProviderTokenExpiresAt { get; }
	}
	
	[BaseType (typeof (Entity))]
	public partial interface QBASession {

		[Export ("token", ArgumentSemantic.Retain)]
		string Token { get; set; }

		[Export ("applicationID")]
		uint ApplicationID { get; set; }

		[Export ("userID")]
		uint UserID { get; set; }

		[Export ("deviceID")]
		uint DeviceID { get; set; }

		[Export ("timestamp")]
		uint Timestamp { get; set; }

		[Export ("nonce")]
		int Nonce { get; set; }
	}

	*/

}



