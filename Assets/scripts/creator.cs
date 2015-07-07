using UnityEngine;
using System.Collections;

public class creator : MonoBehaviour {
	public power powerprefab;
	// Use this for initialization
	void Start () {
		Vector3 pos1 = new Vector3 (3, 0, 4);
		Vector3 pos2 = new Vector3 (3, 0, 1);

		Instantiate (powerprefab, pos1, Quaternion.identity);
		Instantiate (powerprefab, pos2, Quaternion.identity);


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
