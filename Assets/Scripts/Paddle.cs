using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	public bool autoPlay = false;

	private Ball ball;
	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!autoPlay){
			selfPlay();
		}else{
			AutoPlay();
		}
		// set the defealt position of paddle
	}
	void AutoPlay(){
		Vector3 paddlePos = new Vector3(0.5f,this.transform.position.y,0);
		Vector3 ballPros = ball.transform.position;
		// avoid the paddle to move out the screen.
		paddlePos.x = Mathf.Clamp(ballPros.x,.7f,15.3f);
		this.transform.position = paddlePos;
	}
	void selfPlay(){
		Vector3 paddlePos = new Vector3(0.5f,this.transform.position.y,0);
		float mousePosInBlock = Input.mousePosition.x/Screen.width*16;
		// avoid the paddle to move out the screen.
		paddlePos.x = Mathf.Clamp(mousePosInBlock,.7f,15.3f);
		this.transform.position = paddlePos;
	}
}
