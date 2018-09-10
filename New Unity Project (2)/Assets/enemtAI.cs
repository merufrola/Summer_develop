using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemtAI : MonoBehaviour {


public Transform target;
int randGOAL;
	// Use this for initialization
	void Start () {
// InvokeRepeating("rand",5f,5f);
	}

	// Update is called once per frame
	void Update () {

		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target - transform.position),1f);

		transform.position += transform.forward*0.1f;
Debug.Log(randGOAL);
	}
void damage(){
	Destroy(this.gameObject);
}

int rand(){
	randGOAL = Random.Range(0,3);
	return randGOAL;
}
}
