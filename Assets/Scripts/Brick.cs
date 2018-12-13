using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public AudioClip crack;
	public static int breakableCount = 0;
	public Sprite[] hitSprites;
	public GameObject smoke;
	
	private bool isBreakable;
	private int hit;
	private LevelManager levelManager;
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "breakable");
		if (isBreakable){ 
			breakableCount++; }

		levelManager = GameObject.FindObjectOfType<LevelManager>();
		hit = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D brick){
		//AudioSource.PlayClipAtPoint(crack,transform.position);
		if (isBreakable){
			TakeHit();
		}
	}

	void TakeHit(){
		hit ++;
		int maxHit = hitSprites.Length + 1;
		if(hit >= maxHit){
			breakableCount--;
			GameObject smokePuff= Instantiate (smoke, transform.position, Quaternion.identity) as GameObject;
			smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
			levelManager.BreakDestroyed();
			Destroy (gameObject);
		}else{
			LoadSprite();	
		}
	}

	void LoadSprite(){
		int hitIndex = hit - 1;
		// load the sprites by hits. Go to the component of Sprite Renderer, then load the new hit in the sprite selection.
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[hitIndex];

	}
}
