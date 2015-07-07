using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
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
		}
	}
}
