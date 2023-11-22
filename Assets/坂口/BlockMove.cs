using UnityEngine;
using System.Collections;

public class BlockMove : MonoBehaviour
{

    private Vector3 Position;
    public float speed;

    void Start()
    {
        Position = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(Position.x, Mathf.Sin(Time.time) * speed * Position.y, Position.z);
    }
}
