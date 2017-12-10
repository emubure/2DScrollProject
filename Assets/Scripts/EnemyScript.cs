using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	GameManagerScript gms;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			//gms.EnemyKills += 1;
			Destroy (gameObject);
		}
	}
}
