using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void OnRetureClick()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
