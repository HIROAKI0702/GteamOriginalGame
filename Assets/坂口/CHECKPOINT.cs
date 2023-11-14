using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// キャラクターの衝突に応じた処理　キャラクターにアタッチ
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
