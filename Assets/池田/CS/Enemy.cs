using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    //プレイヤーオブジェクト
    public GameObject Player;
    //弾のプレハブオブジェクト
    public GameObject Enemy_Bullet;

    //一秒ごとに弾を発射するためのもの
    private float targetTime = 1.5f;
    private float currentTime = 0;
    Transform player;


    // Update is called once per frame
    void Update()
    {
        //一秒経つごとに弾を発射する
        currentTime += Time.deltaTime;
        if (targetTime < currentTime)
        {
            currentTime = -3;
            //敵の座標を変数posに保存
            var pos = this.gameObject.transform.position;
            //弾のプレハブを作成
            var t = Instantiate(Enemy_Bullet) as GameObject;
            //弾のプレハブの位置を敵の位置にする
            t.transform.position = pos;
            //敵からプレイヤーに向かうベクトルをつくる
            //プレイヤーの位置から敵の位置（弾の位置）を引く
            Vector2 vec = Player.transform.position - pos;
            //弾のRigidBody2Dコンポネントのvelocityに先程求めたベクトルを入れて力を加える
            t.GetComponent<Rigidbody2D>().velocity = vec;
        }
    }
}