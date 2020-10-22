// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class Cesium : ModuleRules
{
    public Cesium(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(
            new string[] {
				// ... add public include paths required here ...
			}
            );


        PrivateIncludePaths.AddRange(
            new string[] {
				// ... add other private include paths required here ...
                "../extern/cesium-native/Cesium3DTiles/include",
                "../extern/cesium-native/CesiumGeospatial/include",
                "../extern/cesium-native/CesiumGeometry/include",
                "../extern/cesium-native/CesiumUtility/include",
                "../extern/cesium-native/extern/tinygltf",
                "../extern/cesium-native/extern/glm",
                "../extern/cesium-native/extern/GSL/include",
            }
            );

        PublicAdditionalLibraries.AddRange(
            new string[]
            {
                Path.Combine(ModuleDirectory, "../../extern/build/cesium-native/Cesium3DTiles/Debug/Cesium3DTiles.lib"),
                Path.Combine(ModuleDirectory, "../../extern/build/cesium-native/CesiumGeospatial/Debug/CesiumGeospatial.lib"),
                Path.Combine(ModuleDirectory, "../../extern/build/cesium-native/CesiumGeometry/Debug/CesiumGeometry.lib"),
                Path.Combine(ModuleDirectory, "../../extern/build/cesium-native/CesiumUtility/Debug/CesiumUtility.lib"),
                Path.Combine(ModuleDirectory, "../../extern/build/cesium-native/extern/uriparser/Debug/uriparser.lib"),
                Path.Combine(ModuleDirectory, "../../extern/build/cesium-native/extern/draco/Debug/draco.lib"),
                Path.Combine(ModuleDirectory, "../../extern/build/cesium-native/extern/tinyxml2/Debug/tinyxml2d.lib"),
            }
            );

        PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);


        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
                "MeshDescription",
                "StaticMeshDescription",
                "HTTP",
                "MikkTSpace",
                "Chaos"
				// ... add private dependencies that you statically link with here ...	
			}
        );

        if (Target.bCompilePhysX && !Target.bUseChaos)
        {
            PrivateDependencyModuleNames.Add("PhysXCooking");
            PrivateDependencyModuleNames.Add("PhysicsCore");
        }

        if (Target.bBuildEditor == true)
        {
            PublicDependencyModuleNames.AddRange(
                new string[] {
                    "UnrealEd",
                }
            );
        }

        DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PrivatePCHHeaderFile = "Private/PCH.h";
        CppStandard = CppStandardVersion.Cpp17;
    }
}