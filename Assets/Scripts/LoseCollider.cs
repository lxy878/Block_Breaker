using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	// declear a object as levelmanager.
	private LevelManager levelMangager;

	// when only two objects are collision/non-trigger, it will excute the collision function.
	void OnCollisionEnter2D(Collision2D collision){
		print ("Collision");
	}
	// when two objects are either trigger or both, it will exctue the trigger function.
	void OnTriggerEnter2D(Collider2D trigger){
		levelMangager = GameObject.FindObjectOfType<LevelManager>();
		print ("Trigger");
		levelMangager.LoadLevel("Lose");
	}
}
