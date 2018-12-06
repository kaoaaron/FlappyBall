using UnityEngine;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour
{
    // The target marker.
    // public Transform ground;
    public Transform player;
    public GameObject obj1, obj2, obj3, obj4, obj5;
    public float initDelay = 0;
    public float repDelay = 0.0005f;
    public float liveTime = 15;
    private int numObstacle = 5;
    private int random_num;
   
    void Start()
    {
        InvokeRepeating("ObjectSelector", initDelay, repDelay);
    }

    public void Cancel()
    {
        CancelInvoke();
    }

    private void ObjectSelector()
    {
        GameObject holder;
        random_num = Random.Range(1, numObstacle);

        switch (random_num)
        {
            case 1:
                holder = (GameObject)Instantiate(obj1);
                Destroy(holder, liveTime);
                break;
            case 2:
                holder = (GameObject)Instantiate(obj2);
                Destroy(holder, liveTime);
                break;
            case 3:
                holder = (GameObject)Instantiate(obj3);
                Destroy(holder, liveTime);
                break;
            case 4:
                holder = (GameObject)Instantiate(obj4);
                Destroy(holder, liveTime);
                break;
            case 5:
                holder = (GameObject)Instantiate(obj5);
                Destroy(holder, liveTime);
                break;

        }
    }

}