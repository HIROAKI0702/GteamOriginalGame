using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aruki : MonoBehaviour
{
    public static aruki aruki_instace;
    public void Awake()
    {
        if (aruki_instace == null)
        {
            aruki_instace = this;
        }
    }
    public float speed = 3;//初期スピードを3に設定;

    //static float vx = 0;

    //static float vy = 0;
    public Vector2 playerVector = new Vector2(0, 0);
    

    bool leftFlag = false;
    int hp = 1;

    private void Start()
    {
        //Debug.Log(GameObject.Find("player").transform.position);
        //if (CheckPoint.Save_Point_HIT == true)
        //{
        //    Debug.Log(GameObject.Find("player").transform.position);
        //    Vector2 tmp = GameObject.Find("CheckPoint").transform.position;
        //    GameObject.Find("player").transform.position = new Vector2(tmp.x, tmp.y);
        //    Debug.Log(GameObject.Find("player").transform.position);
        //    CheckPoint.Save_Point_HIT = false;
        //    //aruki.playerVector.x = tmp.x;
        //    //aruki.playerVector.y = tmp.y;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //playerVector.x = 0;
        //playerVector.y = 0;

        playerVector.x = speed;
        leftFlag = false;
    }

    void FixedUpdate()
    {
        this.transform.Translate(playerVector.x / 50, playerVector.y / 50, 0);
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