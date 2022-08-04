// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FPS_Alex : ModuleRules
{
	public FPS_Alex(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
