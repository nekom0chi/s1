using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

/*
 �Q���A�ޏo�m�F
 */

public class RoomManager : MonoBehaviourPunCallbacks
{
    // ���[���Ƀv���C���[���������Ƃ��ɌĂ΂��
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(newPlayer.NickName + " �����[���ɓ����Ă��܂����I");
    }

    // ���ɂ��A�v���C���[���ޏo�������Ȃǂ̏������\
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.Log(otherPlayer.NickName + " �����[������ޏo���܂����I");
    }
}
