using UnityEngine;
using System.Collections;

public class PlaneMovement : MonoBehaviour
{
    // The target marker.
   // public Transform ground;
    public GameObject groundObj;
    public GameObject groundObj2;

    // Speed in units per sec.
    public float speed = 5f;

    void Update()
    {
        this.transform.Translate(speed*Time.deltaTime, 0, 0);
  
        if (this.transform.position.x > 300)
        {
            Instantiate(groundObj, new Vector3(this.transform.position.x - 300, 0, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}