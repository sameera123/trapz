using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {

	public bool voulnrable = false;
	Animator animator;
	public bool directionZombie = false;

	// Use this for initialization
	public float speed=0.5f;
	void Start () {
		animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		if (directionZombie) {
			gameObject.transform.Translate (Vector3.up * speed * Time.deltaTime);
		} else {

			gameObject.transform.Translate (Vector3.right * speed * Time.deltaTime);
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		//print (other.gameObject.name);
		voulnrable = true;
	}


	void OnTriggerExit2D(Collider2D other) {
		//print (other.gameObject.name);
		voulnrable = false;

	}

	public void distroyZombie(){
		if (voulnrable) {

			animator.SetBool("dead",true);
			StartCoroutine (KillOnAnimationEnd ());
		}

	}

	private IEnumerator KillOnAnimationEnd() {
		yield return new WaitForSeconds (1.167f);
		speed = 0f;
		Destroy (gameObject);
	}


}
