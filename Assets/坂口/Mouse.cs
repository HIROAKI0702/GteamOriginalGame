using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private bool isObjectSelected = false;//オブジェクトを選択しているかどうか
    private Transform selectedObject;//選択されたオブジェクトのTransform
    private Rigidbody2D rb2D; // 2DオブジェクトのRigidbody2Dコンポーネント


    // Update is called once per frame
    void Update()
    {
        this.GetComponent<BoxCollider2D>();

        //マウスの左ボタンがクリックされた場合
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //クリックした位置にオブジェクトがあるかどうかをチェック
            if(Physics.Raycast(ray, out hit))
            {
                //オブジェクトがクリックされた場合
                if(hit.collider.gameObject.CompareTag("SelectableObject"))
                {
                    isObjectSelected = true;
                    selectedObject = hit.collider.transform;
                }
            }
        }

        //マウスの左ボタンが離された場合
        if (Input.GetMouseButtonUp(0))
        {
            if(isObjectSelected)
            {
                isObjectSelected = false;
                selectedObject = null;
            }
        }

        //オブジェクトが選択されている場合、マウスの移動に応じてオブジェクトをドラッグ
        if(isObjectSelected)
        {
            float distanceToCamera = Vector3.Distance(selectedObject.position, Camera.main.transform.position);
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceToCamera));
            selectedObject.position = targetPosition;
        }
    }



    

}
