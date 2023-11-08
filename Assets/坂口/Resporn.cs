using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//‚±‚Ìs‚ğ’Ç‹L

public class Resporn : MonoBehaviour
{

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
