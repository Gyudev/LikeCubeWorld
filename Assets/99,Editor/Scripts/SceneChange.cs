using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : Editor
{
    [MenuItem("SceneChange/0.IntroScene")]
    private static void IntroScene()
    {
        EditorSceneManager.OpenScene("Assets/00.Scenes/00.Intro.unity");
    }

    [MenuItem("SceneChange/1.LobbyScene")]
    private static void MainScene()
    {
        EditorSceneManager.OpenScene("Assets/00.Scenes/01.Lobby.unity");
    }

    [MenuItem("SceneChange/2.GameScene")]
    private static void GameScene()
    {
        EditorSceneManager.OpenScene("Assets/00.Scenes/02.Game.unity");
    }
}
