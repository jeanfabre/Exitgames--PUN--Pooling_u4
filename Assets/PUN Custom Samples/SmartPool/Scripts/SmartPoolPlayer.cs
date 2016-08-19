using UnityEngine;
using System.Collections;

using ExitGames.Client.Photon;

public class SmartPoolPlayer : Photon.PunBehaviour {

	// not good as it happens too early when instance is reused.
	void OnEnable () {

		Debug.Log("SmartPoolPlayer Instance OnEnable: ownerID:"+this.photonView.ownerId+" isMine:"+this.photonView.isMine+" viewID:"+this.photonView.viewID);
	}

	// not good as it happens only the first time the instance is returned by the pool
	void Start () {

		Debug.Log("SmartPoolPlayer Instance Start: ownerID:"+this.photonView.ownerId+" isMine:"+this.photonView.isMine+" viewID:"+this.photonView.viewID);
	}

	// right time to get early information
	public override void OnPhotonInstantiate (PhotonMessageInfo info)
	{

		Debug.Log("SmartPoolPlayer Instance OnPhotonInstantiate: ownerID:"+this.photonView.ownerId+" isMine:"+this.photonView.isMine+" viewID:"+this.photonView.viewID);
	}

	
	// Update is called once per frame
	void OnDisable () {
		Debug.Log("SmartPoolPlayer Instance OnDisable\t: ownerID:"+this.photonView.ownerId+" isMine:"+this.photonView.isMine+" viewID:"+this.photonView.viewID);
	}
}
