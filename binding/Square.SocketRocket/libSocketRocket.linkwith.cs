using ObjCRuntime;

[assembly: LinkWith (
	"libSocketRocket.a", 
#if __IOS__
	LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64,
#else
    LinkTarget.x86_64,
#endif
	SmartLink = true, 
	ForceLoad = true,
#if __IOS__
	Frameworks = "CFNetwork Security Foundation",
	LinkerFlags = "-licucore"
#else
//	Frameworks = "CoreServices Security",
	LinkerFlags = "-licucore -F CoreServices -F Security"
#endif
	)]
