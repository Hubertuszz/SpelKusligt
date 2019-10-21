using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarSetup : MonoBehaviour
{
    private PhotonView pv;
    public int characterValue;
    public GameObject myCharacter;
    // Start is called before the first frame update
    void Start()
    {
        pv = GetComponent<PhotonView>();
        if (pv.IsMine)
        {
            pv.RPC("RPC_AddCharacter", RpcTarget.AllBuffered, PlayerInfo.pi.selectedCharacter);
        }
    }

    [PunRPC]
    void RPC_AddCharacter(int randomCharacter)
    {
        myCharacter = Instantiate(PlayerInfo.pi.allCharacters[randomCharacter], transform.position, transform.rotation, transform);
    }
    
}
