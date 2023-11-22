using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CLEAR : MonoBehaviour
{ 
    string score;
    public Text SukoaText; 

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetString("SUKOA");
    }

    // Update is called once per frame
    void Update()
    {
        SukoaText.text = string.Format("Œo‰ßŽžŠÔ{0}", score);
        
    }
}
