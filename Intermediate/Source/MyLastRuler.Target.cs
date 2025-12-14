using UnrealBuildTool;

public class MyLastRulerTarget : TargetRules
{
	public MyLastRulerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyLastRuler");
	}
}
