using UnityEngine;
using System.Collections;

public class Grime : MonoBehaviour {

	public Rigidbody2D grime;
	private float speed = -3.0f;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnGame", 3, 10);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnGame () {
		Rigidbody2D grimeInstance;

		grimeInstance = (Rigidbody2D) Instantiate (grime, new Vector3 (Random.Range (-8, 8), 7, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
		grimeInstance.name = "Grime(Clone)";
		grimeInstance.velocity = new Vector2 (0, speed);
	}

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.name == "Spongy"){
			Destroy(gameObject);
		}
	}
}
