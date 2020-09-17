using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuildToGradle
{
    [MenuItem("BuildToGradle/Build")]
    public static void BuildAS()
    {
        PlayerSettings.productName = "UnityTest";
        EditorUserBuildSettings.exportAsGoogleAndroidProject = true;

        // 设置打包场景
        string launchScene = "Assets/Scenes/SampleScene.unity";

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.locationPathName = "../AndroidProject";
        buildPlayerOptions.options = BuildOptions.None;
        buildPlayerOptions.options |= BuildOptions.AcceptExternalModificationsToPlayer;
        buildPlayerOptions.scenes = new string[] { launchScene };
        buildPlayerOptions.target = BuildTarget.Android;

        // 开始打包
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
