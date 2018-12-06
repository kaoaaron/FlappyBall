using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody rb;
    public GameObject obj;
    public float gravity = -300;
    public float upwardForce = 8000;
    public float sideForce = 0.01f;

    void OnCollisionEnter()
    {
        Debug.Log("Works");
    }

    void FixedUpdate () {
        rb.AddForce(0, gravity * Time.deltaTime, 0);

        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            rb.AddForce(0, upwardForce * Time.deltaTime, 0);
        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else
        {
            rb.AddForce(0, 0, sideForce * Input.acceleration.x * Time.deltaTime, ForceMode.VelocityChange);
        }

    }

   
}
