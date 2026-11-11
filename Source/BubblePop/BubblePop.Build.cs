// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BubblePop : ModuleRules
{
	public BubblePop(ReadOnlyTargetRules Target) : base(Target)
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
			"BubblePop",
			"BubblePop/Variant_Horror",
			"BubblePop/Variant_Horror/UI",
			"BubblePop/Variant_Shooter",
			"BubblePop/Variant_Shooter/AI",
			"BubblePop/Variant_Shooter/UI",
			"BubblePop/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
