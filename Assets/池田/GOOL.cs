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
    private int _score;

    private void Start()
    {
        //_keikajikann = FindObjectOfType<keikajikann>();
        //_score = _keikajikann.GetSCORE();
    }

    //�Փ˂�����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("a");
        //�����A�Փ˂������̖̂��O���ڕW�I�u�W�F�N�g��������
        if (collision.gameObject.name == targetObjectName)
        {
           
            // score�̕ۑ�
            Debug.Log("b");
            //PlayerPrefs.SetInt("SUKOA", _keikajikann.GetSCORE());
            //PlayerPrefs.Save();

            //�V�[����؂芷����
            SceneManager.LoadScene(sceneName);
        }
    }

}