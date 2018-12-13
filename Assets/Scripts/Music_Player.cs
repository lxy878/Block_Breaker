using UnityEngine;
using System.Collections;

public class Music_Player : MonoBehaviour {
	static Music_Player instence = null;
	void Awake(){
		//Debug.Log ("Testing Wake: "+ GetInstanceID());
		// to prevent recreation of music, use the Singleton pattern, 
		//which if there is no gameObject exists, set it; otherwise, destroy the new one.
		if (instence != null) {
			Destroy(gameObject);
		}else{
			instence = this;
			GameObject.DontDestroyOnLoad(gameObject);}
	}
	// Use this for initialization
	void Start () {
		//Debug.Log ("Testing Start: "+ GetInstanceID());
	}
	// Update is called once per frame
	void Update () {
	
	}
}
