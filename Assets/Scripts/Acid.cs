using UnityEngine;
using System.Collections;

public class Acid : MonoBehaviour {

	public Rigidbody2D acid;
	public GameObject SpongyObj;

	private float speed = -3.0f;
	

	// Use this for initializationjg028
	void Start () {
		InvokeRepeating ("SpawnAcid", 3, 5);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void SpawnAcid() {
		Rigidbody2D acidInstance;

		acidInstance = (Rigidbody2D)Instantiate (acid, new Vector3 (Random.Range (-8, 8), 7, 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
		acidInstance.name = "Acid(Clone)";

		acidInstance.velocity = new Vector2 (0, speed);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if(coll.gameObject.name == "Spongy") {
			Destroy(gameObject);
		}

		if(coll.gameObject.name == "Bottom") {
			Destroy(gameObject);
		}
	}
}
