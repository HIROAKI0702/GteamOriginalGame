using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン切り替えに必要

//タッチすると、シーンを切り換える
public class STAGE04 : MonoBehaviour
{

    public string stage04;//シーン名:Inspectorで指定

    void OnMouseDown()
    {
        SceneManager.LoadScene(stage04);

    }
}
