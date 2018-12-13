using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	// importment class paddle, if public, it needs to drag scene into the black.
	private Paddle paddle;

	private bool hasStart = false;
	private Vector3 paddleToBallVector;
	// Use this for initialization
	void Start () {
		// when it is private, using GameObject to Find Object
		paddle = GameObject.FindObjectOfType<Paddle>();
		// set cerrent position for ball
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStart){
			// moving the ball by following the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
			// langch the ball by clicking mouse
			if (Input.GetMouseButtonDown(0)){
				hasStart = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
			}
		}
	}
	void OnCollisionEnter2D(Collision2D sound){
		Vector2 tweak = new Vector2 (Random.Range (-0.1f, 0.1f), Random.Range (0f,0.2f));
		GetComponent<Rigidbody2D>().velocity += tweak;
		if(hasStart){
			GetComponent<AudioSource>().Play();}
	}
}
