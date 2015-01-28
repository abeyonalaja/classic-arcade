using UnityEngine;
using System.Collections;

public class Spongy : MonoBehaviour {

	public float speed = 3.0f;


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
}
