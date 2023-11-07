using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BLOCK_Mouse : MonoBehaviour
{
    private bool isObjectSelected = false;
    private bool objectStop = false;
    private Rigidbody2D rb2D; // 2DオブジェクトのRigidbody2Dコンポーネント
    private new Collider2D collider2D; // 2DオブジェクトのCollider2Dコンポーネント

    public string item;
    public float speed = 5;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<BoxCollider2D>();
        collider2D = GetComponent<PolygonCollider2D>();

        //Physics2D.IgnoreCollision(GetComponent<BoxCollider2D>(), GetComponent<PolygonCollider2D>());
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject.CompareTag(item))
            {
                isObjectSelected = true;
                objectStop = true;
                rb2D.velocity = Vector2.zero;
                Debug.Log("ブロックをクリック");
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isObjectSelected = false;
            //rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

        if (isObjectSelected)
        {
            Vector2 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rb2D.MovePosition(targetPosition);
        }
    }

    private void FixedUpdate()
    {
        if (!isObjectSelected && !objectStop)
        {
            transform.Translate(speed / 50, 0, 0);
        }
    }
}
