using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GiveUp_Button : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("GAMEOVER");
    }
}
