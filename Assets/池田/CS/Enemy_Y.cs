using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Y : MonoBehaviour
{
    private Vector3 pos;
    public int num = 1;

    void Update()
    {
        pos = transform.position;

        // �i�|�C���g�j�}�C�i�X�������邱�Ƃŋt�����Ɉړ�����B
        transform.Translate(transform.up * Time.deltaTime * 6 * num);

        if (pos.y > -1)
        {
            num = -1;
        }
        if (pos.y < -10)
        {
            num = 1;
        }
    }
}