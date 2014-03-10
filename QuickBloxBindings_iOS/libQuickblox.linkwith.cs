using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libQuickblox.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, Frameworks = "CFNetwork SystemConfiguration MobileCoreServices CoreGraphics CoreLocation CoreData AudioToolbox CoreMedia Accelerate CoreVideo AVFoundation Security", LinkerFlags = "-lxml2 -lz -lresolv -ObjC -lstdc++")]

//[assembly: LinkWith ("libQuickblox.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
