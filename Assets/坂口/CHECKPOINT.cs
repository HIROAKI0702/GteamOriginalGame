using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �L�����N�^�[�̏Փ˂ɉ����������@�L�����N�^�[�ɃA�^�b�`
/// </summary>
public class CHECKPOINT : MonoBehaviour
{
    private Stack<Transform> _retryPointStack = new Stack<Transform>();

    private void OnTriggerEnter(Collider other)
    {
        //���g���C�G���A���X�^�b�N�ɒǉ�
        if (other.gameObject.layer == LayerMask.NameToLayer("checkpoint"))
        {
            _retryPointStack.Push(other.gameObject.transform);
        }

        //���W��߂�
        this.gameObject.transform.position = _retryPointStack.Peek().position;
    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    //�G�ɐڐG
    //    if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
    //    {
    //        //���W��߂�
    //        this.gameObject.transform.position = _retryPointStack.Peek().position;

    //        //���̑��A�t�F�[�h�⏔�X�̐ݒ�����ɖ߂��Ȃǂ̃��g���C����
    //        //���ɖ߂����������������Ă���Ȃ�A
    //        //Destroy���āAInstantiate������Ă̂����肩��
    //    }
    //}
}
