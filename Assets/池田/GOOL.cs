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

    private result_time _Result_time;
    private string _score;

    private void Start()
    {
        _Result_time = FindObjectOfType<result_time>();
        _score = _Result_time.GetSCORE();
    }

    //�Փ˂�����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("a");
        //�����A�Փ˂������̖̂��O���ڕW�I�u�W�F�N�g��������
        if (collision.gameObject.name == targetObjectName)
        {
           
            // score�̕ۑ�
            //Debug.Log("b");
            PlayerPrefs.SetString("SCORE", _Result_time.GetSCORE());
            PlayerPrefs.Save();

            //�V�[����؂芷����
            SceneManager.LoadScene(sceneName);
        }
    }

}