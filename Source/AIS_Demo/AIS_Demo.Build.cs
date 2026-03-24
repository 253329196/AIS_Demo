// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AIS_Demo : ModuleRules
{
	public AIS_Demo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"AIS_Demo",
			"AIS_Demo/Variant_Platforming",
			"AIS_Demo/Variant_Platforming/Animation",
			"AIS_Demo/Variant_Combat",
			"AIS_Demo/Variant_Combat/AI",
			"AIS_Demo/Variant_Combat/Animation",
			"AIS_Demo/Variant_Combat/Gameplay",
			"AIS_Demo/Variant_Combat/Interfaces",
			"AIS_Demo/Variant_Combat/UI",
			"AIS_Demo/Variant_SideScrolling",
			"AIS_Demo/Variant_SideScrolling/AI",
			"AIS_Demo/Variant_SideScrolling/Gameplay",
			"AIS_Demo/Variant_SideScrolling/Interfaces",
			"AIS_Demo/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
