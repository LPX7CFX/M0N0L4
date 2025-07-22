using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class BrownAreaInteraction : MonoBehaviour
{
    public GameObject brownPopup;
    public TMP_InputField inputField;
    private bool hasChecked = false;
    void Start()
    {
        brownPopup.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            brownPopup.SetActive(true);
            Debug.Log("Check");
            hasChecked = true;
        }
    }

    public void OnSubmitCommand()
    {
        string command = inputField.text.Trim().ToLower();
        if (command == "enter" && hasChecked)
        {
            SceneManager.LoadScene("Game2");
        }
    }
}