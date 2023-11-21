using UnityEngine;
using System.Collections;

public class BlockMove : MonoBehaviour
{

    private Vector3 initialPosition;
    public float speed;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(initialPosition.x, Mathf.Sin(Time.time) * speed * initialPosition.y, initialPosition.z);
    }
}
