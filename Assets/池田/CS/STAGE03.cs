using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[���؂�ւ��ɕK�v

//�^�b�`����ƁA�V�[����؂芷����
public class STAGE03 : MonoBehaviour
{

    public string stage03;//�V�[����:Inspector�Ŏw��

    void OnMouseDown()
    {
        SceneManager.LoadScene(stage03);

    }
}
