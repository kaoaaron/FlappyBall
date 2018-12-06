using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    public Vector3 offset = new Vector3(5, 0.3f, 0);
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}
