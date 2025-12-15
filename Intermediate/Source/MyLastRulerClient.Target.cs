using UnrealBuildTool;

public class MyLastRulerClientTarget : TargetRules
{
	public MyLastRulerClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MyLastRuler");
	}
}
