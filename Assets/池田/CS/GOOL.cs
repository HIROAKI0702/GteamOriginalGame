using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[���̐؂�ւ��ɕK�v

//�Փ˂���ƁA�V�[����؂芷����
public class GOOL : MonoBehaviour
{
    //sukoajikann.instance.score;

    public string targetObjectName;//�ڕW�I�u�W�F�N�g��:Inspector�Ŏw��
    public string sceneName;//�V�[����:Inspector�Ŏw��

    private keikajikann _keikajikann;
    private string _score;

    private void Start()
    {
        _keikajikann = FindObjectOfType<keikajikann>();
        _score = _keikajikann.GetSCORE();
    }

    //�Փ˂�����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�����A�Փ˂������̖̂��O���ڕW�I�u�W�F�N�g��������
        if (collision.gameObject.name == targetObjectName)
        {
           
            // score�̕ۑ�
            //Debug.Log("aaa");
            PlayerPrefs.SetString("SUKOA", _keikajikann.GetSCORE());
            PlayerPrefs.Save();

            //�V�[����؂芷����
            SceneManager.LoadScene(sceneName);
        }
    }

}