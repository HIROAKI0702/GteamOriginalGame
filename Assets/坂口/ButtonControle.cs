using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControle : MonoBehaviour
{   
    public GameObject Retry_Button;
    public GameObject GiveUp_Button;
    public string targetObjectName1;
    public string targetObjectName2;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[���J�n���͕\�����Ȃ�
        Retry_Button.SetActive(false);
        GiveUp_Button.SetActive(false);        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�����ڕW�I�u�W�F�N�g�ɐG�ꂽ�Ȃ�I�u�W�F�N�g��\������
        if (collision.gameObject.name == targetObjectName1)
        {
            Retry_Button.SetActive(true);
            GiveUp_Button.SetActive(true);
        }
        if(collision.gameObject.name == targetObjectName2)
        {
            Retry_Button.SetActive(true);
            GiveUp_Button.SetActive(true);
        }
    }   
}
