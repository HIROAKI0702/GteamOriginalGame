using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CLEAR : MonoBehaviour
{
    int score;
    public Text SukoaText; 

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("SUKOA");
    }

    // Update is called once per frame
    void Update()
    {
        SukoaText.text = string.Format("Œo‰ßŽžŠÔ{0}•b", score);
    }
}
