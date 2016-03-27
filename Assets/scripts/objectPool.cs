using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class objectPool : MonoBehaviour {

	public GameObject zombie1;
	public List<GameObject> zombieList;
	public List<Vector3> positionList;
	float speed = 0.5f;
	float genInterval = 2f;
	public GameObject score;

	// Use this for initialization
	void Start () {

		Vector3 pos1 = new Vector3 (-5.356f,-4.269f,0f);
		Vector3 pos2 = new Vector3 (-4.164f,-4.273f,0f);
		Vector3 pos3 = new Vector3 (-2.999f,-4.159f,0f);
		Vector3 pos4 = new Vector3 (-1.53f,-4.17f,0f);
		positionList.Add (pos1);
		positionList.Add (pos2);
		positionList.Add (pos3);
		positionList.Add (pos4);

		Invoke ("generateZombie", 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void generateZombie(){
	

		int currentScore = System.Int32.Parse(score.GetComponent<Text> ().text);
		if(currentScore % 5 == 0){
			increaseDifficulty();
		}
		GameObject zombie = zombieList[randomZombie()];
		zombie.GetComponent<walk> ().speed = speed;
		Instantiate (zombie,positionList[randomPos()], zombie.transform.rotation);
		Invoke("generateZombie",genInterval);
	}

	int randomZombie(){
		int z =Random.Range (0, 4); 
		print (z);
		return z;
		
	}

	int randomPos(){
		return Random.Range (0, 4);
	}

	void increaseDifficulty(){
		speed += 0.05f;
		if (genInterval > 0.5f) {
			genInterval -= 0.05f;
		}

	}





}
