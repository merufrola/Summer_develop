﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour {


public Transform target;
int randGOAL;
int flag = 0;

[SerializeField]
public GameObject bear;

[SerializeField]
public GameObject fox;

	// Use this for initialization
	void Start () {
// InvokeRepeating("rand",5f,5f);

target = GameObject.Find("foodsencer").transform;
	}

	// Update is called once per frame
	void Update () {
if(flag == 0){
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position-transform.position),1f);

		transform.position += transform.forward*0.1f;
	}
	else if(flag == 1){
		switch(transform.tag){
			case "fox" :
			case "bear" :
			transform.position -= transform.forward*0.1f;
			break;

			case "hare" :
			case "wolf" :
			case "human" :


		transform.position += transform.forward*0.1f;
		break;
		}
	}


Ray ray = new Ray(transform.position, transform.forward);
RaycastHit hit;
if(Physics.Raycast(ray, out hit, 10.0f)){
	if(hit.collider.tag == "ME"){

	float dis = hit.distance;
		if(dis<4){
			flag = 1;
		}
}

}





Invoke("damage",10f);


	}
void damage(){
	Destroy(this.gameObject);
}

int rand(){
	randGOAL = Random.Range(0,3);
	return randGOAL;
}

void OnTriggerEnter(Collider col){
	if(col.gameObject.tag == "grab"){
		switch(transform.tag){
			case "hare":
			if(statemanager.haregrab){
				SendMessage("Grab");
			}
			break;

			case "fox":
			if(statemanager.foxgrab){
				SendMessage("Grab");
			}
			break;

			case "wolf":
			if(statemanager.wolfgrab){
				SendMessage("Grab");
			}
			break;

			case "bear":
			if(statemanager.beargrab){
				SendMessage("Grab");
			}
			break;

			case "human":
			if(statemanager.humangrab){
				SendMessage("Grab");
			}
			break;
		}
	}
}

}
