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

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        vy = 0; 

        vx = speed;

        //このY座標より下へ落ちたらスタートへ戻る
        //float bottomY = Camera.main.transform.position.y
        //                    - Camera.main.orthographicSize * 2;

        //プレイヤーのY座標がbottomYより低い
        //if (gameObject.transform.position.y < bottomY)
        //{
        //    int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        //    SceneManager.LoadScene(sceneIndex);
        //}

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
