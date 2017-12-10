using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMoveScript : MonoBehaviour {

	public float speed = 10.0f;
	float moveX = 0f;
	float moveZ = 0f;
	Rigidbody rb;

	GameManagerScript gms;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	void Update(){
		moveX = Input.GetAxis ("Horizontal") * speed;
		moveZ = Input.GetAxis ("Vertical") * speed;
		Vector3 direction = new Vector3 (moveX, 0, moveZ);
	}

	void FixedUpdate(){
		rb.velocity = new Vector3 (moveX, 0, moveZ);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "ClearJudgePoint" && gms.EnemyKills == 5) {
		}
	}
}
