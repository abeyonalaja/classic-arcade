using UnityEngine;
using System.Collections;

public class Spongy : MonoBehaviour {

	public  float speed = 3.0f;
	private int   lives = 3;
	private int   score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MoveCharacter ();
	}

	void MoveCharacter() {
		if(Input.GetKey (KeyCode.A)){
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.D)){
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log (coll.gameObject.name);
		if(coll.gameObject.name == "Acid(Clone)"){
			Debug.Log("HIT ACID");
			lives = lives - 1;

			if(lives == 0){
				Debug.Log("LIVES IS 0");
				Time.timeScale = 0;
			}
		}

		if(coll.gameObject.name == "Grime(Clone)"){
			score = score + 50;
		}
	}

	void OnGUI() {
		GUI.Box (new Rect(10, 10, 100, 30), "Time: "+Time.time);
		GUI.Box (new Rect(500, 10, 100, 30), "Score: "+score);
		GUI.Box (new Rect (600, 10, 100, 30), "Lives: " + lives);
	}
}
