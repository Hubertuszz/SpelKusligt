using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PhotonPlayer : MonoBehaviour
{

    private PhotonView pv;
    public GameObject myAvatar;
    // Start is called before the first frame update
    void Start()
    {
        pv = GetComponent<PhotonView>();
        int spawnPicker = Random.Range(0, GameSetup.gs.spawnPoints.Length);
        if (pv.IsMine)
        {
            myAvatar = PhotonNetwork.Instantiate(Path.Combine("Prefabs", "PlayerAvatar"), 
                GameSetup.gs.spawnPoints[spawnPicker].position, GameSetup.gs.spawnPoints[spawnPicker].rotation, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
