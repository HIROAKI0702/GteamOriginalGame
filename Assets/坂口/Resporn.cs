using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//���̍s��ǋL

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
