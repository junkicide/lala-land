using UnityEngine;
using System.Collections;

public class cam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float speed = 5.0f;
		float sideways = Input.GetAxisRaw("Horizontal");
		Vector3 movement = new Vector3 (sideways, 0f, 0f);
		
		GetComponent<Rigidbody>().velocity = movement * speed;
	}
}
