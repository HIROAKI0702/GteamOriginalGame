using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[���؂�ւ��ɕK�v

//�^�b�`����ƁA�V�[����؂芷����
public class STAGE_select01 : MonoBehaviour
{

    public string chap72main;//�V�[����:Inspector�Ŏw��

    void OnMouseDown()
    {
        SceneManager.LoadScene(chap72main);

    }
}
