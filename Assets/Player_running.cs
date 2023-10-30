using UnityEngine;
using System.Collections;

public class Player_running : MonoBehaviour
{
	Rigidbody2D rb;
	public int moveSpeed = 2;

	void Start()
	{
		//GetComponentの処理をキャッシュしておく
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		//velocity: 速度
		//X方向へmoveSpeed分移動させる
		rb.velocity = new Vector3(moveSpeed, rb.velocity.y);
	}
}