using UnityEngine;
using System.Collections;

public class Player_running : MonoBehaviour
{
	Rigidbody2D rb;
	public int moveSpeed = 2;

	void Start()
	{
		//GetComponent�̏������L���b�V�����Ă���
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		//velocity: ���x
		//X������moveSpeed���ړ�������
		rb.velocity = new Vector3(moveSpeed, rb.velocity.y);
	}
}