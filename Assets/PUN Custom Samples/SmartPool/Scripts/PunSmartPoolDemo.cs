using UnityEngine;
using System.Collections;

using ExitGames.Client.Photon;

public class PunSmartPoolDemo: Photon.PunBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public override void OnJoinedRoom ()
	{
		PhotonNetwork.Instantiate("SmartPoolPlayer", new Vector3(0f,0f,0f), Quaternion.identity, 0);
	}

}
