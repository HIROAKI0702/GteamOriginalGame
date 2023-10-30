
using UnityEngine;
using UnityEngine.UI;
public class PickUpItem : MonoBehaviour
{
    public Image icon;
    public GameObject removeButton;

    //Itemデータを入れる
    public Item item;
    


    void Start()
    {
        //設定したアイコンを表示させる
        GetComponent<Image>().sprite = item.icon;
    }

    //インベントリにアイテムを追加
    public void PickUp()
    {
        Inventry.instance.Add(item);
        
        //if(Input.GetMouseButton(0))
        //{
        //    Destroy(gameObject);
        //}
    }


}