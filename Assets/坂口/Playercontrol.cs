using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playercontrol : MonoBehaviour
{
    public float speed = 3;//初期スピードを3に設定;

    float vx = 0;
    float vy = 0;
    bool leftFlag = false;

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        vy = 0; 

        vx = speed;
        leftFlag = false;

        //このY座標より下へ落ちたらスタートへ戻る
        float bottomY = Camera.main.transform.position.y
                        - Camera.main.orthographicSize * 2;

        //忍者のY座標がbottomYより低い
        if (gameObject.transform.position.y < bottomY)
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }

    }

    void FixedUpdate()
    {
        this.transform.Translate(vx / 50, vy / 50, 0);
        //this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
