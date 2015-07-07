using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	Vector3[] localpos = new [] {new Vector3 (0f, 0f, 0.73f), 
		new Vector3 (0f, 0f, -0.73f),
		new Vector3 (-0.73f, 0f, 0f), 
		new Vector3 (0.73f, 0f, 0f),
		new Vector3 (-0.5f, 0f, 0.5f), 
		new Vector3 (0.5f, 0f, -0.5f),
		new Vector3 (-0.5f, 0f, -0.5f),
		new Vector3 (0.5f, 0f, 0.5f)};
	static int ctr = 0;

	float sideways;
	float forward;
	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float speed = 5.0f;
		sideways = Input.GetAxisRaw("Horizontal");
		forward = Input.GetAxisRaw("Vertical");
		Vector3 movement = new Vector3 (sideways, 0, forward);

		GetComponent<Rigidbody>().velocity = movement * speed;

	}
	void OnCollisionEnter (Collision other) {
		if(other.gameObject.tag == "power") { 
			other.transform.parent = transform;
			other.transform.localPosition = localpos[ctr];
			ctr++;
		}
	}
}
