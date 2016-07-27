using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    public Ball ball;
    [Tooltip("Speed in units per second")]
    [Range(1,100f)]
    public float speed;
    private int count;
    public Text countText;
    public Text winText;

    public void start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    public void Update()
    {
        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        ball.Move(new Vector3(h, 0f, v));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        if (count >= 1)
        {
            winText.text = "You Win!";
        }
    }
}
