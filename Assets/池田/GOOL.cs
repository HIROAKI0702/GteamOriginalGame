using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[���̐؂�ւ��ɕK�v

//�Փ˂���ƁA�V�[����؂芷����
public class GOOL : MonoBehaviour
{


    public string targetObjectName;//�ڕW�I�u�W�F�N�g��:Inspector�Ŏw��
    public string sceneName;//�V�[����:Inspector�Ŏw��

    //�Փ˂�����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�����A�Փ˂������̖̂��O���ڕW�I�u�W�F�N�g��������
        if (collision.gameObject.name == targetObjectName)
        {
            //�V�[����؂芷����
            SceneManager.LoadScene(sceneName);
        }
    }
}