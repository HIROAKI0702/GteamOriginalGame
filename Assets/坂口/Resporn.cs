using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//この行を追記

public class Resporn : MonoBehaviour
{
    bool resporn=false;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnClick()
    {
        SceneManager.LoadScene("sakaguchi");
        Time.timeScale = 1;
    }
}
