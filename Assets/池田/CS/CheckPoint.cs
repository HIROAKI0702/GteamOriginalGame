using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//タッチすると、シーンを切り換える
public class CheckPoint : MonoBehaviour
{
    public static CheckPoint check_point_instace;
    public void Awake()
    {
        if (check_point_instace == null)
        {
            check_point_instace = this;
        }
    }
    float tmp;
    public static bool Save_Point_HIT = false;
    
    public string checkpoint;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Save_Point_HIT = true;
        //Debug.Log(Save_Point_HIT);

    }

   // Start is called before the first frame update
    void Start()
    {

    }

    public void OnClick()
    {
        SceneManager.LoadScene("CheckPoint");
        Time.timeScale = 1;

    }


}

