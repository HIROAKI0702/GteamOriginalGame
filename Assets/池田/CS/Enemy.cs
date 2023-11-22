using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    //�v���C���[�I�u�W�F�N�g
    public GameObject Player;
    //�e�̃v���n�u�I�u�W�F�N�g
    public GameObject Enemy_Bullet;

    //��b���Ƃɒe�𔭎˂��邽�߂̂���
    private float targetTime = 1.5f;
    private float currentTime = 0;
    Transform player;


    // Update is called once per frame
    void Update()
    {
        //��b�o���Ƃɒe�𔭎˂���
        currentTime += Time.deltaTime;
        if (targetTime < currentTime)
        {
            currentTime = -3;
            //�G�̍��W��ϐ�pos�ɕۑ�
            var pos = this.gameObject.transform.position;
            //�e�̃v���n�u���쐬
            var t = Instantiate(Enemy_Bullet) as GameObject;
            //�e�̃v���n�u�̈ʒu��G�̈ʒu�ɂ���
            t.transform.position = pos;
            //�G����v���C���[�Ɍ������x�N�g��������
            //�v���C���[�̈ʒu����G�̈ʒu�i�e�̈ʒu�j������
            Vector2 vec = Player.transform.position - pos;
            //�e��RigidBody2D�R���|�l���g��velocity�ɐ�����߂��x�N�g�������ė͂�������
            t.GetComponent<Rigidbody2D>().velocity = vec;
        }
    }
}