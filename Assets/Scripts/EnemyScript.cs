using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	GameManagerScript gms;

	// Use this for initialization
	void Start () {
		
	}
	
	void EnemyDestroy(){
		Destroy (gameObject);
	}
}
