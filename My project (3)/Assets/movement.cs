using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;
using Unity.VisualScripting;
public class CommandSystem : MonoBehaviour

{
    public TMP_InputField commandInput;
    public TMP_Text resultText;
    public float moveSpeed = 5f;

    public Rigidbody2D Myrigidbody;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (commandInput.isFocused)
            {
                ExecuteCommand();
            }
        }
    }

    public void ExecuteCommand()
    {

        string command = commandInput.text.ToLower().Trim();

        switch (command)
        {
            case "walk left" or "walkleft":
                Myrigidbody.linearVelocity = new Vector2(-moveSpeed, 0) * Time.deltaTime;
                resultText.text = "Moving left...";

                break;
            case "walk right" or "walkright":
                Myrigidbody.linearVelocity = new Vector2(moveSpeed, 0) * Time.deltaTime;
                resultText.text = "Moving right...";
                break;
            case "stop":
                Myrigidbody.linearVelocity = new Vector2(0, 0);
                resultText.text = "Stop";

                break;
            default:
                resultText.text = "Unknown command";
                break;


        }
    }
}