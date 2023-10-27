using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public GameObject itemParent;//アイテムParent
    public string tagname;//アイテムのタグ名

    //CellのColliderから大砲オブジェクトが出たら
    private void OnTriggerExit2D(Collider2D collision)
    {
        //アイテムとCellのタグが同じなら
        if (collision.gameObject.tag == this.gameObject.tag)
        {
            //Cellの座標に大砲を複製する
            GameObject Block = (GameObject)Instantiate(collision.gameObject);
            Block.transform.SetParent(itemParent.transform, false);
            Block.transform.localPosition = this.transform.localPosition;

            //外れたアイテムのタグを書き換える
            collision.gameObject.tag = tagname;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
