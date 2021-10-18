using UnrealBuildTool;

public class TeddyFreddyTarget : TargetRules
{
	public TeddyFreddyTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TeddyFreddy");
	}
}
