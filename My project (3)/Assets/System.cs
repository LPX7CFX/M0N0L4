using UnityEngine;
using UnityEngine.UI;

public class PlayerCommand2D : MonoBehaviour
{
    public InputField commandInput;
    public Text resultText;
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ตรวจสอบว่าตัวละครอยู่บนพื้นหรือไม่ (สำหรับการกระโดด)
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
    }

    public void ExecuteCommand()
    {
        string command = commandInput.text.ToLower().Trim();

        switch (command)
        {
            case "walk left":
                rb.linearVelocity = new Vector2(-moveSpeed, rb.linearVelocity.y);
                resultText.text = "Moving left...";
                break;
            case "walk right":
                rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);
                resultText.text = "Moving right...";
                break;
            case "jump":
                if (isGrounded)
                {
                    rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                    resultText.text = "Jumped!";
                }
                else
                {
                    resultText.text = "Not grounded!";
                }
                break;
            case "stop":
                rb.linearVelocity = Vector2.zero;
                resultText.text = "Stopped.";
                break;
            default:
                resultText.text = "Unknown command! Try: walk left, walk right, jump, stop";
                break;
        }

        commandInput.text = "";
    }
}