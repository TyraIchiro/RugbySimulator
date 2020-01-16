dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Unity.TextMeshPro.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Unity.Analytics.DataPrivacy.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/UnityEngine.Advertisements.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/UnityEngine.Monetization.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Unity.XR.WindowsMR.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Async.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Unity.TextMeshPro.Editor.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Unity.PackageManagerUI.Editor.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.MSBuild.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Editor.Utilities.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Unity.CollabProxy.Editor.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Unity.XR.WindowsMR.Editor.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Editor.ClassExtensions.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.SpatialAwarenessSystem.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Gltf.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.SceneSystem.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.InputSystem.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.InputSimulation.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.DiagnosticsSystem.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Demos.InspectorFields.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Providers.WindowsMixedReality.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Demos.Gltf.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Providers.WindowsVoiceInput.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.TeleportSystem.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.CameraSystem.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.BoundarySystem.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Gltf.Importers.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Editor.BuildAndDeploy.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.InputSystem.Editor.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Demos.Gltf.Inspectors.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Providers.OpenVR.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.InputAnimation.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Editor.Inspectors.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Editor.ServiceInspectors.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Demos.InspectorFields.Inspectors.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Tools.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Providers.ObjectMeshObserver.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.InputSimulation.Editor.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Services.InputAnimation.Editor.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.SDK.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Examples.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.SDK.Inspectors.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Demos.StandardShader.Inspectors.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Microsoft.MixedReality.Toolkit.Demos.UX.Interactables.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
dotnet build D:/Programming/Unity/RugbySimulator/RugbySimulator/MSBuild/Projects/Assembly-CSharp.csproj -p:"UnityConfiguration=%1;UnityPlatform=%2;MSBuildExtensionsPath=%~3" --no-dependencies
if %ERRORLEVEL% GEQ 1 EXIT /B 1
