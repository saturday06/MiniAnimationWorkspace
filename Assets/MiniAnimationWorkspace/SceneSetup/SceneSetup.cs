using UnityEditor;
using UnityEditor.SceneManagement;
using System.Linq;

public static class SceneSetup
{
    [InitializeOnLoadMethod]
    private static void Execute()
    {
        EditorApplication.delayCall += () =>
        {
            var currentScene = EditorSceneManager.GetActiveScene();
            if (!string.IsNullOrEmpty(currentScene.name))
            {
                return;
            }
            var scene = EditorBuildSettings.scenes.OrderBy(scene => scene.enabled).FirstOrDefault();
            if (scene == null){
                return;
            }
            EditorSceneManager.OpenScene(scene.path);
        };
    }
}
