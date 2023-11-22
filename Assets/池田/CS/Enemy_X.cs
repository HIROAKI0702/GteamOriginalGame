using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_X : MonoBehaviour
{
    private Vector2 pos;
    public int num = 1;

    void Update()
    {
        pos = transform.position;

        // （ポイント）マイナスをかけることで逆方向に移動する。
        transform.Translate(transform.right * Time.deltaTime * 3 * num);
     
        if (pos.x >= 75)
        {
            num = -1;
               
        }

        if (pos.x <= 55)
        {
            num = 1;

        }


    }
}