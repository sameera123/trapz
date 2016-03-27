using UnityEngine;
using System.Collections;

public class birdSpawn : MonoBehaviour {

	public GameObject bird;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("generateBird", 5f, 7.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void generateBird(){
		print ("bir");
		Object b = Instantiate (bird, new Vector3 (0.46f,-2.6f,0f), Quaternion.identity);
		KillOnAnimationEnd (b);
	}

	private IEnumerator KillOnAnimationEnd(Object g) {

		yield return new WaitForSeconds (1.167f);
		
		Destroy (g);

	}
}
