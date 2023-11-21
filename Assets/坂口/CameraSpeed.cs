using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpeed : MonoBehaviour
{
    float vx = 0;
    float vy = 0;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        vy = 0;
        vx = speed;
    }

    void FixedUpdate()
    {
        this.transform.Translate(vx / 50, vy / 50, 0);
    }
}
