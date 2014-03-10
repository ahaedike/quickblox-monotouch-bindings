
Monotouch binding of the QuickBlox iOS SDK v. 1.8.2
http://quickblox.com/developers/IOS#Download_iOS_SDK

NOTE:  This is a partial binding.  Chat and Push Notifications have been implemented.

I am building a Xamarin project that uses QuickBlox.  I am binding to each feature as it is implemented.  So far, the binding for Chat and Push Notifications have been implemented and tested.

For those distinguished developers who have actually learned how to create bindings:
====================================================================================
There is a file in the repo called: ObjectiveSharpieOutput.cs.  This is the raw output from Objective Sharpie.  I did not add it to the project because it does not compile.  My workflow is to move the needed bindings into ApiDefinition.cs as I can use, adjust, and test them.

If there is a binding that is missing, you will probably find it in ObjectiveSharpieOutput.cs.  Feel free to fork and use what you need.  Please do not send me a request to do your work for you.  That is weak and puny.  Be strong and smart.

I will continue to update this project as we implement features.

