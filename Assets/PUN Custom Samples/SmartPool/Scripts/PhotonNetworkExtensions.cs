using UnityEngine;
using System.Collections;

/// <summary>
/// Photon network extensions.
/// WARNING: this we can't extends static classes, it's not technically extensions but rather composisions.
/// </summary>
public static class PhotonNetworkExtensions  {


	public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, int group,bool usePrefabPool = false)
	{
		return Instantiate(prefabName, position, rotation, group, null,usePrefabPool);
	}

	public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, int group,  object[] data, bool usePrefabPool = false)
	{
		
		IPunPrefabPool _prefabPool = null;
		
		if (! usePrefabPool)
		{
			_prefabPool = PhotonNetwork.PrefabPool;
			PhotonNetwork.PrefabPool = null;
		}
		
		GameObject _instance = PhotonNetwork.Instantiate(prefabName, position, rotation, group, data);
		
		if (! usePrefabPool)
		{
			PhotonNetwork.PrefabPool = _prefabPool;
		}

		return _instance;
	}
}