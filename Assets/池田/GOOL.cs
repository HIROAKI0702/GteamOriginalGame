using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンの切り替えに必要

//衝突すると、シーンを切り換える
public class GOOL : MonoBehaviour
{
    //sukoajikann.instance.score;

    public string targetObjectName;//目標オブジェクト名:Inspectorで指定
    public string sceneName;//シーン名:Inspectorで指定

    private result_time _Result_time;
    private string _score;

    private void Start()
    {
        _Result_time = FindObjectOfType<result_time>();
        _score = _Result_time.GetSCORE();
    }

    //衝突した時
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("a");
        //もし、衝突したものの名前が目標オブジェクトだったら
        if (collision.gameObject.name == targetObjectName)
        {
           
            // scoreの保存
            //Debug.Log("b");
            PlayerPrefs.SetString("SCORE", _Result_time.GetSCORE());
            PlayerPrefs.Save();

            //シーンを切り換える
            SceneManager.LoadScene(sceneName);
        }
    }

}