using UnityEngine;

public class MobileNetwork : Photon.PunBehaviour {


    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("0.1");
        //PhotonNetwork.JoinRandomRoom();
    }
    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }
    public override void OnJoinedLobby()
    {
        //PhotonNetwork.CreateRoom(null);
        Debug.Log("done");
        PhotonNetwork.JoinRandomRoom();
    }

    // TODO-2.a: the same as 1.b
    //   and join a room


    public override void OnJoinedRoom()
    {
        GetComponent<MobileShooter>().Activate();
    }


}
