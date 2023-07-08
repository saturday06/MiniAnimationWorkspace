using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class SceneSetup
{
    [InitializeOnLoadMethod]
    private static void Execute()
    {
        EditorApplication.delayCall += () =>
        {
            Debug.Log( "projectWasLoaded" );
        };
    }
}
