using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aruki : MonoBehaviour
{
    public float speed = 3;//初期スピードを3に設定;

    float vx = 0;
    float vy = 0;
    bool leftFlag = false;
    int hp = 1;

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        vy = 0;

        vx = speed;
        leftFlag = false;
    }

    void FixedUpdate()
    {
        this.transform.Translate(vx / 50, vy / 50, 0);
        //this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    public void Dead()
    {

        if ( hp <= 0)
        {
            Destroy(gameObject);
        }
    }

}