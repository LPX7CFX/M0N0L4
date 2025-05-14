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
            hasChecked = true; // ตั้งค่า flag เป็น true เมื่อผู้เล่น check
        }
    }

    public void OnSubmitCommand()
    {
        string command = inputField.text.Trim().ToLower();
        if (command == "enter" && hasChecked) // ตรวจสอบทั้งคำสั่งและ flag
        {
            SceneManager.LoadScene("Game2");
        }
    }
}