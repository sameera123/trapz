using UnityEngine;
using System.Collections;

public class birdfly : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (Vector3.left * 2f * Time.deltaTime);
	}
}
