using UnrealBuildTool;

public class MyLastRulerServerTarget : TargetRules
{
	public MyLastRulerServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MyLastRuler");
	}
}
