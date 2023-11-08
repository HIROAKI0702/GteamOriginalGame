using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControle : MonoBehaviour
{   
    public GameObject Retry_Button;
    public GameObject GiveUp_Button;
    public string targetObjectName;

    // Start is called before the first frame update
    void Start()
    {
        //シーン開始時は表示しない
        Retry_Button.SetActive(false);
        GiveUp_Button.SetActive(false);        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //もし目標オブジェクトに触れたならオブジェクトを表示する
        if (collision.gameObject.name == targetObjectName)
        {
            Retry_Button.SetActive(true);
            GiveUp_Button.SetActive(true);
        }
    }   
}
