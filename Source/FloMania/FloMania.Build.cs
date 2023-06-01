// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FloMania : ModuleRules
{
	public FloMania(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
