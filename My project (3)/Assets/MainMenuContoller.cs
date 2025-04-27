using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuController : MonoBehaviour
{
    public Animator fadeAnimator;
    public float fadeDuration = 1f;

    public void OnExitClick()
    {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void OnSettingsClick()
    {
        SceneManager.LoadScene("Settings Scene");
    }
}