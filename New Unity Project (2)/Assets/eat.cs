using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour {

public GameObject HMD ;
public GameObject Food;

[SerializeField]
public GameObject usagi;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.position = HMD.transform.position;
	}

	void OnTriggerEnter (Collider col) {




	switch(col.gameObject.tag){
		case "hare":
			Destroy(this.gameObject);
		    statemanager.point = statemanager.point + 5;
			break;
		case "fox" :
		Destroy(this.gameObject);
		statemanager.point = statemanager.point + 10;
		break;
		case "wolf" :
		Destroy(this.gameObject);
		statemanager.point = statemanager.point + 20;
		break;
		case "bear" :
		Destroy(this.gameObject);
		statemanager.point = statemanager.point + 40;
		break;
		case "human" :
		Destroy(this.gameObject);
		statemanager.point = statemanager.point + 900;
		break;
		case "food" :
		Destroy(this.gameObject);
		statemanager.point = statemanager.point + 1;
		break;

	}
	}
}
