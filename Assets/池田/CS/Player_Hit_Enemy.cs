using UnityEngine;

using System.Collections;
 using UnityEngine.SceneManagement;//�V�[���̐؂�ւ��ɕK�v

 
public class Player_Hit_Enemy : MonoBehaviour

{

    private string enemyTag = "Enemy";

    private void OnCollisionEnter2D(Collision2D collision)

    {

        if (collision.collider.tag == enemyTag)

        {

            Debug.Log("gameover");

        }

    }



}