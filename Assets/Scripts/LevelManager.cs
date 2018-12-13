using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	// to use the function, it needs "public"
	public void LoadLevel(string name){
		Brick.breakableCount = 0;
		// to make connection between scenes
		Debug.Log("Level load requested for: "+ name);
		Application.LoadLevel(name);
	}
	public void QuitRequest(string name){
		Debug.Log("Quit request for: "+name);
		// It works on pc and console, but it is difficult to be effective 
		//for web, debug model and apps on applestore and android.
		Application.Quit();
	}
	private void LoadNextLevel(){
		Brick.breakableCount =0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void BreakDestroyed(){
		if(Brick.breakableCount <= 0){ LoadNextLevel();}
	}
}
