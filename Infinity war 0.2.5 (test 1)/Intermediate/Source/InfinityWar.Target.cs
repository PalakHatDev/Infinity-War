using UnrealBuildTool;

public class InfinityWarTarget : TargetRules
{
	public InfinityWarTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("InfinityWar");
	}
}
