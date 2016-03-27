using UnityEngine;
using System.Collections;

public class zombie_detect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Hi");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll) {


		Destroy (coll.gameObject);

		
	}
}
