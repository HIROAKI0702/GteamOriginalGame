using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playercontrol : MonoBehaviour
{
    public string targetObjectName;
    public string targetObjectName2;
    public float speed;//初期スピードを3に設定;
    
    float vx = 0;
    float vy = 0;



    private void Start()
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Time.timeScale = 0;    
        }
    }
}
