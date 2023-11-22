using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//‚±‚Ìs‚ğ’Ç‹L

public class Resporn : MonoBehaviour
{
    bool resporn=false;
    public string retry;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnClick()
    {
        SceneManager.LoadScene(retry);
        Time.timeScale = 1;
    }
}
