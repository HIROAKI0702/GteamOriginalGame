using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private bool isObjectSelected = false;
    private Rigidbody2D rb2D; // 2DオブジェクトのRigidbody2Dコンポーネント
    private new Collider2D collider2D; // 2DオブジェクトのCollider2Dコンポーネント

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject.CompareTag("SelectableObject"))
            {
                isObjectSelected = true;
                rb2D.velocity = Vector2.zero;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isObjectSelected = false;
        }

        if (isObjectSelected)
        {
            Vector2 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rb2D.MovePosition(targetPosition);
        }
    }
}
