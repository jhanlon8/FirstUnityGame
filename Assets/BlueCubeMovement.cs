using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCubeMovement : MonoBehaviour
{
    public float min = 2f;
    public float max = 3f;
    // Use this for initialization
    void Start()
    {

        min = transform.position.x;
        max = transform.position.x + 18;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(1f, 0, 1f);
        transform.position = new Vector3(Mathf.PingPong(Time.time * 6, max - min) + min, transform.position.y, transform.position.z);

    }
}
