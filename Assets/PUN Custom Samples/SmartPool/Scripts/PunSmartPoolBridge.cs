using System.Collections.Generic;
using UnityEngine;
using System.Collections;

/// <summary>
/// Pun smart pool bridge.
/// Common Pitfalls:
/// -- even when using a pool managerm you need to store your prefab inside a Resources Folder, 
///    it's because PUN needs to load the prefab and assign viewIDs to all PhotonViews. Note, It's not instantiated, just loaded for analyzing.
/// -- on the instanciated prefab, use OnPhotonInstantiate() to catch info on initializating if you must, OnEnable and Start aren't suitable due to the network initializaion processes.
/// </summary>
public class PunSmartPoolBridge : MonoBehaviour, IPunPrefabPool
{
	public void Start ()
	{
	    PhotonNetwork.PrefabPool = this;
	}

    public void OnGUI()
    {
        GUILayout.Label("photonViewList " + PhotonNetwork.networkingPeer.photonViewList.Count);
    }


    public GameObject Instantiate(string prefabId, Vector3 position, Quaternion rotation)
    {
        Debug.LogWarning("Prefab: " + prefabId);
		
		GameObject go = SmartPool.Spawn(prefabId);
        go.transform.position = position;
        go.transform.rotation = rotation;

        return go;
    }

    public void Destroy(GameObject gameObject)
    {
		SmartPool.Despawn(gameObject);
       
    }
}
