using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControle : MonoBehaviour
{
    private GameObject Retry_Button;
    public string targetObjectName;

    // Start is called before the first frame update
    void Start()
    {
        Retry_Button = this.gameObject;

        Retry_Button.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == targetObjectName)
        {
            Retry_Button.SetActive(true);
        }
    }
}
