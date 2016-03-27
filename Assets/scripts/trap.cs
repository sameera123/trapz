using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class trap : MonoBehaviour {

	public GameObject scoreText; 
	int score =0;
	public GameObject button1;
	List<GameObject> zombieList;
	public GameObject blood;
	private AudioSource source;
	public AudioClip bomb;



	// Use this for initialization
	void Start () {
		zombieList = new List<GameObject> ();
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D other){
		gameObject.GetComponent<SpriteRenderer> ().color = Color.red;

	}

	void OnTriggerEnter2D(Collider2D other) {
		zombieList.Add (other.gameObject);
		if (other.gameObject.tag == "zombie1") {

		}

		//other.gameObject.AddComponent<_2dxFX>;


	}

	void OnTriggerExit2D(Collider2D other) {
		zombieList.Remove (other.gameObject);
		gameObject.GetComponent<SpriteRenderer> ().color = Color.white;
	}

	public void DestroyZombie1(){

		for(int i=0;i<zombieList.Count;i++){
			GameObject e = zombieList[i]; 
			if(e.tag=="zombie1"){
				if(e != null){
				

					StartCoroutine(KillOnAnimationEnd(e));
					scoreText.GetComponent<Text>().text = "0"+score++;
					source.PlayOneShot(bomb,1);

				zombieList.RemoveAt(i);

					//Destroy (e);
				}
			}
		}

	}


	public void DestroyZombie2(){

		for(int i=0;i<zombieList.Count;i++){
			GameObject e = zombieList[i]; 
			if(e.tag=="zombie2"){
				if(e != null){

					StartCoroutine(KillOnAnimationEnd(e));
					zombieList.RemoveAt(i);
					scoreText.GetComponent<Text>().text = ""+score++;
					source.PlayOneShot(bomb,1);
				}
			}
		}
		
	}


	public void DestroyZombie3(){
		
		for(int i=0;i<zombieList.Count;i++){
			GameObject e = zombieList[i]; 
			if(e.tag=="zombie3"){
				if(e != null){

					StartCoroutine(KillOnAnimationEnd(e));
					zombieList.RemoveAt(i);
					scoreText.GetComponent<Text>().text = ""+score++;
					//Destroy (e);
					source.PlayOneShot(bomb,1);
				}
			}
		}
		
	}

	public void DestroyZombie4(){
		
		for(int i=0;i<zombieList.Count;i++){
			GameObject e = zombieList[i]; 
			if(e.tag=="zombie4"){
				if(e != null){

					StartCoroutine(KillOnAnimationEnd(e));
					zombieList.RemoveAt(i);
					scoreText.GetComponent<Text>().text = ""+score++;
					//Destroy (e);
					source.PlayOneShot(bomb,1);
				}
			}
		}
		
	}


	private IEnumerator KillOnAnimationEnd(GameObject g) {
		Object bllod = Instantiate (blood,g.transform.position, g.transform.rotation);
		g.GetComponent<Animator> ().SetBool ("dead", true);
		g.GetComponent<walk> ().speed = 0f;
		yield return new WaitForSeconds (1.167f);




		Destroy (g);
		Destroy (bllod);
	}


}
