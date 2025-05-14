using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine.TextCore.Text;
public class CommandSystem : MonoBehaviour

{
    public TMP_InputField commandInput;
    public TMP_Text resultText;
    public float moveSpeed = 5f;
    public Animator animator;
    public Rigidbody2D Myrigidbody;

    public SpriteRenderer SpriteRenderer;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            ExecuteCommand();
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
                animator.SetFloat("speed", Mathf.Abs(Myrigidbody.linearVelocity.x));
                SpriteRenderer.flipX = Myrigidbody.linearVelocityX > 0f;

                break;
            case "walk right" or "walkright":
                Myrigidbody.linearVelocity = new Vector2(moveSpeed, 0) * Time.deltaTime;
                resultText.text = "Moving right...";
                animator.SetFloat("speed", Mathf.Abs(Myrigidbody.linearVelocity.x));
                SpriteRenderer.flipX = Myrigidbody.linearVelocityX > 0f;

                break;
            case "stop":
                Myrigidbody.linearVelocity = new Vector2(0, 0);
                resultText.text = "Stop";
                animator.SetFloat("speed", 0);
                break;
            default:
                resultText.text = "Unknown command";
                break;


        }
    }
}