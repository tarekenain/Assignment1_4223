using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public KeepData keepData;
    public Text SpeedTag;

    public float forwardForce = 8000f;
    public float sidewaysForce = 100f;
    // public float newSpeed = 100f;


    // public void ChangeSpeed()
    // {
    //     SliderScript.slider.onValueChanged.AddListener(UpdateSpeed)
    // }


    // public void UpdateSpeed()
    // {
    //     newSpeed = SliderScript.slider.value;
    //     forwardForce = forwardForce * newSpeed;
    // }


    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        forwardForce = KeepData.PlayerSpeed;

        SpeedTag.text = "Speed: " + forwardForce.ToString();

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
