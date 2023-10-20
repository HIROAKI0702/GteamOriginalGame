using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private bool isObjectSelected = false;//�I�u�W�F�N�g��I�����Ă��邩�ǂ���
    private Transform selectedObject;//�I�����ꂽ�I�u�W�F�N�g��Transform
    private Rigidbody2D rb2D; // 2D�I�u�W�F�N�g��Rigidbody2D�R���|�[�l���g


    // Update is called once per frame
    void Update()
    {
        this.GetComponent<BoxCollider2D>();

        //�}�E�X�̍��{�^�����N���b�N���ꂽ�ꍇ
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //�N���b�N�����ʒu�ɃI�u�W�F�N�g�����邩�ǂ������`�F�b�N
            if(Physics.Raycast(ray, out hit))
            {
                //�I�u�W�F�N�g���N���b�N���ꂽ�ꍇ
                if(hit.collider.gameObject.CompareTag("SelectableObject"))
                {
                    isObjectSelected = true;
                    selectedObject = hit.collider.transform;
                }
            }
        }

        //�}�E�X�̍��{�^���������ꂽ�ꍇ
        if (Input.GetMouseButtonUp(0))
        {
            if(isObjectSelected)
            {
                isObjectSelected = false;
                selectedObject = null;
            }
        }

        //�I�u�W�F�N�g���I������Ă���ꍇ�A�}�E�X�̈ړ��ɉ����ăI�u�W�F�N�g���h���b�O
        if(isObjectSelected)
        {
            float distanceToCamera = Vector3.Distance(selectedObject.position, Camera.main.transform.position);
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceToCamera));
            selectedObject.position = targetPosition;
        }
    }



    

}
