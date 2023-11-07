using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// キャラクターの衝突に応じた処理　キャラクターにアタッチ
/// </summary>
public class CHECKPOINT : MonoBehaviour
{
    private Stack<Transform> _retryPointStack = new Stack<Transform>();

    private void OnTriggerEnter(Collider other)
    {
        //リトライエリアをスタックに追加
        if (other.gameObject.layer == LayerMask.NameToLayer("checkpoint"))
        {
            _retryPointStack.Push(other.gameObject.transform);
        }

        //座標を戻す
        this.gameObject.transform.position = _retryPointStack.Peek().position;
    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    //敵に接触
    //    if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
    //    {
    //        //座標を戻す
    //        this.gameObject.transform.position = _retryPointStack.Peek().position;

    //        //その他、フェードや諸々の設定を元に戻すなどのリトライ処理
    //        //元に戻したい処理が増えてくるなら、
    //        //Destroyして、Instantiateするってのもありかも
    //    }
    //}
}
