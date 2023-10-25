using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resporn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //このY座標より下へ落ちたらスタートへ戻る
        float bottomY = Camera.main.transform.position.y 
                        - Camera.main.orthographicSize * 2;

        //忍者のY座標がbottomYより低い
        if(gameObject.transform.position.y < bottomY)
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
