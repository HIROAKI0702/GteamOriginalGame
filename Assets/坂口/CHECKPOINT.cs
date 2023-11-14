using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// �L�����N�^�[�̏Փ˂ɉ����������@�L�����N�^�[�ɃA�^�b�`
/// </summary>
public class CHECKPOINT : MonoBehaviour
{
    public GameObject Point;
    public string targetObjectName;

    Vector3 pos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            pos = Point.transform.position;
        }
    }

}
