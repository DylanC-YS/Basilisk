using UnrealBuildTool;

public class MyLastRulerEditorTarget : TargetRules
{
	public MyLastRulerEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MyLastRuler");
	}
}
