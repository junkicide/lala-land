﻿using UnityEngine;
using System.Collections;

public class creator : MonoBehaviour {
	public power powerprefab;
	// Use this for initialization
	void Start () {
		Vector3 pos1 = new Vector3 (Random.Range(-8,9), 0, Random.Range (-4, 5));
		Vector3 pos2 = new Vector3 (Random.Range(-8,9), 0, Random.Range (-4, 5));
		Vector3 pos3 = new Vector3 (Random.Range(-8,9), 0, Random.Range (-4, 5));
		Vector3 pos4 = new Vector3 (Random.Range(-8,9), 0, Random.Range (-4, 5));
		Vector3 pos5 = new Vector3 (Random.Range(-8,9), 0, Random.Range (-4, 5));
		Vector3 pos6 = new Vector3 (Random.Range(-8,9), 0, Random.Range (-4, 5));
		Vector3 pos7 = new Vector3 (Random.Range(-8,9), 0, Random.Range (-4, 5));
		Vector3 pos8 = new Vector3 (Random.Range(-8,9), 0, Random.Range (-4, 5));



		Instantiate (powerprefab, pos1, Quaternion.identity);
		Instantiate (powerprefab, pos2, Quaternion.identity);
		Instantiate (powerprefab, pos3, Quaternion.identity);
		Instantiate (powerprefab, pos4, Quaternion.identity);
		Instantiate (powerprefab, pos5, Quaternion.identity);
		Instantiate (powerprefab, pos6, Quaternion.identity);
		Instantiate (powerprefab, pos7, Quaternion.identity);
		Instantiate (powerprefab, pos8, Quaternion.identity);



	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
