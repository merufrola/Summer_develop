using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemtAI : MonoBehaviour {


public Transform target;
int randGOAL;
int flag = 0;

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
		transform.position += transform.forward*0.1f;
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
