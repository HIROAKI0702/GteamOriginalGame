using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[���؂�ւ��ɕK�v

//�^�b�`����ƁA�V�[����؂芷����
public class STAGE_select01 : MonoBehaviour
{

    public string stage;//�V�[����:Inspector�Ŏw��

    void OnMouseDown()
    {
        SceneManager.LoadScene(stage);
        Time.timeScale = 1;

    }
}
