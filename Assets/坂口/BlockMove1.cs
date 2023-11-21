using UnityEngine;
using System.Collections;

public class BlockMove1 : MonoBehaviour
{

    private Vector3 initialPosition;
    public float speed;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 10.0f + initialPosition.x, initialPosition.y, initialPosition.z);
    }
}
