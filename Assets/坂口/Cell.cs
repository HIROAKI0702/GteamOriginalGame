using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public GameObject itemParent;//�A�C�e��Parent
    public string tagname;//�A�C�e���̃^�O��

    //Cell��Collider�����C�I�u�W�F�N�g���o����
    private void OnTriggerExit2D(Collider2D collision)
    {
        //�A�C�e����Cell�̃^�O�������Ȃ�
        if (collision.gameObject.tag == this.gameObject.tag)
        {
            //Cell�̍��W�ɑ�C�𕡐�����
            GameObject Block = (GameObject)Instantiate(collision.gameObject);
            Block.transform.SetParent(itemParent.transform, false);
            Block.transform.localPosition = this.transform.localPosition;

            //�O�ꂽ�A�C�e���̃^�O������������
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
